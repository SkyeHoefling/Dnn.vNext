using System.ComponentModel.DataAnnotations;

namespace Dnn.vNext.Data
{
    public class Exception
    {
        [Key]
        [MaxLength(100)]
/*PK*/ public string ExceptionHash { get; set; }

        [Required]
        [MaxLength(500)]
        public string Message { get; set; }

        public string StackTrace { get; set; }

        [MaxLength(500)]
        public string InnerMessage { get; set; }

        public string InnerStackTrace { get; set; }

        [MaxLength(500)]
        public string Source { get; set; }
    }
}