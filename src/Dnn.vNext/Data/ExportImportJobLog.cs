using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class ExportImportJobLog
    {
        [Key]
/*PK*/  public int JobLogId { get; set; }
/*FK*/  public int JobId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public int Level { get; set; }
        public DateTime CreatedOnDate { get; set; }

        public virtual ExportImportJob Job { get; set; }
}
}
