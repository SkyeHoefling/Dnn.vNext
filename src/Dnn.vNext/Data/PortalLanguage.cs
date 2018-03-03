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
/*PK*/  public int PortalLanguageId { get; set; }
/*FK*/  public int PortalId { get; set; }
/*FK*/  public int LanguageId { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
        public bool IsPublished { get; set; }

        public virtual Portal Portal { get; set; }
        public virtual Language Language { get; set; }
    }
}
