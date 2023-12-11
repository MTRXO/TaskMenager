using Microsoft.AspNetCore.Mvc;
using TaskMenager.Models;
using TaskMenager.Data;

namespace TaskMenager.Controllers
{
    public class AddTaskController : Controller
    {
        private ApplicationDBContext _db;

        public AddTaskController(ApplicationDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(); 
        }

        [HttpPost]

        public IActionResult Create(TaskModel obj)
        {
            _db.Tasks.Add(obj);
            _db.SaveChanges();
            return View("TaskReady");  
        }

    }
}
