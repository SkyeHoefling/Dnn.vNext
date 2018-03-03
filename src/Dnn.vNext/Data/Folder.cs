using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class Folder
    {
        [Key]
/*PK*/  public int FolderId { get; set; }
        public int? PortalId { get; set; }
        public string FolderPath { get; set; }
        public int StorageLocation { get; set; }
        public bool IsProtected { get; set; }
        public bool IsCached { get; set; }
        public DateTime LastUpdated { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
        public Guid UniqueId { get; set; }
        public Guid VersionGuid { get; set; }
/*FK*/  public int FolderMappingId { get; set; }
        public int? ParentId { get; set; }
        public bool IsVersioned { get; set; }
/*FK*/  public int? WorkflowId { get; set; }
        public string MappedPath { get; set; }

        public virtual ICollection<FolderPermission> FolderPermission { get; set; }
        public virtual ContentWorkflow Workflow { get; set; }
        public virtual Portal Portal { get; set; }
        public virtual ICollection<File> File { get; set; }
        public virtual FolderMapping FolderMapping { get; set; }
    }
}
