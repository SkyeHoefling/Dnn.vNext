using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class SearchIndexer
    {
        [Key]
/*PK*/  public int SearchIndexerId { get; set; }
        public string SearchIndexerAssemblyQualifiedName { get; set; }
    }
}
