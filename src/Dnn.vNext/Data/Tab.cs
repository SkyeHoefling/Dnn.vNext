using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dnn.vNext.Data
{
    public class Tab
    {
        [Key]
        public int TabID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TabModule> PageModules { get; set; }
    }
}
