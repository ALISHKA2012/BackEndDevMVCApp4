using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogMVCApp.Models
{
    public class ArticleTravelModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime WrittenDate { get; set; }
        public string ImagePath { get; set; }
        public string ShortDescription { get; set; }
        public string AuthorImage { get; set; }
        public int ViewCount { get; set; }
        public string AuthorName { get; set; }
        public int CommentsCount { get; set; }
    }
}