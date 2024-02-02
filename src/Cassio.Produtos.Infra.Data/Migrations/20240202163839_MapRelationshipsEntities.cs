using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cassio.Produtos.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class MapRelationshipsEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PRODUCTS_STOCKS_LocationId",
                table: "PRODUCTS");

            migrationBuilder.DropForeignKey(
                name: "FK_PRODUCTS_SUPPLIERS_SupplierId",
                table: "PRODUCTS");

            migrationBuilder.AlterColumn<string>(
                name: "SupplierId",
                table: "PRODUCTS",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LocationId",
                table: "PRODUCTS",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PRODUCTS_STOCKS_LocationId",
                table: "PRODUCTS",
                column: "LocationId",
                principalTable: "STOCKS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PRODUCTS_SUPPLIERS_SupplierId",
                table: "PRODUCTS",
                column: "SupplierId",
                principalTable: "SUPPLIERS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PRODUCTS_STOCKS_LocationId",
                table: "PRODUCTS");

            migrationBuilder.DropForeignKey(
                name: "FK_PRODUCTS_SUPPLIERS_SupplierId",
                table: "PRODUCTS");

            migrationBuilder.AlterColumn<string>(
                name: "SupplierId",
                table: "PRODUCTS",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "LocationId",
                table: "PRODUCTS",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddForeignKey(
                name: "FK_PRODUCTS_STOCKS_LocationId",
                table: "PRODUCTS",
                column: "LocationId",
                principalTable: "STOCKS",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_PRODUCTS_SUPPLIERS_SupplierId",
                table: "PRODUCTS",
                column: "SupplierId",
                principalTable: "SUPPLIERS",
                principalColumn: "ID");
        }
    }
}
