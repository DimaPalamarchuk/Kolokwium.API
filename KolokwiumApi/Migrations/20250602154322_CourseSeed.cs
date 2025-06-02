using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KolokwiumApi.Migrations
{
    public partial class CourseSeed : Migration
    {
        private void InsertData(MigrationBuilder migrationBuilder, string name, int numberOfHours)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                schema: "kolokwium",
                columns: new[] { "Name", "NumberOfHours", "IsActive" },
                values: new object[] { name, numberOfHours, true }
            );
        }

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            InsertData(migrationBuilder, "Informatyka podstawy", 30);
            InsertData(migrationBuilder, "Programowanie obiektowe", 120);
            InsertData(migrationBuilder, "Bazy danych", 100);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Optional: delete seeded data here if needed
        }
    }
}
