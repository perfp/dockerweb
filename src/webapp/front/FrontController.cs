using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace webapp {

    
    public class FrontController : Controller {

        [Route("/")]
        public IActionResult Index(){
            Debug.WriteLine("Front controller - Index");
            return View();
        }
    }
}
