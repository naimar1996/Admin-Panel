namespace FrontToEnd1.Models
{
    public class ContactType
    {
        public int ID { get; set; }
        public string Icons { get; set; }
        public string  Title { get; set; }
        public string Director  { get; set; }
        public string ContactNumber { get; set; }

        public static implicit operator List<object>(ContactType? v)
        {
            throw new NotImplementedException();
        }
    }
}
