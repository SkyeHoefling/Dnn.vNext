using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class ScheduleHistory
    {
        [Key]
/*PK*/  public int ScheduleHistoryId { get; set; }
/*FK*/  public int ScheduleId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool? Succeeded { get; set; }
        public string LogNotes { get; set; }
        public DateTime? NextStart { get; set; }
        public string Server { get; set; }
    
        public virtual Schedule Schedule { get; set; }
    }
}
