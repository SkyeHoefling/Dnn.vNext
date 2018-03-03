using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class HtmlTextLog
    {
        [Key]
/*PK*/  public int HtmlTextLogId { get; set; }
/*FK*/  public int ItemId { get; set; }
/*FK*/  public int StateId { get; set; }
        public string Comment { get; set; }
        public bool Approved { get; set; }
        public int CreatedByUserId { get; set; }
        public DateTime CreatedOnDate { get; set; }

        public virtual HtmlText Item { get; set; }
        public virtual WorkflowState State { get; set; }
    }
}
