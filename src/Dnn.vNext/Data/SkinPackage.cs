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
/*PK*/  public int SkinPackageID { get; set; }
/*FK*/  public int PackageID { get; set; }
        public int? PortalID { get; set; }
        public string SkinName { get; set; }
        public string SkinType { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserID { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public virtual Package Package { get; set; }
        public virtual ICollection<Skin> Skin { get; set; }
    }
}
