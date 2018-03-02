using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class PortalGroup
    {
        [Key]
/*PK*/  public int ProtalGroupId { get; set; }
        public int? MasterPortalId { get; set; }
        public string PortalGroupName { get; set; }
        public string PortalGroupDescription { get; set; }
        public string AuthenticationDomain { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
    }
}
