using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class ContentWorkflowStatePermission
    {
        [Key]
/*PK*/  public int WorkflowStatePermissionId { get; set; }
/*FK*/  public int StateId { get; set; }
/*FK*/  public int PermissionId { get; set; }
        public bool AllowAccess { get; set; }
        public int? RoleId { get; set; }
/*FK*/  public int? UserId { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }


        public virtual ContentWorkflowState State { get; set; }
        public virtual Permission Permission { get; set; }
        public virtual User User { get; set; }

        public virtual ICollection<Folder> Folder { get; set; }
        public virtual ICollection<FolderPermission> FolderPermission { get; set; }
    }
}
