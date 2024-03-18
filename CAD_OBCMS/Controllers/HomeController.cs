using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CAD_OBCMS.Models;
using Microsoft.Data.SqlClient;

namespace CAD_OBCMS.Controllers;

public class HomeController : Controller
{
    
    SqlConnection con=new SqlConnection();
    SqlCommand com=new SqlCommand();

    SqlDataReader? dr;

    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

[HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    void ConnectionString()
    {
        con.ConnectionString="data source=192.168.1.240\\SQLEXPRESS; database=CAD_OBCMS; user ID=CADBATCH01; password=CAD@123pass; TrustServerCertificate=True;";

    }

[HttpPost]
    public IActionResult VerifyLogin(LoginModel lmodel){
        ConnectionString();
        con.Open();
        com.Connection=con;
        com.CommandText="SELECT * FROM OBCMS_USER_LOGIN where Username='"+lmodel.Username+"'and Password='"+lmodel.Password+"'";
        dr=com.ExecuteReader();

        if (dr.Read()){
            con.Close();
            return View("Create");
        }
        else{
              con.Close();
             return View("Error");
        }
    }

    public IActionResult Store()
    {
        return View();
    }

    public IActionResult Aboutus()
    {
        return View();
    }

    public IActionResult Contactus()
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
}
