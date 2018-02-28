using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    [Table ("ContentType")]
    public class Content_Type
    {
        [Key]
/*PK*/  public int ContentTypeID { get; set; }
        public string ContentType { get; set; }

        public virtual ICollection<ContentItem> ContentItems { get; set; }
        public virtual ICollection<ContentWorkflow> ContentWorkflows { get; set; }
    }
}
