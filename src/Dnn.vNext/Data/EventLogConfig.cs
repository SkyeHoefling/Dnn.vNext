using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class EventLogConfig
    {
        [Key]
/*PK*/  public int ID { get; set; }
        [Column("LogTypeKey")]
        public string LogType_Key { get; set; }
        public String LogTypePortalID { get; set; }
        public bool LoggingIsActive { get; set; }
        public int KeepMostRecent { get; set; }
        public bool EmailNotificaitonIsAcdtive { get; set; }
        public int? NotificationThreshold { get; set; }
        public int? NotificationThresholdTime { get; set; }
        public int? NotificationThresholdTimeType { get; set; }
        public string MailFromAddress { get; set; }
        public string MailToAddress { get; set; }

        
        public virtual EventLogType LogTypeKey { get; set; }
        public virtual ICollection<EventLog> EventLog { get; set; }
    }
}
