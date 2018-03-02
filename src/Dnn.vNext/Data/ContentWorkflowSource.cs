using System.ComponentModel.DataAnnotations;

namespace Dnn.vNext.Data
{
    public class ContentWorkflowSource
    {
        [Key]
/*PK*/ public int SourceId { get; set; }

/*FK*/
        public int WorkflowId { get; set; }

        [Required]
        [MaxLength(20)]
        public string SourceName { get; set; }

        [Required]
        [MaxLength(250)]
        public string SourceType { get; set; }

        public virtual ContentWorkflow ContentWorkflow { get; set; }
    }
}