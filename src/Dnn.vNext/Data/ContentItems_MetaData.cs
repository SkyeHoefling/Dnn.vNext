using System.ComponentModel.DataAnnotations;

namespace Dnn.vNext.Data
{
    public class ContentItems_MetaData
    {
        [Key]
/*PK*/ public int ContentItemMetaDataId { get; set; }

/*FK*/
        public int ContentItemId { get; set; }

/*FK*/
        public int MetaDataId { get; set; }

        public string MetaDataValue { get; set; }

        public virtual ContentItem ContentItem { get; set; }
        public virtual MetaData MetaData { get; set; }
    }
}