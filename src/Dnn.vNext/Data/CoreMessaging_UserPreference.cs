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
/*PK*/  public int UserPreferenceId { get; set; }
        public int PortalId { get; set; }
        public int UserId { get; set; }
        public int MessagesEmailFrequency { get; set; }
        public int NotificationsEmailFrequency { get; set; }
    }
}
