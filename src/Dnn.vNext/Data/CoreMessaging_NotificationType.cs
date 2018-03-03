using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dnn.vNext.Data
{
    public class CoreMessaging_NotificationType
    {
        [Key]
/*PK*/ public int NotificationTypeId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(2000)]
        public string Description { get; set; }

        public int? TTL { get; set; }

/*FK*/
        public int? DesktopModuleId { get; set; }

        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
        public bool IsTask { get; set; }

        public virtual DesktopModule DesktopModule { get; set; }

        public virtual ICollection<CoreMessaging_Message> CoreMessaging_Message { get; set; }

        public virtual ICollection<CoreMessaging_NotificationTypeAction> CoreMessaging_NotificationTypeAction
        {
            get;
            set;
        }
    }
}