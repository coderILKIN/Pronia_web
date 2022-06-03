using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pronia.DAL;
using Pronia.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pronia.Areas.ProniaAdmin.Controllers
{
    [Area("ProniaAdmin")]
    public class SizeController : Controller
    {
        private readonly AppDbContext context;
        public SizeController(AppDbContext context)
        {
            this.context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Size> sizes = await context.Sizes.ToListAsync();
            return View(sizes);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Size size)
        {
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Detail(int id)
        {
            return Json(id);
        }

        public IActionResult Edit(int id)
        {
            return Json(id);
        }

        public IActionResult Delete(int id)
        {
            return Json(id);
        }
    }
}
