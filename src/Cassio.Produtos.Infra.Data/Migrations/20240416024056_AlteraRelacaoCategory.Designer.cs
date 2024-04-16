﻿// <auto-generated />
using System;
using Cassio.Produtos.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Cassio.Produtos.Infra.Data.Migrations
{
    [DbContext(typeof(ProductsContext))]
    [Migration("20240416024056_AlteraRelacaoCategory")]
    partial class AlteraRelacaoCategory
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Cassio.Produtos.Domain.Entities.Category", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text")
                        .HasColumnName("ID");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("DESCRIPTION");

                    b.HasKey("Id");

                    b.ToTable("CATEGORY", (string)null);
                });

            modelBuilder.Entity("Cassio.Produtos.Domain.Entities.Product", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text")
                        .HasColumnName("ID");

                    b.Property<string>("BarCode")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("BAR_CODE");

                    b.Property<string>("CategoryId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("DESCRIPTION");

                    b.Property<DateTime?>("ExpirationDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("EXPIRATION_DATE");

                    b.Property<string>("LocationId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("ManufactoringDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("MANUFACTORING_DATE");

                    b.Property<decimal>("SalePrice")
                        .HasColumnType("numeric")
                        .HasColumnName("SALE_PRICE");

                    b.Property<int>("StockQuantity")
                        .HasColumnType("integer")
                        .HasColumnName("QUANTITY");

                    b.Property<string>("SupplierId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId")
                        .IsUnique();

                    b.HasIndex("LocationId");

                    b.HasIndex("SupplierId");

                    b.ToTable("PRODUCTS", (string)null);
                });

            modelBuilder.Entity("Cassio.Produtos.Domain.Entities.Stock", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text")
                        .HasColumnName("ID");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("DESCRIPTION");

                    b.HasKey("Id");

                    b.ToTable("STOCKS", (string)null);
                });

            modelBuilder.Entity("Cassio.Produtos.Domain.Entities.Supplier", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text")
                        .HasColumnName("ID");

                    b.Property<string>("Identification")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("IDENTIFICATION");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("NAME");

                    b.HasKey("Id");

                    b.ToTable("SUPPLIERS", (string)null);
                });

            modelBuilder.Entity("Cassio.Produtos.Domain.Entities.Product", b =>
                {
                    b.HasOne("Cassio.Produtos.Domain.Entities.Category", "Category")
                        .WithOne()
                        .HasForeignKey("Cassio.Produtos.Domain.Entities.Product", "CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cassio.Produtos.Domain.Entities.Stock", "Location")
                        .WithMany("Products")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cassio.Produtos.Domain.Entities.Supplier", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("Cassio.Produtos.Domain.ValueObjects.Measure", "Mensure", b1 =>
                        {
                            b1.Property<string>("ProductId")
                                .HasColumnType("text");

                            b1.Property<decimal>("Quantity")
                                .HasColumnType("numeric")
                                .HasColumnName("MEASURE_QUANTITY");

                            b1.Property<int>("UnityMeasurement")
                                .HasColumnType("integer")
                                .HasColumnName("MEASURE_UNITY_MEASUREMENT");

                            b1.HasKey("ProductId");

                            b1.ToTable("PRODUCTS");

                            b1.WithOwner()
                                .HasForeignKey("ProductId");
                        });

                    b.Navigation("Category");

                    b.Navigation("Location");

                    b.Navigation("Mensure")
                        .IsRequired();

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("Cassio.Produtos.Domain.Entities.Stock", b =>
                {
                    b.OwnsOne("Cassio.Produtos.Domain.ValueObjects.Address", "Address", b1 =>
                        {
                            b1.Property<string>("StockId")
                                .HasColumnType("text");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("ADDRESS_CITY");

                            b1.Property<string>("Complement")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("ADDRESS_COMPLEMENT");

                            b1.Property<string>("Country")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("ADDRESS_COUNTRY");

                            b1.Property<string>("Neighborhood")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("ADDRESS_NEIGHBORHOOD");

                            b1.Property<int>("Number")
                                .HasColumnType("integer")
                                .HasColumnName("ADDRESS_NUMBER");

                            b1.Property<string>("State")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("ADDRESS_STATE");

                            b1.HasKey("StockId");

                            b1.ToTable("STOCKS");

                            b1.WithOwner()
                                .HasForeignKey("StockId");
                        });

                    b.Navigation("Address")
                        .IsRequired();
                });

            modelBuilder.Entity("Cassio.Produtos.Domain.Entities.Supplier", b =>
                {
                    b.OwnsOne("Cassio.Produtos.Domain.ValueObjects.Address", "Address", b1 =>
                        {
                            b1.Property<string>("SupplierId")
                                .HasColumnType("text");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("ADDRESS_CITY");

                            b1.Property<string>("Complement")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("ADDRESS_COMPLEMENT");

                            b1.Property<string>("Country")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("ADDRESS_COUNTRY");

                            b1.Property<string>("Neighborhood")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("ADDRESS_NEIGHBORHOOD");

                            b1.Property<int>("Number")
                                .HasColumnType("integer")
                                .HasColumnName("ADDRESS_NUMBER");

                            b1.Property<string>("State")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("ADDRESS_STATE");

                            b1.HasKey("SupplierId");

                            b1.ToTable("SUPPLIERS");

                            b1.WithOwner()
                                .HasForeignKey("SupplierId");
                        });

                    b.Navigation("Address")
                        .IsRequired();
                });

            modelBuilder.Entity("Cassio.Produtos.Domain.Entities.Stock", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Cassio.Produtos.Domain.Entities.Supplier", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
