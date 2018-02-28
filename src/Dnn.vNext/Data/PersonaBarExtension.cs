using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class PersonaBarExtension
    {
        [Key]
/*PK*/  public int ExtensionID { get; set; }
        public string Identifier { get; set; }
/*FK*/  public int MenuId { get; set; }
        public string FolderName { get; set; }
        public string Controller { get; set; }
        public string Container { get; set; }
        public string Path { get; set; }
        public int Order { get; set; }
        public bool Enabled { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserID { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public virtual PersonaBarMenu Menu { get; set; }
    }
}
