using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cassio.Produtos.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AlteraRelacionamentoStockSupplier : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PRODUCTS_LocationId",
                table: "PRODUCTS");

            migrationBuilder.DropIndex(
                name: "IX_PRODUCTS_SupplierId",
                table: "PRODUCTS");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCTS_LocationId",
                table: "PRODUCTS",
                column: "LocationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCTS_SupplierId",
                table: "PRODUCTS",
                column: "SupplierId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PRODUCTS_LocationId",
                table: "PRODUCTS");

            migrationBuilder.DropIndex(
                name: "IX_PRODUCTS_SupplierId",
                table: "PRODUCTS");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCTS_LocationId",
                table: "PRODUCTS",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCTS_SupplierId",
                table: "PRODUCTS",
                column: "SupplierId");
        }
    }
}
