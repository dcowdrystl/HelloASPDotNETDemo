using Microsoft.AspNetCore.Mvc;

namespace HelloASPDotNET.Controllers
{
    public class BananaController : Controller
    {
        [HttpGet]
        
        public IActionResult Index()
        {
            string html = "<h1>Nya is the time to choose a victim</h1>" +
                "<form method='post' action='/banana/nya'>" +
                "<select name='name'>" +
                "<option value='Dan'>Your Teacher</option>" +
                "<option value='Clark'>Not Your Teacher</option>" +
                "</select>" +
                "<input type='submit' value='Nya?'>" +
                "</form>";

            return Content(html, "text/html");
        }

        [HttpPost]
        [Route("/banana/nya/{name?}")]
        public IActionResult Nya(string name)
        {
            
            return Content("<h1>Know, like nya. Right, " + name + "? </h1>", "text/html");
        }
    }
}