﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelProject.DataAccesLayer.Migrations
{
    public partial class mig_addWorkLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WorkDepartman",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WorkLocationId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "WorkLocations",
                columns: table => new
                {
                    WorkLocationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkLocationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkLocationCity = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkLocations", x => x.WorkLocationId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_WorkLocationId",
                table: "AspNetUsers",
                column: "WorkLocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_WorkLocations_WorkLocationId",
                table: "AspNetUsers",
                column: "WorkLocationId",
                principalTable: "WorkLocations",
                principalColumn: "WorkLocationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_WorkLocations_WorkLocationId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "WorkLocations");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_WorkLocationId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "WorkDepartman",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "WorkLocationId",
                table: "AspNetUsers");
        }
    }
}
