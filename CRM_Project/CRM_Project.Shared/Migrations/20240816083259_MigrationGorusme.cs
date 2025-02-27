using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRM_Project.Shared.Migrations
{
    /// <inheritdoc />
    public partial class MigrationGorusme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gorusmeler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriId = table.Column<int>(type: "int", nullable: false),
                    YetkiliAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GorusmeTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GorusmeNot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SonrakiGorusmeNot = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RandevuTarih = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gorusmeler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gorusmeler_Musteriler_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "Musteriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Gorusmeler_MusteriId",
                table: "Gorusmeler",
                column: "MusteriId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gorusmeler");
        }
    }
}
