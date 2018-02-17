using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class DnnDbContext : DbContext
    {
        public DnnDbContext(DbContextOptions<DnnDbContext> options) : base(options) { }

        public DbSet<Page> Pages { get; set; }
        public DbSet<Module> Modules { get; set; }


    }
}
