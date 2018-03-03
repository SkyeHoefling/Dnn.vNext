using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class SearchStopWord
    {
        [Key]
/*PK*/  public int StopWordsId { get; set; }
        public string StopWords { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
        public int? PortalId { get; set; }
        public string CultureCode { get; set; }
    }
}
