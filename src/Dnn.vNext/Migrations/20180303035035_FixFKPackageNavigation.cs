using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Dnn.vNext.Migrations
{
    public partial class FixFKPackageNavigation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Packages_Packages_PackageTypeNavigationPackageId",
                table: "Packages");

            migrationBuilder.DropIndex(
                name: "IX_Packages_PackageTypeNavigationPackageId",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "PackageTypeNavigationPackageId",
                table: "Packages");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PackageTypeNavigationPackageId",
                table: "Packages",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Packages_PackageTypeNavigationPackageId",
                table: "Packages",
                column: "PackageTypeNavigationPackageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Packages_Packages_PackageTypeNavigationPackageId",
                table: "Packages",
                column: "PackageTypeNavigationPackageId",
                principalTable: "Packages",
                principalColumn: "PackageId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
