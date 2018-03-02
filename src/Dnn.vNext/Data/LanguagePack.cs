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
/*PK*/  public int LanguagePackId { get; set; }
/*FK*/  public int PackageId { get; set; }
        public int DependentPackageId { get; set; }
        public int LanguageId { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public virtual Package Package { get; set; }
    }
}
