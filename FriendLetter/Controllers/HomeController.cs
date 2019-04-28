//have access to logic from MVC
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

    // homepage: root path
    // ActionResult is a class built in to the MVC library to handle rendering views
    // View() is a built in method from MVC, this route should now return a view in the server's response to the client. View is invoked from the route Letter(), so it will return view from Letter.cshtml.
    [Route("/")]
    public ActionResult Letter() { return View(); }

    //route decorator can be called anything, what matters is the name of Journal() when View is located
    [Route("/journal")]
    public ActionResult Journal() { return View(); }

  }
}
