using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class ContentItems_MetaData
    {
        [Key]
/*PK*/  public int ContetnItemMetaDataID { get; set; }
/*FK*/  public int ContentItemID { get; set; }
/*FK*/  public int MetaDataID { get; set; }
        public string MetaDataValue { get; set; }

        public virtual ContentItem ContentItem { get; set; }
        public virtual MetaData MetaData { get; set; }
    }
}
