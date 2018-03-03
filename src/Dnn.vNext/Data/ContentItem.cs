using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dnn.vNext.Data
{
    public class ContentItem
    {
        [Key]
/*PK*/ public int ContentItemId { get; set; }

        public string Content { get; set; }

/*FK*/
        public int ContentTypeId { get; set; }

        public int TabId { get; set; }
        public int ModuleId { get; set; }

        [MaxLength(250)]
        public string ContentKey { get; set; }

        public bool Indexed { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }

        public DateTime? LastModifiedOnDate { get; set; }

/*FK*/
        public int? StateId { get; set; }

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