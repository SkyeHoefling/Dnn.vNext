using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    [Table("PackageType")]
    public class Package_Type
    {
        [Key]
 /*PK*/ public string PackageType { get; set; }
        public string Descrption { get; set; }
        public int SecurityAccessLevel { get; set; }
        public string EditorControlSrc { get; set; }
        public bool SupportsSIdeBySIdeInstallation { get; set; }

        public virtual Package Package { get; set; }
    }
}
