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

        public IDictionary<string, IEnumerable<string>> Modules { get; set; }
        public string ModulePath { get; } = "Modules/SimpleForm";
        public int PageId { get; set; }

        public void OnGet()
        {
            var page = _context.Pages
                .Include(p => p.PageModules)
                    .ThenInclude(pm => pm.Module)
                .FirstOrDefault();

            PageId = page.Id;
            Modules = page.PageModules
                .GroupBy(pm => pm.ElementId,
                         pm => pm,
                         (key, g) => new { ElementId = key, PageModules = g })
                .ToDictionary(x => x.ElementId, x => x.PageModules.OrderBy(pm => pm.Order).Select(pm => pm.Module.Path));
        }
    }
}
