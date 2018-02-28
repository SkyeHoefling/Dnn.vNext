using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class TabVersionDetail
    {
/*PK*/  public int TabVersionDetailId { get; set; }
/*FK*/  public int TabVersionId { get; set; }
        public int ModuleId { get; set; }
        public int ModuleVersion { get; set; }
        public string PageName { get; set; }
        public int ModuleOrder { get; set; }
        public int Action { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserID { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public virtual TabVersion TabVersion { get; set; }
    }
}
