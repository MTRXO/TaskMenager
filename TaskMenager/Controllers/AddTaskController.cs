using Microsoft.AspNetCore.Mvc;
using TaskMenager.Models;
using TaskMenager.Data;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace TaskMenager.Controllers
{
    public class AddTaskController : Controller
    {
        private readonly ApplicationDBContext _db;

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
            if (int.TryParse(obj.TaskTitle, out int result))
            {
                ModelState.AddModelError("TaskTitle", "Your task tittle can not consist only of numbers ");
            }
            if (ModelState.IsValid)
            {
                _db.Tasks.Add(obj);
                _db.SaveChanges();
                return View("TaskReady");
            }

            else return View("Index");
            
       
        }

    }
}
