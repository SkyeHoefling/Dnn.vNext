using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class OutputCache
    {
        [Key]
        //CacheKey should be the PK
        public string CacheKey { get; set; }

        public int ItemId { get; set; }
        public string Data { get; set; }
        public DateTime Expiration { get; set; }
    }
}
