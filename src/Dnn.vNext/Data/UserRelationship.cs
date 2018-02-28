using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class UserRelationship
    {
        [Key]
/*PK*/  public int UserRelationshipID { get; set; }
/*FK*/  public int UserID { get; set; }
/*FK*/  public int RelatedUserID { get; set; }
/*FK*/  public int RelationshipID { get; set; }
        public int Status { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserID { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public virtual User User { get; set; }
        public virtual User RelatedUser { get; set; }
        public virtual Relationship Relationship { get; set; }
    }
}
