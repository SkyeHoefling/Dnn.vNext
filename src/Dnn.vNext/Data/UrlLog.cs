using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class UrlLog
    {
        [Key]
/*PK*/  public int UrlLogID { get; set; }
/*FK*/  public int UrlTrackingID { get; set; }
        public DateTime ClickDate { get; set; }
        public int? UserID { get; set; }

        public virtual UrlTracking UrlTracking { get; set; }
    }
}
