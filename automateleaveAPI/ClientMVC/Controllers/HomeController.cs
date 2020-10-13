using ClientMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace ClientMVC.Controllers
{
    public class HomeController : Controller
    {
        Uri baseAddress = new Uri("http://localhost:2518/api");
        HttpClient client;
        // GET: Home

        public HomeController()
        {
            client = new HttpClient();
            client.BaseAddress = baseAddress;
        }
        public ActionResult Index()
        {
            List<LeaveAllocationView> modelList = new List<LeaveAllocationView>();

            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/Home").Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                modelList = JsonConvert.DeserializeObject<List<LeaveAllocationView>>(data);
            }
            return View(modelList);
        }
    }
}