using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class TabUrl
    {
        [Key, Column(Order = 0)]
/*PK*/  public int TabId { get; set; }

        [Key, Column(Order = 1)]
/*PK*/  public int SeqNum { get; set; }


        public string Url { get; set; }
        public string QueryString { get; set; }
        public string HttpStatus { get; set; }
        public string CultureCode { get; set; }
        public bool IsSystem { get; set; }
        public int? PortalAliasId { get; set; }
        public int? PortalAliasUsage { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public virtual Tab Tab { get; set; }
    }
}
