﻿// <auto-generated />
using System;
using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Data.Entities.Attributes", b =>
                {
                    b.Property<int>("AttributeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETUTCDATE()");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETUTCDATE()");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AttributeId");

                    b.ToTable("Attributes", (string)null);
                });

            modelBuilder.Entity("Domain.Data.Entities.Brand", b =>
                {
                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETUTCDATE()");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETUTCDATE()");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("BrandId");

                    b.ToTable("Brands", (string)null);
                });

            modelBuilder.Entity("Domain.Data.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETUTCDATE()");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETUTCDATE()");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CategoryId");

                    b.HasIndex("ParentId");

                    b.ToTable("Category", (string)null);
                });

            modelBuilder.Entity("Domain.Data.Entities.CategoryAttributes", b =>
                {
                    b.Property<int>("CategoryAttributeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryAttributeId"));

                    b.Property<int>("AttributeId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETUTCDATE()");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETUTCDATE()");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CategoryAttributeId");

                    b.HasIndex("AttributeId");

                    b.HasIndex("CategoryId");

                    b.ToTable("CategoryAttributes", (string)null);
                });

            modelBuilder.Entity("Domain.Data.Entities.Product", b =>
                {
                    b.Property<Guid>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("BrandId")
                        .HasColumnType("int");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETUTCDATE()");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("HasVariations")
                        .HasColumnType("bit");

                    b.Property<string>("Origin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("PrivewImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Stock")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETUTCDATE()");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProductId");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products", (string)null);
                });

            modelBuilder.Entity("Domain.Data.Entities.ProductAttribute", b =>
                {
                    b.Property<int>("ProductAttributeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductAttributeId"));

                    b.Property<int?>("AttributeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETUTCDATE()");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETUTCDATE()");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductAttributeId");

                    b.HasIndex("AttributeId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductAttributes", (string)null);
                });

            modelBuilder.Entity("Domain.Data.Entities.ProductImage", b =>
                {
                    b.Property<int>("ProductImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductImageId"));

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETUTCDATE()");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("ProductVariationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETUTCDATE()");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProductImageId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProductVariationId");

                    b.ToTable("ProductImages", (string)null);
                });

            modelBuilder.Entity("Domain.Data.Entities.ProductVariationDetails", b =>
                {
                    b.Property<string>("ProductVariationDetailsId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETUTCDATE()");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("ProductCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductVariationsId")
                        .HasColumnType("int");

                    b.Property<int?>("Stock")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETUTCDATE()");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProductVariationDetailsId");

                    b.HasIndex("ProductVariationsId");

                    b.ToTable("ProductVariationDetails", (string)null);
                });

            modelBuilder.Entity("Domain.Data.Entities.ProductVariations", b =>
                {
                    b.Property<int>("ProductVariationsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductVariationsId"));

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETUTCDATE()");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETUTCDATE()");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("VariationType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VariationValue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductVariationsId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductVariations", (string)null);
                });

            modelBuilder.Entity("Domain.Data.Entities.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RoleId");

                    b.HasIndex("RoleName")
                        .IsUnique()
                        .HasFilter("[RoleName] IS NOT NULL");

                    b.ToTable("Roles", (string)null);

                    b.HasData(
                        new
                        {
                            RoleId = 1,
                            CreatedAt = new DateTime(2025, 3, 22, 8, 3, 33, 987, DateTimeKind.Utc).AddTicks(2329),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            RoleName = "Admin",
                            UpdatedAt = new DateTime(2025, 3, 22, 8, 3, 33, 987, DateTimeKind.Utc).AddTicks(2332),
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            RoleId = 2,
                            CreatedAt = new DateTime(2025, 3, 22, 8, 3, 33, 987, DateTimeKind.Utc).AddTicks(2334),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            RoleName = "Staff",
                            UpdatedAt = new DateTime(2025, 3, 22, 8, 3, 33, 987, DateTimeKind.Utc).AddTicks(2334),
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            RoleId = 3,
                            CreatedAt = new DateTime(2025, 3, 22, 8, 3, 33, 987, DateTimeKind.Utc).AddTicks(2335),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            RoleName = "Customer",
                            UpdatedAt = new DateTime(2025, 3, 22, 8, 3, 33, 987, DateTimeKind.Utc).AddTicks(2335),
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000")
                        });
                });

            modelBuilder.Entity("Domain.Data.Entities.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Avatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETUTCDATE()");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HashPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RefreshTokenExpiryTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETUTCDATE()");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("VerificationCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("VerificationExpiry")
                        .HasColumnType("datetime2");

                    b.HasKey("UserId");

                    b.HasIndex("Email");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("Domain.Data.Entities.UserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles", (string)null);
                });

            modelBuilder.Entity("Domain.Data.Entities.Category", b =>
                {
                    b.HasOne("Domain.Data.Entities.Category", "ParentCategory")
                        .WithMany("ChildCategories")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("ParentCategory");
                });

            modelBuilder.Entity("Domain.Data.Entities.CategoryAttributes", b =>
                {
                    b.HasOne("Domain.Data.Entities.Attributes", "Attribute")
                        .WithMany("CategoryAttributes")
                        .HasForeignKey("AttributeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Data.Entities.Category", "Category")
                        .WithMany("CategoryAttributes")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Attribute");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Domain.Data.Entities.Product", b =>
                {
                    b.HasOne("Domain.Data.Entities.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Domain.Data.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Brand");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Domain.Data.Entities.ProductAttribute", b =>
                {
                    b.HasOne("Domain.Data.Entities.Attributes", "Attribute")
                        .WithMany("ProductAttributes")
                        .HasForeignKey("AttributeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Data.Entities.Product", "Product")
                        .WithMany("ProductAttributes")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Attribute");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Domain.Data.Entities.ProductImage", b =>
                {
                    b.HasOne("Domain.Data.Entities.Product", "Product")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("Domain.Data.Entities.ProductVariations", "ProductVariation")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductVariationId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Product");

                    b.Navigation("ProductVariation");
                });

            modelBuilder.Entity("Domain.Data.Entities.ProductVariationDetails", b =>
                {
                    b.HasOne("Domain.Data.Entities.ProductVariations", "ProductVariation")
                        .WithMany("ProductVariationDetails")
                        .HasForeignKey("ProductVariationsId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("ProductVariation");
                });

            modelBuilder.Entity("Domain.Data.Entities.ProductVariations", b =>
                {
                    b.HasOne("Domain.Data.Entities.Product", "Product")
                        .WithMany("ProductVariations")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Domain.Data.Entities.UserRole", b =>
                {
                    b.HasOne("Domain.Data.Entities.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Data.Entities.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Data.Entities.Attributes", b =>
                {
                    b.Navigation("CategoryAttributes");

                    b.Navigation("ProductAttributes");
                });

            modelBuilder.Entity("Domain.Data.Entities.Brand", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Domain.Data.Entities.Category", b =>
                {
                    b.Navigation("CategoryAttributes");

                    b.Navigation("ChildCategories");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("Domain.Data.Entities.Product", b =>
                {
                    b.Navigation("ProductAttributes");

                    b.Navigation("ProductImages");

                    b.Navigation("ProductVariations");
                });

            modelBuilder.Entity("Domain.Data.Entities.ProductVariations", b =>
                {
                    b.Navigation("ProductImages");

                    b.Navigation("ProductVariationDetails");
                });

            modelBuilder.Entity("Domain.Data.Entities.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("Domain.Data.Entities.User", b =>
                {
                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
