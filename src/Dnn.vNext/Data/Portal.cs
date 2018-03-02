using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class Portal
    {
        [Key]
        /*PK*/
        public int PortalId { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public int UserRegistration { get; set; }
        public int BannerAdvertising { get; set; }
        public int? AdministratorId { get; set; }
        public string Currency { get; set; }
        public decimal HostFee { get; set; }
        public int HostSpace { get; set; }
        public int? AdministratorRoleId { get; set; }
        public int? RegisteredRoleId { get; set; }
        public Guid Guid { get; set; }
        public string PaymentProcessor { get; set; }
        public string ProcessorUserId { get; set; }
        public string ProcessorPassword { get; set; }
        public int? SiteLogHistory { get; set; }
        public string DefaultLanguage { get; set; }
        public int TimezoneOffset { get; set; }
        public string HomeDirectory { get; set; }
        public int PageQuota { get; set; }
        public int UserQuota { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }


        public virtual ICollection<ProfilePropertyDefinition> ProfilePropertyDefinition {get; set;}
        public virtual ICollection<UsersOnline> UsersOnline {get; set;}
        public virtual ICollection<RoleGroup> RoleGroup {get; set;}
        public virtual ICollection<Role> Role {get; set;}
        public virtual ICollection<PersonaBarMenuPermission> PersonaBarMenuPermission {get; set;}
        public virtual ICollection<PortalDesktopModule> PortalDesktopModule {get; set;}
        public virtual ICollection<Folder> Folder {get; set;}
        public virtual ICollection<File> File {get; set;}
        public virtual ICollection<Tab> Tab {get; set;}
        public virtual ICollection<CoreMessaging_Subscription> CoreMessaging_Subscription {get; set;}
        public virtual ICollection<Profile> Profile {get; set;}
        public virtual ICollection<UserPortal> UserPortal {get; set;}
        public virtual ICollection<Relationship> Relationship {get; set;}
        public virtual ICollection<AnonymousUser> AnonymousUser {get; set;}
        public virtual ICollection<PortalSetting> PortalSetting {get; set;}
        public virtual ICollection<UrlTracking> UrlTracking {get; set;}
        public virtual ICollection<PortalLocalization> PortalLocalization {get; set;}
        public virtual ICollection<Urls> Urls {get; set;}
        public virtual ICollection<SystemMessage> SystemMessage {get; set;}
        public virtual ICollection<PortalAlias> PortalAlias {get; set;}
        public virtual ICollection<Mobile_Redirection> Mobile_Redirection {get; set;}
        public virtual ICollection<Sitelog> Sitelog {get; set;}
        public virtual ICollection<Mobile_PreviewProfile> Mobile_PreviewProfile { get; set; }
        public virtual ICollection<PortalLanguage> PortalLanguage { get; set; }
        public virtual ICollection<FolderMapping> FolderMapping { get; set; }
    }
}
