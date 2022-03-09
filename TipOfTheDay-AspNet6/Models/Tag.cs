namespace TipOfTheDay.Models
{
    public class Tag
    {
        private readonly List<Tip> tips = new();
        private string category = "Default category";

        public int TagId { get; set; }
        public String Category { get => category; set => category = value; }
        public List<Tip> Tips
        {
            get { return tips; }
        }
    }
}
