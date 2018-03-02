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
 /*PK*/ public int PasswordHistoryId { get; set; }
 /*FK*/ public int UserId { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public virtual User User { get; set; }
    }
}
