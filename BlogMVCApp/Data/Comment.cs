using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogMVCApp.Models
{
    public class Comment
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(1000)]
        public string Text { get; set; }
        [Required]
        [EmailAddress]
        [MaxLength(50)]
        public string Email { get; set; }
        public string WebSite { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public virtual Article Article { get; set; }
        public int ArticleId { get; set; }
    }
}