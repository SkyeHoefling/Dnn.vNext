using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dnn.vNext.Data
{
    public class ContentWorkflowState
    {
        [Key]
/*PK*/ public int StateId { get; set; }

/*FK*/
        public int WorkflowId { get; set; }

        [Required]
        [MaxLength(40)]
        public string StateName { get; set; }

        public int Order { get; set; }
        public bool IsActive { get; set; }
        public bool SendEmail { get; set; }
        public bool SendMessage { get; set; }
        public bool IsDisposalState { get; set; }

        [Required]
        [MaxLength(256)]
        public string OnCompleteMessageSubject { get; set; }

        [Required]
        [MaxLength(1024)]
        public string OnCompleteMessageBody { get; set; }

        [Required]
        [MaxLength(1024)]
        public string OnDiscardMessageBody { get; set; }

        [Required]
        [MaxLength(256)]
        public string OnDiscardMessageSubject { get; set; }

        public bool IsSystem { get; set; }
        public bool SendNotification { get; set; }
        public bool SendNotificationToAdministrators { get; set; }

        public virtual ContentWorkflow ContentWorkflow { get; set; }

        public virtual ICollection<ContentWorkflowStatePermission> ContentWorkflowStatePermission { get; set; }
        public virtual ICollection<ContentItem> ContentItem { get; set; }
    }
}