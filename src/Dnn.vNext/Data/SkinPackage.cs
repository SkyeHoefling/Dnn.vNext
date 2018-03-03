using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class SkinPackage
    {
        [Key]
/*PK*/  public int SkinPackageId { get; set; }
/*FK*/  public int PackageId { get; set; }
        public int? PortalId { get; set; }
        public string SkinName { get; set; }
        public string SkinType { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public virtual Package Package { get; set; }
        public virtual ICollection<Skin> Skin { get; set; }
    }
}
