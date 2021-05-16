using BlogMVCApp.Data;
using BlogMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace BlogMVCApp.infrastrucure
{
    public static class DbContextExtensions
    {
        public static async Task<IEnumerable<ArticleIndexModel>> GetPaginatableArticleDataAsync(this BlogDbContext _blogDbContext, int page, int _itemsPerPage)
        {
            return await _blogDbContext.Articles.OrderByDescending(art => art.PublishDate).Skip((page - 1) * _itemsPerPage).Take(_itemsPerPage)

            .Select(x => new ArticleIndexModel
            {
                Id = x.Id,
                Categories = x.Categories.Select(y => new CategoryModel
                {
                    Id = y.Id,
                    Name = y.Name
                }),
                ImagePath = x.ImagePath,
                ShortDescription = x.ShortDescription,
                PublishDate = x.PublishDate,
                Title = x.Title,
                CommentsCount = x.Comments.Count,
                AuthorName =  x.Author.Name + " " + x.Author.Surname,
                ViewCount = x.ViewCount
            }).ToListAsync();
        }

        public static IEnumerable<CategoryModel> GetCategoriesData(this BlogDbContext _blogDbContext)
        {
            return _blogDbContext.Categories.Select(x => new CategoryModel
            {
                Id = x.Id,
                Name = x.Name,
                ArticleCount = x.Articles.Count
            }).ToList();
        }
        public static IEnumerable<TagModel> GetTagsData(this BlogDbContext _blogDbContext)
        {
            return _blogDbContext.Tags.Select(x => new TagModel
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
          
        }
        public static IEnumerable<ArticlePopularModel> GetArticlePopularModels(this BlogDbContext _blogDbContext)
        {
                    return _blogDbContext.Articles.OrderByDescending(art => art.ViewCount).Take(3)
           .Select(x => new ArticlePopularModel
           {
               Id = x.Id,
               ImagePath = x.ImagePath,
               PublishDate = x.PublishDate,
               Title = x.Title,
               CommentsCount = x.Comments.Count,
               AuthorName = x.Author.Name + " " + x.Author.Surname,
           }).ToList();
        }

        public static async Task<IEnumerable<ArticleTravelModel>> GetPaginatableTravelArticleDataAsync(this BlogDbContext _blogDbContext, int page, int _itemsPerPage)
        {
            return await _blogDbContext.Articles.OrderByDescending(art => art.WrittenDate).Skip((page - 1) * _itemsPerPage).Take(_itemsPerPage)

            .Select(x => new ArticleTravelModel
            {
                Id = x.Id,
                ImagePath = x.ImagePath,
                ShortDescription = x.ShortDescription,
                WrittenDate = x.PublishDate,
                Title = x.Title,
                CommentsCount = x.Comments.Count,
                AuthorName = x.Author.Name + " " + x.Author.Surname,
                ViewCount = x.ViewCount,
                AuthorImage = x.Author.ProfilePicture
            }).ToListAsync();
        }

    }
}