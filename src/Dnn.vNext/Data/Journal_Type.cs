using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class Journal_Type
    {
        [Key]
/*PK*/  public int JournalTypeId { get; set; }
        public string JournalType { get; set; }
        public string icon { get; set; }
        public int PortalId { get; set; }
        public bool IsEnabled { get; set; }
        public bool AppliesToProfile { get; set; }
        public bool AppliesToGroup { get; set; }
        public bool AppliesToStream { get; set; }
        public string Options { get; set; }
        public bool SupportsNotify { get; set; }
        public bool EnableComments { get; set; }

        public virtual ICollection<Journal> Journal { get; set; }
    }
}
