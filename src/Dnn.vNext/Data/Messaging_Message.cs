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
/*PK*/  public int MessageID { get; set; }
        public int PortalID { get; set; }
        public int FromUserID { get; set; }
        public string ToUserName { get; set; }
        public string FromUserName { get; set; }
        public int ToUserID { get; set; }
        public int ToRoleID { get; set; }
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
