using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class ContentWorkflowLog
    {
        [Key]
/*PK*/  public int WorkflowLogID { get; set; }
        public string Action { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; }
        public int? User { get; set; }
/*FK*/  public int WorkflowID { get; set; }
/*FK*/  public int ContentItemID { get; set; }
        public int Type { get; set; }

        public virtual ContentItem ContentItem { get; set; }
        public virtual ContentWorkflow ContentWorkflow { get; set; }
    }
}
