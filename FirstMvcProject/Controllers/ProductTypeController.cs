using FirstMvcProject.Entity;
using FirstMvcProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMvcProject.Controllers
{
    public class ProductTypeController : Controller
    {
        private ApplicationDbContext _db;

        public ProductTypeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            //select * from ProductType
            IEnumerable<ProductType> model = _db.ProductType;
            
            return View(model);
        }

        // GET - CREATE
        //[HttpGet]
        //[ActionName("Ekle")]
        //[Route("{Controller}/UrunTipi/Ekle")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ekle(ProductType model)
        {
            if (ModelState.IsValid)
            {
                _db.ProductType.Add(model);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View("Create", model);
            }
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id <= 0)
            {
                return NotFound();
            }

            var model = _db.ProductType.Find(id);

            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(ProductType model)
        {
            if (ModelState.IsValid)
            {
                _db.ProductType.Update(model);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }


            return View(model);
        }
    }
}
