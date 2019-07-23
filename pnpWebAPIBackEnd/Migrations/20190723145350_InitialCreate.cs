using Microsoft.EntityFrameworkCore.Migrations;

namespace pnpWebAPIBackEnd.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UsersDetails",
                columns: table => new
                {
                    Email = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Identification = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    DateofBirth = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    HomeNumber = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    WorkNumber = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    AddressType = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    StreetAddress = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Suburb = table.Column<string>(nullable: true),
                    City = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Province = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    CommsMethod = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    UserType = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    LoginStatus = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Active = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersDetails", x => x.Email);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersDetails");
        }
    }
}
