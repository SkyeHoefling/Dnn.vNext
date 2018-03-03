using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class FolderPermission
    {
        [Key]
/*PK*/  public int FolderPermissionId { get; set; }
/*FK*/  public int FolderId { get; set; }
/*FK*/  public int PermissionId { get; set; }
        public bool AllowAccess { get; set; }
/*FK*/  public int? RoleId { get; set; }
/*FK*/  public int? UserId { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public virtual Folder Folder { get; set; }
        public virtual Permission Permission { get; set; }
        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
    }
}
