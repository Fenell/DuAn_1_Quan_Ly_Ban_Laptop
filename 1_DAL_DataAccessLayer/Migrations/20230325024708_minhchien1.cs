using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1_DAL_DataAccessLayer.Migrations
{
    public partial class minhchien1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ten",
                table: "Laptop",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ten",
                table: "Laptop");
        }
    }
}
