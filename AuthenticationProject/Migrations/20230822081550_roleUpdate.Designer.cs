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
    [Migration("20230822081550_roleUpdate")]
    partial class roleUpdate
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
                            Id = "7796aa81-3296-45b8-ba78-add610716673",
                            ConcurrencyStamp = "4",
                            Name = "Apartment_Create",
                            NormalizedName = "Apartment_Create"
                        },
                        new
                        {
                            Id = "5e78ec34-dd90-491a-bdad-f9da36b2a3d0",
                            ConcurrencyStamp = "4",
                            Name = "Apartment_Update",
                            NormalizedName = "Apartment_Update"
                        },
                        new
                        {
                            Id = "52b47086-f96f-4c28-9cd8-d0e127fc33ed",
                            ConcurrencyStamp = "4",
                            Name = "Apartment_Delete",
                            NormalizedName = "Apartment_Delete"
                        },
                        new
                        {
                            Id = "0126a158-f9e5-494f-8c39-fdca8c316de0",
                            ConcurrencyStamp = "4",
                            Name = "Apartment_DeleteMultiple",
                            NormalizedName = "Apartment_DeleteMultiple"
                        },
                        new
                        {
                            Id = "b88b1a74-db98-49e1-ab03-2b30145fde11",
                            ConcurrencyStamp = "4",
                            Name = "Apartment_GetAll",
                            NormalizedName = "Apartment_GetAll"
                        },
                        new
                        {
                            Id = "d301acfe-c20f-41f6-807f-20be68797775",
                            ConcurrencyStamp = "4",
                            Name = "Apartment_GetById",
                            NormalizedName = "Apartment_GetById"
                        },
                        new
                        {
                            Id = "3b562f50-6948-44c3-a7b5-986e248413b8",
                            ConcurrencyStamp = "4",
                            Name = "User_Create",
                            NormalizedName = "User_Create"
                        },
                        new
                        {
                            Id = "18540016-205d-49e8-8b39-f3a5e7eeb179",
                            ConcurrencyStamp = "4",
                            Name = "User_Update",
                            NormalizedName = "User_Update"
                        },
                        new
                        {
                            Id = "bd18a087-cfe1-4d4b-899f-e2814e84df2e",
                            ConcurrencyStamp = "4",
                            Name = "User_Delete",
                            NormalizedName = "User_Delete"
                        },
                        new
                        {
                            Id = "08096062-d77f-445c-9612-eed852d75395",
                            ConcurrencyStamp = "4",
                            Name = "User_DeleteMultiple",
                            NormalizedName = "User_DeleteMultiple"
                        },
                        new
                        {
                            Id = "388fee5c-c79c-4e95-a318-d4a501073aa4",
                            ConcurrencyStamp = "4",
                            Name = "User_GetAll",
                            NormalizedName = "User_GetAll"
                        },
                        new
                        {
                            Id = "0dfc6ea5-210f-44e5-ab33-3237d7e39c05",
                            ConcurrencyStamp = "4",
                            Name = "User_GetById",
                            NormalizedName = "User_GetById"
                        },
                        new
                        {
                            Id = "f7481977-bf73-4ae6-bd4a-524a7fe92101",
                            ConcurrencyStamp = "4",
                            Name = "Resident_Create",
                            NormalizedName = "Resident_Create"
                        },
                        new
                        {
                            Id = "6fa12d2e-178d-4e6d-a35c-0c7e1fdb8e08",
                            ConcurrencyStamp = "4",
                            Name = "Resident_Update",
                            NormalizedName = "Resident_Update"
                        },
                        new
                        {
                            Id = "514107c8-a7e4-45f1-aff8-bc628e51d386",
                            ConcurrencyStamp = "4",
                            Name = "Resident_Delete",
                            NormalizedName = "Resident_Delete"
                        },
                        new
                        {
                            Id = "6ec01335-9614-4b21-900b-1185e7626269",
                            ConcurrencyStamp = "4",
                            Name = "Resident_DeleteMultiple",
                            NormalizedName = "Resident_DeleteMultiple"
                        },
                        new
                        {
                            Id = "2464ffd8-de8c-4ebb-8005-8666dbb9a723",
                            ConcurrencyStamp = "4",
                            Name = "Resident_GetAll",
                            NormalizedName = "Resident_GetAll"
                        },
                        new
                        {
                            Id = "a476c983-519c-4523-bfed-d6bdbc26b832",
                            ConcurrencyStamp = "4",
                            Name = "Resident_GetById",
                            NormalizedName = "Resident_GetById"
                        },
                        new
                        {
                            Id = "438964c7-a659-4347-aff0-d9d169deb034",
                            ConcurrencyStamp = "4",
                            Name = "Permission_Create",
                            NormalizedName = "Permission_Create"
                        },
                        new
                        {
                            Id = "8421e5e5-4579-4668-abb2-af0d544a5b06",
                            ConcurrencyStamp = "4",
                            Name = "Permission_Update",
                            NormalizedName = "Permission_Update"
                        },
                        new
                        {
                            Id = "e1db33e5-c302-4d53-8afe-40afb17bc48a",
                            ConcurrencyStamp = "4",
                            Name = "Permission_Delete",
                            NormalizedName = "Permission_Delete"
                        },
                        new
                        {
                            Id = "86c64e37-f50f-4f99-b426-77cd9c39fc34",
                            ConcurrencyStamp = "4",
                            Name = "Permission_DeleteMultiple",
                            NormalizedName = "Permission_DeleteMultiple"
                        },
                        new
                        {
                            Id = "83d184fe-fbfa-4215-8e26-8552148021a5",
                            ConcurrencyStamp = "4",
                            Name = "Permission_GetAll",
                            NormalizedName = "Permission_GetAll"
                        },
                        new
                        {
                            Id = "98a9184d-9c50-4e94-8697-44821365d4cf",
                            ConcurrencyStamp = "4",
                            Name = "Permission_GetById",
                            NormalizedName = "Permission_GetById"
                        },
                        new
                        {
                            Id = "1bcb7a2d-2973-4ae2-bc11-c4857457e2f3",
                            ConcurrencyStamp = "4",
                            Name = "Customer_Create",
                            NormalizedName = "Customer_Create"
                        },
                        new
                        {
                            Id = "bb295213-5816-44bd-94b0-3766740ba47c",
                            ConcurrencyStamp = "4",
                            Name = "Customer_Update",
                            NormalizedName = "Customer_Update"
                        },
                        new
                        {
                            Id = "76ea388e-c99c-4493-8bf3-7f2cf03b4a4c",
                            ConcurrencyStamp = "4",
                            Name = "Customer_Delete",
                            NormalizedName = "Customer_Delete"
                        },
                        new
                        {
                            Id = "a026706c-284c-44fd-85e9-fca29f889382",
                            ConcurrencyStamp = "4",
                            Name = "Customer_DeleteMultiple",
                            NormalizedName = "Customer_DeleteMultiple"
                        },
                        new
                        {
                            Id = "a4ed35c4-dcb9-4302-813f-0da9629d855e",
                            ConcurrencyStamp = "4",
                            Name = "Customer_GetAll",
                            NormalizedName = "Customer_GetAll"
                        },
                        new
                        {
                            Id = "3773ce18-b6f6-4063-9c6d-ef47c4fc46c9",
                            ConcurrencyStamp = "4",
                            Name = "Customer_GetById",
                            NormalizedName = "Customer_GetById"
                        },
                        new
                        {
                            Id = "a7eee4af-d93d-4567-94f5-11ed5221aced",
                            ConcurrencyStamp = "4",
                            Name = "UrbanArea_Create",
                            NormalizedName = "UrbanArea_Create"
                        },
                        new
                        {
                            Id = "2fb2bcac-376e-444a-80db-648d734751f3",
                            ConcurrencyStamp = "4",
                            Name = "UrbanArea_Update",
                            NormalizedName = "UrbanArea_Update"
                        },
                        new
                        {
                            Id = "62532d55-6446-43db-8420-b23b7f41772d",
                            ConcurrencyStamp = "4",
                            Name = "UrbanArea_Delete",
                            NormalizedName = "UrbanArea_Delete"
                        },
                        new
                        {
                            Id = "f63d8da6-a70c-4a02-ad57-3166d45f3fa1",
                            ConcurrencyStamp = "4",
                            Name = "UrbanArea_DeleteMultiple",
                            NormalizedName = "UrbanArea_DeleteMultiple"
                        },
                        new
                        {
                            Id = "c9fcc583-2120-4750-bddc-f5c7afad6cb8",
                            ConcurrencyStamp = "4",
                            Name = "UrbanArea_GetAll",
                            NormalizedName = "UrbanArea_GetAll"
                        },
                        new
                        {
                            Id = "6fa817a6-165a-4324-928f-51d47b3ade76",
                            ConcurrencyStamp = "4",
                            Name = "UrbanArea_GetById",
                            NormalizedName = "UrbanArea_GetById"
                        },
                        new
                        {
                            Id = "4250a940-1931-4f69-ba41-b34705e3b4fd",
                            ConcurrencyStamp = "4",
                            Name = "BuildingCategorie_Create",
                            NormalizedName = "BuildingCategorie_Create"
                        },
                        new
                        {
                            Id = "2806e756-20ff-474d-8772-e301dffae0f7",
                            ConcurrencyStamp = "4",
                            Name = "BuildingCategorie_Update",
                            NormalizedName = "BuildingCategorie_Update"
                        },
                        new
                        {
                            Id = "985d8a20-c434-446e-ac10-db5b413df5ec",
                            ConcurrencyStamp = "4",
                            Name = "BuildingCategorie_Delete",
                            NormalizedName = "BuildingCategorie_Delete"
                        },
                        new
                        {
                            Id = "1ca46a57-d6f2-49fe-abea-74cdc1fba1f0",
                            ConcurrencyStamp = "4",
                            Name = "BuildingCategorie_DeleteMultiple",
                            NormalizedName = "BuildingCategorie_DeleteMultiple"
                        },
                        new
                        {
                            Id = "e73ac0b3-c3cf-408c-b77e-50cf3791d012",
                            ConcurrencyStamp = "4",
                            Name = "BuildingCategorie_GetAll",
                            NormalizedName = "BuildingCategorie_GetAll"
                        },
                        new
                        {
                            Id = "0432b207-ad54-4bde-9448-19a0b766181b",
                            ConcurrencyStamp = "4",
                            Name = "BuildingCategorie_GetById",
                            NormalizedName = "BuildingCategorie_GetById"
                        },
                        new
                        {
                            Id = "80142f60-8c4c-4952-a832-133923fefe58",
                            ConcurrencyStamp = "4",
                            Name = "Addresse_Create",
                            NormalizedName = "Addresse_Create"
                        },
                        new
                        {
                            Id = "f6cfe93f-f930-4f3c-a04e-298457447b3d",
                            ConcurrencyStamp = "4",
                            Name = "Addresse_Update",
                            NormalizedName = "Addresse_Update"
                        },
                        new
                        {
                            Id = "5c2714b5-3af7-4978-a518-1e04afbf180a",
                            ConcurrencyStamp = "4",
                            Name = "Addresse_Delete",
                            NormalizedName = "Addresse_Delete"
                        },
                        new
                        {
                            Id = "7545a2d0-8d22-4c4f-8b3c-bfea01292aa8",
                            ConcurrencyStamp = "4",
                            Name = "Addresse_DeleteMultiple",
                            NormalizedName = "Addresse_DeleteMultiple"
                        },
                        new
                        {
                            Id = "b5ea3ebf-3f5c-4278-ba0f-bb6f02a1d085",
                            ConcurrencyStamp = "4",
                            Name = "Addresse_GetAll",
                            NormalizedName = "Addresse_GetAll"
                        },
                        new
                        {
                            Id = "dbd3c5a5-96c5-48ac-be57-7e5565a10f95",
                            ConcurrencyStamp = "4",
                            Name = "Addresse_GetById",
                            NormalizedName = "Addresse_GetById"
                        },
                        new
                        {
                            Id = "0060302a-67bd-4a03-a4c4-9d2e7799af41",
                            ConcurrencyStamp = "4",
                            Name = "Admin",
                            NormalizedName = "Admin"
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
