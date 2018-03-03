using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class PackageDependency
    {
        [Key]
/*PK*/  public int PackageDependencyId { get; set; }
/*FK*/  public int PackageId { get; set; }
        public string PackageName { get; set; }
        public string Version { get; set; }

        public virtual Package Package {get; set;}
    }
}
