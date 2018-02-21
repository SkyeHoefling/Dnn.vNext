using System;
using System.ComponentModel.DataAnnotations;

namespace Dnn.vNext.Data
{
    public class ModuleSetting
    {
        [Key]
        public int ModuleID { get; set; }
        public string SettingName { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserID{ get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
}
}
