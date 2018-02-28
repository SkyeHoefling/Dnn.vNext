using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class PersonaBarMenuDefaultPermission
    {
        [Key]
/*PK*/  public int Id { get; set; }
/*FK*/  public int MenuId { get; set; }
        public string RoleNames { get; set; }

        public virtual PersonaBarMenu Menu { get; set; }
    }
}
