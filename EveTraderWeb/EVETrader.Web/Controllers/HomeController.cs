using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EVETrader.Web.Models;
//using IO.Swagger.Client;
//using IO.Swagger.Model;
//using IO.Swagger.Api;

namespace EVETrader.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
			//var client = new SalesOrdersApi();
			//var test = client.ApiSalesOrdersGet();

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
