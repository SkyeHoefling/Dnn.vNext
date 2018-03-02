using System;
using System.ComponentModel.DataAnnotations;

namespace Dnn.vNext.Data
{
    public class ExportImportJobLog
    {
        [Key]
/*PK*/ public int JobLogId { get; set; }

/*FK*/
        public int JobId { get; set; }

        [MaxLength(255)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string Value { get; set; }

        public int Level { get; set; }
        public DateTime CreatedOnDate { get; set; }

        public virtual ExportImportJob Job { get; set; }
    }
}