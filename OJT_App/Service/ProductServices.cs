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
        //string _baseURL = "http://localhost:5201";
        string _baseURL = "http://localhost:5166";
        public async Task<List<ProductModel>> GetProducts()
        {
            var products = new List<ProductModel>();
                
            try
            {
                using(var httpclient = new HttpClient())
                {
                    //string url = $"{_baseURL}/api/Product/GetAllProduct";
                    string url = $"{_baseURL}/Product/GetProducts";
                    var apiresponse = await httpclient.GetAsync(url);

                    if(apiresponse.StatusCode == HttpStatusCode.OK)
                    {
                        var response = apiresponse.Content.ReadAsStringAsync();
                        Console.WriteLine(response);

                        products = JsonConvert.DeserializeObject<List<ProductModel>>(response.Result);
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
                    //string url = $"{_baseURL}/api/Product/InsertProduct";
                    string url = $"{_baseURL}/Product/AddProduct";
                    var apiresponse = await httpclient.PostAsJsonAsync(url,prod);

                    if (apiresponse.StatusCode == HttpStatusCode.OK)
                    {
                        ItemAdded = true;
                    }
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                
            }

            return ItemAdded;


        }

        public async Task<Boolean> DeleteProductItem(Guid productid)
        {

            bool Isdeleted = false;

            try
            {
                using(var httpclient = new HttpClient())
                {
                    string url = $"{_baseURL}/Product/DeleteProduct";
                    var uid = new { ProductID = productid };

                    var apiresponse = await httpclient.PostAsJsonAsync(url, uid);

                    if (apiresponse.StatusCode == HttpStatusCode.OK)
                    {
                        Isdeleted = true;
                    }
                }

            }
            catch (Exception e)
            {
                

            }



            return Isdeleted;

        }
    }
}
