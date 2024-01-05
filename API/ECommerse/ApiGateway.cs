using ECommerse.Models;
using Newtonsoft.Json;
using System.Net;

namespace ECommerse
{
    public class ApiGateway
    {

        private String urlProduct= "http://localhost:5280/api/Product";
        private string urlBasket = "http://localhost:5280/api/Basket";  

        private HttpClient httpClient=new HttpClient();


        public List<Product> ListProducts()
        {
            List<Product> products = new List<Product>();
            if (urlProduct.Trim().Substring(0, 5).ToLower() == "https://")
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            }

            try
            {
                HttpResponseMessage response = httpClient.GetAsync(urlProduct).Result;
                if (response.IsSuccessStatusCode)
                {
                    String result = response.Content.ReadAsStringAsync().Result;
                    var dataCol = JsonConvert.DeserializeObject<List<Product>>(result);

                    if (dataCol != null)
                    {
                        products = dataCol;
                    }
                }

                else
                {
                    string result = response.Content.ReadAsStringAsync().Result;
                    throw new Exception("Error Occured at the API endpoints : " + result);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error Occured at the API endpoints. Error info : " + ex.Message);
            }
            finally { }
           return products;
            
        }

        public List<Product> ListBasket()
        {
            List<Product> basket = new List<Product>();
            if (urlBasket.Trim().Substring(0, 5).ToLower() == "https://")
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            }

            try
            {
                HttpResponseMessage response = httpClient.GetAsync(urlBasket).Result;
                if (response.IsSuccessStatusCode)
                {
                    String result = response.Content.ReadAsStringAsync().Result;
                    var dataCol = JsonConvert.DeserializeObject<List<Product>>(result);

                    if (dataCol != null)
                    {
                        basket = dataCol;
                    }
                }

                else
                {
                    string result = response.Content.ReadAsStringAsync().Result;
                    throw new Exception("Error Occured at the API endpoints : " + result);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error Occured at the API endpoints. Error info : " + ex.Message);
            }
            finally { }
            return basket;

        }
    }
}
