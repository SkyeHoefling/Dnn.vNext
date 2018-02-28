using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class ExtensionUrlProvider
    {
        [Key]
 /*PK*/ public int ExtensionUrlProviderID { get; set; }
        public string ProviderName { get; set; }
        public string ProviderType { get; set; }
        public string SettingsControlSrc { get; set; }
        public bool IsActive { get; set; }
        public bool RewriteAllUrls { get; set; }
        public bool RedirectAllUrls { get; set; }
        public bool ReplaceAllUrls { get; set; }
        public int? DekstopModuleId { get; set; }
    }
}
