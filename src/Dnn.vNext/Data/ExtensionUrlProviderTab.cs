using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class ExtensionUrlProviderTab
    {
        [Key, Column(Order = 0)]
/*PK*/  public int ExtensionUrlProviderID { get; set; }

        [Key, Column(Order = 1)]
/*PK*/  public int PortalID { get; set; }

        [Key, Column(Order = 2)]
/*PK*/  public int TabID { get; set; }
        public bool IsActive { get; set; }
    }
}
