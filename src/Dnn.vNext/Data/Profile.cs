using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class Profile
    {
        [Key]
/*PK*/  public int ProfileId { get; set; }
/*FK*/  public int UserId { get; set; }
/*FK*/  public int PortalId { get; set; }
        public string ProfileData { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual User User { get; set; }
        public virtual Portal Portal { get; set; }
    }
}
