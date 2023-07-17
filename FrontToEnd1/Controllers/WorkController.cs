using FrontToEnd1.DAL;
using FrontToEnd1.ViewModels.Work;
using Microsoft.AspNetCore.Mvc;

namespace FrontToEnd1.Controllers
{
    public class WorkController : Controller
    {
        private readonly AppDbContext _context;

        public WorkController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var featuredWork = _context.FeaturedWorks.FirstOrDefault(fw => !fw.IsDeleted);
            var model = new WorkIndexVM
            {
                FeaturedWork = featuredWork
            };
            return View(model);
        }
    }
}

