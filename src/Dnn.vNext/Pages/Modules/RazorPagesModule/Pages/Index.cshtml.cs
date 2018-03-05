using DotNetNuke.Web.Mvc.RazorPages.SDK;

namespace DNNTAG.RazorPagesModule.Pages
{
    public class Index : DnnPageModel
    {        
        
        public Index()
        {            
        }

        public string WelcomeMessage => "Hello DNN Razor Pages, it's a brand new world!";
    }
}