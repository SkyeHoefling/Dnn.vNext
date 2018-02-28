using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class Taxonomy_ScopeType
    {
        [Key]
/*PK*/  public int ScopeTypeID { get; set; }
        public string ScopeType { get; set; }

        public virtual ICollection<Taxonomy_Vocabulary> Taxonomy_Vocabulary { get; set; }
    }
}
