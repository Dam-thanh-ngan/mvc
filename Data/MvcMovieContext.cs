using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using demonet.Models;

namespace demonet.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<demonet.Models.Movie> Movie { get; set; }

        public DbSet<demonet.Models.Student> Student { get; set; }

    }
}
