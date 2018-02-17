using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dnn.vNext.Pages
{
    public class DemoModel : PageModel
    {
        public string ModulePath { get; } = "Modules/SimpleForm";

        public void OnGet()
        {

        }
    }
}