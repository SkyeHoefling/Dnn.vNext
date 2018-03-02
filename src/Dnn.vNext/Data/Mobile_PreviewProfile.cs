using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class Mobile_PreviewProfile
    {
        [Key]
/*PK*/  public int Id { get; set; }
/*FK*/  public int PortalId { get; set; }
        public string Name { get; set; }
        public int WIdth { get; set; }
        public int Height { get; set; }
        public string UserAgent { get; set; }
        public int SortOrder { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public virtual Portal Portal { get; set; }
    }
}
