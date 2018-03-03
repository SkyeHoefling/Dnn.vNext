using System.ComponentModel.DataAnnotations;

namespace Dnn.vNext.Data
{
    public class Assembly
    {
        [Key]
/*PK*/ public int AssemblyId { get; set; }

/*FK*/
        public int? PackageId { get; set; }

        [Required]
        [MaxLength(250)]
        public string AssemblyName { get; set; }

        [Required]
        [MaxLength(20)]
        public string Version { get; set; }

        public virtual Package Package { get; set; }
    }
}