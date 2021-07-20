using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloASPDotNET.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
           string html = "<form method='get' action='/hello/Greating'>" +
         "<input type='text' name='name' />" +
         "<select name='language'><option value = 'Russian'> Russian </ option ><option value = 'Turkish'> Turkish </ option >" +
         "<input type='submit' value='Greet Me!' />" +
         "</form>";
            return Content(html, "text/html");
        }
        public IActionResult Greating(string name, string language)
        {
            if (language == "Russian")
            {
                string html = $"<h1> Zdarova {name} </h1>";
                return Content(html, "text/html");
            }
            else if (language == "Turkish")
            {
                string html = $"<h1> Merhaba {name} </h1>";
                return Content(html, "text/html");
            }
            else
            {
                string html = $"<h1> Hello {name} </h1>";
                return Content(html, "text/html");
            }
        }
    }
}
