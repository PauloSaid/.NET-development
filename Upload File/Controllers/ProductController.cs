using Microsoft.AspNetCore.Mvc;
using CRUD.Models;
using CRUD.Data;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        public ProductController(AppDbContext context)
        {
            _context = context;
        }
        
        public async Task<IActionResult> Index()
        {
            return View(await _context.Products.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,UnitPrice,Amount,ImageUpload,Active")] Product product)
        {
            if (ModelState.IsValid)
            {
                var imgPrefix = Guid.NewGuid() + "_";
                if (!await UploadImg(product.ImageUpload, imgPrefix))
                {
                    return View(product);
                }

                product.Image = imgPrefix + product.ImageUpload.FileName;

                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View("Create", product);
        }

        private async Task<bool> UploadImg(IFormFile file, string imgPrefix)
        {
            if (file.Length <= 0) return false;

            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", imgPrefix + file.FileName);

            if (System.IO.File.Exists(path))
            {
                ModelState.AddModelError(string.Empty, "Já existe um arquivo com este nome!");
                return false;
            }

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return true;
        }
    }
}
