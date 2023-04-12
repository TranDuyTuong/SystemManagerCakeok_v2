using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.DomainData.Migrations
{
    public partial class DB_CakeOk_V2_VINXSERVER : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "T_Countrys",
                keyColumn: "IDCountry",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 12, 1, 28, 50, 940, DateTimeKind.Utc).AddTicks(1541));

            migrationBuilder.UpdateData(
                table: "T_Countrys",
                keyColumn: "IDCountry",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 4, 12, 1, 28, 50, 940, DateTimeKind.Utc).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "T_Countrys",
                keyColumn: "IDCountry",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 4, 12, 1, 28, 50, 940, DateTimeKind.Utc).AddTicks(1546));

            migrationBuilder.UpdateData(
                table: "T_Countrys",
                keyColumn: "IDCountry",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 4, 12, 1, 28, 50, 940, DateTimeKind.Utc).AddTicks(1546));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "T_Countrys",
                keyColumn: "IDCountry",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 11, 13, 45, 43, 957, DateTimeKind.Utc).AddTicks(2769));

            migrationBuilder.UpdateData(
                table: "T_Countrys",
                keyColumn: "IDCountry",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 4, 11, 13, 45, 43, 957, DateTimeKind.Utc).AddTicks(2772));

            migrationBuilder.UpdateData(
                table: "T_Countrys",
                keyColumn: "IDCountry",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 4, 11, 13, 45, 43, 957, DateTimeKind.Utc).AddTicks(2774));

            migrationBuilder.UpdateData(
                table: "T_Countrys",
                keyColumn: "IDCountry",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 4, 11, 13, 45, 43, 957, DateTimeKind.Utc).AddTicks(2775));

            migrationBuilder.UpdateData(
                table: "T_CustomerOrStaffs",
                keyColumn: "IDCustomerOrStaff",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 11, 13, 45, 43, 957, DateTimeKind.Utc).AddTicks(2888));

            migrationBuilder.UpdateData(
                table: "T_CustomerOrStaffs",
                keyColumn: "IDCustomerOrStaff",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 4, 11, 13, 45, 43, 957, DateTimeKind.Utc).AddTicks(2890));

            migrationBuilder.UpdateData(
                table: "T_Roles",
                keyColumn: "IDRole",
                keyValue: new Guid("d6e0ac8a-7eed-4865-a6f0-3f5a8ba60bdc"),
                column: "CreateDate",
                value: new DateTime(2023, 4, 11, 13, 45, 43, 957, DateTimeKind.Utc).AddTicks(2978));

            migrationBuilder.UpdateData(
                table: "T_StaffOrChefs",
                keyColumn: "IDStaffOrChef",
                keyValue: new Guid("b9c709e5-0ae2-4ca2-b5b1-1c6509fba56c"),
                column: "CreateDate",
                value: new DateTime(2023, 4, 11, 13, 45, 43, 957, DateTimeKind.Utc).AddTicks(2944));

            migrationBuilder.UpdateData(
                table: "T_StaffOrChefs",
                keyColumn: "IDStaffOrChef",
                keyValue: new Guid("fb0ad9bd-9be3-4557-ac8b-1001d48ec3b5"),
                column: "CreateDate",
                value: new DateTime(2023, 4, 11, 13, 45, 43, 957, DateTimeKind.Utc).AddTicks(2945));

            migrationBuilder.UpdateData(
                table: "T_Staffs",
                keyColumn: "IDStaff",
                keyValue: new Guid("d8b14017-6271-4f1c-8c50-c06b06fcd28b"),
                column: "CreateDate",
                value: new DateTime(2023, 4, 11, 13, 45, 44, 199, DateTimeKind.Utc).AddTicks(9822));

            migrationBuilder.UpdateData(
                table: "T_UserRoles",
                keyColumn: "IDUserRole",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 11, 13, 45, 44, 199, DateTimeKind.Utc).AddTicks(9866));

            migrationBuilder.UpdateData(
                table: "T_Users",
                keyColumn: "IDAccount",
                keyValue: new Guid("723d5b79-51fa-45d1-8ed3-14c53580110f"),
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PassWord", "PasswordHash" },
                values: new object[] { "cbf4dc3f-f707-4ccf-9afe-8f70e63a09a1", new DateTime(2023, 4, 11, 13, 45, 44, 199, DateTimeKind.Utc).AddTicks(9315), "AQAAAAIAAYagAAAAENMP2QN/QtvqWXBaX3OcRx5wKJ0mJkUW5DqAp+kNJ6PLFk4CzsyTz/Od6cWrqPAxcg==", "AQAAAAIAAYagAAAAENaw3AkEMcgtCDmM4XMa8PKlVb+wQtc9Ipc8Xjqu+BW0uGsoSyeWhDNm1cWsDJTMoA==" });
        }
    }
}
