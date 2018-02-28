using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class PortalLanguage
    {
        [Key]
/*PK*/  public int PortalLanguageID { get; set; }
/*FK*/  public int PortalID { get; set; }
/*FK*/  public int LanguageID { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserID { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
        public bool IsPublished { get; set; }

        public virtual Portal Portal { get; set; }
        public virtual Language Language { get; set; }
    }
}
