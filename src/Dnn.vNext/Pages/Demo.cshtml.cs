using Dnn.vNext.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
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

        public (string id, string path) Module { get; set; }
        public string ModulePath { get; } = "Modules/SimpleForm";

        public void OnGet()
        {
            var module = _context.Modules.FirstOrDefault();
            Module = (module.ElementId, module.Path);
        }
    }
}