using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dnn.vNext.Data
{
    [Table("ContentTypes")]
    public class Content_Type
    {
        [Key]
/*PK*/ public int ContentTypeId { get; set; }

        public string ContentType { get; set; }

        public virtual ICollection<ContentItem> ContentItems { get; set; }
        public virtual ICollection<ContentWorkflow> ContentWorkflows { get; set; }
    }
}