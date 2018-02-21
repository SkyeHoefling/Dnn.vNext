using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Dnn.vNext.Migrations
{
    public partial class MoreDnnTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContainerSrc",
                table: "Tabs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContentItemID",
                table: "Tabs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserID",
                table: "Tabs",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOnDate",
                table: "Tabs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CultureCode",
                table: "Tabs",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DefaultLanguageGUID",
                table: "Tabs",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Tabs",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "DisableLink",
                table: "Tabs",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Tabs",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasBeenPublished",
                table: "Tabs",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "IconFile",
                table: "Tabs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IconFileLarge",
                table: "Tabs",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Tabs",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSecure",
                table: "Tabs",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSystem",
                table: "Tabs",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsVisible",
                table: "Tabs",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Keywords",
                table: "Tabs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LastModifiedByUserID",
                table: "Tabs",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOnDate",
                table: "Tabs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Level",
                table: "Tabs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "LocalizedVersionGUID",
                table: "Tabs",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "PageHeadText",
                table: "Tabs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "Tabs",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PermanentRedirect",
                table: "Tabs",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "PortalID",
                table: "Tabs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RefreshInterval",
                table: "Tabs",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "SiteMapPriority",
                table: "Tabs",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "SkinSrc",
                table: "Tabs",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Tabs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TabName",
                table: "Tabs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TabOrder",
                table: "Tabs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TabPath",
                table: "Tabs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Tabs",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UniqueId",
                table: "Tabs",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Tabs",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "VersionGUID",
                table: "Tabs",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContainerSrc",
                table: "Tabs");

            migrationBuilder.DropColumn(
                name: "ContentItemID",
                table: "Tabs");

            migrationBuilder.DropColumn(
                name: "CreatedByUserID",
                table: "Tabs");

            migrationBuilder.DropColumn(
                name: "CreatedOnDate",
                table: "Tabs");

            migrationBuilder.DropColumn(
                name: "CultureCode",
                table: "Tabs");

            migrationBuilder.DropColumn(
                name: "DefaultLanguageGUID",
                table: "Tabs");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Tabs");

            migrationBuilder.DropColumn(
                name: "DisableLink",
                table: "Tabs");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Tabs");

            migrationBuilder.DropColumn(
                name: "HasBeenPublished",
                table: "Tabs");

            migrationBuilder.DropColumn(
                name: "IconFile",
                table: "Tabs");

            migrationBuilder.DropColumn(
                name: "IconFileLarge",
                table: "Tabs");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Tabs");

            migrationBuilder.DropColumn(
                name: "IsSecure",
                table: "Tabs");

            migrationBuilder.DropColumn(
                name: "IsSystem",
                table: "Tabs");

            migrationBuilder.DropColumn(
                name: "IsVisible",
                table: "Tabs");

            migrationBuilder.DropColumn(
                name: "Keywords",
                table: "Tabs");

            migrationBuilder.DropColumn(
                name: "LastModifiedByUserID",
                table: "Tabs");

            migrationBuilder.DropColumn(
                name: "LastModifiedOnDate",
                table: "Tabs");

            migrationBuilder.DropColumn(
                name: "Level",
                table: "Tabs");

            migrationBuilder.DropColumn(
                name: "LocalizedVersionGUID",
                table: "Tabs");

            migrationBuilder.DropColumn(
                name: "PageHeadText",
                table: "Tabs");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Tabs");

            migrationBuilder.DropColumn(
                name: "PermanentRedirect",
                table: "Tabs");

            migrationBuilder.DropColumn(
                name: "PortalID",
                table: "Tabs");

            migrationBuilder.DropColumn(
                name: "RefreshInterval",
                table: "Tabs");

            migrationBuilder.DropColumn(
                name: "SiteMapPriority",
                table: "Tabs");

            migrationBuilder.DropColumn(
                name: "SkinSrc",
                table: "Tabs");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Tabs");

            migrationBuilder.DropColumn(
                name: "TabName",
                table: "Tabs");

            migrationBuilder.DropColumn(
                name: "TabOrder",
                table: "Tabs");

            migrationBuilder.DropColumn(
                name: "TabPath",
                table: "Tabs");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Tabs");

            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "Tabs");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "Tabs");

            migrationBuilder.DropColumn(
                name: "VersionGUID",
                table: "Tabs");
        }
    }
}
