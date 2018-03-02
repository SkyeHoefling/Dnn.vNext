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
                context.SaveChanges();

                
                var moduleDef = new ModuleDefinition
                {
                    ModuleDefId = 0,
                    DesktopModule = new DesktopModule()
                };

                context.ModuleDefinitions.Add(moduleDef);
                context.SaveChanges();

                var modules = new[] {
                    new Module
                    {
                        ModuleDefId = moduleDef.ModuleDefId,
                        Icon = "tasks",
                        Name = "Simple Form",
                        Path = "Modules/SimpleForm"
                    },
                    //new Module
                    //{
                    //    Icon = "pencil",
                    //    Name = "HTML Editor",
                    //    Path = "Modules/SimpleForm"
                    //}
                };
                context.Modules.AddRange(modules);
                context.SaveChanges();
                

                // todo - cleanup
                //var module = new PageModule
                //{
                //    PageId = context.Pages.FirstOrDefault().Id,
                //    ElementId = "content_3",
                //    Path = "Modules/SimpleForm"
                //};

                //context.Modules.Add(module);
                //context.SaveChanges();
            }
        }
    }
}
