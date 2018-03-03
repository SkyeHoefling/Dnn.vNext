using System;
using System.ComponentModel.DataAnnotations;

namespace Dnn.vNext.Data
{
    public class ModuleControl
    {
        [Key]
/*PK*/  public int ModuleControlId { get; set; }
/*FK*/  public int ModuleDefId { get; set; }
        public string ControlKey { get; set; }
        public string ControlTitle { get; set; }
        public string ControlSrc { get; set; }
        public string IconFile  { get; set; }
        public int ControlType { get; set; }
        public int? ViewOrder  { get; set; }
        public string HelpUrl { get; set; }
        public bool SupportsPartialRendering { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
        public bool SupportPopUps { get; set; }

        public virtual ModuleDefinition ModuleDef { get; set; }
    }
}
