using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class Language
    {
        [Key]
/*PK*/  public int LanguageID { get; set; }
        public string CultureCode { get; set; }
        public string CultureName { get; set; }
        public string FallbackCulture { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserID { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public virtual ICollection<PortalLanguage> PortalLanguage { get; set; }
    }
}
