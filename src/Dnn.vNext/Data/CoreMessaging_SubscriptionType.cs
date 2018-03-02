using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dnn.vNext.Data
{
    public class CoreMessaging_SubscriptionType
    {
        [Key]
/*PK*/ public int SubscriptionTypeId { get; set; }

        [Required]
        [MaxLength(50)]
        public string SubscriptionName { get; set; }

        [Required]
        [MaxLength(50)]
        public string FriendlyName { get; set; }

        public int? DesktopModuleId { get; set; }

        public virtual ICollection<CoreMessaging_Subscription> CoreMessaging_Subscription { get; set; }
    }
}