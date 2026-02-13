using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResumeProjectDemo.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Portfolies",
                table: "Portfolies");

            migrationBuilder.RenameTable(
                name: "Portfolies",
                newName: "Portfolios");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Portfolios",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Portfolios",
                table: "Portfolios",
                column: "PortfolioId");

            migrationBuilder.CreateIndex(
                name: "IX_Portfolios_CategoryId",
                table: "Portfolios",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolios_Categories_CategoryId",
                table: "Portfolios",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Portfolios_Categories_CategoryId",
                table: "Portfolios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Portfolios",
                table: "Portfolios");

            migrationBuilder.DropIndex(
                name: "IX_Portfolios_CategoryId",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Portfolios");

            migrationBuilder.RenameTable(
                name: "Portfolios",
                newName: "Portfolies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Portfolies",
                table: "Portfolies",
                column: "PortfolioId");
        }
    }
}
