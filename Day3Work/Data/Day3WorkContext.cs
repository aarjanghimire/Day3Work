using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Day3Work.Models;

namespace Day3Work.Data
{
    public class Day3WorkContext : DbContext
    {
        public Day3WorkContext (DbContextOptions<Day3WorkContext> options)
            : base(options)
        {
        }

        public DbSet<Day3Work.Models.Products> Products { get; set; } = default!;

        public DbSet<Day3Work.Models.Users>? Users { get; set; }
    }
}
