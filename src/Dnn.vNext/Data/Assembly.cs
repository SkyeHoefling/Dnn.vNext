using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class Assembly
    {
        [Key]
/*PK*/  public int AssemblyID { get; set; }
/*FK*/  public int? PackageID { get; set; }
        public string AssemblyName { get; set; }
        public string Version { get; set; }

        public virtual Package Package { get; set; }
    }
}
