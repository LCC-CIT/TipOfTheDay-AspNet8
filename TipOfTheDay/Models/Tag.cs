namespace TipOfTheDay.Models
{
    public class Tag
    {
        // Backing fields
        private readonly List<Tip> _tips = new();
        private string _category = "Default category";

        // Properties
        public int TagId { get; set; }
        // "Long form" of property getter and setter
        public String Category { get => _category; set => _category = value; }
        public List<Tip> Tips
        {
            get { return _tips; }
        }
    }
}
