using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MVCMOVIE.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        //GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();

           // return "This is my default action...";
        }

        //
        //GET" /HelloWorld/Welcome/
        //Requires using System.Text.Encodings.Web;

        public IActionResult Welcome(string name,int numTimes = 1)
        {
            ViewData["Message"] = "Hello" + name;
            ViewData["NumTimes"] = numTimes;

            return View();
           // return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
            //return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is {numTimes}");
           // return "This is the Welcome action method...";
        }
    }
}
