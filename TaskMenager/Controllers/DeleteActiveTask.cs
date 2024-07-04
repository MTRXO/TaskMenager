using Microsoft.AspNetCore.Mvc;
using DataAcces;
using TaskMenagerModels;
using DataAccess.Repository.Validation;
using DataAccess.Repository.DbOperations;

namespace TaskMenager.Controllers
{
    public class DeleteActiveTask : Controller
    {
        

        private readonly IDbOperations<TaskModel> _operation;
        private readonly IValidation _validation;

        public DeleteActiveTask(IDbOperations<TaskModel> operation, IValidation validation)
        {
            _validation = validation;
            _operation = operation;
        }
        
        public IActionResult Index()
        {
            return View("Index");
        }

       
      

        public IActionResult Delete(int? id )
        {
            if (_validation.IsNullOrEmpty(id) || id == 0) return NotFound();

            TaskModel model = _operation.Get(t => t.Id == id);  
            if (model == null) return NotFound();

            return View(model);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int? id) 
        {
            if (_validation.IsNullOrEmpty(id)) return NotFound();
            TaskModel? obj = _operation.Get(t => t.Id == id);
            if ( obj == null ) return NotFound();
            _operation.Delete(obj);
            _operation.SaveChanges();
            return RedirectToAction("Index");
        }

      
    }
}
