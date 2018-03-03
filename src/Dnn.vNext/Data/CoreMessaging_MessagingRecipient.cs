using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class CoreMessaging_MessagingRecipient
    {
        [Key]
/*PK*/  public int RecipientId { get; set; }
/*FK*/  public int MessageId { get; set; }
        public int UserId { get; set; }
        public bool Read { get; set; }
        public bool Archived { get; set; }
        public bool EmailSent { get; set; }
        public DateTime? EmailSentDate { get; set; }
        public Guid? EmailSchedulerInstance { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
        public bool SendToast { get; set; }

        public virtual CoreMessaging_Message Message { get; set; }
    }
}
