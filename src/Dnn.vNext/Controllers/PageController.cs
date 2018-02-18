using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dnn.vNext.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Dnn.vNext.Controllers
{
    [JsonObject]
    public class PageModule
    {
        [JsonProperty("pageId")]
        public string PageId { get; set; }

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
                .Include(p => p.Modules)
                .FirstOrDefault();
            page.Modules.Add(new Module
            {
                ElementId = pageModule.ElementId,
                Path = pageModule.ModulePath
            });
            _context.SaveChanges();
            return Json("done");
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
