using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class EventLogType
    {
        [Key]
/*PK*/  public string LogTypeKey { get; set; }
        public string LogTypeFriendlyName { get; set; }
        public string LogTypeDescription { get; set; }
        public string LogTypeOwner { get; set; }
        public string LogTypeCSSClass { get; set; }

        public virtual ICollection<EventLog> EventLog { get; set; }
        public virtual ICollection<EventLogConfig> EventLogConfig { get; set; }
    }
}
