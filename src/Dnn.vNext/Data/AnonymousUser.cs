using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class AnonymousUser
    {
        [Key, Column(Order = 0)]
/*PK*/  public int UserID { get; set; }
        

        [Key, Column(Order  = 1)]
/*PK+FK*/ public int PortalID { get; set; }

        public int TabId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastActiveDate { get; set; }

        public virtual Portal Portal { get; set; }

    }
}
