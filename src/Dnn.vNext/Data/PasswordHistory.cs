using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class PasswordHistory
    {
        [Key]
 /*PK*/ public int PasswordHistoryID { get; set; }
 /*FK*/ public int UserID { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserID { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public virtual User User { get; set; }
    }
}
