using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class ContentWorkflowSource
    {
        [Key]
/*PK*/  public int SourceID { get; set; }
/*FK*/  public int WorkflowID { get; set; }
        public string SourceName { get; set; }
        public string SourceType { get; set; }

        public virtual ContentWorkflow ContentWorkflow { get; set; }
    }
}
