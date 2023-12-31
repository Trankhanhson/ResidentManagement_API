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
    [Migration("20230821093626_updateNew")]
    partial class updateNew
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

                    b.Property<string>("Commune")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
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
                            Id = "a7222042-4a62-471c-850d-95824ae471a7",
                            ConcurrencyStamp = "4",
                            Name = "Apartment_Create",
                            NormalizedName = "Apartment_Create"
                        },
                        new
                        {
                            Id = "711a13a7-6f5f-4992-9a48-4dcf47bf5fc1",
                            ConcurrencyStamp = "4",
                            Name = "Apartment_Update",
                            NormalizedName = "Apartment_Update"
                        },
                        new
                        {
                            Id = "f34914f6-dbca-4898-9ea2-79de87f3df3f",
                            ConcurrencyStamp = "4",
                            Name = "Apartment_Delete",
                            NormalizedName = "Apartment_Delete"
                        },
                        new
                        {
                            Id = "b0f9c342-18ed-41b7-9881-a1032c32ecca",
                            ConcurrencyStamp = "4",
                            Name = "Apartment_DeleteMultiple",
                            NormalizedName = "Apartment_DeleteMultiple"
                        },
                        new
                        {
                            Id = "cb59eeb9-5f54-4c85-972a-30c67f3cf1b7",
                            ConcurrencyStamp = "4",
                            Name = "Apartment_GetAll",
                            NormalizedName = "Apartment_GetAll"
                        },
                        new
                        {
                            Id = "1e85f124-cfec-490b-9e59-b42df68fd02b",
                            ConcurrencyStamp = "4",
                            Name = "Apartment_GetById",
                            NormalizedName = "Apartment_GetById"
                        },
                        new
                        {
                            Id = "8135f3b9-896f-4902-acb6-d26cfda6b43c",
                            ConcurrencyStamp = "4",
                            Name = "User_Create",
                            NormalizedName = "User_Create"
                        },
                        new
                        {
                            Id = "93c0f295-0a25-411a-a6c7-564aaf8d6ca4",
                            ConcurrencyStamp = "4",
                            Name = "User_Update",
                            NormalizedName = "User_Update"
                        },
                        new
                        {
                            Id = "6171750f-a321-4d11-94c1-9baeedd2f89c",
                            ConcurrencyStamp = "4",
                            Name = "User_Delete",
                            NormalizedName = "User_Delete"
                        },
                        new
                        {
                            Id = "21b14071-87c1-4da4-836d-63036f3d0c88",
                            ConcurrencyStamp = "4",
                            Name = "User_DeleteMultiple",
                            NormalizedName = "User_DeleteMultiple"
                        },
                        new
                        {
                            Id = "145e479d-3c19-4e1c-a2a8-e70efeade9b9",
                            ConcurrencyStamp = "4",
                            Name = "User_GetAll",
                            NormalizedName = "User_GetAll"
                        },
                        new
                        {
                            Id = "7d18cb29-03f7-4683-9301-1de20600232d",
                            ConcurrencyStamp = "4",
                            Name = "User_GetById",
                            NormalizedName = "User_GetById"
                        },
                        new
                        {
                            Id = "a378bbd0-b66a-4547-92e6-976b630d56d2",
                            ConcurrencyStamp = "4",
                            Name = "Resident_Create",
                            NormalizedName = "Resident_Create"
                        },
                        new
                        {
                            Id = "aedf4e34-66d7-40eb-b952-5a1b9770fe98",
                            ConcurrencyStamp = "4",
                            Name = "Resident_Update",
                            NormalizedName = "Resident_Update"
                        },
                        new
                        {
                            Id = "18438c3f-0419-41a1-a95b-3edc70af8971",
                            ConcurrencyStamp = "4",
                            Name = "Resident_Delete",
                            NormalizedName = "Resident_Delete"
                        },
                        new
                        {
                            Id = "45e51b35-a9c6-444c-9989-87fb6855e282",
                            ConcurrencyStamp = "4",
                            Name = "Resident_DeleteMultiple",
                            NormalizedName = "Resident_DeleteMultiple"
                        },
                        new
                        {
                            Id = "662d1a22-cb23-494a-8aa8-eaeb927f9a13",
                            ConcurrencyStamp = "4",
                            Name = "Resident_GetAll",
                            NormalizedName = "Resident_GetAll"
                        },
                        new
                        {
                            Id = "93eb864e-e698-4700-ac77-4fea6c56d4ab",
                            ConcurrencyStamp = "4",
                            Name = "Resident_GetById",
                            NormalizedName = "Resident_GetById"
                        },
                        new
                        {
                            Id = "85f4867e-bcb0-44e9-ae76-59bc3c0ff565",
                            ConcurrencyStamp = "4",
                            Name = "Permission_Create",
                            NormalizedName = "Permission_Create"
                        },
                        new
                        {
                            Id = "ac0ef910-df9b-46f5-b81f-25637a04e80d",
                            ConcurrencyStamp = "4",
                            Name = "Permission_Update",
                            NormalizedName = "Permission_Update"
                        },
                        new
                        {
                            Id = "2d6eb1ed-7c54-4bdd-8154-879707538db9",
                            ConcurrencyStamp = "4",
                            Name = "Permission_Delete",
                            NormalizedName = "Permission_Delete"
                        },
                        new
                        {
                            Id = "e42694b7-9d73-4b8e-9ed5-78cd9a2db30a",
                            ConcurrencyStamp = "4",
                            Name = "Permission_DeleteMultiple",
                            NormalizedName = "Permission_DeleteMultiple"
                        },
                        new
                        {
                            Id = "e8d503bb-b993-43c8-8839-c23ac692a871",
                            ConcurrencyStamp = "4",
                            Name = "Permission_GetAll",
                            NormalizedName = "Permission_GetAll"
                        },
                        new
                        {
                            Id = "ee9a1eb6-8c5b-4cf5-b56f-f25804f35526",
                            ConcurrencyStamp = "4",
                            Name = "Permission_GetById",
                            NormalizedName = "Permission_GetById"
                        },
                        new
                        {
                            Id = "68a5592f-4c88-4392-817a-ee0e42290368",
                            ConcurrencyStamp = "4",
                            Name = "Customer_Create",
                            NormalizedName = "Customer_Create"
                        },
                        new
                        {
                            Id = "df39e523-092e-46f2-9ba3-982d1dc83df5",
                            ConcurrencyStamp = "4",
                            Name = "Customer_Update",
                            NormalizedName = "Customer_Update"
                        },
                        new
                        {
                            Id = "754088df-9a66-4566-8397-c5619f97ca7a",
                            ConcurrencyStamp = "4",
                            Name = "Customer_Delete",
                            NormalizedName = "Customer_Delete"
                        },
                        new
                        {
                            Id = "708df00e-d640-4b5f-891d-9663f780ec1f",
                            ConcurrencyStamp = "4",
                            Name = "Customer_DeleteMultiple",
                            NormalizedName = "Customer_DeleteMultiple"
                        },
                        new
                        {
                            Id = "31c0726d-f114-4d22-a161-f87e3d0de659",
                            ConcurrencyStamp = "4",
                            Name = "Customer_GetAll",
                            NormalizedName = "Customer_GetAll"
                        },
                        new
                        {
                            Id = "9b7d47c3-bbac-4e0a-b5af-3573a9682dd8",
                            ConcurrencyStamp = "4",
                            Name = "Customer_GetById",
                            NormalizedName = "Customer_GetById"
                        },
                        new
                        {
                            Id = "e9fc8a9d-a24e-4331-a5d2-32214b113b1a",
                            ConcurrencyStamp = "4",
                            Name = "UrbanArea_Create",
                            NormalizedName = "UrbanArea_Create"
                        },
                        new
                        {
                            Id = "05138b36-f0fd-42a2-ba2c-df0e3833e444",
                            ConcurrencyStamp = "4",
                            Name = "UrbanArea_Update",
                            NormalizedName = "UrbanArea_Update"
                        },
                        new
                        {
                            Id = "77fa7ad2-86a9-4b1e-8bce-eebf297bb50b",
                            ConcurrencyStamp = "4",
                            Name = "UrbanArea_Delete",
                            NormalizedName = "UrbanArea_Delete"
                        },
                        new
                        {
                            Id = "8ec79f31-2c60-4fee-a97c-370ff2ca959f",
                            ConcurrencyStamp = "4",
                            Name = "UrbanArea_DeleteMultiple",
                            NormalizedName = "UrbanArea_DeleteMultiple"
                        },
                        new
                        {
                            Id = "e7ce56ac-8c48-46e4-b020-9b32e38b3ef6",
                            ConcurrencyStamp = "4",
                            Name = "UrbanArea_GetAll",
                            NormalizedName = "UrbanArea_GetAll"
                        },
                        new
                        {
                            Id = "8c40dfcb-a851-43c2-9c5e-9cca665609ff",
                            ConcurrencyStamp = "4",
                            Name = "UrbanArea_GetById",
                            NormalizedName = "UrbanArea_GetById"
                        },
                        new
                        {
                            Id = "a923f822-6ca7-4172-a2cf-d38968877638",
                            ConcurrencyStamp = "4",
                            Name = "BuildingCategorie_Create",
                            NormalizedName = "BuildingCategorie_Create"
                        },
                        new
                        {
                            Id = "8997ba6d-a60f-40e3-b920-5f1d958ade0b",
                            ConcurrencyStamp = "4",
                            Name = "BuildingCategorie_Update",
                            NormalizedName = "BuildingCategorie_Update"
                        },
                        new
                        {
                            Id = "c20d89a4-1a1d-4d96-83c3-88f29a962a36",
                            ConcurrencyStamp = "4",
                            Name = "BuildingCategorie_Delete",
                            NormalizedName = "BuildingCategorie_Delete"
                        },
                        new
                        {
                            Id = "fc26265c-9087-45ff-b23a-d92cf1416fab",
                            ConcurrencyStamp = "4",
                            Name = "BuildingCategorie_DeleteMultiple",
                            NormalizedName = "BuildingCategorie_DeleteMultiple"
                        },
                        new
                        {
                            Id = "60768870-8f8c-4d36-bb7f-e2fd61fc1d94",
                            ConcurrencyStamp = "4",
                            Name = "BuildingCategorie_GetAll",
                            NormalizedName = "BuildingCategorie_GetAll"
                        },
                        new
                        {
                            Id = "b74c56a4-6fa4-43d0-8f94-28f2cf8c3d69",
                            ConcurrencyStamp = "4",
                            Name = "BuildingCategorie_GetById",
                            NormalizedName = "BuildingCategorie_GetById"
                        },
                        new
                        {
                            Id = "b58b34ea-b7e8-452a-86fe-09bdae445fd7",
                            ConcurrencyStamp = "4",
                            Name = "Addresse_Create",
                            NormalizedName = "Addresse_Create"
                        },
                        new
                        {
                            Id = "0ca7ec81-a15e-4b1b-950f-c58ce92b9adc",
                            ConcurrencyStamp = "4",
                            Name = "Addresse_Update",
                            NormalizedName = "Addresse_Update"
                        },
                        new
                        {
                            Id = "661f677c-1b54-4e17-892c-61df4ea5b42a",
                            ConcurrencyStamp = "4",
                            Name = "Addresse_Delete",
                            NormalizedName = "Addresse_Delete"
                        },
                        new
                        {
                            Id = "c4c752bc-31ef-4984-9fcd-fe70835475e0",
                            ConcurrencyStamp = "4",
                            Name = "Addresse_DeleteMultiple",
                            NormalizedName = "Addresse_DeleteMultiple"
                        },
                        new
                        {
                            Id = "9a17d9bb-e178-44ae-ba56-d8073565760b",
                            ConcurrencyStamp = "4",
                            Name = "Addresse_GetAll",
                            NormalizedName = "Addresse_GetAll"
                        },
                        new
                        {
                            Id = "efb0fcb4-071a-4aad-87c4-39819d683d94",
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
