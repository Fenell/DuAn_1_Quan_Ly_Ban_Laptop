using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1_DAL_DataAccessLayer.Migrations
{
    public partial class chienco1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Laptop_SerialLaptop_SerialLaptopId",
                table: "Laptop");

            migrationBuilder.DropIndex(
                name: "IX_Laptop_SerialLaptopId",
                table: "Laptop");

            migrationBuilder.DropColumn(
                name: "SerialLaptopId",
                table: "Laptop");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "SerialLaptopId",
                table: "Laptop",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Laptop_SerialLaptopId",
                table: "Laptop",
                column: "SerialLaptopId");

            migrationBuilder.AddForeignKey(
                name: "FK_Laptop_SerialLaptop_SerialLaptopId",
                table: "Laptop",
                column: "SerialLaptopId",
                principalTable: "SerialLaptop",
                principalColumn: "Id");
        }
    }
}
