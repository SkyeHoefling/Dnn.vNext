using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class RoleGroup
    {
        [Key]
/*PK*/  public int RoleGroupId { get; set; }
/*FK*/  public int PortalId { get; set; }
        public String RoleGroupName { get; set; }
        public string Description { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public virtual Portal Portal { get; set; }
        public virtual ICollection<Role> Role { get; set; }
    }
}
