using Microsoft.AspNetCore.Mvc;

namespace HostingModel.Controllers
{
    public class DefaultController : Controller
    {
        [Route("/")]
        public ActionResult<string> Default()
        {
            return "Test";
        }
    }
}
