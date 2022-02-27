using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class defaultvalueforupdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Updated",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()",
                defaultValue: DateTime.Now,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "NOW()");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Updated",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "NOW()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
