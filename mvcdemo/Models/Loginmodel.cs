using Microsoft.Identity.Client;
using Microsoft.Net.Http.Headers;

namespace mvcdemo.Controllers;

public class LoginModel 
{
public string? User_Name{get; set;}
public string? Password{get; set;}
}