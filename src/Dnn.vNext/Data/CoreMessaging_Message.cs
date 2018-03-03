using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dnn.vNext.Data
{
    public class CoreMessaging_Message
    {
        [Key]
/*PK*/ public int MessageId { get; set; }

        public int? PortalId { get; set; }

/*FK*/
        public int? NotificationTypeId { get; set; }

        [MaxLength(2000)]
        public string To { get; set; }

        [MaxLength(200)]
        public string From { get; set; }

        [MaxLength(400)]
        public string Subject { get; set; }

        public string Body { get; set; }
        public int? ConversationId { get; set; }
        public bool? ReplyAllAllowed { get; set; }
        public int? SenderUserId { get; set; }
        public DateTime? ExpirationDate { get; set; }

        [MaxLength(200)]
        public string Context { get; set; }

        public bool? IncludeDismissAction { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public virtual CoreMessaging_NotificationType NotificationType { get; set; }

        public virtual ICollection<CoreMessaging_MessagingRecipient> CoreMessaging_MessagingRecipient { get; set; }
        public virtual ICollection<CoreMessaging_MessageAttachment> CoreMessaging_MessageAttachment { get; set; }
    }
}