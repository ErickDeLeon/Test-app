using Microsoft.EntityFrameworkCore.Migrations;

namespace ToyStore.Migrations
{
    public partial class UpdateRestriccionEdad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RestriccionEdad",
                table: "Toys",
                type: "Int",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RestriccionEdad",
                table: "Toys",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "Int",
                oldMaxLength: 100);
        }
    }
}
