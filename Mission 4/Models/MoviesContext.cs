using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_4.Models
{
    public class MoviesContext : DbContext
    {
        //Constructor 
        public MoviesContext (DbContextOptions<MoviesContext> options) : base (options)
        {

        }

        public DbSet<AddResponse> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Comedy" },
                new Category { CategoryID = 2, CategoryName = "Action" },
                new Category { CategoryID = 3, CategoryName = "Drama" },
                new Category { CategoryID = 4, CategoryName = "Fantasy" },
                new Category { CategoryID = 5, CategoryName = "Horror" },
                new Category { CategoryID = 6, CategoryName = "Mystery" },
                new Category { CategoryID = 7, CategoryName = "Romance" },
                new Category { CategoryID = 8, CategoryName = "Thriller" },
                new Category { CategoryID = 9, CategoryName = "Western" }
            );

            mb.Entity<AddResponse>().HasData(
                new AddResponse
                {
                    MovieID = 1,
                    CategoryID = 1,
                    Title = "Hot Rod",
                    Year = 2007,
                    Director = "Akiva Schaffer",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },
                new AddResponse
                {
                    MovieID = 2,
                    CategoryID = 1,
                    Title = "Napoleon Dynamite",
                    Year = 2004,
                    Director = "Jared Hess",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },
                new AddResponse
                {
                    MovieID = 3,
                    CategoryID = 1,
                    Title = "Zootopia",
                    Year = 2016,
                    Director = "Byron Howard, Rich Moore",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                }
            );
        }
    }
}
