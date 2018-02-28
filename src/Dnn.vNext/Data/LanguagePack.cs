using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class LanguagePack
    {
        [Key]
/*PK*/  public int LanguagePackID { get; set; }
/*FK*/  public int PackageID { get; set; }
        public int DependentPackageID { get; set; }
        public int LanguageID { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserID { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public virtual Package Package { get; set; }
    }
}
