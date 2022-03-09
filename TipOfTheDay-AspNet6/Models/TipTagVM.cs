namespace TipOfTheDay.Models
{
    public class TagChoice
    {
        private Tag tag = new();

        public bool Selected { get; set; }
        public Tag Tag { get => tag; set => tag = value; }
    }

    public class TipTagVM
    {
        private Tip tip = new();
        private List<TagChoice> tagSelections = new();

        public Tip Tip { get => tip; set => tip = value; }
        public List<TagChoice> TagSelections { get => tagSelections; set => tagSelections = value; }
    }
}
