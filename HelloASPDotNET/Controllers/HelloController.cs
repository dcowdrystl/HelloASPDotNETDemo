using Microsoft.AspNetCore.Mvc;

namespace HelloASPDotNET.Controllers
{
    
    public class HelloController : Controller
    {
        /*[HttpGet]
        [Route("/helloworld/")]*/
        public IActionResult Index()
        {
            string index = "<form method='POST' action='/hello/result'>" +
                "The hello path<br>" + 
                "<input type='submit' value='submit'><br>" +
                "</form>";
            return Content(index, "text/html");
        }


        //POST: /hello/
        [HttpPost]
        [Route("hello/result")]
        public IActionResult FormSubmission()
        {
            string html = "Form Submitted!";
            return Content(html, "text/html");
        }
    }
}
