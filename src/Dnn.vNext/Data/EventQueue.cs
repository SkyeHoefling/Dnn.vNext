using System;
using System.ComponentModel.DataAnnotations;

namespace Dnn.vNext.Data
{
    public class EventQueue
    {
        [Key]
/*PK*/ public int EventMessageId { get; set; }

        [Required]
        [MaxLength(100)]
        public string EventName { get; set; }

        public int Priority { get; set; }

        [Required]
        [MaxLength(250)]
        public string ProcessorType { get; set; }

        [Required]
        [MaxLength(250)]
        public string ProcessorCommand { get; set; }

        [Required]
        [MaxLength(250)]
        public string Body { get; set; }

        [Required]
        [MaxLength(250)]
        public string Sender { get; set; }

        [Required]
        [MaxLength(100)]
        public string Subscriber { get; set; }

        [Required]
        [MaxLength(250)]
        public string AuthorizedRoles { get; set; }

        [Required]
        [MaxLength(250)]
        public string ExceptionMessage { get; set; }

        public DateTime SentDate { get; set; }

        public DateTime ExpirationDate { get; set; }

        //TODO: Changed from ntext => nVARCHAR(MAX)
        public string Attributes { get; set; }

        public bool IsComplete { get; set; }
    }
}