using System;
using System.ComponentModel.DataAnnotations;

namespace Dnn.vNext.Data
{
    public class Authentication
    {
        [Key]
/*PK*/ public int AuthenticationId { get; set; }

/*FK*/
        public int PackageId { get; set; }

        [Required]
        [MaxLength(100)]
        public string AuthenticationType { get; set; }

        public bool IsEnabled { get; set; }

        [Required]
        [MaxLength(250)]
        public string SettignsControlSrc { get; set; }

        [Required]
        [MaxLength(250)]
        public string LoginControlSrc { get; set; }

        [Required]
        [MaxLength(250)]
        public string LogoffControlSrc { get; set; }

        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public virtual Package Package { get; set; }
    }
}