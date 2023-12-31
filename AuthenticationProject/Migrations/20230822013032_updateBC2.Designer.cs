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
    [Migration("20230822013032_updateBC2")]
    partial class updateBC2
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

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("Floor")
                        .HasColumnType("int");

                    b.Property<int?>("Space")
                        .HasColumnType("int");

                    b.HasKey("ApartmentId");

                    b.HasIndex("CategoryId");

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

                    b.Property<int>("UrbanId")
                        .HasColumnType("int");

                    b.HasKey("CategoryId");

                    b.HasIndex("AddressId");

                    b.HasIndex("UrbanId");

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
                            Id = "facad8ca-ffe9-4f09-8fa8-9db2e21aa0e9",
                            ConcurrencyStamp = "4",
                            Name = "Apartment_Create",
                            NormalizedName = "Apartment_Create"
                        },
                        new
                        {
                            Id = "ba17de18-6d90-4638-8e8f-53f8e8c864cb",
                            ConcurrencyStamp = "4",
                            Name = "Apartment_Update",
                            NormalizedName = "Apartment_Update"
                        },
                        new
                        {
                            Id = "e7059776-2430-4f7e-8710-5466c4b70700",
                            ConcurrencyStamp = "4",
                            Name = "Apartment_Delete",
                            NormalizedName = "Apartment_Delete"
                        },
                        new
                        {
                            Id = "9ca61611-3c79-404f-8847-86a41c3cf1fc",
                            ConcurrencyStamp = "4",
                            Name = "Apartment_DeleteMultiple",
                            NormalizedName = "Apartment_DeleteMultiple"
                        },
                        new
                        {
                            Id = "8bc92bac-2792-44a1-8a74-b2eb4f670bf2",
                            ConcurrencyStamp = "4",
                            Name = "Apartment_GetAll",
                            NormalizedName = "Apartment_GetAll"
                        },
                        new
                        {
                            Id = "643fd86a-0926-4a95-b9d7-7f3913ed2db1",
                            ConcurrencyStamp = "4",
                            Name = "Apartment_GetById",
                            NormalizedName = "Apartment_GetById"
                        },
                        new
                        {
                            Id = "e6c269a8-2528-4a51-96d1-d54b7b28730f",
                            ConcurrencyStamp = "4",
                            Name = "User_Create",
                            NormalizedName = "User_Create"
                        },
                        new
                        {
                            Id = "a81d6d3c-0537-47bc-9c7a-806857a13f4e",
                            ConcurrencyStamp = "4",
                            Name = "User_Update",
                            NormalizedName = "User_Update"
                        },
                        new
                        {
                            Id = "9ee1aa1b-ff21-43ea-a49e-8f2551d1d290",
                            ConcurrencyStamp = "4",
                            Name = "User_Delete",
                            NormalizedName = "User_Delete"
                        },
                        new
                        {
                            Id = "4edc0227-d64b-4f4c-beeb-6c425865cc7a",
                            ConcurrencyStamp = "4",
                            Name = "User_DeleteMultiple",
                            NormalizedName = "User_DeleteMultiple"
                        },
                        new
                        {
                            Id = "f82e515d-b35c-4bf2-90e0-5bb98d1d280a",
                            ConcurrencyStamp = "4",
                            Name = "User_GetAll",
                            NormalizedName = "User_GetAll"
                        },
                        new
                        {
                            Id = "a1b7d41f-c7d3-4c7a-8807-1254476cb98d",
                            ConcurrencyStamp = "4",
                            Name = "User_GetById",
                            NormalizedName = "User_GetById"
                        },
                        new
                        {
                            Id = "8c328a74-0afb-4a6f-846f-d6a7204398fc",
                            ConcurrencyStamp = "4",
                            Name = "Resident_Create",
                            NormalizedName = "Resident_Create"
                        },
                        new
                        {
                            Id = "8610b603-bf00-4633-adff-d1846d0a5897",
                            ConcurrencyStamp = "4",
                            Name = "Resident_Update",
                            NormalizedName = "Resident_Update"
                        },
                        new
                        {
                            Id = "5bbf906a-8d29-4eec-b61d-128fadd83d47",
                            ConcurrencyStamp = "4",
                            Name = "Resident_Delete",
                            NormalizedName = "Resident_Delete"
                        },
                        new
                        {
                            Id = "6f3aaed4-bd15-4d28-9905-2be7c2bda6b0",
                            ConcurrencyStamp = "4",
                            Name = "Resident_DeleteMultiple",
                            NormalizedName = "Resident_DeleteMultiple"
                        },
                        new
                        {
                            Id = "d3e3fd19-4f34-4c37-a7dd-6fc549886f7c",
                            ConcurrencyStamp = "4",
                            Name = "Resident_GetAll",
                            NormalizedName = "Resident_GetAll"
                        },
                        new
                        {
                            Id = "64b227cc-bdcc-45de-afd1-dcb0a8791898",
                            ConcurrencyStamp = "4",
                            Name = "Resident_GetById",
                            NormalizedName = "Resident_GetById"
                        },
                        new
                        {
                            Id = "90695955-6237-4340-8b8b-c5b521c3d331",
                            ConcurrencyStamp = "4",
                            Name = "Permission_Create",
                            NormalizedName = "Permission_Create"
                        },
                        new
                        {
                            Id = "3aaae9b9-1113-47ae-9e38-6a18c0e9e82f",
                            ConcurrencyStamp = "4",
                            Name = "Permission_Update",
                            NormalizedName = "Permission_Update"
                        },
                        new
                        {
                            Id = "041efbcc-fa40-4d8d-9fef-dd605be24497",
                            ConcurrencyStamp = "4",
                            Name = "Permission_Delete",
                            NormalizedName = "Permission_Delete"
                        },
                        new
                        {
                            Id = "cd6fa288-643f-4acb-9db6-59d1d7836f18",
                            ConcurrencyStamp = "4",
                            Name = "Permission_DeleteMultiple",
                            NormalizedName = "Permission_DeleteMultiple"
                        },
                        new
                        {
                            Id = "8c9b1626-42f8-4448-b6c5-4426f2000138",
                            ConcurrencyStamp = "4",
                            Name = "Permission_GetAll",
                            NormalizedName = "Permission_GetAll"
                        },
                        new
                        {
                            Id = "7221b35a-9833-43a3-8be6-c8b6afefd984",
                            ConcurrencyStamp = "4",
                            Name = "Permission_GetById",
                            NormalizedName = "Permission_GetById"
                        },
                        new
                        {
                            Id = "dccf4c9b-95d4-4f66-9b28-5b17d460e668",
                            ConcurrencyStamp = "4",
                            Name = "Customer_Create",
                            NormalizedName = "Customer_Create"
                        },
                        new
                        {
                            Id = "200047ec-3c7b-45a5-9c85-540a0785ecb8",
                            ConcurrencyStamp = "4",
                            Name = "Customer_Update",
                            NormalizedName = "Customer_Update"
                        },
                        new
                        {
                            Id = "c943c1e8-14e0-4aa0-853d-275d6f7ffc46",
                            ConcurrencyStamp = "4",
                            Name = "Customer_Delete",
                            NormalizedName = "Customer_Delete"
                        },
                        new
                        {
                            Id = "a57dda58-34a6-419c-aa3e-c354510bfd77",
                            ConcurrencyStamp = "4",
                            Name = "Customer_DeleteMultiple",
                            NormalizedName = "Customer_DeleteMultiple"
                        },
                        new
                        {
                            Id = "ffabf91d-64fa-4045-b695-c0511bca8d73",
                            ConcurrencyStamp = "4",
                            Name = "Customer_GetAll",
                            NormalizedName = "Customer_GetAll"
                        },
                        new
                        {
                            Id = "97ace3b6-d325-4316-82ee-df16d3d7650a",
                            ConcurrencyStamp = "4",
                            Name = "Customer_GetById",
                            NormalizedName = "Customer_GetById"
                        },
                        new
                        {
                            Id = "42de8dfc-df64-414a-9dba-b97625b08d2e",
                            ConcurrencyStamp = "4",
                            Name = "UrbanArea_Create",
                            NormalizedName = "UrbanArea_Create"
                        },
                        new
                        {
                            Id = "096dee13-27b4-4ed5-9c6e-d28501e01a48",
                            ConcurrencyStamp = "4",
                            Name = "UrbanArea_Update",
                            NormalizedName = "UrbanArea_Update"
                        },
                        new
                        {
                            Id = "e01e128a-f518-4e45-9dc8-b7c40537d0c7",
                            ConcurrencyStamp = "4",
                            Name = "UrbanArea_Delete",
                            NormalizedName = "UrbanArea_Delete"
                        },
                        new
                        {
                            Id = "94dfb0bf-e84c-4674-8086-9df8fe93f7e7",
                            ConcurrencyStamp = "4",
                            Name = "UrbanArea_DeleteMultiple",
                            NormalizedName = "UrbanArea_DeleteMultiple"
                        },
                        new
                        {
                            Id = "aa98bcce-864c-4765-a0a5-0f06f4851963",
                            ConcurrencyStamp = "4",
                            Name = "UrbanArea_GetAll",
                            NormalizedName = "UrbanArea_GetAll"
                        },
                        new
                        {
                            Id = "d04b7daf-05d6-4881-bc7c-183788548730",
                            ConcurrencyStamp = "4",
                            Name = "UrbanArea_GetById",
                            NormalizedName = "UrbanArea_GetById"
                        },
                        new
                        {
                            Id = "6e25a1d7-51d7-4b3d-b5ea-53bab7948223",
                            ConcurrencyStamp = "4",
                            Name = "BuildingCategorie_Create",
                            NormalizedName = "BuildingCategorie_Create"
                        },
                        new
                        {
                            Id = "d974e981-4c3d-4c1c-9cad-eeea57fdaf69",
                            ConcurrencyStamp = "4",
                            Name = "BuildingCategorie_Update",
                            NormalizedName = "BuildingCategorie_Update"
                        },
                        new
                        {
                            Id = "388ef2f6-623e-4525-bf70-3cef6e8d7fa1",
                            ConcurrencyStamp = "4",
                            Name = "BuildingCategorie_Delete",
                            NormalizedName = "BuildingCategorie_Delete"
                        },
                        new
                        {
                            Id = "d27640f6-0ef0-4e61-bc0d-28340f243ebf",
                            ConcurrencyStamp = "4",
                            Name = "BuildingCategorie_DeleteMultiple",
                            NormalizedName = "BuildingCategorie_DeleteMultiple"
                        },
                        new
                        {
                            Id = "0a95533f-123d-4895-aa5f-ea8d630d28ee",
                            ConcurrencyStamp = "4",
                            Name = "BuildingCategorie_GetAll",
                            NormalizedName = "BuildingCategorie_GetAll"
                        },
                        new
                        {
                            Id = "4ae7c7dd-5a59-417c-9ee8-cc2c64ba5115",
                            ConcurrencyStamp = "4",
                            Name = "BuildingCategorie_GetById",
                            NormalizedName = "BuildingCategorie_GetById"
                        },
                        new
                        {
                            Id = "1b521f0c-a429-4d7f-b3e1-ad8a2e6e9dc9",
                            ConcurrencyStamp = "4",
                            Name = "Addresse_Create",
                            NormalizedName = "Addresse_Create"
                        },
                        new
                        {
                            Id = "87045f3f-fdb2-4cb2-8ac8-db69c8b0c3d7",
                            ConcurrencyStamp = "4",
                            Name = "Addresse_Update",
                            NormalizedName = "Addresse_Update"
                        },
                        new
                        {
                            Id = "7081a9ab-3203-4e35-b341-ae55f25c67ab",
                            ConcurrencyStamp = "4",
                            Name = "Addresse_Delete",
                            NormalizedName = "Addresse_Delete"
                        },
                        new
                        {
                            Id = "919f040b-71b4-42f7-8a28-99998ee4189a",
                            ConcurrencyStamp = "4",
                            Name = "Addresse_DeleteMultiple",
                            NormalizedName = "Addresse_DeleteMultiple"
                        },
                        new
                        {
                            Id = "168806ec-ff3e-49a0-89a7-d5328584379e",
                            ConcurrencyStamp = "4",
                            Name = "Addresse_GetAll",
                            NormalizedName = "Addresse_GetAll"
                        },
                        new
                        {
                            Id = "eec760e0-84b1-4e36-8d4f-425f1ccd8af3",
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
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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
                        .HasForeignKey("UrbanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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
