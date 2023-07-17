using FrontToEnd1.DAL;
using FrontToEnd1.Models;
using FrontToEnd1.ViewModels.Contact;
using Microsoft.AspNetCore.Mvc;

namespace FrontToEnd1.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index() 
        {
            var createSuccess = _context.CreateSuccess.FirstOrDefault();
            //var create = new Create { ID = 1, Title = "Create success campaign with us!", SubTitle = "Elit, sed do eiusmod tempor", Description = "Incididunt ut labore et dolore magna aliqua. Quis ipsum suspendisse ultrices gravida. Risus commodo viverra maecenas accumsan lacus vel facilisis. Laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate." };

            var contactTypes = _context.ContactTypes.ToList();
            //var contactTypes = new List<ContactType>
            //{
            //    new ContactType{ ID = 1, Icons = "bx bx-news", Title = "Media Contact", Director = "Mr.Naim Rahimov", ContactNumber = "010-020-0340"},
            //    new ContactType{ ID = 2, Icons = "bx bx-laptop", Title = "Technical Contact", Director = "Mr. John Stiles", ContactNumber = "010-020-0340"},
            //    new ContactType{ ID = 3, Icons = "bx bx-money", Title = "Billing Contact", Director = "Mr. Richard Miles", ContactNumber = "010-020-0340"}
            //};
            var model = new ContactIndexVM
            {
                CreateSuccess = createSuccess,
                ContactTypes = contactTypes

            };
            return View(model);
        }
    }
}
