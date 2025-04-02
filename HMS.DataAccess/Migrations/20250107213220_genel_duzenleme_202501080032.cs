using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HMS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class genel_duzenleme_202501080032 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "enterprise",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_enterprise", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "company",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_company", x => x.Id);
                    table.ForeignKey(
                        name: "FK_company_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "referance",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_referance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_referance_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "agency",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_agency", x => x.Id);
                    table.ForeignKey(
                        name: "FK_agency_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_agency_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_agency_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "bank",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bank", x => x.Id);
                    table.ForeignKey(
                        name: "FK_bank_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_bank_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_bank_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "boardinghouse",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_boardinghouse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_boardinghouse_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_boardinghouse_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_boardinghouse_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "category",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Pax = table.Column<int>(type: "integer", nullable: false),
                    Child = table.Column<int>(type: "integer", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_category", x => x.Id);
                    table.ForeignKey(
                        name: "FK_category_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_category_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_category_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "condition",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    AgreementDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    SaleDateStart = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    SaleDateEnd = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    StayDateStart = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    StayDateEnd = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    MinDay = table.Column<int>(type: "integer", nullable: false),
                    MaxDay = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_condition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_condition_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_condition_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_condition_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "country",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    IsoCode = table.Column<string>(type: "text", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_country", x => x.Id);
                    table.ForeignKey(
                        name: "FK_country_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_country_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_country_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "diagnosis",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_diagnosis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_diagnosis_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_diagnosis_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_diagnosis_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "floor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_floor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_floor_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_floor_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_floor_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "formule",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_formule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_formule_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_formule_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_formule_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "guest",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false),
                    FullName = table.Column<string>(type: "text", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Gender = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_guest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_guest_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_guest_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_guest_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hkcode",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Color = table.Column<string>(type: "text", nullable: false),
                    CleanCode = table.Column<int>(type: "integer", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hkcode", x => x.Id);
                    table.ForeignKey(
                        name: "FK_hkcode_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_hkcode_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_hkcode_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hospital",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    HospitalName = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    ContactPerson = table.Column<string>(type: "text", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hospital", x => x.Id);
                    table.ForeignKey(
                        name: "FK_hospital_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_hospital_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_hospital_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "market",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_market", x => x.Id);
                    table.ForeignKey(
                        name: "FK_market_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_market_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_market_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "medicalactiontype",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicalactiontype", x => x.Id);
                    table.ForeignKey(
                        name: "FK_medicalactiontype_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_medicalactiontype_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_medicalactiontype_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "medicalstaffrole",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    RoleName = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicalstaffrole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_medicalstaffrole_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_medicalstaffrole_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_medicalstaffrole_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "outof",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    SaleType = table.Column<int>(type: "integer", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_outof", x => x.Id);
                    table.ForeignKey(
                        name: "FK_outof_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_outof_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_outof_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "packettype",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    Additional = table.Column<bool>(type: "boolean", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_packettype", x => x.Id);
                    table.ForeignKey(
                        name: "FK_packettype_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_packettype_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_packettype_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "paymenttype",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Types = table.Column<int>(type: "integer", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paymenttype", x => x.Id);
                    table.ForeignKey(
                        name: "FK_paymenttype_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_paymenttype_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_paymenttype_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pricelocation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pricelocation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_pricelocation_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pricelocation_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pricelocation_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pricetype",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Pax = table.Column<int>(type: "integer", nullable: false),
                    Child = table.Column<int>(type: "integer", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pricetype", x => x.Id);
                    table.ForeignKey(
                        name: "FK_pricetype_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pricetype_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pricetype_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "reservationproperties",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reservationproperties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_reservationproperties_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reservationproperties_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reservationproperties_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "reservationrecord",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    GroupVoucher = table.Column<string>(type: "text", nullable: false),
                    IsShare = table.Column<bool>(type: "boolean", nullable: false),
                    IsGroup = table.Column<bool>(type: "boolean", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reservationrecord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_reservationrecord_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reservationrecord_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reservationrecord_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "roomlocation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roomlocation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_roomlocation_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_roomlocation_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_roomlocation_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "roomproperties",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roomproperties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_roomproperties_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_roomproperties_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_roomproperties_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "symptom",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_symptom", x => x.Id);
                    table.ForeignKey(
                        name: "FK_symptom_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_symptom_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_symptom_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tax",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tax", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tax_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tax_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tax_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "viptype",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_viptype", x => x.Id);
                    table.ForeignKey(
                        name: "FK_viptype_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_viptype_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_viptype_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "currency",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    BankId = table.Column<Guid>(type: "uuid", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_currency", x => x.Id);
                    table.ForeignKey(
                        name: "FK_currency_bank_BankId",
                        column: x => x.BankId,
                        principalTable: "bank",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_currency_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_currency_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_currency_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "contract",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    ConditionId = table.Column<Guid>(type: "uuid", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contract", x => x.Id);
                    table.ForeignKey(
                        name: "FK_contract_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_contract_condition_ConditionId",
                        column: x => x.ConditionId,
                        principalTable: "condition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_contract_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_contract_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "nationality",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    CountryId = table.Column<Guid>(type: "uuid", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nationality", x => x.Id);
                    table.ForeignKey(
                        name: "FK_nationality_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_nationality_country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_nationality_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_nationality_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "state",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CountryId = table.Column<Guid>(type: "uuid", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_state", x => x.Id);
                    table.ForeignKey(
                        name: "FK_state_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_state_country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_state_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_state_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "medicalstaff",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Specialty = table.Column<string>(type: "text", nullable: false),
                    MedicalStaffRoleId = table.Column<Guid>(type: "uuid", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false),
                    FullName = table.Column<string>(type: "text", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Gender = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicalstaff", x => x.Id);
                    table.ForeignKey(
                        name: "FK_medicalstaff_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_medicalstaff_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_medicalstaff_medicalstaffrole_MedicalStaffRoleId",
                        column: x => x.MedicalStaffRoleId,
                        principalTable: "medicalstaffrole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_medicalstaff_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "outoffloor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    OutOfId = table.Column<Guid>(type: "uuid", nullable: false),
                    FloorId = table.Column<Guid>(type: "uuid", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_outoffloor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_outoffloor_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_outoffloor_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_outoffloor_floor_FloorId",
                        column: x => x.FloorId,
                        principalTable: "floor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_outoffloor_outof_OutOfId",
                        column: x => x.OutOfId,
                        principalTable: "outof",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_outoffloor_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "formuledetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    FormuleId = table.Column<Guid>(type: "uuid", nullable: false),
                    PacketTypeId = table.Column<Guid>(type: "uuid", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Cumulative = table.Column<bool>(type: "boolean", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_formuledetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_formuledetail_formule_FormuleId",
                        column: x => x.FormuleId,
                        principalTable: "formule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_formuledetail_packettype_PacketTypeId",
                        column: x => x.PacketTypeId,
                        principalTable: "packettype",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "outofroomlocation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    OutOfId = table.Column<Guid>(type: "uuid", nullable: false),
                    RoomLocationId = table.Column<Guid>(type: "uuid", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_outofroomlocation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_outofroomlocation_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_outofroomlocation_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_outofroomlocation_outof_OutOfId",
                        column: x => x.OutOfId,
                        principalTable: "outof",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_outofroomlocation_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_outofroomlocation_roomlocation_RoomLocationId",
                        column: x => x.RoomLocationId,
                        principalTable: "roomlocation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "room",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    RoomLocationId = table.Column<Guid>(type: "uuid", nullable: false),
                    FloorId = table.Column<Guid>(type: "uuid", nullable: false),
                    HKCodeId = table.Column<Guid>(type: "uuid", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_room", x => x.Id);
                    table.ForeignKey(
                        name: "FK_room_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_room_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_room_floor_FloorId",
                        column: x => x.FloorId,
                        principalTable: "floor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_room_hkcode_HKCodeId",
                        column: x => x.HKCodeId,
                        principalTable: "hkcode",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_room_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_room_roomlocation_RoomLocationId",
                        column: x => x.RoomLocationId,
                        principalTable: "roomlocation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "department",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    TaxId = table.Column<Guid>(type: "uuid", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_department", x => x.Id);
                    table.ForeignKey(
                        name: "FK_department_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_department_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_department_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_department_tax_TaxId",
                        column: x => x.TaxId,
                        principalTable: "tax",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "reservationdetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    CinDate = table.Column<DateTime>(type: "date", nullable: true),
                    CoutDate = table.Column<DateTime>(type: "date", nullable: true),
                    ReservationOrder = table.Column<int>(type: "integer", nullable: false),
                    RoomLocationId = table.Column<Guid>(type: "uuid", nullable: false),
                    PriceLocationId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReservationRecordId = table.Column<Guid>(type: "uuid", nullable: false),
                    Voucher = table.Column<string>(type: "text", nullable: false),
                    IsFixedPrice = table.Column<bool>(type: "boolean", nullable: false),
                    IsFixedRate = table.Column<bool>(type: "boolean", nullable: false),
                    FixedPrice = table.Column<double>(type: "double precision", nullable: true),
                    FixedRate = table.Column<double>(type: "double precision", nullable: true),
                    CurrencyId = table.Column<Guid>(type: "uuid", nullable: false),
                    BoardingHouseId = table.Column<Guid>(type: "uuid", nullable: false),
                    AgencyId = table.Column<Guid>(type: "uuid", nullable: false),
                    MarketId = table.Column<Guid>(type: "uuid", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reservationdetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_reservationdetail_agency_AgencyId",
                        column: x => x.AgencyId,
                        principalTable: "agency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reservationdetail_boardinghouse_BoardingHouseId",
                        column: x => x.BoardingHouseId,
                        principalTable: "boardinghouse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reservationdetail_currency_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "currency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reservationdetail_market_MarketId",
                        column: x => x.MarketId,
                        principalTable: "market",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reservationdetail_pricelocation_PriceLocationId",
                        column: x => x.PriceLocationId,
                        principalTable: "pricelocation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reservationdetail_reservationrecord_ReservationRecordId",
                        column: x => x.ReservationRecordId,
                        principalTable: "reservationrecord",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reservationdetail_roomlocation_RoomLocationId",
                        column: x => x.RoomLocationId,
                        principalTable: "roomlocation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "contractagency",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    AgencyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ContractId = table.Column<Guid>(type: "uuid", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contractagency", x => x.Id);
                    table.ForeignKey(
                        name: "FK_contractagency_agency_AgencyId",
                        column: x => x.AgencyId,
                        principalTable: "agency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_contractagency_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_contractagency_contract_ContractId",
                        column: x => x.ContractId,
                        principalTable: "contract",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_contractagency_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_contractagency_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "contractperiod",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    StartDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ContractId = table.Column<Guid>(type: "uuid", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contractperiod", x => x.Id);
                    table.ForeignKey(
                        name: "FK_contractperiod_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_contractperiod_contract_ContractId",
                        column: x => x.ContractId,
                        principalTable: "contract",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_contractperiod_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_contractperiod_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "packets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    ContractId = table.Column<Guid>(type: "uuid", nullable: false),
                    ConditionId = table.Column<Guid>(type: "uuid", nullable: false),
                    PacketTypeId = table.Column<Guid>(type: "uuid", nullable: false),
                    Ratio = table.Column<double>(type: "double precision", nullable: true),
                    Price = table.Column<double>(type: "double precision", nullable: true),
                    AgencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_packets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_packets_agency_AgencyId",
                        column: x => x.AgencyId,
                        principalTable: "agency",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_packets_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_packets_condition_ConditionId",
                        column: x => x.ConditionId,
                        principalTable: "condition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_packets_contract_ContractId",
                        column: x => x.ContractId,
                        principalTable: "contract",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_packets_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_packets_packettype_PacketTypeId",
                        column: x => x.PacketTypeId,
                        principalTable: "packettype",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_packets_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "city",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Name = table.Column<string>(type: "text", nullable: false),
                    StateId = table.Column<Guid>(type: "uuid", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_city", x => x.Id);
                    table.ForeignKey(
                        name: "FK_city_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_city_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_city_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_city_state_StateId",
                        column: x => x.StateId,
                        principalTable: "state",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "email",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    EmailAddress = table.Column<string>(type: "text", nullable: false),
                    GuestId = table.Column<Guid>(type: "uuid", nullable: true),
                    MedicalStaffId = table.Column<Guid>(type: "uuid", nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_email", x => x.Id);
                    table.ForeignKey(
                        name: "FK_email_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_email_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_email_guest_GuestId",
                        column: x => x.GuestId,
                        principalTable: "guest",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_email_medicalstaff_MedicalStaffId",
                        column: x => x.MedicalStaffId,
                        principalTable: "medicalstaff",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_email_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "healthrecord",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    GuestId = table.Column<Guid>(type: "uuid", nullable: false),
                    IncidentDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ActionTypeId = table.Column<Guid>(type: "uuid", nullable: false),
                    HospitalId = table.Column<Guid>(type: "uuid", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    MedicalStaffId = table.Column<Guid>(type: "uuid", nullable: false),
                    MedicalActionTypeId = table.Column<Guid>(type: "uuid", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_healthrecord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_healthrecord_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_healthrecord_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_healthrecord_guest_GuestId",
                        column: x => x.GuestId,
                        principalTable: "guest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_healthrecord_hospital_HospitalId",
                        column: x => x.HospitalId,
                        principalTable: "hospital",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_healthrecord_medicalactiontype_MedicalActionTypeId",
                        column: x => x.MedicalActionTypeId,
                        principalTable: "medicalactiontype",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_healthrecord_medicalstaff_MedicalStaffId",
                        column: x => x.MedicalStaffId,
                        principalTable: "medicalstaff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_healthrecord_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "phone",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    GuestId = table.Column<Guid>(type: "uuid", nullable: true),
                    MedicalStaffId = table.Column<Guid>(type: "uuid", nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_phone", x => x.Id);
                    table.ForeignKey(
                        name: "FK_phone_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_phone_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_phone_guest_GuestId",
                        column: x => x.GuestId,
                        principalTable: "guest",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_phone_medicalstaff_MedicalStaffId",
                        column: x => x.MedicalStaffId,
                        principalTable: "medicalstaff",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_phone_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "routinecheckup",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    GuestId = table.Column<Guid>(type: "uuid", nullable: false),
                    MedicalStaffId = table.Column<Guid>(type: "uuid", nullable: false),
                    Location = table.Column<int>(type: "integer", nullable: false),
                    HospitalId = table.Column<Guid>(type: "uuid", nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_routinecheckup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_routinecheckup_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_routinecheckup_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_routinecheckup_guest_GuestId",
                        column: x => x.GuestId,
                        principalTable: "guest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_routinecheckup_hospital_HospitalId",
                        column: x => x.HospitalId,
                        principalTable: "hospital",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_routinecheckup_medicalstaff_MedicalStaffId",
                        column: x => x.MedicalStaffId,
                        principalTable: "medicalstaff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_routinecheckup_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "outoffroom",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    OutOfId = table.Column<Guid>(type: "uuid", nullable: false),
                    RoomId = table.Column<Guid>(type: "uuid", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_outoffroom", x => x.Id);
                    table.ForeignKey(
                        name: "FK_outoffroom_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_outoffroom_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_outoffroom_outof_OutOfId",
                        column: x => x.OutOfId,
                        principalTable: "outof",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_outoffroom_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_outoffroom_room_RoomId",
                        column: x => x.RoomId,
                        principalTable: "room",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "folio",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    ReservationDetailId = table.Column<Guid>(type: "uuid", nullable: false),
                    No = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    InvoiceId = table.Column<Guid>(type: "uuid", nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_folio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_folio_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_folio_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_folio_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_folio_reservationdetail_ReservationDetailId",
                        column: x => x.ReservationDetailId,
                        principalTable: "reservationdetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "reservationdaily",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    RoomId = table.Column<Guid>(type: "uuid", nullable: true),
                    Pax = table.Column<int>(type: "integer", nullable: false),
                    Child = table.Column<int>(type: "integer", nullable: false),
                    Free = table.Column<int>(type: "integer", nullable: false),
                    Beb = table.Column<int>(type: "integer", nullable: false),
                    ReservationDetailId = table.Column<Guid>(type: "uuid", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reservationdaily", x => x.Id);
                    table.ForeignKey(
                        name: "FK_reservationdaily_reservationdetail_ReservationDetailId",
                        column: x => x.ReservationDetailId,
                        principalTable: "reservationdetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reservationdaily_room_RoomId",
                        column: x => x.RoomId,
                        principalTable: "room",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "periodprices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    ContractPeriodId = table.Column<Guid>(type: "uuid", nullable: false),
                    RoomLocationId = table.Column<Guid>(type: "uuid", nullable: false),
                    PriceTypeId = table.Column<Guid>(type: "uuid", nullable: false),
                    RawPrice = table.Column<double>(type: "double precision", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_periodprices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_periodprices_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_periodprices_contractperiod_ContractPeriodId",
                        column: x => x.ContractPeriodId,
                        principalTable: "contractperiod",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_periodprices_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_periodprices_pricetype_PriceTypeId",
                        column: x => x.PriceTypeId,
                        principalTable: "pricetype",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_periodprices_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_periodprices_roomlocation_RoomLocationId",
                        column: x => x.RoomLocationId,
                        principalTable: "roomlocation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "address",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    CityId = table.Column<Guid>(type: "uuid", nullable: false),
                    Street = table.Column<string>(type: "text", nullable: false),
                    PostalCode = table.Column<string>(type: "text", nullable: false),
                    CountryId = table.Column<Guid>(type: "uuid", nullable: false),
                    GuestId = table.Column<Guid>(type: "uuid", nullable: true),
                    MedicalStaffId = table.Column<Guid>(type: "uuid", nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_address", x => x.Id);
                    table.ForeignKey(
                        name: "FK_address_city_CityId",
                        column: x => x.CityId,
                        principalTable: "city",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_address_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_address_country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_address_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_address_guest_GuestId",
                        column: x => x.GuestId,
                        principalTable: "guest",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_address_medicalstaff_MedicalStaffId",
                        column: x => x.MedicalStaffId,
                        principalTable: "medicalstaff",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_address_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "healthrecorddiagnosis",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    HealthRecordId = table.Column<Guid>(type: "uuid", nullable: false),
                    DiagnosisId = table.Column<Guid>(type: "uuid", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_healthrecorddiagnosis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_healthrecorddiagnosis_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_healthrecorddiagnosis_diagnosis_DiagnosisId",
                        column: x => x.DiagnosisId,
                        principalTable: "diagnosis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_healthrecorddiagnosis_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_healthrecorddiagnosis_healthrecord_HealthRecordId",
                        column: x => x.HealthRecordId,
                        principalTable: "healthrecord",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_healthrecorddiagnosis_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "healthrecordsymptom",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    HealthRecordId = table.Column<Guid>(type: "uuid", nullable: false),
                    SymptomId = table.Column<Guid>(type: "uuid", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_healthrecordsymptom", x => x.Id);
                    table.ForeignKey(
                        name: "FK_healthrecordsymptom_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_healthrecordsymptom_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_healthrecordsymptom_healthrecord_HealthRecordId",
                        column: x => x.HealthRecordId,
                        principalTable: "healthrecord",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_healthrecordsymptom_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_healthrecordsymptom_symptom_SymptomId",
                        column: x => x.SymptomId,
                        principalTable: "symptom",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "dailyprocedure",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    RoutineCheckupId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProcedureDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dailyprocedure", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dailyprocedure_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dailyprocedure_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dailyprocedure_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dailyprocedure_routinecheckup_RoutineCheckupId",
                        column: x => x.RoutineCheckupId,
                        principalTable: "routinecheckup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "foliodetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    FolioId = table.Column<Guid>(type: "uuid", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uuid", nullable: false),
                    CurrencyId = table.Column<Guid>(type: "uuid", nullable: false),
                    Amount = table.Column<double>(type: "double precision", nullable: false),
                    LocalAmount = table.Column<double>(type: "double precision", nullable: false),
                    Rate = table.Column<double>(type: "double precision", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Time = table.Column<TimeSpan>(type: "interval", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    TaxId = table.Column<Guid>(type: "uuid", nullable: false),
                    Remark = table.Column<string>(type: "text", nullable: false),
                    SourceFolioId = table.Column<Guid>(type: "uuid", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_foliodetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_foliodetail_currency_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "currency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_foliodetail_department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_foliodetail_folio_FolioId",
                        column: x => x.FolioId,
                        principalTable: "folio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_foliodetail_folio_SourceFolioId",
                        column: x => x.SourceFolioId,
                        principalTable: "folio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_foliodetail_tax_TaxId",
                        column: x => x.TaxId,
                        principalTable: "tax",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "reservastiondailyguest",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    ReservationDetailId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReservationDailyId = table.Column<Guid>(type: "uuid", nullable: false),
                    GuestOrder = table.Column<int>(type: "integer", nullable: false),
                    GuestId = table.Column<Guid>(type: "uuid", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reservastiondailyguest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_reservastiondailyguest_guest_GuestId",
                        column: x => x.GuestId,
                        principalTable: "guest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reservastiondailyguest_reservationdaily_ReservationDailyId",
                        column: x => x.ReservationDailyId,
                        principalTable: "reservationdaily",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "reservationdailypricedetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Amount = table.Column<double>(type: "double precision", nullable: false),
                    ReservationDailyId = table.Column<Guid>(type: "uuid", nullable: false),
                    PeriodPricesId = table.Column<Guid>(type: "uuid", nullable: true),
                    PacketsId = table.Column<Guid>(type: "uuid", nullable: true),
                    FormuleDetailId = table.Column<Guid>(type: "uuid", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reservationdailypricedetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_reservationdailypricedetail_formuledetail_FormuleDetailId",
                        column: x => x.FormuleDetailId,
                        principalTable: "formuledetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reservationdailypricedetail_packets_PacketsId",
                        column: x => x.PacketsId,
                        principalTable: "packets",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_reservationdailypricedetail_periodprices_PeriodPricesId",
                        column: x => x.PeriodPricesId,
                        principalTable: "periodprices",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_reservationdailypricedetail_reservationdaily_ReservationDai~",
                        column: x => x.ReservationDailyId,
                        principalTable: "reservationdaily",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "proceduretype",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    DailyProcedureId = table.Column<Guid>(type: "uuid", nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Inactive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uuid", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReferanceId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_proceduretype", x => x.Id);
                    table.ForeignKey(
                        name: "FK_proceduretype_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_proceduretype_dailyprocedure_DailyProcedureId",
                        column: x => x.DailyProcedureId,
                        principalTable: "dailyprocedure",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_proceduretype_enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_proceduretype_referance_ReferanceId",
                        column: x => x.ReferanceId,
                        principalTable: "referance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_address_CityId",
                table: "address",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_address_CompanyId",
                table: "address",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_address_CountryId",
                table: "address",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_address_EnterpriseId",
                table: "address",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_address_GuestId",
                table: "address",
                column: "GuestId");

            migrationBuilder.CreateIndex(
                name: "IX_address_MedicalStaffId",
                table: "address",
                column: "MedicalStaffId");

            migrationBuilder.CreateIndex(
                name: "IX_address_ReferanceId",
                table: "address",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_agency_CompanyId",
                table: "agency",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_agency_EnterpriseId",
                table: "agency",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_agency_ReferanceId",
                table: "agency",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_bank_CompanyId",
                table: "bank",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_bank_EnterpriseId",
                table: "bank",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_bank_ReferanceId",
                table: "bank",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_boardinghouse_CompanyId",
                table: "boardinghouse",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_boardinghouse_EnterpriseId",
                table: "boardinghouse",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_boardinghouse_ReferanceId",
                table: "boardinghouse",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_category_CompanyId",
                table: "category",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_category_EnterpriseId",
                table: "category",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_category_ReferanceId",
                table: "category",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_city_CompanyId",
                table: "city",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_city_EnterpriseId",
                table: "city",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_city_ReferanceId",
                table: "city",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_city_StateId",
                table: "city",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_company_EnterpriseId",
                table: "company",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_condition_CompanyId",
                table: "condition",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_condition_EnterpriseId",
                table: "condition",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_condition_ReferanceId",
                table: "condition",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_contract_CompanyId",
                table: "contract",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_contract_ConditionId",
                table: "contract",
                column: "ConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_contract_EnterpriseId",
                table: "contract",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_contract_ReferanceId",
                table: "contract",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_contractagency_AgencyId",
                table: "contractagency",
                column: "AgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_contractagency_CompanyId",
                table: "contractagency",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_contractagency_ContractId",
                table: "contractagency",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_contractagency_EnterpriseId",
                table: "contractagency",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_contractagency_ReferanceId",
                table: "contractagency",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_contractperiod_CompanyId",
                table: "contractperiod",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_contractperiod_ContractId",
                table: "contractperiod",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_contractperiod_EnterpriseId",
                table: "contractperiod",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_contractperiod_ReferanceId",
                table: "contractperiod",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_country_CompanyId",
                table: "country",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_country_EnterpriseId",
                table: "country",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_country_ReferanceId",
                table: "country",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_currency_BankId",
                table: "currency",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_currency_CompanyId",
                table: "currency",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_currency_EnterpriseId",
                table: "currency",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_currency_ReferanceId",
                table: "currency",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_dailyprocedure_CompanyId",
                table: "dailyprocedure",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_dailyprocedure_EnterpriseId",
                table: "dailyprocedure",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_dailyprocedure_ReferanceId",
                table: "dailyprocedure",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_dailyprocedure_RoutineCheckupId",
                table: "dailyprocedure",
                column: "RoutineCheckupId");

            migrationBuilder.CreateIndex(
                name: "IX_department_CompanyId",
                table: "department",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_department_EnterpriseId",
                table: "department",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_department_ReferanceId",
                table: "department",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_department_TaxId",
                table: "department",
                column: "TaxId");

            migrationBuilder.CreateIndex(
                name: "IX_diagnosis_CompanyId",
                table: "diagnosis",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_diagnosis_EnterpriseId",
                table: "diagnosis",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_diagnosis_ReferanceId",
                table: "diagnosis",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_email_CompanyId",
                table: "email",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_email_EnterpriseId",
                table: "email",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_email_GuestId",
                table: "email",
                column: "GuestId");

            migrationBuilder.CreateIndex(
                name: "IX_email_MedicalStaffId",
                table: "email",
                column: "MedicalStaffId");

            migrationBuilder.CreateIndex(
                name: "IX_email_ReferanceId",
                table: "email",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_floor_CompanyId",
                table: "floor",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_floor_EnterpriseId",
                table: "floor",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_floor_ReferanceId",
                table: "floor",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_folio_CompanyId",
                table: "folio",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_folio_EnterpriseId",
                table: "folio",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_folio_ReferanceId",
                table: "folio",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_folio_ReservationDetailId",
                table: "folio",
                column: "ReservationDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_foliodetail_CurrencyId",
                table: "foliodetail",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_foliodetail_DepartmentId",
                table: "foliodetail",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_foliodetail_FolioId",
                table: "foliodetail",
                column: "FolioId");

            migrationBuilder.CreateIndex(
                name: "IX_foliodetail_SourceFolioId",
                table: "foliodetail",
                column: "SourceFolioId");

            migrationBuilder.CreateIndex(
                name: "IX_foliodetail_TaxId",
                table: "foliodetail",
                column: "TaxId");

            migrationBuilder.CreateIndex(
                name: "IX_formule_CompanyId",
                table: "formule",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_formule_EnterpriseId",
                table: "formule",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_formule_ReferanceId",
                table: "formule",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_formuledetail_FormuleId",
                table: "formuledetail",
                column: "FormuleId");

            migrationBuilder.CreateIndex(
                name: "IX_formuledetail_PacketTypeId",
                table: "formuledetail",
                column: "PacketTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_guest_CompanyId",
                table: "guest",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_guest_EnterpriseId",
                table: "guest",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_guest_ReferanceId",
                table: "guest",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_healthrecord_CompanyId",
                table: "healthrecord",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_healthrecord_EnterpriseId",
                table: "healthrecord",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_healthrecord_GuestId",
                table: "healthrecord",
                column: "GuestId");

            migrationBuilder.CreateIndex(
                name: "IX_healthrecord_HospitalId",
                table: "healthrecord",
                column: "HospitalId");

            migrationBuilder.CreateIndex(
                name: "IX_healthrecord_MedicalActionTypeId",
                table: "healthrecord",
                column: "MedicalActionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_healthrecord_MedicalStaffId",
                table: "healthrecord",
                column: "MedicalStaffId");

            migrationBuilder.CreateIndex(
                name: "IX_healthrecord_ReferanceId",
                table: "healthrecord",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_healthrecorddiagnosis_CompanyId",
                table: "healthrecorddiagnosis",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_healthrecorddiagnosis_DiagnosisId",
                table: "healthrecorddiagnosis",
                column: "DiagnosisId");

            migrationBuilder.CreateIndex(
                name: "IX_healthrecorddiagnosis_EnterpriseId",
                table: "healthrecorddiagnosis",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_healthrecorddiagnosis_HealthRecordId",
                table: "healthrecorddiagnosis",
                column: "HealthRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_healthrecorddiagnosis_ReferanceId",
                table: "healthrecorddiagnosis",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_healthrecordsymptom_CompanyId",
                table: "healthrecordsymptom",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_healthrecordsymptom_EnterpriseId",
                table: "healthrecordsymptom",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_healthrecordsymptom_HealthRecordId",
                table: "healthrecordsymptom",
                column: "HealthRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_healthrecordsymptom_ReferanceId",
                table: "healthrecordsymptom",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_healthrecordsymptom_SymptomId",
                table: "healthrecordsymptom",
                column: "SymptomId");

            migrationBuilder.CreateIndex(
                name: "IX_hkcode_CompanyId",
                table: "hkcode",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_hkcode_EnterpriseId",
                table: "hkcode",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_hkcode_ReferanceId",
                table: "hkcode",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_hospital_CompanyId",
                table: "hospital",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_hospital_EnterpriseId",
                table: "hospital",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_hospital_ReferanceId",
                table: "hospital",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_market_CompanyId",
                table: "market",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_market_EnterpriseId",
                table: "market",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_market_ReferanceId",
                table: "market",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_medicalactiontype_CompanyId",
                table: "medicalactiontype",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_medicalactiontype_EnterpriseId",
                table: "medicalactiontype",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_medicalactiontype_ReferanceId",
                table: "medicalactiontype",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_medicalstaff_CompanyId",
                table: "medicalstaff",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_medicalstaff_EnterpriseId",
                table: "medicalstaff",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_medicalstaff_MedicalStaffRoleId",
                table: "medicalstaff",
                column: "MedicalStaffRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_medicalstaff_ReferanceId",
                table: "medicalstaff",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_medicalstaffrole_CompanyId",
                table: "medicalstaffrole",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_medicalstaffrole_EnterpriseId",
                table: "medicalstaffrole",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_medicalstaffrole_ReferanceId",
                table: "medicalstaffrole",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_nationality_CompanyId",
                table: "nationality",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_nationality_CountryId",
                table: "nationality",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_nationality_EnterpriseId",
                table: "nationality",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_nationality_ReferanceId",
                table: "nationality",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_outof_CompanyId",
                table: "outof",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_outof_EnterpriseId",
                table: "outof",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_outof_ReferanceId",
                table: "outof",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_outoffloor_CompanyId",
                table: "outoffloor",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_outoffloor_EnterpriseId",
                table: "outoffloor",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_outoffloor_FloorId",
                table: "outoffloor",
                column: "FloorId");

            migrationBuilder.CreateIndex(
                name: "IX_outoffloor_OutOfId",
                table: "outoffloor",
                column: "OutOfId");

            migrationBuilder.CreateIndex(
                name: "IX_outoffloor_ReferanceId",
                table: "outoffloor",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_outoffroom_CompanyId",
                table: "outoffroom",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_outoffroom_EnterpriseId",
                table: "outoffroom",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_outoffroom_OutOfId",
                table: "outoffroom",
                column: "OutOfId");

            migrationBuilder.CreateIndex(
                name: "IX_outoffroom_ReferanceId",
                table: "outoffroom",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_outoffroom_RoomId",
                table: "outoffroom",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_outofroomlocation_CompanyId",
                table: "outofroomlocation",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_outofroomlocation_EnterpriseId",
                table: "outofroomlocation",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_outofroomlocation_OutOfId",
                table: "outofroomlocation",
                column: "OutOfId");

            migrationBuilder.CreateIndex(
                name: "IX_outofroomlocation_ReferanceId",
                table: "outofroomlocation",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_outofroomlocation_RoomLocationId",
                table: "outofroomlocation",
                column: "RoomLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_packets_AgencyId",
                table: "packets",
                column: "AgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_packets_CompanyId",
                table: "packets",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_packets_ConditionId",
                table: "packets",
                column: "ConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_packets_ContractId",
                table: "packets",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_packets_EnterpriseId",
                table: "packets",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_packets_PacketTypeId",
                table: "packets",
                column: "PacketTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_packets_ReferanceId",
                table: "packets",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_packettype_CompanyId",
                table: "packettype",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_packettype_EnterpriseId",
                table: "packettype",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_packettype_ReferanceId",
                table: "packettype",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_paymenttype_CompanyId",
                table: "paymenttype",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_paymenttype_EnterpriseId",
                table: "paymenttype",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_paymenttype_ReferanceId",
                table: "paymenttype",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_periodprices_CompanyId",
                table: "periodprices",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_periodprices_ContractPeriodId",
                table: "periodprices",
                column: "ContractPeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_periodprices_EnterpriseId",
                table: "periodprices",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_periodprices_PriceTypeId",
                table: "periodprices",
                column: "PriceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_periodprices_ReferanceId",
                table: "periodprices",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_periodprices_RoomLocationId",
                table: "periodprices",
                column: "RoomLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_phone_CompanyId",
                table: "phone",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_phone_EnterpriseId",
                table: "phone",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_phone_GuestId",
                table: "phone",
                column: "GuestId");

            migrationBuilder.CreateIndex(
                name: "IX_phone_MedicalStaffId",
                table: "phone",
                column: "MedicalStaffId");

            migrationBuilder.CreateIndex(
                name: "IX_phone_ReferanceId",
                table: "phone",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_pricelocation_CompanyId",
                table: "pricelocation",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_pricelocation_EnterpriseId",
                table: "pricelocation",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_pricelocation_ReferanceId",
                table: "pricelocation",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_pricetype_CompanyId",
                table: "pricetype",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_pricetype_EnterpriseId",
                table: "pricetype",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_pricetype_ReferanceId",
                table: "pricetype",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_proceduretype_CompanyId",
                table: "proceduretype",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_proceduretype_DailyProcedureId",
                table: "proceduretype",
                column: "DailyProcedureId");

            migrationBuilder.CreateIndex(
                name: "IX_proceduretype_EnterpriseId",
                table: "proceduretype",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_proceduretype_ReferanceId",
                table: "proceduretype",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_referance_CompanyId",
                table: "referance",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_reservastiondailyguest_GuestId",
                table: "reservastiondailyguest",
                column: "GuestId");

            migrationBuilder.CreateIndex(
                name: "IX_reservastiondailyguest_ReservationDailyId",
                table: "reservastiondailyguest",
                column: "ReservationDailyId");

            migrationBuilder.CreateIndex(
                name: "IX_reservationdaily_ReservationDetailId",
                table: "reservationdaily",
                column: "ReservationDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_reservationdaily_RoomId",
                table: "reservationdaily",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_reservationdailypricedetail_FormuleDetailId",
                table: "reservationdailypricedetail",
                column: "FormuleDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_reservationdailypricedetail_PacketsId",
                table: "reservationdailypricedetail",
                column: "PacketsId");

            migrationBuilder.CreateIndex(
                name: "IX_reservationdailypricedetail_PeriodPricesId",
                table: "reservationdailypricedetail",
                column: "PeriodPricesId");

            migrationBuilder.CreateIndex(
                name: "IX_reservationdailypricedetail_ReservationDailyId",
                table: "reservationdailypricedetail",
                column: "ReservationDailyId");

            migrationBuilder.CreateIndex(
                name: "IX_reservationdetail_AgencyId",
                table: "reservationdetail",
                column: "AgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_reservationdetail_BoardingHouseId",
                table: "reservationdetail",
                column: "BoardingHouseId");

            migrationBuilder.CreateIndex(
                name: "IX_reservationdetail_CurrencyId",
                table: "reservationdetail",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_reservationdetail_MarketId",
                table: "reservationdetail",
                column: "MarketId");

            migrationBuilder.CreateIndex(
                name: "IX_reservationdetail_PriceLocationId",
                table: "reservationdetail",
                column: "PriceLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_reservationdetail_ReservationRecordId",
                table: "reservationdetail",
                column: "ReservationRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_reservationdetail_RoomLocationId",
                table: "reservationdetail",
                column: "RoomLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_reservationproperties_CompanyId",
                table: "reservationproperties",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_reservationproperties_EnterpriseId",
                table: "reservationproperties",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_reservationproperties_ReferanceId",
                table: "reservationproperties",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_reservationrecord_CompanyId",
                table: "reservationrecord",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_reservationrecord_EnterpriseId",
                table: "reservationrecord",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_reservationrecord_ReferanceId",
                table: "reservationrecord",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_room_CompanyId",
                table: "room",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_room_EnterpriseId",
                table: "room",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_room_FloorId",
                table: "room",
                column: "FloorId");

            migrationBuilder.CreateIndex(
                name: "IX_room_HKCodeId",
                table: "room",
                column: "HKCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_room_ReferanceId",
                table: "room",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_room_RoomLocationId",
                table: "room",
                column: "RoomLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_roomlocation_CompanyId",
                table: "roomlocation",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_roomlocation_EnterpriseId",
                table: "roomlocation",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_roomlocation_ReferanceId",
                table: "roomlocation",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_roomproperties_CompanyId",
                table: "roomproperties",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_roomproperties_EnterpriseId",
                table: "roomproperties",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_roomproperties_ReferanceId",
                table: "roomproperties",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_routinecheckup_CompanyId",
                table: "routinecheckup",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_routinecheckup_EnterpriseId",
                table: "routinecheckup",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_routinecheckup_GuestId",
                table: "routinecheckup",
                column: "GuestId");

            migrationBuilder.CreateIndex(
                name: "IX_routinecheckup_HospitalId",
                table: "routinecheckup",
                column: "HospitalId");

            migrationBuilder.CreateIndex(
                name: "IX_routinecheckup_MedicalStaffId",
                table: "routinecheckup",
                column: "MedicalStaffId");

            migrationBuilder.CreateIndex(
                name: "IX_routinecheckup_ReferanceId",
                table: "routinecheckup",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_state_CompanyId",
                table: "state",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_state_CountryId",
                table: "state",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_state_EnterpriseId",
                table: "state",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_state_ReferanceId",
                table: "state",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_symptom_CompanyId",
                table: "symptom",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_symptom_EnterpriseId",
                table: "symptom",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_symptom_ReferanceId",
                table: "symptom",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_tax_CompanyId",
                table: "tax",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tax_EnterpriseId",
                table: "tax",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_tax_ReferanceId",
                table: "tax",
                column: "ReferanceId");

            migrationBuilder.CreateIndex(
                name: "IX_viptype_CompanyId",
                table: "viptype",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_viptype_EnterpriseId",
                table: "viptype",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_viptype_ReferanceId",
                table: "viptype",
                column: "ReferanceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "address");

            migrationBuilder.DropTable(
                name: "category");

            migrationBuilder.DropTable(
                name: "contractagency");

            migrationBuilder.DropTable(
                name: "email");

            migrationBuilder.DropTable(
                name: "foliodetail");

            migrationBuilder.DropTable(
                name: "healthrecorddiagnosis");

            migrationBuilder.DropTable(
                name: "healthrecordsymptom");

            migrationBuilder.DropTable(
                name: "nationality");

            migrationBuilder.DropTable(
                name: "outoffloor");

            migrationBuilder.DropTable(
                name: "outoffroom");

            migrationBuilder.DropTable(
                name: "outofroomlocation");

            migrationBuilder.DropTable(
                name: "paymenttype");

            migrationBuilder.DropTable(
                name: "phone");

            migrationBuilder.DropTable(
                name: "proceduretype");

            migrationBuilder.DropTable(
                name: "reservastiondailyguest");

            migrationBuilder.DropTable(
                name: "reservationdailypricedetail");

            migrationBuilder.DropTable(
                name: "reservationproperties");

            migrationBuilder.DropTable(
                name: "roomproperties");

            migrationBuilder.DropTable(
                name: "viptype");

            migrationBuilder.DropTable(
                name: "city");

            migrationBuilder.DropTable(
                name: "department");

            migrationBuilder.DropTable(
                name: "folio");

            migrationBuilder.DropTable(
                name: "diagnosis");

            migrationBuilder.DropTable(
                name: "healthrecord");

            migrationBuilder.DropTable(
                name: "symptom");

            migrationBuilder.DropTable(
                name: "outof");

            migrationBuilder.DropTable(
                name: "dailyprocedure");

            migrationBuilder.DropTable(
                name: "formuledetail");

            migrationBuilder.DropTable(
                name: "packets");

            migrationBuilder.DropTable(
                name: "periodprices");

            migrationBuilder.DropTable(
                name: "reservationdaily");

            migrationBuilder.DropTable(
                name: "state");

            migrationBuilder.DropTable(
                name: "tax");

            migrationBuilder.DropTable(
                name: "medicalactiontype");

            migrationBuilder.DropTable(
                name: "routinecheckup");

            migrationBuilder.DropTable(
                name: "formule");

            migrationBuilder.DropTable(
                name: "packettype");

            migrationBuilder.DropTable(
                name: "contractperiod");

            migrationBuilder.DropTable(
                name: "pricetype");

            migrationBuilder.DropTable(
                name: "reservationdetail");

            migrationBuilder.DropTable(
                name: "room");

            migrationBuilder.DropTable(
                name: "country");

            migrationBuilder.DropTable(
                name: "guest");

            migrationBuilder.DropTable(
                name: "hospital");

            migrationBuilder.DropTable(
                name: "medicalstaff");

            migrationBuilder.DropTable(
                name: "contract");

            migrationBuilder.DropTable(
                name: "agency");

            migrationBuilder.DropTable(
                name: "boardinghouse");

            migrationBuilder.DropTable(
                name: "currency");

            migrationBuilder.DropTable(
                name: "market");

            migrationBuilder.DropTable(
                name: "pricelocation");

            migrationBuilder.DropTable(
                name: "reservationrecord");

            migrationBuilder.DropTable(
                name: "floor");

            migrationBuilder.DropTable(
                name: "hkcode");

            migrationBuilder.DropTable(
                name: "roomlocation");

            migrationBuilder.DropTable(
                name: "medicalstaffrole");

            migrationBuilder.DropTable(
                name: "condition");

            migrationBuilder.DropTable(
                name: "bank");

            migrationBuilder.DropTable(
                name: "referance");

            migrationBuilder.DropTable(
                name: "company");

            migrationBuilder.DropTable(
                name: "enterprise");
        }
    }
}
