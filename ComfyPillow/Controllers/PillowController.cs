using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace ComfyPillow.Controllers
{
    public class PillowController : Controller
    {
        // 
        // GET: /Pillow/

        //public string Index()
        //{
           // return "This is my default action...";
       // }

        // 
        // GET: /Pillow/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
        public IActionResult Index()
        {
         return View();
         }
    }
}
