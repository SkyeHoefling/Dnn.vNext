using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class UserProfile
    {
        [Key]
/*PK*/  public int ProfileId { get; set; }
/*FK*/  public int UserId { get; set; }
/*FK*/  public int ProfilePropertyDefinitionId { get; set; }
        public string PropertyValue { get; set; }
        public string PropertyText { get; set; }
        public int Visibility { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string ExtendedVisibility { get; set; }

        public virtual User User {get; set;}
        public virtual ProfilePropertyDefinition ProfilePropertyDefinition { get; set; }
    }
}
