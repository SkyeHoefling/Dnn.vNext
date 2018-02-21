using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class ModulePermission
    {
        public int ModulePermissionID { get; set; }
        public int ModuleID { get; set; }
        public int PermissionID { get; set; }
        public bool AllowAccess { get; set; }
        public int? RoleID { get; set; }
        public int? UserID { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserID { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
        public int PortalID { get; set; }
}
}
