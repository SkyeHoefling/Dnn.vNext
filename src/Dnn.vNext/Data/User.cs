using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class User
    {
        [Key]
/*PK*/  public int UserID { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsSuperUser { get; set; }
        public int? AffiliateId { get; set; }
        public string Email { get; set; }
        public string DisplayName { get; set; }
        public bool UpdatePassword { get; set; }
        public string LastIPAddress { get; set; }
        public bool IsDeleted { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserID { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
        public Guid PasswordResetToken { get; set; }
        public DateTime? PasswordResetExpiration { get; set; }
        public string LowerEmail { get; set; }

        public virtual ICollection<UserProfile> UserProfile {get; set;}
        public virtual ICollection<UsersOnline> UsersOnline {get; set;}
        public virtual ICollection<UserRole> UserRole {get; set;}
        public virtual ICollection<ModulePermission> ModulePermission {get; set;}
        public virtual ICollection<PersonaBarMenuPermission> PersonaBarMenuPermission {get; set;}
        public virtual ICollection<DesktopModulePermission> DesktopModulePermission{get; set;}
        public virtual ICollection<TabPermission> TabPermission {get; set;}
        public virtual ICollection<FolderPermission> FolderPermission {get; set;}
        public virtual ICollection<ContentWorkflowStatePermission> ContentWorkflowStatePermission {get; set;}
        public virtual ICollection<CoreMessaging_Subscription> CoreMessaging_Subscription {get; set;}
        public virtual ICollection<Profile> Profile {get; set;}
        public virtual ICollection<PasswordHistory> PasswordHistory {get; set;}
        public virtual ICollection<UserPortal> UserPortal {get; set;}
        public virtual ICollection<UserAuthentication> UserAuthentication {get; set;}
        public virtual ICollection<Relationship> Relationship {get; set;}
        public virtual ICollection<UserRelationshipPreference> UserRelationshipPreference {get; set;}
        //public virtual ICollection<UserRelationship> UserRelationship {get; set;}        
    }
}
