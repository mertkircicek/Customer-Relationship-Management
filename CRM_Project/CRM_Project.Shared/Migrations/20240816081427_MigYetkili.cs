using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRM_Project.Shared.Migrations
{
    /// <inheritdoc />
    public partial class MigYetkili : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Yetkili",
                table: "Musteriler",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Yetkili",
                table: "Musteriler");
        }
    }
}
