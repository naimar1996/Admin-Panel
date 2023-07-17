using FrontToEnd1.Models;
using FrontToEnd1.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FrontToEnd1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var works = new List<Models.Work>
            {
                new Work{ID = 1,Title = "Social Media",Description = "SM Description",PhotoPath = "/assets/img/recent-work-01.jpg" },
                new Work{ID = 2,Title = "Web Marketing",Description = "WM Description",PhotoPath = "/assets/img/recent-work-02.jpg"},
                new Work{ID = 3,Title = "R - D",Description = "RD Description",PhotoPath = "/assets/img/recent-work-03.jpg"},
                new Work{ID = 4,Title = "Public Relation",Description = "PR Description",PhotoPath = "/assets/img/recent-work-04.jpg"},
                new Work{ID = 5,Title = "Branding",Description = "Br Description",PhotoPath = "/assets/img/recent-work-05.jpg"},
                new Work{ID = 6,Title = "Creative Design",Description = "CD Description",PhotoPath = "/assets/img/recent-work-06.jpg"},
            };
            var model = new HomeIndexVM
           {
                Works = works
           };

            return View(model);
        }
    }
}
