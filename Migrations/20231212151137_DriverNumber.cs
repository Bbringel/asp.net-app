using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcMoto.Migrations
{
    /// <inheritdoc />
    public partial class DriverNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DriverNumber",
                table: "Moto",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DriverNumber",
                table: "Moto");
        }
    }
}
