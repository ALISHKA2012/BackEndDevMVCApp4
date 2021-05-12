using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogMVCApp.Models
{
    public class Article
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 80, MinimumLength = 2)]
        public string Title { get; set; }
        public virtual Author Author { get; set; }
        public int AuthorId { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime WrittenDate { get; set; }
        [Required]
        public string ImagePath  { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string ShortDescription { get; set; }
        public int ViewCount { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
        public virtual Menu Menu { get; set; }
        public int MenuId { get; set; }
        public Article()
        {
            Comments = new HashSet<Comment>();
            Tags = new HashSet<Tag>();
            Categories = new HashSet<Category>();
        }
    }
}