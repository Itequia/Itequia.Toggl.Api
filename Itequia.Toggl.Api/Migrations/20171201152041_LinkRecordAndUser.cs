using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Itequia.Toggl.Api.Migrations
{
    public partial class LinkRecordAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Records",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Records_ApplicationUserId",
                table: "Records",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Records_AspNetUsers_ApplicationUserId",
                table: "Records",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Records_AspNetUsers_ApplicationUserId",
                table: "Records");

            migrationBuilder.DropIndex(
                name: "IX_Records_ApplicationUserId",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Records");
        }
    }
}
