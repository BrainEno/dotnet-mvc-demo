using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Dotnetweb.Data;
using Dotnetweb.Models;

namespace Dotnetweb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly Data.ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> objList = _db.Category;
            return View(objList);
        }

        //GET - CREATE
        public IActionResult Create()
        {
            return View();
        }

        //POST -CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create(Category obj)
        {
            _db.Category.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
