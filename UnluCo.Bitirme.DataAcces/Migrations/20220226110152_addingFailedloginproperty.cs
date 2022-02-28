using Microsoft.EntityFrameworkCore.Migrations;

namespace UnluCo.Bitirme.DataAcces.Migrations
{
    public partial class addingFailedloginproperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FiledLogin",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FiledLogin",
                table: "Users");
        }
    }
}
