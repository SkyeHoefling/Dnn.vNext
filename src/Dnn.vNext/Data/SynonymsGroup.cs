using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class SynonymsGroup
    {
        [Key]
/*PK*/  public int SynonymsGroupId { get; set; }
        public string SynonymsTags { get; set; }
        public int PortalId { get; set; }
        public string CultureCode { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
    }
}
