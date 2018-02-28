using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class ScheduleItemSetting
    {
        [Key]
/*PK*/  public int ScheduleID { get; set; }
        public string SettingName { get; set; }
        public string SettingValue { get; set; }

        public virtual Schedule Schedule { get; set; }
    }
}
