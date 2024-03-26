using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using brightskills.Models;
using Microsoft.Data.SqlClient;

namespace OBCMS.Controllers;

public class LoginController : Controller
{
    SqlConnection con=new SqlConnection();
    SqlCommand cmd=new SqlCommand();
    SqlDataReader? dr;
    private readonly ILogger<LoginController> _logger;

    public LoginController(ILogger<LoginController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
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

     public IActionResult Login()
    {
        return View();
    }


     public IActionResult VerifyLogin(LoginModel lmodel)
    {
        conStr();
        con.Open();
        cmd.Connection=con;
        cmd.CommandText="select * from OBCMS_USER_LOGIN where Username=@uname and Password=@pass";
        cmd.Parameters.AddWithValue("@uname", lmodel.Username);
        cmd.Parameters.AddWithValue("@pass", lmodel.Password);

        dr=cmd.ExecuteReader();

        if(dr.Read()){


            // con.Close();

            string? jobrolecheck=dr["jobrole"].ToString();
            con.Close();
         


            if(jobrolecheck=="Branchhead")
            {
                
            return RedirectToAction("Dashboard","Branchhead");
            }
            else if(jobrolecheck=="admin"){
                
                return RedirectToAction("Dashboard","Admin");
            }
                        
            else{
         
                    con.Close();
                    return View("Error");
    
             }

        }
        
        else{
              
                dr.Close();
                cmd.CommandText="select * from OBCMS_USER_LOGIN where Username=@u_name and Password=@_pass";
                cmd.Parameters.AddWithValue("@u_name", lmodel.Username);
                cmd.Parameters.AddWithValue("@_pass", lmodel.Password);
                dr=cmd.ExecuteReader();
                if(dr.Read()){
                    con.Close();
                    return RedirectToAction("Dashboard","Customer");
                }
                else{
                    con.Close();
                    return View("Error");
                 }
        }   
            

        
    }

    [HttpGet]
     public IActionResult Register()
    {
        return View();
    }


    void conStr(){
         con.ConnectionString="data source=192.168.1.240\\SQLEXPRESS; database=CAD_OBCMS; User ID=CADBATCH01; Password=CAD@123pass; TrustServerCertificate=True; ";
    }
    
    [HttpPost]
     public IActionResult RegisterDB(RegisterModel rmodel)
    {   // // Method 01
        // conStr();
        // con.Open();
        // cmd.Connection=con;
        // cmd.CommandText="insert into tbl_reg_users(full_name,user_name ,email_id,contact_number,password) values ('"+rmodel.FullName+"','"+rmodel.UserName+"','"+rmodel.Email+"','"+rmodel.ContactNumber+"','"+rmodel.Password+"') ";

        // int rowAffected=cmd.ExecuteNonQuery();
        // if(rowAffected>0){
        //     return RedirectToAction("Login");
        // }
        // else{
        //     return View("Error");
        // }


        //Method 02
        conStr();
        con.Open();
        cmd.Connection=con;
        cmd.CommandText="insert into tbl_reg_users(full_name,user_name ,email_id,contact_number,password) values (@firstname,@username,@email,@contactnumber,@password) ";
        cmd.Parameters.AddWithValue("@firstname",rmodel.FIRST_NAME);
        cmd.Parameters.AddWithValue("@lastname",rmodel.LAST_NAME);
        cmd.Parameters.AddWithValue("@username",rmodel.USER_NAME);
        cmd.Parameters.AddWithValue("@password",rmodel.PASSWORD);
        cmd.Parameters.AddWithValue("@confirmpassword",rmodel.CONFIRM_PASSWORD);
        cmd.Parameters.AddWithValue("@email",rmodel.EMAIL);
        cmd.Parameters.AddWithValue("@phonenumber",rmodel.PHONENUMBER);
        cmd.Parameters.AddWithValue("@accounttype",rmodel.ACCOUNT_TYPE);

        int rowAffected=cmd.ExecuteNonQuery();
        if(rowAffected>0){
            con.Close();
            return RedirectToAction("Login");
        }
        else{
            con.Close();
            return View("Error");
        }
        
    }


     public IActionResult Services()
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