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

        public async Task<bool> DeleteProductAsync(int id)
        {
            var response = await _http.DeleteAsync($"api/Product/{id}");
            return response.IsSuccessStatusCode;
        }

        public async Task<ProductDTO> GetProductByIdAsync(int id)
        {
            return await _http.GetFromJsonAsync<ProductDTO>($"api/Product/{id}");
        }

        public async Task<bool> UpdateProductAsync(int id, ProductDTO sp)
        {
            var response = await _http.PutAsJsonAsync($"api/Product/{id}", sp);
            return response.IsSuccessStatusCode;
        }

    }
}
