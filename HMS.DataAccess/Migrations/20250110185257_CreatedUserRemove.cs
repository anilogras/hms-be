using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HMS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class CreatedUserRemove : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "viptype");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "tax");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "symptom");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "state");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "routinecheckup");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "roomproperties");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "roomlocation");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "room");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "reservationrecord");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "reservationproperties");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "reservationdetail");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "reservationdailypricedetail");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "reservationdaily");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "reservastiondailyguest");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "proceduretype");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "pricetype");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "pricelocation");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "phone");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "periodprices");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "paymenttype");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "packettype");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "packets");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "outofroomlocation");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "outoffroom");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "outoffloor");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "outof");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "nationality");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "medicalstaffrole");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "medicalstaff");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "medicalactiontype");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "market");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "hospital");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "hkcode");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "healthrecordsymptom");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "healthrecorddiagnosis");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "healthrecord");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "guest");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "formuledetail");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "formule");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "foliodetail");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "folio");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "floor");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "enterprise");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "email");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "diagnosis");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "department");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "dailyprocedure");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "currency");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "country");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "contractperiod");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "contractagency");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "contract");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "condition");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "city");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "category");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "boardinghouse");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "bank");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "agency");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "address");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "viptype",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "tax",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "symptom",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "state",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "routinecheckup",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "roomproperties",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "roomlocation",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "room",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "reservationrecord",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "reservationproperties",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "reservationdetail",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "reservationdailypricedetail",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "reservationdaily",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "reservastiondailyguest",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "proceduretype",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "pricetype",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "pricelocation",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "phone",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "periodprices",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "paymenttype",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "packettype",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "packets",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "outofroomlocation",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "outoffroom",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "outoffloor",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "outof",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "nationality",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "medicalstaffrole",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "medicalstaff",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "medicalactiontype",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "market",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "hospital",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "hkcode",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "healthrecordsymptom",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "healthrecorddiagnosis",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "healthrecord",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "guest",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "formuledetail",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "formule",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "foliodetail",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "folio",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "floor",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "enterprise",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "email",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "diagnosis",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "department",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "dailyprocedure",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "currency",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "country",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "contractperiod",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "contractagency",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "contract",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "condition",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "city",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "category",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "boardinghouse",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "bank",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "agency",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUser",
                table: "address",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
