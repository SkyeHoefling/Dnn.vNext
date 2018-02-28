using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class DnnDbContext : DbContext
    {
        public DnnDbContext(DbContextOptions<DnnDbContext> options) : base(options) { }

      //  *** This handles creating the composite keys for tables with 2 Primary Keys ***//
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<AnonymousUser>().HasKey(au => new { au.UserID, au.PortalID });
            builder.Entity<aspnet_SchemaVersion>().HasKey(sv => new { sv.Feature, sv.CompatibleSchemaVersion });
            builder.Entity<TabSetting>().HasKey(ts => new { ts.TabID, ts.SettingName });
            builder.Entity<TabUrl>().HasKey(tu => new { tu.TabId, tu.SeqNum });
            builder.Entity<ExtensionUrlProviderConfiguration>().HasKey(pc => new { pc.ExtensionUrlProviderID, pc.PortalID });
            builder.Entity<ExtensionUrlProviderTab>().HasKey(eupt => new { eupt.ExtensionUrlProviderID, eupt.PortalID, eupt.TabID });
            builder.Entity<ExtensionUrlProviderSetting>().HasKey(ups => new { ups.ExtensionUrlProviderID, ups.PortalID, ups.SettingName });
            builder.Entity<FileVersion>().HasKey(fv => new { fv.FileId, fv.Version });
            builder.Entity<FolderMappingsSetting>().HasKey(fms => new { fms.FolderMappingID, fms.SettingName });
            builder.Entity<ModuleSetting>().HasKey(ms => new { ms.ModuleID, ms.SettingName });
            builder.Entity<TabModuleSetting>().HasKey(tms => new { tms.TabModuleID, tms.SettingName });

            //builder.Entity<EventLog>()
            //    .HasOne(ee => ee.LogEvent).WithOne(el => el.LogEvent)
            //    .HasForeignKey<ExceptionEvent>( ee => ee.LogEventID);

        }





        public DbSet<AnonymousUser> AnonymousUsers { get; set; }
        public DbSet<aspnet_Application> aspnet_Applications  { get; set; }
        public DbSet<aspnet_Membership> aspnet_Memership { get; set; }
        public DbSet<aspnet_SchemaVersion> aspnet_SchemaVersions { get; set; }
        public DbSet<aspnet_User> aspnet_Users { get; set; }
        public DbSet<Assembly> Assemblies { get; set; }
        public DbSet<Authentication> Authentication  { get; set; }

        /*SHOULD WE REMOVE CKE EDITOR?*/
        public DbSet<CKE_Setting> CKE_Settings  { get; set; }

        public DbSet<ContentItem> ContentItems { get; set; }
        public DbSet<ContentItems_MetaData> ContentItems_MetaData { get; set; }
        public DbSet<ContentItems_Tag> ContentItems_Tags { get; set; }
        public DbSet<Content_Type> ContentTypes { get; set; }
        public DbSet<ContentWorkflow> ContentWorkflows { get; set; }
        public DbSet<ContentWorkflowAction> ContentWorkflowActios { get; set; }
        public DbSet<ContentWorkflowLog> ContentWorkflowLogs { get; set; }
        public DbSet<ContentWorkflowSource> ContentWorkflowSources { get; set; }
        public DbSet<ContentWorkflowState> ContentWorkflowStates { get; set; }
        public DbSet<CoreMessaging_Message> CoreMessaging_Messages { get; set; }
        public DbSet<CoreMessaging_MessageAttachment> CoreMessaging_MessageAttachments { get; set; }
        public DbSet<CoreMessaging_MessagingRecipient> CoreMessaging_MessagingRecipients { get; set; }
        public DbSet<CoreMessaging_NotificationType> CoreMessaging_NotificationTypes { get; set; }
        public DbSet<CoreMessaging_NotificationTypeAction> CoreMessaging_NotificationTypeActions { get; set; }
        public DbSet<CoreMessaging_Subscription> CoreMessaging_Subscriptions { get; set; }
        public DbSet<CoreMessaging_SubscriptionType> CoreMessaging_SubscriptionTypes { get; set; }
        public DbSet<CoreMessaging_UserPreference> CoreMessaging_UserPreferences { get; set; }
        public DbSet<DesktopModule> DesktopModules { get; set; }
        public DbSet<DesktopModulePermission> DesktopModulePermission { get; set; }
        public DbSet<EventLog> EventLog  { get; set; }
        public DbSet<EventLogConfig> EventLogConfig { get; set; }
        public DbSet<EventLogType> EventLogTypes { get; set; }
        public DbSet<EventQueue> EventQueue { get; set; }
        public DbSet<Exception> Exceptions { get; set; }
        public DbSet<ExceptionEvent> ExceptionEvents { get; set; }
        public DbSet<ExportImportCheckpoint> ExportImportCheckpoints { get; set; }
        public DbSet<ExportImportJob> ExportImportJobs { get; set; }
        public DbSet<ExportImportJobLog> ExportImportJobLogs { get; set; }
        public DbSet<ExportImportSetting> ExportImportSettings { get; set; }
        public DbSet<ExtensionUrlProvider> ExtensionUrlProviders { get; set; }
        public DbSet<ExtensionUrlProviderConfiguration> ExtensionUrlProviderConfiguration { get; set; }
        public DbSet<ExtensionUrlProviderSetting> ExtensionUrlProviderSetting { get; set; }
        public DbSet<ExtensionUrlProviderTab> ExtensionUrlProviderTab { get; set; }
        public DbSet<File> Files  { get; set; }
        public DbSet<FileVersion> FileVersions { get; set; }
        public DbSet<Folder> Folders  { get; set; }
        public DbSet<FolderMapping> FolderMappings { get; set; }
        public DbSet<FolderMappingsSetting> FolderMappingsSettings { get; set; }
        public DbSet<FolderPermission> FolderPermission { get; set; }
        public DbSet<HostSetting> HostSettings { get; set; }
        public DbSet<HtmlText> HtmlText { get; set; }
        public DbSet<HtmlTextLog> HtmlTextLog { get; set; }
        public DbSet<HtmlTextUser> HtmlTextUsers { get; set; }
        public DbSet<IPFilter> IPFilter { get; set; }
        public DbSet<JavascriptLibrary> JavascriptLibraries { get; set; }
        public DbSet<Journal> Journal { get; set; }
        public DbSet<Journal_Access> Journal_Access { get; set; }
        public DbSet<Journal_Comment> Journal_Comments { get; set; }
        public DbSet<Journal_Data> Journal_Data { get; set; }
        public DbSet<Journal_Security> Journal_Security { get; set; }
        public DbSet<Journal_Type> Journal_Types { get; set; }
        public DbSet<Journal_TypeFilter> Journal_TypeFilters { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<LanguagePack> LanguagePacks { get; set; }
        public DbSet<List> Lists { get; set; }
        public DbSet<Messaging_Message> Messaging_Messages { get; set; }
        public DbSet<MetaData> MetaData { get; set; }
        public DbSet<Mobile_PreviewProfile> Mobile_PreviewProfiles { get; set; }
        public DbSet<Mobile_Redirection> Mobile_Redirections { get; set; }
        public DbSet<Mobile_RedirectionRule> Mobile_RedirectionRules { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<ModuleControl> ModuleControls { get; set; }
        public DbSet<ModuleDefinition> ModuleDefinitions { get; set; }
        public DbSet<ModulePermission> ModulePermissions { get; set; }
        public DbSet<ModuleSetting> ModuleSettings { get; set; }
        public DbSet<OutputCache> OutputCache { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<PackageDependency> PackageDependencies { get; set; }
        public DbSet<Package_Type> Package_Type { get; set; }
        public DbSet<PasswordHistory> PasswordHistory { get; set; }
        public DbSet<Permission> Permission { get; set; }
        public DbSet<PersonaBarExtension> PersonaBarExtensions { get; set; }
        public DbSet<PersonaBarMenu> PersonaBarMenu { get; set; }
        public DbSet<PersonaBarMenuDefaultPermission> PersonaBarMenuDefaultPermissions { get; set; }
        public DbSet<PersonaBarMenuPermission> PersonaBarMenuPermission { get; set; }
        public DbSet<PersonaBarPermission> PersonaBarPermission { get; set; }
        public DbSet<Portal> Portals { get; set; }
        public DbSet<PortalAlias> PortalAlias  { get; set; }
        public DbSet<PortalDesktopModule> PortalDesktopModules { get; set; }
        public DbSet<PortalGroup> PortalGroups { get; set; }
        public DbSet<PortalLanguage> PortalLanguages { get; set; }
        public DbSet<PortalLocalization> PortalLocalization { get; set; }
        public DbSet<PortalSetting> PortalSettings { get; set; }
        public DbSet<Profile> Profile { get; set; }
        public DbSet<ProfilePropertyDefinition> ProfilePropertyDefinition { get; set; }
        public DbSet<RedirectMessage> RedirectMessages { get; set; }
        public DbSet<Relationship> Relationships  { get; set; }
        public DbSet<RelationshipType> RelationshipTypes { get; set; }
        public DbSet<RoleGroup> RoleGroups { get; set; }
        public DbSet<RoleSetting> RoleSettings { get; set; }
        public DbSet<Schedule> Schedule { get; set; }
        public DbSet<ScheduleHistory> ScheduleHistory { get; set; }
        public DbSet<ScheduleItemSetting> ScheduleItemSettings { get; set; }
        public DbSet<SearchCommonWord> SearchCommonWords { get; set; }
        public DbSet<SearchDeletedItem> SearchDeletedItems { get; set; }
        public DbSet<SearchIndexer> SearchIndexer { get; set; }
        public DbSet<SearchStopWord> SearchStopWords { get; set; }
        public DbSet<SearchType> SearchTypes { get; set; }
        public DbSet<Sitelog> SiteLog { get; set; }
        public DbSet<Skin> Skins { get; set; }
        public DbSet<SkinControl> SkinControls { get; set; }
        public DbSet<SkinPackage> vSkinPackages { get; set; }
        public DbSet<SQLQuery> SQLQueries { get; set; }
        public DbSet<SynonymsGroup> SynonymsGroups { get; set; }
        public DbSet<SystemMessage> SystemMessages { get; set; }
        public DbSet<Tab> Tabs { get; set; }
        public DbSet<TabAliasSkin> TabAliasSkins { get; set; }
        public DbSet<TabModule> TabModules { get; set; }
        public DbSet<TabModuleSetting> TabModuleSettings { get; set; }     
        public DbSet<TabPermission> TabPermission { get; set; }
        public DbSet<TabSetting> TabSettings { get; set; }
        public DbSet<TabUrl> TabUrls { get; set; }
        public DbSet<TabVersion> TabVersions { get; set; }
        public DbSet<TabVersionDetail> TabVersionDetails { get; set; }
        public DbSet<Taxonomy_ScopeType> Taxonomy_ScopeTypes { get; set; }
        public DbSet<Taxonomy_Term> Taxonomy_Terms { get; set; }
        public DbSet<Taxonomy_Vocabulary> Taxonomy_Vocabularies { get; set; }
        public DbSet<Taxonomy_VocabularyType> Taxonomy_VocabularyTypes { get; set; }
        public DbSet<Urls> Urls { get; set; }
        public DbSet<UrlLog> UrlLog { get; set; }
        public DbSet<UrlTracking> UrlTracking { get; set; }
        public DbSet<User> Users  { get; set; }
        public DbSet<UserAuthentication> UserAuthentication { get; set; }
        public DbSet<UserPortal> UserPortals { get; set; }
        public DbSet<UserProfile> UserProfile { get; set; }
        public DbSet<UserRelationship> UserRelationships { get; set; }
        public DbSet<UserRelationshipPreference> UserRelationshipPreferences { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<UsersOnline> UsersOnline { get; set; }
        public DbSet<Version> Version { get; set; }
        public DbSet<WebServer> WebServers { get; set; }
        public DbSet<Workflow> Workflow { get; set; }
        public DbSet<WorkflowState> WorkflowStates { get; set; }
    }

        
}
