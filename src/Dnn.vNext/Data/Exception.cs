using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class Exception
    {
        [Key]
/*PK*/  public string ExceptionHash { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public string InnerMessage { get; set; }
        public string InnerStackTrace { get; set; }
        public string Source { get; set; }
    }
}
