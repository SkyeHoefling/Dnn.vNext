using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dnn.vNext.Data
{
    public class EventLog
    {
        [Key]
/*PK*/ public long LogEventId { get; set; }

        [MaxLength(100)]
        public string ExceptionHash { get; set; }

        [Required]
        [MaxLength(36)]
        public string LogGuid { get; set; }

        [Required]
        [MaxLength(35)]
/*FK*/ public string LogTypeKey { get; set; }

/*FK*/
        public int LogConfigId { get; set; }

        public int? LogUserId { get; set; }

        [MaxLength(50)]
        public string LogUserName { get; set; }

        public int? LogPortalId { get; set; }

        [MaxLength(100)]
        public string LogPortalName { get; set; }

        public DateTime LogCreateDate { get; set; }

        [Required]
        [MaxLength(50)]
        public string LogServerName { get; set; }

        [Column(TypeName = "xml")]
        public string LogProperties { get; set; }

        public bool? LogNotificationPending { get; set; }


        public virtual EventLogType LogType { get; set; }
        public virtual EventLog LogConfig { get; set; }
        public virtual ExceptionEvent LogEvent { get; set; }

        //TODO: Indexes Missing
    }
}