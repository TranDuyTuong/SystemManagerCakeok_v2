using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.DomainData.Migrations
{
    public partial class DB_CakeOk_V3_VINXSERVER : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "T_Countrys",
                keyColumn: "IDCountry",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "T_Countrys",
                keyColumn: "IDCountry",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "T_Countrys",
                keyColumn: "IDCountry",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "T_Countrys",
                keyColumn: "IDCountry",
                keyValue: 4);

            migrationBuilder.AddColumn<string>(
                name: "Symbol",
                table: "T_Countrys",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "T_CustomerOrStaffs",
                keyColumn: "IDCustomerOrStaff",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 17, 0, 56, 30, 463, DateTimeKind.Utc).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "T_CustomerOrStaffs",
                keyColumn: "IDCustomerOrStaff",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 4, 17, 0, 56, 30, 463, DateTimeKind.Utc).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "T_Roles",
                keyColumn: "IDRole",
                keyValue: new Guid("d6e0ac8a-7eed-4865-a6f0-3f5a8ba60bdc"),
                column: "CreateDate",
                value: new DateTime(2023, 4, 17, 0, 56, 30, 463, DateTimeKind.Utc).AddTicks(8908));

            migrationBuilder.UpdateData(
                table: "T_StaffOrChefs",
                keyColumn: "IDStaffOrChef",
                keyValue: new Guid("b9c709e5-0ae2-4ca2-b5b1-1c6509fba56c"),
                column: "CreateDate",
                value: new DateTime(2023, 4, 17, 0, 56, 30, 463, DateTimeKind.Utc).AddTicks(8888));

            migrationBuilder.UpdateData(
                table: "T_StaffOrChefs",
                keyColumn: "IDStaffOrChef",
                keyValue: new Guid("fb0ad9bd-9be3-4557-ac8b-1001d48ec3b5"),
                column: "CreateDate",
                value: new DateTime(2023, 4, 17, 0, 56, 30, 463, DateTimeKind.Utc).AddTicks(8889));

            migrationBuilder.UpdateData(
                table: "T_Staffs",
                keyColumn: "IDStaff",
                keyValue: new Guid("d8b14017-6271-4f1c-8c50-c06b06fcd28b"),
                column: "CreateDate",
                value: new DateTime(2023, 4, 17, 0, 56, 30, 605, DateTimeKind.Utc).AddTicks(71));

            migrationBuilder.UpdateData(
                table: "T_UserRoles",
                keyColumn: "IDUserRole",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 17, 0, 56, 30, 605, DateTimeKind.Utc).AddTicks(128));

            migrationBuilder.UpdateData(
                table: "T_Users",
                keyColumn: "IDAccount",
                keyValue: new Guid("723d5b79-51fa-45d1-8ed3-14c53580110f"),
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PassWord", "PasswordHash" },
                values: new object[] { "bfafbad5-dc23-414e-8d96-46e3022e0892", new DateTime(2023, 4, 17, 0, 56, 30, 604, DateTimeKind.Utc).AddTicks(9471), "AQAAAAIAAYagAAAAEHIC6d8ojg4+ioQR5rfM1Wtc2tzoT4bOAVAbqfjEMdA6GBF6vx1pPV0vvwPnkHSrCQ==", "AQAAAAIAAYagAAAAELuGeQYAvbQ5+GthhqEjsKEPpRZWx94oJ8H6d+nvgZ28MGhK3Ipb4+HihmzDX2f81w==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Symbol",
                table: "T_Countrys");

            migrationBuilder.InsertData(
                table: "T_Countrys",
                columns: new[] { "IDCountry", "CreateDate", "Name", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 12, 1, 28, 50, 940, DateTimeKind.Utc).AddTicks(1541), "Việt Nam", true },
                    { 2, new DateTime(2023, 4, 12, 1, 28, 50, 940, DateTimeKind.Utc).AddTicks(1545), "Lào", true },
                    { 3, new DateTime(2023, 4, 12, 1, 28, 50, 940, DateTimeKind.Utc).AddTicks(1546), "Campuchia", true },
                    { 4, new DateTime(2023, 4, 12, 1, 28, 50, 940, DateTimeKind.Utc).AddTicks(1546), "Thái Lan", true }
                });

            migrationBuilder.UpdateData(
                table: "T_CustomerOrStaffs",
                keyColumn: "IDCustomerOrStaff",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 12, 1, 28, 50, 940, DateTimeKind.Utc).AddTicks(1593));

            migrationBuilder.UpdateData(
                table: "T_CustomerOrStaffs",
                keyColumn: "IDCustomerOrStaff",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 4, 12, 1, 28, 50, 940, DateTimeKind.Utc).AddTicks(1597));

            migrationBuilder.UpdateData(
                table: "T_Roles",
                keyColumn: "IDRole",
                keyValue: new Guid("d6e0ac8a-7eed-4865-a6f0-3f5a8ba60bdc"),
                column: "CreateDate",
                value: new DateTime(2023, 4, 12, 1, 28, 50, 940, DateTimeKind.Utc).AddTicks(1641));

            migrationBuilder.UpdateData(
                table: "T_StaffOrChefs",
                keyColumn: "IDStaffOrChef",
                keyValue: new Guid("b9c709e5-0ae2-4ca2-b5b1-1c6509fba56c"),
                column: "CreateDate",
                value: new DateTime(2023, 4, 12, 1, 28, 50, 940, DateTimeKind.Utc).AddTicks(1621));

            migrationBuilder.UpdateData(
                table: "T_StaffOrChefs",
                keyColumn: "IDStaffOrChef",
                keyValue: new Guid("fb0ad9bd-9be3-4557-ac8b-1001d48ec3b5"),
                column: "CreateDate",
                value: new DateTime(2023, 4, 12, 1, 28, 50, 940, DateTimeKind.Utc).AddTicks(1622));

            migrationBuilder.UpdateData(
                table: "T_Staffs",
                keyColumn: "IDStaff",
                keyValue: new Guid("d8b14017-6271-4f1c-8c50-c06b06fcd28b"),
                column: "CreateDate",
                value: new DateTime(2023, 4, 12, 1, 28, 51, 64, DateTimeKind.Utc).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "T_UserRoles",
                keyColumn: "IDUserRole",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 12, 1, 28, 51, 64, DateTimeKind.Utc).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "T_Users",
                keyColumn: "IDAccount",
                keyValue: new Guid("723d5b79-51fa-45d1-8ed3-14c53580110f"),
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PassWord", "PasswordHash" },
                values: new object[] { "1a09da9f-12a1-4563-b64a-626ef41034e6", new DateTime(2023, 4, 12, 1, 28, 51, 64, DateTimeKind.Utc).AddTicks(8069), "AQAAAAIAAYagAAAAEDHyh/iJKUjLQHehGxvYYOBn0oXsQHmadTXDjctoiZR3CUM9sAHlMfUuq0CMh1UKsg==", "AQAAAAIAAYagAAAAEJE8FoXLwY1SkCSrRS2wfiR8gkv3FCL0BanP5KsYHwGVTymQBKMb3stIwYHLJYiOhA==" });
        }
    }
}
