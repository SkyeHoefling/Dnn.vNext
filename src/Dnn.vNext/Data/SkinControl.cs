using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class SkinControl
    {
        [Key]
/*PK*/  public int SkinControlId { get; set; }
/*FK*/  public int PackageId { get; set; }
        public string ControlKey { get; set; }
        public string ControlSrc { get; set; }
        public string IconFile { get; set; }
        public string HelpURL { get; set; }
        public bool SupportsPartialRendering { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public virtual Package Package { get; set; }
    }
}
