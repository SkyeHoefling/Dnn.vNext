using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class ExportImportCheckpoint
    {
        [Key]
/*PK*/  public int CheckpointID { get; set; }
/*FK*/  public int JobID { get; set; }
        public string AssemblyName { get; set; }
        public string Category { get; set; }
        public int Stage { get; set; }
        public string StageData { get; set; }
        public int Progress { get; set; }
        public int TotalItems { get; set; }
        public int ProcessedItems { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public bool? Completed { get; set; }

        public virtual ExportImportJob Job { get; set; }
    }
}
