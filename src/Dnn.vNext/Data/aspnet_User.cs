using System;
using System.ComponentModel.DataAnnotations;

namespace Dnn.vNext.Data
{
    public class aspnet_User
    {
        /*FK*/
        public Guid ApplicationId { get; set; }

        [Key]
        /*PK*/ public Guid UserId { get; set; }

        [Required]
        [MaxLength(256)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(256)]
        public string LoweredUserName { get; set; }

        [MaxLength(16)]
        public string MobileAlias { get; set; }

        public bool IsAnonymous { get; set; }
        public DateTime LastActivityDate { get; set; }

        public virtual aspnet_Application Application { get; set; }
    }
}