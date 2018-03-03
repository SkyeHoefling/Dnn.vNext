using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class FileVersion
    {
        [Key, Column(Order = 0)]
        /*PK*/
        public int FileId { get; set; }

        [Key, Column(Order = 1)]
        /*PK*/
        public int Version { get; set; }

        public string FileName { get; set; }
        public string Extension { get; set; }
        public int Size { get; set; }
        public int? WIdth { get; set; }
        public int? Height { get; set; }
        public string ContentType { get; set; }
        public Byte? Content { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
        public string SHA1Hash { get; set; }

        public virtual File File { get; set; }
    }
}
