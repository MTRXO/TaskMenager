using TaskMenager.Models;
using Microsoft.AspNetCore.Mvc;
using TaskMenager.Data;

namespace TaskMenager.Controllers
{
    public class ActiveTasksController : Controller
    {
        private readonly ApplicationDBContext _db;

        public ActiveTasksController(ApplicationDBContext db)
        {
                _db = db;
        }
        public IActionResult TaskNotFound() 
        {
            return View();
        }

        public IActionResult Index()
        {
            List<TaskModel> objTask = _db.Tasks.ToList(); 
            if (objTask.Count == 0) 
            {
                return RedirectToAction("TaskNotFound");
            }
            return View(objTask);
        }
    }
}
