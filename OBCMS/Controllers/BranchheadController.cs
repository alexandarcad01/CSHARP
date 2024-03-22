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
            return View("MyCourses", "_LayoutBranchhead");
        }
        public IActionResult DevicePrice()
        {
            return View("ScheduleSessions", "_LayoutBranchhead");
        }
        public IActionResult ManageCustomer()
        {
            return View("ManageTrainees", "_LayoutBranchhead");
        }
        public IActionResult Feedback()
        {
            return View("Grades", "_LayoutBranchhead");
        }
        public IActionResult DeviceInfo()
        {
            return View("Resources", "_LayoutBranchhead");
        }
       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}