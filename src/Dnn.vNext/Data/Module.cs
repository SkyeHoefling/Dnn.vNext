using System.Collections.Generic;

namespace Dnn.vNext.Data
{
    public class Module
    {
        public int Id { get; set; }
        public string Icon { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }

        public virtual ICollection<PageModule> PageModules { get; set; }
    }
}
