using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class SearchDeletedItem
    {
        [Key]
/*PK*/  public int SearchDeletedItemId { get; set; }
        public DateTime DateCreated { get; set; }
        public string Document { get; set; }
    }
}
