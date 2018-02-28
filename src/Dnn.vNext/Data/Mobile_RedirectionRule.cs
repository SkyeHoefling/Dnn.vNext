using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class Mobile_RedirectionRule
    {
        [Key]
/*PK*/  public int Id { get; set; }
/*FK*/  public int RedirectionId { get; set; }
        public string Capability { get; set; }
        public string Expression { get; set; }

        public virtual Mobile_RedirectionRule Redirection { get; set; }
    }
}
