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
/*PK*/  public int SkinID { get; set; }
/*FK*/  public int SkinPackageID { get; set; }
        public string SkinSrc { get; set; }

        public virtual SkinPackage SkinPackage { get; set; }
    }
}
