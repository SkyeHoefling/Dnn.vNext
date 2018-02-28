using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class FolderMapping
    {
        [Key]
/*PK*/  public int FolderMappingID { get; set; }
/*FK*/  public int? PortalID { get; set; }
        public string MappingName { get; set; }
        public string FolderProviderType { get; set; }
        public int? Priority { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserID { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public virtual ICollection<Folder> Folder { get; set; }
        public virtual Portal Portal { get; set; }
        public virtual ICollection<FolderMappingsSetting> FolderMappingsSetting { get; set; }
    }
}
