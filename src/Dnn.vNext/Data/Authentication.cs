using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class Authentication
    {
        [Key]
/*PK*/  public int AuthenticationID { get; set; }
/*FK*/  public int PackageID { get; set; }
        public string AuthenticationType { get; set; }
        public bool IsEnabled { get; set; }
        public string SettignsControlSrc { get; set; }
        public string LoginControlSrc { get; set; }
        public string LogoffControlSrc { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserID { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public virtual Package Package { get; set; }
    }
}
