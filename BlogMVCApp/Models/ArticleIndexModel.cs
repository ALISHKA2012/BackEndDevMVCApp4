using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogMVCApp.Models
{
    public class ArticleIndexModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 80, MinimumLength = 2)]
        public string Title { get; set; }
      
        public DateTime PublishDate { get; set; }
        [Required]
        public string ImagePath { get; set; }
        [Required]
        public string ShortDescription { get; set; }
        public uint ViewCount { get; set; }
        public string AuthorName { get; set; }

        public IEnumerable<CategoryModel> Categories { get; set; }
        public int CommentsCount { get; set; }


    }
}