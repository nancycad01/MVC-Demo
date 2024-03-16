using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvcdemo.Models;
using Microsoft.Data.SqlClient;

namespace mvcdemo.Controllers;

public class HomeController : Controller
{
    SqlConnection con=new SqlConnection{};
    SqlCommand com=new SqlCommand{};

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

    public IActionResult Home()
    {
        return View();
    }
    public IActionResult Privacy()
    {
        return View();
    }
    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    void connectionstring(){
        con.ConnectionString="data source= 192.168.1.240\\SQLEXPRESS; database=cad_gs;User Id = CADBATCH01;Password=CAD@123pass; TrustServerCertificate=True;";
    }

[HttpPost]   
 public IActionResult VerifyLogin(LoginModel lmodel){
        connectionstring();
        con.Open();
        com.Connection=con;
    com.CommandText="select * from GS_User_Login where User_Name='"+lmodel.User_Name+"' and Password='"+lmodel.Password+"' ";
        dr=com.ExecuteReader();
        if(dr.Read()){
            con.Close();
            return View("Success");
        }
        else{
             con.Close();
        return View("Error");
        }
        
    }

      public IActionResult CreateCustomerPage()
    {
        return View();
    }
    
     public IActionResult CreateProductPage()
    {
        return View();
    }

    public IActionResult Registration()
    {
        return View();
    }
    public IActionResult Order()
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

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
