using Microsoft.EntityFrameworkCore.Migrations;

namespace NailTechHelper.Data.Persistence.Migrations
{
    public partial class CreateBeautySalonBussinessestable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BeautySalonBussinesses",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YelpId = table.Column<string>(maxLength: 50, nullable: true),
                    Alias = table.Column<string>(maxLength: 500, nullable: true),
                    BusinessName = table.Column<string>(maxLength: 1000, nullable: true),
                    ImageURL = table.Column<string>(maxLength: 1000, nullable: true),
                    BusinessURL = table.Column<string>(maxLength: 1000, nullable: true),
                    Category = table.Column<string>(maxLength: 200, nullable: true),
                    Latitude = table.Column<decimal>(nullable: false),
                    Longitude = table.Column<decimal>(nullable: false),
                    Price = table.Column<string>(maxLength: 50, nullable: true),
                    Address1 = table.Column<string>(maxLength: 1000, nullable: true),
                    Address2 = table.Column<string>(maxLength: 1000, nullable: true),
                    Address3 = table.Column<string>(maxLength: 1000, nullable: true),
                    City = table.Column<string>(maxLength: 100, nullable: true),
                    ZipCode = table.Column<string>(maxLength: 50, nullable: true),
                    Country = table.Column<string>(maxLength: 100, nullable: true),
                    State = table.Column<string>(maxLength: 2, nullable: true),
                    DisplayAddress1 = table.Column<string>(maxLength: 1000, nullable: true),
                    DisplayAddress2 = table.Column<string>(maxLength: 1000, nullable: true),
                    PhoneNumber = table.Column<string>(maxLength: 50, nullable: true),
                    PhoneNumberDisplay = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeautySalonBussinesses", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BeautySalonBussinesses");
        }
    }
}
