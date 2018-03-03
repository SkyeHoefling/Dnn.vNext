using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dnn.vNext.Data
{
    public class EventLogType
    {
        [Key]
        [MaxLength(35)]
/*PK*/ public string LogTypeKey { get; set; }

        [Required]
        [MaxLength(50)]
        public string LogTypeFriendlyName { get; set; }

        [Required]
        [MaxLength(128)]
        public string LogTypeDescription { get; set; }

        [Required]
        [MaxLength(100)]
        public string LogTypeOwner { get; set; }

        [Required]
        [MaxLength(40)]
        public string LogTypeCSSClass { get; set; }

        public virtual ICollection<EventLog> EventLog { get; set; }
        public virtual ICollection<EventLogConfig> EventLogConfig { get; set; }
    }
}