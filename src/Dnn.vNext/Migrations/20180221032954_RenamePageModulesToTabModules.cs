using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Dnn.vNext.Migrations
{
    public partial class RenamePageModulesToTabModules : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PageModule");

            migrationBuilder.AddColumn<string>(
                name: "ElementId",
                table: "TabModules",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "TabModules",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PageId",
                table: "TabModules",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TabModules_ModuleID",
                table: "TabModules",
                column: "ModuleID");

            migrationBuilder.CreateIndex(
                name: "IX_TabModules_PageId",
                table: "TabModules",
                column: "PageId");

            migrationBuilder.AddForeignKey(
                name: "FK_TabModules_Modules_ModuleID",
                table: "TabModules",
                column: "ModuleID",
                principalTable: "Modules",
                principalColumn: "ModuleID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TabModules_Tabs_PageId",
                table: "TabModules",
                column: "PageId",
                principalTable: "Tabs",
                principalColumn: "TabID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TabModules_Modules_ModuleID",
                table: "TabModules");

            migrationBuilder.DropForeignKey(
                name: "FK_TabModules_Tabs_PageId",
                table: "TabModules");

            migrationBuilder.DropIndex(
                name: "IX_TabModules_ModuleID",
                table: "TabModules");

            migrationBuilder.DropIndex(
                name: "IX_TabModules_PageId",
                table: "TabModules");

            migrationBuilder.DropColumn(
                name: "ElementId",
                table: "TabModules");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "TabModules");

            migrationBuilder.DropColumn(
                name: "PageId",
                table: "TabModules");

            migrationBuilder.CreateTable(
                name: "PageModule",
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
                    table.PrimaryKey("PK_PageModule", x => x.TabModuleID);
                    table.ForeignKey(
                        name: "FK_PageModule_Modules_ModuleID",
                        column: x => x.ModuleID,
                        principalTable: "Modules",
                        principalColumn: "ModuleID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PageModule_Tabs_PageId",
                        column: x => x.PageId,
                        principalTable: "Tabs",
                        principalColumn: "TabID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PageModule_ModuleID",
                table: "PageModule",
                column: "ModuleID");

            migrationBuilder.CreateIndex(
                name: "IX_PageModule_PageId",
                table: "PageModule",
                column: "PageId");
        }
    }
}
