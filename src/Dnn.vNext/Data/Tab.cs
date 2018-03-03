using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dnn.vNext.Data
{
    public class Tab
    {
        [Key]
/*PK*/  public int TabId { get; set; }
        public int TabOrder { get; set; }
/*FK*/  public int? PortalId { get; set; }
        public string TabName { get; set; }
        public bool IsVisible { get; set; }
/*FK*/  public int? ParentId { get; set; }
        public string IconFile { get; set; }
        public bool DisableLink { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Keywords { get; set; }
        public bool IsDeleted { get; set; }
        public string Url { get; set; }
        public string SkinSrc { get; set; }
        public string ContainerSrc { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? RefreshInterval { get; set; }
        public string PageHeadText { get; set; }
        public bool IsSecure { get; set; }
        public bool PermanentRedirect { get; set; }
        public float SiteMapPriority { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
        public string IconFileLarge { get; set; }
        public string CultureCode { get; set; }
/*FK*/  public int? ContentItemId { get; set; }
        public Guid UniqueId { get; set; }
        public Guid VersionGuid { get; set; }
        public Guid DefaultLanguageGuid { get; set; }
        public Guid LocalizedVersionGuid { get; set; }
        public int Level { get; set; }
        public string TabPath { get; set; }
        public bool HasBeenPublished { get; set; }
        public bool IsSystem { get; set; }

        // DNN vNext        
        public string Name { get; set; }

        public virtual Portal Portal { get; set; }
        public virtual Tab Parent { get; set; }
        public virtual ContentItem Content { get; set; }

        public virtual ICollection<TabUrl> TabUrl { get; set; }
        public virtual ICollection<TabVersion> TabVersion { get; set; }
        public virtual ICollection<TabPermission> TabPermission { get; set; }
        public virtual ICollection<TabSetting> TabSetting { get; set; }
        public virtual ICollection<TabModule> TabModules { get; set; }
        
    }
}
