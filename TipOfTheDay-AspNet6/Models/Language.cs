namespace TipOfTheDay.Models
{
    public class Language
    {
        private string name = "Defualt language";

        public int LanguageId { get; set; }
        public String Name { get => name; set => name = value; }
    }
}
