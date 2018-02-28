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
/*PK*/  public int RecipientID { get; set; }
/*FK*/  public int MessageID { get; set; }
        public int UserID { get; set; }
        public bool Read { get; set; }
        public bool Archived { get; set; }
        public bool EmailSent { get; set; }
        public DateTime? EmailSentDate { get; set; }
        public Guid? EmailSchedulerInstance { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserID { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
        public bool SendToast { get; set; }

        public virtual CoreMessaging_Message Message { get; set; }
    }
}
