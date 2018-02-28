using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class ContentWorkflow
    {
        [Key]
/*PK*/  public int WorkflowID { get; set; }
        public int? PortalID { get; set; }
        public string WorkflowName { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public bool StartAfterCreating { get; set; }
        public bool StartAfterEditing { get; set; }
        public bool DispositionEnabled { get; set; }
        public bool IsSystem { get; set; }
        public string WorkflowKey { get; set; }

        public virtual ICollection<ContentWorkflowLog> ContentWorkflowLog { get; set; }
        public virtual ICollection<ContentWorkflowSource> ContentWorkflowSource { get; set; }
        public virtual ICollection<ContentWorkflowState> ContentWorkflowState { get; set; }
        public virtual ICollection<Folder> Folder { get; set; }

    }
}
