using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestBlazorWebApp.Models;

namespace TestBlazorWebApp.Data
{
    public class TestBlazorWebAppContext : DbContext
    {
        public TestBlazorWebAppContext (DbContextOptions<TestBlazorWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<TestBlazorWebApp.Models.Movie> Movie { get; set; } = default!;
    }
}
