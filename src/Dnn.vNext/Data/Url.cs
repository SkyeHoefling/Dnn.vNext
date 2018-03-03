using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class Urls
    {
        [Key]
/*PK*/  public int UrlId { get; set; }
/*FK*/  public int? PortalId { get; set; }
        public string Url { get; set; }

        public virtual Portal Portal { get; set; }
    }
}
