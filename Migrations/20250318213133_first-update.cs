using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnet_Api.Migrations
{
    public partial class firstupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Command",
                table: "Command");

            migrationBuilder.RenameTable(
                name: "Command",
                newName: "Commands");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Commands",
                table: "Commands",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Commands",
                table: "Commands");

            migrationBuilder.RenameTable(
                name: "Commands",
                newName: "Command");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Command",
                table: "Command",
                column: "Id");
        }
    }
}
