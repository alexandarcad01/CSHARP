using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace OBCMS.Controllers
{
    [Route("[controller]")]
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;

        public AdminController(ILogger<AdminController> logger)
        {
            _logger = logger;
        }

         [Route("Admin/Dashboard")]
        public IActionResult Dashboard()
        {
            return View("Dashboard", "_LayoutAdmin");
        }
        public IActionResult ManageCustomer()
        {
            return View("ManageCustomer", "_LayoutAdmin");
        }
        public IActionResult ManageDevicePrice()
        {
            return View("ManageDevicePrice", "_LayoutAdmin");
        }
        public IActionResult ManageUsers()
        {
            return View(" ManageUsers", "_LayoutAdmin");
        }
        public IActionResult Reports()
        {
            return View("Reports", "_LayoutAdmin");
        }
        public IActionResult Settings()
        {
            return View("Settings", "_LayoutAdmin");
        }
       public IActionResult Branchhead()
        {
            return View("Branchhead", "_LayoutAdmin");
        }
       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}