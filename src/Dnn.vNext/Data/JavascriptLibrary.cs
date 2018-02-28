using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class JavascriptLibrary
    {
        [Key]
/*PK*/  public int JavaScriptLibraryID { get; set; }
/*FK*/  public int PackageID { get; set; }
        public string LibraryName { get; set; }
        public string Version { get; set; }
        public string FileName { get; set; }
        public string ObjectName { get; set; }
        public int PreferredScriptLocation { get; set; }
        public string CDNPath { get; set; }

        public virtual Package Package { get; set; }
    }
}
