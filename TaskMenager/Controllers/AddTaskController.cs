using Microsoft.AspNetCore.Mvc;

namespace TaskMenager.Controllers
{
    public class AddTaskController : Controller
    {
        public IActionResult Index()
        {
            return View(); 
        }
    }
}
