using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class ExportImportJob
    {
        [Key]
/*PK*/  public int JobId { get; set; }
        public int PortalId { get; set; }
        public int JobType { get; set; }
        public int JobStatus { get; set; }
        public bool IsCancelled { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CreatedByUserId { get; set; }
        public DateTime CreatedOnDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public DateTime CompletedOnDate { get; set; }
        public string Directory { get; set; }
        public string JobObject { get; set; }

        public virtual ICollection<ExportImportCheckpoint> ExportImportCheckpoint { get; set; }
    }
}
