using TaskMenagerModels;
using Microsoft.AspNetCore.Mvc;
using DataAcces;
using DataAccess.Repository.DbOperations;

namespace TaskMenager.Areas.User.Controllers
{
    public class ActiveTasksController : Controller
    {
        private readonly IDbOperations<TaskModel> _operation;

        public ActiveTasksController(IDbOperations<TaskModel> operation)
        {
            _operation = operation;
        }
        public IActionResult TaskNotFound()
        {
            return View();
        }

        public IActionResult Index()
        {
            List<TaskModel> objTask = _operation.GetAll().ToList();
            if (objTask.Count == 0)
            {
                return RedirectToAction("TaskNotFound");
            }
            return View(objTask);
        }
    }
}
