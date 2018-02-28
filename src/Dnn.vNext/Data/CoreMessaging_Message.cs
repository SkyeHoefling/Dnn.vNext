using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class CoreMessaging_Message
    {
        [Key]
/*PK*/ public int MessageID { get; set; }
        public int? PortalID { get; set; }
/*FK*/  public int? NotificationTypeID { get; set; }
        public string To { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public int? ConversationID { get; set; }
        public bool? ReplyAllAllowed { get; set; }
        public int? SenderUserID { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string Context { get; set; }
        public bool? IncludeDismissAction { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserID { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public virtual CoreMessaging_NotificationType NotificationType { get; set; }

        public virtual ICollection<CoreMessaging_MessagingRecipient> CoreMessaging_MessagingRecipient { get; set; }
        public virtual ICollection<CoreMessaging_MessageAttachment> CoreMessaging_MessageAttachment { get; set; }
    }
}
