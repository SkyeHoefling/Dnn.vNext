using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dnn.vNext.Data
{
    public class ModuleDefinition
    {
        [Key]
/*PK*/  public int ModuleDefId { get; set; }
        public string FriendlyName { get; set; }
/*FK*/  public int DesktopModuleId { get; set; }
        public int DefaultCacheTime { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
        public string DefinitionName { get; set; }

        public virtual DesktopModule DesktopModule { get; set; }

        public virtual ICollection<Module> Module { get; set; }
        public virtual ICollection<ModuleControl> ModuleControl { get; set; }
    }
}
