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
/*PK*/  public int HtmlTextLogID { get; set; }
/*FK*/  public int ItemID { get; set; }
/*FK*/  public int StateID { get; set; }
        public string Comment { get; set; }
        public bool Approved { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedOnDate { get; set; }

        public virtual HtmlText Item { get; set; }
        public virtual WorkflowState State { get; set; }
    }
}
