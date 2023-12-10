using TaskMenager.Models;
using Microsoft.AspNetCore.Mvc;
using TaskMenager.Data;

namespace TaskMenager.Controllers
{
    public class ActiveTasksController : Controller
    {
        private ApplicationDBContext _db;

        public ActiveTasksController(ApplicationDBContext db)
        {
                _db = db;
        }

        public IActionResult Index()
        {
            List<TaskModel> objTask = _db.Tasks.ToList(); 
            return View(objTask);
        }
    }
}
