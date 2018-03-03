using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class SearchType
    {
        [Key]
/*PK*/  public int SearchTypeId { get; set; }
        public string SearchTypeName { get; set; }
        public string SearchResultClass { get; set; }
        public bool? IsPrivate { get; set; }
    }
}
