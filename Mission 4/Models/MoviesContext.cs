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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<AddResponse>().HasData(
                new AddResponse
                {
                    MovieID = 1,
                    Category = "Comedy",
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
                    Category = "Comedy, Indie film",
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
                    Category = "Family, Comedy",
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
