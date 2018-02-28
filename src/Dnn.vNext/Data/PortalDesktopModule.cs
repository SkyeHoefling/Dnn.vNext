using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class PortalDesktopModule
    {
        [Key]
/*PK*/  public int PortalDesktopModuleID { get; set; }
/*FK*/  public int PortalID { get; set; }
/*FK*/  public int DesktopModuleID { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserID { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public virtual Portal Portal { get; set; }
        public virtual DesktopModule DesktopModule { get; set; }

        public virtual ICollection<DesktopModulePermission> DesktopModulePermission { get; set; }
    }
}
