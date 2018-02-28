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
/*PK*/  public int MessageAttachmentID { get; set; }
/*FK*/  public int MessageID { get; set; }
        public int? FileID { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserID { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public virtual CoreMessaging_Message Message { get; set; }
    }
}
