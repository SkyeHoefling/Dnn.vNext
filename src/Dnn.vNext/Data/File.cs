using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class File
    {
        [Key]
/*PK*/  public int FileId { get; set; }
/*FK*/  public int? PortalId { get; set; }
        public string FileName { get; set; }
        public string Extension { get; set; }
        public int Size { get; set; }
        public int? WIdth { get; set; }
        public int? Hieght { get; set; }
        public string ContentType { get; set; }
/*FK*/  public int FolderId { get; set; }
        public Byte? Content { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
        public Guid UniqueId { get; set; }
        public Guid VersionGuid { get; set; }
        public string SHA1Hash { get; set; }
        public DateTime LastModificationTime { get; set; }
        [Column("Folder")]
        public string _Folder { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public bool EnablePublishPeriod { get; set; }
        public DateTime EndDate { get; set; }
        public int PublishedVersion { get; set; }
/*FK*/  public int? ContentItemId { get; set; }
        public bool HasBeenPublished { get; set; }
        public string Description { get; set; }

        public virtual Folder Folder { get; set; }
        public virtual ICollection<FileVersion> FileVersion { get; set; }
        public virtual Portal Portal { get; set; }
        public virtual ContentItem ContentItem { get; set; }
    }
}
