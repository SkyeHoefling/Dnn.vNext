using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class CoreMessaging_UserPreference
    {
        [Key]
/*PK*/  public int UserPreferenceID { get; set; }
        public int PortalID { get; set; }
        public int UserID { get; set; }
        public int MessagesEmailFrequency { get; set; }
        public int NotificationsEmailFrequency { get; set; }
    }
}
