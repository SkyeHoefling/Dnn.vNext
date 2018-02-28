using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class SearchCommonWord
    {
        [Key]
/*PK*/  public int CommonWordID { get; set; }
        public string CommonWord { get; set; }
        public string Locale { get; set; }
    }
}
