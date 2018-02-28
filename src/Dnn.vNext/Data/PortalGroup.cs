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
/*PK*/  public int ProtalGroupID { get; set; }
        public int? MasterPortalID { get; set; }
        public string PortalGroupName { get; set; }
        public string PortalGroupDescription { get; set; }
        public string AuthenticationDomain { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserID { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
    }
}
