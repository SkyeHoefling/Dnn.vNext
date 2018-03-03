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
/*PK*/  public int HtmlTextUserId { get; set; }
/*FK*/  public int ItemId { get; set; }
        public int StateId { get; set; }
        public int ModuleId { get; set; }
        public int TabId { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedOnDate { get; set; }


        public virtual HtmlText Item { get; set; }
    }
}
