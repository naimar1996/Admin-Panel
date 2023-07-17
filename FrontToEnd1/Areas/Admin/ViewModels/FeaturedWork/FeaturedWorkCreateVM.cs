using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace FrontToEnd1.Areas.Admin.ViewModels.FeaturedWork
{
    public class FeaturedWorkCreateVM
    {
        [Required(ErrorMessage = "Title must be definitely entered")]
        [MaxLength(20, ErrorMessage = "Title must be 20 symbols")]
        public string Title { get; set; }

        [MaxLength(20, ErrorMessage = "Title must be 20 symbols")]
        public string Subtitle { get; set; }

        [Required(ErrorMessage = "Description must be definitely entered")]
        [MaxLength(1000, ErrorMessage = "Description must be 1000 symbols at least"), MinLength(10, ErrorMessage = "Description must be 10 symbols at least")]
        public string Description { get; set; }

    }
}
