using GeekShopping.Web.Models;
using GeekShopping.Web.Services.IServices;
using GeekShopping.Web.Utils;

namespace GeekShopping.Web.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;
        public const string basePath = "api/Product";

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public async Task<ProductModel> Create(ProductModel product)
        {
            var response = await _httpClient.PostAsJson(basePath, product);
            if (!response.IsSuccessStatusCode) throw new Exception("Something went wrong when calling the API!");
            return await response.ReadContentAs<ProductModel>();
        }

        public async Task<bool> DeleteById(long id)
        {
            var response = await _httpClient.DeleteAsync($"{basePath}/{id}");
            if (!response.IsSuccessStatusCode) throw new Exception("Something went wrong when calling the API!");
            return await response.ReadContentAs<bool>();
        }

        public async Task<IEnumerable<ProductModel>> FindAllProducts()
        {
            var response = await _httpClient.GetAsync(basePath);
            Console.WriteLine(_httpClient.BaseAddress);
            return await response.ReadContentAs<List<ProductModel>>();
        }

        public async Task<ProductModel> FindById(long id)
        {
            var response = await _httpClient.GetAsync($"{basePath}/{id}");
            return await response.ReadContentAs<ProductModel>();
        }

        public async Task<ProductModel> Update(ProductModel product)
        {
            var response = await _httpClient.PutAsJson(basePath, product);
            if (!response.IsSuccessStatusCode) throw new Exception("Something went wrong when calling the API!");
            return await response.ReadContentAs<ProductModel>();
        }
    }
}
