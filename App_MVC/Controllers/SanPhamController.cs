using ClassLib_App_Data.Models;
using ClassLib_App_Data.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App_MVC.Controllers
{
    public class SanPhamController : Controller
    {
        WebMvcContext _context;
        Repository<SanPham> _reps;
        DbSet<SanPham> _dbSet;
        public SanPhamController()
        {
            _context = new WebMvcContext();
            _dbSet = _context.sanPhams;
            _reps = new Repository<SanPham>(_dbSet,_context);
        }
        public IActionResult Index()
        {
            var getProducts = _reps.GetAll();
            return View(getProducts);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(SanPham sanPham)
        {
            sanPham.ID = Guid.NewGuid();
            _reps.CreateObj(sanPham);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(Guid id)
        {
            var getByID = _reps.GetByID(id);
            return View(getByID);
        }
        public IActionResult UpdateProducts(SanPham sanPham)
        {
            _reps.UpdateObj(sanPham);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(Guid id)
        {
            _reps.DeleteObj(id);
            return RedirectToAction("Index");
        }
        public IActionResult Details(Guid id)
        {
            var getById = _reps.GetByID(id);
            return View(getById);
        }
    }
}
