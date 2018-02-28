using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class List
    {
        [Key]
/*PK*/  public int EntryID { get; set; }
        public string ListName { get; set; }
        public string Value { get; set; }
        public string Text { get; set; }
        public int ParentID { get; set; }
        public int Level { get; set; }
        public int SortOrder { get; set; }
        public int DefinitionID { get; set; }
        public string Description { get; set; }
        public int PortalID { get; set; }
        public bool SystemList { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserID { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
    }
}
