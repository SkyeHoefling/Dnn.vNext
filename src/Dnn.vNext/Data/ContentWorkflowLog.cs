using System;
using System.ComponentModel.DataAnnotations;

namespace Dnn.vNext.Data
{
    public class ContentWorkflowLog
    {
        [Key]
/*PK*/ public int WorkflowLogId { get; set; }

        [Required]
        [MaxLength(40)]
        public string Action { get; set; }

        [Required]
        public string Comment { get; set; }

        public DateTime Date { get; set; }

        public int User { get; set; }

/*FK*/
        public int WorkflowId { get; set; }

/*FK*/
        public int ContentItemId { get; set; }

        public int Type { get; set; }

        public virtual ContentItem ContentItem { get; set; }
        public virtual ContentWorkflow ContentWorkflow { get; set; }
    }
}