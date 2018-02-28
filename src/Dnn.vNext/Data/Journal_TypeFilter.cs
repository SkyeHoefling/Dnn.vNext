using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class Journal_TypeFilter
    {
        [Key]
/*PK*/  public int JournalTypeFilerId { get; set; }
        public int PortalId { get; set; }
        public int ModuleId { get; set; }
        public int JournalTypeId { get; set; }
    }
}
