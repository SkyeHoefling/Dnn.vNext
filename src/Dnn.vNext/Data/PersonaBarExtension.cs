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
/*PK*/  public int ExtensionId { get; set; }
        public string Identifier { get; set; }
/*FK*/  public int MenuId { get; set; }
        public string FolderName { get; set; }
        public string Controller { get; set; }
        public string Container { get; set; }
        public string Path { get; set; }
        public int Order { get; set; }
        public bool Enabled { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public virtual PersonaBarMenu Menu { get; set; }
    }
}
