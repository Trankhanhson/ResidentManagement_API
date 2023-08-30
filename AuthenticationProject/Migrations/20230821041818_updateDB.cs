using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AuthenticationProject.Migrations
{
    /// <inheritdoc />
    public partial class updateDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Makhachhang = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tenkhachhang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cccd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ngaycap = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Hinhanh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sodienthoai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diachi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Makhachhang);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    PermissionId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.PermissionId);
                });

            migrationBuilder.CreateTable(
                name: "Resident",
                columns: table => new
                {
                    ResidentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cccd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Gender = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resident", x => x.ResidentId);
                });

            migrationBuilder.CreateTable(
                name: "UrbanAreas",
                columns: table => new
                {
                    UrbanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrbanName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Population = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrbanAreas", x => x.UrbanId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PermissionRoles",
                columns: table => new
                {
                    PermissionRoleId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PermissionId = table.Column<long>(type: "bigint", nullable: true),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissionRoles", x => x.PermissionRoleId);
                    table.ForeignKey(
                        name: "FK_PermissionRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PermissionRoles_Permissions_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permissions",
                        principalColumn: "PermissionId");
                });

            migrationBuilder.CreateTable(
                name: "PermissionUsers",
                columns: table => new
                {
                    PermissionUserId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PermissionId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissionUsers", x => x.PermissionUserId);
                    table.ForeignKey(
                        name: "FK_PermissionUsers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PermissionUsers_Permissions_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permissions",
                        principalColumn: "PermissionId");
                });

            migrationBuilder.CreateTable(
                name: "BuildingCategories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrbanId = table.Column<int>(type: "int", nullable: false),
                    AddressId = table.Column<long>(type: "bigint", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrbanAreaUrbanId = table.Column<int>(type: "int", nullable: true),
                    AddressId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingCategories", x => x.CategoryId);
                    table.ForeignKey(
                        name: "FK_BuildingCategories_Addresses_AddressId1",
                        column: x => x.AddressId1,
                        principalTable: "Addresses",
                        principalColumn: "AddressId");
                    table.ForeignKey(
                        name: "FK_BuildingCategories_UrbanAreas_UrbanAreaUrbanId",
                        column: x => x.UrbanAreaUrbanId,
                        principalTable: "UrbanAreas",
                        principalColumn: "UrbanId");
                });

            migrationBuilder.CreateTable(
                name: "Apartments",
                columns: table => new
                {
                    ApartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ApartmentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Building = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Space = table.Column<int>(type: "int", nullable: true),
                    Floor = table.Column<int>(type: "int", nullable: true),
                    BuildingCategoryCategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartments", x => x.ApartmentId);
                    table.ForeignKey(
                        name: "FK_Apartments_BuildingCategories_BuildingCategoryCategoryId",
                        column: x => x.BuildingCategoryCategoryId,
                        principalTable: "BuildingCategories",
                        principalColumn: "CategoryId");
                });

            migrationBuilder.CreateTable(
                name: "ResidentApartment",
                columns: table => new
                {
                    ResidentApartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApartmentId = table.Column<int>(type: "int", nullable: true),
                    ResidentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResidentApartment", x => x.ResidentApartmentId);
                    table.ForeignKey(
                        name: "FK_ResidentApartment_Apartments_ApartmentId",
                        column: x => x.ApartmentId,
                        principalTable: "Apartments",
                        principalColumn: "ApartmentId");
                    table.ForeignKey(
                        name: "FK_ResidentApartment_Resident_ResidentId",
                        column: x => x.ResidentId,
                        principalTable: "Resident",
                        principalColumn: "ResidentId");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "08992fdf-76f5-4d89-9b60-7c51d65a86d9", "4", "BuildingCategorie_DeleteMultiple", "BuildingCategorie_DeleteMultiple" },
                    { "09d7d942-38ca-43d7-a869-0bacb90f9fe3", "4", "User_Create", "User_Create" },
                    { "0c2d23e8-1f98-4f36-bbeb-e8e723717959", "4", "Apartment_Delete", "Apartment_Delete" },
                    { "12cdbe37-5d1d-4570-b7ee-e8fa8c256029", "4", "Addresse_Update", "Addresse_Update" },
                    { "15a6e104-e42d-46aa-b1cf-6f00660e7b62", "4", "UrbanArea_GetById", "UrbanArea_GetById" },
                    { "233a774f-648c-4f55-b77f-fa44082f3f08", "4", "Customer_DeleteMultiple", "Customer_DeleteMultiple" },
                    { "25e956f6-75d6-4bf3-a637-8754d2d8d71e", "4", "Resident_GetAll", "Resident_GetAll" },
                    { "3dd5c60c-21c4-4167-91b5-04415a44cd36", "4", "Apartment_Update", "Apartment_Update" },
                    { "4048934e-f5f1-4c71-a208-4f8d094e96c3", "4", "Customer_Update", "Customer_Update" },
                    { "49d7e621-f9e3-4c59-ae93-9c0c63c479ef", "4", "Resident_DeleteMultiple", "Resident_DeleteMultiple" },
                    { "4f27a722-62fb-4f8e-8506-3d2703333c7b", "4", "Resident_Update", "Resident_Update" },
                    { "4f3d33d3-add9-43ab-a257-7b31427550c6", "4", "Customer_Create", "Customer_Create" },
                    { "54c3483d-a5d4-49f0-8ddc-cae77b09a4ea", "4", "User_DeleteMultiple", "User_DeleteMultiple" },
                    { "5ac89a8c-e6c5-4bb5-bb22-4f472802b753", "4", "UrbanArea_DeleteMultiple", "UrbanArea_DeleteMultiple" },
                    { "5c54407d-9e6a-4e3d-a250-f3846ada59bf", "4", "UrbanArea_Create", "UrbanArea_Create" },
                    { "6306d233-46f1-4663-97ab-5ba018ca0e8d", "4", "BuildingCategorie_Create", "BuildingCategorie_Create" },
                    { "67a43273-3b39-4d86-abfd-b237a4ef3905", "4", "Addresse_GetById", "Addresse_GetById" },
                    { "68a6aed6-20c9-4499-967d-65d30fc9645e", "4", "Permission_GetById", "Permission_GetById" },
                    { "6a43a2f8-ea2b-4602-a228-ecd08bc84c07", "4", "BuildingCategorie_GetById", "BuildingCategorie_GetById" },
                    { "6d8cff4e-b32f-4542-9100-600fc4ab8677", "4", "BuildingCategorie_Delete", "BuildingCategorie_Delete" },
                    { "6e8fa062-43c4-40e8-ade1-b1aa05e5b7af", "4", "Resident_GetById", "Resident_GetById" },
                    { "6eba6fd6-b761-4470-8bea-de6860af8d40", "4", "Permission_Create", "Permission_Create" },
                    { "736ee447-2973-4a10-aba8-e2e58986ae6b", "4", "Permission_GetAll", "Permission_GetAll" },
                    { "7a63b2db-8cd6-4a36-b226-e74ae82c296f", "4", "Customer_Delete", "Customer_Delete" },
                    { "85c6dec7-0ea3-43a8-8fee-d104ca24a6ea", "4", "Permission_DeleteMultiple", "Permission_DeleteMultiple" },
                    { "877a6cff-9e8e-4184-87ce-0df5a64b38c3", "4", "BuildingCategorie_Update", "BuildingCategorie_Update" },
                    { "896af9ff-7aef-4473-be6e-9df02fe57158", "4", "UrbanArea_Delete", "UrbanArea_Delete" },
                    { "89eef294-4f2b-4489-94d2-69a79653c5de", "4", "User_GetAll", "User_GetAll" },
                    { "8ba8cb23-58c3-42da-bc90-2b0ebdf72151", "4", "User_GetById", "User_GetById" },
                    { "8c5bcfe6-3a59-4ed5-80fe-ae555977b8f2", "4", "UrbanArea_GetAll", "UrbanArea_GetAll" },
                    { "8ff374e5-4e65-41d0-aeef-25c7d197fc8d", "4", "Addresse_Create", "Addresse_Create" },
                    { "9e2d2cb5-3c0e-4e7b-9897-62096cf30968", "4", "Permission_Update", "Permission_Update" },
                    { "b01a77a7-f842-4ab8-b782-6126c676c3b7", "4", "Apartment_Create", "Apartment_Create" },
                    { "b159128f-0354-4530-9c0a-c09170445de2", "4", "User_Delete", "User_Delete" },
                    { "b1de0c0a-ce52-4905-9517-891d44cd293d", "4", "UrbanArea_Update", "UrbanArea_Update" },
                    { "b2606622-ac4b-458a-a84c-48f57b612b1b", "4", "Resident_Delete", "Resident_Delete" },
                    { "b79e64cf-b231-4852-b01f-a61689ea1e20", "4", "Customer_GetById", "Customer_GetById" },
                    { "bb109f0b-9807-4dfe-af1b-0d629e2f6c37", "4", "Addresse_Delete", "Addresse_Delete" },
                    { "bc090446-355d-4132-9dc9-65a023c213b8", "4", "Resident_Create", "Resident_Create" },
                    { "bf1b5c0a-a56f-47ad-84a6-1cc6f3d1c6b7", "4", "Customer_GetAll", "Customer_GetAll" },
                    { "d22f0049-117d-465f-b26f-9ec8cf026e7c", "4", "BuildingCategorie_GetAll", "BuildingCategorie_GetAll" },
                    { "d2f643a0-201a-4339-af5a-7410d349b909", "4", "Apartment_GetById", "Apartment_GetById" },
                    { "d345d9b7-c07f-41ae-a9f0-6a641f40622f", "4", "Apartment_DeleteMultiple", "Apartment_DeleteMultiple" },
                    { "d41e3a11-794f-461a-8e52-672536f5e7fb", "4", "Addresse_DeleteMultiple", "Addresse_DeleteMultiple" },
                    { "ea676f75-d55b-4988-9b44-4dd7a1fa1622", "4", "Addresse_GetAll", "Addresse_GetAll" },
                    { "ef1ba0ef-7250-4f1b-963a-4df67b2e3302", "4", "Apartment_GetAll", "Apartment_GetAll" },
                    { "f516b86b-f206-45af-acb4-d169f9fcec93", "4", "User_Update", "User_Update" },
                    { "feae7f24-eaec-41cc-b6d3-007f059e33cc", "4", "Permission_Delete", "Permission_Delete" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_BuildingCategoryCategoryId",
                table: "Apartments",
                column: "BuildingCategoryCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingCategories_AddressId1",
                table: "BuildingCategories",
                column: "AddressId1");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingCategories_UrbanAreaUrbanId",
                table: "BuildingCategories",
                column: "UrbanAreaUrbanId");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionRoles_PermissionId",
                table: "PermissionRoles",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionRoles_RoleId",
                table: "PermissionRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionUsers_PermissionId",
                table: "PermissionUsers",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionUsers_UserId",
                table: "PermissionUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ResidentApartment_ApartmentId",
                table: "ResidentApartment",
                column: "ApartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ResidentApartment_ResidentId",
                table: "ResidentApartment",
                column: "ResidentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "PermissionRoles");

            migrationBuilder.DropTable(
                name: "PermissionUsers");

            migrationBuilder.DropTable(
                name: "ResidentApartment");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "Apartments");

            migrationBuilder.DropTable(
                name: "Resident");

            migrationBuilder.DropTable(
                name: "BuildingCategories");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "UrbanAreas");
        }
    }
}
