using Newtonsoft.Json;
using OJT_App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace OJT_App.Service
{
    internal class ProductServices : iProduct
    {
        string _baseURL = "http://localhost:5201";
        public async Task<List<ProductModel>> GetProducts()
        {
            var products = new List<ProductModel>();
                
            try
            {
                using(var httpclient = new HttpClient())
                {
                    string url = $"{_baseURL}/api/Product/GetAllProduct";
                    var apiresponse = await httpclient.GetAsync(url);

                    if(apiresponse.StatusCode == HttpStatusCode.OK)
                    {
                        var responce = apiresponse.Content.ReadAsStringAsync();
                        products = JsonConvert.DeserializeObject<List<ProductModel>>(responce.Result);
                    }
                }
            }
            catch (Exception e)
            {

              
            }

            return products;

        }

        public async Task<Boolean> AddProdctItem(ProductInsert prod)
        {
            bool ItemAdded = false;


            try
            {

                using(var httpclient = new HttpClient())
                {
                    string url = $"{_baseURL}/api/Product/InsertProduct";
                    var apiresponse = await httpclient.PostAsJsonAsync(url,prod);

                    if (apiresponse.StatusCode == HttpStatusCode.OK)
                    {
                        ItemAdded = true;
                    }
                }


            }
            catch (Exception e)
            {

                
            }

            return ItemAdded;


        }
    }
}
