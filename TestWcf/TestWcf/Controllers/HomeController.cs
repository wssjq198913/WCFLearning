using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ServiceModel;

namespace TestWcf.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var message = string.Empty;
            // first approach, this apporach is not using serviceBase class in CalculateServiceClient.
            //var client = new CalculatorService.CalculatorClient();
            //message = client.Add(12, 12).ToString();

            // second approach
            //BasicHttpBinding binding = new BasicHttpBinding();
            //EndpointAddress remoteAddress = new EndpointAddress("http://localhost:90/CalculatorService/CalculateService.svc");
            //var client = new CalculateServiceClient.ServiceProxy(binding, remoteAddress);
            //try
            //{
            //    message = client.Add(12, 12).ToString();
            //}
            //finally
            //{
            //    client.Close();
            //}

            var client = new CalculateServiceClient.ServiceProxy();
            try
            {
                message = client.Add(12, 12).ToString();
            }
            finally
            {
                client.Close();
            }
            ViewBag.Message = message;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
