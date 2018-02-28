using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class TabVersion
    {
        [Key]
/*PK*/  public int TabVersionId { get; set; }
/*FK*/  public int TabId { get; set; }
        public int Version { get; set; }
        public DateTime TimeStamp { get; set; }
        public bool IsPublished { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserID { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public virtual Tab Tab { get; set; }
        public virtual ICollection<TabVersionDetail> TabVersionDetail { get; set; }
    }
}
