using System;
using System.ComponentModel.DataAnnotations;

namespace Dnn.vNext.Data
{
    public class ModulePermission
    {
        [Key]
/*PK*/  public int ModulePermissionId { get; set; }
/*FK*/  public int ModuleId { get; set; }
/*FK*/  public int PermissionId { get; set; }
        public bool AllowAccess { get; set; }
/*FK*/  public int? RoleId { get; set; }
/*FK*/  public int? UserId { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
        public int PortalId { get; set; }

        public virtual Module Module { get; set; }
        public virtual Permission Permission { get; set; }
        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
    }
}
