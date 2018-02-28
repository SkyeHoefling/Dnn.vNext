using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class CoreMessaging_NotificationTypeAction
    {
        [Key]
/*PK*/  public int NotificaationTypeActionID { get; set; }
/*FK*/  public int NotificationTypeID { get; set; }
        public string NameResourceKey { get; set; }
        public string DescriptionResourceKey { get; set; }
        public string ConfirmRescourceKey { get; set; }
        public int Order { get; set; }
        public string APICall { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserID { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public virtual CoreMessaging_NotificationType NotificationType { get; set; }
    }
}
