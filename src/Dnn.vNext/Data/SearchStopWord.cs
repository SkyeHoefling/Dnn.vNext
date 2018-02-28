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
/*PK*/  public int StopWordsID { get; set; }
        public string StopWords { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserID { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
        public int? PortalID { get; set; }
        public string CultureCode { get; set; }
    }
}
