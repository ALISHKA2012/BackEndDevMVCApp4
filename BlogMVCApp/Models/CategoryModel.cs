using System.ComponentModel.DataAnnotations;

namespace BlogMVCApp.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 2)]
        public string Name { get; set; }
        public int ArticleCount { get; set; }
    }
}