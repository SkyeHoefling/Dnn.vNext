using System.ComponentModel.DataAnnotations;

namespace Dnn.vNext.Data
{
    public class aspnet_SchemaVersion
    {
        [Key]
        [MaxLength(125)]
/*PK*/ public string Feature { get; set; }

        [Key]
        [MaxLength(128)]
/*PK*/ public string CompatibleSchemaVersion { get; set; }

        public bool IsCurrentVersion { get; set; }
    }
}