using Microsoft.EntityFrameworkCore;
using Parcial2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial2.Data
{
    
        public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {

            }

            public DbSet<Suerte> Suerte { get; set; }
        }
    
}
