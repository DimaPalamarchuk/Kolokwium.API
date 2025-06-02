using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KolokwiumStudent.Migrations
{
    /// <inheritdoc />
    public partial class StudentSeed : Migration
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
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
