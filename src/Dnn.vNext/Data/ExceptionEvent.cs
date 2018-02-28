using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class ExceptionEvent
    {
        [Key]
/*PK*/  public Int64 LogEventID { get; set; }
        public string AssemblyVersion { get; set; }
        public int? PortalID { get; set; }
        public int? UserID { get; set; }
        public int? TabID { get; set; }
        public string RawURL { get; set; }
        public string Referrer { get; set; }
        public string UserAgent { get; set; }

        public virtual EventLog LogEvent { get; set; }
    }
}
