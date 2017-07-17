using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BeerTracker5000.Models
{
    public class BeerTracker5000Context : DbContext
    {
        public BeerTracker5000Context (DbContextOptions<BeerTracker5000Context> options)
            : base(options)
        {
        }

        public DbSet<BeerTracker5000.Models.Beer> Beer { get; set; }
    }
}
