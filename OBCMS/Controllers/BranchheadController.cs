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
    public class BranchheadController : Controller
    {
        private readonly ILogger<BranchheadController> _logger;

        public BranchheadController(ILogger<BranchheadController> logger)
        {
            _logger = logger;
        }

         [Route("Branchhead/Dashboard")]
        public IActionResult Dashboard()
        {
            return View("Dashboard", "_LayoutBranchhead");
        }
        public IActionResult MyDevice()
        {
            return View("MyDevice", "_LayoutBranchhead");
        }
        public IActionResult DevicePrice()
        {
            return View("DevicePrice", "_LayoutBranchhead");
        }
        public IActionResult ManageCustomer()
        {
            return View("ManageCustomer", "_LayoutBranchhead");
        }
        public IActionResult Feedback()
        {
            return View("Feedback", "_LayoutBranchhead");
        }
        public IActionResult DeviceInfo()
        {
            return View("DeviceInfo", "_LayoutBranchhead");
        }
       public IActionResult Customerpage()
        {
            return View("DeviceInfo", "_LayoutBranchhead");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}