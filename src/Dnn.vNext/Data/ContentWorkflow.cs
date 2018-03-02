using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dnn.vNext.Data
{
    public class ContentWorkflow
    {
        [Key]
/*PK*/ public int WorkflowId { get; set; }

        public int? PortalId { get; set; }

        [Required]
        [MaxLength(40)]
        public string WorkflowName { get; set; }

        [MaxLength(256)]
        public string Description { get; set; }

        public bool IsDeleted { get; set; }
        public bool StartAfterCreating { get; set; }
        public bool StartAfterEditing { get; set; }
        public bool DispositionEnabled { get; set; }
        public bool IsSystem { get; set; }

        [Required]
        [MaxLength(40)]
        public string WorkflowKey { get; set; }

        public virtual ICollection<ContentWorkflowLog> ContentWorkflowLog { get; set; }
        public virtual ICollection<ContentWorkflowSource> ContentWorkflowSource { get; set; }
        public virtual ICollection<ContentWorkflowState> ContentWorkflowState { get; set; }
        public virtual ICollection<Folder> Folder { get; set; }
    }
}