using System.ComponentModel.DataAnnotations;

namespace Dnn.vNext.Data
{
    public class ExceptionEvent
    {
        [Key]
/*PK*/ public long LogEventId { get; set; }

        [Required]
        [MaxLength(20)]
        public string AssemblyVersion { get; set; }

        public int? PortalId { get; set; }
        public int? UserId { get; set; }
        public int? TabId { get; set; }

        [MaxLength(260)]
        public string RawURL { get; set; }

        [MaxLength(260)]
        public string Referrer { get; set; }

        [MaxLength(260)]
        public string UserAgent { get; set; }

        public virtual EventLog LogEvent { get; set; }
    }
}