using System;
using System.ComponentModel.DataAnnotations;

namespace Dnn.vNext.Data
{
    public class aspnet_Application
    {
        [MaxLength(256)]
        [Required]
        public string ApplicationName { get; set; }

        [MaxLength(256)]
        [Required]
        public string LoweredApplicationName { get; set; }

        [Key]
/*PK*/ public Guid ApplicationId { get; set; }

        [MaxLength(256)]
        public string Description { get; set; }
    }
}