using BlogMVCApp.Areas.Admin.Data;
using BlogMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace BlogMVCApp.infrastrucure
{
    public static class DbSetExtensions
    {
        public async static Task<User> GetUserAsync(this DbSet<User> _users, LoginModel model) 
        {
            if (!_users.Any(x => x.Email == model.Email && x.Password == model.Password))
                return null;
            else
                return await _users.Where(x => x.Email == model.Email && x.Password == model.Password).SingleOrDefaultAsync();
        }
    }
}