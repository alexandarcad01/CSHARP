

using Microsoft.AspNetCore.Mvc;

namespace OBCMS.Controllers
{
   [Route("[controller]")]
    public class CustomerController : Controller{


    [Route("Customer/Dashboard")]
      public IActionResult Dashboard(){
        return View("Dashboard", "_LayoutCustomer");
      }
      public IActionResult EnrollinDevice(){
        return View();
      }
      public IActionResult MyDevice(){
        return View();
      }
      public IActionResult ViewDeviceInfo(){
        return View();
      }
      public IActionResult Feedback(){
        return View();
      }
      
     

    }

}