using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class aspnet_SchemaVersion
    {
        [Key, Column(Order = 0)]
/*PK*/  public string Feature { get; set; }

        [Key, Column(Order = 1)]
/*PK*/  public string CompatibleSchemaVersion { get; set; }

        public bool IsCurrentVersion { get; set; }
    }
}
