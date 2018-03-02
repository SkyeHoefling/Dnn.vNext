using System.ComponentModel.DataAnnotations;

namespace Dnn.vNext.Data
{
    public class CKE_Setting
    {
        [Key]
        [MaxLength(300)]
/*PK*/ public string SettingName { get; set; }

        //TODO: Fix DIfference Was NTEXT => NVARCHAR(MAX)
        public string SettingValue { get; set; }
    }
}