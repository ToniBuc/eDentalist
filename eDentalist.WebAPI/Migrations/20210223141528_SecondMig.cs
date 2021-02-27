using Microsoft.EntityFrameworkCore.Migrations;

namespace eDentalist.WebAPI.Migrations
{
    public partial class SecondMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CityID",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CityID",
                table: "Bill",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CountryID",
                table: "Bill",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_User_CityID",
                table: "User",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_CityID",
                table: "Bill",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_CountryID",
                table: "Bill",
                column: "CountryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_City_CityID",
                table: "Bill",
                column: "CityID",
                principalTable: "City",
                principalColumn: "CityID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_Country_CountryID",
                table: "Bill",
                column: "CountryID",
                principalTable: "Country",
                principalColumn: "CountryID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_User_City_CityID",
                table: "User",
                column: "CityID",
                principalTable: "City",
                principalColumn: "CityID",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bill_City_CityID",
                table: "Bill");

            migrationBuilder.DropForeignKey(
                name: "FK_Bill_Country_CountryID",
                table: "Bill");

            migrationBuilder.DropForeignKey(
                name: "FK_User_City_CityID",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_CityID",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_Bill_CityID",
                table: "Bill");

            migrationBuilder.DropIndex(
                name: "IX_Bill_CountryID",
                table: "Bill");

            migrationBuilder.DropColumn(
                name: "CityID",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CityID",
                table: "Bill");

            migrationBuilder.DropColumn(
                name: "CountryID",
                table: "Bill");
        }
    }
}
