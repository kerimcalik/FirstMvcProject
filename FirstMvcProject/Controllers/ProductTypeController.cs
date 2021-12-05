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
    }
}
