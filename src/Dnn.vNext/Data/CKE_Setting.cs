using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class CKE_Setting
    {
        [Key]
/*PK*/  public string SettingName { get; set; }
        public string SettingValue { get; set; }
    }
}
