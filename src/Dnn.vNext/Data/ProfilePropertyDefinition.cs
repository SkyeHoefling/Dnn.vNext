using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class ProfilePropertyDefinition
    {
        [Key]
/*PK*/  public int PropertyDefinitionID { get; set; }
/*FK*/  public int? PortalID { get; set; }
        public int? ModuleDefId { get; set; }
        public bool Deleted { get; set; }
        public int DataType { get; set; }
        public string DefaultValue { get; set; }
        public string PropertyCategory { get; set; }
        public string PropertyName { get; set; }
        public int Length { get; set; }
        public bool Required { get; set; }
        public string ValidationExpression { get; set; }
        public int ViewOrder { get; set; }
        public bool Visible { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserID { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
        public int? DefaultVisibility { get; set; }
        public bool ReadOnly { get; set; }

        public virtual Portal Portal { get; set; }
        public virtual ICollection<UserProfile> UserProfile { get; set; }
    }
}
