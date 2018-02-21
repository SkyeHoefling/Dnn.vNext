using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class ModuleSetting
    {
        public int ModuleID { get; set; }
        public string SettingName { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserID{ get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
}
}
