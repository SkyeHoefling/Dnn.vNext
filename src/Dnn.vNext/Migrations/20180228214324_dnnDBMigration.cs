using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Dnn.vNext.Migrations
{
    public partial class dnnDBMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "aspnet_Applications",
                columns: table => new
                {
                    ApplicationId = table.Column<Guid>(nullable: false),
                    ApplicationName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    LoweredApplicationName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aspnet_Applications", x => x.ApplicationId);
                });

            migrationBuilder.CreateTable(
                name: "aspnet_SchemaVersions",
                columns: table => new
                {
                    Feature = table.Column<string>(nullable: false),
                    CompatibleSchemaVersion = table.Column<string>(nullable: false),
                    IsCurrentVersion = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aspnet_SchemaVersions", x => new { x.Feature, x.CompatibleSchemaVersion });
                    table.UniqueConstraint("AK_aspnet_SchemaVersions_CompatibleSchemaVersion_Feature", x => new { x.CompatibleSchemaVersion, x.Feature });
                });

            migrationBuilder.CreateTable(
                name: "CKE_Settings",
                columns: table => new
                {
                    SettingName = table.Column<string>(nullable: false),
                    SettingValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CKE_Settings", x => x.SettingName);
                });

            migrationBuilder.CreateTable(
                name: "ContentType",
                columns: table => new
                {
                    ContentTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContentType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentType", x => x.ContentTypeID);
                });

            migrationBuilder.CreateTable(
                name: "ContentWorkflowActios",
                columns: table => new
                {
                    ActionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ActionSource = table.Column<string>(nullable: true),
                    ActionType = table.Column<string>(nullable: true),
                    ContentTypeID = table.Column<int>(nullable: false),
                    ContentWorkflowActionActionID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentWorkflowActios", x => x.ActionID);
                    table.ForeignKey(
                        name: "FK_ContentWorkflowActios_ContentWorkflowActios_ContentWorkflowActionActionID",
                        column: x => x.ContentWorkflowActionActionID,
                        principalTable: "ContentWorkflowActios",
                        principalColumn: "ActionID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CoreMessaging_SubscriptionTypes",
                columns: table => new
                {
                    SubscriptionTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DesktopModuleID = table.Column<int>(nullable: true),
                    FriendlyName = table.Column<string>(nullable: true),
                    SubscriptionName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoreMessaging_SubscriptionTypes", x => x.SubscriptionTypeID);
                });

            migrationBuilder.CreateTable(
                name: "CoreMessaging_UserPreferences",
                columns: table => new
                {
                    UserPreferenceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MessagesEmailFrequency = table.Column<int>(nullable: false),
                    NotificationsEmailFrequency = table.Column<int>(nullable: false),
                    PortalID = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoreMessaging_UserPreferences", x => x.UserPreferenceID);
                });

            migrationBuilder.CreateTable(
                name: "EventLogTypes",
                columns: table => new
                {
                    LogTypeKey = table.Column<string>(nullable: false),
                    LogTypeCSSClass = table.Column<string>(nullable: true),
                    LogTypeDescription = table.Column<string>(nullable: true),
                    LogTypeFriendlyName = table.Column<string>(nullable: true),
                    LogTypeOwner = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventLogTypes", x => x.LogTypeKey);
                });

            migrationBuilder.CreateTable(
                name: "EventQueue",
                columns: table => new
                {
                    EventMessageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Attributes = table.Column<string>(nullable: true),
                    AuthorizedRoles = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    EventName = table.Column<string>(nullable: true),
                    ExceptionMessage = table.Column<string>(nullable: true),
                    ExpirationDate = table.Column<DateTime>(nullable: false),
                    IsComplete = table.Column<bool>(nullable: false),
                    Priority = table.Column<int>(nullable: false),
                    ProcessorCommand = table.Column<string>(nullable: true),
                    ProcessorType = table.Column<string>(nullable: true),
                    Sender = table.Column<string>(nullable: true),
                    SentDate = table.Column<DateTime>(nullable: false),
                    Subscriber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventQueue", x => x.EventMessageID);
                });

            migrationBuilder.CreateTable(
                name: "Exceptions",
                columns: table => new
                {
                    ExceptionHash = table.Column<string>(nullable: false),
                    InnerMessage = table.Column<string>(nullable: true),
                    InnerStackTrace = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    Source = table.Column<string>(nullable: true),
                    StackTrace = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exceptions", x => x.ExceptionHash);
                });

            migrationBuilder.CreateTable(
                name: "ExportImportJobs",
                columns: table => new
                {
                    JobId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompletedOnDate = table.Column<DateTime>(nullable: false),
                    CreatedByUserID = table.Column<int>(nullable: false),
                    CreatedOnDate = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Directory = table.Column<string>(nullable: true),
                    IsCancelled = table.Column<bool>(nullable: false),
                    JobObject = table.Column<string>(nullable: true),
                    JobStatus = table.Column<int>(nullable: false),
                    JobType = table.Column<int>(nullable: false),
                    LastModifiedDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PortalId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExportImportJobs", x => x.JobId);
                });

            migrationBuilder.CreateTable(
                name: "ExportImportSettings",
                columns: table => new
                {
                    SettingName = table.Column<string>(nullable: false),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    SettingIsSecure = table.Column<bool>(nullable: false),
                    SettingValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExportImportSettings", x => x.SettingName);
                });

            migrationBuilder.CreateTable(
                name: "ExtensionUrlProviderConfiguration",
                columns: table => new
                {
                    ExtensionUrlProviderID = table.Column<int>(nullable: false),
                    PortalID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtensionUrlProviderConfiguration", x => new { x.ExtensionUrlProviderID, x.PortalID });
                });

            migrationBuilder.CreateTable(
                name: "ExtensionUrlProviders",
                columns: table => new
                {
                    ExtensionUrlProviderID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DekstopModuleId = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    ProviderName = table.Column<string>(nullable: true),
                    ProviderType = table.Column<string>(nullable: true),
                    RedirectAllUrls = table.Column<bool>(nullable: false),
                    ReplaceAllUrls = table.Column<bool>(nullable: false),
                    RewriteAllUrls = table.Column<bool>(nullable: false),
                    SettingsControlSrc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtensionUrlProviders", x => x.ExtensionUrlProviderID);
                });

            migrationBuilder.CreateTable(
                name: "ExtensionUrlProviderSetting",
                columns: table => new
                {
                    ExtensionUrlProviderID = table.Column<int>(nullable: false),
                    PortalID = table.Column<int>(nullable: false),
                    SettingName = table.Column<string>(nullable: false),
                    SettingValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtensionUrlProviderSetting", x => new { x.ExtensionUrlProviderID, x.PortalID, x.SettingName });
                });

            migrationBuilder.CreateTable(
                name: "ExtensionUrlProviderTab",
                columns: table => new
                {
                    ExtensionUrlProviderID = table.Column<int>(nullable: false),
                    PortalID = table.Column<int>(nullable: false),
                    TabID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtensionUrlProviderTab", x => new { x.ExtensionUrlProviderID, x.PortalID, x.TabID });
                });

            migrationBuilder.CreateTable(
                name: "HostSettings",
                columns: table => new
                {
                    SettingName = table.Column<string>(nullable: false),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    SettingIsSecure = table.Column<bool>(nullable: false),
                    SettingValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HostSettings", x => x.SettingName);
                });

            migrationBuilder.CreateTable(
                name: "IPFilter",
                columns: table => new
                {
                    IPFilterID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    IPAddress = table.Column<string>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    RuleType = table.Column<int>(nullable: true),
                    SubnetMask = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IPFilter", x => x.IPFilterID);
                });

            migrationBuilder.CreateTable(
                name: "Journal_Access",
                columns: table => new
                {
                    JournalAccessId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccessKey = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    IsEnabled = table.Column<bool>(nullable: false),
                    JournalTypeId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PortalId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Journal_Access", x => x.JournalAccessId);
                });

            migrationBuilder.CreateTable(
                name: "Journal_Security",
                columns: table => new
                {
                    JournalSecurityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    JournalId = table.Column<int>(nullable: false),
                    SecurityKey = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Journal_Security", x => x.JournalSecurityId);
                });

            migrationBuilder.CreateTable(
                name: "Journal_TypeFilters",
                columns: table => new
                {
                    JournalTypeFilerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    JournalTypeId = table.Column<int>(nullable: false),
                    ModuleId = table.Column<int>(nullable: false),
                    PortalId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Journal_TypeFilters", x => x.JournalTypeFilerId);
                });

            migrationBuilder.CreateTable(
                name: "Journal_Types",
                columns: table => new
                {
                    JournalTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AppliesToGroup = table.Column<bool>(nullable: false),
                    AppliesToProfile = table.Column<bool>(nullable: false),
                    AppliesToStream = table.Column<bool>(nullable: false),
                    EnableComments = table.Column<bool>(nullable: false),
                    IsEnabled = table.Column<bool>(nullable: false),
                    JournalType = table.Column<string>(nullable: true),
                    Options = table.Column<string>(nullable: true),
                    PortalId = table.Column<int>(nullable: false),
                    SupportsNotify = table.Column<bool>(nullable: false),
                    icon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Journal_Types", x => x.JournalTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    LanguageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    CultureCode = table.Column<string>(nullable: true),
                    CultureName = table.Column<string>(nullable: true),
                    FallbackCulture = table.Column<string>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.LanguageID);
                });

            migrationBuilder.CreateTable(
                name: "Lists",
                columns: table => new
                {
                    EntryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    DefinitionID = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    Level = table.Column<int>(nullable: false),
                    ListName = table.Column<string>(nullable: true),
                    ParentID = table.Column<int>(nullable: false),
                    PortalID = table.Column<int>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    SystemList = table.Column<bool>(nullable: false),
                    Text = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lists", x => x.EntryID);
                });

            migrationBuilder.CreateTable(
                name: "Messaging_Messages",
                columns: table => new
                {
                    MessageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AllowReply = table.Column<bool>(nullable: false),
                    Body = table.Column<string>(nullable: true),
                    Conversation = table.Column<Guid>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    EmailSchedulerInstance = table.Column<Guid>(nullable: true),
                    EmailSent = table.Column<bool>(nullable: false),
                    EmailSentDate = table.Column<DateTime>(nullable: true),
                    FromUserID = table.Column<int>(nullable: false),
                    FromUserName = table.Column<string>(nullable: true),
                    PortalID = table.Column<int>(nullable: false),
                    ReplyTo = table.Column<int>(nullable: true),
                    SkipPortal = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Subject = table.Column<string>(nullable: true),
                    ToRoleID = table.Column<int>(nullable: false),
                    ToUserID = table.Column<int>(nullable: false),
                    ToUserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messaging_Messages", x => x.MessageID);
                });

            migrationBuilder.CreateTable(
                name: "MetaData",
                columns: table => new
                {
                    MetaDataID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MetaDataDescription = table.Column<string>(nullable: true),
                    MetaDataName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetaData", x => x.MetaDataID);
                });

            migrationBuilder.CreateTable(
                name: "OutputCache",
                columns: table => new
                {
                    CacheKey = table.Column<string>(nullable: false),
                    Data = table.Column<string>(nullable: true),
                    Expiration = table.Column<DateTime>(nullable: false),
                    ItemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutputCache", x => x.CacheKey);
                });

            migrationBuilder.CreateTable(
                name: "PackageType",
                columns: table => new
                {
                    PackageType = table.Column<string>(nullable: false),
                    Descrption = table.Column<string>(nullable: true),
                    EditorControlSrc = table.Column<string>(nullable: true),
                    SecurityAccessLevel = table.Column<int>(nullable: false),
                    SupportsSideBySideInstallation = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageType", x => x.PackageType);
                });

            migrationBuilder.CreateTable(
                name: "Permission",
                columns: table => new
                {
                    PermissionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    ModuleDefID = table.Column<int>(nullable: false),
                    PermissionCode = table.Column<string>(nullable: true),
                    PermissionKey = table.Column<string>(nullable: true),
                    PermissionName = table.Column<string>(nullable: true),
                    ViewOrder = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permission", x => x.PermissionID);
                });

            migrationBuilder.CreateTable(
                name: "PersonaBarMenu",
                columns: table => new
                {
                    MenuId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AllowHost = table.Column<bool>(nullable: false),
                    Controller = table.Column<string>(nullable: true),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    CssClass = table.Column<string>(nullable: true),
                    Enabled = table.Column<bool>(nullable: false),
                    FolderName = table.Column<string>(nullable: true),
                    Identifier = table.Column<string>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    Link = table.Column<string>(nullable: true),
                    ModuleName = table.Column<string>(nullable: true),
                    Order = table.Column<int>(nullable: false),
                    ParentID = table.Column<int>(nullable: true),
                    Path = table.Column<string>(nullable: true),
                    ResourceKey = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonaBarMenu", x => x.MenuId);
                    table.ForeignKey(
                        name: "FK_PersonaBarMenu_PersonaBarMenu_ParentID",
                        column: x => x.ParentID,
                        principalTable: "PersonaBarMenu",
                        principalColumn: "MenuId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PortalGroups",
                columns: table => new
                {
                    ProtalGroupID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AuthenticationDomain = table.Column<string>(nullable: true),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    MasterPortalID = table.Column<int>(nullable: true),
                    PortalGroupDescription = table.Column<string>(nullable: true),
                    PortalGroupName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortalGroups", x => x.ProtalGroupID);
                });

            migrationBuilder.CreateTable(
                name: "Portals",
                columns: table => new
                {
                    PortalID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AdministratorID = table.Column<int>(nullable: true),
                    AdministratorRoleId = table.Column<int>(nullable: true),
                    BannerAdvertising = table.Column<int>(nullable: false),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    Currency = table.Column<string>(nullable: true),
                    DefaultLanguage = table.Column<string>(nullable: true),
                    ExpiryDate = table.Column<DateTime>(nullable: true),
                    GUID = table.Column<Guid>(nullable: false),
                    HomeDirectory = table.Column<string>(nullable: true),
                    HostFee = table.Column<decimal>(nullable: false),
                    HostSpace = table.Column<int>(nullable: false),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    PageQuota = table.Column<int>(nullable: false),
                    PaymentProcessor = table.Column<string>(nullable: true),
                    ProcessorPassword = table.Column<string>(nullable: true),
                    ProcessorUserId = table.Column<string>(nullable: true),
                    RegisteredRoleId = table.Column<int>(nullable: true),
                    SiteLogHistory = table.Column<int>(nullable: true),
                    TimezoneOffset = table.Column<int>(nullable: false),
                    UserQuota = table.Column<int>(nullable: false),
                    UserRegistration = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portals", x => x.PortalID);
                });

            migrationBuilder.CreateTable(
                name: "RedirectMessages",
                columns: table => new
                {
                    MessageId = table.Column<Guid>(nullable: false),
                    CreatedOnDate = table.Column<DateTime>(nullable: false),
                    MessageText = table.Column<string>(nullable: true),
                    TabId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RedirectMessages", x => x.MessageId);
                });

            migrationBuilder.CreateTable(
                name: "RelationshipTypes",
                columns: table => new
                {
                    RelationshipTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Direction = table.Column<int>(nullable: false),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelationshipTypes", x => x.RelationshipTypeID);
                });

            migrationBuilder.CreateTable(
                name: "RoleSettings",
                columns: table => new
                {
                    RoleSettingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    RoleID = table.Column<int>(nullable: false),
                    SettingName = table.Column<string>(nullable: true),
                    SettingValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleSettings", x => x.RoleSettingID);
                });

            migrationBuilder.CreateTable(
                name: "Schedule",
                columns: table => new
                {
                    ScheduleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AttachToEvent = table.Column<string>(nullable: true),
                    CatchUpEnabled = table.Column<bool>(nullable: false),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    Enabled = table.Column<bool>(nullable: false),
                    FriendlyName = table.Column<string>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    ObjectDependencies = table.Column<string>(nullable: true),
                    RetainHistoryNumber = table.Column<int>(nullable: false),
                    RetryTimeLapse = table.Column<int>(nullable: false),
                    RetryTimeLapseMeasurement = table.Column<string>(nullable: true),
                    ScheduleStartDate = table.Column<DateTime>(nullable: false),
                    Servers = table.Column<string>(nullable: true),
                    TimeLapse = table.Column<int>(nullable: false),
                    TimeLapseMeasurement = table.Column<string>(nullable: true),
                    TypeFullName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedule", x => x.ScheduleID);
                });

            migrationBuilder.CreateTable(
                name: "SearchCommonWords",
                columns: table => new
                {
                    CommonWordID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CommonWord = table.Column<string>(nullable: true),
                    Locale = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SearchCommonWords", x => x.CommonWordID);
                });

            migrationBuilder.CreateTable(
                name: "SearchDeletedItems",
                columns: table => new
                {
                    SearchDeletedItemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    Document = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SearchDeletedItems", x => x.SearchDeletedItemID);
                });

            migrationBuilder.CreateTable(
                name: "SearchIndexer",
                columns: table => new
                {
                    SearchIndexerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SearchIndexerAssemblyQualifiedName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SearchIndexer", x => x.SearchIndexerID);
                });

            migrationBuilder.CreateTable(
                name: "SearchStopWords",
                columns: table => new
                {
                    StopWordsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    CultureCode = table.Column<string>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    PortalID = table.Column<int>(nullable: true),
                    StopWords = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SearchStopWords", x => x.StopWordsID);
                });

            migrationBuilder.CreateTable(
                name: "SearchTypes",
                columns: table => new
                {
                    SearchTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsPrivate = table.Column<bool>(nullable: true),
                    SearchResultClass = table.Column<string>(nullable: true),
                    SearchTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SearchTypes", x => x.SearchTypeID);
                });

            migrationBuilder.CreateTable(
                name: "SQLQueries",
                columns: table => new
                {
                    QueryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ConnectionStringName = table.Column<string>(nullable: true),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Query = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SQLQueries", x => x.QueryId);
                });

            migrationBuilder.CreateTable(
                name: "SynonymsGroups",
                columns: table => new
                {
                    SynonymsGroupID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    CultureCode = table.Column<string>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    PortalID = table.Column<int>(nullable: false),
                    SynonymsTags = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SynonymsGroups", x => x.SynonymsGroupID);
                });

            migrationBuilder.CreateTable(
                name: "TabAliasSkins",
                columns: table => new
                {
                    TabAliasSkinId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    PortalAliasId = table.Column<int>(nullable: false),
                    SkinSrc = table.Column<string>(nullable: true),
                    TabId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabAliasSkins", x => x.TabAliasSkinId);
                });

            migrationBuilder.CreateTable(
                name: "Taxonomy_ScopeTypes",
                columns: table => new
                {
                    ScopeTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ScopeType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taxonomy_ScopeTypes", x => x.ScopeTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Taxonomy_VocabularyTypes",
                columns: table => new
                {
                    VocabularyTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VocabularyType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taxonomy_VocabularyTypes", x => x.VocabularyTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AffiliateId = table.Column<int>(nullable: true),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    DisplayName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsSuperUser = table.Column<bool>(nullable: false),
                    LastIPAddress = table.Column<string>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    LowerEmail = table.Column<string>(nullable: true),
                    PasswordResetExpiration = table.Column<DateTime>(nullable: true),
                    PasswordResetToken = table.Column<Guid>(nullable: false),
                    UpdatePassword = table.Column<bool>(nullable: false),
                    Username = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Version",
                columns: table => new
                {
                    VersionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Build = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Increment = table.Column<int>(nullable: true),
                    Major = table.Column<int>(nullable: false),
                    Minor = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Version", x => x.VersionID);
                });

            migrationBuilder.CreateTable(
                name: "WebServers",
                columns: table => new
                {
                    ServerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Enabled = table.Column<bool>(nullable: false),
                    IISAppName = table.Column<string>(nullable: true),
                    LastActivityDate = table.Column<DateTime>(nullable: false),
                    PingFailureCount = table.Column<int>(nullable: false),
                    ServerGroup = table.Column<string>(nullable: true),
                    ServerName = table.Column<string>(nullable: true),
                    URL = table.Column<string>(nullable: true),
                    UniqueID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebServers", x => x.ServerID);
                });

            migrationBuilder.CreateTable(
                name: "Workflow",
                columns: table => new
                {
                    WorkflowID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    PortalID = table.Column<int>(nullable: true),
                    WorkflowName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workflow", x => x.WorkflowID);
                });

            migrationBuilder.CreateTable(
                name: "aspnet_Memership",
                columns: table => new
                {
                    UserID = table.Column<Guid>(nullable: false),
                    ApplicationID = table.Column<Guid>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    FailedPasswordAnswerAttemptCount = table.Column<int>(nullable: false),
                    FailedPasswordAnswerAttemptWindow = table.Column<DateTime>(nullable: false),
                    FailedPasswordAttemptCount = table.Column<int>(nullable: false),
                    FailedPasswordWindowStart = table.Column<DateTime>(nullable: false),
                    IsApproved = table.Column<bool>(nullable: false),
                    IsLockedOut = table.Column<bool>(nullable: false),
                    LastLockoutDate = table.Column<DateTime>(nullable: false),
                    LastLoginDate = table.Column<DateTime>(nullable: false),
                    LastPasswordChangedDate = table.Column<DateTime>(nullable: false),
                    LoweredEmail = table.Column<string>(nullable: true),
                    MobilePIN = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    PasswordAnswer = table.Column<string>(nullable: true),
                    PasswordFormat = table.Column<int>(nullable: false),
                    PasswordQuestion = table.Column<string>(nullable: true),
                    PasswordSalt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aspnet_Memership", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_aspnet_Memership_aspnet_Applications_ApplicationID",
                        column: x => x.ApplicationID,
                        principalTable: "aspnet_Applications",
                        principalColumn: "ApplicationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "aspnet_Users",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    ApplicationId = table.Column<Guid>(nullable: false),
                    IsAnonymous = table.Column<bool>(nullable: false),
                    LastActivityDate = table.Column<DateTime>(nullable: false),
                    LoweredUserName = table.Column<string>(nullable: true),
                    MobileAlias = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aspnet_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_aspnet_Users_aspnet_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "aspnet_Applications",
                        principalColumn: "ApplicationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContentWorkflows",
                columns: table => new
                {
                    WorkflowID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Content_TypeContentTypeID = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DispositionEnabled = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsSystem = table.Column<bool>(nullable: false),
                    PortalID = table.Column<int>(nullable: true),
                    StartAfterCreating = table.Column<bool>(nullable: false),
                    StartAfterEditing = table.Column<bool>(nullable: false),
                    WorkflowKey = table.Column<string>(nullable: true),
                    WorkflowName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentWorkflows", x => x.WorkflowID);
                    table.ForeignKey(
                        name: "FK_ContentWorkflows_ContentType_Content_TypeContentTypeID",
                        column: x => x.Content_TypeContentTypeID,
                        principalTable: "ContentType",
                        principalColumn: "ContentTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EventLogConfig",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmailNotificaitonIsAcdtive = table.Column<bool>(nullable: false),
                    KeepMostRecent = table.Column<int>(nullable: false),
                    LogTypeKey1 = table.Column<string>(nullable: true),
                    LogTypePortalID = table.Column<string>(nullable: true),
                    LogTypeKey = table.Column<string>(nullable: true),
                    LoggingIsActive = table.Column<bool>(nullable: false),
                    MailFromAddress = table.Column<string>(nullable: true),
                    MailToAddress = table.Column<string>(nullable: true),
                    NotificationThreshold = table.Column<int>(nullable: true),
                    NotificationThresholdTime = table.Column<int>(nullable: true),
                    NotificationThresholdTimeType = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventLogConfig", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EventLogConfig_EventLogTypes_LogTypeKey1",
                        column: x => x.LogTypeKey1,
                        principalTable: "EventLogTypes",
                        principalColumn: "LogTypeKey",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExportImportCheckpoints",
                columns: table => new
                {
                    CheckpointID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssemblyName = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    Completed = table.Column<bool>(nullable: true),
                    JobID = table.Column<int>(nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(nullable: true),
                    ProcessedItems = table.Column<int>(nullable: false),
                    Progress = table.Column<int>(nullable: false),
                    Stage = table.Column<int>(nullable: false),
                    StageData = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: true),
                    TotalItems = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExportImportCheckpoints", x => x.CheckpointID);
                    table.ForeignKey(
                        name: "FK_ExportImportCheckpoints_ExportImportJobs_JobID",
                        column: x => x.JobID,
                        principalTable: "ExportImportJobs",
                        principalColumn: "JobId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExportImportJobLogs",
                columns: table => new
                {
                    JobLogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOnDate = table.Column<DateTime>(nullable: false),
                    JobId = table.Column<int>(nullable: false),
                    Level = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExportImportJobLogs", x => x.JobLogId);
                    table.ForeignKey(
                        name: "FK_ExportImportJobLogs_ExportImportJobs_JobId",
                        column: x => x.JobId,
                        principalTable: "ExportImportJobs",
                        principalColumn: "JobId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Journal",
                columns: table => new
                {
                    JournalId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccessKey = table.Column<Guid>(nullable: false),
                    CommentsDisabled = table.Column<bool>(nullable: false),
                    CommentsHidden = table.Column<bool>(nullable: false),
                    ContentItemId = table.Column<int>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    GroupId = table.Column<int>(nullable: false),
                    ImageURL = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ItemData = table.Column<string>(nullable: true),
                    JournalTypeId = table.Column<int>(nullable: false),
                    ObjectKey = table.Column<string>(nullable: true),
                    PortalId = table.Column<int>(nullable: true),
                    ProfielId = table.Column<int>(nullable: false),
                    Summary = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Journal", x => x.JournalId);
                    table.ForeignKey(
                        name: "FK_Journal_Journal_Types_JournalTypeId",
                        column: x => x.JournalTypeId,
                        principalTable: "Journal_Types",
                        principalColumn: "JournalTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Packages",
                columns: table => new
                {
                    PackageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    FolderName = table.Column<string>(nullable: true),
                    FriendlyName = table.Column<string>(nullable: true),
                    IconFile = table.Column<string>(nullable: true),
                    IsSystemPackage = table.Column<bool>(nullable: false),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    License = table.Column<string>(nullable: true),
                    Manifest = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Organization = table.Column<string>(nullable: true),
                    Owner = table.Column<string>(nullable: true),
                    PackageType = table.Column<string>(nullable: true),
                    PackageTypeNavigationPackageID = table.Column<int>(nullable: true),
                    PortalID = table.Column<int>(nullable: true),
                    ReleaseNotes = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    Version = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packages", x => x.PackageID);
                    table.ForeignKey(
                        name: "FK_Packages_PackageType_PackageType",
                        column: x => x.PackageType,
                        principalTable: "PackageType",
                        principalColumn: "PackageType",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Packages_Packages_PackageTypeNavigationPackageID",
                        column: x => x.PackageTypeNavigationPackageID,
                        principalTable: "Packages",
                        principalColumn: "PackageID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PersonaBarExtensions",
                columns: table => new
                {
                    ExtensionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Container = table.Column<string>(nullable: true),
                    Controller = table.Column<string>(nullable: true),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    Enabled = table.Column<bool>(nullable: false),
                    FolderName = table.Column<string>(nullable: true),
                    Identifier = table.Column<string>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    MenuId = table.Column<int>(nullable: false),
                    Order = table.Column<int>(nullable: false),
                    Path = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonaBarExtensions", x => x.ExtensionID);
                    table.ForeignKey(
                        name: "FK_PersonaBarExtensions_PersonaBarMenu_MenuId",
                        column: x => x.MenuId,
                        principalTable: "PersonaBarMenu",
                        principalColumn: "MenuId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonaBarMenuDefaultPermissions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MenuId = table.Column<int>(nullable: false),
                    RoleNames = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonaBarMenuDefaultPermissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonaBarMenuDefaultPermissions_PersonaBarMenu_MenuId",
                        column: x => x.MenuId,
                        principalTable: "PersonaBarMenu",
                        principalColumn: "MenuId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonaBarPermission",
                columns: table => new
                {
                    PermissionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    MenuId = table.Column<int>(nullable: true),
                    PermissionKey = table.Column<string>(nullable: true),
                    PermissionName = table.Column<string>(nullable: true),
                    ViewOrder = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonaBarPermission", x => x.PermissionId);
                    table.ForeignKey(
                        name: "FK_PersonaBarPermission_PersonaBarMenu_MenuId",
                        column: x => x.MenuId,
                        principalTable: "PersonaBarMenu",
                        principalColumn: "MenuId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AnonymousUsers",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false),
                    PortalID = table.Column<int>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastActiveDate = table.Column<DateTime>(nullable: false),
                    TabId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnonymousUsers", x => new { x.UserID, x.PortalID });
                    table.UniqueConstraint("AK_AnonymousUsers_PortalID_UserID", x => new { x.PortalID, x.UserID });
                    table.ForeignKey(
                        name: "FK_AnonymousUsers_Portals_PortalID",
                        column: x => x.PortalID,
                        principalTable: "Portals",
                        principalColumn: "PortalID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FolderMappings",
                columns: table => new
                {
                    FolderMappingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    FolderProviderType = table.Column<string>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    MappingName = table.Column<string>(nullable: true),
                    PortalID = table.Column<int>(nullable: true),
                    Priority = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FolderMappings", x => x.FolderMappingID);
                    table.ForeignKey(
                        name: "FK_FolderMappings_Portals_PortalID",
                        column: x => x.PortalID,
                        principalTable: "Portals",
                        principalColumn: "PortalID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mobile_PreviewProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    Height = table.Column<int>(nullable: false),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PortalId = table.Column<int>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    UserAgent = table.Column<string>(nullable: true),
                    Width = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mobile_PreviewProfiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mobile_PreviewProfiles_Portals_PortalId",
                        column: x => x.PortalId,
                        principalTable: "Portals",
                        principalColumn: "PortalID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mobile_Redirections",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    Enabled = table.Column<bool>(nullable: false),
                    IncludeChildTabs = table.Column<bool>(nullable: false),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PortalId = table.Column<int>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    SourceTabId = table.Column<int>(nullable: false),
                    TargetType = table.Column<int>(nullable: false),
                    TargetValue = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mobile_Redirections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mobile_Redirections_Portals_PortalId",
                        column: x => x.PortalId,
                        principalTable: "Portals",
                        principalColumn: "PortalID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PortalAlias",
                columns: table => new
                {
                    PortalAliasID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BrowserType = table.Column<string>(nullable: true),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    CulturCode = table.Column<string>(nullable: true),
                    HTTPAlias = table.Column<string>(nullable: true),
                    IsPrimary = table.Column<bool>(nullable: false),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    PortalID = table.Column<int>(nullable: false),
                    Skin = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortalAlias", x => x.PortalAliasID);
                    table.ForeignKey(
                        name: "FK_PortalAlias_Portals_PortalID",
                        column: x => x.PortalID,
                        principalTable: "Portals",
                        principalColumn: "PortalID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PortalLanguages",
                columns: table => new
                {
                    PortalLanguageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    IsPublished = table.Column<bool>(nullable: false),
                    LanguageID = table.Column<int>(nullable: false),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    PortalID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortalLanguages", x => x.PortalLanguageID);
                    table.ForeignKey(
                        name: "FK_PortalLanguages_Languages_LanguageID",
                        column: x => x.LanguageID,
                        principalTable: "Languages",
                        principalColumn: "LanguageID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PortalLanguages_Portals_PortalID",
                        column: x => x.PortalID,
                        principalTable: "Portals",
                        principalColumn: "PortalID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PortalLocalization",
                columns: table => new
                {
                    PortalID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AdminTabId = table.Column<int>(nullable: true),
                    BackgroundFile = table.Column<string>(nullable: true),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    CultureCode = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    FooterText = table.Column<string>(nullable: true),
                    HomeTabId = table.Column<int>(nullable: true),
                    KeyWords = table.Column<string>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    LoginTabId = table.Column<int>(nullable: true),
                    LogoFile = table.Column<string>(nullable: true),
                    PortalID1 = table.Column<int>(nullable: true),
                    PortalName = table.Column<string>(nullable: true),
                    SplashTabId = table.Column<int>(nullable: true),
                    UserTabId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortalLocalization", x => x.PortalID);
                    table.ForeignKey(
                        name: "FK_PortalLocalization_Portals_PortalID1",
                        column: x => x.PortalID1,
                        principalTable: "Portals",
                        principalColumn: "PortalID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PortalSettings",
                columns: table => new
                {
                    PortalSettingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    CultureCode = table.Column<string>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    PortalID = table.Column<int>(nullable: false),
                    SettingName = table.Column<string>(nullable: true),
                    SettingValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortalSettings", x => x.PortalSettingID);
                    table.ForeignKey(
                        name: "FK_PortalSettings_Portals_PortalID",
                        column: x => x.PortalID,
                        principalTable: "Portals",
                        principalColumn: "PortalID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfilePropertyDefinition",
                columns: table => new
                {
                    PropertyDefinitionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    DataType = table.Column<int>(nullable: false),
                    DefaultValue = table.Column<string>(nullable: true),
                    DefaultVisibility = table.Column<int>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    Length = table.Column<int>(nullable: false),
                    ModuleDefId = table.Column<int>(nullable: true),
                    PortalID = table.Column<int>(nullable: true),
                    PropertyCategory = table.Column<string>(nullable: true),
                    PropertyName = table.Column<string>(nullable: true),
                    ReadOnly = table.Column<bool>(nullable: false),
                    Required = table.Column<bool>(nullable: false),
                    ValidationExpression = table.Column<string>(nullable: true),
                    ViewOrder = table.Column<int>(nullable: false),
                    Visible = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfilePropertyDefinition", x => x.PropertyDefinitionID);
                    table.ForeignKey(
                        name: "FK_ProfilePropertyDefinition_Portals_PortalID",
                        column: x => x.PortalID,
                        principalTable: "Portals",
                        principalColumn: "PortalID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoleGroups",
                columns: table => new
                {
                    RoleGroupID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    PortalID = table.Column<int>(nullable: false),
                    RoleGroupName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleGroups", x => x.RoleGroupID);
                    table.ForeignKey(
                        name: "FK_RoleGroups_Portals_PortalID",
                        column: x => x.PortalID,
                        principalTable: "Portals",
                        principalColumn: "PortalID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SiteLog",
                columns: table => new
                {
                    SiteLogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AffiliateId = table.Column<int>(nullable: true),
                    DateTime = table.Column<DateTime>(nullable: false),
                    PortalID = table.Column<int>(nullable: false),
                    Referrer = table.Column<string>(nullable: true),
                    TabId = table.Column<int>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    UserAgent = table.Column<string>(nullable: true),
                    UserHostAddress = table.Column<string>(nullable: true),
                    UserHostName = table.Column<string>(nullable: true),
                    UserID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteLog", x => x.SiteLogId);
                    table.ForeignKey(
                        name: "FK_SiteLog_Portals_PortalID",
                        column: x => x.PortalID,
                        principalTable: "Portals",
                        principalColumn: "PortalID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SystemMessages",
                columns: table => new
                {
                    MessageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MessageName = table.Column<string>(nullable: true),
                    MessageValue = table.Column<string>(nullable: true),
                    PortalID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemMessages", x => x.MessageID);
                    table.ForeignKey(
                        name: "FK_SystemMessages_Portals_PortalID",
                        column: x => x.PortalID,
                        principalTable: "Portals",
                        principalColumn: "PortalID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Urls",
                columns: table => new
                {
                    UrlID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PortalID = table.Column<int>(nullable: true),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urls", x => x.UrlID);
                    table.ForeignKey(
                        name: "FK_Urls_Portals_PortalID",
                        column: x => x.PortalID,
                        principalTable: "Portals",
                        principalColumn: "PortalID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UrlTracking",
                columns: table => new
                {
                    UrlTrackingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Clicks = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastClick = table.Column<DateTime>(nullable: true),
                    LogActivity = table.Column<bool>(nullable: false),
                    ModuleID = table.Column<int>(nullable: true),
                    NewWindow = table.Column<bool>(nullable: false),
                    PortalID = table.Column<int>(nullable: true),
                    TrackClicks = table.Column<bool>(nullable: false),
                    Url = table.Column<string>(nullable: true),
                    UrlType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrlTracking", x => x.UrlTrackingID);
                    table.ForeignKey(
                        name: "FK_UrlTracking_Portals_PortalID",
                        column: x => x.PortalID,
                        principalTable: "Portals",
                        principalColumn: "PortalID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleHistory",
                columns: table => new
                {
                    ScheduleHistoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EndDate = table.Column<DateTime>(nullable: false),
                    LogNotes = table.Column<string>(nullable: true),
                    NextStart = table.Column<DateTime>(nullable: true),
                    ScheduleID = table.Column<int>(nullable: false),
                    Server = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    Succeeded = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleHistory", x => x.ScheduleHistoryID);
                    table.ForeignKey(
                        name: "FK_ScheduleHistory_Schedule_ScheduleID",
                        column: x => x.ScheduleID,
                        principalTable: "Schedule",
                        principalColumn: "ScheduleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleItemSettings",
                columns: table => new
                {
                    ScheduleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ScheduleID1 = table.Column<int>(nullable: true),
                    SettingName = table.Column<string>(nullable: true),
                    SettingValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleItemSettings", x => x.ScheduleID);
                    table.ForeignKey(
                        name: "FK_ScheduleItemSettings_Schedule_ScheduleID1",
                        column: x => x.ScheduleID1,
                        principalTable: "Schedule",
                        principalColumn: "ScheduleID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Taxonomy_Vocabularies",
                columns: table => new
                {
                    VocabularyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ScopeID = table.Column<int>(nullable: true),
                    ScopeTypeID = table.Column<int>(nullable: false),
                    VocabularyTypeID = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taxonomy_Vocabularies", x => x.VocabularyID);
                    table.ForeignKey(
                        name: "FK_Taxonomy_Vocabularies_Taxonomy_ScopeTypes_ScopeTypeID",
                        column: x => x.ScopeTypeID,
                        principalTable: "Taxonomy_ScopeTypes",
                        principalColumn: "ScopeTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Taxonomy_Vocabularies_Taxonomy_VocabularyTypes_VocabularyTypeID",
                        column: x => x.VocabularyTypeID,
                        principalTable: "Taxonomy_VocabularyTypes",
                        principalColumn: "VocabularyTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PasswordHistory",
                columns: table => new
                {
                    PasswordHistoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    PasswordSalt = table.Column<string>(nullable: true),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PasswordHistory", x => x.PasswordHistoryID);
                    table.ForeignKey(
                        name: "FK_PasswordHistory_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Profile",
                columns: table => new
                {
                    ProfileId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    PortalId = table.Column<int>(nullable: false),
                    ProfileData = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profile", x => x.ProfileId);
                    table.ForeignKey(
                        name: "FK_Profile_Portals_PortalId",
                        column: x => x.PortalId,
                        principalTable: "Portals",
                        principalColumn: "PortalID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Profile_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Relationships",
                columns: table => new
                {
                    RelationshipId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    DefaultResponse = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PortalID = table.Column<int>(nullable: true),
                    RelationshipTypeID = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relationships", x => x.RelationshipId);
                    table.ForeignKey(
                        name: "FK_Relationships_Portals_PortalID",
                        column: x => x.PortalID,
                        principalTable: "Portals",
                        principalColumn: "PortalID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Relationships_RelationshipTypes_RelationshipTypeID",
                        column: x => x.RelationshipTypeID,
                        principalTable: "RelationshipTypes",
                        principalColumn: "RelationshipTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Relationships_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserAuthentication",
                columns: table => new
                {
                    UserAuthenticationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AuthenticaitonToken = table.Column<string>(nullable: true),
                    AuthenticationType = table.Column<string>(nullable: true),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAuthentication", x => x.UserAuthenticationID);
                    table.ForeignKey(
                        name: "FK_UserAuthentication_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserPortals",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Authorized = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    PortalId = table.Column<int>(nullable: false),
                    RefreshRoles = table.Column<bool>(nullable: false),
                    UserPortalId = table.Column<int>(nullable: false),
                    VanityUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPortals", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_UserPortals_Portals_PortalId",
                        column: x => x.PortalId,
                        principalTable: "Portals",
                        principalColumn: "PortalID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPortals_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UsersOnline",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastActiveDate = table.Column<DateTime>(nullable: false),
                    PortalID = table.Column<int>(nullable: false),
                    TabID = table.Column<int>(nullable: false),
                    UserID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersOnline", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_UsersOnline_Portals_PortalID",
                        column: x => x.PortalID,
                        principalTable: "Portals",
                        principalColumn: "PortalID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsersOnline_Users_UserID1",
                        column: x => x.UserID1,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WorkflowStates",
                columns: table => new
                {
                    StateID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsActive = table.Column<bool>(nullable: false),
                    Notify = table.Column<bool>(nullable: false),
                    Order = table.Column<bool>(nullable: false),
                    StateName = table.Column<string>(nullable: true),
                    WorkflowID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkflowStates", x => x.StateID);
                    table.ForeignKey(
                        name: "FK_WorkflowStates_Workflow_WorkflowID",
                        column: x => x.WorkflowID,
                        principalTable: "Workflow",
                        principalColumn: "WorkflowID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContentWorkflowSources",
                columns: table => new
                {
                    SourceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SourceName = table.Column<string>(nullable: true),
                    SourceType = table.Column<string>(nullable: true),
                    WorkflowID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentWorkflowSources", x => x.SourceID);
                    table.ForeignKey(
                        name: "FK_ContentWorkflowSources_ContentWorkflows_WorkflowID",
                        column: x => x.WorkflowID,
                        principalTable: "ContentWorkflows",
                        principalColumn: "WorkflowID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContentWorkflowStates",
                columns: table => new
                {
                    StateID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDisposalState = table.Column<bool>(nullable: false),
                    IsSystem = table.Column<bool>(nullable: false),
                    OnCompleteMessageBody = table.Column<string>(nullable: true),
                    OnCompleteMessageSubject = table.Column<string>(nullable: true),
                    OnDiscardMessageSubject = table.Column<string>(nullable: true),
                    Order = table.Column<int>(nullable: false),
                    SendEmail = table.Column<bool>(nullable: false),
                    SendMessage = table.Column<bool>(nullable: false),
                    SendNotification = table.Column<bool>(nullable: false),
                    SendNotificationToAdministrators = table.Column<bool>(nullable: false),
                    StateName = table.Column<string>(nullable: true),
                    WorkflowID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentWorkflowStates", x => x.StateID);
                    table.ForeignKey(
                        name: "FK_ContentWorkflowStates_ContentWorkflows_WorkflowID",
                        column: x => x.WorkflowID,
                        principalTable: "ContentWorkflows",
                        principalColumn: "WorkflowID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventLog",
                columns: table => new
                {
                    LogEventID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EventLogConfigID = table.Column<int>(nullable: true),
                    ExceptionHash = table.Column<string>(nullable: true),
                    LogConfigID = table.Column<int>(nullable: false),
                    LogConfigLogEventID = table.Column<long>(nullable: true),
                    LogCreateDate = table.Column<DateTime>(nullable: false),
                    LogGuid = table.Column<string>(nullable: true),
                    LogNotificationPending = table.Column<bool>(nullable: true),
                    LogPortalID = table.Column<int>(nullable: true),
                    LogPortalName = table.Column<string>(nullable: true),
                    LogProperties = table.Column<string>(type: "xml", nullable: true),
                    LogServerName = table.Column<string>(nullable: true),
                    LogTypeKey1 = table.Column<string>(nullable: true),
                    LogTypeKey = table.Column<string>(nullable: true),
                    LogUserID = table.Column<int>(nullable: true),
                    LogUserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventLog", x => x.LogEventID);
                    table.ForeignKey(
                        name: "FK_EventLog_EventLogConfig_EventLogConfigID",
                        column: x => x.EventLogConfigID,
                        principalTable: "EventLogConfig",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EventLog_EventLog_LogConfigLogEventID",
                        column: x => x.LogConfigLogEventID,
                        principalTable: "EventLog",
                        principalColumn: "LogEventID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EventLog_EventLogTypes_LogTypeKey1",
                        column: x => x.LogTypeKey1,
                        principalTable: "EventLogTypes",
                        principalColumn: "LogTypeKey",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Journal_Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Comment = table.Column<string>(nullable: true),
                    CommentXML = table.Column<string>(type: "xml", nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    JournalId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Journal_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Journal_Comments_Journal_JournalId",
                        column: x => x.JournalId,
                        principalTable: "Journal",
                        principalColumn: "JournalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Journal_Data",
                columns: table => new
                {
                    JournalDataId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    JournalId = table.Column<int>(nullable: false),
                    JournalXML = table.Column<string>(type: "xml", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Journal_Data", x => x.JournalDataId);
                    table.ForeignKey(
                        name: "FK_Journal_Data_Journal_JournalId",
                        column: x => x.JournalId,
                        principalTable: "Journal",
                        principalColumn: "JournalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Assemblies",
                columns: table => new
                {
                    AssemblyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssemblyName = table.Column<string>(nullable: true),
                    PackageID = table.Column<int>(nullable: true),
                    Version = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assemblies", x => x.AssemblyID);
                    table.ForeignKey(
                        name: "FK_Assemblies_Packages_PackageID",
                        column: x => x.PackageID,
                        principalTable: "Packages",
                        principalColumn: "PackageID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Authentication",
                columns: table => new
                {
                    AuthenticationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AuthenticationType = table.Column<string>(nullable: true),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    IsEnabled = table.Column<bool>(nullable: false),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    LoginControlSrc = table.Column<string>(nullable: true),
                    LogoffControlSrc = table.Column<string>(nullable: true),
                    PackageID = table.Column<int>(nullable: false),
                    SettignsControlSrc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authentication", x => x.AuthenticationID);
                    table.ForeignKey(
                        name: "FK_Authentication_Packages_PackageID",
                        column: x => x.PackageID,
                        principalTable: "Packages",
                        principalColumn: "PackageID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DesktopModules",
                columns: table => new
                {
                    DesktopModuleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AdminPage = table.Column<string>(nullable: true),
                    BusinessControllerClass = table.Column<string>(nullable: true),
                    CompatibleVersions = table.Column<string>(nullable: true),
                    ContentItemID = table.Column<int>(nullable: false),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    Dependencies = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    FolderName = table.Column<string>(nullable: true),
                    FriendlyName = table.Column<string>(nullable: true),
                    HostPage = table.Column<string>(nullable: true),
                    IsAdmin = table.Column<bool>(nullable: false),
                    IsPremium = table.Column<bool>(nullable: false),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    ModuleName = table.Column<string>(nullable: true),
                    PackageID = table.Column<int>(nullable: false),
                    Permissions = table.Column<string>(nullable: true),
                    Shareable = table.Column<int>(nullable: false),
                    SupportedFeatures = table.Column<bool>(nullable: false),
                    Version = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesktopModules", x => x.DesktopModuleID);
                    table.ForeignKey(
                        name: "FK_DesktopModules_Packages_PackageID",
                        column: x => x.PackageID,
                        principalTable: "Packages",
                        principalColumn: "PackageID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JavascriptLibraries",
                columns: table => new
                {
                    JavaScriptLibraryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CDNPath = table.Column<string>(nullable: true),
                    FileName = table.Column<string>(nullable: true),
                    LibraryName = table.Column<string>(nullable: true),
                    ObjectName = table.Column<string>(nullable: true),
                    PackageID = table.Column<int>(nullable: false),
                    PreferredScriptLocation = table.Column<int>(nullable: false),
                    Version = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JavascriptLibraries", x => x.JavaScriptLibraryID);
                    table.ForeignKey(
                        name: "FK_JavascriptLibraries_Packages_PackageID",
                        column: x => x.PackageID,
                        principalTable: "Packages",
                        principalColumn: "PackageID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LanguagePacks",
                columns: table => new
                {
                    LanguagePackID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    DependentPackageID = table.Column<int>(nullable: false),
                    LanguageID = table.Column<int>(nullable: false),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    PackageID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguagePacks", x => x.LanguagePackID);
                    table.ForeignKey(
                        name: "FK_LanguagePacks_Packages_PackageID",
                        column: x => x.PackageID,
                        principalTable: "Packages",
                        principalColumn: "PackageID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PackageDependencies",
                columns: table => new
                {
                    PackageDependencyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PackageID = table.Column<int>(nullable: false),
                    PackageName = table.Column<string>(nullable: true),
                    Version = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageDependencies", x => x.PackageDependencyID);
                    table.ForeignKey(
                        name: "FK_PackageDependencies_Packages_PackageID",
                        column: x => x.PackageID,
                        principalTable: "Packages",
                        principalColumn: "PackageID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SkinControls",
                columns: table => new
                {
                    SkinControlID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ControlKey = table.Column<string>(nullable: true),
                    ControlSrc = table.Column<string>(nullable: true),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    HelpURL = table.Column<string>(nullable: true),
                    IconFile = table.Column<string>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    PackageID = table.Column<int>(nullable: false),
                    SupportsPartialRendering = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkinControls", x => x.SkinControlID);
                    table.ForeignKey(
                        name: "FK_SkinControls_Packages_PackageID",
                        column: x => x.PackageID,
                        principalTable: "Packages",
                        principalColumn: "PackageID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "vSkinPackages",
                columns: table => new
                {
                    SkinPackageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    PackageID = table.Column<int>(nullable: false),
                    PortalID = table.Column<int>(nullable: true),
                    SkinName = table.Column<string>(nullable: true),
                    SkinType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vSkinPackages", x => x.SkinPackageID);
                    table.ForeignKey(
                        name: "FK_vSkinPackages_Packages_PackageID",
                        column: x => x.PackageID,
                        principalTable: "Packages",
                        principalColumn: "PackageID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FolderMappingsSettings",
                columns: table => new
                {
                    FolderMappingID = table.Column<int>(nullable: false),
                    SettingName = table.Column<string>(nullable: false),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    SettingValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FolderMappingsSettings", x => new { x.FolderMappingID, x.SettingName });
                    table.ForeignKey(
                        name: "FK_FolderMappingsSettings_FolderMappings_FolderMappingID",
                        column: x => x.FolderMappingID,
                        principalTable: "FolderMappings",
                        principalColumn: "FolderMappingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mobile_RedirectionRules",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Capability = table.Column<string>(nullable: true),
                    Expression = table.Column<string>(nullable: true),
                    Mobile_RedirectionId = table.Column<int>(nullable: true),
                    RedirectionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mobile_RedirectionRules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mobile_RedirectionRules_Mobile_Redirections_Mobile_RedirectionId",
                        column: x => x.Mobile_RedirectionId,
                        principalTable: "Mobile_Redirections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Mobile_RedirectionRules_Mobile_RedirectionRules_RedirectionId",
                        column: x => x.RedirectionId,
                        principalTable: "Mobile_RedirectionRules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "UserProfile",
                columns: table => new
                {
                    ProfileID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ExtendedVisibility = table.Column<string>(nullable: true),
                    LastUpdatedDate = table.Column<DateTime>(nullable: false),
                    ProfilePropertyDefinitionID = table.Column<int>(nullable: false),
                    PropertyText = table.Column<string>(nullable: true),
                    PropertyValue = table.Column<string>(nullable: true),
                    UserID = table.Column<int>(nullable: false),
                    Visibility = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfile", x => x.ProfileID);
                    table.ForeignKey(
                        name: "FK_UserProfile_ProfilePropertyDefinition_ProfilePropertyDefinitionID",
                        column: x => x.ProfilePropertyDefinitionID,
                        principalTable: "ProfilePropertyDefinition",
                        principalColumn: "PropertyDefinitionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserProfile_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AutoAssignment = table.Column<bool>(nullable: false),
                    BillingFrequency = table.Column<string>(nullable: true),
                    BillingPeriod = table.Column<int>(nullable: true),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IconFile = table.Column<string>(nullable: true),
                    IsPublic = table.Column<bool>(nullable: false),
                    IsSystemRole = table.Column<bool>(nullable: false),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    PortalID = table.Column<int>(nullable: true),
                    RSVPCode = table.Column<string>(nullable: true),
                    RoleGroupID = table.Column<int>(nullable: true),
                    RoleName = table.Column<string>(nullable: true),
                    SecurityMode = table.Column<int>(nullable: false),
                    ServiceFee = table.Column<decimal>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    TrialFee = table.Column<decimal>(nullable: true),
                    TrialFrequency = table.Column<string>(nullable: true),
                    TrialPeriod = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleID);
                    table.ForeignKey(
                        name: "FK_Role_Portals_PortalID",
                        column: x => x.PortalID,
                        principalTable: "Portals",
                        principalColumn: "PortalID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Role_RoleGroups_RoleGroupID",
                        column: x => x.RoleGroupID,
                        principalTable: "RoleGroups",
                        principalColumn: "RoleGroupID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UrlLog",
                columns: table => new
                {
                    UrlLogID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClickDate = table.Column<DateTime>(nullable: false),
                    UrlTrackingID = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrlLog", x => x.UrlLogID);
                    table.ForeignKey(
                        name: "FK_UrlLog_UrlTracking_UrlTrackingID",
                        column: x => x.UrlTrackingID,
                        principalTable: "UrlTracking",
                        principalColumn: "UrlTrackingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Taxonomy_Terms",
                columns: table => new
                {
                    TermID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ParentTermID = table.Column<int>(nullable: false),
                    TermLeft = table.Column<int>(nullable: false),
                    TermRight = table.Column<int>(nullable: false),
                    VocabularyID = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taxonomy_Terms", x => x.TermID);
                    table.ForeignKey(
                        name: "FK_Taxonomy_Terms_Taxonomy_Terms_ParentTermID",
                        column: x => x.ParentTermID,
                        principalTable: "Taxonomy_Terms",
                        principalColumn: "TermID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Taxonomy_Terms_Taxonomy_Vocabularies_VocabularyID",
                        column: x => x.VocabularyID,
                        principalTable: "Taxonomy_Vocabularies",
                        principalColumn: "VocabularyID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "UserRelationshipPreferences",
                columns: table => new
                {
                    PreferenceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    DefaultResponse = table.Column<int>(nullable: false),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    RealtionshipID = table.Column<int>(nullable: false),
                    RelationshipId = table.Column<int>(nullable: true),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRelationshipPreferences", x => x.PreferenceID);
                    table.ForeignKey(
                        name: "FK_UserRelationshipPreferences_Relationships_RelationshipId",
                        column: x => x.RelationshipId,
                        principalTable: "Relationships",
                        principalColumn: "RelationshipId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserRelationshipPreferences_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRelationships",
                columns: table => new
                {
                    UserRelationshipID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    RelatedUserID = table.Column<int>(nullable: false),
                    RelationshipID = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRelationships", x => x.UserRelationshipID);
                    table.ForeignKey(
                        name: "FK_UserRelationships_Users_RelatedUserID",
                        column: x => x.RelatedUserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRelationships_Relationships_RelationshipID",
                        column: x => x.RelationshipID,
                        principalTable: "Relationships",
                        principalColumn: "RelationshipId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRelationships_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ContentItems",
                columns: table => new
                {
                    ContentItemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Content = table.Column<string>(nullable: true),
                    ContentKey = table.Column<string>(nullable: true),
                    ContentTypeID = table.Column<int>(nullable: false),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    Indexed = table.Column<bool>(nullable: false),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    ModuleID = table.Column<int>(nullable: false),
                    StateID = table.Column<int>(nullable: true),
                    TabID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentItems", x => x.ContentItemID);
                    table.ForeignKey(
                        name: "FK_ContentItems_ContentType_ContentTypeID",
                        column: x => x.ContentTypeID,
                        principalTable: "ContentType",
                        principalColumn: "ContentTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContentItems_ContentWorkflowStates_StateID",
                        column: x => x.StateID,
                        principalTable: "ContentWorkflowStates",
                        principalColumn: "StateID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContentWorkflowStatePermission",
                columns: table => new
                {
                    WorkflowStatePermissionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AllowAccess = table.Column<bool>(nullable: false),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    PermissionID = table.Column<int>(nullable: false),
                    RoleID = table.Column<int>(nullable: true),
                    StateId = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentWorkflowStatePermission", x => x.WorkflowStatePermissionID);
                    table.ForeignKey(
                        name: "FK_ContentWorkflowStatePermission_Permission_PermissionID",
                        column: x => x.PermissionID,
                        principalTable: "Permission",
                        principalColumn: "PermissionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContentWorkflowStatePermission_ContentWorkflowStates_StateId",
                        column: x => x.StateId,
                        principalTable: "ContentWorkflowStates",
                        principalColumn: "StateID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContentWorkflowStatePermission_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExceptionEvents",
                columns: table => new
                {
                    LogEventID = table.Column<long>(nullable: false),
                    AssemblyVersion = table.Column<string>(nullable: true),
                    PortalID = table.Column<int>(nullable: true),
                    RawURL = table.Column<string>(nullable: true),
                    Referrer = table.Column<string>(nullable: true),
                    TabID = table.Column<int>(nullable: true),
                    UserAgent = table.Column<string>(nullable: true),
                    UserID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExceptionEvents", x => x.LogEventID);
                    table.ForeignKey(
                        name: "FK_ExceptionEvents_EventLog_LogEventID",
                        column: x => x.LogEventID,
                        principalTable: "EventLog",
                        principalColumn: "LogEventID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CoreMessaging_NotificationTypes",
                columns: table => new
                {
                    NotificationTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DesktopModuleID = table.Column<int>(nullable: true),
                    IsTask = table.Column<bool>(nullable: false),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    TTL = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoreMessaging_NotificationTypes", x => x.NotificationTypeID);
                    table.ForeignKey(
                        name: "FK_CoreMessaging_NotificationTypes_DesktopModules_DesktopModuleID",
                        column: x => x.DesktopModuleID,
                        principalTable: "DesktopModules",
                        principalColumn: "DesktopModuleID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ModuleDefinitions",
                columns: table => new
                {
                    ModuleDefID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    DefaultCacheTime = table.Column<int>(nullable: false),
                    DefinitionName = table.Column<string>(nullable: true),
                    DesktopModuleID = table.Column<int>(nullable: false),
                    FriendlyName = table.Column<string>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleDefinitions", x => x.ModuleDefID);
                    table.ForeignKey(
                        name: "FK_ModuleDefinitions_DesktopModules_DesktopModuleID",
                        column: x => x.DesktopModuleID,
                        principalTable: "DesktopModules",
                        principalColumn: "DesktopModuleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PortalDesktopModules",
                columns: table => new
                {
                    PortalDesktopModuleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    DesktopModuleID = table.Column<int>(nullable: false),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    PortalID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortalDesktopModules", x => x.PortalDesktopModuleID);
                    table.ForeignKey(
                        name: "FK_PortalDesktopModules_DesktopModules_DesktopModuleID",
                        column: x => x.DesktopModuleID,
                        principalTable: "DesktopModules",
                        principalColumn: "DesktopModuleID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PortalDesktopModules_Portals_PortalID",
                        column: x => x.PortalID,
                        principalTable: "Portals",
                        principalColumn: "PortalID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Skins",
                columns: table => new
                {
                    SkinID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SkinPackageID = table.Column<int>(nullable: false),
                    SkinSrc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skins", x => x.SkinID);
                    table.ForeignKey(
                        name: "FK_Skins_vSkinPackages_SkinPackageID",
                        column: x => x.SkinPackageID,
                        principalTable: "vSkinPackages",
                        principalColumn: "SkinPackageID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonaBarMenuPermission",
                columns: table => new
                {
                    MenuPermissionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AllowAccess = table.Column<bool>(nullable: false),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    MenuId = table.Column<int>(nullable: false),
                    PermissionId = table.Column<int>(nullable: false),
                    PortalId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonaBarMenuPermission", x => x.MenuPermissionID);
                    table.ForeignKey(
                        name: "FK_PersonaBarMenuPermission_PersonaBarMenu_MenuId",
                        column: x => x.MenuId,
                        principalTable: "PersonaBarMenu",
                        principalColumn: "MenuId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonaBarMenuPermission_PersonaBarPermission_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "PersonaBarPermission",
                        principalColumn: "PermissionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonaBarMenuPermission_Portals_PortalId",
                        column: x => x.PortalId,
                        principalTable: "Portals",
                        principalColumn: "PortalID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonaBarMenuPermission_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonaBarMenuPermission_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserRoleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    EffectiveDate = table.Column<DateTime>(nullable: true),
                    ExpiryDate = table.Column<DateTime>(nullable: true),
                    IsOwner = table.Column<bool>(nullable: false),
                    IsTrialUsed = table.Column<bool>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    RoleID = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.UserRoleID);
                    table.ForeignKey(
                        name: "FK_UserRoles_Role_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Role",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContentItems_MetaData",
                columns: table => new
                {
                    ContetnItemMetaDataID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContentItemID = table.Column<int>(nullable: false),
                    MetaDataID = table.Column<int>(nullable: false),
                    MetaDataValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentItems_MetaData", x => x.ContetnItemMetaDataID);
                    table.ForeignKey(
                        name: "FK_ContentItems_MetaData_ContentItems_ContentItemID",
                        column: x => x.ContentItemID,
                        principalTable: "ContentItems",
                        principalColumn: "ContentItemID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContentItems_MetaData_MetaData_MetaDataID",
                        column: x => x.MetaDataID,
                        principalTable: "MetaData",
                        principalColumn: "MetaDataID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContentItems_Tags",
                columns: table => new
                {
                    ContentItemTagID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContentItemID = table.Column<int>(nullable: false),
                    ContentItemTagID1 = table.Column<int>(nullable: true),
                    TermID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentItems_Tags", x => x.ContentItemTagID);
                    table.ForeignKey(
                        name: "FK_ContentItems_Tags_ContentItems_ContentItemID",
                        column: x => x.ContentItemID,
                        principalTable: "ContentItems",
                        principalColumn: "ContentItemID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContentItems_Tags_ContentItems_Tags_ContentItemTagID1",
                        column: x => x.ContentItemTagID1,
                        principalTable: "ContentItems_Tags",
                        principalColumn: "ContentItemTagID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContentItems_Tags_Taxonomy_Terms_TermID",
                        column: x => x.TermID,
                        principalTable: "Taxonomy_Terms",
                        principalColumn: "TermID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContentWorkflowLogs",
                columns: table => new
                {
                    WorkflowLogID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Action = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    ContentItemID = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    User = table.Column<int>(nullable: true),
                    WorkflowID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentWorkflowLogs", x => x.WorkflowLogID);
                    table.ForeignKey(
                        name: "FK_ContentWorkflowLogs_ContentItems_ContentItemID",
                        column: x => x.ContentItemID,
                        principalTable: "ContentItems",
                        principalColumn: "ContentItemID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContentWorkflowLogs_ContentWorkflows_WorkflowID",
                        column: x => x.WorkflowID,
                        principalTable: "ContentWorkflows",
                        principalColumn: "WorkflowID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tabs",
                columns: table => new
                {
                    TabID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContainerSrc = table.Column<string>(nullable: true),
                    ContentItemID = table.Column<int>(nullable: true),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    CultureCode = table.Column<string>(nullable: true),
                    DefaultLanguageGUID = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    DisableLink = table.Column<bool>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: true),
                    HasBeenPublished = table.Column<bool>(nullable: false),
                    IconFile = table.Column<string>(nullable: true),
                    IconFileLarge = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsSecure = table.Column<bool>(nullable: false),
                    IsSystem = table.Column<bool>(nullable: false),
                    IsVisible = table.Column<bool>(nullable: false),
                    Keywords = table.Column<string>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    Level = table.Column<int>(nullable: false),
                    LocalizedVersionGUID = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PageHeadText = table.Column<string>(nullable: true),
                    ParentId = table.Column<int>(nullable: true),
                    PermanentRedirect = table.Column<bool>(nullable: false),
                    PortalID = table.Column<int>(nullable: true),
                    RefreshInterval = table.Column<int>(nullable: true),
                    SiteMapPriority = table.Column<float>(nullable: false),
                    SkinSrc = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: true),
                    TabName = table.Column<string>(nullable: true),
                    TabOrder = table.Column<int>(nullable: false),
                    TabPath = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    UniqueId = table.Column<Guid>(nullable: false),
                    Url = table.Column<string>(nullable: true),
                    VersionGUID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tabs", x => x.TabID);
                    table.ForeignKey(
                        name: "FK_Tabs_ContentItems_ContentItemID",
                        column: x => x.ContentItemID,
                        principalTable: "ContentItems",
                        principalColumn: "ContentItemID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tabs_Tabs_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Tabs",
                        principalColumn: "TabID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tabs_Portals_PortalID",
                        column: x => x.PortalID,
                        principalTable: "Portals",
                        principalColumn: "PortalID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Folders",
                columns: table => new
                {
                    FolderID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContentWorkflowStatePermissionWorkflowStatePermissionID = table.Column<int>(nullable: true),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    FolderMappingID = table.Column<int>(nullable: false),
                    FolderPath = table.Column<string>(nullable: true),
                    IsCached = table.Column<bool>(nullable: false),
                    IsProtected = table.Column<bool>(nullable: false),
                    IsVersioned = table.Column<bool>(nullable: false),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    LastUpdated = table.Column<DateTime>(nullable: false),
                    MappedPath = table.Column<string>(nullable: true),
                    ParentID = table.Column<int>(nullable: true),
                    PortalID = table.Column<int>(nullable: true),
                    StorageLocation = table.Column<int>(nullable: false),
                    UniqueID = table.Column<Guid>(nullable: false),
                    VersionGuid = table.Column<Guid>(nullable: false),
                    WorkflowID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Folders", x => x.FolderID);
                    table.ForeignKey(
                        name: "FK_Folders_ContentWorkflowStatePermission_ContentWorkflowStatePermissionWorkflowStatePermissionID",
                        column: x => x.ContentWorkflowStatePermissionWorkflowStatePermissionID,
                        principalTable: "ContentWorkflowStatePermission",
                        principalColumn: "WorkflowStatePermissionID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Folders_FolderMappings_FolderMappingID",
                        column: x => x.FolderMappingID,
                        principalTable: "FolderMappings",
                        principalColumn: "FolderMappingID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Folders_Portals_PortalID",
                        column: x => x.PortalID,
                        principalTable: "Portals",
                        principalColumn: "PortalID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Folders_ContentWorkflows_WorkflowID",
                        column: x => x.WorkflowID,
                        principalTable: "ContentWorkflows",
                        principalColumn: "WorkflowID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CoreMessaging_Messages",
                columns: table => new
                {
                    MessageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Body = table.Column<string>(nullable: true),
                    Context = table.Column<string>(nullable: true),
                    ConversationID = table.Column<int>(nullable: true),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    ExpirationDate = table.Column<DateTime>(nullable: true),
                    From = table.Column<string>(nullable: true),
                    IncludeDismissAction = table.Column<bool>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    NotificationTypeID = table.Column<int>(nullable: true),
                    PortalID = table.Column<int>(nullable: true),
                    ReplyAllAllowed = table.Column<bool>(nullable: true),
                    SenderUserID = table.Column<int>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    To = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoreMessaging_Messages", x => x.MessageID);
                    table.ForeignKey(
                        name: "FK_CoreMessaging_Messages_CoreMessaging_NotificationTypes_NotificationTypeID",
                        column: x => x.NotificationTypeID,
                        principalTable: "CoreMessaging_NotificationTypes",
                        principalColumn: "NotificationTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CoreMessaging_NotificationTypeActions",
                columns: table => new
                {
                    NotificaationTypeActionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    APICall = table.Column<string>(nullable: true),
                    ConfirmRescourceKey = table.Column<string>(nullable: true),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    DescriptionResourceKey = table.Column<string>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    NameResourceKey = table.Column<string>(nullable: true),
                    NotificationTypeID = table.Column<int>(nullable: false),
                    Order = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoreMessaging_NotificationTypeActions", x => x.NotificaationTypeActionID);
                    table.ForeignKey(
                        name: "FK_CoreMessaging_NotificationTypeActions_CoreMessaging_NotificationTypes_NotificationTypeID",
                        column: x => x.NotificationTypeID,
                        principalTable: "CoreMessaging_NotificationTypes",
                        principalColumn: "NotificationTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ModuleControls",
                columns: table => new
                {
                    ModuleControlID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ControlKey = table.Column<string>(nullable: true),
                    ControlSrc = table.Column<string>(nullable: true),
                    ControlTitle = table.Column<string>(nullable: true),
                    ControlType = table.Column<int>(nullable: false),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    HelpUrl = table.Column<string>(nullable: true),
                    IconFile = table.Column<string>(nullable: true),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    ModuleDefID = table.Column<int>(nullable: false),
                    SupportPopUps = table.Column<bool>(nullable: false),
                    SupportsPartialRendering = table.Column<bool>(nullable: false),
                    ViewOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleControls", x => x.ModuleControlID);
                    table.ForeignKey(
                        name: "FK_ModuleControls_ModuleDefinitions_ModuleDefID",
                        column: x => x.ModuleDefID,
                        principalTable: "ModuleDefinitions",
                        principalColumn: "ModuleDefID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    ModuleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AllTabs = table.Column<bool>(nullable: false),
                    ContentItemID = table.Column<int>(nullable: true),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    EndDate = table.Column<DateTime>(nullable: true),
                    Icon = table.Column<string>(nullable: true),
                    InheritViewPermissions = table.Column<bool>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsShareable = table.Column<bool>(nullable: true),
                    IsShareableViewOnly = table.Column<bool>(nullable: true),
                    LastContentModifiedOnDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    ModuleDef = table.Column<int>(nullable: false),
                    ModuleDefID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Path = table.Column<string>(nullable: true),
                    PortalID = table.Column<int>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.ModuleID);
                    table.ForeignKey(
                        name: "FK_Modules_ContentItems_ContentItemID",
                        column: x => x.ContentItemID,
                        principalTable: "ContentItems",
                        principalColumn: "ContentItemID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Modules_ModuleDefinitions_ModuleDefID",
                        column: x => x.ModuleDefID,
                        principalTable: "ModuleDefinitions",
                        principalColumn: "ModuleDefID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DesktopModulePermission",
                columns: table => new
                {
                    DesktopModulePermissionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AllowAccess = table.Column<bool>(nullable: false),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    PermissionID = table.Column<int>(nullable: false),
                    PortalDesktopModuleID = table.Column<int>(nullable: false),
                    RoleID = table.Column<int>(nullable: true),
                    UserID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesktopModulePermission", x => x.DesktopModulePermissionID);
                    table.ForeignKey(
                        name: "FK_DesktopModulePermission_Permission_PermissionID",
                        column: x => x.PermissionID,
                        principalTable: "Permission",
                        principalColumn: "PermissionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DesktopModulePermission_PortalDesktopModules_PortalDesktopModuleID",
                        column: x => x.PortalDesktopModuleID,
                        principalTable: "PortalDesktopModules",
                        principalColumn: "PortalDesktopModuleID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DesktopModulePermission_Role_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Role",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DesktopModulePermission_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TabPermission",
                columns: table => new
                {
                    TabPermissionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AllowAccess = table.Column<bool>(nullable: false),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    PermissionID = table.Column<int>(nullable: false),
                    RoleID = table.Column<int>(nullable: true),
                    TabID = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabPermission", x => x.TabPermissionID);
                    table.ForeignKey(
                        name: "FK_TabPermission_Permission_PermissionID",
                        column: x => x.PermissionID,
                        principalTable: "Permission",
                        principalColumn: "PermissionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TabPermission_Role_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Role",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TabPermission_Tabs_TabID",
                        column: x => x.TabID,
                        principalTable: "Tabs",
                        principalColumn: "TabID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TabPermission_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TabSettings",
                columns: table => new
                {
                    TabID = table.Column<int>(nullable: false),
                    SettingName = table.Column<string>(nullable: false),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    SettingValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabSettings", x => new { x.TabID, x.SettingName });
                    table.UniqueConstraint("AK_TabSettings_SettingName_TabID", x => new { x.SettingName, x.TabID });
                    table.ForeignKey(
                        name: "FK_TabSettings_Tabs_TabID",
                        column: x => x.TabID,
                        principalTable: "Tabs",
                        principalColumn: "TabID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TabUrls",
                columns: table => new
                {
                    TabId = table.Column<int>(nullable: false),
                    SeqNum = table.Column<int>(nullable: false),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    CultureCode = table.Column<string>(nullable: true),
                    HttpStatus = table.Column<string>(nullable: true),
                    IsSystem = table.Column<bool>(nullable: false),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    PortalAliasId = table.Column<int>(nullable: true),
                    PortalAliasUsage = table.Column<int>(nullable: true),
                    QueryString = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabUrls", x => new { x.TabId, x.SeqNum });
                    table.UniqueConstraint("AK_TabUrls_SeqNum_TabId", x => new { x.SeqNum, x.TabId });
                    table.ForeignKey(
                        name: "FK_TabUrls_Tabs_TabId",
                        column: x => x.TabId,
                        principalTable: "Tabs",
                        principalColumn: "TabID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TabVersions",
                columns: table => new
                {
                    TabVersionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    IsPublished = table.Column<bool>(nullable: false),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    TabId = table.Column<int>(nullable: false),
                    TimeStamp = table.Column<DateTime>(nullable: false),
                    Version = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabVersions", x => x.TabVersionId);
                    table.ForeignKey(
                        name: "FK_TabVersions_Tabs_TabId",
                        column: x => x.TabId,
                        principalTable: "Tabs",
                        principalColumn: "TabID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    FileId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Content = table.Column<byte>(nullable: true),
                    ContentItemID = table.Column<int>(nullable: true),
                    ContentType = table.Column<string>(nullable: true),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    EnablePublishPeriod = table.Column<bool>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    Extension = table.Column<string>(nullable: true),
                    FileName = table.Column<string>(nullable: true),
                    FolderID = table.Column<int>(nullable: false),
                    HasBeenPublished = table.Column<bool>(nullable: false),
                    Hieght = table.Column<int>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: false),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    PortalId = table.Column<int>(nullable: true),
                    PublishedVersion = table.Column<int>(nullable: false),
                    SHA1Hash = table.Column<string>(nullable: true),
                    Size = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    UniqueID = table.Column<Guid>(nullable: false),
                    VersionGuid = table.Column<Guid>(nullable: false),
                    Width = table.Column<int>(nullable: true),
                    Folder = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.FileId);
                    table.ForeignKey(
                        name: "FK_Files_ContentItems_ContentItemID",
                        column: x => x.ContentItemID,
                        principalTable: "ContentItems",
                        principalColumn: "ContentItemID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Files_Folders_FolderID",
                        column: x => x.FolderID,
                        principalTable: "Folders",
                        principalColumn: "FolderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Files_Portals_PortalId",
                        column: x => x.PortalId,
                        principalTable: "Portals",
                        principalColumn: "PortalID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FolderPermission",
                columns: table => new
                {
                    FolderPermissionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AllowAccess = table.Column<bool>(nullable: false),
                    ContentWorkflowStatePermissionWorkflowStatePermissionID = table.Column<int>(nullable: true),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    FolderID = table.Column<int>(nullable: false),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    PermissionID = table.Column<int>(nullable: false),
                    RoleID = table.Column<int>(nullable: true),
                    UserID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FolderPermission", x => x.FolderPermissionID);
                    table.ForeignKey(
                        name: "FK_FolderPermission_ContentWorkflowStatePermission_ContentWorkflowStatePermissionWorkflowStatePermissionID",
                        column: x => x.ContentWorkflowStatePermissionWorkflowStatePermissionID,
                        principalTable: "ContentWorkflowStatePermission",
                        principalColumn: "WorkflowStatePermissionID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FolderPermission_Folders_FolderID",
                        column: x => x.FolderID,
                        principalTable: "Folders",
                        principalColumn: "FolderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FolderPermission_Permission_PermissionID",
                        column: x => x.PermissionID,
                        principalTable: "Permission",
                        principalColumn: "PermissionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FolderPermission_Role_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Role",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FolderPermission_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CoreMessaging_MessageAttachments",
                columns: table => new
                {
                    MessageAttachmentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    FileID = table.Column<int>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    MessageID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoreMessaging_MessageAttachments", x => x.MessageAttachmentID);
                    table.ForeignKey(
                        name: "FK_CoreMessaging_MessageAttachments_CoreMessaging_Messages_MessageID",
                        column: x => x.MessageID,
                        principalTable: "CoreMessaging_Messages",
                        principalColumn: "MessageID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CoreMessaging_MessagingRecipients",
                columns: table => new
                {
                    RecipientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Archived = table.Column<bool>(nullable: false),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    EmailSchedulerInstance = table.Column<Guid>(nullable: true),
                    EmailSent = table.Column<bool>(nullable: false),
                    EmailSentDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    MessageID = table.Column<int>(nullable: false),
                    Read = table.Column<bool>(nullable: false),
                    SendToast = table.Column<bool>(nullable: false),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoreMessaging_MessagingRecipients", x => x.RecipientID);
                    table.ForeignKey(
                        name: "FK_CoreMessaging_MessagingRecipients_CoreMessaging_Messages_MessageID",
                        column: x => x.MessageID,
                        principalTable: "CoreMessaging_Messages",
                        principalColumn: "MessageID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CoreMessaging_Subscriptions",
                columns: table => new
                {
                    SubscriptionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOnDate = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ModuleID = table.Column<int>(nullable: true),
                    ObjectData = table.Column<string>(nullable: true),
                    ObjectKey = table.Column<string>(nullable: true),
                    PortalID = table.Column<int>(nullable: true),
                    SubscriptionTypeID = table.Column<int>(nullable: false),
                    TabID = table.Column<int>(nullable: true),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoreMessaging_Subscriptions", x => x.SubscriptionID);
                    table.ForeignKey(
                        name: "FK_CoreMessaging_Subscriptions_Modules_ModuleID",
                        column: x => x.ModuleID,
                        principalTable: "Modules",
                        principalColumn: "ModuleID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CoreMessaging_Subscriptions_Portals_PortalID",
                        column: x => x.PortalID,
                        principalTable: "Portals",
                        principalColumn: "PortalID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CoreMessaging_Subscriptions_CoreMessaging_SubscriptionTypes_SubscriptionTypeID",
                        column: x => x.SubscriptionTypeID,
                        principalTable: "CoreMessaging_SubscriptionTypes",
                        principalColumn: "SubscriptionTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoreMessaging_Subscriptions_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HtmlText",
                columns: table => new
                {
                    ModuleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Content = table.Column<string>(nullable: true),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    IsPublished = table.Column<bool>(nullable: true),
                    ItemID = table.Column<int>(nullable: false),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    ModuleID1 = table.Column<int>(nullable: true),
                    StateID = table.Column<int>(nullable: true),
                    Summary = table.Column<string>(nullable: true),
                    Version = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HtmlText", x => x.ModuleID);
                    table.ForeignKey(
                        name: "FK_HtmlText_Modules_ModuleID1",
                        column: x => x.ModuleID1,
                        principalTable: "Modules",
                        principalColumn: "ModuleID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HtmlText_WorkflowStates_StateID",
                        column: x => x.StateID,
                        principalTable: "WorkflowStates",
                        principalColumn: "StateID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ModulePermissions",
                columns: table => new
                {
                    ModulePermissionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AllowAccess = table.Column<bool>(nullable: false),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    ModuleID = table.Column<int>(nullable: false),
                    PermissionID = table.Column<int>(nullable: false),
                    PortalID = table.Column<int>(nullable: false),
                    RoleID = table.Column<int>(nullable: true),
                    UserID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModulePermissions", x => x.ModulePermissionID);
                    table.ForeignKey(
                        name: "FK_ModulePermissions_Modules_ModuleID",
                        column: x => x.ModuleID,
                        principalTable: "Modules",
                        principalColumn: "ModuleID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModulePermissions_Permission_PermissionID",
                        column: x => x.PermissionID,
                        principalTable: "Permission",
                        principalColumn: "PermissionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModulePermissions_Role_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Role",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ModulePermissions_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ModuleSettings",
                columns: table => new
                {
                    ModuleID = table.Column<int>(nullable: false),
                    SettingName = table.Column<string>(nullable: false),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleSettings", x => new { x.ModuleID, x.SettingName });
                    table.ForeignKey(
                        name: "FK_ModuleSettings_Modules_ModuleID",
                        column: x => x.ModuleID,
                        principalTable: "Modules",
                        principalColumn: "ModuleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TabModules",
                columns: table => new
                {
                    TabModuleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Alignment = table.Column<string>(nullable: true),
                    Border = table.Column<string>(nullable: true),
                    CacheMethod = table.Column<string>(nullable: true),
                    CacheTime = table.Column<int>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    ContainerSrc = table.Column<string>(nullable: true),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    CultureCode = table.Column<string>(nullable: true),
                    DefaultLanguageGUID = table.Column<Guid>(nullable: false),
                    DisplayPrint = table.Column<int>(nullable: false),
                    DisplaySyndicate = table.Column<int>(nullable: false),
                    DisplayTitle = table.Column<int>(nullable: false),
                    ElementId = table.Column<string>(nullable: true),
                    Footer = table.Column<string>(nullable: true),
                    Header = table.Column<string>(nullable: true),
                    IconFile = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<int>(nullable: false),
                    IsWebSlice = table.Column<int>(nullable: false),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    LocalizedVersionGUID = table.Column<Guid>(nullable: false),
                    ModuleID = table.Column<int>(nullable: false),
                    ModuleOrder = table.Column<int>(nullable: false),
                    ModuleTitle = table.Column<string>(nullable: true),
                    Order = table.Column<int>(nullable: false),
                    PageId = table.Column<int>(nullable: false),
                    PaneName = table.Column<string>(nullable: true),
                    TabID = table.Column<int>(nullable: false),
                    UniqueId = table.Column<Guid>(nullable: false),
                    VersionGUID = table.Column<Guid>(nullable: false),
                    Visibility = table.Column<int>(nullable: false),
                    WebSliceExpiryDate = table.Column<DateTime>(nullable: true),
                    WebSliceTTL = table.Column<int>(nullable: true),
                    WebSliceTitle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabModules", x => x.TabModuleID);
                    table.ForeignKey(
                        name: "FK_TabModules_Modules_ModuleID",
                        column: x => x.ModuleID,
                        principalTable: "Modules",
                        principalColumn: "ModuleID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TabModules_Tabs_TabID",
                        column: x => x.TabID,
                        principalTable: "Tabs",
                        principalColumn: "TabID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TabVersionDetails",
                columns: table => new
                {
                    TabVersionDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Action = table.Column<int>(nullable: false),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    ModuleId = table.Column<int>(nullable: false),
                    ModuleOrder = table.Column<int>(nullable: false),
                    ModuleVersion = table.Column<int>(nullable: false),
                    PageName = table.Column<string>(nullable: true),
                    TabVersionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabVersionDetails", x => x.TabVersionDetailId);
                    table.ForeignKey(
                        name: "FK_TabVersionDetails_TabVersions_TabVersionId",
                        column: x => x.TabVersionId,
                        principalTable: "TabVersions",
                        principalColumn: "TabVersionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FileVersions",
                columns: table => new
                {
                    FileId = table.Column<int>(nullable: false),
                    Version = table.Column<int>(nullable: false),
                    Content = table.Column<byte>(nullable: true),
                    ContentType = table.Column<string>(nullable: true),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    Extension = table.Column<string>(nullable: true),
                    FileName = table.Column<string>(nullable: true),
                    Height = table.Column<int>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    SHA1Hash = table.Column<string>(nullable: true),
                    Size = table.Column<int>(nullable: false),
                    Width = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileVersions", x => new { x.FileId, x.Version });
                    table.ForeignKey(
                        name: "FK_FileVersions_Files_FileId",
                        column: x => x.FileId,
                        principalTable: "Files",
                        principalColumn: "FileId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HtmlTextLog",
                columns: table => new
                {
                    HtmlTextLogID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Approved = table.Column<bool>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    CreatedByUserID = table.Column<int>(nullable: false),
                    CreatedOnDate = table.Column<DateTime>(nullable: false),
                    ItemID = table.Column<int>(nullable: false),
                    StateID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HtmlTextLog", x => x.HtmlTextLogID);
                    table.ForeignKey(
                        name: "FK_HtmlTextLog_HtmlText_ItemID",
                        column: x => x.ItemID,
                        principalTable: "HtmlText",
                        principalColumn: "ModuleID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HtmlTextLog_WorkflowStates_StateID",
                        column: x => x.StateID,
                        principalTable: "WorkflowStates",
                        principalColumn: "StateID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HtmlTextUsers",
                columns: table => new
                {
                    HtmlTextUserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOnDate = table.Column<DateTime>(nullable: false),
                    ItemID = table.Column<int>(nullable: false),
                    ModuleID = table.Column<int>(nullable: false),
                    StateID = table.Column<int>(nullable: false),
                    TabID = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HtmlTextUsers", x => x.HtmlTextUserID);
                    table.ForeignKey(
                        name: "FK_HtmlTextUsers_HtmlText_ItemID",
                        column: x => x.ItemID,
                        principalTable: "HtmlText",
                        principalColumn: "ModuleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TabModuleSettings",
                columns: table => new
                {
                    TabModuleID = table.Column<int>(nullable: false),
                    SettingName = table.Column<string>(nullable: false),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    SetttingValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabModuleSettings", x => new { x.TabModuleID, x.SettingName });
                    table.UniqueConstraint("AK_TabModuleSettings_SettingName_TabModuleID", x => new { x.SettingName, x.TabModuleID });
                    table.ForeignKey(
                        name: "FK_TabModuleSettings_TabModules_TabModuleID",
                        column: x => x.TabModuleID,
                        principalTable: "TabModules",
                        principalColumn: "TabModuleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_aspnet_Memership_ApplicationID",
                table: "aspnet_Memership",
                column: "ApplicationID");

            migrationBuilder.CreateIndex(
                name: "IX_aspnet_Users_ApplicationId",
                table: "aspnet_Users",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Assemblies_PackageID",
                table: "Assemblies",
                column: "PackageID");

            migrationBuilder.CreateIndex(
                name: "IX_Authentication_PackageID",
                table: "Authentication",
                column: "PackageID");

            migrationBuilder.CreateIndex(
                name: "IX_ContentItems_ContentTypeID",
                table: "ContentItems",
                column: "ContentTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ContentItems_StateID",
                table: "ContentItems",
                column: "StateID");

            migrationBuilder.CreateIndex(
                name: "IX_ContentItems_MetaData_ContentItemID",
                table: "ContentItems_MetaData",
                column: "ContentItemID");

            migrationBuilder.CreateIndex(
                name: "IX_ContentItems_MetaData_MetaDataID",
                table: "ContentItems_MetaData",
                column: "MetaDataID");

            migrationBuilder.CreateIndex(
                name: "IX_ContentItems_Tags_ContentItemID",
                table: "ContentItems_Tags",
                column: "ContentItemID");

            migrationBuilder.CreateIndex(
                name: "IX_ContentItems_Tags_ContentItemTagID1",
                table: "ContentItems_Tags",
                column: "ContentItemTagID1");

            migrationBuilder.CreateIndex(
                name: "IX_ContentItems_Tags_TermID",
                table: "ContentItems_Tags",
                column: "TermID");

            migrationBuilder.CreateIndex(
                name: "IX_ContentWorkflowActios_ContentWorkflowActionActionID",
                table: "ContentWorkflowActios",
                column: "ContentWorkflowActionActionID");

            migrationBuilder.CreateIndex(
                name: "IX_ContentWorkflowLogs_ContentItemID",
                table: "ContentWorkflowLogs",
                column: "ContentItemID");

            migrationBuilder.CreateIndex(
                name: "IX_ContentWorkflowLogs_WorkflowID",
                table: "ContentWorkflowLogs",
                column: "WorkflowID");

            migrationBuilder.CreateIndex(
                name: "IX_ContentWorkflows_Content_TypeContentTypeID",
                table: "ContentWorkflows",
                column: "Content_TypeContentTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ContentWorkflowSources_WorkflowID",
                table: "ContentWorkflowSources",
                column: "WorkflowID");

            migrationBuilder.CreateIndex(
                name: "IX_ContentWorkflowStatePermission_PermissionID",
                table: "ContentWorkflowStatePermission",
                column: "PermissionID");

            migrationBuilder.CreateIndex(
                name: "IX_ContentWorkflowStatePermission_StateId",
                table: "ContentWorkflowStatePermission",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_ContentWorkflowStatePermission_UserID",
                table: "ContentWorkflowStatePermission",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ContentWorkflowStates_WorkflowID",
                table: "ContentWorkflowStates",
                column: "WorkflowID");

            migrationBuilder.CreateIndex(
                name: "IX_CoreMessaging_MessageAttachments_MessageID",
                table: "CoreMessaging_MessageAttachments",
                column: "MessageID");

            migrationBuilder.CreateIndex(
                name: "IX_CoreMessaging_Messages_NotificationTypeID",
                table: "CoreMessaging_Messages",
                column: "NotificationTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_CoreMessaging_MessagingRecipients_MessageID",
                table: "CoreMessaging_MessagingRecipients",
                column: "MessageID");

            migrationBuilder.CreateIndex(
                name: "IX_CoreMessaging_NotificationTypeActions_NotificationTypeID",
                table: "CoreMessaging_NotificationTypeActions",
                column: "NotificationTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_CoreMessaging_NotificationTypes_DesktopModuleID",
                table: "CoreMessaging_NotificationTypes",
                column: "DesktopModuleID");

            migrationBuilder.CreateIndex(
                name: "IX_CoreMessaging_Subscriptions_ModuleID",
                table: "CoreMessaging_Subscriptions",
                column: "ModuleID");

            migrationBuilder.CreateIndex(
                name: "IX_CoreMessaging_Subscriptions_PortalID",
                table: "CoreMessaging_Subscriptions",
                column: "PortalID");

            migrationBuilder.CreateIndex(
                name: "IX_CoreMessaging_Subscriptions_SubscriptionTypeID",
                table: "CoreMessaging_Subscriptions",
                column: "SubscriptionTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_CoreMessaging_Subscriptions_UserID",
                table: "CoreMessaging_Subscriptions",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_DesktopModulePermission_PermissionID",
                table: "DesktopModulePermission",
                column: "PermissionID");

            migrationBuilder.CreateIndex(
                name: "IX_DesktopModulePermission_PortalDesktopModuleID",
                table: "DesktopModulePermission",
                column: "PortalDesktopModuleID");

            migrationBuilder.CreateIndex(
                name: "IX_DesktopModulePermission_RoleID",
                table: "DesktopModulePermission",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_DesktopModulePermission_UserID",
                table: "DesktopModulePermission",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_DesktopModules_PackageID",
                table: "DesktopModules",
                column: "PackageID");

            migrationBuilder.CreateIndex(
                name: "IX_EventLog_EventLogConfigID",
                table: "EventLog",
                column: "EventLogConfigID");

            migrationBuilder.CreateIndex(
                name: "IX_EventLog_LogConfigLogEventID",
                table: "EventLog",
                column: "LogConfigLogEventID");

            migrationBuilder.CreateIndex(
                name: "IX_EventLog_LogTypeKey1",
                table: "EventLog",
                column: "LogTypeKey1");

            migrationBuilder.CreateIndex(
                name: "IX_EventLogConfig_LogTypeKey1",
                table: "EventLogConfig",
                column: "LogTypeKey1");

            migrationBuilder.CreateIndex(
                name: "IX_ExportImportCheckpoints_JobID",
                table: "ExportImportCheckpoints",
                column: "JobID");

            migrationBuilder.CreateIndex(
                name: "IX_ExportImportJobLogs_JobId",
                table: "ExportImportJobLogs",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_Files_ContentItemID",
                table: "Files",
                column: "ContentItemID");

            migrationBuilder.CreateIndex(
                name: "IX_Files_FolderID",
                table: "Files",
                column: "FolderID");

            migrationBuilder.CreateIndex(
                name: "IX_Files_PortalId",
                table: "Files",
                column: "PortalId");

            migrationBuilder.CreateIndex(
                name: "IX_FolderMappings_PortalID",
                table: "FolderMappings",
                column: "PortalID");

            migrationBuilder.CreateIndex(
                name: "IX_FolderPermission_ContentWorkflowStatePermissionWorkflowStatePermissionID",
                table: "FolderPermission",
                column: "ContentWorkflowStatePermissionWorkflowStatePermissionID");

            migrationBuilder.CreateIndex(
                name: "IX_FolderPermission_FolderID",
                table: "FolderPermission",
                column: "FolderID");

            migrationBuilder.CreateIndex(
                name: "IX_FolderPermission_PermissionID",
                table: "FolderPermission",
                column: "PermissionID");

            migrationBuilder.CreateIndex(
                name: "IX_FolderPermission_RoleID",
                table: "FolderPermission",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_FolderPermission_UserID",
                table: "FolderPermission",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Folders_ContentWorkflowStatePermissionWorkflowStatePermissionID",
                table: "Folders",
                column: "ContentWorkflowStatePermissionWorkflowStatePermissionID");

            migrationBuilder.CreateIndex(
                name: "IX_Folders_FolderMappingID",
                table: "Folders",
                column: "FolderMappingID");

            migrationBuilder.CreateIndex(
                name: "IX_Folders_PortalID",
                table: "Folders",
                column: "PortalID");

            migrationBuilder.CreateIndex(
                name: "IX_Folders_WorkflowID",
                table: "Folders",
                column: "WorkflowID");

            migrationBuilder.CreateIndex(
                name: "IX_HtmlText_ModuleID1",
                table: "HtmlText",
                column: "ModuleID1");

            migrationBuilder.CreateIndex(
                name: "IX_HtmlText_StateID",
                table: "HtmlText",
                column: "StateID");

            migrationBuilder.CreateIndex(
                name: "IX_HtmlTextLog_ItemID",
                table: "HtmlTextLog",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_HtmlTextLog_StateID",
                table: "HtmlTextLog",
                column: "StateID");

            migrationBuilder.CreateIndex(
                name: "IX_HtmlTextUsers_ItemID",
                table: "HtmlTextUsers",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_JavascriptLibraries_PackageID",
                table: "JavascriptLibraries",
                column: "PackageID");

            migrationBuilder.CreateIndex(
                name: "IX_Journal_JournalTypeId",
                table: "Journal",
                column: "JournalTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Journal_Comments_JournalId",
                table: "Journal_Comments",
                column: "JournalId");

            migrationBuilder.CreateIndex(
                name: "IX_Journal_Data_JournalId",
                table: "Journal_Data",
                column: "JournalId");

            migrationBuilder.CreateIndex(
                name: "IX_LanguagePacks_PackageID",
                table: "LanguagePacks",
                column: "PackageID");

            migrationBuilder.CreateIndex(
                name: "IX_Mobile_PreviewProfiles_PortalId",
                table: "Mobile_PreviewProfiles",
                column: "PortalId");

            migrationBuilder.CreateIndex(
                name: "IX_Mobile_RedirectionRules_Mobile_RedirectionId",
                table: "Mobile_RedirectionRules",
                column: "Mobile_RedirectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Mobile_RedirectionRules_RedirectionId",
                table: "Mobile_RedirectionRules",
                column: "RedirectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Mobile_Redirections_PortalId",
                table: "Mobile_Redirections",
                column: "PortalId");

            migrationBuilder.CreateIndex(
                name: "IX_ModuleControls_ModuleDefID",
                table: "ModuleControls",
                column: "ModuleDefID");

            migrationBuilder.CreateIndex(
                name: "IX_ModuleDefinitions_DesktopModuleID",
                table: "ModuleDefinitions",
                column: "DesktopModuleID");

            migrationBuilder.CreateIndex(
                name: "IX_ModulePermissions_ModuleID",
                table: "ModulePermissions",
                column: "ModuleID");

            migrationBuilder.CreateIndex(
                name: "IX_ModulePermissions_PermissionID",
                table: "ModulePermissions",
                column: "PermissionID");

            migrationBuilder.CreateIndex(
                name: "IX_ModulePermissions_RoleID",
                table: "ModulePermissions",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_ModulePermissions_UserID",
                table: "ModulePermissions",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Modules_ContentItemID",
                table: "Modules",
                column: "ContentItemID");

            migrationBuilder.CreateIndex(
                name: "IX_Modules_ModuleDefID",
                table: "Modules",
                column: "ModuleDefID");

            migrationBuilder.CreateIndex(
                name: "IX_PackageDependencies_PackageID",
                table: "PackageDependencies",
                column: "PackageID");

            migrationBuilder.CreateIndex(
                name: "IX_Packages_PackageType",
                table: "Packages",
                column: "PackageType",
                unique: true,
                filter: "[PackageType] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Packages_PackageTypeNavigationPackageID",
                table: "Packages",
                column: "PackageTypeNavigationPackageID");

            migrationBuilder.CreateIndex(
                name: "IX_PasswordHistory_UserID",
                table: "PasswordHistory",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaBarExtensions_MenuId",
                table: "PersonaBarExtensions",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaBarMenu_ParentID",
                table: "PersonaBarMenu",
                column: "ParentID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaBarMenuDefaultPermissions_MenuId",
                table: "PersonaBarMenuDefaultPermissions",
                column: "MenuId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PersonaBarMenuPermission_MenuId",
                table: "PersonaBarMenuPermission",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaBarMenuPermission_PermissionId",
                table: "PersonaBarMenuPermission",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaBarMenuPermission_PortalId",
                table: "PersonaBarMenuPermission",
                column: "PortalId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaBarMenuPermission_RoleId",
                table: "PersonaBarMenuPermission",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaBarMenuPermission_UserId",
                table: "PersonaBarMenuPermission",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaBarPermission_MenuId",
                table: "PersonaBarPermission",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_PortalAlias_PortalID",
                table: "PortalAlias",
                column: "PortalID");

            migrationBuilder.CreateIndex(
                name: "IX_PortalDesktopModules_DesktopModuleID",
                table: "PortalDesktopModules",
                column: "DesktopModuleID");

            migrationBuilder.CreateIndex(
                name: "IX_PortalDesktopModules_PortalID",
                table: "PortalDesktopModules",
                column: "PortalID");

            migrationBuilder.CreateIndex(
                name: "IX_PortalLanguages_LanguageID",
                table: "PortalLanguages",
                column: "LanguageID");

            migrationBuilder.CreateIndex(
                name: "IX_PortalLanguages_PortalID",
                table: "PortalLanguages",
                column: "PortalID");

            migrationBuilder.CreateIndex(
                name: "IX_PortalLocalization_PortalID1",
                table: "PortalLocalization",
                column: "PortalID1");

            migrationBuilder.CreateIndex(
                name: "IX_PortalSettings_PortalID",
                table: "PortalSettings",
                column: "PortalID");

            migrationBuilder.CreateIndex(
                name: "IX_Profile_PortalId",
                table: "Profile",
                column: "PortalId");

            migrationBuilder.CreateIndex(
                name: "IX_Profile_UserId",
                table: "Profile",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfilePropertyDefinition_PortalID",
                table: "ProfilePropertyDefinition",
                column: "PortalID");

            migrationBuilder.CreateIndex(
                name: "IX_Relationships_PortalID",
                table: "Relationships",
                column: "PortalID");

            migrationBuilder.CreateIndex(
                name: "IX_Relationships_RelationshipTypeID",
                table: "Relationships",
                column: "RelationshipTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Relationships_UserID",
                table: "Relationships",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Role_PortalID",
                table: "Role",
                column: "PortalID");

            migrationBuilder.CreateIndex(
                name: "IX_Role_RoleGroupID",
                table: "Role",
                column: "RoleGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_RoleGroups_PortalID",
                table: "RoleGroups",
                column: "PortalID");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleHistory_ScheduleID",
                table: "ScheduleHistory",
                column: "ScheduleID");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleItemSettings_ScheduleID1",
                table: "ScheduleItemSettings",
                column: "ScheduleID1");

            migrationBuilder.CreateIndex(
                name: "IX_SiteLog_PortalID",
                table: "SiteLog",
                column: "PortalID");

            migrationBuilder.CreateIndex(
                name: "IX_SkinControls_PackageID",
                table: "SkinControls",
                column: "PackageID");

            migrationBuilder.CreateIndex(
                name: "IX_Skins_SkinPackageID",
                table: "Skins",
                column: "SkinPackageID");

            migrationBuilder.CreateIndex(
                name: "IX_SystemMessages_PortalID",
                table: "SystemMessages",
                column: "PortalID");

            migrationBuilder.CreateIndex(
                name: "IX_TabModules_ModuleID",
                table: "TabModules",
                column: "ModuleID");

            migrationBuilder.CreateIndex(
                name: "IX_TabModules_TabID",
                table: "TabModules",
                column: "TabID");

            migrationBuilder.CreateIndex(
                name: "IX_TabPermission_PermissionID",
                table: "TabPermission",
                column: "PermissionID");

            migrationBuilder.CreateIndex(
                name: "IX_TabPermission_RoleID",
                table: "TabPermission",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_TabPermission_TabID",
                table: "TabPermission",
                column: "TabID");

            migrationBuilder.CreateIndex(
                name: "IX_TabPermission_UserID",
                table: "TabPermission",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Tabs_ContentItemID",
                table: "Tabs",
                column: "ContentItemID");

            migrationBuilder.CreateIndex(
                name: "IX_Tabs_ParentId",
                table: "Tabs",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Tabs_PortalID",
                table: "Tabs",
                column: "PortalID");

            migrationBuilder.CreateIndex(
                name: "IX_TabVersionDetails_TabVersionId",
                table: "TabVersionDetails",
                column: "TabVersionId");

            migrationBuilder.CreateIndex(
                name: "IX_TabVersions_TabId",
                table: "TabVersions",
                column: "TabId");

            migrationBuilder.CreateIndex(
                name: "IX_Taxonomy_Terms_ParentTermID",
                table: "Taxonomy_Terms",
                column: "ParentTermID");

            migrationBuilder.CreateIndex(
                name: "IX_Taxonomy_Terms_VocabularyID",
                table: "Taxonomy_Terms",
                column: "VocabularyID");

            migrationBuilder.CreateIndex(
                name: "IX_Taxonomy_Vocabularies_ScopeTypeID",
                table: "Taxonomy_Vocabularies",
                column: "ScopeTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Taxonomy_Vocabularies_VocabularyTypeID",
                table: "Taxonomy_Vocabularies",
                column: "VocabularyTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_UrlLog_UrlTrackingID",
                table: "UrlLog",
                column: "UrlTrackingID");

            migrationBuilder.CreateIndex(
                name: "IX_Urls_PortalID",
                table: "Urls",
                column: "PortalID");

            migrationBuilder.CreateIndex(
                name: "IX_UrlTracking_PortalID",
                table: "UrlTracking",
                column: "PortalID");

            migrationBuilder.CreateIndex(
                name: "IX_UserAuthentication_UserID",
                table: "UserAuthentication",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserPortals_PortalId",
                table: "UserPortals",
                column: "PortalId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPortals_UserID",
                table: "UserPortals",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfile_ProfilePropertyDefinitionID",
                table: "UserProfile",
                column: "ProfilePropertyDefinitionID");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfile_UserID",
                table: "UserProfile",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRelationshipPreferences_RelationshipId",
                table: "UserRelationshipPreferences",
                column: "RelationshipId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRelationshipPreferences_UserID",
                table: "UserRelationshipPreferences",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRelationships_RelatedUserID",
                table: "UserRelationships",
                column: "RelatedUserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRelationships_RelationshipID",
                table: "UserRelationships",
                column: "RelationshipID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRelationships_UserID",
                table: "UserRelationships",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleID",
                table: "UserRoles",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserID",
                table: "UserRoles",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UsersOnline_PortalID",
                table: "UsersOnline",
                column: "PortalID");

            migrationBuilder.CreateIndex(
                name: "IX_UsersOnline_UserID1",
                table: "UsersOnline",
                column: "UserID1");

            migrationBuilder.CreateIndex(
                name: "IX_vSkinPackages_PackageID",
                table: "vSkinPackages",
                column: "PackageID");

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowStates_WorkflowID",
                table: "WorkflowStates",
                column: "WorkflowID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnonymousUsers");

            migrationBuilder.DropTable(
                name: "aspnet_Memership");

            migrationBuilder.DropTable(
                name: "aspnet_SchemaVersions");

            migrationBuilder.DropTable(
                name: "aspnet_Users");

            migrationBuilder.DropTable(
                name: "Assemblies");

            migrationBuilder.DropTable(
                name: "Authentication");

            migrationBuilder.DropTable(
                name: "CKE_Settings");

            migrationBuilder.DropTable(
                name: "ContentItems_MetaData");

            migrationBuilder.DropTable(
                name: "ContentItems_Tags");

            migrationBuilder.DropTable(
                name: "ContentWorkflowActios");

            migrationBuilder.DropTable(
                name: "ContentWorkflowLogs");

            migrationBuilder.DropTable(
                name: "ContentWorkflowSources");

            migrationBuilder.DropTable(
                name: "CoreMessaging_MessageAttachments");

            migrationBuilder.DropTable(
                name: "CoreMessaging_MessagingRecipients");

            migrationBuilder.DropTable(
                name: "CoreMessaging_NotificationTypeActions");

            migrationBuilder.DropTable(
                name: "CoreMessaging_Subscriptions");

            migrationBuilder.DropTable(
                name: "CoreMessaging_UserPreferences");

            migrationBuilder.DropTable(
                name: "DesktopModulePermission");

            migrationBuilder.DropTable(
                name: "EventQueue");

            migrationBuilder.DropTable(
                name: "ExceptionEvents");

            migrationBuilder.DropTable(
                name: "Exceptions");

            migrationBuilder.DropTable(
                name: "ExportImportCheckpoints");

            migrationBuilder.DropTable(
                name: "ExportImportJobLogs");

            migrationBuilder.DropTable(
                name: "ExportImportSettings");

            migrationBuilder.DropTable(
                name: "ExtensionUrlProviderConfiguration");

            migrationBuilder.DropTable(
                name: "ExtensionUrlProviders");

            migrationBuilder.DropTable(
                name: "ExtensionUrlProviderSetting");

            migrationBuilder.DropTable(
                name: "ExtensionUrlProviderTab");

            migrationBuilder.DropTable(
                name: "FileVersions");

            migrationBuilder.DropTable(
                name: "FolderMappingsSettings");

            migrationBuilder.DropTable(
                name: "FolderPermission");

            migrationBuilder.DropTable(
                name: "HostSettings");

            migrationBuilder.DropTable(
                name: "HtmlTextLog");

            migrationBuilder.DropTable(
                name: "HtmlTextUsers");

            migrationBuilder.DropTable(
                name: "IPFilter");

            migrationBuilder.DropTable(
                name: "JavascriptLibraries");

            migrationBuilder.DropTable(
                name: "Journal_Access");

            migrationBuilder.DropTable(
                name: "Journal_Comments");

            migrationBuilder.DropTable(
                name: "Journal_Data");

            migrationBuilder.DropTable(
                name: "Journal_Security");

            migrationBuilder.DropTable(
                name: "Journal_TypeFilters");

            migrationBuilder.DropTable(
                name: "LanguagePacks");

            migrationBuilder.DropTable(
                name: "Lists");

            migrationBuilder.DropTable(
                name: "Messaging_Messages");

            migrationBuilder.DropTable(
                name: "Mobile_PreviewProfiles");

            migrationBuilder.DropTable(
                name: "Mobile_RedirectionRules");

            migrationBuilder.DropTable(
                name: "ModuleControls");

            migrationBuilder.DropTable(
                name: "ModulePermissions");

            migrationBuilder.DropTable(
                name: "ModuleSettings");

            migrationBuilder.DropTable(
                name: "OutputCache");

            migrationBuilder.DropTable(
                name: "PackageDependencies");

            migrationBuilder.DropTable(
                name: "PasswordHistory");

            migrationBuilder.DropTable(
                name: "PersonaBarExtensions");

            migrationBuilder.DropTable(
                name: "PersonaBarMenuDefaultPermissions");

            migrationBuilder.DropTable(
                name: "PersonaBarMenuPermission");

            migrationBuilder.DropTable(
                name: "PortalAlias");

            migrationBuilder.DropTable(
                name: "PortalGroups");

            migrationBuilder.DropTable(
                name: "PortalLanguages");

            migrationBuilder.DropTable(
                name: "PortalLocalization");

            migrationBuilder.DropTable(
                name: "PortalSettings");

            migrationBuilder.DropTable(
                name: "Profile");

            migrationBuilder.DropTable(
                name: "RedirectMessages");

            migrationBuilder.DropTable(
                name: "RoleSettings");

            migrationBuilder.DropTable(
                name: "ScheduleHistory");

            migrationBuilder.DropTable(
                name: "ScheduleItemSettings");

            migrationBuilder.DropTable(
                name: "SearchCommonWords");

            migrationBuilder.DropTable(
                name: "SearchDeletedItems");

            migrationBuilder.DropTable(
                name: "SearchIndexer");

            migrationBuilder.DropTable(
                name: "SearchStopWords");

            migrationBuilder.DropTable(
                name: "SearchTypes");

            migrationBuilder.DropTable(
                name: "SiteLog");

            migrationBuilder.DropTable(
                name: "SkinControls");

            migrationBuilder.DropTable(
                name: "Skins");

            migrationBuilder.DropTable(
                name: "SQLQueries");

            migrationBuilder.DropTable(
                name: "SynonymsGroups");

            migrationBuilder.DropTable(
                name: "SystemMessages");

            migrationBuilder.DropTable(
                name: "TabAliasSkins");

            migrationBuilder.DropTable(
                name: "TabModuleSettings");

            migrationBuilder.DropTable(
                name: "TabPermission");

            migrationBuilder.DropTable(
                name: "TabSettings");

            migrationBuilder.DropTable(
                name: "TabUrls");

            migrationBuilder.DropTable(
                name: "TabVersionDetails");

            migrationBuilder.DropTable(
                name: "UrlLog");

            migrationBuilder.DropTable(
                name: "Urls");

            migrationBuilder.DropTable(
                name: "UserAuthentication");

            migrationBuilder.DropTable(
                name: "UserPortals");

            migrationBuilder.DropTable(
                name: "UserProfile");

            migrationBuilder.DropTable(
                name: "UserRelationshipPreferences");

            migrationBuilder.DropTable(
                name: "UserRelationships");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UsersOnline");

            migrationBuilder.DropTable(
                name: "Version");

            migrationBuilder.DropTable(
                name: "WebServers");

            migrationBuilder.DropTable(
                name: "aspnet_Applications");

            migrationBuilder.DropTable(
                name: "MetaData");

            migrationBuilder.DropTable(
                name: "Taxonomy_Terms");

            migrationBuilder.DropTable(
                name: "CoreMessaging_Messages");

            migrationBuilder.DropTable(
                name: "CoreMessaging_SubscriptionTypes");

            migrationBuilder.DropTable(
                name: "PortalDesktopModules");

            migrationBuilder.DropTable(
                name: "EventLog");

            migrationBuilder.DropTable(
                name: "ExportImportJobs");

            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DropTable(
                name: "HtmlText");

            migrationBuilder.DropTable(
                name: "Journal");

            migrationBuilder.DropTable(
                name: "Mobile_Redirections");

            migrationBuilder.DropTable(
                name: "PersonaBarPermission");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Schedule");

            migrationBuilder.DropTable(
                name: "vSkinPackages");

            migrationBuilder.DropTable(
                name: "TabModules");

            migrationBuilder.DropTable(
                name: "TabVersions");

            migrationBuilder.DropTable(
                name: "UrlTracking");

            migrationBuilder.DropTable(
                name: "ProfilePropertyDefinition");

            migrationBuilder.DropTable(
                name: "Relationships");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Taxonomy_Vocabularies");

            migrationBuilder.DropTable(
                name: "CoreMessaging_NotificationTypes");

            migrationBuilder.DropTable(
                name: "EventLogConfig");

            migrationBuilder.DropTable(
                name: "Folders");

            migrationBuilder.DropTable(
                name: "WorkflowStates");

            migrationBuilder.DropTable(
                name: "Journal_Types");

            migrationBuilder.DropTable(
                name: "PersonaBarMenu");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropTable(
                name: "Tabs");

            migrationBuilder.DropTable(
                name: "RelationshipTypes");

            migrationBuilder.DropTable(
                name: "RoleGroups");

            migrationBuilder.DropTable(
                name: "Taxonomy_ScopeTypes");

            migrationBuilder.DropTable(
                name: "Taxonomy_VocabularyTypes");

            migrationBuilder.DropTable(
                name: "EventLogTypes");

            migrationBuilder.DropTable(
                name: "ContentWorkflowStatePermission");

            migrationBuilder.DropTable(
                name: "FolderMappings");

            migrationBuilder.DropTable(
                name: "Workflow");

            migrationBuilder.DropTable(
                name: "ModuleDefinitions");

            migrationBuilder.DropTable(
                name: "ContentItems");

            migrationBuilder.DropTable(
                name: "Permission");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Portals");

            migrationBuilder.DropTable(
                name: "DesktopModules");

            migrationBuilder.DropTable(
                name: "ContentWorkflowStates");

            migrationBuilder.DropTable(
                name: "Packages");

            migrationBuilder.DropTable(
                name: "ContentWorkflows");

            migrationBuilder.DropTable(
                name: "PackageType");

            migrationBuilder.DropTable(
                name: "ContentType");
        }
    }
}
