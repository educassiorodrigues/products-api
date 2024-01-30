using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cassio.Produtos.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDomainModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PRODUCTS",
                newName: "ID");

            migrationBuilder.AddColumn<string>(
                name: "CategoryId",
                table: "PRODUCTS",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "EXPIRATION_DATE",
                table: "PRODUCTS",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LocationId",
                table: "PRODUCTS",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "MANUFACTORING_DATE",
                table: "PRODUCTS",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "MEASURE_QUANTITY",
                table: "PRODUCTS",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "MEASURE_UNITY_MEASUREMENT",
                table: "PRODUCTS",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "SALE_PRICE",
                table: "PRODUCTS",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "SupplierId",
                table: "PRODUCTS",
                type: "text",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CATEGORY",
                columns: table => new
                {
                    ID = table.Column<string>(type: "text", nullable: false),
                    DESCRIPTION = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CATEGORY", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "STOCKS",
                columns: table => new
                {
                    ID = table.Column<string>(type: "text", nullable: false),
                    DESCRIPTION = table.Column<string>(type: "text", nullable: false),
                    ADDRESS_CITY = table.Column<string>(type: "text", nullable: false),
                    ADDRESS_STATE = table.Column<string>(type: "text", nullable: false),
                    ADDRESS_NEIGHBORHOOD = table.Column<string>(type: "text", nullable: false),
                    ADDRESS_NUMBER = table.Column<int>(type: "integer", nullable: false),
                    ADDRESS_COUNTRY = table.Column<string>(type: "text", nullable: false),
                    ADDRESS_COMPLEMENT = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STOCKS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SUPPLIERS",
                columns: table => new
                {
                    ID = table.Column<string>(type: "text", nullable: false),
                    NAME = table.Column<string>(type: "text", nullable: false),
                    ADDRESS_CITY = table.Column<string>(type: "text", nullable: false),
                    ADDRESS_STATE = table.Column<string>(type: "text", nullable: false),
                    ADDRESS_NEIGHBORHOOD = table.Column<string>(type: "text", nullable: false),
                    ADDRESS_NUMBER = table.Column<int>(type: "integer", nullable: false),
                    ADDRESS_COUNTRY = table.Column<string>(type: "text", nullable: false),
                    ADDRESS_COMPLEMENT = table.Column<string>(type: "text", nullable: false),
                    IDENTIFICATION = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SUPPLIERS", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCTS_CategoryId",
                table: "PRODUCTS",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCTS_LocationId",
                table: "PRODUCTS",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCTS_SupplierId",
                table: "PRODUCTS",
                column: "SupplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_PRODUCTS_CATEGORY_CategoryId",
                table: "PRODUCTS",
                column: "CategoryId",
                principalTable: "CATEGORY",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PRODUCTS_CATEGORY_CategoryId",
                table: "PRODUCTS");

            migrationBuilder.DropForeignKey(
                name: "FK_PRODUCTS_STOCKS_LocationId",
                table: "PRODUCTS");

            migrationBuilder.DropForeignKey(
                name: "FK_PRODUCTS_SUPPLIERS_SupplierId",
                table: "PRODUCTS");

            migrationBuilder.DropTable(
                name: "CATEGORY");

            migrationBuilder.DropTable(
                name: "STOCKS");

            migrationBuilder.DropTable(
                name: "SUPPLIERS");

            migrationBuilder.DropIndex(
                name: "IX_PRODUCTS_CategoryId",
                table: "PRODUCTS");

            migrationBuilder.DropIndex(
                name: "IX_PRODUCTS_LocationId",
                table: "PRODUCTS");

            migrationBuilder.DropIndex(
                name: "IX_PRODUCTS_SupplierId",
                table: "PRODUCTS");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "PRODUCTS");

            migrationBuilder.DropColumn(
                name: "EXPIRATION_DATE",
                table: "PRODUCTS");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "PRODUCTS");

            migrationBuilder.DropColumn(
                name: "MANUFACTORING_DATE",
                table: "PRODUCTS");

            migrationBuilder.DropColumn(
                name: "MEASURE_QUANTITY",
                table: "PRODUCTS");

            migrationBuilder.DropColumn(
                name: "MEASURE_UNITY_MEASUREMENT",
                table: "PRODUCTS");

            migrationBuilder.DropColumn(
                name: "SALE_PRICE",
                table: "PRODUCTS");

            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "PRODUCTS");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "PRODUCTS",
                newName: "Id");
        }
    }
}
