using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class Relationship
    {
        [Key]
/*PK*/  public int RelationshipId { get; set; }
/*FK*/  public int RelationshipTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
/*FK*/  public int? PortalId { get; set; }
/*FK*/  public int? UserId { get; set; }
        public int DefaultResponse { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public virtual Portal Portal { get; set; }
        public virtual User User { get; set; }
        public virtual RelationshipType RelationshipType {get; set;}
        public virtual ICollection<UserRelationshipPreference> UserRelationshipPreference { get; set; }
        public virtual ICollection<UserRelationship> UserRelationship { get; set; }
    }
}
