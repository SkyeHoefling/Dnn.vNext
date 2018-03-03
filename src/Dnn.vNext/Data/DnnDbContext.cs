using Microsoft.EntityFrameworkCore;

namespace Dnn.vNext.Data
{
    public class DnnDbContext : DbContext
    {
        public DnnDbContext(DbContextOptions<DnnDbContext> options) : base(options)
        {
        }

        //  *** This handles creating the composite keys for tables with 2 Primary Keys ***//
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<AnonymousUser>().HasKey(au => new {au.UserId, au.PortalId});
            builder.Entity<AnonymousUser>().Property(au => au.CreationDate).HasDefaultValueSql("getdate()");
            builder.Entity<AnonymousUser>().Property(au => au.LastActiveDate).HasDefaultValueSql("getdate()");
            builder.Entity<aspnet_Application>().Property(au => au.ApplicationId).HasDefaultValueSql("newId()");
            builder.Entity<aspnet_SchemaVersion>().HasKey(sv => new {sv.Feature, sv.CompatibleSchemaVersion});
            builder.Entity<aspnet_User>().Property(au => au.UserId).HasDefaultValueSql("newId()");
            builder.Entity<aspnet_User>().Property(au => au.MobileAlias).HasDefaultValueSql("null");
            builder.Entity<aspnet_User>().Property(au => au.IsAnonymous).HasDefaultValue(0);
            builder.Entity<aspnet_User>().HasIndex(au => new {au.ApplicationId, au.LastActivityDate})
                .ForSqlServerIsClustered(false);
            builder.Entity<aspnet_User>().HasIndex(au => new {au.ApplicationId, au.LoweredUserName})
                .ForSqlServerIsClustered(true);
            builder.Entity<Assembly>().HasOne(a => a.Package).WithMany(a => a.Assemblies)
                .OnDelete(DeleteBehavior.Cascade);
            builder.Entity<Authentication>().Property(au => au.PackageId).HasDefaultValue(-1);
            builder.Entity<Authentication>().Property(au => au.IsEnabled).HasDefaultValue(0);
            builder.Entity<ContentItem>().Property(au => au.Indexed).HasDefaultValue(0);
            builder.Entity<ContentItem>().HasIndex(ci => ci.TabId).ForSqlServerIsClustered(false);
            builder.Entity<ContentItems_Tag>().HasIndex(ct => new {ct.ContentItemId, ct.TermId}).IsUnique(true);
            builder.Entity<ContentWorkflowLog>().Property(au => au.Type).HasDefaultValue(-1);
            builder.Entity<ContentWorkflow>().Property(au => au.IsDeleted).HasDefaultValue(0);
            builder.Entity<ContentWorkflow>().Property(au => au.StartAfterCreating).HasDefaultValue(1);
            builder.Entity<ContentWorkflow>().Property(au => au.StartAfterEditing).HasDefaultValue(1);
            builder.Entity<ContentWorkflow>().Property(au => au.DispositionEnabled).HasDefaultValue(0);
            builder.Entity<ContentWorkflow>().Property(au => au.IsSystem).HasDefaultValue(0);
            builder.Entity<ContentWorkflow>().Property(au => au.WorkflowKey).HasDefaultValueSql("''");
            builder.Entity<ContentWorkflow>().HasIndex(ct => new {ct.PortalId, ct.WorkflowName}).IsUnique(true);
            builder.Entity<ContentWorkflowSource>().HasIndex(ct => new {ct.WorkflowId, ct.SourceName}).IsUnique(true);
            builder.Entity<ContentWorkflowStatePermission>()
                .HasIndex(ct => new {ct.StateId, ct.PermissionId, ct.RoleId, ct.UserId}).IsUnique(true);
            builder.Entity<ContentWorkflowState>().Property(au => au.IsActive).HasDefaultValue(1);
            builder.Entity<ContentWorkflowState>().Property(au => au.SendEmail).HasDefaultValue(0);
            builder.Entity<ContentWorkflowState>().Property(au => au.SendMessage).HasDefaultValue(0);
            builder.Entity<ContentWorkflowState>().Property(au => au.IsDisposalState).HasDefaultValue(0);
            builder.Entity<ContentWorkflowState>().Property(au => au.OnCompleteMessageSubject).HasDefaultValueSql("''");
            builder.Entity<ContentWorkflowState>().Property(au => au.OnCompleteMessageBody).HasDefaultValueSql("''");
            builder.Entity<ContentWorkflowState>().Property(au => au.OnDiscardMessageSubject).HasDefaultValueSql("''");
            builder.Entity<ContentWorkflowState>().Property(au => au.OnDiscardMessageBody).HasDefaultValueSql("''");
            builder.Entity<ContentWorkflowState>().Property(au => au.IsSystem).HasDefaultValue(0);
            builder.Entity<ContentWorkflowState>().Property(au => au.SendNotification).HasDefaultValue(1);
            builder.Entity<ContentWorkflowState>().Property(au => au.SendNotificationToAdministrators)
                .HasDefaultValue(1);
            builder.Entity<ContentWorkflowState>().HasIndex(ct => new {ct.WorkflowId, ct.StateName}).IsUnique(true);
            builder.Entity<CoreMessaging_Message>()
                .HasIndex(ct => new {ct.MessageId, ct.PortalId, ct.NotificationTypeId, ct.ExpirationDate})
                .IsUnique(true);
            builder.Entity<CoreMessaging_NotificationType>().Property(au => au.IsTask).HasDefaultValue(0);
            builder.Entity<CoreMessaging_NotificationType>().HasIndex(ct => new {ct.Name}).IsUnique(true);
            builder.Entity<CoreMessaging_SubscriptionType>().HasIndex(cs => new {cs.SubscriptionName}).IsUnique(true);
            builder.Entity<DesktopModulePermission>()
                .HasIndex(dmp => new {dmp.PortalDesktopModuleId, dmp.PermissionId, dmp.RoleId, dmp.UserId})
                .IsUnique(true);
            builder.Entity<DesktopModulePermission>().HasIndex(dmp => new {dmp.UserId}).IsUnique(true);
            builder.Entity<DesktopModulePermission>().HasIndex(dmp => new {dmp.RoleId}).IsUnique(true);
            builder.Entity<DesktopModule>().Property(au => au.SupportedFeatures).HasDefaultValue(0);
            builder.Entity<DesktopModule>().Property(au => au.PackageId).HasDefaultValue(-1);
            builder.Entity<DesktopModule>().Property(au => au.ContentItemId).HasDefaultValue(-1);
            builder.Entity<DesktopModule>().Property(au => au.Shareable).HasDefaultValue(0);
            builder.Entity<EventLogConfig>().HasIndex(elc => new {elc.LogTypeKey, elc.LogTypePortalId}).IsUnique(true);
            builder.Entity<ExportImportCheckpoint>().Property(au => au.TotalItems).HasDefaultValue(0);
            builder.Entity<ExportImportCheckpoint>().Property(au => au.ProcessedItems).HasDefaultValue(0);
            builder.Entity<ExportImportCheckpoint>().Property(au => au.Completed).HasDefaultValue(0);
            builder.Entity<ExportImportCheckpoint>().HasIndex(eic => new {eic.Category, eic.AssemblyName, eic.JobId})
                .IsUnique(true);
            builder.Entity<ExportImportCheckpoint>().HasIndex(eic => new {eic.Category});
            builder.Entity<ExportImportCheckpoint>().HasIndex(eic => new {eic.JobId});
            builder.Entity<ExportImportJobLog>().Property(au => au.Level).HasDefaultValue(0);
            builder.Entity<ExportImportJobLog>().Property(au => au.CreatedOnDate).HasDefaultValueSql("getutcdate()");

            builder.Entity<TabSetting>().HasKey(ts => new {ts.TabId, ts.SettingName});
            builder.Entity<TabUrl>().HasKey(tu => new {tu.TabId, tu.SeqNum});
            builder.Entity<ExtensionUrlProvIderConfiguration>()
                .HasKey(pc => new {pc.ExtensionUrlProvIderId, pc.PortalId});
            builder.Entity<ExtensionUrlProvIderTab>()
                .HasKey(eupt => new {eupt.ExtensionUrlProvIderId, eupt.PortalId, eupt.TabId});
            builder.Entity<ExtensionUrlProvIderSetting>()
                .HasKey(ups => new {ups.ExtensionUrlProvIderId, ups.PortalId, ups.SettingName});
            builder.Entity<FileVersion>().HasKey(fv => new {fv.FileId, fv.Version});
            builder.Entity<FolderMappingsSetting>().HasKey(fms => new {fms.FolderMappingId, fms.SettingName});
            builder.Entity<ModuleSetting>().HasKey(ms => new {ms.ModuleId, ms.SettingName});
            builder.Entity<TabModuleSetting>().HasKey(tms => new {tms.TabModuleId, tms.SettingName});

            //builder.Entity<EventLog>()
            //    .HasOne(ee => ee.LogEvent).WithOne(el => el.LogEvent)
            //    .HasForeignKey<ExceptionEvent>( ee => ee.LogEventId);
        }


        public DbSet<AnonymousUser> AnonymousUsers { get; set; }
        public DbSet<aspnet_Application> aspnet_Applications { get; set; }
        public DbSet<aspnet_Membership> aspnet_Membership { get; set; }
        public DbSet<aspnet_SchemaVersion> aspnet_SchemaVersions { get; set; }
        public DbSet<aspnet_User> aspnet_Users { get; set; }
        public DbSet<Assembly> Assemblies { get; set; }
        public DbSet<Authentication> Authentication { get; set; }

        /*SHOULD WE REMOVE CKE EDITOR?*/
        public DbSet<CKE_Setting> CKE_Settings { get; set; }

        public DbSet<ContentItem> ContentItems { get; set; }
        public DbSet<ContentItems_MetaData> ContentItems_MetaData { get; set; }
        public DbSet<ContentItems_Tag> ContentItems_Tags { get; set; }
        public DbSet<Content_Type> ContentTypes { get; set; }
        public DbSet<ContentWorkflow> ContentWorkflows { get; set; }
        public DbSet<ContentWorkflowAction> ContentWorkflowActions { get; set; }
        public DbSet<ContentWorkflowLog> ContentWorkflowLogs { get; set; }
        public DbSet<ContentWorkflowSource> ContentWorkflowSources { get; set; }
        public DbSet<ContentWorkflowState> ContentWorkflowStates { get; set; }
        public DbSet<CoreMessaging_Message> CoreMessaging_Messages { get; set; }
        public DbSet<CoreMessaging_MessageAttachment> CoreMessaging_MessageAttachments { get; set; }
        public DbSet<CoreMessaging_MessagingRecipient> CoreMessaging_MessageRecipients { get; set; }
        public DbSet<CoreMessaging_NotificationType> CoreMessaging_NotificationTypes { get; set; }
        public DbSet<CoreMessaging_NotificationTypeAction> CoreMessaging_NotificationTypeActions { get; set; }
        public DbSet<CoreMessaging_Subscription> CoreMessaging_Subscriptions { get; set; }
        public DbSet<CoreMessaging_SubscriptionType> CoreMessaging_SubscriptionTypes { get; set; }
        public DbSet<CoreMessaging_UserPreference> CoreMessaging_UserPreferences { get; set; }
        public DbSet<DesktopModule> DesktopModules { get; set; }
        public DbSet<DesktopModulePermission> DesktopModulePermission { get; set; }
        public DbSet<EventLog> EventLog { get; set; }
        public DbSet<EventLogConfig> EventLogConfig { get; set; }
        public DbSet<EventLogType> EventLogTypes { get; set; }
        public DbSet<EventQueue> EventQueue { get; set; }
        public DbSet<Exception> Exceptions { get; set; }
        public DbSet<ExceptionEvent> ExceptionEvents { get; set; }
        public DbSet<ExportImportCheckpoint> ExportImportCheckpoints { get; set; }
        public DbSet<ExportImportJob> ExportImportJobs { get; set; }
        public DbSet<ExportImportJobLog> ExportImportJobLogs { get; set; }
        public DbSet<ExportImportSetting> ExportImportSettings { get; set; }
        public DbSet<ExtensionUrlProvIder> ExtensionUrlProvIders { get; set; }
        public DbSet<ExtensionUrlProvIderConfiguration> ExtensionUrlProvIderConfiguration { get; set; }
        public DbSet<ExtensionUrlProvIderSetting> ExtensionUrlProvIderSetting { get; set; }
        public DbSet<ExtensionUrlProvIderTab> ExtensionUrlProvIderTab { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<FileVersion> FileVersions { get; set; }
        public DbSet<Folder> Folders { get; set; }
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
        public DbSet<ModulePermission> ModulePermission { get; set; }
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
        public DbSet<PortalAlias> PortalAlias { get; set; }
        public DbSet<PortalDesktopModule> PortalDesktopModules { get; set; }
        public DbSet<PortalGroup> PortalGroups { get; set; }
        public DbSet<PortalLanguage> PortalLanguages { get; set; }
        public DbSet<PortalLocalization> PortalLocalization { get; set; }
        public DbSet<PortalSetting> PortalSettings { get; set; }
        public DbSet<Profile> Profile { get; set; }
        public DbSet<ProfilePropertyDefinition> ProfilePropertyDefinition { get; set; }
        public DbSet<RedirectMessage> RedirectMessages { get; set; }
        public DbSet<Relationship> Relationships { get; set; }
        public DbSet<RelationshipType> RelationshipTypes { get; set; }
        public DbSet<Role> Roles { get; set; }
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
        public DbSet<SkinPackage> SkinPackages { get; set; }
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
        public DbSet<User> Users { get; set; }
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