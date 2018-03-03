using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class RedirectMessage
    {
        [Key]
/*PK*/  public Guid MessageId { get; set; }
        public int? UserId { get; set; }
        public int? TabId { get; set; }
        public string MessageText { get; set; }
        public DateTime CreatedOnDate { get; set; }
    }
}
