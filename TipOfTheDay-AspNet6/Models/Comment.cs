namespace TipOfTheDay.Models
{
    public class Comment
    {
        private AppUser member = new();
        private string commentText = "Default text";

        public int CommentId { get; set; }
        public AppUser Member { get => member; set => member = value; }
        public String CommentText { get => commentText; set => commentText = value; }
    }
}
