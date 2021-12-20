using System;
using System.Collections.Generic;
using System.Linq;
using BadNews.Repositories.Comments;

namespace BadNews.Models.Comments
{
    public class CommentsDto
    {
        public Guid NewsId { get; set; }

        public IReadOnlyCollection<CommentDto> Comments { get; set; }

        public CommentsDto(IReadOnlyCollection<Comment> comments)
        {
            Comments = comments.Select(c => new CommentDto(c.User, c.Value)).ToArray();
        }
    }
}