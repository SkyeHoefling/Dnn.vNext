using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class PersonaBarMenuPermission
    {
        [Key]
/*PK*/  public int MenuPermissionID { get; set; }
/*FK*/  public int PortalId { get; set; }
/*FK*/  public int MenuId { get; set; }
/*FK*/  public int PermissionId { get; set; }
        public bool AllowAccess { get; set; }
/*FK*/  public int? RoleId { get; set; }
/*FK*/  public int? UserId { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserID { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public virtual Portal Portal { get; set; }
        public virtual PersonaBarPermission Permission { get; set; }
        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
    }
}
