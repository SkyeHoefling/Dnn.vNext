using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class CoreMessaging_NotificationType
    {
        [Key]
/*PK*/  public int NotificationTypeID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? TTL { get; set; }
/*FK*/  public int? DesktopModuleID { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserID { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
        public bool IsTask { get; set; }

        public virtual DesktopModule DesktopModule { get; set; }

        public virtual ICollection<CoreMessaging_Message> CoreMessaging_Message { get; set; }
        public virtual ICollection<CoreMessaging_NotificationTypeAction> CoreMessaging_NotificationTypeAction { get; set; }
    }
}
