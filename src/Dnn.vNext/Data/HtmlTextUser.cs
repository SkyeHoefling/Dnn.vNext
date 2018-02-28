using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class HtmlTextUser
    {
        [Key]
/*PK*/  public int HtmlTextUserID { get; set; }
/*FK*/  public int ItemID { get; set; }
        public int StateID { get; set; }
        public int ModuleID { get; set; }
        public int TabID { get; set; }
        public int UserID { get; set; }
        public DateTime CreatedOnDate { get; set; }


        public virtual HtmlText Item { get; set; }
    }
}
