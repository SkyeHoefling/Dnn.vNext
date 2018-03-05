using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Dnn.vNext.Data
{
    public static class SeedData
    {
        public static void Initialize(DnnDbContext context)
        {
            context.Database.Migrate();

            if (!context.Tabs.Any())
            {
                var page = new Tab
                {
                    Name = "Demo"
                };
                context.Tabs.Add(page);

                //var package1 = new Package
                //{
                //    PackageId = 0,
                //    PackageTypeNavigation = new Package_Type
                //    {
                //        PackageType = Guid.NewGuid().ToString()
                //    }
                //};

                var package2 = new Package
                {
                    PackageTypeNavigation = new Package_Type
                    {
                        PackageType = Guid.NewGuid().ToString()
                    }
                };

                context.Packages.AddRange(package2);

                //var moduleDef1 = new ModuleDefinition
                //{
                //    ModuleDefId = 0,
                //    DesktopModule = new DesktopModule
                //    {
                //        DesktopModuleId = 0,
                //        FolderName = "SimpleForm",
                //        FriendlyName = "SimpleForm",
                //        ModuleName = "SimpleForm",
                //        PackageId = package1.PackageId
                //    }
                //};
                
                var moduleDef2 = new ModuleDefinition
                {
                    DesktopModule = new DesktopModule
                    {
                        FolderName = "RazorPagesModule",
                        FriendlyName = "RazorPagesModule",
                        ModuleName = "RazorPagesModule",
                        PackageId = package2.PackageId
                    }
                };

                context.ModuleDefinitions.AddRange(moduleDef2);

                var modules = new[] {
                    //new Module
                    //{
                    //    ModuleDefId = moduleDef1.ModuleDefId,
                    //    Icon = "tasks",
                    //    Name = "Simple Form",
                    //    Path = "Modules/SimpleForm"
                    //},
                    new Module
                    {
                        ModuleDefId = moduleDef2.ModuleDefId,
                        Icon = "pencil",
                        Name = "HTML Editor",
                        Path = "Modules/RazorPagesModule/Pages/Index"
                    }
                };
                context.Modules.AddRange(modules);
                context.SaveChanges();
            }
        }
    }
}
