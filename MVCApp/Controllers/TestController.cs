using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;
using MVCApp.Services;

namespace MVCApp.Controllers
{
    //[Controller]
    //[NonController]
    //[Route("[controller]/2[action]")]
    [Area("my")]
    public class TestController : Controller
    {
        private readonly IVisit _visit;
        public TestController(IVisit visit)
        {
            _visit = visit;
        }

        //[ActionName("visits")]
        //[NonAction]
        [Route("ok")]
        [HttpGet]
        public IActionResult Index(/*int count = 0*/ User user)
        {
            //return View("Index", new TestViewModel() { Counter = _visit.Visits });
            //return View(new TestViewModel() { Counter = _visit.Visits });
            //return View(new TestViewModel() { Counter = count });
            return View(user);
        }
        /*
        [Route("api/user")]
        public JsonResult APICall(User user)
        {
            
        }
        */
        //
        public string Index2()
        {
            return "It's ok";
        }
    }

    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
