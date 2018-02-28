using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class IPFilter
    {
        [Key]
/*PK*/  public int IPFilterID { get; set; }
        public string IPAddress { get; set; }
        public string SubnetMask { get; set; }
        public int? RuleType { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserID { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
    }
}
