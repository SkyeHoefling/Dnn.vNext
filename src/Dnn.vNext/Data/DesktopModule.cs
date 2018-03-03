using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dnn.vNext.Data
{
    public class DesktopModule
    {
        [Key]
/*PK*/ public int DesktopModuleId { get; set; }

        [Required]
        [MaxLength(128)]
        public string FriendlyName { get; set; }

        [MaxLength(2000)]
        public string Description { get; set; }

        [MaxLength(8)]
        public string Version { get; set; }

        public bool IsPremium { get; set; }
        public bool IsAdmin { get; set; }

        [MaxLength(200)]
        public string BusinessControllerClass { get; set; }

        [Required]
        [MaxLength(128)]
        public string FolderName { get; set; }

        [Required]
        [MaxLength(128)]
        public string ModuleName { get; set; }

        public int SupportedFeatures { get; set; }

        [MaxLength(500)]
        public string CompatibleVersions { get; set; }

        [MaxLength(400)]
        public string Dependencies { get; set; }

        [MaxLength(400)]
        public string Permissions { get; set; }

/*FK*/
        public int PackageId { get; set; }

        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
        public int ContentItemId { get; set; }
        public int Shareable { get; set; }

        [MaxLength(128)]
        public string AdminPage { get; set; }

        [MaxLength(128)]
        public string HostPage { get; set; }

        public virtual Package Package { get; set; }

        public virtual ICollection<CoreMessaging_NotificationType> CoreMessaging_NotificationType { get; set; }
        public virtual ICollection<ModuleDefinition> ModuleDefinition { get; set; }
        public virtual ICollection<PortalDesktopModule> PortalDesktopModule { get; set; }
    }
}