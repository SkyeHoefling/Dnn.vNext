using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class ExtensionUrlProvIder
    {
        [Key]
 /*PK*/ public int ExtensionUrlProvIderId { get; set; }
        public string ProvIderName { get; set; }
        public string ProvIderType { get; set; }
        public string SettingsControlSrc { get; set; }
        public bool IsActive { get; set; }
        public bool RewriteAllUrls { get; set; }
        public bool RedirectAllUrls { get; set; }
        public bool ReplaceAllUrls { get; set; }
        public int? DekstopModuleId { get; set; }
    }
}
