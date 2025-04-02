using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HMS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ReferanceNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_address_referance_ReferanceId",
                table: "address");

            migrationBuilder.DropForeignKey(
                name: "FK_agency_referance_ReferanceId",
                table: "agency");

            migrationBuilder.DropForeignKey(
                name: "FK_bank_referance_ReferanceId",
                table: "bank");

            migrationBuilder.DropForeignKey(
                name: "FK_boardinghouse_referance_ReferanceId",
                table: "boardinghouse");

            migrationBuilder.DropForeignKey(
                name: "FK_category_referance_ReferanceId",
                table: "category");

            migrationBuilder.DropForeignKey(
                name: "FK_city_referance_ReferanceId",
                table: "city");

            migrationBuilder.DropForeignKey(
                name: "FK_condition_referance_ReferanceId",
                table: "condition");

            migrationBuilder.DropForeignKey(
                name: "FK_contract_referance_ReferanceId",
                table: "contract");

            migrationBuilder.DropForeignKey(
                name: "FK_contractagency_referance_ReferanceId",
                table: "contractagency");

            migrationBuilder.DropForeignKey(
                name: "FK_contractperiod_referance_ReferanceId",
                table: "contractperiod");

            migrationBuilder.DropForeignKey(
                name: "FK_country_referance_ReferanceId",
                table: "country");

            migrationBuilder.DropForeignKey(
                name: "FK_currency_referance_ReferanceId",
                table: "currency");

            migrationBuilder.DropForeignKey(
                name: "FK_dailyprocedure_referance_ReferanceId",
                table: "dailyprocedure");

            migrationBuilder.DropForeignKey(
                name: "FK_department_referance_ReferanceId",
                table: "department");

            migrationBuilder.DropForeignKey(
                name: "FK_diagnosis_referance_ReferanceId",
                table: "diagnosis");

            migrationBuilder.DropForeignKey(
                name: "FK_email_referance_ReferanceId",
                table: "email");

            migrationBuilder.DropForeignKey(
                name: "FK_floor_referance_ReferanceId",
                table: "floor");

            migrationBuilder.DropForeignKey(
                name: "FK_folio_referance_ReferanceId",
                table: "folio");

            migrationBuilder.DropForeignKey(
                name: "FK_formule_referance_ReferanceId",
                table: "formule");

            migrationBuilder.DropForeignKey(
                name: "FK_guest_referance_ReferanceId",
                table: "guest");

            migrationBuilder.DropForeignKey(
                name: "FK_healthrecord_referance_ReferanceId",
                table: "healthrecord");

            migrationBuilder.DropForeignKey(
                name: "FK_healthrecorddiagnosis_referance_ReferanceId",
                table: "healthrecorddiagnosis");

            migrationBuilder.DropForeignKey(
                name: "FK_healthrecordsymptom_referance_ReferanceId",
                table: "healthrecordsymptom");

            migrationBuilder.DropForeignKey(
                name: "FK_hkcode_referance_ReferanceId",
                table: "hkcode");

            migrationBuilder.DropForeignKey(
                name: "FK_hospital_referance_ReferanceId",
                table: "hospital");

            migrationBuilder.DropForeignKey(
                name: "FK_market_referance_ReferanceId",
                table: "market");

            migrationBuilder.DropForeignKey(
                name: "FK_medicalactiontype_referance_ReferanceId",
                table: "medicalactiontype");

            migrationBuilder.DropForeignKey(
                name: "FK_medicalstaff_referance_ReferanceId",
                table: "medicalstaff");

            migrationBuilder.DropForeignKey(
                name: "FK_medicalstaffrole_referance_ReferanceId",
                table: "medicalstaffrole");

            migrationBuilder.DropForeignKey(
                name: "FK_nationality_referance_ReferanceId",
                table: "nationality");

            migrationBuilder.DropForeignKey(
                name: "FK_outof_referance_ReferanceId",
                table: "outof");

            migrationBuilder.DropForeignKey(
                name: "FK_outoffloor_referance_ReferanceId",
                table: "outoffloor");

            migrationBuilder.DropForeignKey(
                name: "FK_outoffroom_referance_ReferanceId",
                table: "outoffroom");

            migrationBuilder.DropForeignKey(
                name: "FK_outofroomlocation_referance_ReferanceId",
                table: "outofroomlocation");

            migrationBuilder.DropForeignKey(
                name: "FK_packets_referance_ReferanceId",
                table: "packets");

            migrationBuilder.DropForeignKey(
                name: "FK_packettype_referance_ReferanceId",
                table: "packettype");

            migrationBuilder.DropForeignKey(
                name: "FK_paymenttype_referance_ReferanceId",
                table: "paymenttype");

            migrationBuilder.DropForeignKey(
                name: "FK_periodprices_referance_ReferanceId",
                table: "periodprices");

            migrationBuilder.DropForeignKey(
                name: "FK_phone_referance_ReferanceId",
                table: "phone");

            migrationBuilder.DropForeignKey(
                name: "FK_pricelocation_referance_ReferanceId",
                table: "pricelocation");

            migrationBuilder.DropForeignKey(
                name: "FK_pricetype_referance_ReferanceId",
                table: "pricetype");

            migrationBuilder.DropForeignKey(
                name: "FK_proceduretype_referance_ReferanceId",
                table: "proceduretype");

            migrationBuilder.DropForeignKey(
                name: "FK_reservationproperties_referance_ReferanceId",
                table: "reservationproperties");

            migrationBuilder.DropForeignKey(
                name: "FK_reservationrecord_referance_ReferanceId",
                table: "reservationrecord");

            migrationBuilder.DropForeignKey(
                name: "FK_room_referance_ReferanceId",
                table: "room");

            migrationBuilder.DropForeignKey(
                name: "FK_roomlocation_referance_ReferanceId",
                table: "roomlocation");

            migrationBuilder.DropForeignKey(
                name: "FK_roomproperties_referance_ReferanceId",
                table: "roomproperties");

            migrationBuilder.DropForeignKey(
                name: "FK_routinecheckup_referance_ReferanceId",
                table: "routinecheckup");

            migrationBuilder.DropForeignKey(
                name: "FK_state_referance_ReferanceId",
                table: "state");

            migrationBuilder.DropForeignKey(
                name: "FK_symptom_referance_ReferanceId",
                table: "symptom");

            migrationBuilder.DropForeignKey(
                name: "FK_tax_referance_ReferanceId",
                table: "tax");

            migrationBuilder.DropForeignKey(
                name: "FK_viptype_referance_ReferanceId",
                table: "viptype");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "viptype",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "tax",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "symptom",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "state",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "routinecheckup",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "roomproperties",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "roomlocation",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "room",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "reservationrecord",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "reservationproperties",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "proceduretype",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "pricetype",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "pricelocation",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "phone",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "periodprices",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "paymenttype",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "packettype",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "packets",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "outofroomlocation",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "outoffroom",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "outoffloor",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "outof",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "nationality",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "medicalstaffrole",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "medicalstaff",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "medicalactiontype",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "market",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "hospital",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "hkcode",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "healthrecordsymptom",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "healthrecorddiagnosis",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "healthrecord",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "guest",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "formule",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "folio",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "floor",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "email",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "diagnosis",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "department",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "dailyprocedure",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "currency",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "country",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "contractperiod",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "contractagency",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "contract",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "condition",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "city",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "category",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "boardinghouse",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "bank",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "agency",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "address",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddForeignKey(
                name: "FK_address_referance_ReferanceId",
                table: "address",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_agency_referance_ReferanceId",
                table: "agency",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_bank_referance_ReferanceId",
                table: "bank",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_boardinghouse_referance_ReferanceId",
                table: "boardinghouse",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_category_referance_ReferanceId",
                table: "category",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_city_referance_ReferanceId",
                table: "city",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_condition_referance_ReferanceId",
                table: "condition",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_contract_referance_ReferanceId",
                table: "contract",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_contractagency_referance_ReferanceId",
                table: "contractagency",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_contractperiod_referance_ReferanceId",
                table: "contractperiod",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_country_referance_ReferanceId",
                table: "country",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_currency_referance_ReferanceId",
                table: "currency",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_dailyprocedure_referance_ReferanceId",
                table: "dailyprocedure",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_department_referance_ReferanceId",
                table: "department",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_diagnosis_referance_ReferanceId",
                table: "diagnosis",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_email_referance_ReferanceId",
                table: "email",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_floor_referance_ReferanceId",
                table: "floor",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_folio_referance_ReferanceId",
                table: "folio",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_formule_referance_ReferanceId",
                table: "formule",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_guest_referance_ReferanceId",
                table: "guest",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_healthrecord_referance_ReferanceId",
                table: "healthrecord",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_healthrecorddiagnosis_referance_ReferanceId",
                table: "healthrecorddiagnosis",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_healthrecordsymptom_referance_ReferanceId",
                table: "healthrecordsymptom",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_hkcode_referance_ReferanceId",
                table: "hkcode",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_hospital_referance_ReferanceId",
                table: "hospital",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_market_referance_ReferanceId",
                table: "market",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_medicalactiontype_referance_ReferanceId",
                table: "medicalactiontype",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_medicalstaff_referance_ReferanceId",
                table: "medicalstaff",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_medicalstaffrole_referance_ReferanceId",
                table: "medicalstaffrole",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_nationality_referance_ReferanceId",
                table: "nationality",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_outof_referance_ReferanceId",
                table: "outof",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_outoffloor_referance_ReferanceId",
                table: "outoffloor",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_outoffroom_referance_ReferanceId",
                table: "outoffroom",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_outofroomlocation_referance_ReferanceId",
                table: "outofroomlocation",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_packets_referance_ReferanceId",
                table: "packets",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_packettype_referance_ReferanceId",
                table: "packettype",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_paymenttype_referance_ReferanceId",
                table: "paymenttype",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_periodprices_referance_ReferanceId",
                table: "periodprices",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_phone_referance_ReferanceId",
                table: "phone",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_pricelocation_referance_ReferanceId",
                table: "pricelocation",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_pricetype_referance_ReferanceId",
                table: "pricetype",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_proceduretype_referance_ReferanceId",
                table: "proceduretype",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_reservationproperties_referance_ReferanceId",
                table: "reservationproperties",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_reservationrecord_referance_ReferanceId",
                table: "reservationrecord",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_room_referance_ReferanceId",
                table: "room",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_roomlocation_referance_ReferanceId",
                table: "roomlocation",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_roomproperties_referance_ReferanceId",
                table: "roomproperties",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_routinecheckup_referance_ReferanceId",
                table: "routinecheckup",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_state_referance_ReferanceId",
                table: "state",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_symptom_referance_ReferanceId",
                table: "symptom",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tax_referance_ReferanceId",
                table: "tax",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_viptype_referance_ReferanceId",
                table: "viptype",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_address_referance_ReferanceId",
                table: "address");

            migrationBuilder.DropForeignKey(
                name: "FK_agency_referance_ReferanceId",
                table: "agency");

            migrationBuilder.DropForeignKey(
                name: "FK_bank_referance_ReferanceId",
                table: "bank");

            migrationBuilder.DropForeignKey(
                name: "FK_boardinghouse_referance_ReferanceId",
                table: "boardinghouse");

            migrationBuilder.DropForeignKey(
                name: "FK_category_referance_ReferanceId",
                table: "category");

            migrationBuilder.DropForeignKey(
                name: "FK_city_referance_ReferanceId",
                table: "city");

            migrationBuilder.DropForeignKey(
                name: "FK_condition_referance_ReferanceId",
                table: "condition");

            migrationBuilder.DropForeignKey(
                name: "FK_contract_referance_ReferanceId",
                table: "contract");

            migrationBuilder.DropForeignKey(
                name: "FK_contractagency_referance_ReferanceId",
                table: "contractagency");

            migrationBuilder.DropForeignKey(
                name: "FK_contractperiod_referance_ReferanceId",
                table: "contractperiod");

            migrationBuilder.DropForeignKey(
                name: "FK_country_referance_ReferanceId",
                table: "country");

            migrationBuilder.DropForeignKey(
                name: "FK_currency_referance_ReferanceId",
                table: "currency");

            migrationBuilder.DropForeignKey(
                name: "FK_dailyprocedure_referance_ReferanceId",
                table: "dailyprocedure");

            migrationBuilder.DropForeignKey(
                name: "FK_department_referance_ReferanceId",
                table: "department");

            migrationBuilder.DropForeignKey(
                name: "FK_diagnosis_referance_ReferanceId",
                table: "diagnosis");

            migrationBuilder.DropForeignKey(
                name: "FK_email_referance_ReferanceId",
                table: "email");

            migrationBuilder.DropForeignKey(
                name: "FK_floor_referance_ReferanceId",
                table: "floor");

            migrationBuilder.DropForeignKey(
                name: "FK_folio_referance_ReferanceId",
                table: "folio");

            migrationBuilder.DropForeignKey(
                name: "FK_formule_referance_ReferanceId",
                table: "formule");

            migrationBuilder.DropForeignKey(
                name: "FK_guest_referance_ReferanceId",
                table: "guest");

            migrationBuilder.DropForeignKey(
                name: "FK_healthrecord_referance_ReferanceId",
                table: "healthrecord");

            migrationBuilder.DropForeignKey(
                name: "FK_healthrecorddiagnosis_referance_ReferanceId",
                table: "healthrecorddiagnosis");

            migrationBuilder.DropForeignKey(
                name: "FK_healthrecordsymptom_referance_ReferanceId",
                table: "healthrecordsymptom");

            migrationBuilder.DropForeignKey(
                name: "FK_hkcode_referance_ReferanceId",
                table: "hkcode");

            migrationBuilder.DropForeignKey(
                name: "FK_hospital_referance_ReferanceId",
                table: "hospital");

            migrationBuilder.DropForeignKey(
                name: "FK_market_referance_ReferanceId",
                table: "market");

            migrationBuilder.DropForeignKey(
                name: "FK_medicalactiontype_referance_ReferanceId",
                table: "medicalactiontype");

            migrationBuilder.DropForeignKey(
                name: "FK_medicalstaff_referance_ReferanceId",
                table: "medicalstaff");

            migrationBuilder.DropForeignKey(
                name: "FK_medicalstaffrole_referance_ReferanceId",
                table: "medicalstaffrole");

            migrationBuilder.DropForeignKey(
                name: "FK_nationality_referance_ReferanceId",
                table: "nationality");

            migrationBuilder.DropForeignKey(
                name: "FK_outof_referance_ReferanceId",
                table: "outof");

            migrationBuilder.DropForeignKey(
                name: "FK_outoffloor_referance_ReferanceId",
                table: "outoffloor");

            migrationBuilder.DropForeignKey(
                name: "FK_outoffroom_referance_ReferanceId",
                table: "outoffroom");

            migrationBuilder.DropForeignKey(
                name: "FK_outofroomlocation_referance_ReferanceId",
                table: "outofroomlocation");

            migrationBuilder.DropForeignKey(
                name: "FK_packets_referance_ReferanceId",
                table: "packets");

            migrationBuilder.DropForeignKey(
                name: "FK_packettype_referance_ReferanceId",
                table: "packettype");

            migrationBuilder.DropForeignKey(
                name: "FK_paymenttype_referance_ReferanceId",
                table: "paymenttype");

            migrationBuilder.DropForeignKey(
                name: "FK_periodprices_referance_ReferanceId",
                table: "periodprices");

            migrationBuilder.DropForeignKey(
                name: "FK_phone_referance_ReferanceId",
                table: "phone");

            migrationBuilder.DropForeignKey(
                name: "FK_pricelocation_referance_ReferanceId",
                table: "pricelocation");

            migrationBuilder.DropForeignKey(
                name: "FK_pricetype_referance_ReferanceId",
                table: "pricetype");

            migrationBuilder.DropForeignKey(
                name: "FK_proceduretype_referance_ReferanceId",
                table: "proceduretype");

            migrationBuilder.DropForeignKey(
                name: "FK_reservationproperties_referance_ReferanceId",
                table: "reservationproperties");

            migrationBuilder.DropForeignKey(
                name: "FK_reservationrecord_referance_ReferanceId",
                table: "reservationrecord");

            migrationBuilder.DropForeignKey(
                name: "FK_room_referance_ReferanceId",
                table: "room");

            migrationBuilder.DropForeignKey(
                name: "FK_roomlocation_referance_ReferanceId",
                table: "roomlocation");

            migrationBuilder.DropForeignKey(
                name: "FK_roomproperties_referance_ReferanceId",
                table: "roomproperties");

            migrationBuilder.DropForeignKey(
                name: "FK_routinecheckup_referance_ReferanceId",
                table: "routinecheckup");

            migrationBuilder.DropForeignKey(
                name: "FK_state_referance_ReferanceId",
                table: "state");

            migrationBuilder.DropForeignKey(
                name: "FK_symptom_referance_ReferanceId",
                table: "symptom");

            migrationBuilder.DropForeignKey(
                name: "FK_tax_referance_ReferanceId",
                table: "tax");

            migrationBuilder.DropForeignKey(
                name: "FK_viptype_referance_ReferanceId",
                table: "viptype");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "viptype",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "tax",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "symptom",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "state",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "routinecheckup",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "roomproperties",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "roomlocation",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "room",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "reservationrecord",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "reservationproperties",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "proceduretype",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "pricetype",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "pricelocation",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "phone",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "periodprices",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "paymenttype",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "packettype",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "packets",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "outofroomlocation",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "outoffroom",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "outoffloor",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "outof",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "nationality",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "medicalstaffrole",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "medicalstaff",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "medicalactiontype",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "market",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "hospital",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "hkcode",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "healthrecordsymptom",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "healthrecorddiagnosis",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "healthrecord",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "guest",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "formule",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "folio",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "floor",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "email",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "diagnosis",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "department",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "dailyprocedure",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "currency",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "country",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "contractperiod",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "contractagency",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "contract",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "condition",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "city",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "category",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "boardinghouse",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "bank",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "agency",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReferanceId",
                table: "address",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_address_referance_ReferanceId",
                table: "address",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_agency_referance_ReferanceId",
                table: "agency",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_bank_referance_ReferanceId",
                table: "bank",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_boardinghouse_referance_ReferanceId",
                table: "boardinghouse",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_category_referance_ReferanceId",
                table: "category",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_city_referance_ReferanceId",
                table: "city",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_condition_referance_ReferanceId",
                table: "condition",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_contract_referance_ReferanceId",
                table: "contract",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_contractagency_referance_ReferanceId",
                table: "contractagency",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_contractperiod_referance_ReferanceId",
                table: "contractperiod",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_country_referance_ReferanceId",
                table: "country",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_currency_referance_ReferanceId",
                table: "currency",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dailyprocedure_referance_ReferanceId",
                table: "dailyprocedure",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_department_referance_ReferanceId",
                table: "department",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_diagnosis_referance_ReferanceId",
                table: "diagnosis",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_email_referance_ReferanceId",
                table: "email",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_floor_referance_ReferanceId",
                table: "floor",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_folio_referance_ReferanceId",
                table: "folio",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_formule_referance_ReferanceId",
                table: "formule",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_guest_referance_ReferanceId",
                table: "guest",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_healthrecord_referance_ReferanceId",
                table: "healthrecord",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_healthrecorddiagnosis_referance_ReferanceId",
                table: "healthrecorddiagnosis",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_healthrecordsymptom_referance_ReferanceId",
                table: "healthrecordsymptom",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_hkcode_referance_ReferanceId",
                table: "hkcode",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_hospital_referance_ReferanceId",
                table: "hospital",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_market_referance_ReferanceId",
                table: "market",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_medicalactiontype_referance_ReferanceId",
                table: "medicalactiontype",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_medicalstaff_referance_ReferanceId",
                table: "medicalstaff",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_medicalstaffrole_referance_ReferanceId",
                table: "medicalstaffrole",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_nationality_referance_ReferanceId",
                table: "nationality",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_outof_referance_ReferanceId",
                table: "outof",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_outoffloor_referance_ReferanceId",
                table: "outoffloor",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_outoffroom_referance_ReferanceId",
                table: "outoffroom",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_outofroomlocation_referance_ReferanceId",
                table: "outofroomlocation",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_packets_referance_ReferanceId",
                table: "packets",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_packettype_referance_ReferanceId",
                table: "packettype",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_paymenttype_referance_ReferanceId",
                table: "paymenttype",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_periodprices_referance_ReferanceId",
                table: "periodprices",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_phone_referance_ReferanceId",
                table: "phone",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_pricelocation_referance_ReferanceId",
                table: "pricelocation",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_pricetype_referance_ReferanceId",
                table: "pricetype",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_proceduretype_referance_ReferanceId",
                table: "proceduretype",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_reservationproperties_referance_ReferanceId",
                table: "reservationproperties",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_reservationrecord_referance_ReferanceId",
                table: "reservationrecord",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_room_referance_ReferanceId",
                table: "room",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_roomlocation_referance_ReferanceId",
                table: "roomlocation",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_roomproperties_referance_ReferanceId",
                table: "roomproperties",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_routinecheckup_referance_ReferanceId",
                table: "routinecheckup",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_state_referance_ReferanceId",
                table: "state",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_symptom_referance_ReferanceId",
                table: "symptom",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tax_referance_ReferanceId",
                table: "tax",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_viptype_referance_ReferanceId",
                table: "viptype",
                column: "ReferanceId",
                principalTable: "referance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
