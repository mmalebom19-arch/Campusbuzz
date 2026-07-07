using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CampusBuzzAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreEvents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EventTitle", "Location", "TicketPrice" },
                values: new object[] { "Hackathon ", "IT Building", "Free" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EventTitle", "Location", "TicketPrice" },
                values: new object[] { "UP Ovuwa", "Amphitheatre", "R120" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EventTitle", "TicketPrice" },
                values: new object[] { "Tuks Camarata", "R250" });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "EventTitle", "Location", "TicketPrice" },
                values: new object[,]
                {
                    { 4, "Career Fair", "Main Hall", "Free" },
                    { 5, "150 Years of Tuks", "Hatfield Campus", "R80" },
                    { 6, "Sports Day", "LC", "R30" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EventTitle", "Location", "TicketPrice" },
                values: new object[] { "Tech Workshop", "Lab A", "$50" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EventTitle", "Location", "TicketPrice" },
                values: new object[] { "Music Festival", "Main Hall", "$120" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EventTitle", "TicketPrice" },
                values: new object[] { "Startup Pitch", "Free" });
        }
    }
}
