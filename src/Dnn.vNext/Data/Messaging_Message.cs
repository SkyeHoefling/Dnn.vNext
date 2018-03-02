using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class Messaging_Message
    {
        [Key]
/*PK*/  public int MessageId { get; set; }
        public int PortalId { get; set; }
        public int FromUserId { get; set; }
        public string ToUserName { get; set; }
        public string FromUserName { get; set; }
        public int ToUserId { get; set; }
        public int ToRoleId { get; set; }
        public int Status { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime Date { get; set; }
        public Guid Conversation { get; set; }
        public int? ReplyTo { get; set; }
        public bool AllowReply { get; set; }
        public bool SkipPortal { get; set; }
        public bool EmailSent { get; set; }
        public DateTime? EmailSentDate { get; set; }
        public Guid? EmailSchedulerInstance { get; set; }
    }
}
