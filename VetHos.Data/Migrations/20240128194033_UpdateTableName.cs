using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetHos.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_VetTables",
                table: "VetTables");

            migrationBuilder.RenameTable(
                name: "VetTables",
                newName: "VetTable");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VetTable",
                table: "VetTable",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_VetTable",
                table: "VetTable");

            migrationBuilder.RenameTable(
                name: "VetTable",
                newName: "VetTables");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VetTables",
                table: "VetTables",
                column: "Id");
        }
    }
}
