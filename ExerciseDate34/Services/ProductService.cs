public class ProductService
{
   public List<ProductVM> lstProduct = new List<ProductVM>();
    public string resAddProduct { get; set; } = "";

   HttpClient _httpClient;
   public ProductService(HttpClient httpClient)
   {
      _httpClient = httpClient;
   }

   public async void GetAllProductApi()
   {
      // URL gốc của API
      var url = "https://apistore.cybersoft.edu.vn/api/Product";
      var res = await _httpClient.GetFromJsonAsync<HTTPResponse<List<ProductVM>>>(url);
      lstProduct = res.content;
      SetStateHasChange();
   }

   public async Task<string> AddNewProduct(ProductAddNew model){
      //URL gốc của API
      string url = $"https://apistore.cybersoft.edu.vn/api/Product/addNew";
      HttpResponseMessage res = await _httpClient.PostAsJsonAsync(url, model);
      var response = await res.Content.ReadFromJsonAsync<HTTPResponse<string>>();
      resAddProduct = response.content;
      SetStateHasChange();
      return response.content;
   }

   public event Action OnChange;

   public void SetStateHasChange() => OnChange?.Invoke();
}