﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class initial_mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    City = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Province = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_Email",
                table: "Staffs",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Staffs");
        }
    }
}
