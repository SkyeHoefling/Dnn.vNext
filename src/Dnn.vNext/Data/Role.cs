using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class Role
    {
        [Key]
/*PK*/  public int RoleID { get; set; }
/*FK*/  public int? PortalID { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }
        public decimal ServiceFee { get; set; }
        public string BillingFrequency { get; set; }
        public int? TrialPeriod { get; set; }
        public string TrialFrequency { get; set; }
        public int? BillingPeriod { get; set; }
        public decimal? TrialFee { get; set; }
        public bool IsPublic { get; set; }
        public bool AutoAssignment { get; set; }
/*FK*/  public int? RoleGroupID { get; set; }
        public string RSVPCode { get; set; }
        public string IconFile { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserID { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
        public int Status { get; set; }
        public int SecurityMode { get; set; }
        public bool IsSystemRole { get; set; }

        public virtual Portal Portal { get; set; }
        public virtual RoleGroup RoleGroup { get; set; }

        public virtual ICollection<UserRole> UserRole { get; set; }
        public virtual ICollection<PersonaBarMenuPermission> PersonaBarMenuPermission { get; set; }
        public virtual ICollection<ModulePermission> ModulePermission { get; set; }
        public virtual ICollection<DesktopModulePermission> DesktopModulePermission { get; set; }
        public virtual ICollection<TabPermission> TabPermission { get; set; }
        public virtual ICollection<FolderPermission> FolderPermission { get; set; }
    }
}
