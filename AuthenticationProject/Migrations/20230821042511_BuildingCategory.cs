using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AuthenticationProject.Migrations
{
    /// <inheritdoc />
    public partial class BuildingCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BuildingCategories_Addresses_AddressId1",
                table: "BuildingCategories");

            migrationBuilder.DropIndex(
                name: "IX_BuildingCategories_AddressId1",
                table: "BuildingCategories");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08992fdf-76f5-4d89-9b60-7c51d65a86d9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09d7d942-38ca-43d7-a869-0bacb90f9fe3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c2d23e8-1f98-4f36-bbeb-e8e723717959");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12cdbe37-5d1d-4570-b7ee-e8fa8c256029");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "15a6e104-e42d-46aa-b1cf-6f00660e7b62");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "233a774f-648c-4f55-b77f-fa44082f3f08");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "25e956f6-75d6-4bf3-a637-8754d2d8d71e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3dd5c60c-21c4-4167-91b5-04415a44cd36");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4048934e-f5f1-4c71-a208-4f8d094e96c3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "49d7e621-f9e3-4c59-ae93-9c0c63c479ef");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f27a722-62fb-4f8e-8506-3d2703333c7b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f3d33d3-add9-43ab-a257-7b31427550c6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "54c3483d-a5d4-49f0-8ddc-cae77b09a4ea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ac89a8c-e6c5-4bb5-bb22-4f472802b753");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c54407d-9e6a-4e3d-a250-f3846ada59bf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6306d233-46f1-4663-97ab-5ba018ca0e8d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67a43273-3b39-4d86-abfd-b237a4ef3905");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68a6aed6-20c9-4499-967d-65d30fc9645e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6a43a2f8-ea2b-4602-a228-ecd08bc84c07");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6d8cff4e-b32f-4542-9100-600fc4ab8677");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e8fa062-43c4-40e8-ade1-b1aa05e5b7af");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6eba6fd6-b761-4470-8bea-de6860af8d40");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "736ee447-2973-4a10-aba8-e2e58986ae6b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a63b2db-8cd6-4a36-b226-e74ae82c296f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "85c6dec7-0ea3-43a8-8fee-d104ca24a6ea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "877a6cff-9e8e-4184-87ce-0df5a64b38c3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "896af9ff-7aef-4473-be6e-9df02fe57158");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89eef294-4f2b-4489-94d2-69a79653c5de");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ba8cb23-58c3-42da-bc90-2b0ebdf72151");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8c5bcfe6-3a59-4ed5-80fe-ae555977b8f2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ff374e5-4e65-41d0-aeef-25c7d197fc8d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e2d2cb5-3c0e-4e7b-9897-62096cf30968");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b01a77a7-f842-4ab8-b782-6126c676c3b7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b159128f-0354-4530-9c0a-c09170445de2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1de0c0a-ce52-4905-9517-891d44cd293d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2606622-ac4b-458a-a84c-48f57b612b1b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b79e64cf-b231-4852-b01f-a61689ea1e20");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb109f0b-9807-4dfe-af1b-0d629e2f6c37");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc090446-355d-4132-9dc9-65a023c213b8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf1b5c0a-a56f-47ad-84a6-1cc6f3d1c6b7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d22f0049-117d-465f-b26f-9ec8cf026e7c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d2f643a0-201a-4339-af5a-7410d349b909");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d345d9b7-c07f-41ae-a9f0-6a641f40622f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d41e3a11-794f-461a-8e52-672536f5e7fb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea676f75-d55b-4988-9b44-4dd7a1fa1622");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef1ba0ef-7250-4f1b-963a-4df67b2e3302");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f516b86b-f206-45af-acb4-d169f9fcec93");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "feae7f24-eaec-41cc-b6d3-007f059e33cc");

            migrationBuilder.DropColumn(
                name: "AddressId1",
                table: "BuildingCategories");

            migrationBuilder.AlterColumn<int>(
                name: "AddressId",
                table: "BuildingCategories",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0d141dca-7380-4ad4-a7fd-b0d38c5e6041", "4", "User_Update", "User_Update" },
                    { "0de72702-a55a-4c41-bb51-16a91a36b8e2", "4", "UrbanArea_DeleteMultiple", "UrbanArea_DeleteMultiple" },
                    { "10f7d383-e6ea-49fc-ae53-3e4116920491", "4", "User_GetAll", "User_GetAll" },
                    { "158e6717-bede-40ae-828a-8677b02e56a8", "4", "Permission_Delete", "Permission_Delete" },
                    { "190c47ec-e5e9-45b9-a7d7-ef941816919d", "4", "Customer_DeleteMultiple", "Customer_DeleteMultiple" },
                    { "1c4c8c8f-ff78-4653-a2af-93b45599bc1f", "4", "Customer_Update", "Customer_Update" },
                    { "2147b67b-810a-4c7c-9091-f7c195f80e44", "4", "BuildingCategorie_DeleteMultiple", "BuildingCategorie_DeleteMultiple" },
                    { "273d0cab-6071-42dd-bcac-421b9253dd19", "4", "BuildingCategorie_Create", "BuildingCategorie_Create" },
                    { "2ec8154d-ee85-4a69-a0c4-388d7895a7fe", "4", "UrbanArea_Update", "UrbanArea_Update" },
                    { "2f678588-bdf1-414c-82b6-38b707727ea2", "4", "Apartment_GetAll", "Apartment_GetAll" },
                    { "32a682dc-a7c0-4369-a683-63e70ed04fa1", "4", "Resident_Delete", "Resident_Delete" },
                    { "349163c3-c330-4137-8ebb-528efd0881d0", "4", "Permission_DeleteMultiple", "Permission_DeleteMultiple" },
                    { "37e00be4-64c9-44da-98aa-50613fc73933", "4", "Apartment_DeleteMultiple", "Apartment_DeleteMultiple" },
                    { "39311dce-73bb-458c-86f3-54df0538f307", "4", "Addresse_Create", "Addresse_Create" },
                    { "3e59369e-978b-4c6c-b2c4-75ed5ef0afbb", "4", "Customer_GetById", "Customer_GetById" },
                    { "43902d8d-2d5a-4d37-87c7-d2a1788d258b", "4", "Apartment_Update", "Apartment_Update" },
                    { "4ca1121d-1c07-4018-9f8f-e08756b671da", "4", "UrbanArea_GetById", "UrbanArea_GetById" },
                    { "4ed5fac0-db04-4740-a070-a2cce4cb62de", "4", "Resident_Create", "Resident_Create" },
                    { "53b4e585-5698-4863-a92f-51c82e96074b", "4", "Permission_Create", "Permission_Create" },
                    { "590396e9-e3e2-475d-855a-5cb9be328b6a", "4", "Permission_GetAll", "Permission_GetAll" },
                    { "5968b0a3-929e-4a3f-b6c2-a34d0ac2cd34", "4", "Addresse_Delete", "Addresse_Delete" },
                    { "5b693ea2-8a77-4b70-9350-5b0d03d20b8d", "4", "Permission_Update", "Permission_Update" },
                    { "5bc1f64f-6b72-4e20-bb88-5be08549d4a5", "4", "UrbanArea_GetAll", "UrbanArea_GetAll" },
                    { "654fb25b-9562-4b37-9cf1-af5111e5ce6e", "4", "Addresse_Update", "Addresse_Update" },
                    { "6fad30c2-7f31-4e22-9eaf-b206be70b984", "4", "BuildingCategorie_GetById", "BuildingCategorie_GetById" },
                    { "776a1b5e-9cd3-4837-b752-2936d1819dab", "4", "Resident_GetAll", "Resident_GetAll" },
                    { "7adcd543-437b-4a4f-a5d4-b8ec3808ed4a", "4", "Customer_GetAll", "Customer_GetAll" },
                    { "7ae8d129-cd9c-44fa-b98f-c5527431bcdf", "4", "UrbanArea_Delete", "UrbanArea_Delete" },
                    { "84a1d6a5-749b-4bfb-b3f2-fd12b98b3dba", "4", "User_Create", "User_Create" },
                    { "87cfd94d-528f-4b74-b705-d3d1bf756d70", "4", "Apartment_Create", "Apartment_Create" },
                    { "908a52e9-5758-4aa6-82a3-3978daaefe37", "4", "Addresse_GetById", "Addresse_GetById" },
                    { "91fe8adf-ab93-4e3e-a11a-93a60893fe9d", "4", "Resident_GetById", "Resident_GetById" },
                    { "93eae0b3-0917-4543-89ed-206390ad23ca", "4", "Resident_DeleteMultiple", "Resident_DeleteMultiple" },
                    { "a31eb321-a476-4f75-8856-dd99a0037b3d", "4", "Permission_GetById", "Permission_GetById" },
                    { "b4bf4eb3-5c82-446c-b97c-388879605935", "4", "BuildingCategorie_Delete", "BuildingCategorie_Delete" },
                    { "b86944e2-5347-4a05-9e8a-74473474e8f6", "4", "User_GetById", "User_GetById" },
                    { "ba933c4e-3b42-4581-ae28-f212ddb2ff74", "4", "Addresse_GetAll", "Addresse_GetAll" },
                    { "d48f040f-307b-4e97-8697-f14904efddc6", "4", "Apartment_Delete", "Apartment_Delete" },
                    { "dcf04dfb-b0bd-475b-be08-34f347ae11d6", "4", "Resident_Update", "Resident_Update" },
                    { "e29981d5-ce02-4342-81d4-b022b3ce00b4", "4", "UrbanArea_Create", "UrbanArea_Create" },
                    { "e494de48-9366-4bc0-9374-f97b37a58321", "4", "User_DeleteMultiple", "User_DeleteMultiple" },
                    { "e5509a42-f5f8-4f30-95ec-77dd633346fd", "4", "User_Delete", "User_Delete" },
                    { "e81e427f-8abf-4d68-b6d3-7dc34cff39bc", "4", "BuildingCategorie_Update", "BuildingCategorie_Update" },
                    { "ee0dd263-8c99-46b3-a3a2-35d52f98e208", "4", "BuildingCategorie_GetAll", "BuildingCategorie_GetAll" },
                    { "ee4419a5-cf77-4b2a-863f-fc5e419c2e11", "4", "Customer_Delete", "Customer_Delete" },
                    { "f4e7001f-924c-4cdf-b829-a951707afd8c", "4", "Customer_Create", "Customer_Create" },
                    { "f62e7e78-680b-42a1-bc51-3942bf0fdd6f", "4", "Addresse_DeleteMultiple", "Addresse_DeleteMultiple" },
                    { "fb52cc00-4c15-4f0c-a50e-2872f73ecc61", "4", "Apartment_GetById", "Apartment_GetById" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BuildingCategories_AddressId",
                table: "BuildingCategories",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingCategories_Addresses_AddressId",
                table: "BuildingCategories",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BuildingCategories_Addresses_AddressId",
                table: "BuildingCategories");

            migrationBuilder.DropIndex(
                name: "IX_BuildingCategories_AddressId",
                table: "BuildingCategories");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d141dca-7380-4ad4-a7fd-b0d38c5e6041");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0de72702-a55a-4c41-bb51-16a91a36b8e2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10f7d383-e6ea-49fc-ae53-3e4116920491");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "158e6717-bede-40ae-828a-8677b02e56a8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "190c47ec-e5e9-45b9-a7d7-ef941816919d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c4c8c8f-ff78-4653-a2af-93b45599bc1f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2147b67b-810a-4c7c-9091-f7c195f80e44");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "273d0cab-6071-42dd-bcac-421b9253dd19");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2ec8154d-ee85-4a69-a0c4-388d7895a7fe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f678588-bdf1-414c-82b6-38b707727ea2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32a682dc-a7c0-4369-a683-63e70ed04fa1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "349163c3-c330-4137-8ebb-528efd0881d0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37e00be4-64c9-44da-98aa-50613fc73933");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "39311dce-73bb-458c-86f3-54df0538f307");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e59369e-978b-4c6c-b2c4-75ed5ef0afbb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43902d8d-2d5a-4d37-87c7-d2a1788d258b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ca1121d-1c07-4018-9f8f-e08756b671da");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ed5fac0-db04-4740-a070-a2cce4cb62de");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53b4e585-5698-4863-a92f-51c82e96074b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "590396e9-e3e2-475d-855a-5cb9be328b6a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5968b0a3-929e-4a3f-b6c2-a34d0ac2cd34");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b693ea2-8a77-4b70-9350-5b0d03d20b8d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5bc1f64f-6b72-4e20-bb88-5be08549d4a5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "654fb25b-9562-4b37-9cf1-af5111e5ce6e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6fad30c2-7f31-4e22-9eaf-b206be70b984");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "776a1b5e-9cd3-4837-b752-2936d1819dab");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7adcd543-437b-4a4f-a5d4-b8ec3808ed4a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7ae8d129-cd9c-44fa-b98f-c5527431bcdf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84a1d6a5-749b-4bfb-b3f2-fd12b98b3dba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87cfd94d-528f-4b74-b705-d3d1bf756d70");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "908a52e9-5758-4aa6-82a3-3978daaefe37");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91fe8adf-ab93-4e3e-a11a-93a60893fe9d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93eae0b3-0917-4543-89ed-206390ad23ca");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a31eb321-a476-4f75-8856-dd99a0037b3d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4bf4eb3-5c82-446c-b97c-388879605935");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b86944e2-5347-4a05-9e8a-74473474e8f6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba933c4e-3b42-4581-ae28-f212ddb2ff74");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d48f040f-307b-4e97-8697-f14904efddc6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dcf04dfb-b0bd-475b-be08-34f347ae11d6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e29981d5-ce02-4342-81d4-b022b3ce00b4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e494de48-9366-4bc0-9374-f97b37a58321");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5509a42-f5f8-4f30-95ec-77dd633346fd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e81e427f-8abf-4d68-b6d3-7dc34cff39bc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee0dd263-8c99-46b3-a3a2-35d52f98e208");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee4419a5-cf77-4b2a-863f-fc5e419c2e11");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4e7001f-924c-4cdf-b829-a951707afd8c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f62e7e78-680b-42a1-bc51-3942bf0fdd6f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb52cc00-4c15-4f0c-a50e-2872f73ecc61");

            migrationBuilder.AlterColumn<long>(
                name: "AddressId",
                table: "BuildingCategories",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "AddressId1",
                table: "BuildingCategories",
                type: "int",
                nullable: true);

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
                name: "IX_BuildingCategories_AddressId1",
                table: "BuildingCategories",
                column: "AddressId1");

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingCategories_Addresses_AddressId1",
                table: "BuildingCategories",
                column: "AddressId1",
                principalTable: "Addresses",
                principalColumn: "AddressId");
        }
    }
}
