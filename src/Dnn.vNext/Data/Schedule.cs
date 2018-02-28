using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class Schedule
    {
        [Key]
/*PK*/  public int ScheduleID { get; set; }
        public string TypeFullName { get; set; }
        public int TimeLapse { get; set; }
        public string TimeLapseMeasurement { get; set; }
        public int RetryTimeLapse { get; set; }
        public string RetryTimeLapseMeasurement { get; set; }
        public int RetainHistoryNumber { get; set; }
        public string AttachToEvent { get; set; }
        public bool CatchUpEnabled { get; set; }
        public bool Enabled { get; set; }
        public string ObjectDependencies { get; set; }
        public string Servers { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserID { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
        public string FriendlyName { get; set; }
        public DateTime ScheduleStartDate { get; set; }

        public virtual ICollection<ScheduleHistory> ScheduleHistory { get; set; }
        public virtual ICollection<ScheduleItemSetting> ScheduleItemSetting { get; set; }
    }
}
