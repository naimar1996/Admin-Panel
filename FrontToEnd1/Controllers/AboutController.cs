using FrontToEnd1.Models;
using FrontToEnd1.ViewModels.About;
using Microsoft.AspNetCore.Mvc;

namespace FrontToEnd1.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            var ours = new List<Our>
            {
                new Our{ID = 1,Title = "Our Vision",Description = "OV Description",Icons = "bx bx-revision"},
                new Our{ID = 1,Title = "Our Mission",Description = "OM Description",Icons = " bx bxs-bulb"},
                new Our{ID = 1,Title = "Our Goal",Description = "OG Description",Icons = " bx bxs-select-multiple"}
            };
            var model = new AboutIndexVM
            {
                Ours = ours
            };



            return View(model);
        }
    }
}
