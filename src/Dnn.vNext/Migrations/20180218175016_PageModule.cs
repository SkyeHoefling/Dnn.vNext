using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Dnn.vNext.Migrations
{
    public partial class PageModule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ElementId",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "PageId",
                table: "Modules");

            migrationBuilder.CreateTable(
                name: "PageModule",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ElementId = table.Column<string>(nullable: true),
                    ModuleId = table.Column<int>(nullable: false),
                    Order = table.Column<int>(nullable: false),
                    PageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PageModule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PageModule_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PageModule_Pages_PageId",
                        column: x => x.PageId,
                        principalTable: "Pages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PageModule_ModuleId",
                table: "PageModule",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_PageModule_PageId",
                table: "PageModule",
                column: "PageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PageModule");

            migrationBuilder.AddColumn<string>(
                name: "ElementId",
                table: "Modules",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PageId",
                table: "Modules",
                nullable: false,
                defaultValue: 0);
        }
    }
}
