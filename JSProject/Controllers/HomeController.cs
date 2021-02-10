using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using JSProject.Models;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace JSProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        
        public IActionResult Index()
        {
            //byte[] imageBytes = Convert.FromBase64String(base64String);
            //MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            //ms.Write(imageBytes, 0, imageBytes.Length);
            //System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            //return image;
            return View();
        }



        [HttpPost]
        public IActionResult Index(AjaxModel model)
        {
            //byte[] imageBytes = Convert.FromBase64String(base64String);
            //MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            //ms.Write(imageBytes, 0, imageBytes.Length);
            //System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            //return image;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
