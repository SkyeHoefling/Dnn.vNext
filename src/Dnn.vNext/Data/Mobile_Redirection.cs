using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class Mobile_Redirection
    {
        [Key]
/*PK*/  public int Id { get; set; }
/*FK*/  public int PortalId { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public int SortOrder { get; set; }
        public int SourceTabId { get; set; }
        public bool IncludeChildTabs { get; set; }
        public int TargetType { get; set; }
        public string TargetValue { get; set; }
        public bool Enabled { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserID { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public virtual Portal Portal { get; set; }
        public virtual ICollection<Mobile_RedirectionRule> Mobile_RedirectionRule { get; set; }
    }
}
