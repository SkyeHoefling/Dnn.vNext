using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class Skin
    {
        [Key]
/*PK*/  public int SkinId { get; set; }
/*FK*/  public int SkinPackageId { get; set; }
        public string SkinSrc { get; set; }

        public virtual SkinPackage SkinPackage { get; set; }
    }
}
