using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class Journal_Security
    {
        [Key]
/*PK*/  public int JournalSecurityId { get; set; }
        public int JournalId { get; set; }
        public string SecurityKey { get; set; }
    }
}
