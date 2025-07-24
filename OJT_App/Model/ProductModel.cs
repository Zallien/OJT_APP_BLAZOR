using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OJT_App.Model
{
    public class ProductModel
    {
        [JsonProperty("productId")]
        public Guid Id { get; set; }

        [JsonProperty("productName")]
        public string Productname { get; set; }

        [JsonProperty("productPrice")]
        public decimal price { get; set; }

        [JsonProperty("productQuanity")]
        public int Quantity { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("datecreated")]
        public DateTime Created { get; set; }


    }
}
