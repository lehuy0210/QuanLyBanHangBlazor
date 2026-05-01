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


    }
}
