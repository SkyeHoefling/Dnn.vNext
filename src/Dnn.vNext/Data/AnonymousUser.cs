using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dnn.vNext.Data
{
    public class AnonymousUser
    {
        [MaxLength(36)]
        [Required]
        [Column(TypeName = "char(36)")]
        public string UserId { get; set; }

        public int PortalId { get; set; }

        public int TabId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastActiveDate { get; set; }

        public virtual Portal Portal { get; set; }
    }
}