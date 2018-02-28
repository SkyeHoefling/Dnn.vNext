using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class Journal_Comment
    {
        [Key]
/*PK*/  public int CommentId { get; set; }
/*FK*/  public int JournalId { get; set; }
        public int UserId { get; set; }
        public string Comment { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }

        [Column(TypeName = "xml")]
        public string CommentXML { get; set; }

        public virtual Journal Journal { get; set; }
    }
}
