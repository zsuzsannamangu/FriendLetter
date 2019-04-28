using Microsoft.AspNetCore.Mvc;

namespace FriendLetter.Controllers
{
  //we tell .NET that HomeController should inherit or extend functionality from ASP.NET Core's built-in Controller class
  public class HomeController : Controller
  {
  //Hello() method represents a route in our application, sg a user can visit. because it is a route it will also create a special path. www.xyz.com/home/hello
  // /home, corresponds to the name of our controller
  //add route decorator to override what URL path matches which route
    [Route("/hello")]
    public string Hello() { return "Hello friend!"; }

    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend"; }

  }
}
