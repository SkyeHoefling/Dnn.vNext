using Dnn.vNext.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Dnn.vNext.Pages
{
    public abstract class DnnPageModel : PageModel
    {
        private readonly DnnDbContext _context;
        public DnnPageModel(DnnDbContext context)
        {
            _context = context;
        }

        public IEnumerable<(string id, string path)> Modules { get; set; }
        public string ModulePath { get; } = "Modules/SimpleForm";
        public int PageId { get; set; }

        public void OnGet()
        {
            var page = _context.Pages
                .Include(p => p.PageModules)
                    .ThenInclude(pm => pm.Module)
                .FirstOrDefault();

            PageId = page.Id;
            Modules = page.PageModules.Select(x => (x.ElementId, x.Module.Path));
        }
    }
}
