namespace Dnn.vNext.Data
{
    public class PageModule
    {
        public int Id { get; set; }
        public int PageId { get; set; }
        public int ModuleId { get; set; }

        /// <summary>
        /// The name of the html element where the module exists
        /// </summary>
        public string ElementId { get; set; }

        /// <summary>
        /// The order of the module in the html element.
        /// </summary>
        /// <remarks>
        /// If there are more than 1 module in the same element, the order
        /// determines how the modules are displayed on the screen.
        /// </remarks>
        public int Order { get; set; }
        
        public virtual Page Page { get; set; }
        public virtual Module Module { get; set; }
    }
}
