using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MovieMvc.Controllers
{
    public class HelloWorldController : Controller
    {
        //Get: /Helloworld/
        public string Index()
        {
            return "Default";
        }

        // Get: /helloworld/welcome
        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}
