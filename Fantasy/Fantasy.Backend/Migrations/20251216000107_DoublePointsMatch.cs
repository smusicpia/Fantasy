using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fantasy.Backend.Migrations
{
    /// <inheritdoc />
    public partial class DoublePointsMatch : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "DoublePoints",
                table: "Matches",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DoublePoints",
                table: "Matches");
        }
    }
}
