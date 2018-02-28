using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class PortalAlias
    {
        [Key]
/*PK*/  public int PortalAliasID { get; set; }
/*FK*/  public int PortalID { get; set; }
        public string HTTPAlias { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserID { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
        public string BrowserType { get; set; }
        public string Skin { get; set; }
        public string CulturCode { get; set; }
        public bool IsPrimary { get; set; }

        public virtual Portal Portal { get; set; }
    }
}
