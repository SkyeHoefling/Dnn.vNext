using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class UserRelationshipPreference
    {
        [Key]
/*PK*/  public int PreferenceId { get; set; }
/*FK*/  public int UserId { get; set; }
/*FK*/  public int RealtionshipId { get; set; }
        public int DefaultResponse { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public virtual User User { get; set; }
        public virtual Relationship Relationship { get; set; }
    }
}
