using System;
using System.ComponentModel.DataAnnotations;

namespace Dnn.vNext.Data
{
    public class CoreMessaging_NotificationTypeAction
    {
        [Key]
/*PK*/ public int NotificationTypeActionId { get; set; }

/*FK*/
        public int NotificationTypeId { get; set; }

        [Required]
        [MaxLength(100)]
        public string NameResourceKey { get; set; }

        [MaxLength(100)]
        public string DescriptionResourceKey { get; set; }

        [MaxLength(100)]
        public string ConfirmRescourceKey { get; set; }

        public int Order { get; set; }

        [Required]
        [MaxLength(500)]
        public string APICall { get; set; }

        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public virtual CoreMessaging_NotificationType NotificationType { get; set; }
    }
}