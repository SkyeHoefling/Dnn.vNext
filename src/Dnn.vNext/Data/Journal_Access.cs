using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class Journal_Access
    {
        [Key]
/*PK*/  public int JournalAccessId { get; set; }
        public int JournalTypeId { get; set; }
        public int PortalId { get; set; }
        public string Name { get; set; }
        public Guid AccessKey { get; set; }
        public bool IsEnabled { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
