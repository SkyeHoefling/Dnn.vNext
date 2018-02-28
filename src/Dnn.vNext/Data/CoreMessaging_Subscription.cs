using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class CoreMessaging_Subscription
    {
        [Key]
/*PK*/  public int SubscriptionID { get; set; }
/*FK*/  public int UserID { get; set; }
/*FK*/  public int? PortalID { get; set; }
/*FK*/  public int  SubscriptionTypeID { get; set; }
        public string ObjectKey { get; set; }
        public string ObjectData { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOnDate { get; set; }
/*FK*/  public int? ModuleID { get; set; }
        public int? TabID { get; set; }

        public virtual User User { get; set; }
        //public virtual Portal Portal { get; set; }
        public virtual CoreMessaging_SubscriptionType SubscriptionType { get; set; }
        public virtual Module Module { get; set; }
    }
}
