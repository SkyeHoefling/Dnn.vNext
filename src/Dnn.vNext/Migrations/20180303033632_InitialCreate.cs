using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Dnn.vNext.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "aspnet_Applications",
                columns: table => new
                {
                    ApplicationId = table.Column<Guid>(nullable: false, defaultValueSql: "newId()"),
                    ApplicationName = table.Column<string>(maxLength: 256, nullable: false),
                    Description = table.Column<string>(maxLength: 256, nullable: true),
                    LoweredApplicationName = table.Column<string>(maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aspnet_Applications", x => x.ApplicationId);
                });

            migrationBuilder.CreateTable(
                name: "aspnet_SchemaVersions",
                columns: table => new
                {
                    Feature = table.Column<string>(maxLength: 125, nullable: false),
                    CompatibleSchemaVersion = table.Column<string>(maxLength: 128, nullable: false),
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
                    SettingName = table.Column<string>(maxLength: 300, nullable: false),
                    SettingValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CKE_Settings", x => x.SettingName);
                });

            migrationBuilder.CreateTable(
                name: "ContentTypes",
                columns: table => new
                {
                    ContentTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContentType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentTypes", x => x.ContentTypeId);
                });

            migrationBuilder.CreateTable(
                name: "ContentWorkflowActions",
                columns: table => new
                {
                    ActionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ActionSource = table.Column<string>(nullable: true),
                    ActionType = table.Column<string>(nullable: true),
                    ContentTypeId = table.Column<int>(nullable: false),
                    ContentWorkflowActionActionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentWorkflowActions", x => x.ActionId);
                    table.ForeignKey(
                        name: "FK_ContentWorkflowActions_ContentWorkflowActions_ContentWorkflowActionActionId",
                        column: x => x.ContentWorkflowActionActionId,
                        principalTable: "ContentWorkflowActions",
                        principalColumn: "ActionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CoreMessaging_SubscriptionTypes",
                columns: table => new
                {
                    SubscriptionTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DesktopModuleId = table.Column<int>(nullable: true),
                    FriendlyName = table.Column<string>(maxLength: 50, nullable: false),
                    SubscriptionName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoreMessaging_SubscriptionTypes", x => x.SubscriptionTypeId);
                });

            migrationBuilder.CreateTable(
                name: "CoreMessaging_UserPreferences",
                columns: table => new
                {
                    UserPreferenceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MessagesEmailFrequency = table.Column<int>(nullable: false),
                    NotificationsEmailFrequency = table.Column<int>(nullable: false),
                    PortalId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoreMessaging_UserPreferences", x => x.UserPreferenceId);
                });

            migrationBuilder.CreateTable(
                name: "EventLogTypes",
                columns: table => new
                {
                    LogTypeKey = table.Column<string>(maxLength: 35, nullable: false),
                    LogTypeCSSClass = table.Column<string>(maxLength: 40, nullable: false),
                    LogTypeDescription = table.Column<string>(maxLength: 128, nullable: false),
                    LogTypeFriendlyName = table.Column<string>(maxLength: 50, nullable: false),
                    LogTypeOwner = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventLogTypes", x => x.LogTypeKey);
                });

            migrationBuilder.CreateTable(
                name: "EventQueue",
                columns: table => new
                {
                    EventMessageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Attributes = table.Column<string>(nullable: true),
                    AuthorizedRoles = table.Column<string>(maxLength: 250, nullable: false),
                    Body = table.Column<string>(maxLength: 250, nullable: false),
                    EventName = table.Column<string>(maxLength: 100, nullable: false),
                    ExceptionMessage = table.Column<string>(maxLength: 250, nullable: false),
                    ExpirationDate = table.Column<DateTime>(nullable: false),
                    IsComplete = table.Column<bool>(nullable: false),
                    Priority = table.Column<int>(nullable: false),
                    ProcessorCommand = table.Column<string>(maxLength: 250, nullable: false),
                    ProcessorType = table.Column<string>(maxLength: 250, nullable: false),
                    Sender = table.Column<string>(maxLength: 250, nullable: false),
                    SentDate = table.Column<DateTime>(nullable: false),
                    Subscriber = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventQueue", x => x.EventMessageId);
                });

            migrationBuilder.CreateTable(
                name: "Exceptions",
                columns: table => new
                {
                    ExceptionHash = table.Column<string>(maxLength: 100, nullable: false),
                    InnerMessage = table.Column<string>(maxLength: 500, nullable: true),
                    InnerStackTrace = table.Column<string>(nullable: true),
                    Message = table.Column<string>(maxLength: 500, nullable: false),
                    Source = table.Column<string>(maxLength: 500, nullable: true),
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
                    CreatedByUserId = table.Column<int>(nullable: false),
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
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    SettingIsSecure = table.Column<bool>(nullable: false),
                    SettingValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExportImportSettings", x => x.SettingName);
                });

            migrationBuilder.CreateTable(
                name: "ExtensionUrlProvIderConfiguration",
                columns: table => new
                {
                    ExtensionUrlProvIderId = table.Column<int>(nullable: false),
                    PortalId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtensionUrlProvIderConfiguration", x => new { x.ExtensionUrlProvIderId, x.PortalId });
                });

            migrationBuilder.CreateTable(
                name: "ExtensionUrlProvIders",
                columns: table => new
                {
                    ExtensionUrlProvIderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DekstopModuleId = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    ProvIderName = table.Column<string>(nullable: true),
                    ProvIderType = table.Column<string>(nullable: true),
                    RedirectAllUrls = table.Column<bool>(nullable: false),
                    ReplaceAllUrls = table.Column<bool>(nullable: false),
                    RewriteAllUrls = table.Column<bool>(nullable: false),
                    SettingsControlSrc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtensionUrlProvIders", x => x.ExtensionUrlProvIderId);
                });

            migrationBuilder.CreateTable(
                name: "ExtensionUrlProvIderSetting",
                columns: table => new
                {
                    ExtensionUrlProvIderId = table.Column<int>(nullable: false),
                    PortalId = table.Column<int>(nullable: false),
                    SettingName = table.Column<string>(nullable: false),
                    SettingValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtensionUrlProvIderSetting", x => new { x.ExtensionUrlProvIderId, x.PortalId, x.SettingName });
                });

            migrationBuilder.CreateTable(
                name: "ExtensionUrlProvIderTab",
                columns: table => new
                {
                    ExtensionUrlProvIderId = table.Column<int>(nullable: false),
                    PortalId = table.Column<int>(nullable: false),
                    TabId = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtensionUrlProvIderTab", x => new { x.ExtensionUrlProvIderId, x.PortalId, x.TabId });
                });

            migrationBuilder.CreateTable(
                name: "HostSettings",
                columns: table => new
                {
                    SettingName = table.Column<string>(nullable: false),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
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
                    IPFilterId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    IPAddress = table.Column<string>(nullable: true),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    RuleType = table.Column<int>(nullable: true),
                    SubnetMask = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IPFilter", x => x.IPFilterId);
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
                    LanguageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    CultureCode = table.Column<string>(nullable: true),
                    CultureName = table.Column<string>(nullable: true),
                    FallbackCulture = table.Column<string>(nullable: true),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.LanguageId);
                });

            migrationBuilder.CreateTable(
                name: "Lists",
                columns: table => new
                {
                    EntryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    DefinitionId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    Level = table.Column<int>(nullable: false),
                    ListName = table.Column<string>(nullable: true),
                    ParentId = table.Column<int>(nullable: false),
                    PortalId = table.Column<int>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    SystemList = table.Column<bool>(nullable: false),
                    Text = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lists", x => x.EntryId);
                });

            migrationBuilder.CreateTable(
                name: "Messaging_Messages",
                columns: table => new
                {
                    MessageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AllowReply = table.Column<bool>(nullable: false),
                    Body = table.Column<string>(nullable: true),
                    Conversation = table.Column<Guid>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    EmailSchedulerInstance = table.Column<Guid>(nullable: true),
                    EmailSent = table.Column<bool>(nullable: false),
                    EmailSentDate = table.Column<DateTime>(nullable: true),
                    FromUserId = table.Column<int>(nullable: false),
                    FromUserName = table.Column<string>(nullable: true),
                    PortalId = table.Column<int>(nullable: false),
                    ReplyTo = table.Column<int>(nullable: true),
                    SkipPortal = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Subject = table.Column<string>(nullable: true),
                    ToRoleId = table.Column<int>(nullable: false),
                    ToUserId = table.Column<int>(nullable: false),
                    ToUserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messaging_Messages", x => x.MessageId);
                });

            migrationBuilder.CreateTable(
                name: "MetaData",
                columns: table => new
                {
                    MetaDataId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MetaDataDescription = table.Column<string>(nullable: true),
                    MetaDataName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetaData", x => x.MetaDataId);
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
                    SupportsSIdeBySIdeInstallation = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageType", x => x.PackageType);
                });

            migrationBuilder.CreateTable(
                name: "Permission",
                columns: table => new
                {
                    PermissionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    ModuleDefId = table.Column<int>(nullable: false),
                    PermissionCode = table.Column<string>(nullable: true),
                    PermissionKey = table.Column<string>(nullable: true),
                    PermissionName = table.Column<string>(nullable: true),
                    ViewOrder = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permission", x => x.PermissionId);
                });

            migrationBuilder.CreateTable(
                name: "PersonaBarMenu",
                columns: table => new
                {
                    MenuId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AllowHost = table.Column<bool>(nullable: false),
                    Controller = table.Column<string>(nullable: true),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    CssClass = table.Column<string>(nullable: true),
                    Enabled = table.Column<bool>(nullable: false),
                    FolderName = table.Column<string>(nullable: true),
                    Identifier = table.Column<string>(nullable: true),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    Link = table.Column<string>(nullable: true),
                    ModuleName = table.Column<string>(nullable: true),
                    Order = table.Column<int>(nullable: false),
                    ParentId = table.Column<int>(nullable: true),
                    Path = table.Column<string>(nullable: true),
                    ResourceKey = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonaBarMenu", x => x.MenuId);
                    table.ForeignKey(
                        name: "FK_PersonaBarMenu_PersonaBarMenu_ParentId",
                        column: x => x.ParentId,
                        principalTable: "PersonaBarMenu",
                        principalColumn: "MenuId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PortalGroups",
                columns: table => new
                {
                    ProtalGroupId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AuthenticationDomain = table.Column<string>(nullable: true),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    MasterPortalId = table.Column<int>(nullable: true),
                    PortalGroupDescription = table.Column<string>(nullable: true),
                    PortalGroupName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortalGroups", x => x.ProtalGroupId);
                });

            migrationBuilder.CreateTable(
                name: "Portals",
                columns: table => new
                {
                    PortalId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AdministratorId = table.Column<int>(nullable: true),
                    AdministratorRoleId = table.Column<int>(nullable: true),
                    BannerAdvertising = table.Column<int>(nullable: false),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    Currency = table.Column<string>(nullable: true),
                    DefaultLanguage = table.Column<string>(nullable: true),
                    ExpiryDate = table.Column<DateTime>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    HomeDirectory = table.Column<string>(nullable: true),
                    HostFee = table.Column<decimal>(nullable: false),
                    HostSpace = table.Column<int>(nullable: false),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
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
                    table.PrimaryKey("PK_Portals", x => x.PortalId);
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
                    RelationshipTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Direction = table.Column<int>(nullable: false),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelationshipTypes", x => x.RelationshipTypeId);
                });

            migrationBuilder.CreateTable(
                name: "RoleSettings",
                columns: table => new
                {
                    RoleSettingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    RoleId = table.Column<int>(nullable: false),
                    SettingName = table.Column<string>(nullable: true),
                    SettingValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleSettings", x => x.RoleSettingId);
                });

            migrationBuilder.CreateTable(
                name: "Schedule",
                columns: table => new
                {
                    ScheduleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AttachToEvent = table.Column<string>(nullable: true),
                    CatchUpEnabled = table.Column<bool>(nullable: false),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    Enabled = table.Column<bool>(nullable: false),
                    FriendlyName = table.Column<string>(nullable: true),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
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
                    table.PrimaryKey("PK_Schedule", x => x.ScheduleId);
                });

            migrationBuilder.CreateTable(
                name: "SearchCommonWords",
                columns: table => new
                {
                    CommonWordId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CommonWord = table.Column<string>(nullable: true),
                    Locale = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SearchCommonWords", x => x.CommonWordId);
                });

            migrationBuilder.CreateTable(
                name: "SearchDeletedItems",
                columns: table => new
                {
                    SearchDeletedItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    Document = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SearchDeletedItems", x => x.SearchDeletedItemId);
                });

            migrationBuilder.CreateTable(
                name: "SearchIndexer",
                columns: table => new
                {
                    SearchIndexerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SearchIndexerAssemblyQualifiedName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SearchIndexer", x => x.SearchIndexerId);
                });

            migrationBuilder.CreateTable(
                name: "SearchStopWords",
                columns: table => new
                {
                    StopWordsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    CultureCode = table.Column<string>(nullable: true),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    PortalId = table.Column<int>(nullable: true),
                    StopWords = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SearchStopWords", x => x.StopWordsId);
                });

            migrationBuilder.CreateTable(
                name: "SearchTypes",
                columns: table => new
                {
                    SearchTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsPrivate = table.Column<bool>(nullable: true),
                    SearchResultClass = table.Column<string>(nullable: true),
                    SearchTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SearchTypes", x => x.SearchTypeId);
                });

            migrationBuilder.CreateTable(
                name: "SQLQueries",
                columns: table => new
                {
                    QueryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ConnectionStringName = table.Column<string>(nullable: true),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
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
                    SynonymsGroupId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    CultureCode = table.Column<string>(nullable: true),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    PortalId = table.Column<int>(nullable: false),
                    SynonymsTags = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SynonymsGroups", x => x.SynonymsGroupId);
                });

            migrationBuilder.CreateTable(
                name: "TabAliasSkins",
                columns: table => new
                {
                    TabAliasSkinId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
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
                    ScopeTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ScopeType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taxonomy_ScopeTypes", x => x.ScopeTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Taxonomy_VocabularyTypes",
                columns: table => new
                {
                    VocabularyTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VocabularyType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taxonomy_VocabularyTypes", x => x.VocabularyTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AffiliateId = table.Column<int>(nullable: true),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    DisplayName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsSuperUser = table.Column<bool>(nullable: false),
                    LastIPAddress = table.Column<string>(nullable: true),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
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
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Version",
                columns: table => new
                {
                    VersionId = table.Column<int>(nullable: false)
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
                    table.PrimaryKey("PK_Version", x => x.VersionId);
                });

            migrationBuilder.CreateTable(
                name: "WebServers",
                columns: table => new
                {
                    ServerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Enabled = table.Column<bool>(nullable: false),
                    IISAppName = table.Column<string>(nullable: true),
                    LastActivityDate = table.Column<DateTime>(nullable: false),
                    PingFailureCount = table.Column<int>(nullable: false),
                    ServerGroup = table.Column<string>(nullable: true),
                    ServerName = table.Column<string>(nullable: true),
                    URL = table.Column<string>(nullable: true),
                    UniqueId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebServers", x => x.ServerId);
                });

            migrationBuilder.CreateTable(
                name: "Workflow",
                columns: table => new
                {
                    WorkflowId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    PortalId = table.Column<int>(nullable: true),
                    WorkflowName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workflow", x => x.WorkflowId);
                });

            migrationBuilder.CreateTable(
                name: "aspnet_Membership",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    ApplicationId = table.Column<Guid>(nullable: false),
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
                    table.PrimaryKey("PK_aspnet_Membership", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_aspnet_Membership_aspnet_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "aspnet_Applications",
                        principalColumn: "ApplicationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "aspnet_Users",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false, defaultValueSql: "newId()"),
                    ApplicationId = table.Column<Guid>(nullable: false),
                    IsAnonymous = table.Column<bool>(nullable: false, defaultValue: false),
                    LastActivityDate = table.Column<DateTime>(nullable: false),
                    LoweredUserName = table.Column<string>(maxLength: 256, nullable: false),
                    MobileAlias = table.Column<string>(maxLength: 16, nullable: true, defaultValueSql: "null"),
                    UserName = table.Column<string>(maxLength: 256, nullable: false)
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
                    WorkflowId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Content_TypeContentTypeId = table.Column<int>(nullable: true),
                    Description = table.Column<string>(maxLength: 256, nullable: true),
                    DispositionEnabled = table.Column<bool>(nullable: false, defaultValue: false),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    IsSystem = table.Column<bool>(nullable: false, defaultValue: false),
                    PortalId = table.Column<int>(nullable: true),
                    StartAfterCreating = table.Column<bool>(nullable: false, defaultValue: true),
                    StartAfterEditing = table.Column<bool>(nullable: false, defaultValue: true),
                    WorkflowKey = table.Column<string>(maxLength: 40, nullable: false, defaultValueSql: "''"),
                    WorkflowName = table.Column<string>(maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentWorkflows", x => x.WorkflowId);
                    table.ForeignKey(
                        name: "FK_ContentWorkflows_ContentTypes_Content_TypeContentTypeId",
                        column: x => x.Content_TypeContentTypeId,
                        principalTable: "ContentTypes",
                        principalColumn: "ContentTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EventLogConfig",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmailNotificaitonIsActive = table.Column<bool>(nullable: false),
                    KeepMostRecent = table.Column<int>(nullable: false),
                    LogTypeKey = table.Column<string>(maxLength: 35, nullable: true),
                    LogTypePortalId = table.Column<int>(nullable: false),
                    LoggingIsActive = table.Column<bool>(nullable: false),
                    MailFromAddress = table.Column<string>(maxLength: 50, nullable: false),
                    MailToAddress = table.Column<string>(maxLength: 50, nullable: false),
                    NotificationThreshold = table.Column<int>(nullable: true),
                    NotificationThresholdTime = table.Column<int>(nullable: true),
                    NotificationThresholdTimeType = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventLogConfig", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventLogConfig_EventLogTypes_LogTypeKey",
                        column: x => x.LogTypeKey,
                        principalTable: "EventLogTypes",
                        principalColumn: "LogTypeKey",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExportImportCheckpoints",
                columns: table => new
                {
                    CheckpointId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssemblyName = table.Column<string>(maxLength: 200, nullable: false),
                    Category = table.Column<string>(maxLength: 50, nullable: false),
                    Completed = table.Column<bool>(nullable: false, defaultValue: false),
                    JobId = table.Column<int>(nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(nullable: true),
                    ProcessedItems = table.Column<int>(nullable: false, defaultValue: 0),
                    Progress = table.Column<int>(nullable: false),
                    Stage = table.Column<int>(nullable: false),
                    StageData = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: true),
                    TotalItems = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExportImportCheckpoints", x => x.CheckpointId);
                    table.ForeignKey(
                        name: "FK_ExportImportCheckpoints_ExportImportJobs_JobId",
                        column: x => x.JobId,
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
                    CreatedOnDate = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    JobId = table.Column<int>(nullable: false),
                    Level = table.Column<int>(nullable: false, defaultValue: 0),
                    Name = table.Column<string>(maxLength: 255, nullable: true),
                    Value = table.Column<string>(maxLength: 255, nullable: true)
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
                    CommentsHIdden = table.Column<bool>(nullable: false),
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
                    PackageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    FolderName = table.Column<string>(nullable: true),
                    FriendlyName = table.Column<string>(nullable: true),
                    IconFile = table.Column<string>(nullable: true),
                    IsSystemPackage = table.Column<bool>(nullable: false),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    License = table.Column<string>(nullable: true),
                    Manifest = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Organization = table.Column<string>(nullable: true),
                    Owner = table.Column<string>(nullable: true),
                    PackageType = table.Column<string>(nullable: true),
                    PackageTypeNavigationPackageId = table.Column<int>(nullable: true),
                    PortalId = table.Column<int>(nullable: true),
                    ReleaseNotes = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    Version = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packages", x => x.PackageId);
                    table.ForeignKey(
                        name: "FK_Packages_PackageType_PackageType",
                        column: x => x.PackageType,
                        principalTable: "PackageType",
                        principalColumn: "PackageType",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Packages_Packages_PackageTypeNavigationPackageId",
                        column: x => x.PackageTypeNavigationPackageId,
                        principalTable: "Packages",
                        principalColumn: "PackageId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PersonaBarExtensions",
                columns: table => new
                {
                    ExtensionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Container = table.Column<string>(nullable: true),
                    Controller = table.Column<string>(nullable: true),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    Enabled = table.Column<bool>(nullable: false),
                    FolderName = table.Column<string>(nullable: true),
                    Identifier = table.Column<string>(nullable: true),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    MenuId = table.Column<int>(nullable: false),
                    Order = table.Column<int>(nullable: false),
                    Path = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonaBarExtensions", x => x.ExtensionId);
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
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
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
                    UserId = table.Column<string>(type: "char(36)", maxLength: 36, nullable: false),
                    PortalId = table.Column<int>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()"),
                    LastActiveDate = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()"),
                    TabId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnonymousUsers", x => new { x.UserId, x.PortalId });
                    table.ForeignKey(
                        name: "FK_AnonymousUsers_Portals_PortalId",
                        column: x => x.PortalId,
                        principalTable: "Portals",
                        principalColumn: "PortalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FolderMappings",
                columns: table => new
                {
                    FolderMappingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    FolderProvIderType = table.Column<string>(nullable: true),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    MappingName = table.Column<string>(nullable: true),
                    PortalId = table.Column<int>(nullable: true),
                    Priority = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FolderMappings", x => x.FolderMappingId);
                    table.ForeignKey(
                        name: "FK_FolderMappings_Portals_PortalId",
                        column: x => x.PortalId,
                        principalTable: "Portals",
                        principalColumn: "PortalId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mobile_PreviewProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    Height = table.Column<int>(nullable: false),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PortalId = table.Column<int>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    UserAgent = table.Column<string>(nullable: true),
                    WIdth = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mobile_PreviewProfiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mobile_PreviewProfiles_Portals_PortalId",
                        column: x => x.PortalId,
                        principalTable: "Portals",
                        principalColumn: "PortalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mobile_Redirections",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    Enabled = table.Column<bool>(nullable: false),
                    IncludeChildTabs = table.Column<bool>(nullable: false),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
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
                        principalColumn: "PortalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PortalAlias",
                columns: table => new
                {
                    PortalAliasId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BrowserType = table.Column<string>(nullable: true),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    CulturCode = table.Column<string>(nullable: true),
                    HTTPAlias = table.Column<string>(nullable: true),
                    IsPrimary = table.Column<bool>(nullable: false),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    PortalId = table.Column<int>(nullable: false),
                    Skin = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortalAlias", x => x.PortalAliasId);
                    table.ForeignKey(
                        name: "FK_PortalAlias_Portals_PortalId",
                        column: x => x.PortalId,
                        principalTable: "Portals",
                        principalColumn: "PortalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PortalLanguages",
                columns: table => new
                {
                    PortalLanguageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    IsPublished = table.Column<bool>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    PortalId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortalLanguages", x => x.PortalLanguageId);
                    table.ForeignKey(
                        name: "FK_PortalLanguages_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PortalLanguages_Portals_PortalId",
                        column: x => x.PortalId,
                        principalTable: "Portals",
                        principalColumn: "PortalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PortalLocalization",
                columns: table => new
                {
                    PortalId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AdminTabId = table.Column<int>(nullable: true),
                    BackgroundFile = table.Column<string>(nullable: true),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    CultureCode = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    FooterText = table.Column<string>(nullable: true),
                    HomeTabId = table.Column<int>(nullable: true),
                    KeyWords = table.Column<string>(nullable: true),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    LoginTabId = table.Column<int>(nullable: true),
                    LogoFile = table.Column<string>(nullable: true),
                    PortalId1 = table.Column<int>(nullable: true),
                    PortalName = table.Column<string>(nullable: true),
                    SplashTabId = table.Column<int>(nullable: true),
                    UserTabId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortalLocalization", x => x.PortalId);
                    table.ForeignKey(
                        name: "FK_PortalLocalization_Portals_PortalId1",
                        column: x => x.PortalId1,
                        principalTable: "Portals",
                        principalColumn: "PortalId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PortalSettings",
                columns: table => new
                {
                    PortalSettingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    CultureCode = table.Column<string>(nullable: true),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    PortalId = table.Column<int>(nullable: false),
                    SettingName = table.Column<string>(nullable: true),
                    SettingValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortalSettings", x => x.PortalSettingId);
                    table.ForeignKey(
                        name: "FK_PortalSettings_Portals_PortalId",
                        column: x => x.PortalId,
                        principalTable: "Portals",
                        principalColumn: "PortalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfilePropertyDefinition",
                columns: table => new
                {
                    PropertyDefinitionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    DataType = table.Column<int>(nullable: false),
                    DefaultValue = table.Column<string>(nullable: true),
                    DefaultVisibility = table.Column<int>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    Length = table.Column<int>(nullable: false),
                    ModuleDefId = table.Column<int>(nullable: true),
                    PortalId = table.Column<int>(nullable: true),
                    PropertyCategory = table.Column<string>(nullable: true),
                    PropertyName = table.Column<string>(nullable: true),
                    ReadOnly = table.Column<bool>(nullable: false),
                    Required = table.Column<bool>(nullable: false),
                    ValIdationExpression = table.Column<string>(nullable: true),
                    ViewOrder = table.Column<int>(nullable: false),
                    Visible = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfilePropertyDefinition", x => x.PropertyDefinitionId);
                    table.ForeignKey(
                        name: "FK_ProfilePropertyDefinition_Portals_PortalId",
                        column: x => x.PortalId,
                        principalTable: "Portals",
                        principalColumn: "PortalId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoleGroups",
                columns: table => new
                {
                    RoleGroupId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    PortalId = table.Column<int>(nullable: false),
                    RoleGroupName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleGroups", x => x.RoleGroupId);
                    table.ForeignKey(
                        name: "FK_RoleGroups_Portals_PortalId",
                        column: x => x.PortalId,
                        principalTable: "Portals",
                        principalColumn: "PortalId",
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
                    PortalId = table.Column<int>(nullable: false),
                    Referrer = table.Column<string>(nullable: true),
                    TabId = table.Column<int>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    UserAgent = table.Column<string>(nullable: true),
                    UserHostAddress = table.Column<string>(nullable: true),
                    UserHostName = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteLog", x => x.SiteLogId);
                    table.ForeignKey(
                        name: "FK_SiteLog_Portals_PortalId",
                        column: x => x.PortalId,
                        principalTable: "Portals",
                        principalColumn: "PortalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SystemMessages",
                columns: table => new
                {
                    MessageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MessageName = table.Column<string>(nullable: true),
                    MessageValue = table.Column<string>(nullable: true),
                    PortalId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemMessages", x => x.MessageId);
                    table.ForeignKey(
                        name: "FK_SystemMessages_Portals_PortalId",
                        column: x => x.PortalId,
                        principalTable: "Portals",
                        principalColumn: "PortalId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Urls",
                columns: table => new
                {
                    UrlId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PortalId = table.Column<int>(nullable: true),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urls", x => x.UrlId);
                    table.ForeignKey(
                        name: "FK_Urls_Portals_PortalId",
                        column: x => x.PortalId,
                        principalTable: "Portals",
                        principalColumn: "PortalId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UrlTracking",
                columns: table => new
                {
                    UrlTrackingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Clicks = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastClick = table.Column<DateTime>(nullable: true),
                    LogActivity = table.Column<bool>(nullable: false),
                    ModuleId = table.Column<int>(nullable: true),
                    NewWindow = table.Column<bool>(nullable: false),
                    PortalId = table.Column<int>(nullable: true),
                    TrackClicks = table.Column<bool>(nullable: false),
                    Url = table.Column<string>(nullable: true),
                    UrlType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrlTracking", x => x.UrlTrackingId);
                    table.ForeignKey(
                        name: "FK_UrlTracking_Portals_PortalId",
                        column: x => x.PortalId,
                        principalTable: "Portals",
                        principalColumn: "PortalId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleHistory",
                columns: table => new
                {
                    ScheduleHistoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EndDate = table.Column<DateTime>(nullable: false),
                    LogNotes = table.Column<string>(nullable: true),
                    NextStart = table.Column<DateTime>(nullable: true),
                    ScheduleId = table.Column<int>(nullable: false),
                    Server = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    Succeeded = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleHistory", x => x.ScheduleHistoryId);
                    table.ForeignKey(
                        name: "FK_ScheduleHistory_Schedule_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedule",
                        principalColumn: "ScheduleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleItemSettings",
                columns: table => new
                {
                    ScheduleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ScheduleId1 = table.Column<int>(nullable: true),
                    SettingName = table.Column<string>(nullable: true),
                    SettingValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleItemSettings", x => x.ScheduleId);
                    table.ForeignKey(
                        name: "FK_ScheduleItemSettings_Schedule_ScheduleId1",
                        column: x => x.ScheduleId1,
                        principalTable: "Schedule",
                        principalColumn: "ScheduleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Taxonomy_Vocabularies",
                columns: table => new
                {
                    VocabularyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ScopeId = table.Column<int>(nullable: true),
                    ScopeTypeId = table.Column<int>(nullable: false),
                    VocabularyTypeId = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taxonomy_Vocabularies", x => x.VocabularyId);
                    table.ForeignKey(
                        name: "FK_Taxonomy_Vocabularies_Taxonomy_ScopeTypes_ScopeTypeId",
                        column: x => x.ScopeTypeId,
                        principalTable: "Taxonomy_ScopeTypes",
                        principalColumn: "ScopeTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Taxonomy_Vocabularies_Taxonomy_VocabularyTypes_VocabularyTypeId",
                        column: x => x.VocabularyTypeId,
                        principalTable: "Taxonomy_VocabularyTypes",
                        principalColumn: "VocabularyTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PasswordHistory",
                columns: table => new
                {
                    PasswordHistoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    PasswordSalt = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PasswordHistory", x => x.PasswordHistoryId);
                    table.ForeignKey(
                        name: "FK_PasswordHistory_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
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
                        principalColumn: "PortalId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Profile_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Relationships",
                columns: table => new
                {
                    RelationshipId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    DefaultResponse = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PortalId = table.Column<int>(nullable: true),
                    RelationshipTypeId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relationships", x => x.RelationshipId);
                    table.ForeignKey(
                        name: "FK_Relationships_Portals_PortalId",
                        column: x => x.PortalId,
                        principalTable: "Portals",
                        principalColumn: "PortalId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Relationships_RelationshipTypes_RelationshipTypeId",
                        column: x => x.RelationshipTypeId,
                        principalTable: "RelationshipTypes",
                        principalColumn: "RelationshipTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Relationships_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserAuthentication",
                columns: table => new
                {
                    UserAuthenticationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AuthenticaitonToken = table.Column<string>(nullable: true),
                    AuthenticationType = table.Column<string>(nullable: true),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAuthentication", x => x.UserAuthenticationId);
                    table.ForeignKey(
                        name: "FK_UserAuthentication_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserPortals",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Authorized = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    PortalId = table.Column<int>(nullable: false),
                    RefreshRoles = table.Column<bool>(nullable: false),
                    UserId1 = table.Column<int>(nullable: true),
                    UserPortalId = table.Column<int>(nullable: false),
                    VanityUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPortals", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_UserPortals_Portals_PortalId",
                        column: x => x.PortalId,
                        principalTable: "Portals",
                        principalColumn: "PortalId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPortals_Users_UserId1",
                        column: x => x.UserId1,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UsersOnline",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastActiveDate = table.Column<DateTime>(nullable: false),
                    PortalId = table.Column<int>(nullable: false),
                    TabId = table.Column<int>(nullable: false),
                    UserId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersOnline", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_UsersOnline_Portals_PortalId",
                        column: x => x.PortalId,
                        principalTable: "Portals",
                        principalColumn: "PortalId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsersOnline_Users_UserId1",
                        column: x => x.UserId1,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WorkflowStates",
                columns: table => new
                {
                    StateId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsActive = table.Column<bool>(nullable: false),
                    Notify = table.Column<bool>(nullable: false),
                    Order = table.Column<bool>(nullable: false),
                    StateName = table.Column<string>(nullable: true),
                    WorkflowId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkflowStates", x => x.StateId);
                    table.ForeignKey(
                        name: "FK_WorkflowStates_Workflow_WorkflowId",
                        column: x => x.WorkflowId,
                        principalTable: "Workflow",
                        principalColumn: "WorkflowId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContentWorkflowSources",
                columns: table => new
                {
                    SourceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SourceName = table.Column<string>(maxLength: 20, nullable: false),
                    SourceType = table.Column<string>(maxLength: 250, nullable: false),
                    WorkflowId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentWorkflowSources", x => x.SourceId);
                    table.ForeignKey(
                        name: "FK_ContentWorkflowSources_ContentWorkflows_WorkflowId",
                        column: x => x.WorkflowId,
                        principalTable: "ContentWorkflows",
                        principalColumn: "WorkflowId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContentWorkflowStates",
                columns: table => new
                {
                    StateId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsActive = table.Column<bool>(nullable: false, defaultValue: true),
                    IsDisposalState = table.Column<bool>(nullable: false, defaultValue: false),
                    IsSystem = table.Column<bool>(nullable: false, defaultValue: false),
                    OnCompleteMessageBody = table.Column<string>(maxLength: 1024, nullable: false, defaultValueSql: "''"),
                    OnCompleteMessageSubject = table.Column<string>(maxLength: 256, nullable: false, defaultValueSql: "''"),
                    OnDiscardMessageBody = table.Column<string>(maxLength: 1024, nullable: false, defaultValueSql: "''"),
                    OnDiscardMessageSubject = table.Column<string>(maxLength: 256, nullable: false, defaultValueSql: "''"),
                    Order = table.Column<int>(nullable: false),
                    SendEmail = table.Column<bool>(nullable: false, defaultValue: false),
                    SendMessage = table.Column<bool>(nullable: false, defaultValue: false),
                    SendNotification = table.Column<bool>(nullable: false, defaultValue: true),
                    SendNotificationToAdministrators = table.Column<bool>(nullable: false, defaultValue: true),
                    StateName = table.Column<string>(maxLength: 40, nullable: false),
                    WorkflowId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentWorkflowStates", x => x.StateId);
                    table.ForeignKey(
                        name: "FK_ContentWorkflowStates_ContentWorkflows_WorkflowId",
                        column: x => x.WorkflowId,
                        principalTable: "ContentWorkflows",
                        principalColumn: "WorkflowId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventLog",
                columns: table => new
                {
                    LogEventId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EventLogConfigId = table.Column<int>(nullable: true),
                    ExceptionHash = table.Column<string>(maxLength: 100, nullable: true),
                    LogConfigId = table.Column<int>(nullable: false),
                    LogConfigLogEventId = table.Column<long>(nullable: true),
                    LogCreateDate = table.Column<DateTime>(nullable: false),
                    LogGuid = table.Column<string>(maxLength: 36, nullable: false),
                    LogNotificationPending = table.Column<bool>(nullable: true),
                    LogPortalId = table.Column<int>(nullable: true),
                    LogPortalName = table.Column<string>(maxLength: 100, nullable: true),
                    LogProperties = table.Column<string>(type: "xml", nullable: true),
                    LogServerName = table.Column<string>(maxLength: 50, nullable: false),
                    LogTypeKey = table.Column<string>(maxLength: 35, nullable: false),
                    LogUserId = table.Column<int>(nullable: true),
                    LogUserName = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventLog", x => x.LogEventId);
                    table.ForeignKey(
                        name: "FK_EventLog_EventLogConfig_EventLogConfigId",
                        column: x => x.EventLogConfigId,
                        principalTable: "EventLogConfig",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EventLog_EventLog_LogConfigLogEventId",
                        column: x => x.LogConfigLogEventId,
                        principalTable: "EventLog",
                        principalColumn: "LogEventId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EventLog_EventLogTypes_LogTypeKey",
                        column: x => x.LogTypeKey,
                        principalTable: "EventLogTypes",
                        principalColumn: "LogTypeKey",
                        onDelete: ReferentialAction.Cascade);
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
                    AssemblyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssemblyName = table.Column<string>(maxLength: 250, nullable: false),
                    PackageId = table.Column<int>(nullable: true),
                    Version = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assemblies", x => x.AssemblyId);
                    table.ForeignKey(
                        name: "FK_Assemblies_Packages_PackageId",
                        column: x => x.PackageId,
                        principalTable: "Packages",
                        principalColumn: "PackageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Authentication",
                columns: table => new
                {
                    AuthenticationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AuthenticationType = table.Column<string>(maxLength: 100, nullable: false),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    IsEnabled = table.Column<bool>(nullable: false, defaultValue: false),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    LoginControlSrc = table.Column<string>(maxLength: 250, nullable: false),
                    LogoffControlSrc = table.Column<string>(maxLength: 250, nullable: false),
                    PackageId = table.Column<int>(nullable: false, defaultValue: -1),
                    SettignsControlSrc = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authentication", x => x.AuthenticationId);
                    table.ForeignKey(
                        name: "FK_Authentication_Packages_PackageId",
                        column: x => x.PackageId,
                        principalTable: "Packages",
                        principalColumn: "PackageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DesktopModules",
                columns: table => new
                {
                    DesktopModuleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AdminPage = table.Column<string>(maxLength: 128, nullable: true),
                    BusinessControllerClass = table.Column<string>(maxLength: 200, nullable: true),
                    CompatibleVersions = table.Column<string>(maxLength: 500, nullable: true),
                    ContentItemId = table.Column<int>(nullable: false, defaultValue: -1),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    Dependencies = table.Column<string>(maxLength: 400, nullable: true),
                    Description = table.Column<string>(maxLength: 2000, nullable: true),
                    FolderName = table.Column<string>(maxLength: 128, nullable: false),
                    FriendlyName = table.Column<string>(maxLength: 128, nullable: false),
                    HostPage = table.Column<string>(maxLength: 128, nullable: true),
                    IsAdmin = table.Column<bool>(nullable: false),
                    IsPremium = table.Column<bool>(nullable: false),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    ModuleName = table.Column<string>(maxLength: 128, nullable: false),
                    PackageId = table.Column<int>(nullable: false, defaultValue: -1),
                    Permissions = table.Column<string>(maxLength: 400, nullable: true),
                    Shareable = table.Column<int>(nullable: false, defaultValue: 0),
                    SupportedFeatures = table.Column<int>(nullable: false, defaultValue: 0),
                    Version = table.Column<string>(maxLength: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesktopModules", x => x.DesktopModuleId);
                    table.ForeignKey(
                        name: "FK_DesktopModules_Packages_PackageId",
                        column: x => x.PackageId,
                        principalTable: "Packages",
                        principalColumn: "PackageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JavascriptLibraries",
                columns: table => new
                {
                    JavaScriptLibraryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CDNPath = table.Column<string>(nullable: true),
                    FileName = table.Column<string>(nullable: true),
                    LibraryName = table.Column<string>(nullable: true),
                    ObjectName = table.Column<string>(nullable: true),
                    PackageId = table.Column<int>(nullable: false),
                    PreferredScriptLocation = table.Column<int>(nullable: false),
                    Version = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JavascriptLibraries", x => x.JavaScriptLibraryId);
                    table.ForeignKey(
                        name: "FK_JavascriptLibraries_Packages_PackageId",
                        column: x => x.PackageId,
                        principalTable: "Packages",
                        principalColumn: "PackageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LanguagePacks",
                columns: table => new
                {
                    LanguagePackId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    DependentPackageId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    PackageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguagePacks", x => x.LanguagePackId);
                    table.ForeignKey(
                        name: "FK_LanguagePacks_Packages_PackageId",
                        column: x => x.PackageId,
                        principalTable: "Packages",
                        principalColumn: "PackageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PackageDependencies",
                columns: table => new
                {
                    PackageDependencyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PackageId = table.Column<int>(nullable: false),
                    PackageName = table.Column<string>(nullable: true),
                    Version = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageDependencies", x => x.PackageDependencyId);
                    table.ForeignKey(
                        name: "FK_PackageDependencies_Packages_PackageId",
                        column: x => x.PackageId,
                        principalTable: "Packages",
                        principalColumn: "PackageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SkinControls",
                columns: table => new
                {
                    SkinControlId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ControlKey = table.Column<string>(nullable: true),
                    ControlSrc = table.Column<string>(nullable: true),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    HelpURL = table.Column<string>(nullable: true),
                    IconFile = table.Column<string>(nullable: true),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    PackageId = table.Column<int>(nullable: false),
                    SupportsPartialRendering = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkinControls", x => x.SkinControlId);
                    table.ForeignKey(
                        name: "FK_SkinControls_Packages_PackageId",
                        column: x => x.PackageId,
                        principalTable: "Packages",
                        principalColumn: "PackageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SkinPackages",
                columns: table => new
                {
                    SkinPackageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    PackageId = table.Column<int>(nullable: false),
                    PortalId = table.Column<int>(nullable: true),
                    SkinName = table.Column<string>(nullable: true),
                    SkinType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkinPackages", x => x.SkinPackageId);
                    table.ForeignKey(
                        name: "FK_SkinPackages_Packages_PackageId",
                        column: x => x.PackageId,
                        principalTable: "Packages",
                        principalColumn: "PackageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FolderMappingsSettings",
                columns: table => new
                {
                    FolderMappingId = table.Column<int>(nullable: false),
                    SettingName = table.Column<string>(nullable: false),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    SettingValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FolderMappingsSettings", x => new { x.FolderMappingId, x.SettingName });
                    table.ForeignKey(
                        name: "FK_FolderMappingsSettings_FolderMappings_FolderMappingId",
                        column: x => x.FolderMappingId,
                        principalTable: "FolderMappings",
                        principalColumn: "FolderMappingId",
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
                    RedirectionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mobile_RedirectionRules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mobile_RedirectionRules_Mobile_Redirections_RedirectionId",
                        column: x => x.RedirectionId,
                        principalTable: "Mobile_Redirections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserProfile",
                columns: table => new
                {
                    ProfileId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ExtendedVisibility = table.Column<string>(nullable: true),
                    LastUpdatedDate = table.Column<DateTime>(nullable: false),
                    ProfilePropertyDefinitionId = table.Column<int>(nullable: false),
                    PropertyText = table.Column<string>(nullable: true),
                    PropertyValue = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    Visibility = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfile", x => x.ProfileId);
                    table.ForeignKey(
                        name: "FK_UserProfile_ProfilePropertyDefinition_ProfilePropertyDefinitionId",
                        column: x => x.ProfilePropertyDefinitionId,
                        principalTable: "ProfilePropertyDefinition",
                        principalColumn: "PropertyDefinitionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserProfile_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AutoAssignment = table.Column<bool>(nullable: false),
                    BillingFrequency = table.Column<string>(nullable: true),
                    BillingPeriod = table.Column<int>(nullable: true),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IconFile = table.Column<string>(nullable: true),
                    IsPublic = table.Column<bool>(nullable: false),
                    IsSystemRole = table.Column<bool>(nullable: false),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    PortalId = table.Column<int>(nullable: true),
                    RSVPCode = table.Column<string>(nullable: true),
                    RoleGroupId = table.Column<int>(nullable: true),
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
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                    table.ForeignKey(
                        name: "FK_Roles_Portals_PortalId",
                        column: x => x.PortalId,
                        principalTable: "Portals",
                        principalColumn: "PortalId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Roles_RoleGroups_RoleGroupId",
                        column: x => x.RoleGroupId,
                        principalTable: "RoleGroups",
                        principalColumn: "RoleGroupId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UrlLog",
                columns: table => new
                {
                    UrlLogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClickDate = table.Column<DateTime>(nullable: false),
                    UrlTrackingId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrlLog", x => x.UrlLogId);
                    table.ForeignKey(
                        name: "FK_UrlLog_UrlTracking_UrlTrackingId",
                        column: x => x.UrlTrackingId,
                        principalTable: "UrlTracking",
                        principalColumn: "UrlTrackingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Taxonomy_Terms",
                columns: table => new
                {
                    TermId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ParentTermId = table.Column<int>(nullable: false),
                    TermLeft = table.Column<int>(nullable: false),
                    TermRight = table.Column<int>(nullable: false),
                    VocabularyId = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taxonomy_Terms", x => x.TermId);
                    table.ForeignKey(
                        name: "FK_Taxonomy_Terms_Taxonomy_Terms_ParentTermId",
                        column: x => x.ParentTermId,
                        principalTable: "Taxonomy_Terms",
                        principalColumn: "TermId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Taxonomy_Terms_Taxonomy_Vocabularies_VocabularyId",
                        column: x => x.VocabularyId,
                        principalTable: "Taxonomy_Vocabularies",
                        principalColumn: "VocabularyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRelationshipPreferences",
                columns: table => new
                {
                    PreferenceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    DefaultResponse = table.Column<int>(nullable: false),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    RealtionshipId = table.Column<int>(nullable: false),
                    RelationshipId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRelationshipPreferences", x => x.PreferenceId);
                    table.ForeignKey(
                        name: "FK_UserRelationshipPreferences_Relationships_RelationshipId",
                        column: x => x.RelationshipId,
                        principalTable: "Relationships",
                        principalColumn: "RelationshipId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserRelationshipPreferences_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRelationships",
                columns: table => new
                {
                    UserRelationshipId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    RelatedUserId = table.Column<int>(nullable: false),
                    RelationshipId = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRelationships", x => x.UserRelationshipId);
                    table.ForeignKey(
                        name: "FK_UserRelationships_Users_RelatedUserId",
                        column: x => x.RelatedUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRelationships_Relationships_RelationshipId",
                        column: x => x.RelationshipId,
                        principalTable: "Relationships",
                        principalColumn: "RelationshipId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRelationships_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ContentItems",
                columns: table => new
                {
                    ContentItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Content = table.Column<string>(nullable: true),
                    ContentKey = table.Column<string>(maxLength: 250, nullable: true),
                    ContentTypeId = table.Column<int>(nullable: false),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    Indexed = table.Column<bool>(nullable: false, defaultValue: false),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    ModuleId = table.Column<int>(nullable: false),
                    StateId = table.Column<int>(nullable: true),
                    TabId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentItems", x => x.ContentItemId);
                    table.ForeignKey(
                        name: "FK_ContentItems_ContentTypes_ContentTypeId",
                        column: x => x.ContentTypeId,
                        principalTable: "ContentTypes",
                        principalColumn: "ContentTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContentItems_ContentWorkflowStates_StateId",
                        column: x => x.StateId,
                        principalTable: "ContentWorkflowStates",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContentWorkflowStatePermission",
                columns: table => new
                {
                    WorkflowStatePermissionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AllowAccess = table.Column<bool>(nullable: false),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    PermissionId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: true),
                    StateId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentWorkflowStatePermission", x => x.WorkflowStatePermissionId);
                    table.ForeignKey(
                        name: "FK_ContentWorkflowStatePermission_Permission_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permission",
                        principalColumn: "PermissionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContentWorkflowStatePermission_ContentWorkflowStates_StateId",
                        column: x => x.StateId,
                        principalTable: "ContentWorkflowStates",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContentWorkflowStatePermission_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExceptionEvents",
                columns: table => new
                {
                    LogEventId = table.Column<long>(nullable: false),
                    AssemblyVersion = table.Column<string>(maxLength: 20, nullable: false),
                    PortalId = table.Column<int>(nullable: true),
                    RawURL = table.Column<string>(maxLength: 260, nullable: true),
                    Referrer = table.Column<string>(maxLength: 260, nullable: true),
                    TabId = table.Column<int>(nullable: true),
                    UserAgent = table.Column<string>(maxLength: 260, nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExceptionEvents", x => x.LogEventId);
                    table.ForeignKey(
                        name: "FK_ExceptionEvents_EventLog_LogEventId",
                        column: x => x.LogEventId,
                        principalTable: "EventLog",
                        principalColumn: "LogEventId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CoreMessaging_NotificationTypes",
                columns: table => new
                {
                    NotificationTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(maxLength: 2000, nullable: true),
                    DesktopModuleId = table.Column<int>(nullable: true),
                    IsTask = table.Column<bool>(nullable: false, defaultValue: false),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    TTL = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoreMessaging_NotificationTypes", x => x.NotificationTypeId);
                    table.ForeignKey(
                        name: "FK_CoreMessaging_NotificationTypes_DesktopModules_DesktopModuleId",
                        column: x => x.DesktopModuleId,
                        principalTable: "DesktopModules",
                        principalColumn: "DesktopModuleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ModuleDefinitions",
                columns: table => new
                {
                    ModuleDefId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    DefaultCacheTime = table.Column<int>(nullable: false),
                    DefinitionName = table.Column<string>(nullable: true),
                    DesktopModuleId = table.Column<int>(nullable: false),
                    FriendlyName = table.Column<string>(nullable: true),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleDefinitions", x => x.ModuleDefId);
                    table.ForeignKey(
                        name: "FK_ModuleDefinitions_DesktopModules_DesktopModuleId",
                        column: x => x.DesktopModuleId,
                        principalTable: "DesktopModules",
                        principalColumn: "DesktopModuleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PortalDesktopModules",
                columns: table => new
                {
                    PortalDesktopModuleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    DesktopModuleId = table.Column<int>(nullable: false),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    PortalId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortalDesktopModules", x => x.PortalDesktopModuleId);
                    table.ForeignKey(
                        name: "FK_PortalDesktopModules_DesktopModules_DesktopModuleId",
                        column: x => x.DesktopModuleId,
                        principalTable: "DesktopModules",
                        principalColumn: "DesktopModuleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PortalDesktopModules_Portals_PortalId",
                        column: x => x.PortalId,
                        principalTable: "Portals",
                        principalColumn: "PortalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Skins",
                columns: table => new
                {
                    SkinId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SkinPackageId = table.Column<int>(nullable: false),
                    SkinSrc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skins", x => x.SkinId);
                    table.ForeignKey(
                        name: "FK_Skins_SkinPackages_SkinPackageId",
                        column: x => x.SkinPackageId,
                        principalTable: "SkinPackages",
                        principalColumn: "SkinPackageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonaBarMenuPermission",
                columns: table => new
                {
                    MenuPermissionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AllowAccess = table.Column<bool>(nullable: false),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    MenuId = table.Column<int>(nullable: false),
                    PermissionId = table.Column<int>(nullable: false),
                    PortalId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonaBarMenuPermission", x => x.MenuPermissionId);
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
                        principalColumn: "PortalId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonaBarMenuPermission_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonaBarMenuPermission_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserRoleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    EffectiveDate = table.Column<DateTime>(nullable: true),
                    ExpiryDate = table.Column<DateTime>(nullable: true),
                    IsOwner = table.Column<bool>(nullable: false),
                    IsTrialUsed = table.Column<bool>(nullable: true),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    RoleId = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.UserRoleId);
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContentItems_MetaData",
                columns: table => new
                {
                    ContentItemMetaDataId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContentItemId = table.Column<int>(nullable: false),
                    MetaDataId = table.Column<int>(nullable: false),
                    MetaDataValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentItems_MetaData", x => x.ContentItemMetaDataId);
                    table.ForeignKey(
                        name: "FK_ContentItems_MetaData_ContentItems_ContentItemId",
                        column: x => x.ContentItemId,
                        principalTable: "ContentItems",
                        principalColumn: "ContentItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContentItems_MetaData_MetaData_MetaDataId",
                        column: x => x.MetaDataId,
                        principalTable: "MetaData",
                        principalColumn: "MetaDataId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContentItems_Tags",
                columns: table => new
                {
                    ContentItemTagId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContentItemId = table.Column<int>(nullable: false),
                    TermId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentItems_Tags", x => x.ContentItemTagId);
                    table.ForeignKey(
                        name: "FK_ContentItems_Tags_ContentItems_ContentItemId",
                        column: x => x.ContentItemId,
                        principalTable: "ContentItems",
                        principalColumn: "ContentItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContentItems_Tags_Taxonomy_Terms_TermId",
                        column: x => x.TermId,
                        principalTable: "Taxonomy_Terms",
                        principalColumn: "TermId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContentWorkflowLogs",
                columns: table => new
                {
                    WorkflowLogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Action = table.Column<string>(maxLength: 40, nullable: false),
                    Comment = table.Column<string>(nullable: false),
                    ContentItemId = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Type = table.Column<int>(nullable: false, defaultValue: -1),
                    User = table.Column<int>(nullable: false),
                    WorkflowId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentWorkflowLogs", x => x.WorkflowLogId);
                    table.ForeignKey(
                        name: "FK_ContentWorkflowLogs_ContentItems_ContentItemId",
                        column: x => x.ContentItemId,
                        principalTable: "ContentItems",
                        principalColumn: "ContentItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContentWorkflowLogs_ContentWorkflows_WorkflowId",
                        column: x => x.WorkflowId,
                        principalTable: "ContentWorkflows",
                        principalColumn: "WorkflowId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tabs",
                columns: table => new
                {
                    TabId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContainerSrc = table.Column<string>(nullable: true),
                    ContentItemId = table.Column<int>(nullable: true),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    CultureCode = table.Column<string>(nullable: true),
                    DefaultLanguageGuid = table.Column<Guid>(nullable: false),
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
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    Level = table.Column<int>(nullable: false),
                    LocalizedVersionGuid = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PageHeadText = table.Column<string>(nullable: true),
                    ParentId = table.Column<int>(nullable: true),
                    PermanentRedirect = table.Column<bool>(nullable: false),
                    PortalId = table.Column<int>(nullable: true),
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
                    VersionGuid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tabs", x => x.TabId);
                    table.ForeignKey(
                        name: "FK_Tabs_ContentItems_ContentItemId",
                        column: x => x.ContentItemId,
                        principalTable: "ContentItems",
                        principalColumn: "ContentItemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tabs_Tabs_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Tabs",
                        principalColumn: "TabId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tabs_Portals_PortalId",
                        column: x => x.PortalId,
                        principalTable: "Portals",
                        principalColumn: "PortalId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Folders",
                columns: table => new
                {
                    FolderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContentWorkflowStatePermissionWorkflowStatePermissionId = table.Column<int>(nullable: true),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    FolderMappingId = table.Column<int>(nullable: false),
                    FolderPath = table.Column<string>(nullable: true),
                    IsCached = table.Column<bool>(nullable: false),
                    IsProtected = table.Column<bool>(nullable: false),
                    IsVersioned = table.Column<bool>(nullable: false),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    LastUpdated = table.Column<DateTime>(nullable: false),
                    MappedPath = table.Column<string>(nullable: true),
                    ParentId = table.Column<int>(nullable: true),
                    PortalId = table.Column<int>(nullable: true),
                    StorageLocation = table.Column<int>(nullable: false),
                    UniqueId = table.Column<Guid>(nullable: false),
                    VersionGuid = table.Column<Guid>(nullable: false),
                    WorkflowId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Folders", x => x.FolderId);
                    table.ForeignKey(
                        name: "FK_Folders_ContentWorkflowStatePermission_ContentWorkflowStatePermissionWorkflowStatePermissionId",
                        column: x => x.ContentWorkflowStatePermissionWorkflowStatePermissionId,
                        principalTable: "ContentWorkflowStatePermission",
                        principalColumn: "WorkflowStatePermissionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Folders_FolderMappings_FolderMappingId",
                        column: x => x.FolderMappingId,
                        principalTable: "FolderMappings",
                        principalColumn: "FolderMappingId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Folders_Portals_PortalId",
                        column: x => x.PortalId,
                        principalTable: "Portals",
                        principalColumn: "PortalId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Folders_ContentWorkflows_WorkflowId",
                        column: x => x.WorkflowId,
                        principalTable: "ContentWorkflows",
                        principalColumn: "WorkflowId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CoreMessaging_Messages",
                columns: table => new
                {
                    MessageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Body = table.Column<string>(nullable: true),
                    Context = table.Column<string>(maxLength: 200, nullable: true),
                    ConversationId = table.Column<int>(nullable: true),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    ExpirationDate = table.Column<DateTime>(nullable: true),
                    From = table.Column<string>(maxLength: 200, nullable: true),
                    IncludeDismissAction = table.Column<bool>(nullable: true),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    NotificationTypeId = table.Column<int>(nullable: true),
                    PortalId = table.Column<int>(nullable: true),
                    ReplyAllAllowed = table.Column<bool>(nullable: true),
                    SenderUserId = table.Column<int>(nullable: true),
                    Subject = table.Column<string>(maxLength: 400, nullable: true),
                    To = table.Column<string>(maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoreMessaging_Messages", x => x.MessageId);
                    table.ForeignKey(
                        name: "FK_CoreMessaging_Messages_CoreMessaging_NotificationTypes_NotificationTypeId",
                        column: x => x.NotificationTypeId,
                        principalTable: "CoreMessaging_NotificationTypes",
                        principalColumn: "NotificationTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CoreMessaging_NotificationTypeActions",
                columns: table => new
                {
                    NotificationTypeActionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    APICall = table.Column<string>(maxLength: 500, nullable: false),
                    ConfirmRescourceKey = table.Column<string>(maxLength: 100, nullable: true),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    DescriptionResourceKey = table.Column<string>(maxLength: 100, nullable: true),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    NameResourceKey = table.Column<string>(maxLength: 100, nullable: false),
                    NotificationTypeId = table.Column<int>(nullable: false),
                    Order = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoreMessaging_NotificationTypeActions", x => x.NotificationTypeActionId);
                    table.ForeignKey(
                        name: "FK_CoreMessaging_NotificationTypeActions_CoreMessaging_NotificationTypes_NotificationTypeId",
                        column: x => x.NotificationTypeId,
                        principalTable: "CoreMessaging_NotificationTypes",
                        principalColumn: "NotificationTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ModuleControls",
                columns: table => new
                {
                    ModuleControlId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ControlKey = table.Column<string>(nullable: true),
                    ControlSrc = table.Column<string>(nullable: true),
                    ControlTitle = table.Column<string>(nullable: true),
                    ControlType = table.Column<int>(nullable: false),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    HelpUrl = table.Column<string>(nullable: true),
                    IconFile = table.Column<string>(nullable: true),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    ModuleDefId = table.Column<int>(nullable: false),
                    SupportPopUps = table.Column<bool>(nullable: false),
                    SupportsPartialRendering = table.Column<bool>(nullable: false),
                    ViewOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleControls", x => x.ModuleControlId);
                    table.ForeignKey(
                        name: "FK_ModuleControls_ModuleDefinitions_ModuleDefId",
                        column: x => x.ModuleDefId,
                        principalTable: "ModuleDefinitions",
                        principalColumn: "ModuleDefId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    ModuleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AllTabs = table.Column<bool>(nullable: false),
                    ContentItemId = table.Column<int>(nullable: true),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    EndDate = table.Column<DateTime>(nullable: true),
                    Icon = table.Column<string>(nullable: true),
                    InheritViewPermissions = table.Column<bool>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsShareable = table.Column<bool>(nullable: true),
                    IsShareableViewOnly = table.Column<bool>(nullable: true),
                    LastContentModifiedOnDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    ModuleDef = table.Column<int>(nullable: false),
                    ModuleDefId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Path = table.Column<string>(nullable: true),
                    PortalId = table.Column<int>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.ModuleId);
                    table.ForeignKey(
                        name: "FK_Modules_ContentItems_ContentItemId",
                        column: x => x.ContentItemId,
                        principalTable: "ContentItems",
                        principalColumn: "ContentItemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Modules_ModuleDefinitions_ModuleDefId",
                        column: x => x.ModuleDefId,
                        principalTable: "ModuleDefinitions",
                        principalColumn: "ModuleDefId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DesktopModulePermission",
                columns: table => new
                {
                    DesktopModulePermissionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AllowAccess = table.Column<bool>(nullable: false),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    PermissionId = table.Column<int>(nullable: false),
                    PortalDesktopModuleId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesktopModulePermission", x => x.DesktopModulePermissionId);
                    table.ForeignKey(
                        name: "FK_DesktopModulePermission_Permission_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permission",
                        principalColumn: "PermissionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DesktopModulePermission_PortalDesktopModules_PortalDesktopModuleId",
                        column: x => x.PortalDesktopModuleId,
                        principalTable: "PortalDesktopModules",
                        principalColumn: "PortalDesktopModuleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DesktopModulePermission_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DesktopModulePermission_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TabPermission",
                columns: table => new
                {
                    TabPermissionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AllowAccess = table.Column<bool>(nullable: false),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    PermissionId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: true),
                    TabId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabPermission", x => x.TabPermissionId);
                    table.ForeignKey(
                        name: "FK_TabPermission_Permission_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permission",
                        principalColumn: "PermissionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TabPermission_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TabPermission_Tabs_TabId",
                        column: x => x.TabId,
                        principalTable: "Tabs",
                        principalColumn: "TabId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TabPermission_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TabSettings",
                columns: table => new
                {
                    TabId = table.Column<int>(nullable: false),
                    SettingName = table.Column<string>(nullable: false),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    SettingValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabSettings", x => new { x.TabId, x.SettingName });
                    table.UniqueConstraint("AK_TabSettings_SettingName_TabId", x => new { x.SettingName, x.TabId });
                    table.ForeignKey(
                        name: "FK_TabSettings_Tabs_TabId",
                        column: x => x.TabId,
                        principalTable: "Tabs",
                        principalColumn: "TabId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TabUrls",
                columns: table => new
                {
                    TabId = table.Column<int>(nullable: false),
                    SeqNum = table.Column<int>(nullable: false),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    CultureCode = table.Column<string>(nullable: true),
                    HttpStatus = table.Column<string>(nullable: true),
                    IsSystem = table.Column<bool>(nullable: false),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
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
                        principalColumn: "TabId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TabVersions",
                columns: table => new
                {
                    TabVersionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    IsPublished = table.Column<bool>(nullable: false),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
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
                        principalColumn: "TabId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    FileId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Content = table.Column<byte>(nullable: true),
                    ContentItemId = table.Column<int>(nullable: true),
                    ContentType = table.Column<string>(nullable: true),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    EnablePublishPeriod = table.Column<bool>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    Extension = table.Column<string>(nullable: true),
                    FileName = table.Column<string>(nullable: true),
                    FolderId = table.Column<int>(nullable: false),
                    HasBeenPublished = table.Column<bool>(nullable: false),
                    Hieght = table.Column<int>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: false),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    PortalId = table.Column<int>(nullable: true),
                    PublishedVersion = table.Column<int>(nullable: false),
                    SHA1Hash = table.Column<string>(nullable: true),
                    Size = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    UniqueId = table.Column<Guid>(nullable: false),
                    VersionGuid = table.Column<Guid>(nullable: false),
                    WIdth = table.Column<int>(nullable: true),
                    Folder = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.FileId);
                    table.ForeignKey(
                        name: "FK_Files_ContentItems_ContentItemId",
                        column: x => x.ContentItemId,
                        principalTable: "ContentItems",
                        principalColumn: "ContentItemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Files_Folders_FolderId",
                        column: x => x.FolderId,
                        principalTable: "Folders",
                        principalColumn: "FolderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Files_Portals_PortalId",
                        column: x => x.PortalId,
                        principalTable: "Portals",
                        principalColumn: "PortalId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FolderPermission",
                columns: table => new
                {
                    FolderPermissionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AllowAccess = table.Column<bool>(nullable: false),
                    ContentWorkflowStatePermissionWorkflowStatePermissionId = table.Column<int>(nullable: true),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    FolderId = table.Column<int>(nullable: false),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    PermissionId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FolderPermission", x => x.FolderPermissionId);
                    table.ForeignKey(
                        name: "FK_FolderPermission_ContentWorkflowStatePermission_ContentWorkflowStatePermissionWorkflowStatePermissionId",
                        column: x => x.ContentWorkflowStatePermissionWorkflowStatePermissionId,
                        principalTable: "ContentWorkflowStatePermission",
                        principalColumn: "WorkflowStatePermissionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FolderPermission_Folders_FolderId",
                        column: x => x.FolderId,
                        principalTable: "Folders",
                        principalColumn: "FolderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FolderPermission_Permission_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permission",
                        principalColumn: "PermissionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FolderPermission_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FolderPermission_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CoreMessaging_MessageAttachments",
                columns: table => new
                {
                    MessageAttachmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    FileId = table.Column<int>(nullable: true),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    MessageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoreMessaging_MessageAttachments", x => x.MessageAttachmentId);
                    table.ForeignKey(
                        name: "FK_CoreMessaging_MessageAttachments_CoreMessaging_Messages_MessageId",
                        column: x => x.MessageId,
                        principalTable: "CoreMessaging_Messages",
                        principalColumn: "MessageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CoreMessaging_MessageRecipients",
                columns: table => new
                {
                    RecipientId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Archived = table.Column<bool>(nullable: false),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    EmailSchedulerInstance = table.Column<Guid>(nullable: true),
                    EmailSent = table.Column<bool>(nullable: false),
                    EmailSentDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    MessageId = table.Column<int>(nullable: false),
                    Read = table.Column<bool>(nullable: false),
                    SendToast = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoreMessaging_MessageRecipients", x => x.RecipientId);
                    table.ForeignKey(
                        name: "FK_CoreMessaging_MessageRecipients_CoreMessaging_Messages_MessageId",
                        column: x => x.MessageId,
                        principalTable: "CoreMessaging_Messages",
                        principalColumn: "MessageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CoreMessaging_Subscriptions",
                columns: table => new
                {
                    SubscriptionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOnDate = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(maxLength: 255, nullable: false),
                    ModuleId = table.Column<int>(nullable: true),
                    ObjectData = table.Column<string>(nullable: true),
                    ObjectKey = table.Column<string>(maxLength: 255, nullable: true),
                    PortalId = table.Column<int>(nullable: true),
                    SubscriptionTypeId = table.Column<int>(nullable: false),
                    TabId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoreMessaging_Subscriptions", x => x.SubscriptionId);
                    table.ForeignKey(
                        name: "FK_CoreMessaging_Subscriptions_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "ModuleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CoreMessaging_Subscriptions_Portals_PortalId",
                        column: x => x.PortalId,
                        principalTable: "Portals",
                        principalColumn: "PortalId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CoreMessaging_Subscriptions_CoreMessaging_SubscriptionTypes_SubscriptionTypeId",
                        column: x => x.SubscriptionTypeId,
                        principalTable: "CoreMessaging_SubscriptionTypes",
                        principalColumn: "SubscriptionTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoreMessaging_Subscriptions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HtmlText",
                columns: table => new
                {
                    ModuleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Content = table.Column<string>(nullable: true),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    IsPublished = table.Column<bool>(nullable: true),
                    ItemId = table.Column<int>(nullable: false),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    ModuleId1 = table.Column<int>(nullable: true),
                    StateId = table.Column<int>(nullable: true),
                    Summary = table.Column<string>(nullable: true),
                    Version = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HtmlText", x => x.ModuleId);
                    table.ForeignKey(
                        name: "FK_HtmlText_Modules_ModuleId1",
                        column: x => x.ModuleId1,
                        principalTable: "Modules",
                        principalColumn: "ModuleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HtmlText_WorkflowStates_StateId",
                        column: x => x.StateId,
                        principalTable: "WorkflowStates",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ModulePermission",
                columns: table => new
                {
                    ModulePermissionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AllowAccess = table.Column<bool>(nullable: false),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    ModuleId = table.Column<int>(nullable: false),
                    PermissionId = table.Column<int>(nullable: false),
                    PortalId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModulePermission", x => x.ModulePermissionId);
                    table.ForeignKey(
                        name: "FK_ModulePermission_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "ModuleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModulePermission_Permission_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permission",
                        principalColumn: "PermissionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModulePermission_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ModulePermission_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ModuleSettings",
                columns: table => new
                {
                    ModuleId = table.Column<int>(nullable: false),
                    SettingName = table.Column<string>(nullable: false),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleSettings", x => new { x.ModuleId, x.SettingName });
                    table.ForeignKey(
                        name: "FK_ModuleSettings_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "ModuleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TabModules",
                columns: table => new
                {
                    TabModuleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Alignment = table.Column<string>(nullable: true),
                    Border = table.Column<string>(nullable: true),
                    CacheMethod = table.Column<string>(nullable: true),
                    CacheTime = table.Column<int>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    ContainerSrc = table.Column<string>(nullable: true),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    CultureCode = table.Column<string>(nullable: true),
                    DefaultLanguageGuid = table.Column<Guid>(nullable: false),
                    DisplayPrint = table.Column<int>(nullable: false),
                    DisplaySyndicate = table.Column<int>(nullable: false),
                    DisplayTitle = table.Column<int>(nullable: false),
                    ElementId = table.Column<string>(nullable: true),
                    Footer = table.Column<string>(nullable: true),
                    Header = table.Column<string>(nullable: true),
                    IconFile = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<int>(nullable: false),
                    IsWebSlice = table.Column<int>(nullable: false),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    LocalizedVersionGuid = table.Column<Guid>(nullable: false),
                    ModuleId = table.Column<int>(nullable: false),
                    ModuleOrder = table.Column<int>(nullable: false),
                    ModuleTitle = table.Column<string>(nullable: true),
                    Order = table.Column<int>(nullable: false),
                    PageId = table.Column<int>(nullable: false),
                    PaneName = table.Column<string>(nullable: true),
                    TabId = table.Column<int>(nullable: false),
                    UniqueId = table.Column<Guid>(nullable: false),
                    VersionGuid = table.Column<Guid>(nullable: false),
                    Visibility = table.Column<int>(nullable: false),
                    WebSliceExpiryDate = table.Column<DateTime>(nullable: true),
                    WebSliceTTL = table.Column<int>(nullable: true),
                    WebSliceTitle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabModules", x => x.TabModuleId);
                    table.ForeignKey(
                        name: "FK_TabModules_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "ModuleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TabModules_Tabs_TabId",
                        column: x => x.TabId,
                        principalTable: "Tabs",
                        principalColumn: "TabId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TabVersionDetails",
                columns: table => new
                {
                    TabVersionDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Action = table.Column<int>(nullable: false),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
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
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    Extension = table.Column<string>(nullable: true),
                    FileName = table.Column<string>(nullable: true),
                    Height = table.Column<int>(nullable: true),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    SHA1Hash = table.Column<string>(nullable: true),
                    Size = table.Column<int>(nullable: false),
                    WIdth = table.Column<int>(nullable: true)
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
                    HtmlTextLogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Approved = table.Column<bool>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    CreatedByUserId = table.Column<int>(nullable: false),
                    CreatedOnDate = table.Column<DateTime>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    StateId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HtmlTextLog", x => x.HtmlTextLogId);
                    table.ForeignKey(
                        name: "FK_HtmlTextLog_HtmlText_ItemId",
                        column: x => x.ItemId,
                        principalTable: "HtmlText",
                        principalColumn: "ModuleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HtmlTextLog_WorkflowStates_StateId",
                        column: x => x.StateId,
                        principalTable: "WorkflowStates",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HtmlTextUsers",
                columns: table => new
                {
                    HtmlTextUserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOnDate = table.Column<DateTime>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    ModuleId = table.Column<int>(nullable: false),
                    StateId = table.Column<int>(nullable: false),
                    TabId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HtmlTextUsers", x => x.HtmlTextUserId);
                    table.ForeignKey(
                        name: "FK_HtmlTextUsers_HtmlText_ItemId",
                        column: x => x.ItemId,
                        principalTable: "HtmlText",
                        principalColumn: "ModuleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TabModuleSettings",
                columns: table => new
                {
                    TabModuleId = table.Column<int>(nullable: false),
                    SettingName = table.Column<string>(nullable: false),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserId = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    SetttingValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabModuleSettings", x => new { x.TabModuleId, x.SettingName });
                    table.UniqueConstraint("AK_TabModuleSettings_SettingName_TabModuleId", x => new { x.SettingName, x.TabModuleId });
                    table.ForeignKey(
                        name: "FK_TabModuleSettings_TabModules_TabModuleId",
                        column: x => x.TabModuleId,
                        principalTable: "TabModules",
                        principalColumn: "TabModuleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnonymousUsers_PortalId",
                table: "AnonymousUsers",
                column: "PortalId");

            migrationBuilder.CreateIndex(
                name: "IX_aspnet_Membership_ApplicationId",
                table: "aspnet_Membership",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_aspnet_Users_ApplicationId_LastActivityDate",
                table: "aspnet_Users",
                columns: new[] { "ApplicationId", "LastActivityDate" })
                .Annotation("SqlServer:Clustered", false);
            
            migrationBuilder.CreateIndex(
                name: "IX_Assemblies_PackageId",
                table: "Assemblies",
                column: "PackageId");

            migrationBuilder.CreateIndex(
                name: "IX_Authentication_PackageId",
                table: "Authentication",
                column: "PackageId");

            migrationBuilder.CreateIndex(
                name: "IX_ContentItems_ContentTypeId",
                table: "ContentItems",
                column: "ContentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ContentItems_StateId",
                table: "ContentItems",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_ContentItems_TabId",
                table: "ContentItems",
                column: "TabId")
                .Annotation("SqlServer:Clustered", false);

            migrationBuilder.CreateIndex(
                name: "IX_ContentItems_MetaData_ContentItemId",
                table: "ContentItems_MetaData",
                column: "ContentItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ContentItems_MetaData_MetaDataId",
                table: "ContentItems_MetaData",
                column: "MetaDataId");

            migrationBuilder.CreateIndex(
                name: "IX_ContentItems_Tags_TermId",
                table: "ContentItems_Tags",
                column: "TermId");

            migrationBuilder.CreateIndex(
                name: "IX_ContentItems_Tags_ContentItemId_TermId",
                table: "ContentItems_Tags",
                columns: new[] { "ContentItemId", "TermId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContentWorkflowActions_ContentWorkflowActionActionId",
                table: "ContentWorkflowActions",
                column: "ContentWorkflowActionActionId");

            migrationBuilder.CreateIndex(
                name: "IX_ContentWorkflowLogs_ContentItemId",
                table: "ContentWorkflowLogs",
                column: "ContentItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ContentWorkflowLogs_WorkflowId",
                table: "ContentWorkflowLogs",
                column: "WorkflowId");

            migrationBuilder.CreateIndex(
                name: "IX_ContentWorkflows_Content_TypeContentTypeId",
                table: "ContentWorkflows",
                column: "Content_TypeContentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ContentWorkflows_PortalId_WorkflowName",
                table: "ContentWorkflows",
                columns: new[] { "PortalId", "WorkflowName" },
                unique: true,
                filter: "[PortalId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ContentWorkflowSources_WorkflowId_SourceName",
                table: "ContentWorkflowSources",
                columns: new[] { "WorkflowId", "SourceName" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContentWorkflowStatePermission_PermissionId",
                table: "ContentWorkflowStatePermission",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_ContentWorkflowStatePermission_UserId",
                table: "ContentWorkflowStatePermission",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ContentWorkflowStatePermission_StateId_PermissionId_RoleId_UserId",
                table: "ContentWorkflowStatePermission",
                columns: new[] { "StateId", "PermissionId", "RoleId", "UserId" },
                unique: true,
                filter: "[RoleId] IS NOT NULL AND [UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ContentWorkflowStates_WorkflowId_StateName",
                table: "ContentWorkflowStates",
                columns: new[] { "WorkflowId", "StateName" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CoreMessaging_MessageAttachments_MessageId",
                table: "CoreMessaging_MessageAttachments",
                column: "MessageId");

            migrationBuilder.CreateIndex(
                name: "IX_CoreMessaging_MessageRecipients_MessageId",
                table: "CoreMessaging_MessageRecipients",
                column: "MessageId");

            migrationBuilder.CreateIndex(
                name: "IX_CoreMessaging_Messages_NotificationTypeId",
                table: "CoreMessaging_Messages",
                column: "NotificationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CoreMessaging_Messages_MessageId_PortalId_NotificationTypeId_ExpirationDate",
                table: "CoreMessaging_Messages",
                columns: new[] { "MessageId", "PortalId", "NotificationTypeId", "ExpirationDate" },
                unique: true,
                filter: "[PortalId] IS NOT NULL AND [NotificationTypeId] IS NOT NULL AND [ExpirationDate] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CoreMessaging_NotificationTypeActions_NotificationTypeId",
                table: "CoreMessaging_NotificationTypeActions",
                column: "NotificationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CoreMessaging_NotificationTypes_DesktopModuleId",
                table: "CoreMessaging_NotificationTypes",
                column: "DesktopModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_CoreMessaging_NotificationTypes_Name",
                table: "CoreMessaging_NotificationTypes",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CoreMessaging_Subscriptions_ModuleId",
                table: "CoreMessaging_Subscriptions",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_CoreMessaging_Subscriptions_PortalId",
                table: "CoreMessaging_Subscriptions",
                column: "PortalId");

            migrationBuilder.CreateIndex(
                name: "IX_CoreMessaging_Subscriptions_SubscriptionTypeId",
                table: "CoreMessaging_Subscriptions",
                column: "SubscriptionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CoreMessaging_Subscriptions_UserId",
                table: "CoreMessaging_Subscriptions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CoreMessaging_SubscriptionTypes_SubscriptionName",
                table: "CoreMessaging_SubscriptionTypes",
                column: "SubscriptionName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DesktopModulePermission_PermissionId",
                table: "DesktopModulePermission",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_DesktopModulePermission_RoleId",
                table: "DesktopModulePermission",
                column: "RoleId",
                unique: true,
                filter: "[RoleId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DesktopModulePermission_UserId",
                table: "DesktopModulePermission",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DesktopModulePermission_PortalDesktopModuleId_PermissionId_RoleId_UserId",
                table: "DesktopModulePermission",
                columns: new[] { "PortalDesktopModuleId", "PermissionId", "RoleId", "UserId" },
                unique: true,
                filter: "[RoleId] IS NOT NULL AND [UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DesktopModules_PackageId",
                table: "DesktopModules",
                column: "PackageId");

            migrationBuilder.CreateIndex(
                name: "IX_EventLog_EventLogConfigId",
                table: "EventLog",
                column: "EventLogConfigId");

            migrationBuilder.CreateIndex(
                name: "IX_EventLog_LogConfigLogEventId",
                table: "EventLog",
                column: "LogConfigLogEventId");

            migrationBuilder.CreateIndex(
                name: "IX_EventLog_LogTypeKey",
                table: "EventLog",
                column: "LogTypeKey");

            migrationBuilder.CreateIndex(
                name: "IX_EventLogConfig_LogTypeKey_LogTypePortalId",
                table: "EventLogConfig",
                columns: new[] { "LogTypeKey", "LogTypePortalId" },
                unique: true,
                filter: "[LogTypeKey] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ExportImportCheckpoints_Category",
                table: "ExportImportCheckpoints",
                column: "Category");

            migrationBuilder.CreateIndex(
                name: "IX_ExportImportCheckpoints_JobId",
                table: "ExportImportCheckpoints",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_ExportImportCheckpoints_Category_AssemblyName_JobId",
                table: "ExportImportCheckpoints",
                columns: new[] { "Category", "AssemblyName", "JobId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExportImportJobLogs_JobId",
                table: "ExportImportJobLogs",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_Files_ContentItemId",
                table: "Files",
                column: "ContentItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Files_FolderId",
                table: "Files",
                column: "FolderId");

            migrationBuilder.CreateIndex(
                name: "IX_Files_PortalId",
                table: "Files",
                column: "PortalId");

            migrationBuilder.CreateIndex(
                name: "IX_FolderMappings_PortalId",
                table: "FolderMappings",
                column: "PortalId");

            migrationBuilder.CreateIndex(
                name: "IX_FolderPermission_ContentWorkflowStatePermissionWorkflowStatePermissionId",
                table: "FolderPermission",
                column: "ContentWorkflowStatePermissionWorkflowStatePermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_FolderPermission_FolderId",
                table: "FolderPermission",
                column: "FolderId");

            migrationBuilder.CreateIndex(
                name: "IX_FolderPermission_PermissionId",
                table: "FolderPermission",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_FolderPermission_RoleId",
                table: "FolderPermission",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_FolderPermission_UserId",
                table: "FolderPermission",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Folders_ContentWorkflowStatePermissionWorkflowStatePermissionId",
                table: "Folders",
                column: "ContentWorkflowStatePermissionWorkflowStatePermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Folders_FolderMappingId",
                table: "Folders",
                column: "FolderMappingId");

            migrationBuilder.CreateIndex(
                name: "IX_Folders_PortalId",
                table: "Folders",
                column: "PortalId");

            migrationBuilder.CreateIndex(
                name: "IX_Folders_WorkflowId",
                table: "Folders",
                column: "WorkflowId");

            migrationBuilder.CreateIndex(
                name: "IX_HtmlText_ModuleId1",
                table: "HtmlText",
                column: "ModuleId1");

            migrationBuilder.CreateIndex(
                name: "IX_HtmlText_StateId",
                table: "HtmlText",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_HtmlTextLog_ItemId",
                table: "HtmlTextLog",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_HtmlTextLog_StateId",
                table: "HtmlTextLog",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_HtmlTextUsers_ItemId",
                table: "HtmlTextUsers",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_JavascriptLibraries_PackageId",
                table: "JavascriptLibraries",
                column: "PackageId");

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
                name: "IX_LanguagePacks_PackageId",
                table: "LanguagePacks",
                column: "PackageId");

            migrationBuilder.CreateIndex(
                name: "IX_Mobile_PreviewProfiles_PortalId",
                table: "Mobile_PreviewProfiles",
                column: "PortalId");

            migrationBuilder.CreateIndex(
                name: "IX_Mobile_RedirectionRules_RedirectionId",
                table: "Mobile_RedirectionRules",
                column: "RedirectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Mobile_Redirections_PortalId",
                table: "Mobile_Redirections",
                column: "PortalId");

            migrationBuilder.CreateIndex(
                name: "IX_ModuleControls_ModuleDefId",
                table: "ModuleControls",
                column: "ModuleDefId");

            migrationBuilder.CreateIndex(
                name: "IX_ModuleDefinitions_DesktopModuleId",
                table: "ModuleDefinitions",
                column: "DesktopModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_ModulePermission_ModuleId",
                table: "ModulePermission",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_ModulePermission_PermissionId",
                table: "ModulePermission",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_ModulePermission_RoleId",
                table: "ModulePermission",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_ModulePermission_UserId",
                table: "ModulePermission",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Modules_ContentItemId",
                table: "Modules",
                column: "ContentItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Modules_ModuleDefId",
                table: "Modules",
                column: "ModuleDefId");

            migrationBuilder.CreateIndex(
                name: "IX_PackageDependencies_PackageId",
                table: "PackageDependencies",
                column: "PackageId");

            migrationBuilder.CreateIndex(
                name: "IX_Packages_PackageType",
                table: "Packages",
                column: "PackageType",
                unique: true,
                filter: "[PackageType] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Packages_PackageTypeNavigationPackageId",
                table: "Packages",
                column: "PackageTypeNavigationPackageId");

            migrationBuilder.CreateIndex(
                name: "IX_PasswordHistory_UserId",
                table: "PasswordHistory",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaBarExtensions_MenuId",
                table: "PersonaBarExtensions",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaBarMenu_ParentId",
                table: "PersonaBarMenu",
                column: "ParentId");

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
                name: "IX_PortalAlias_PortalId",
                table: "PortalAlias",
                column: "PortalId");

            migrationBuilder.CreateIndex(
                name: "IX_PortalDesktopModules_DesktopModuleId",
                table: "PortalDesktopModules",
                column: "DesktopModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_PortalDesktopModules_PortalId",
                table: "PortalDesktopModules",
                column: "PortalId");

            migrationBuilder.CreateIndex(
                name: "IX_PortalLanguages_LanguageId",
                table: "PortalLanguages",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_PortalLanguages_PortalId",
                table: "PortalLanguages",
                column: "PortalId");

            migrationBuilder.CreateIndex(
                name: "IX_PortalLocalization_PortalId1",
                table: "PortalLocalization",
                column: "PortalId1");

            migrationBuilder.CreateIndex(
                name: "IX_PortalSettings_PortalId",
                table: "PortalSettings",
                column: "PortalId");

            migrationBuilder.CreateIndex(
                name: "IX_Profile_PortalId",
                table: "Profile",
                column: "PortalId");

            migrationBuilder.CreateIndex(
                name: "IX_Profile_UserId",
                table: "Profile",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfilePropertyDefinition_PortalId",
                table: "ProfilePropertyDefinition",
                column: "PortalId");

            migrationBuilder.CreateIndex(
                name: "IX_Relationships_PortalId",
                table: "Relationships",
                column: "PortalId");

            migrationBuilder.CreateIndex(
                name: "IX_Relationships_RelationshipTypeId",
                table: "Relationships",
                column: "RelationshipTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Relationships_UserId",
                table: "Relationships",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleGroups_PortalId",
                table: "RoleGroups",
                column: "PortalId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_PortalId",
                table: "Roles",
                column: "PortalId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_RoleGroupId",
                table: "Roles",
                column: "RoleGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleHistory_ScheduleId",
                table: "ScheduleHistory",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleItemSettings_ScheduleId1",
                table: "ScheduleItemSettings",
                column: "ScheduleId1");

            migrationBuilder.CreateIndex(
                name: "IX_SiteLog_PortalId",
                table: "SiteLog",
                column: "PortalId");

            migrationBuilder.CreateIndex(
                name: "IX_SkinControls_PackageId",
                table: "SkinControls",
                column: "PackageId");

            migrationBuilder.CreateIndex(
                name: "IX_SkinPackages_PackageId",
                table: "SkinPackages",
                column: "PackageId");

            migrationBuilder.CreateIndex(
                name: "IX_Skins_SkinPackageId",
                table: "Skins",
                column: "SkinPackageId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemMessages_PortalId",
                table: "SystemMessages",
                column: "PortalId");

            migrationBuilder.CreateIndex(
                name: "IX_TabModules_ModuleId",
                table: "TabModules",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_TabModules_TabId",
                table: "TabModules",
                column: "TabId");

            migrationBuilder.CreateIndex(
                name: "IX_TabPermission_PermissionId",
                table: "TabPermission",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_TabPermission_RoleId",
                table: "TabPermission",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_TabPermission_TabId",
                table: "TabPermission",
                column: "TabId");

            migrationBuilder.CreateIndex(
                name: "IX_TabPermission_UserId",
                table: "TabPermission",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tabs_ContentItemId",
                table: "Tabs",
                column: "ContentItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Tabs_ParentId",
                table: "Tabs",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Tabs_PortalId",
                table: "Tabs",
                column: "PortalId");

            migrationBuilder.CreateIndex(
                name: "IX_TabVersionDetails_TabVersionId",
                table: "TabVersionDetails",
                column: "TabVersionId");

            migrationBuilder.CreateIndex(
                name: "IX_TabVersions_TabId",
                table: "TabVersions",
                column: "TabId");

            migrationBuilder.CreateIndex(
                name: "IX_Taxonomy_Terms_ParentTermId",
                table: "Taxonomy_Terms",
                column: "ParentTermId");

            migrationBuilder.CreateIndex(
                name: "IX_Taxonomy_Terms_VocabularyId",
                table: "Taxonomy_Terms",
                column: "VocabularyId");

            migrationBuilder.CreateIndex(
                name: "IX_Taxonomy_Vocabularies_ScopeTypeId",
                table: "Taxonomy_Vocabularies",
                column: "ScopeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Taxonomy_Vocabularies_VocabularyTypeId",
                table: "Taxonomy_Vocabularies",
                column: "VocabularyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UrlLog_UrlTrackingId",
                table: "UrlLog",
                column: "UrlTrackingId");

            migrationBuilder.CreateIndex(
                name: "IX_Urls_PortalId",
                table: "Urls",
                column: "PortalId");

            migrationBuilder.CreateIndex(
                name: "IX_UrlTracking_PortalId",
                table: "UrlTracking",
                column: "PortalId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAuthentication_UserId",
                table: "UserAuthentication",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPortals_PortalId",
                table: "UserPortals",
                column: "PortalId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPortals_UserId1",
                table: "UserPortals",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfile_ProfilePropertyDefinitionId",
                table: "UserProfile",
                column: "ProfilePropertyDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfile_UserId",
                table: "UserProfile",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRelationshipPreferences_RelationshipId",
                table: "UserRelationshipPreferences",
                column: "RelationshipId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRelationshipPreferences_UserId",
                table: "UserRelationshipPreferences",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRelationships_RelatedUserId",
                table: "UserRelationships",
                column: "RelatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRelationships_RelationshipId",
                table: "UserRelationships",
                column: "RelationshipId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRelationships_UserId",
                table: "UserRelationships",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersOnline_PortalId",
                table: "UsersOnline",
                column: "PortalId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersOnline_UserId1",
                table: "UsersOnline",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowStates_WorkflowId",
                table: "WorkflowStates",
                column: "WorkflowId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnonymousUsers");

            migrationBuilder.DropTable(
                name: "aspnet_Membership");

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
                name: "ContentWorkflowActions");

            migrationBuilder.DropTable(
                name: "ContentWorkflowLogs");

            migrationBuilder.DropTable(
                name: "ContentWorkflowSources");

            migrationBuilder.DropTable(
                name: "CoreMessaging_MessageAttachments");

            migrationBuilder.DropTable(
                name: "CoreMessaging_MessageRecipients");

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
                name: "ExtensionUrlProvIderConfiguration");

            migrationBuilder.DropTable(
                name: "ExtensionUrlProvIders");

            migrationBuilder.DropTable(
                name: "ExtensionUrlProvIderSetting");

            migrationBuilder.DropTable(
                name: "ExtensionUrlProvIderTab");

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
                name: "ModulePermission");

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
                name: "SkinPackages");

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
                name: "Roles");

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
                name: "ContentTypes");
        }
    }
}
