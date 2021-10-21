using BlogPlatform.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform
{
    public class BlogContext: DbContext
    {
        public DbSet<Content> Contents { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb; Database=BlogDB_101321; Trusted_Connection=True";

            optionsBuilder.UseSqlServer(connectionString).UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Content>().HasData(
                new Content() { Id = 1, Title = "How To Get a Man To Ask You To Dance", Author = "Deserae Florentine", Body = "Body body body body body body body body body body body body body body body body body", CategoryId = 3 },
                new Content() { Id = 2, Title = "Best Dancing Shoes", Author = "Brandon Bell", Body = "Body body body body body body body body body body body body body body body body body", CategoryId = 1 },
                new Content() { Id = 3, Title = "90's Bachata", Author = "Julio Santiago", Body = "Body body body body body body body body body body body body body body body body body", CategoryId = 2 },
                new Content() { Id = 4, Title = "Who Is The Best Salsa Singer Of All Time: Marc Anthony Or Hector Lavoe?", Author = "Neil Potbelly", Body = "Body body body body body body body body body body body body body body body body body", CategoryId = 2 },
                new Content() { Id = 5, Title = "Do You Need To Know Spanish To Appreciate Bachata Music?", Author = "Brittany Rabbit", Body = "Body body body body body body body body body body body body body body body body body", CategoryId = 2 },
                new Content() { Id = 6, Title = "What Is The Hardest Latin Dance To Learn?", Author = "Donna Doleur", Body = "Body body body body body body body body body body body body body body body body body", CategoryId = 1 },
                 new Content() { Id = 7, Title = "The Dancing Couple's Guide To Navigating Jealousy", Author = "Randy Super", Body = "Body body body body body body body body body body body body body body body body body", CategoryId = 3 },
                 new Content() { Id = 8, Title = "Five Salsa Moves You Should Know", Author = "Kay Dee", Body = "Body body body body body body body body body body body body body body body body body", CategoryId = 2 },
                 new Content() { Id = 9, Title = "Important Milonga Etiquette", Author = "Maria Reuben", Body = "Body body body body body body body body body body body body body body body body body", CategoryId = 3 }
                );

            modelbuilder.Entity<Category>().HasData(
                new Category() { Id = 1, CatName = "Dance Steps"},
                new Category() { Id = 2, CatName = "Music" },
                new Category() { Id = 3, CatName = "Social Dancing" }
                );
        }
    }
}
