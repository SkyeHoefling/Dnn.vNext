using System;
using System.ComponentModel.DataAnnotations;

namespace Dnn.vNext.Data
{
    public class CoreMessaging_Subscription
    {
        [Key]
/*PK*/ public int SubscriptionId { get; set; }

/*FK*/
        public int UserId { get; set; }

/*FK*/
        public int? PortalId { get; set; }

/*FK*/
        public int SubscriptionTypeId { get; set; }

        [MaxLength(255)]
        public string ObjectKey { get; set; }

        public string ObjectData { get; set; }

        [Required]
        [MaxLength(255)]
        public string Description { get; set; }

        public DateTime CreatedOnDate { get; set; }

/*FK*/
        public int? ModuleId { get; set; }

        public int? TabId { get; set; }

        public virtual User User { get; set; }

        //public virtual Portal Portal { get; set; }
        public virtual CoreMessaging_SubscriptionType SubscriptionType { get; set; }

        public virtual Module Module { get; set; }
    }
}