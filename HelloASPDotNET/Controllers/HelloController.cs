using Microsoft.AspNetCore.Mvc;

namespace HelloASPDotNET.Controllers
{
    [Route("/helloworld")]
    public class HelloController : Controller
    {
        //GET: /helloworld/
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post' action='/helloworld/welcome'>" +
              "<input type='text' name = 'name'/>" +
              "<select name='helloTranslate'>" +
              "<option value='Hello' selected>English</option>" +
               "<option value='Bonjour' selected>French</option>" +
                "<option value='NiHao' selected>Mandarin</option>" +
                 "<option value='Hola' selected>Spanish</option>" +
                  "<option value='Hallo' selected>German</option>" +
                  "<input type='submit' value='Greet Me!' />" +
                  "</form>";

            return Content(html,"text/html");
        }

        [HttpPost("welcome")]
        [HttpGet("welcome/{name?}/{helloTranslate?}")]
        public IActionResult CreateMessage(string name = "Patrick", string helloTranslate = "Whattup?!")
        {
            //string html = $"<h1>{helloTranslate}, {name}!</h1>";
            return Content($"<h1>{helloTranslate}, {name}!</h1>", "text/html");
        }
    }
}
