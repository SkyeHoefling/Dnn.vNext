using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class TabPermission
    {
        [Key]
/*PK*/  public int TabPermissionID { get; set; }
/*FK*/  public int TabID { get; set; }
/*FK*/  public int PermissionID { get; set; }
        public bool AllowAccess { get; set; }
/*FK*/  public int? RoleID { get; set; }
/*FK*/  public int? UserID { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserID { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }


        public virtual Tab Tab { get; set; }
        public virtual Permission Permission { get; set; }
        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
    }
}
