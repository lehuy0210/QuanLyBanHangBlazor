using System.Net.Http.Json;
using QLBH.DTO;

namespace QLBH.WEB.Services
{
    public class ProductService
    {
        private readonly HttpClient _http;
        public ProductService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<ProductDTO>> GetProductsAsync()
        {
            return await _http.GetFromJsonAsync<List<ProductDTO>>("api/Product");
        }

        public async Task<bool> CreateProductAsync(ProductDTO sp)
        {
            var response = await _http.PostAsJsonAsync("api/Product", sp);
            return response.IsSuccessStatusCode;
        }

        public async Task<List<CategoryDTO>> GetCategoriesAsync()
        {
            return await _http.GetFromJsonAsync<List<CategoryDTO>>("api/Product/categories");
        }

        public async Task<List<SupplierDTO>> GetSuppliersAsync()
        {
            return await _http.GetFromJsonAsync<List<SupplierDTO>>("api/Product/suppliers");
        }


    }
}
