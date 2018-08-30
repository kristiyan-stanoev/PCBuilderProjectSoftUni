﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace PCBuilder.Data.Migrations
{
    public partial class RemovedFullName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "AspNetUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "AspNetUsers",
                maxLength: 100,
                nullable: true);
        }
    }
}
