using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class Sitelog
    {
        [Key]
/*PK*/  public int SiteLogId { get; set; }
        public DateTime DateTime { get; set; }
/*FK*/  public int PortalId { get; set; }
        public int? UserId { get; set; }
        public string Referrer { get; set; }
        public string Url { get; set; }
        public string UserAgent { get; set; }
        public string UserHostAddress { get; set; }
        public string UserHostName { get; set; }
        public int? TabId { get; set; }
        public int? AffiliateId { get; set; }

        public virtual Portal Portal { get; set; }
    }
}
