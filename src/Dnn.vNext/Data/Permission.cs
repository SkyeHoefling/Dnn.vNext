using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class Permission
    {
        [Key]
 /*PK*/ public int PermissionId { get; set; }
        public string PermissionCode { get; set; }
        public int ModuleDefId { get; set; }
        public string PermissionKey { get; set; }
        public string PermissionName { get; set; }
        public int ViewOrder { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public virtual ICollection<DesktopModulePermission> DesktopModulePermission { get; set; }
        public virtual ICollection<ModulePermission> ModulePermission { get; set; }
        public virtual ICollection<TabPermission> TabPermission { get; set; }
        public virtual ICollection<ContentWorkflowStatePermission> ContentWorkflowStatePermission { get; set; }
        public virtual ICollection<FolderPermission> FolderPermission { get; set; }
    }
}
