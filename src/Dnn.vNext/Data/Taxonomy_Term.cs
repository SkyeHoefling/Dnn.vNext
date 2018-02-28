using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class Taxonomy_Term
    {
        [Key]
/*PK*/  public int TermID { get; set; }
/*FK*/  public int VocabularyID { get; set; }
/*FK*/  public int ParentTermID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Weight { get; set; }
        public int TermLeft { get; set; }
        public int TermRight { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserID { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public virtual Taxonomy_Vocabulary Vocabulary { get; set; }
        public virtual Taxonomy_Term ParentTerm { get; set; }
        public virtual ICollection<ContentItems_Tag> ContentItems_Tag { get; set; }
    }
}
