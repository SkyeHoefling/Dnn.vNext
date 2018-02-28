using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class ContentWorkflowAction
    {
        [Key]
 /*PK*/ public int ActionID { get; set; }
 /*FK*/ public int ContentTypeID { get; set; }
        public string ActionType { get; set; }
        public string ActionSource { get; set; }

        public virtual ICollection<ContentWorkflowAction> ContentType { get; set; }
    }
}
