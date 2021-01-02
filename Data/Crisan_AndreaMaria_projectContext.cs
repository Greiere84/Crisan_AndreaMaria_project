using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Crisan_AndreaMaria_project.Models;

namespace Crisan_AndreaMaria_project.Data
{
    public class Crisan_AndreaMaria_projectContext : DbContext
    {
        public Crisan_AndreaMaria_projectContext (DbContextOptions<Crisan_AndreaMaria_projectContext> options)
            : base(options)
        {
        }

        public DbSet<Crisan_AndreaMaria_project.Models.Movie> Movie { get; set; }

        public DbSet<Crisan_AndreaMaria_project.Models.ProductionCo> ProductionCo { get; set; }

        public DbSet<Crisan_AndreaMaria_project.Models.Star> Star { get; set; }

        public DbSet<Crisan_AndreaMaria_project.Models.Genre> Genre { get; set; }
    }
}
