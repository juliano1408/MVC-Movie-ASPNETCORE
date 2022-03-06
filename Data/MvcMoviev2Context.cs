using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMoviev2.Data
{
    public class MvcMoviev2Context : DbContext
    {
        public MvcMoviev2Context (DbContextOptions<MvcMoviev2Context> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; }
    }
}
