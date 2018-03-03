using System.ComponentModel.DataAnnotations;

namespace Dnn.vNext.Data
{
    public class ContentItems_Tag
    {
        [Key]
/*PK*/ public int ContentItemTagId { get; set; }

/*FK*/
        public int ContentItemId { get; set; }

/*FK*/
        public int TermId { get; set; }


        public virtual ContentItem ContentItem { get; set; }
        public virtual Taxonomy_Term Term { get; set; }
    }
}