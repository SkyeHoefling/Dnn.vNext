using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class EventLog
    {
        [Key]
/*PK*/  public Int64 LogEventID { get; set; }

        public string ExceptionHash { get; set; }
        public string LogGuid { get; set; }
        [Column("LogTypeKey")]
/*FK*/  public string LogType_Key { get; set; }
/*FK*/  public int LogConfigID { get; set; }
        public int? LogUserID { get; set; }
        public string LogUserName { get; set; }
        public int? LogPortalID { get; set; }
        public string LogPortalName { get; set; }
        public DateTime LogCreateDate { get; set; }
        public string LogServerName { get; set; }
        [Column(TypeName = "xml")]
        public string LogProperties { get; set; }
        public bool? LogNotificationPending { get; set; }

       
        public virtual EventLogType LogTypeKey  { get; set; }
        public virtual EventLog LogConfig { get; set; }
        public virtual ExceptionEvent LogEvent { get; set; }
    }
}
