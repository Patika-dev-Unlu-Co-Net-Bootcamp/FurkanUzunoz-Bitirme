using Microsoft.EntityFrameworkCore.Migrations;

namespace UnluCo.Bitirme.DataAcces.Migrations
{
    public partial class AddedIsOfferActive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isOfferActive",
                table: "Offers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isOfferActive",
                table: "Offers");
        }
    }
}
