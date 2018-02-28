using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class Package
    {
        [Key]
/*PK*/  public int PackageID { get; set; }
        public int? PortalID { get; set; }
        public string Name { get; set; }
        public string FriendlyName { get; set; }
        public string Description { get; set; }

        //[ForeignKey ("PackageTypeNavigation")]
/*FK*/  public string PackageType { get; set; }

        public string Version { get; set; }
        public string License { get; set; }
        public string Manifest { get; set; }
        public string Owner { get; set; }
        public string Organization { get; set; }
        public string Url { get; set; }
        public string Email { get; set; }
        public string ReleaseNotes { get; set; }
        public bool IsSystemPackage { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserID { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
        public string FolderName { get; set; }
        public string IconFile { get; set; }


        public virtual Package_Type Package_Type { get; set; }
        public virtual ICollection<Assembly> Assemblies { get; set; }
        public virtual ICollection<SkinPackage> SkinPackage { get; set; }
        public virtual ICollection<JavascriptLibrary> JavascriptLibrary { get; set; }
        public virtual ICollection<LanguagePack> LanguagePack { get; set; }
        public virtual ICollection<SkinControl> SkinControl { get; set; }
        public virtual ICollection<DesktopModule> DesktopModule { get; set; }
        public virtual ICollection<PackageDependency> PackageDependency { get; set; }
        public virtual ICollection<Authentication> Authentications { get; set; }

        public virtual Package PackageTypeNavigation {get; set;}
        
    }
}
