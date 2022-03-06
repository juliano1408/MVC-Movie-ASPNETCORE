using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMoviev2.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMoviev2Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMoviev2Context>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The Rm",
                        ReleaseDate = DateTime.Parse("2005-2-12"),
                        Genre = "Gospel",
                        Rating = "A",
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Title = "Other Side of the Heaven ",
                        ReleaseDate = DateTime.Parse("2000-3-13"),
                        Genre = "Gospel",
                        Rating = "R",
                        Price = 8.99M
                    },

                    new Movie
                    {
                        Title = "Meet the Mormons",
                        ReleaseDate = DateTime.Parse("2014-2-23"),
                        Genre = "Gospel",
                        Rating = "B",
                        Price = 9.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}