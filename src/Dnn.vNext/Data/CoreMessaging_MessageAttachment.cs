using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class CoreMessaging_MessageAttachment
    {
        [Key]
/*PK*/  public int MessageAttachmentId { get; set; }
/*FK*/  public int MessageId { get; set; }
        public int? FileId { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public virtual CoreMessaging_Message Message { get; set; }
    }
}
