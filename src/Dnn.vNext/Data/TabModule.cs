using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class TabModule
    {
        public int TabModuleID { get; set; }
        public int TabID { get; set; }
        public int ModuleID { get; set; }
        public string PaneName { get; set; }
        public int ModuleOrder { get; set; }
        public int CacheTime { get; set; }
        public string Alignment { get; set; }
        public string Color { get; set; }
        public string Border { get; set; }
        public string IconFile { get; set; }
        public int Visibility { get; set; }
        public string ContainerSrc { get; set; }
        public int DisplayTitle { get; set; }
        public int DisplayPrint { get; set; }
        public int DisplaySyndicate { get; set; }
        public int IsWebSlice { get; set; }
        public string WebSliceTitle { get; set; }
        public DateTime? WebSliceExpiryDate { get; set; }
        public int? WebSliceTTL { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserID { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
        public int IsDeleted { get; set; }
        public string CacheMethod { get; set; }
        public string ModuleTitle { get; set; }
        public string Header { get; set; }
        public string Footer { get; set; }
        public string CultureCode { get; set; }
        public Guid UniqueId { get; set; }
        public Guid VersionGUID { get; set; }
        public Guid DefaultLanguageGUID { get; set; }
        public Guid LocalizedVersionGUID { get; set; }
    }
}
