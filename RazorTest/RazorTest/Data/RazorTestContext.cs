using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RazorTest.Models
{
    public class RazorTestContext : DbContext
    {
        public RazorTestContext (DbContextOptions<RazorTestContext> options)
            : base(options)
        {
        }

        public DbSet<RazorTest.Models.Movie> Movie { get; set; }
    }
}
