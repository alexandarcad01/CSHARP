using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OBCMS.Models;
using Microsoft.Data.SqlClient;

namespace OBCMS.Controllers
{
   [Route("[controller]")]
    public class CustomerController : Controller{


    [Route("Customer/Dashboard")]
      public IActionResult Dashboard(){
        return View("Dashboard", "_LayoutCustomer");
      }
      public IActionResult Registration(){
        return View("Registration", "_LayoutCustomer");
      }
      public IActionResult MyDevice(){
        return View("MyDevice", "_LayoutCustomer");
      }
      public IActionResult ViewDeviceInfo(){
        return View("ViewDeviceInfo", "_LayoutCustomer");
      }
      public IActionResult Feedback(){
        return View("Feedback", "_LayoutCustomer");
      }
      
     

    }

}