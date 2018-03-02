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
/*PK*/  public int IPFilterId { get; set; }
        public string IPAddress { get; set; }
        public string SubnetMask { get; set; }
        public int? RuleType { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
    }
}
