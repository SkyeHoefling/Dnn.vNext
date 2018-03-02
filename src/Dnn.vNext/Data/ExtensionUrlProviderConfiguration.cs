using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class ExtensionUrlProvIderConfiguration
    {
        [Key, Column(Order = 0)]
 /*PK*/  public int ExtensionUrlProvIderId { get; set; }

        [Key, Column(Order = 1)]
 /*PK*/  public int PortalId { get; set; }
    }
}
