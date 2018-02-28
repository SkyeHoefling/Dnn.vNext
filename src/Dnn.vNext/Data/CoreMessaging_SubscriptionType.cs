using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class CoreMessaging_SubscriptionType
    {
        [Key]
/*PK*/  public int SubscriptionTypeID { get; set; }
        public string SubscriptionName { get; set; }
        public string FriendlyName { get; set; }
        public int? DesktopModuleID { get; set; }

        public virtual ICollection<CoreMessaging_Subscription> CoreMessaging_Subscription { get; set; }
    }
}
