using Dnn.vNext.Data;
using Dnn.vNext.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Dnn.vNext.Controllers
{
    [JsonObject]
    public class PageModule
    {
        [JsonProperty("pageId")]
        public int PageId { get; set; }

        [JsonProperty("elementId")]
        public string ElementId { get; set; }

        [JsonProperty("modulePath")]
        public string ModulePath { get; set; }
    }

    [Route("api/[controller]")]
    public class PageController : Controller
    {
        private readonly DnnDbContext _context;
        public PageController(DnnDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("AddModule")]
        public IActionResult AddModule([FromBody]PageModule pageModule)
        {
            var page = _context.Pages
                .Include(p => p.PageModules)
                .FirstOrDefault();

            var numberOfModulesInElement = page.PageModules
                .Count(x => x.ElementId == pageModule.ElementId);

            var findModule = _context.Modules
                .FirstOrDefault(x => x.Path == pageModule.ModulePath);

            page.PageModules.Add(new Data.PageModule
            {
                PageId = pageModule.PageId,
                ElementId = pageModule.ElementId,
                ModuleId = findModule.Id,
                Order = numberOfModulesInElement
            });

            _context.SaveChanges();
            return Json("done");
        }

        [HttpPost]
        [Route("EditPage")]
        public IActionResult EditPage()
        {
            var modules = _context.Modules
                .Select(x => new Models.Module
                {
                    Id = x.Id.ToString(),
                    Icon = x.Icon,
                    Name = x.Name
                });
            return PartialView("~/Pages/_EditPage.cshtml", modules);
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
