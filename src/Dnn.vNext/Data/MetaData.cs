using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class MetaData
    {
        [Key]
/*PK*/  public int MetaDataID { get; set; }
        public string MetaDataName { get; set; }
        public string MetaDataDescription { get; set; }

        public virtual ICollection<ContentItems_MetaData> ContentItems_MetaData { get; set; }
    }
}
