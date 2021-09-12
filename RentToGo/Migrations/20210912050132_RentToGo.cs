using Microsoft.EntityFrameworkCore.Migrations;

namespace RentToGo.Migrations
{
    public partial class RentToGo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cust_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cust_LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cust_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cust_Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cust_Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cust_Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Property",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Property_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Property_WeeklyRent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Property_Number_of_Bedrooms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Property_Number_of_Bathrooms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Property_Location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Agent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cust_Id = table.Column<int>(type: "int", nullable: true),
                    Property_Id = table.Column<int>(type: "int", nullable: true),
                    Agent_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Agent_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Agent_Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Office_Location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Agent_Customer_Cust_Id",
                        column: x => x.Cust_Id,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Agent_Property_Property_Id",
                        column: x => x.Property_Id,
                        principalTable: "Property",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agent_Cust_Id",
                table: "Agent",
                column: "Cust_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Agent_Property_Id",
                table: "Agent",
                column: "Property_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agent");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Property");
        }
    }
}
