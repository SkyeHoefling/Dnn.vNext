using System.Linq;

namespace Dnn.vNext.Data
{
    public static class SeedData
    {
        public static void Initialize(DnnDbContext context)
        {
            context.Database.EnsureCreated();

            if (!context.Pages.Any())
            {
                var page = new Page
                {
                    Name = "Demo"
                };
                context.Pages.Add(page);
                context.SaveChanges();

                var module = new Module
                {
                    PageId = context.Pages.FirstOrDefault().Id,
                    ElementId = "content_3",
                    Path = "Modules/SimpleForm"
                };

                context.Modules.Add(module);
                context.SaveChanges();
            }
        }
    }
}
