namespace TipOfTheDay.Models
{
    public class Tip
    {
        private readonly List<Language> languages = new();
        private readonly List<Tag> tags = new();
        private readonly List<Comment> comments = new();
        private AppUser user = new();

        public int TipId { get; set; }

        public AppUser Member{ get => user; set => user = value; }

        public List<Language> Languages
        {
            get { return languages; }
        }

        public List<Tag> Tags
        {
            get { return tags; }
        }

        public List<Comment> Comments
        {
            get { return comments; }
        }

        public String? TipText { get; set; }

    }
}
