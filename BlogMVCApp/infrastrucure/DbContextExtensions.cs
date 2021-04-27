using BlogMVCApp.Data;
using BlogMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogMVCApp.infrastrucure
{
    public static class DbContextExtensions
    {
        public static IEnumerable<ArticleIndexModel> GetPaginatableArticleData(this BlogDbContext _blogDbContext, int page, int _itemsPerPage)
        {
            return _blogDbContext.Articles.OrderByDescending(art => art.PublishDate).Skip((page - 1) * _itemsPerPage).Take(_itemsPerPage)

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
                AuthorName = x.Author.User.UserName
                //ViewCount = x.ViewCount
            }).ToList();
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


    }
}