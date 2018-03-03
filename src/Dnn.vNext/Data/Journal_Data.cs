using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class Journal_Data
    {
        [Key]
/*PK*/  public int JournalDataId { get; set; }
/*FK*/  public int JournalId { get; set; }
        
        [Column(TypeName = "xml")]
        public string JournalXML { get; set; }

        public virtual Journal Journal { get; set; }
    }
}
