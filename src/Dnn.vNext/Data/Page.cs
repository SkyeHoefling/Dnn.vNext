using System.Collections.Generic;

namespace Dnn.vNext.Data
{
    public class Page
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<PageModule> PageModules { get; set; }
    }
}
