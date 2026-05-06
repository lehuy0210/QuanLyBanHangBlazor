using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Text.Json.Serialization; 
using Newtonsoft.Json;

namespace QLBH.DTO
{
    public class ProductDTO
    {
        [JsonPropertyName("ProductID")]
        [JsonProperty("ProductID")]
        public int Id { get; set; }
        [JsonPropertyName("ProductName")]
        [JsonProperty("ProductName")]
        public string Name { get; set; }
        [JsonPropertyName("UnitPrice")]
        [JsonProperty("UnitPrice")]
        public decimal Price { get; set; }
        [JsonPropertyName("QuantityPerUnit")]
        [JsonProperty("QuantityPerUnit")]
        public string Quantity { get; set; }

        [JsonProperty("CategoryID")]
        [JsonPropertyName("CategoryID")]
        public int CateId { get; set; }

        [JsonProperty("SupplierID")]
        [JsonPropertyName("SupplierID")]
        public int SupId { get; set; }

        [JsonProperty("UnitsInStock")]
        [JsonPropertyName("UnitsInStock")]
        public int UnitsInStock { get; set; }

        [JsonProperty("CategoryName")]
        [JsonPropertyName("CategoryName")]
        public string? CategoryName { get; set; }

        [JsonProperty("CompanyName")]
        [JsonPropertyName("CompanyName")]
        public string? CompanyName { get; set; }

        public IEnumerable<CategoryDTO>? Categories { get; set; }
        public IEnumerable<SupplierDTO>? Suppliers { get; set; }

        public ProductDTO()
        {

        }

        public ProductDTO(int id, string name, decimal price, string quantity, int cateid, int supid, int uis)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.CateId = cateid;
            this.SupId = supid;
            this.UnitsInStock = uis;
        }

    }
}
