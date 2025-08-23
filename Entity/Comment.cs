using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagazaApp.Entity
{
    public class Comment
    {
         public int CommentId { get; set; }
        public string? Text { get; set; }
        public DateTime PublishedOn { get; set; }
         public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }= null!;
    }
}