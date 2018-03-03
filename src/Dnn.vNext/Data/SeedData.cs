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


                var moduleDef1 = new ModuleDefinition
                {
                    ModuleDefId = 0,
                    DesktopModule = new DesktopModule
                    {
                        DesktopModuleId = 0,
                        FolderName = "RazorPagesModule",
                        FriendlyName = "RazorPagesModule",
                        ModuleName = "RazorPagesModule",
                        Package = new Package
                        {
                            PackageId = 0,
                            PackageTypeNavigation = new Package_Type
                            {
                                PackageType = Guid.NewGuid().ToString()
                            }
                        }
                    }
                };

                // AH - we need to add a second module later
                //var moduleDef2 = new ModuleDefinition
                //{
                //    ModuleDefId = 1,
                //    DesktopModule = new DesktopModule
                //    {
                //        DesktopModuleId = 1,
                //        FolderName = "RazorPagesModule",
                //        FriendlyName = "RazorPagesModule",
                //        ModuleName = "RazorPagesModule",
                //        Package = new Package
                //        {
                //            PackageId = 1,
                //            PackageTypeNavigation = new Package_Type
                //            {
                //                PackageType = Guid.NewGuid().ToString()
                //            }
                //        }
                //    }
                //};

                context.ModuleDefinitions.AddRange(moduleDef1);

                var modules = new[] {
                    new Module
                    {
                        ModuleDefId = moduleDef1.ModuleDefId,
                        Icon = "tasks",
                        Name = "Simple Form",
                        Path = "Modules/SimpleForm"
                    },
                    //new Module
                    //{
                    //    ModuleDefId = moduleDef2.ModuleDefId,
                    //    Icon = "pencil",
                    //    Name = "HTML Editor",
                    //    Path = "Modules/SimpleForm"
                    //}
                };
                context.Modules.AddRange(modules);
                context.SaveChanges();
            }
        }
    }
}
