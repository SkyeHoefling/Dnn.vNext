using Dnn.vNext.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Dnn.vNext.Pages
{
    public class DemoModel : PageModel
    {
        private readonly DnnDbContext _context;
        public DemoModel(DnnDbContext context)
        {
            _context = context;
        }

        public IEnumerable<(string id, string path)> Modules { get; set; }
        public string ModulePath { get; } = "Modules/SimpleForm";

        public void OnGet()
        {
            var page = _context.Pages
                .Include(p => p.Modules)
                .FirstOrDefault();
            var modules = page.Modules;
            Modules = page.Modules.Select(x => (x.ElementId, x.Path));
        }
    }
}