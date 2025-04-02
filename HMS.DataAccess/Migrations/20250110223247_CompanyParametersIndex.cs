using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HMS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class CompanyParametersIndex : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                table: "companyparemeters",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_companyparemeters_CompanyId",
                table: "companyparemeters",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_companyparemeters_company_CompanyId",
                table: "companyparemeters",
                column: "CompanyId",
                principalTable: "company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_companyparemeters_company_CompanyId",
                table: "companyparemeters");

            migrationBuilder.DropIndex(
                name: "IX_companyparemeters_CompanyId",
                table: "companyparemeters");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "companyparemeters");
        }
    }
}
