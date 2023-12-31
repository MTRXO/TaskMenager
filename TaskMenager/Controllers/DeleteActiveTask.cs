﻿using Microsoft.AspNetCore.Mvc;
using TaskMenager.Data;
using TaskMenager.Models;

namespace TaskMenager.Controllers
{
    public class DeleteActiveTask : Controller
    {


        private readonly ApplicationDBContext _db;

        public DeleteActiveTask(ApplicationDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View("Index");
        }
        public bool IsNull(int? value)
        {
            if (value == null)
            {
                return true;
            }
            else return false;  
        }

        public IActionResult Delete(int? id )
        {
            if ( IsNull(id) || id == 0 ) return NotFound();
            TaskModel model = _db.Tasks.Find(id);
            if ( model == null ) return NotFound(); 
            return View(model);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int? id) 
        {
            if ( IsNull(id)) return NotFound();
            TaskModel? obj = _db.Tasks.Find(id);
            if ( obj == null ) return NotFound();
            _db.Tasks.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
