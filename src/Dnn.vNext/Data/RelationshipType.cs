using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class RelationshipType
    {
        [Key]
/*PK*/  public int RelationshipTypeID { get; set; }
        public int Direction { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserID { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public virtual ICollection<Relationship> Relationship { get; set; }
    }
}
