using System.Reflection.Metadata.Ecma335;

namespace FrontToEnd1.Models
{
    public class FeaturedWork
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }
        public bool  IsDeleted { get; set; }

    }
}
