using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class HtmlText
    {
        [Key]
/*FK*/  public int ModuleID { get; set; }
/*PK*/  public int ItemID { get; set; }
        public string Content { get; set; }
        public int? Version { get; set; }
/*FK*/  public int? StateID { get; set; }
        public bool? IsPublished { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserID { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
        public string Summary { get; set; }

        public virtual Module Module { get; set; }
        public virtual WorkflowState State { get; set; }

        public virtual ICollection<HtmlTextLog> HtmlTextLog { get; set; }
        public virtual ICollection<HtmlTextUser> HtmlTextUser { get; set; }
    }
}
