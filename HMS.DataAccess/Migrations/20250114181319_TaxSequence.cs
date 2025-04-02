using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HMS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class TaxSequence : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Rate",
                table: "tax",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "taxsequence",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    TaxId = table.Column<Guid>(type: "uuid", nullable: false),
                    PrecedingTax = table.Column<Guid>(type: "uuid", nullable: false),
                    SourceFolioId = table.Column<Guid>(type: "uuid", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_taxsequence", x => x.Id);
                    table.ForeignKey(
                        name: "FK_taxsequence_tax_SourceFolioId",
                        column: x => x.SourceFolioId,
                        principalTable: "tax",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_taxsequence_tax_TaxId",
                        column: x => x.TaxId,
                        principalTable: "tax",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_taxsequence_SourceFolioId",
                table: "taxsequence",
                column: "SourceFolioId");

            migrationBuilder.CreateIndex(
                name: "IX_taxsequence_TaxId",
                table: "taxsequence",
                column: "TaxId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "taxsequence");

            migrationBuilder.DropColumn(
                name: "Rate",
                table: "tax");
        }
    }
}
