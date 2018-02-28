using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class Version
    {
        [Key]
/*PK*/  public int VersionID { get; set; }
        public int Major { get; set; }
        public int Minor { get; set; }
        public int Build { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? Increment { get; set; }
    }
}
