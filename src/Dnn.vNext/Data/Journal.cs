using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class Journal
    {
        [Key]
/*PK*/  public int JournalId { get; set; }
/*FK*/  public int JournalTypeId { get; set; }
        public int? UserId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public int? PortalId { get; set; }
        public int ProfielId { get; set; }
        public int GroupId { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string ItemData { get; set; }
        public string ImageURL { get; set; }
        public string ObjectKey { get; set; }
        public Guid AccessKey { get; set; }
        public int? ContentItemId { get; set; }
        public bool IsDeleted { get; set; }
        public bool CommentsDisabled { get; set; }
        public bool CommentsHIdden { get; set; }

        public virtual Journal_Type Journal_Type { get; set; }

        public virtual ICollection<Journal_Data> Journal_Data { get; set; }
        public virtual ICollection<Journal_Comment> Journal_Comment { get; set; }
    }
}
