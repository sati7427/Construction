using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ConstructionCoreApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ConstructionCoreApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration Config;
        
        public HomeController(ILogger<HomeController> logger, IConfiguration Configg)
        {
            _logger = logger;
            Config = Configg;
        }

        public IActionResult Index()
        {
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


        public string Tables()
        {
            ConnectionClass Con = new ConnectionClass(Config);
            string query = "CREATE TABLE Workers(PId int IDENTITY(1,1) PRIMARY KEY NOT NULL,Name NVARCHAR(250),Designation NVARCHAR(250),Mobile INT,AMobile INT,Location NVARCHAR(250) )";
            Con.SqlCommandnonquery(query);
            
            return "Sucess";
        }
    }
}
