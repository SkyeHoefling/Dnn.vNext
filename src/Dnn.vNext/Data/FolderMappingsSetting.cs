using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class FolderMappingsSetting
    {
        [Key, Column(Order = 0)]
/*PK*/  public int FolderMappingID { get; set; }

        [Key, Column(Order = 1)]
/*PK*/  public string SettingName { get; set; }

        public string SettingValue { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserID { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public virtual FolderMapping FolderMapping { get; set; }
    }
}
