using FrontToEnd1.Areas.Admin.ViewModels.FeaturedWork;
using FrontToEnd1.DAL;
using FrontToEnd1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace FrontToEnd1.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FeaturedWorkController : Controller
    {
        private readonly AppDbContext _context;

        public FeaturedWorkController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var featuredWorks = _context.FeaturedWorks.OrderByDescending(fw => fw.ID).ToList();
            var model = new FeaturedWorkIndexVM
            {
                FeaturedWorks = featuredWorks
            };

            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(FeaturedWorkCreateVM model)
        {
            if (!ModelState.IsValid) return View();

            var featuredWork = new FeaturedWork
            {
                Title = model.Title,
                Subtitle = model.Subtitle,
                Description = model.Description
            };
            _context.FeaturedWorks.Add(featuredWork);

            var dbFeaturedWorks = _context.FeaturedWorks.FirstOrDefault(fw => !fw.IsDeleted);
            if (dbFeaturedWorks is not null)
            {
                dbFeaturedWorks.IsDeleted = true;
                _context.FeaturedWorks.Update(dbFeaturedWorks);
            }

            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
