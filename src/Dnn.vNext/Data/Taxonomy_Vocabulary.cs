using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class Taxonomy_Vocabulary
    {
        [Key]
/*PK*/  public int VocabularyId { get; set; }
/*FK*/  public int VocabularyTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Weight { get; set; }
        public int? ScopeId { get; set; }
/*FK*/  public int ScopeTypeId { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public virtual Taxonomy_ScopeType Taxonomy_ScopeType { get; set; }
        public virtual Taxonomy_VocabularyType Taxonomy_VocabularyType { get; set; }
        public virtual ICollection<Taxonomy_Term> Taxonomy_Term { get; set; }
    }
}
