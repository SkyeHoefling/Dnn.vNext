using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class WebServer
    {
        [Key]
/*PK*/  public int ServerID { get; set; }
        public string ServerName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastActivityDate { get; set; }
        public string URL { get; set; }
        public string IISAppName { get; set; }
        public bool Enabled { get; set; }
        public string ServerGroup { get; set; }
        public string UniqueID { get; set; }
        public int PingFailureCount { get; set; }
    }
}
