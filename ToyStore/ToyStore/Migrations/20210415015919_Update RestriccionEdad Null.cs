using Microsoft.EntityFrameworkCore.Migrations;

namespace ToyStore.Migrations
{
    public partial class UpdateRestriccionEdadNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RestriccionEdad",
                table: "Toys",
                type: "Int",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "Int",
                oldMaxLength: 100);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RestriccionEdad",
                table: "Toys",
                type: "Int",
                maxLength: 100,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "Int",
                oldMaxLength: 100,
                oldNullable: true);
        }
    }
}
