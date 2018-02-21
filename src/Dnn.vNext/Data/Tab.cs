using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dnn.vNext.Data
{
    public class Tab
    {
        [Key]
        public int TabID { get; set; }
        public int TabOrder { get; set; }
        public int? PortalID { get; set; }
        public string TabName { get; set; }
        public bool IsVisible { get; set; }
        public int? ParentId { get; set; }
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
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserID { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
        public string IconFileLarge { get; set; }
        public string CultureCode { get; set; }
        public int? ContentItemID { get; set; }
        public Guid UniqueId { get; set; }
        public Guid VersionGUID { get; set; }
        public Guid DefaultLanguageGUID { get; set; }
        public Guid LocalizedVersionGUID { get; set; }
        public int Level { get; set; }
        public string TabPath { get; set; }
        public bool HasBeenPublished { get; set; }
        public bool IsSystem { get; set; }

        // DNN vNext        
        public string Name { get; set; }

        public virtual ICollection<TabModule> TabModules { get; set; }
    }
}
