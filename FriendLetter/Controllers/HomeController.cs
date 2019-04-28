//have access to logic from MVC
using Microsoft.AspNetCore.Mvc;
//use LetterVariable.cs
using FriendLetter.Models;

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
    // create a new instance of our LetterVariable class, and provide it to the view:
    [Route("/")]
    public ActionResult Letter() {
      // create new empty LetterVariable object
      LetterVariable myLetterVariable = new LetterVariable();
      //use SetRecipient() method defined in LetterVariable and sets _recipient property of object to Jessica
      myLetterVariable.SetRecipient("Jessica");
      myLetterVariable.SetSender("John");
      //pass myLetterVariable object to View() as argument, so Letter.cshtml view now has access to LetterVariable object.
      return View(myLetterVariable);
    }

    //route decorator can be called anything, what matters is the name of Journal() when View is located
    [Route("/journal")]
    public ActionResult Journal() { return View(); }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    //the arguments in PostCard are the name attribute of input in the form in Form.cshtml, they should match exactly
    [Route("/postcard")]
    public ActionResult PostCard(string recipient, string sender)
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.SetRecipient(recipient);
      myLetterVariable.SetSender(sender);
      return View(myLetterVariable);
    }

  }
}
