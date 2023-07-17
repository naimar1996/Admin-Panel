using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FrontToEnd1.Migrations
{
    /// <inheritdoc />
    public partial class CreateModified_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Creates",
                table: "Creates");

            migrationBuilder.RenameTable(
                name: "Creates",
                newName: "Create");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Create",
                table: "Create",
                column: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Create",
                table: "Create");

            migrationBuilder.RenameTable(
                name: "Create",
                newName: "Creates");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Creates",
                table: "Creates",
                column: "ID");
        }
    }
}
