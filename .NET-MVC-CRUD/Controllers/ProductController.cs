using Microsoft.AspNetCore.Mvc;
using CRUD.Models;
using CRUD.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using AppSemTemplate.Extensions;

namespace CRUD.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        [ClaimsAuthorize("Products", "VI")]
        public async Task<IActionResult> Index()
        {
            var user = HttpContext.User.Identity;

            return View(await _context.Products.ToListAsync());
        }
        [ClaimsAuthorize("Products", "AD")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ClaimsAuthorize("Products", "AD")]
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
        [ClaimsAuthorize("Products", "ED")]
        public async Task<IActionResult> Edit(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }


            return View(product);
        }
        [HttpPost]
        [ClaimsAuthorize("Products", "ED")]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,UnitPrice,Amount,ImageUpload,Active")] Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            var produtoDb = await _context.Products.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);

            if (ModelState.IsValid)
            {
                try
                {
                    product.Image = produtoDb.Image;

                    if (product.ImageUpload != null)
                    {
                        var imgPrefixo = Guid.NewGuid() + "_";
                        if (!await UploadImg(product.ImageUpload, imgPrefixo))
                        {
                            return View(product);
                        }

                        product.Image = imgPrefixo + product.ImageUpload.FileName;
                    }

                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }
        [ClaimsAuthorize("Products", "DT")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);

            return View(product);
        }
        [ClaimsAuthorize("Products", "DL")]
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if(id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = _context.Products.FirstOrDefault(p => p.Id == id);

            if(product == null)
            {
                return NotFound();
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [ClaimsAuthorize("Products", "DL")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);

            return View(product);
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
    private bool ProductExists(int id)
    {
            return (_context.Products?.Any(p => p.Id == id)).GetValueOrDefault();
    }
    }

}
