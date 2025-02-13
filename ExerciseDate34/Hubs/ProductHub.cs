using Microsoft.AspNetCore.SignalR;

public class ProductHub : Hub{

  ProductService _productService;
  public ProductHub(ProductService productService){
    _productService = productService;
  }

  public override async Task OnConnectedAsync(){
    Console.WriteLine($"Connected client-id: {Context.ConnectionId}");
    
    await base.OnConnectedAsync();
    _productService.GetAllProductApi();
    await Clients.All.SendAsync("GetAllProduct", _productService.lstProduct);
  }

  public async Task AddNewProduct(ProductAddNew productAddNew){
    await _productService.AddNewProduct(productAddNew);
    _productService.GetAllProductApi();
    await Clients.All.SendAsync("GetAllProduct", _productService.lstProduct);
  }

  public override async Task OnDisconnectedAsync(Exception? ex){
    Console.WriteLine($"Disconnected client-id: {Context.ConnectionId}");
    await base.OnDisconnectedAsync(ex);
  }
}