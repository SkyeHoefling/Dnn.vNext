using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class UserPortal
    {
        [Key]
/*PK*/  public int UserId { get; set; }
/*FK*/  public int PortalId { get; set; }
        public int UserPortalId { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Authorized { get; set; }
        public bool IsDeleted { get; set; }
        public bool RefreshRoles { get; set; }
        public string VanityUrl { get; set; }

        public virtual User User { get; set; }
        public virtual Portal Portal { get; set; }
    }
}
