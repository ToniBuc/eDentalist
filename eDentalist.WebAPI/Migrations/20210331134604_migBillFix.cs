using Microsoft.EntityFrameworkCore.Migrations;

namespace eDentalist.WebAPI.Migrations
{
    public partial class migBillFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bill_City_CityID",
                table: "Bill");

            migrationBuilder.DropForeignKey(
                name: "FK_Bill_Country_CountryID",
                table: "Bill");

            migrationBuilder.DropIndex(
                name: "IX_Bill_CityID",
                table: "Bill");

            migrationBuilder.DropIndex(
                name: "IX_Bill_CountryID",
                table: "Bill");

            migrationBuilder.DropColumn(
                name: "CityID",
                table: "Bill");

            migrationBuilder.DropColumn(
                name: "CountryID",
                table: "Bill");

            migrationBuilder.DropColumn(
                name: "UserAddress",
                table: "Bill");

            migrationBuilder.DropColumn(
                name: "UserCity",
                table: "Bill");

            migrationBuilder.DropColumn(
                name: "UserCountry",
                table: "Bill");

            migrationBuilder.DropColumn(
                name: "UserFirstName",
                table: "Bill");

            migrationBuilder.DropColumn(
                name: "UserLastName",
                table: "Bill");

            migrationBuilder.AlterColumn<bool>(
                name: "IsPaid",
                table: "Bill",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<decimal>(
                name: "PaymentAmount",
                table: "Bill",
                type: "DECIMAL(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentAmount",
                table: "Bill");

            migrationBuilder.AlterColumn<bool>(
                name: "IsPaid",
                table: "Bill",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT");

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

            migrationBuilder.AddColumn<string>(
                name: "UserAddress",
                table: "Bill",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCity",
                table: "Bill",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCountry",
                table: "Bill",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserFirstName",
                table: "Bill",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserLastName",
                table: "Bill",
                type: "nvarchar(max)",
                nullable: true);

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
        }
    }
}
