using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class ModuleDefinitions
    {
        public int ModuleDefID { get; set; }
        public string FriendlyName { get; set; }
        public int DesktopModuleID { get; set; }
        public int DefaultCacheTime { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserID { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
        public string DefinitionName { get; set; }
}
}
