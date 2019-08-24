using Microsoft.EntityFrameworkCore.Migrations;

namespace BookShelf.Data.Migrations
{
    public partial class addmigrationsecondnewproperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "Book",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ApplicationUserId",
                table: "Book",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
