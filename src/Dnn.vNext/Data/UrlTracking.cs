using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class UrlTracking
    {
        [Key]
/*PK*/  public int UrlTrackingID { get; set; }
/*FK*/  public int? PortalID { get; set; }
        public string Url { get; set; }
        public string UrlType { get; set; }
        public int Clicks { get; set; }
        public DateTime? LastClick { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool LogActivity { get; set; }
        public bool TrackClicks { get; set; }
        public int? ModuleID { get; set; }
        public bool NewWindow { get; set; }

        public virtual Portal Portal { get; set; }
        public virtual ICollection<UrlLog> UrlLog { get; set; }
    }
}
