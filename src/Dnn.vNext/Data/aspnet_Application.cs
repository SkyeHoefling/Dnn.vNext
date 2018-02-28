using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class aspnet_Application
    {
        public string ApplicationName { get; set; }
        public string LoweredApplicationName { get; set; }
        [Key]
/*PK*/  public Guid ApplicationId { get; set; }
        public string Description { get; set; }
    }
}
