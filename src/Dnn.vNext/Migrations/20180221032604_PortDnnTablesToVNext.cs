using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Dnn.vNext.Migrations
{
    public partial class PortDnnTablesToVNext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PageModule_Modules_ModuleId",
                table: "PageModule");

            migrationBuilder.DropForeignKey(
                name: "FK_PageModule_Pages_PageId",
                table: "PageModule");

            migrationBuilder.DropTable(
                name: "Pages");

            migrationBuilder.RenameColumn(
                name: "ModuleId",
                table: "PageModule",
                newName: "ModuleID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PageModule",
                newName: "TabModuleID");

            migrationBuilder.RenameIndex(
                name: "IX_PageModule_ModuleId",
                table: "PageModule",
                newName: "IX_PageModule_ModuleID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Modules",
                newName: "ModuleID");

            migrationBuilder.AddColumn<string>(
                name: "Alignment",
                table: "PageModule",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Border",
                table: "PageModule",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CacheMethod",
                table: "PageModule",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CacheTime",
                table: "PageModule",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "PageModule",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContainerSrc",
                table: "PageModule",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserID",
                table: "PageModule",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOnDate",
                table: "PageModule",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CultureCode",
                table: "PageModule",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DefaultLanguageGUID",
                table: "PageModule",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "DisplayPrint",
                table: "PageModule",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DisplaySyndicate",
                table: "PageModule",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DisplayTitle",
                table: "PageModule",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Footer",
                table: "PageModule",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Header",
                table: "PageModule",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IconFile",
                table: "PageModule",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IsDeleted",
                table: "PageModule",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IsWebSlice",
                table: "PageModule",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LastModifiedByUserID",
                table: "PageModule",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOnDate",
                table: "PageModule",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LocalizedVersionGUID",
                table: "PageModule",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "ModuleOrder",
                table: "PageModule",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ModuleTitle",
                table: "PageModule",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PaneName",
                table: "PageModule",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TabID",
                table: "PageModule",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "UniqueId",
                table: "PageModule",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "VersionGUID",
                table: "PageModule",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "Visibility",
                table: "PageModule",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "WebSliceExpiryDate",
                table: "PageModule",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WebSliceTTL",
                table: "PageModule",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WebSliceTitle",
                table: "PageModule",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "AllTabs",
                table: "Modules",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ContentItemID",
                table: "Modules",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserID",
                table: "Modules",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOnDate",
                table: "Modules",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Modules",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "InheritViewPermissions",
                table: "Modules",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Modules",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsShareable",
                table: "Modules",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsShareableViewOnly",
                table: "Modules",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastContentModifiedOnDate",
                table: "Modules",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LastModifiedByUserID",
                table: "Modules",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOnDate",
                table: "Modules",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModuleDefID",
                table: "Modules",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PortalID",
                table: "Modules",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Modules",
                nullable: true);

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
                });

            migrationBuilder.CreateTable(
                name: "ModuleSettings",
                columns: table => new
                {
                    ModuleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    SettingName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleSettings", x => x.ModuleID);
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
                });

            migrationBuilder.CreateTable(
                name: "TabModuleSettings",
                columns: table => new
                {
                    TabModuleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    CreatedOnDate = table.Column<DateTime>(nullable: true),
                    LastModifiedByUserID = table.Column<int>(nullable: true),
                    LastModifiedOnDate = table.Column<DateTime>(nullable: true),
                    SettingName = table.Column<string>(nullable: true),
                    SetttingValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabModuleSettings", x => x.TabModuleID);
                });

            migrationBuilder.CreateTable(
                name: "Tabs",
                columns: table => new
                {
                    TabID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tabs", x => x.TabID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_PageModule_Modules_ModuleID",
                table: "PageModule",
                column: "ModuleID",
                principalTable: "Modules",
                principalColumn: "ModuleID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PageModule_Tabs_PageId",
                table: "PageModule",
                column: "PageId",
                principalTable: "Tabs",
                principalColumn: "TabID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PageModule_Modules_ModuleID",
                table: "PageModule");

            migrationBuilder.DropForeignKey(
                name: "FK_PageModule_Tabs_PageId",
                table: "PageModule");

            migrationBuilder.DropTable(
                name: "ModuleControls");

            migrationBuilder.DropTable(
                name: "ModuleDefinitions");

            migrationBuilder.DropTable(
                name: "ModulePermissions");

            migrationBuilder.DropTable(
                name: "ModuleSettings");

            migrationBuilder.DropTable(
                name: "TabModules");

            migrationBuilder.DropTable(
                name: "TabModuleSettings");

            migrationBuilder.DropTable(
                name: "Tabs");

            migrationBuilder.DropColumn(
                name: "Alignment",
                table: "PageModule");

            migrationBuilder.DropColumn(
                name: "Border",
                table: "PageModule");

            migrationBuilder.DropColumn(
                name: "CacheMethod",
                table: "PageModule");

            migrationBuilder.DropColumn(
                name: "CacheTime",
                table: "PageModule");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "PageModule");

            migrationBuilder.DropColumn(
                name: "ContainerSrc",
                table: "PageModule");

            migrationBuilder.DropColumn(
                name: "CreatedByUserID",
                table: "PageModule");

            migrationBuilder.DropColumn(
                name: "CreatedOnDate",
                table: "PageModule");

            migrationBuilder.DropColumn(
                name: "CultureCode",
                table: "PageModule");

            migrationBuilder.DropColumn(
                name: "DefaultLanguageGUID",
                table: "PageModule");

            migrationBuilder.DropColumn(
                name: "DisplayPrint",
                table: "PageModule");

            migrationBuilder.DropColumn(
                name: "DisplaySyndicate",
                table: "PageModule");

            migrationBuilder.DropColumn(
                name: "DisplayTitle",
                table: "PageModule");

            migrationBuilder.DropColumn(
                name: "Footer",
                table: "PageModule");

            migrationBuilder.DropColumn(
                name: "Header",
                table: "PageModule");

            migrationBuilder.DropColumn(
                name: "IconFile",
                table: "PageModule");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "PageModule");

            migrationBuilder.DropColumn(
                name: "IsWebSlice",
                table: "PageModule");

            migrationBuilder.DropColumn(
                name: "LastModifiedByUserID",
                table: "PageModule");

            migrationBuilder.DropColumn(
                name: "LastModifiedOnDate",
                table: "PageModule");

            migrationBuilder.DropColumn(
                name: "LocalizedVersionGUID",
                table: "PageModule");

            migrationBuilder.DropColumn(
                name: "ModuleOrder",
                table: "PageModule");

            migrationBuilder.DropColumn(
                name: "ModuleTitle",
                table: "PageModule");

            migrationBuilder.DropColumn(
                name: "PaneName",
                table: "PageModule");

            migrationBuilder.DropColumn(
                name: "TabID",
                table: "PageModule");

            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "PageModule");

            migrationBuilder.DropColumn(
                name: "VersionGUID",
                table: "PageModule");

            migrationBuilder.DropColumn(
                name: "Visibility",
                table: "PageModule");

            migrationBuilder.DropColumn(
                name: "WebSliceExpiryDate",
                table: "PageModule");

            migrationBuilder.DropColumn(
                name: "WebSliceTTL",
                table: "PageModule");

            migrationBuilder.DropColumn(
                name: "WebSliceTitle",
                table: "PageModule");

            migrationBuilder.DropColumn(
                name: "AllTabs",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "ContentItemID",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "CreatedByUserID",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "CreatedOnDate",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "InheritViewPermissions",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "IsShareable",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "IsShareableViewOnly",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "LastContentModifiedOnDate",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "LastModifiedByUserID",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "LastModifiedOnDate",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "ModuleDefID",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "PortalID",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Modules");

            migrationBuilder.RenameColumn(
                name: "ModuleID",
                table: "PageModule",
                newName: "ModuleId");

            migrationBuilder.RenameColumn(
                name: "TabModuleID",
                table: "PageModule",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_PageModule_ModuleID",
                table: "PageModule",
                newName: "IX_PageModule_ModuleId");

            migrationBuilder.RenameColumn(
                name: "ModuleID",
                table: "Modules",
                newName: "Id");

            migrationBuilder.CreateTable(
                name: "Pages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pages", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_PageModule_Modules_ModuleId",
                table: "PageModule",
                column: "ModuleId",
                principalTable: "Modules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PageModule_Pages_PageId",
                table: "PageModule",
                column: "PageId",
                principalTable: "Pages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
