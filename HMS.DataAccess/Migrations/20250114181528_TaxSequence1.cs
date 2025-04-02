using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HMS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class TaxSequence1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_taxsequence_tax_SourceFolioId",
                table: "taxsequence");

            migrationBuilder.DropIndex(
                name: "IX_taxsequence_SourceFolioId",
                table: "taxsequence");

            migrationBuilder.DropColumn(
                name: "SourceFolioId",
                table: "taxsequence");

            migrationBuilder.CreateIndex(
                name: "IX_taxsequence_PrecedingTax",
                table: "taxsequence",
                column: "PrecedingTax");

            migrationBuilder.AddForeignKey(
                name: "FK_taxsequence_tax_PrecedingTax",
                table: "taxsequence",
                column: "PrecedingTax",
                principalTable: "tax",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_taxsequence_tax_PrecedingTax",
                table: "taxsequence");

            migrationBuilder.DropIndex(
                name: "IX_taxsequence_PrecedingTax",
                table: "taxsequence");

            migrationBuilder.AddColumn<Guid>(
                name: "SourceFolioId",
                table: "taxsequence",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_taxsequence_SourceFolioId",
                table: "taxsequence",
                column: "SourceFolioId");

            migrationBuilder.AddForeignKey(
                name: "FK_taxsequence_tax_SourceFolioId",
                table: "taxsequence",
                column: "SourceFolioId",
                principalTable: "tax",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
