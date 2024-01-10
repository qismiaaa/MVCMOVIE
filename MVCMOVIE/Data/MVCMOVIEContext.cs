using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCMOVIE.Models;

namespace MVCMOVIE.Data
{
    public class MVCMOVIEContext : DbContext
    {
        public MVCMOVIEContext (DbContextOptions<MVCMOVIEContext> options)
            : base(options)
        {
        }

        public DbSet<MVCMOVIE.Models.Movie> Movie { get; set; } 
    }
}
