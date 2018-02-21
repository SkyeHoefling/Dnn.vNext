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

        public DbSet<Module> Modules { get; set; }
        public DbSet<ModuleControl> ModuleControls { get; set; }
        public DbSet<ModuleDefinition> ModuleDefinitions { get; set; }
        public DbSet<ModulePermission> ModulePermissions { get; set; }
        public DbSet<ModuleSetting> ModuleSettings { get; set; }
        public DbSet<Tab> Tabs { get; set; }
        public DbSet<TabModule> TabModules { get; set; }
        public DbSet<TabModuleSetting> TabModuleSettings { get; set; }
    }
}
