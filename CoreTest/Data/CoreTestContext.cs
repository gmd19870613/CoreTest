using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CoreTest.Models;

namespace CoreTest.Data
{
    public class CoreTestContext : DbContext
    {
        public CoreTestContext (DbContextOptions<CoreTestContext> options)
            : base(options)
        {
        }

        public DbSet<CoreTest.Models.Movie>? Movie { get; set; }
    }
}
