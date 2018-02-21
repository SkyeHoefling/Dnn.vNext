using System;
using System.ComponentModel.DataAnnotations;

namespace Dnn.vNext.Data
{
    public class TabModuleSetting
    {
        [Key]
        public int TabModuleID { get; set; }
        public string SettingName { get; set; }
        public string SetttingValue { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserID { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
    }
}
