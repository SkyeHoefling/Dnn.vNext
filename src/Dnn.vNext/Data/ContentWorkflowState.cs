using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class ContentWorkflowState
    {
        [Key]
/*PK*/  public int StateID { get; set; }
/*FK*/  public int WorkflowID { get; set; }
        public string StateName { get; set; }
        public int Order { get; set; }
        public bool IsActive { get; set; }
        public bool SendEmail { get; set; }
        public bool SendMessage { get; set; }
        public bool IsDisposalState { get; set; }
        public string OnCompleteMessageSubject { get; set; }
        public string OnCompleteMessageBody { get; set; }
        public string OnDiscardMessageSubject { get; set; }
        public bool IsSystem { get; set; }
        public bool SendNotification { get; set; }
        public bool SendNotificationToAdministrators { get; set; }

        public virtual ContentWorkflow ContentWorkflow { get; set; }

        public virtual ICollection<ContentWorkflowStatePermission> ContentWorkflowStatePermission { get; set; }
        public virtual ICollection<ContentItem> ContentItem { get; set; }
        
    }
}
