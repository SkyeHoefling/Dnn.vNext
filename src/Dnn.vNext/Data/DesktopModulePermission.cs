using System;
using System.ComponentModel.DataAnnotations;

namespace Dnn.vNext.Data
{
    public class DesktopModulePermission
    {
        [Key]
/*PK*/ public int DesktopModulePermissionId { get; set; }

/*FK*/
        public int PortalDesktopModuleId { get; set; }

/*FK*/
        public int PermissionId { get; set; }

        public bool AllowAccess { get; set; }

/*FK*/
        public int? RoleId { get; set; }

/*FK*/
        public int? UserId { get; set; }

        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public virtual PortalDesktopModule PortalDesktopModule { get; set; }
        public virtual Permission Permission { get; set; }
        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
    }
}