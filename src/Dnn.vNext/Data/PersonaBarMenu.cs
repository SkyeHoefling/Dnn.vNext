using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class PersonaBarMenu
    {
        [Key]
 /*PK*/ public int MenuId { get; set; }
        public string Identifier { get; set; }
        public string ModuleName { get; set; }
        public string FolderName { get; set; }
        public string Controller { get; set; }
        public string ResourceKey { get; set; }
        public string Path { get; set; }
        public string Link { get; set; }
        public string CssClass { get; set; }
/*FK*/  public int? ParentId { get; set; }
        public int Order { get; set; }
        public bool AllowHost { get; set; }
        public bool Enabled { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public virtual PersonaBarMenuDefaultPermission Menu { get; set; }

        public virtual ICollection<PersonaBarPermission> PersonaBarPermission { get; set; }
        public virtual ICollection<PersonaBarMenuPermission> PersonaBarMenuPermission { get; set; }
        public virtual ICollection<PersonaBarExtension> PersonaBarExtension { get; set; }

        public virtual PersonaBarMenu Parent { get; set; }
    }
}
