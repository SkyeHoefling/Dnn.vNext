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
/*PK*/  public int PortalDesktopModuleId { get; set; }
/*FK*/  public int PortalId { get; set; }
/*FK*/  public int DesktopModuleId { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public virtual Portal Portal { get; set; }
        public virtual DesktopModule DesktopModule { get; set; }

        public virtual ICollection<DesktopModulePermission> DesktopModulePermission { get; set; }
    }
}
