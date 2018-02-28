using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class DesktopModule
    {
        [Key]
/*PK*/  public int DesktopModuleID { get; set; }
        public string FriendlyName { get; set; }
        public string Description { get; set; }
        public string Version { get; set; }
        public bool IsPremium { get; set; }
        public bool IsAdmin { get; set; }
        public string BusinessControllerClass { get; set; }
        public string FolderName { get; set; }
        public string ModuleName { get; set; }
        public bool SupportedFeatures { get; set; }
        public string CompatibleVersions { get; set; }
        public string Dependencies { get; set; }
        public string Permissions { get; set; }
/*FK*/  public int PackageID { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserID { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
        public int ContentItemID { get; set; }
        public int Shareable { get; set; }
        public string AdminPage { get; set; }
        public string HostPage { get; set; }

        public virtual Package Package  { get; set; }

        public virtual ICollection<CoreMessaging_NotificationType> CoreMessaging_NotificationType { get; set; }
        public virtual ICollection<ModuleDefinition> ModuleDefinition { get; set; }
        public virtual ICollection<PortalDesktopModule> PortalDesktopModule { get; set; }
}
}
