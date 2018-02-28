using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class UserRole
    {
        [Key]
/*PK*/  public int UserRoleID { get; set; }
/*FK*/  public int UserID { get; set; }
/*FK*/  public int RoleID { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public bool? IsTrialUsed { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserID { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
        public int Status { get; set; }
        public bool IsOwner { get; set; }

        public virtual User User { get; set; }
        public virtual Role Role { get; set; }
    }
}
