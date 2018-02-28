using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class ContentItem
    {
        [Key]
/*PK*/  public int ContentItemID { get; set; }
        public string Content { get; set; }
/*FK*/  public int ContentTypeID { get; set; }
        public int TabID { get; set; }
        public int ModuleID { get; set; }
        public string ContentKey { get; set; }
        public bool Indexed { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserID { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
/*FK*/  public int? StateID { get; set; }

        public virtual Content_Type ContentType { get; set; }
        public virtual ContentWorkflowState State { get; set; }

        public virtual ICollection<Module> Module { get; set; }
        public virtual ICollection<ContentWorkflowLog> GetContentWorkflowLog { get; set; }
        public virtual ICollection<File> File { get; set; }
        public virtual ICollection<Tab> Tab { get; set; }
        public virtual ICollection<ContentItems_Tag> ContentItems_Tag { get; set; }
        public virtual ICollection<ContentItems_MetaData> ContentItems_Meta { get; set; }
    }
}

