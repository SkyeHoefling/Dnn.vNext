using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class UsersOnline
    {
        [Key]
/*PK*/  public int UserID { get; set; }
/*FK*/  public int PortalID { get; set; }
        public int TabID { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastActiveDate { get; set; }

        public virtual User User { get; set; }
        public virtual Portal Portal { get; set; }

    }
}
