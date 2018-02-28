using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class PortalLocalization
    {
        [Key]
/*PK*/  public int PortalID { get; set; }
/*FK*/  public string CultureCode { get; set; }
        public string PortalName { get; set; }
        public string LogoFile { get; set; }
        public string FooterText { get; set; }
        public string Description { get; set; }
        public string KeyWords { get; set; }
        public string BackgroundFile { get; set; }
        public int? HomeTabId { get; set; }
        public int? LoginTabId { get; set; }
        public int? UserTabId { get; set; }
        public int? AdminTabId { get; set; }
        public int? SplashTabId { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserID { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public virtual Portal Portal { get; set; }
    }
}
