using FirstMvcProject.Entity;
using FirstMvcProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMvcProject.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;            
        }

        public IActionResult Index()
        {
            var categoryList = _db.Category;

            return View(categoryList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category model)
        {
            _db.Category.Add(model);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
