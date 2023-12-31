﻿// <auto-generated />
using System;
using AuthenticationProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AuthenticationProject.Migrations
{
    [DbContext(typeof(AuthenticationDBContext))]
    [Migration("20230821042511_BuildingCategory")]
    partial class BuildingCategory
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AuthenticationProject.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("AuthenticationProject.Models.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressId"));

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AddressId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("AuthenticationProject.Models.Apartment", b =>
                {
                    b.Property<int>("ApartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ApartmentId"));

                    b.Property<string>("ApartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Building")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BuildingCategoryCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("Floor")
                        .HasColumnType("int");

                    b.Property<int?>("Space")
                        .HasColumnType("int");

                    b.HasKey("ApartmentId");

                    b.HasIndex("BuildingCategoryCategoryId");

                    b.ToTable("Apartments");
                });

            modelBuilder.Entity("AuthenticationProject.Models.BuildingCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UrbanAreaUrbanId")
                        .HasColumnType("int");

                    b.Property<int>("UrbanId")
                        .HasColumnType("int");

                    b.HasKey("CategoryId");

                    b.HasIndex("AddressId");

                    b.HasIndex("UrbanAreaUrbanId");

                    b.ToTable("BuildingCategories");
                });

            modelBuilder.Entity("AuthenticationProject.Models.Customer", b =>
                {
                    b.Property<long?>("Makhachhang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long?>("Makhachhang"));

                    b.Property<string>("Cccd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diachi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hinhanh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Ngaycap")
                        .HasColumnType("datetime2");

                    b.Property<string>("Sodienthoai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tenkhachhang")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Makhachhang");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("AuthenticationProject.Models.Permission", b =>
                {
                    b.Property<long>("PermissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("PermissionId"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PermissionId");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("AuthenticationProject.Models.PermissionRole", b =>
                {
                    b.Property<long?>("PermissionRoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long?>("PermissionRoleId"));

                    b.Property<long?>("PermissionId")
                        .HasColumnType("bigint");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PermissionRoleId");

                    b.HasIndex("PermissionId");

                    b.HasIndex("RoleId");

                    b.ToTable("PermissionRoles");
                });

            modelBuilder.Entity("AuthenticationProject.Models.PermissionUser", b =>
                {
                    b.Property<long?>("PermissionUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long?>("PermissionUserId"));

                    b.Property<long?>("PermissionId")
                        .HasColumnType("bigint");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PermissionUserId");

                    b.HasIndex("PermissionId");

                    b.HasIndex("UserId");

                    b.ToTable("PermissionUsers");
                });

            modelBuilder.Entity("AuthenticationProject.Models.Resident", b =>
                {
                    b.Property<int>("ResidentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResidentId"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cccd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ResidentId");

                    b.ToTable("Resident");
                });

            modelBuilder.Entity("AuthenticationProject.Models.ResidentApartment", b =>
                {
                    b.Property<int>("ResidentApartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResidentApartmentId"));

                    b.Property<int?>("ApartmentId")
                        .HasColumnType("int");

                    b.Property<int?>("ResidentId")
                        .HasColumnType("int");

                    b.HasKey("ResidentApartmentId");

                    b.HasIndex("ApartmentId");

                    b.HasIndex("ResidentId");

                    b.ToTable("ResidentApartment");
                });

            modelBuilder.Entity("AuthenticationProject.Models.UrbanArea", b =>
                {
                    b.Property<int>("UrbanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UrbanId"));

                    b.Property<int?>("Population")
                        .HasColumnType("int");

                    b.Property<string>("UrbanName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UrbanId");

                    b.ToTable("UrbanAreas");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "87cfd94d-528f-4b74-b705-d3d1bf756d70",
                            ConcurrencyStamp = "4",
                            Name = "Apartment_Create",
                            NormalizedName = "Apartment_Create"
                        },
                        new
                        {
                            Id = "43902d8d-2d5a-4d37-87c7-d2a1788d258b",
                            ConcurrencyStamp = "4",
                            Name = "Apartment_Update",
                            NormalizedName = "Apartment_Update"
                        },
                        new
                        {
                            Id = "d48f040f-307b-4e97-8697-f14904efddc6",
                            ConcurrencyStamp = "4",
                            Name = "Apartment_Delete",
                            NormalizedName = "Apartment_Delete"
                        },
                        new
                        {
                            Id = "37e00be4-64c9-44da-98aa-50613fc73933",
                            ConcurrencyStamp = "4",
                            Name = "Apartment_DeleteMultiple",
                            NormalizedName = "Apartment_DeleteMultiple"
                        },
                        new
                        {
                            Id = "2f678588-bdf1-414c-82b6-38b707727ea2",
                            ConcurrencyStamp = "4",
                            Name = "Apartment_GetAll",
                            NormalizedName = "Apartment_GetAll"
                        },
                        new
                        {
                            Id = "fb52cc00-4c15-4f0c-a50e-2872f73ecc61",
                            ConcurrencyStamp = "4",
                            Name = "Apartment_GetById",
                            NormalizedName = "Apartment_GetById"
                        },
                        new
                        {
                            Id = "84a1d6a5-749b-4bfb-b3f2-fd12b98b3dba",
                            ConcurrencyStamp = "4",
                            Name = "User_Create",
                            NormalizedName = "User_Create"
                        },
                        new
                        {
                            Id = "0d141dca-7380-4ad4-a7fd-b0d38c5e6041",
                            ConcurrencyStamp = "4",
                            Name = "User_Update",
                            NormalizedName = "User_Update"
                        },
                        new
                        {
                            Id = "e5509a42-f5f8-4f30-95ec-77dd633346fd",
                            ConcurrencyStamp = "4",
                            Name = "User_Delete",
                            NormalizedName = "User_Delete"
                        },
                        new
                        {
                            Id = "e494de48-9366-4bc0-9374-f97b37a58321",
                            ConcurrencyStamp = "4",
                            Name = "User_DeleteMultiple",
                            NormalizedName = "User_DeleteMultiple"
                        },
                        new
                        {
                            Id = "10f7d383-e6ea-49fc-ae53-3e4116920491",
                            ConcurrencyStamp = "4",
                            Name = "User_GetAll",
                            NormalizedName = "User_GetAll"
                        },
                        new
                        {
                            Id = "b86944e2-5347-4a05-9e8a-74473474e8f6",
                            ConcurrencyStamp = "4",
                            Name = "User_GetById",
                            NormalizedName = "User_GetById"
                        },
                        new
                        {
                            Id = "4ed5fac0-db04-4740-a070-a2cce4cb62de",
                            ConcurrencyStamp = "4",
                            Name = "Resident_Create",
                            NormalizedName = "Resident_Create"
                        },
                        new
                        {
                            Id = "dcf04dfb-b0bd-475b-be08-34f347ae11d6",
                            ConcurrencyStamp = "4",
                            Name = "Resident_Update",
                            NormalizedName = "Resident_Update"
                        },
                        new
                        {
                            Id = "32a682dc-a7c0-4369-a683-63e70ed04fa1",
                            ConcurrencyStamp = "4",
                            Name = "Resident_Delete",
                            NormalizedName = "Resident_Delete"
                        },
                        new
                        {
                            Id = "93eae0b3-0917-4543-89ed-206390ad23ca",
                            ConcurrencyStamp = "4",
                            Name = "Resident_DeleteMultiple",
                            NormalizedName = "Resident_DeleteMultiple"
                        },
                        new
                        {
                            Id = "776a1b5e-9cd3-4837-b752-2936d1819dab",
                            ConcurrencyStamp = "4",
                            Name = "Resident_GetAll",
                            NormalizedName = "Resident_GetAll"
                        },
                        new
                        {
                            Id = "91fe8adf-ab93-4e3e-a11a-93a60893fe9d",
                            ConcurrencyStamp = "4",
                            Name = "Resident_GetById",
                            NormalizedName = "Resident_GetById"
                        },
                        new
                        {
                            Id = "53b4e585-5698-4863-a92f-51c82e96074b",
                            ConcurrencyStamp = "4",
                            Name = "Permission_Create",
                            NormalizedName = "Permission_Create"
                        },
                        new
                        {
                            Id = "5b693ea2-8a77-4b70-9350-5b0d03d20b8d",
                            ConcurrencyStamp = "4",
                            Name = "Permission_Update",
                            NormalizedName = "Permission_Update"
                        },
                        new
                        {
                            Id = "158e6717-bede-40ae-828a-8677b02e56a8",
                            ConcurrencyStamp = "4",
                            Name = "Permission_Delete",
                            NormalizedName = "Permission_Delete"
                        },
                        new
                        {
                            Id = "349163c3-c330-4137-8ebb-528efd0881d0",
                            ConcurrencyStamp = "4",
                            Name = "Permission_DeleteMultiple",
                            NormalizedName = "Permission_DeleteMultiple"
                        },
                        new
                        {
                            Id = "590396e9-e3e2-475d-855a-5cb9be328b6a",
                            ConcurrencyStamp = "4",
                            Name = "Permission_GetAll",
                            NormalizedName = "Permission_GetAll"
                        },
                        new
                        {
                            Id = "a31eb321-a476-4f75-8856-dd99a0037b3d",
                            ConcurrencyStamp = "4",
                            Name = "Permission_GetById",
                            NormalizedName = "Permission_GetById"
                        },
                        new
                        {
                            Id = "f4e7001f-924c-4cdf-b829-a951707afd8c",
                            ConcurrencyStamp = "4",
                            Name = "Customer_Create",
                            NormalizedName = "Customer_Create"
                        },
                        new
                        {
                            Id = "1c4c8c8f-ff78-4653-a2af-93b45599bc1f",
                            ConcurrencyStamp = "4",
                            Name = "Customer_Update",
                            NormalizedName = "Customer_Update"
                        },
                        new
                        {
                            Id = "ee4419a5-cf77-4b2a-863f-fc5e419c2e11",
                            ConcurrencyStamp = "4",
                            Name = "Customer_Delete",
                            NormalizedName = "Customer_Delete"
                        },
                        new
                        {
                            Id = "190c47ec-e5e9-45b9-a7d7-ef941816919d",
                            ConcurrencyStamp = "4",
                            Name = "Customer_DeleteMultiple",
                            NormalizedName = "Customer_DeleteMultiple"
                        },
                        new
                        {
                            Id = "7adcd543-437b-4a4f-a5d4-b8ec3808ed4a",
                            ConcurrencyStamp = "4",
                            Name = "Customer_GetAll",
                            NormalizedName = "Customer_GetAll"
                        },
                        new
                        {
                            Id = "3e59369e-978b-4c6c-b2c4-75ed5ef0afbb",
                            ConcurrencyStamp = "4",
                            Name = "Customer_GetById",
                            NormalizedName = "Customer_GetById"
                        },
                        new
                        {
                            Id = "e29981d5-ce02-4342-81d4-b022b3ce00b4",
                            ConcurrencyStamp = "4",
                            Name = "UrbanArea_Create",
                            NormalizedName = "UrbanArea_Create"
                        },
                        new
                        {
                            Id = "2ec8154d-ee85-4a69-a0c4-388d7895a7fe",
                            ConcurrencyStamp = "4",
                            Name = "UrbanArea_Update",
                            NormalizedName = "UrbanArea_Update"
                        },
                        new
                        {
                            Id = "7ae8d129-cd9c-44fa-b98f-c5527431bcdf",
                            ConcurrencyStamp = "4",
                            Name = "UrbanArea_Delete",
                            NormalizedName = "UrbanArea_Delete"
                        },
                        new
                        {
                            Id = "0de72702-a55a-4c41-bb51-16a91a36b8e2",
                            ConcurrencyStamp = "4",
                            Name = "UrbanArea_DeleteMultiple",
                            NormalizedName = "UrbanArea_DeleteMultiple"
                        },
                        new
                        {
                            Id = "5bc1f64f-6b72-4e20-bb88-5be08549d4a5",
                            ConcurrencyStamp = "4",
                            Name = "UrbanArea_GetAll",
                            NormalizedName = "UrbanArea_GetAll"
                        },
                        new
                        {
                            Id = "4ca1121d-1c07-4018-9f8f-e08756b671da",
                            ConcurrencyStamp = "4",
                            Name = "UrbanArea_GetById",
                            NormalizedName = "UrbanArea_GetById"
                        },
                        new
                        {
                            Id = "273d0cab-6071-42dd-bcac-421b9253dd19",
                            ConcurrencyStamp = "4",
                            Name = "BuildingCategorie_Create",
                            NormalizedName = "BuildingCategorie_Create"
                        },
                        new
                        {
                            Id = "e81e427f-8abf-4d68-b6d3-7dc34cff39bc",
                            ConcurrencyStamp = "4",
                            Name = "BuildingCategorie_Update",
                            NormalizedName = "BuildingCategorie_Update"
                        },
                        new
                        {
                            Id = "b4bf4eb3-5c82-446c-b97c-388879605935",
                            ConcurrencyStamp = "4",
                            Name = "BuildingCategorie_Delete",
                            NormalizedName = "BuildingCategorie_Delete"
                        },
                        new
                        {
                            Id = "2147b67b-810a-4c7c-9091-f7c195f80e44",
                            ConcurrencyStamp = "4",
                            Name = "BuildingCategorie_DeleteMultiple",
                            NormalizedName = "BuildingCategorie_DeleteMultiple"
                        },
                        new
                        {
                            Id = "ee0dd263-8c99-46b3-a3a2-35d52f98e208",
                            ConcurrencyStamp = "4",
                            Name = "BuildingCategorie_GetAll",
                            NormalizedName = "BuildingCategorie_GetAll"
                        },
                        new
                        {
                            Id = "6fad30c2-7f31-4e22-9eaf-b206be70b984",
                            ConcurrencyStamp = "4",
                            Name = "BuildingCategorie_GetById",
                            NormalizedName = "BuildingCategorie_GetById"
                        },
                        new
                        {
                            Id = "39311dce-73bb-458c-86f3-54df0538f307",
                            ConcurrencyStamp = "4",
                            Name = "Addresse_Create",
                            NormalizedName = "Addresse_Create"
                        },
                        new
                        {
                            Id = "654fb25b-9562-4b37-9cf1-af5111e5ce6e",
                            ConcurrencyStamp = "4",
                            Name = "Addresse_Update",
                            NormalizedName = "Addresse_Update"
                        },
                        new
                        {
                            Id = "5968b0a3-929e-4a3f-b6c2-a34d0ac2cd34",
                            ConcurrencyStamp = "4",
                            Name = "Addresse_Delete",
                            NormalizedName = "Addresse_Delete"
                        },
                        new
                        {
                            Id = "f62e7e78-680b-42a1-bc51-3942bf0fdd6f",
                            ConcurrencyStamp = "4",
                            Name = "Addresse_DeleteMultiple",
                            NormalizedName = "Addresse_DeleteMultiple"
                        },
                        new
                        {
                            Id = "ba933c4e-3b42-4581-ae28-f212ddb2ff74",
                            ConcurrencyStamp = "4",
                            Name = "Addresse_GetAll",
                            NormalizedName = "Addresse_GetAll"
                        },
                        new
                        {
                            Id = "908a52e9-5758-4aa6-82a3-3978daaefe37",
                            ConcurrencyStamp = "4",
                            Name = "Addresse_GetById",
                            NormalizedName = "Addresse_GetById"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("AuthenticationProject.Models.Apartment", b =>
                {
                    b.HasOne("AuthenticationProject.Models.BuildingCategory", "BuildingCategory")
                        .WithMany("Apartments")
                        .HasForeignKey("BuildingCategoryCategoryId");

                    b.Navigation("BuildingCategory");
                });

            modelBuilder.Entity("AuthenticationProject.Models.BuildingCategory", b =>
                {
                    b.HasOne("AuthenticationProject.Models.Address", "Address")
                        .WithMany("buildingCategories")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AuthenticationProject.Models.UrbanArea", "UrbanArea")
                        .WithMany("buildingCategories")
                        .HasForeignKey("UrbanAreaUrbanId");

                    b.Navigation("Address");

                    b.Navigation("UrbanArea");
                });

            modelBuilder.Entity("AuthenticationProject.Models.PermissionRole", b =>
                {
                    b.HasOne("AuthenticationProject.Models.Permission", "Permission")
                        .WithMany("PermissionRoles")
                        .HasForeignKey("PermissionId");

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.Navigation("Permission");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("AuthenticationProject.Models.PermissionUser", b =>
                {
                    b.HasOne("AuthenticationProject.Models.Permission", "Permission")
                        .WithMany("PermissionUsers")
                        .HasForeignKey("PermissionId");

                    b.HasOne("AuthenticationProject.Data.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Permission");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AuthenticationProject.Models.ResidentApartment", b =>
                {
                    b.HasOne("AuthenticationProject.Models.Apartment", "Apartment")
                        .WithMany("ResidentApartments")
                        .HasForeignKey("ApartmentId");

                    b.HasOne("AuthenticationProject.Models.Resident", "Resident")
                        .WithMany("ResidentApartments")
                        .HasForeignKey("ResidentId");

                    b.Navigation("Apartment");

                    b.Navigation("Resident");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("AuthenticationProject.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("AuthenticationProject.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AuthenticationProject.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("AuthenticationProject.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AuthenticationProject.Models.Address", b =>
                {
                    b.Navigation("buildingCategories");
                });

            modelBuilder.Entity("AuthenticationProject.Models.Apartment", b =>
                {
                    b.Navigation("ResidentApartments");
                });

            modelBuilder.Entity("AuthenticationProject.Models.BuildingCategory", b =>
                {
                    b.Navigation("Apartments");
                });

            modelBuilder.Entity("AuthenticationProject.Models.Permission", b =>
                {
                    b.Navigation("PermissionRoles");

                    b.Navigation("PermissionUsers");
                });

            modelBuilder.Entity("AuthenticationProject.Models.Resident", b =>
                {
                    b.Navigation("ResidentApartments");
                });

            modelBuilder.Entity("AuthenticationProject.Models.UrbanArea", b =>
                {
                    b.Navigation("buildingCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
