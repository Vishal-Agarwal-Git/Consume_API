using Consume_API.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace Consume_API.Controllers
{
    public class CustomerController : Controller
    {
        private string localURL = "https://localhost:7192/swagger/index.html";
        public IActionResult Index()
        {
            List<Customer> data = new List<Customer>();
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(localURL);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = client.GetAsync("/Customer/GetAllCustomers").Result;
                    client.Dispose();
                    if(response.IsSuccessStatusCode)
                    {
                        string stringData = response.Content.ReadAsStringAsync().Result;
                        data = JsonConvert.DeserializeObject<List<Customer>>(stringData);
                    }
                    else
                    {
                        TempData["error"] = $"{response.ReasonPhrase}";
                    }
                }
            }
            catch(Exception Ex)
            {
                TempData["exception"] = Ex.Message;
            }
            return View(data);
        }
    }
}
