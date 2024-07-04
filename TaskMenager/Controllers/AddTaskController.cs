using Microsoft.AspNetCore.Mvc;
using TaskMenagerModels;
using DataAcces;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using DataAccess.Repository.DbOperations;

namespace TaskMenager.Controllers
{
    public class AddTaskController : Controller
    {
        private readonly IDbOperations<TaskModel> _operation;

        public AddTaskController(IDbOperations<TaskModel> operation)
        {
            _operation = operation;
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
                _operation.Add(obj);
                _operation.SaveChanges();
                return View("TaskReady");
            }

            else return View("Index");
            
       
        }

    }
}
