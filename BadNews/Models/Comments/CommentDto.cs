namespace BadNews.Models.Comments
{
    public class CommentDto
    {
        public string User { get; set; }
        
        public string Value { get; set; }

        public CommentDto(string user, string value)
        {
            User = user;
            Value = value;
        }
    }
}