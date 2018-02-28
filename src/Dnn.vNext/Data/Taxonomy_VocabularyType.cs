using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class Taxonomy_VocabularyType
    {
        [Key]
/*PK*/  public int VocabularyTypeID { get; set; }
        public string VocabularyType { get; set; }

        public virtual ICollection<Taxonomy_Vocabulary> Taxonomy_Vocabulary { get; set; }
    }
}
