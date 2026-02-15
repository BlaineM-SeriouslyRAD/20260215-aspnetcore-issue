using Microsoft.AspNetCore.Mvc;

namespace SampleProject.Controllers
{
    public class DefaultController : Controller
    {
        [Route("/")]
        public ActionResult<string> Default()
        {
            return "Hello World!";
        }
    }
}
