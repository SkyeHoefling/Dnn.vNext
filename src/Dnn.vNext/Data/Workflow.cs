using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class Workflow
    {
        [Key]
/*PK*/  public int WorkflowId { get; set; }
        public int? PortalId { get; set; }
        public string WorkflowName { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<WorkflowState> WorkflowState { get; set; }
    }
}
