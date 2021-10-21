using BlogPlatform.Extensions;
using BlogPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Repositories
{
    public class ContentRepository : IRepository<Content>
    {
        public BlogContext db;

        public ContentRepository(BlogContext db)
        {
            this.db = db;
        }

        // Create
        public void Create(Content obj)
        {
            db.Contents.Add(obj);
            db.SaveChanges();
        }
        // Read
        public IEnumerable<Content> GetAll()
        {
            return db.Contents.ToList();
        }
        public Content GetByID(int id)
        {
            return db.Contents.Find(id);
            //return db.Contents.Where(c => c.Author == "" && c.Now ==  && c.Id == id).FirstOrDefault();
        }
        // Update
        public void Update(Content obj)
        {
            db.Contents.Update(obj);
            db.SaveChanges();
        }
        // Delete
        public void Delete(Content obj)
        {
            db.Contents.Remove(obj);
            db.SaveChanges();
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return db.Categories.ToList();
        }
    }
}
