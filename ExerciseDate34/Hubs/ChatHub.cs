
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.SignalR;

public class ChatHub : Hub
{
  private static readonly Dictionary<string, List<string>> chatRooms = new Dictionary<string, List<string>>();
  private static readonly Dictionary<string, string> connectedUsers = new Dictionary<string, string>(); //Lưu connectionId -> Username

  public override async Task OnConnectedAsync()
  {
    string connectionId = Context.ConnectionId;
    connectedUsers[connectionId] = "Guest"; // Mặc định là "Guest" cho đến khi user nhập tên
                                            // Gửi phản hồi lại cho chính client đã gọi phương thức
    await Clients.All.SendAsync("Connected", connectionId);
    await base.OnConnectedAsync();
  }

  public override async Task OnDisconnectedAsync(Exception? exception){
    string connectionId = Context.ConnectionId;

    if(connectedUsers.TryGetValue(connectionId, out string? userName)){
      foreach(var room in chatRooms){
        if(room.Value.Contains(userName)){
          room.Value.Remove(userName);
          await Clients.Group(room.Key).SendAsync("UserLeft", userName, room.Key);
        }
      }
      connectedUsers.Remove(connectionId);
    }
    await base.OnDisconnectedAsync(exception);
  }

  public async Task CreateRoom(string roomName){
    if(!chatRooms.ContainsKey(roomName)){
      chatRooms[roomName] = new List<string>();
      await Clients.All.SendAsync("RoomCreated", roomName);
    }
  }

  public async Task JoinRoom(string roomName, string user){
    if(chatRooms.ContainsKey(roomName)){
      chatRooms[roomName].Add(user);
      connectedUsers[Context.ConnectionId] = user;

      await Groups.AddToGroupAsync(Context.ConnectionId, roomName);
      await Clients.Group(roomName).SendAsync("UserJoined", user, roomName);
    }
  }

  public async Task SendMessage(string roomName, string user, string message){
    await Clients.Group(roomName).SendAsync("ReceiveMessage", user, message);
  }

}