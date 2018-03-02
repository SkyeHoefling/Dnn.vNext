using System;
using System.ComponentModel.DataAnnotations;

namespace Dnn.vNext.Data
{
    public class ExportImportCheckpoint
    {
        [Key]
/*PK*/ public int CheckpointId { get; set; }

/*FK*/
        public int JobId { get; set; }

        [Required]
        [MaxLength(200)]
        public string AssemblyName { get; set; }

        [Required]
        [MaxLength(50)]
        public string Category { get; set; }

        public int Stage { get; set; }
        public string StageData { get; set; }
        public int Progress { get; set; }
        public int TotalItems { get; set; }
        public int ProcessedItems { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public bool Completed { get; set; }

        public virtual ExportImportJob Job { get; set; }
    }
}