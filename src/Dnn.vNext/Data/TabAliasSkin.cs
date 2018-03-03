using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class TabAliasSkin
    {
        [Key]
/*PK*/  public int TabAliasSkinId { get; set; }
        public int TabId { get; set; }
        public int PortalAliasId { get; set; }
        public string SkinSrc { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
    }
}
