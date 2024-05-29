using Microsoft.AspNetCore.Mvc;
using DataAcces;
using TaskMenagerModels;
using DataAccess.Repository.Validation;

namespace TaskMenager.Controllers
{
    public class DeleteActiveTask : Controller
    {
        

        private readonly ApplicationDBContext _db;
        private readonly IValidation _validation;

        public DeleteActiveTask(ApplicationDBContext db, IValidation validation)
        {
            _validation = validation;
            _db = db;
        }
        
        public IActionResult Index()
        {
            return View("Index");
        }

       
      

        public IActionResult Delete(int? id )
        {
            if ( _validation.IsNullOrEmpty(id) || id == 0 ) return NotFound();
            TaskModel model = _db.Tasks.Find(id);
            if ( model == null ) return NotFound(); 
            return View(model);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int? id) 
        {
            if (_validation.IsNullOrEmpty(id)) return NotFound();
            TaskModel? obj = _db.Tasks.Find(id);
            if ( obj == null ) return NotFound();
            _db.Tasks.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

      
    }
}
