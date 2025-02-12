using ExerciseDate32.Models;
using ExerciseDate32.ViewModels;
namespace ExerciseDate32.Services;
public class StoreService
{
  public List<StoreVM> lstStores = new List<StoreVM>();

  public StoreVM storeDetail = new StoreVM();
  public HttpClient _httpClient;
  public StoreService(HttpClient httpClient)
  {
    _httpClient = httpClient;
  }

  public async void GetAllStoreApi()
  {
    //URL gốc của API
    var url = "https://apistore.cybersoft.edu.vn/api/Store/getAll";
    var res = await _httpClient.GetFromJsonAsync<HTTPResponse<List<StoreVM>>>(url);
    lstStores = res.content;
    SetStateHasChange();
  }


  public async void GetStoreByIdApi(string id)
  {
    if (!string.IsNullOrEmpty(id))
    {
      // URL gốc của API
      var url = $"https://apistore.cybersoft.edu.vn/api/Store/getbyid?id={id}";
      var res = await _httpClient.GetFromJsonAsync<HTTPResponse<StoreVM>>(url);
      storeDetail = res.content;
    }
    SetStateHasChange();
  }

  public async Task<string> UpdateStoreApi(string id)
  {
    // URL gốc của API
    var url = $"https://apistore.cybersoft.edu.vn/api/Store?id={id}";
    var res = await _httpClient.PutAsJsonAsync(url, storeDetail);
    var response = await res.Content.ReadFromJsonAsync<HTTPResponse<string>>();
     GetAllStoreApi();
    SetStateHasChange();
    return response.content;
  }


  public async Task<string> AddNewStore(CreateStoreVM model)
  {
    // URL gốc của API
    var url = $"https://apistore.cybersoft.edu.vn/api/Store";
    var res = await _httpClient.PostAsJsonAsync(url, model);
    var response = await res.Content.ReadFromJsonAsync<HTTPResponse<string>>();
    GetAllStoreApi();
    SetStateHasChange();
    return response.content;
  }

  public async Task<string> DeleteStoreByIdApi(string id)
  {
    if (!string.IsNullOrEmpty(id))
    {
      // URL gốc của API
      var url = $"https://apistore.cybersoft.edu.vn/api/Store/{id}";
      var res = await _httpClient.DeleteFromJsonAsync<HTTPResponse<string>>(url);
      SetStateHasChange();
      GetAllStoreApi();

      return res.content;
    }
    return null;
  }

  public event Action OnChange;

  public void SetStateHasChange() => OnChange?.Invoke();

}