using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class ContentItems_Tag
    {
        [Key]
/*PK*/  public int ContentItemTagID { get; set; }
/*FK*/  public int ContentItemID { get; set; }
/*FK*/  public int TermID { get; set; }


        public virtual ContentItems_Tag ContentItemTag { get; set; }
        public virtual ContentItem ContentItem { get; set; }

    }
}
