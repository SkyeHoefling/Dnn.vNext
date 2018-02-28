using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class WorkflowState
    {
        [Key]
/*PK*/  public int StateID { get; set; }
/*FK*/  public int WorkflowID { get; set; }
        public string StateName { get; set; }
        public bool Order { get; set; }
        public bool IsActive { get; set; }
        public bool Notify { get; set; }


        public virtual Workflow Workflow { get; set; }
    }
}
