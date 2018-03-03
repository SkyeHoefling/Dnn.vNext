using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dnn.vNext.Data
{
    public class EventLogConfig
    {
        [Key]
/*PK*/ public int Id { get; set; }

        [MaxLength(35)]
        public string LogTypeKey { get; set; }

        public int LogTypePortalId { get; set; }
        public bool LoggingIsActive { get; set; }
        public int KeepMostRecent { get; set; }
        public bool EmailNotificaitonIsActive { get; set; }
        public int? NotificationThreshold { get; set; }
        public int? NotificationThresholdTime { get; set; }
        public int? NotificationThresholdTimeType { get; set; }

        [Required]
        [MaxLength(50)]
        public string MailFromAddress { get; set; }

        [Required]
        [MaxLength(50)]
        public string MailToAddress { get; set; }


        public virtual EventLogType LogType { get; set; }
        public virtual ICollection<EventLog> EventLog { get; set; }
    }
}