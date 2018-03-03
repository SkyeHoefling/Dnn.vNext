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
/*PK*/  public int UserRelationshipId { get; set; }
/*FK*/  public int UserId { get; set; }
/*FK*/  public int RelatedUserId { get; set; }
/*FK*/  public int RelationshipId { get; set; }
        public int Status { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public virtual User User { get; set; }
        public virtual User RelatedUser { get; set; }
        public virtual Relationship Relationship { get; set; }
    }
}
