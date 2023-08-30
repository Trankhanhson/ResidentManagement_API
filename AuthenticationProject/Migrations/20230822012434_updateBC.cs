using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AuthenticationProject.Migrations
{
    /// <inheritdoc />
    public partial class updateBC : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BuildingCategories_UrbanAreas_UrbanAreaUrbanId",
                table: "BuildingCategories");

            migrationBuilder.DropIndex(
                name: "IX_BuildingCategories_UrbanAreaUrbanId",
                table: "BuildingCategories");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "085c3bee-aa54-402b-bbb8-b0afaaf73821");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f8bf8a4-5ee2-4c68-be6b-41b323919afa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "126cc3cc-3c92-4565-a4e8-3bb03daa6d23");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13428b7a-60e2-480a-a410-7915de122af9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "14f3edf3-9367-43ef-a9d5-026be4186c06");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16550ca3-5bc3-40a9-9405-f4fd46d6eddf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1784d2d0-d02d-499b-b2bd-2aee9699e9e9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d5fbbda-66cb-4a73-9a3b-4a4dab2e2731");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "232bfbec-8ebb-45f7-ae99-f6af5519fd91");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b835c4a-621a-4124-8e42-99fb7bd33efa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2de22149-bd4e-4718-ac7a-da86aa158aac");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e459ebd-83c8-4acd-b189-c24cb666f77f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2ff16b90-1e2c-402a-852f-6faea2643b99");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "30be87d5-cf9b-41cf-98b9-53ff7ad95798");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31b0a30a-56d9-4a56-a489-f77c3af95d2a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "34ca1629-6ceb-4920-bf70-de3e19a70518");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d284f4d-87eb-4848-8e86-3f0cdd1aaf5a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d4ed85f-76c2-4fcf-a096-a4d92977865a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4643503f-43e0-47f8-baec-e56dd760624d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "494ab336-096d-4cce-9339-6068bfb57fe2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "575b74ea-1a25-4a9a-ba6f-0639c903590e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5da222c1-6944-49f0-a9ed-de13fe05eae5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "621344a9-d10e-44e6-9a1a-c0115c9fc249");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6cd2d88b-7b13-49b5-b912-4592384d26bc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "748dacff-0ac4-4d6f-98fc-46ae843dc6f7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "79d6d719-629f-4ff1-bf89-15c0b1f9de61");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81c9c002-44c5-419b-8e5a-f4ba7e786edc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b58af50-11cd-4dfd-b566-1ddb0bf6f893");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93c73660-7e57-4614-99e6-1ec8923b3c1d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "97873acf-dfd8-498b-be6f-ee738e35972b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ab7a4aa-2a06-433a-b9ed-ee5eb00689f1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9888cfc-4e8f-4bd7-8532-abe5005f5e5b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b5b2b89b-73af-4855-8af7-b56c375668ec");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd064553-2d31-4e8c-91b3-d374517f7d87");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "befa0e07-ff87-4260-8e9d-7d3d361c80c4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c1b7b1c4-574a-43e7-9d44-24df4a6d6258");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c831cf13-1441-4894-877b-bc6385f39aea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d979562d-557e-4ae6-b98f-4469fdafaf89");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e27a2d8b-edc9-4d46-8169-7ecb8dc7a18f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2914001-8c15-4eae-af06-1b2b0b91cf9d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5b1f53c-b267-4ade-b6e4-71e0b32c0bcd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e7d0f281-baaa-4245-b27a-da41ae1dbe3a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "efc82805-fc30-48c1-a720-5a4b6d128bdc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "efd88de2-4db2-4e34-b8c3-133dae667867");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f584ccd2-05c7-455b-8fe2-2ea1e7f91809");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7844037-00dc-4417-ab26-a144eb82bdce");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f8eab6e3-c054-4f67-af49-d497d883a05e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fbce72ed-d485-4cc0-9ab4-6683db048c4c");

            migrationBuilder.DropColumn(
                name: "UrbanAreaUrbanId",
                table: "BuildingCategories");

            migrationBuilder.DropColumn(
                name: "UrbanId",
                table: "BuildingCategories");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "03c13cd6-8f3f-4bd8-84d4-bf3e8b8f32b0", "4", "Customer_Delete", "Customer_Delete" },
                    { "04f1ba2f-4389-4b2c-bf90-c6da74e48c88", "4", "Apartment_GetById", "Apartment_GetById" },
                    { "071971c9-0f7e-46f7-84c4-1da4bb4dbd91", "4", "Apartment_DeleteMultiple", "Apartment_DeleteMultiple" },
                    { "159d4c47-ec30-4907-959a-d7def1372773", "4", "UrbanArea_Create", "UrbanArea_Create" },
                    { "16034e4e-685c-4f40-9f01-ddc06d245904", "4", "Addresse_Update", "Addresse_Update" },
                    { "19d45667-c182-4da8-8220-cf8e3f85f8f0", "4", "Addresse_Delete", "Addresse_Delete" },
                    { "1a477cfa-e3c7-4c73-b8c5-9d187c9f240b", "4", "BuildingCategorie_Update", "BuildingCategorie_Update" },
                    { "2277733f-dfa5-43e9-8f2a-23175532840f", "4", "Addresse_GetById", "Addresse_GetById" },
                    { "23e3cb31-195b-493e-b519-19e8670a1c91", "4", "Customer_Create", "Customer_Create" },
                    { "25009734-3094-48c4-8150-aa279d38a954", "4", "BuildingCategorie_GetById", "BuildingCategorie_GetById" },
                    { "27bb037f-6666-4026-940f-93f55c46628e", "4", "Permission_Delete", "Permission_Delete" },
                    { "307b977b-cd18-48a8-8b89-fa2fc88c77a0", "4", "UrbanArea_Update", "UrbanArea_Update" },
                    { "321b29f8-91cb-4194-8a11-1406374594c0", "4", "BuildingCategorie_Delete", "BuildingCategorie_Delete" },
                    { "3395a21b-3fc6-4c1e-9f09-d244adc0e551", "4", "User_GetAll", "User_GetAll" },
                    { "364b8e17-79b1-4fb4-984b-9dcdda185c03", "4", "Permission_Create", "Permission_Create" },
                    { "39f202d1-e442-46fe-a85e-57b807dc162c", "4", "BuildingCategorie_DeleteMultiple", "BuildingCategorie_DeleteMultiple" },
                    { "48ed395a-f7ca-4cd4-a23a-d1b6862d4543", "4", "Apartment_Delete", "Apartment_Delete" },
                    { "4c61f6d7-a9fa-43c7-92a2-5075ed5e87f6", "4", "User_Update", "User_Update" },
                    { "4c798523-7c4e-414f-9f91-680ce627089f", "4", "Resident_Update", "Resident_Update" },
                    { "53991596-ba24-44a3-977c-a44fbb48329b", "4", "Resident_DeleteMultiple", "Resident_DeleteMultiple" },
                    { "53eb949b-da10-48fb-94c9-8c12b1f19f8b", "4", "Customer_DeleteMultiple", "Customer_DeleteMultiple" },
                    { "70344895-5be0-44d8-95d2-153c4d44fcc2", "4", "Apartment_Update", "Apartment_Update" },
                    { "7aebfa1f-f954-46e0-9da7-fe12a350e5f8", "4", "Customer_GetAll", "Customer_GetAll" },
                    { "7e6a81a8-d9ec-4306-aeea-ad498f64877b", "4", "Addresse_DeleteMultiple", "Addresse_DeleteMultiple" },
                    { "8091ee12-1cc5-4149-b07f-03fe3b7e6bb4", "4", "Permission_DeleteMultiple", "Permission_DeleteMultiple" },
                    { "80a6dfef-943c-42fb-a4f1-3443cfd0a59a", "4", "Resident_Delete", "Resident_Delete" },
                    { "92e6ac55-21aa-4d49-86b0-9a96781667e5", "4", "Resident_GetAll", "Resident_GetAll" },
                    { "93b811e0-c65d-4c83-b5f9-6cb43303cee3", "4", "UrbanArea_Delete", "UrbanArea_Delete" },
                    { "9bd08204-4bef-47fd-9ed0-77250fad0846", "4", "User_DeleteMultiple", "User_DeleteMultiple" },
                    { "9c2f94a8-4650-4a5a-ab0c-3beafc15a4a9", "4", "BuildingCategorie_GetAll", "BuildingCategorie_GetAll" },
                    { "a3e0e643-25f9-4ac7-a863-09dea42c38ff", "4", "Addresse_GetAll", "Addresse_GetAll" },
                    { "a5fc8d20-4bf6-4292-934f-5a96a2351be7", "4", "UrbanArea_GetAll", "UrbanArea_GetAll" },
                    { "a6a270c1-74dd-4a73-a201-a0596aed41b8", "4", "Apartment_GetAll", "Apartment_GetAll" },
                    { "b0c0a3ee-b7a2-4bba-a630-76f3d6ecffbc", "4", "User_Delete", "User_Delete" },
                    { "b50f4742-fc26-4092-8ced-46c5144e06ef", "4", "BuildingCategorie_Create", "BuildingCategorie_Create" },
                    { "b796cc77-edda-48e8-93ad-d47974f18ab2", "4", "Permission_Update", "Permission_Update" },
                    { "b996e3df-4e3f-4900-b353-e9fde3f1e799", "4", "Permission_GetAll", "Permission_GetAll" },
                    { "bd35e4d5-9482-47ad-99af-e52e86724a74", "4", "Customer_GetById", "Customer_GetById" },
                    { "be147070-4bb8-45da-8b15-bbffafa50132", "4", "User_GetById", "User_GetById" },
                    { "be7cbbda-4a16-4cc6-9f13-dd075e5c2e21", "4", "Resident_GetById", "Resident_GetById" },
                    { "c3b0ee53-ab45-450e-8bfb-60953804f16f", "4", "UrbanArea_DeleteMultiple", "UrbanArea_DeleteMultiple" },
                    { "c4bd9a87-553b-49ca-b89c-5e5b9f6447e3", "4", "Customer_Update", "Customer_Update" },
                    { "c978a04a-db72-4d09-9ad3-d196c5710ff1", "4", "Resident_Create", "Resident_Create" },
                    { "cc07a342-479d-4f8e-a555-a332b4596af8", "4", "Addresse_Create", "Addresse_Create" },
                    { "d2f6fc92-5d1b-4dba-b136-39bc95e0bf7c", "4", "UrbanArea_GetById", "UrbanArea_GetById" },
                    { "d7f1c376-7fea-4c67-a054-066c1ffefb53", "4", "Apartment_Create", "Apartment_Create" },
                    { "da2110fc-da2b-49eb-81e6-503ba610757d", "4", "User_Create", "User_Create" },
                    { "e4791c51-afe4-4f20-9c27-1d7fc86ea9f6", "4", "Permission_GetById", "Permission_GetById" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "03c13cd6-8f3f-4bd8-84d4-bf3e8b8f32b0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04f1ba2f-4389-4b2c-bf90-c6da74e48c88");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "071971c9-0f7e-46f7-84c4-1da4bb4dbd91");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "159d4c47-ec30-4907-959a-d7def1372773");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16034e4e-685c-4f40-9f01-ddc06d245904");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19d45667-c182-4da8-8220-cf8e3f85f8f0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a477cfa-e3c7-4c73-b8c5-9d187c9f240b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2277733f-dfa5-43e9-8f2a-23175532840f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "23e3cb31-195b-493e-b519-19e8670a1c91");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "25009734-3094-48c4-8150-aa279d38a954");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "27bb037f-6666-4026-940f-93f55c46628e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "307b977b-cd18-48a8-8b89-fa2fc88c77a0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "321b29f8-91cb-4194-8a11-1406374594c0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3395a21b-3fc6-4c1e-9f09-d244adc0e551");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "364b8e17-79b1-4fb4-984b-9dcdda185c03");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "39f202d1-e442-46fe-a85e-57b807dc162c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48ed395a-f7ca-4cd4-a23a-d1b6862d4543");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c61f6d7-a9fa-43c7-92a2-5075ed5e87f6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c798523-7c4e-414f-9f91-680ce627089f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53991596-ba24-44a3-977c-a44fbb48329b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53eb949b-da10-48fb-94c9-8c12b1f19f8b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70344895-5be0-44d8-95d2-153c4d44fcc2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7aebfa1f-f954-46e0-9da7-fe12a350e5f8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e6a81a8-d9ec-4306-aeea-ad498f64877b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8091ee12-1cc5-4149-b07f-03fe3b7e6bb4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80a6dfef-943c-42fb-a4f1-3443cfd0a59a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "92e6ac55-21aa-4d49-86b0-9a96781667e5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93b811e0-c65d-4c83-b5f9-6cb43303cee3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9bd08204-4bef-47fd-9ed0-77250fad0846");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9c2f94a8-4650-4a5a-ab0c-3beafc15a4a9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a3e0e643-25f9-4ac7-a863-09dea42c38ff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5fc8d20-4bf6-4292-934f-5a96a2351be7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6a270c1-74dd-4a73-a201-a0596aed41b8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0c0a3ee-b7a2-4bba-a630-76f3d6ecffbc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b50f4742-fc26-4092-8ced-46c5144e06ef");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b796cc77-edda-48e8-93ad-d47974f18ab2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b996e3df-4e3f-4900-b353-e9fde3f1e799");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd35e4d5-9482-47ad-99af-e52e86724a74");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be147070-4bb8-45da-8b15-bbffafa50132");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be7cbbda-4a16-4cc6-9f13-dd075e5c2e21");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3b0ee53-ab45-450e-8bfb-60953804f16f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4bd9a87-553b-49ca-b89c-5e5b9f6447e3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c978a04a-db72-4d09-9ad3-d196c5710ff1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc07a342-479d-4f8e-a555-a332b4596af8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d2f6fc92-5d1b-4dba-b136-39bc95e0bf7c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d7f1c376-7fea-4c67-a054-066c1ffefb53");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da2110fc-da2b-49eb-81e6-503ba610757d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4791c51-afe4-4f20-9c27-1d7fc86ea9f6");

            migrationBuilder.AddColumn<int>(
                name: "UrbanAreaUrbanId",
                table: "BuildingCategories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UrbanId",
                table: "BuildingCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "085c3bee-aa54-402b-bbb8-b0afaaf73821", "4", "Permission_Delete", "Permission_Delete" },
                    { "0f8bf8a4-5ee2-4c68-be6b-41b323919afa", "4", "User_GetById", "User_GetById" },
                    { "126cc3cc-3c92-4565-a4e8-3bb03daa6d23", "4", "Addresse_Delete", "Addresse_Delete" },
                    { "13428b7a-60e2-480a-a410-7915de122af9", "4", "BuildingCategorie_Create", "BuildingCategorie_Create" },
                    { "14f3edf3-9367-43ef-a9d5-026be4186c06", "4", "Permission_GetById", "Permission_GetById" },
                    { "16550ca3-5bc3-40a9-9405-f4fd46d6eddf", "4", "Customer_GetAll", "Customer_GetAll" },
                    { "1784d2d0-d02d-499b-b2bd-2aee9699e9e9", "4", "Addresse_GetAll", "Addresse_GetAll" },
                    { "1d5fbbda-66cb-4a73-9a3b-4a4dab2e2731", "4", "Apartment_Delete", "Apartment_Delete" },
                    { "232bfbec-8ebb-45f7-ae99-f6af5519fd91", "4", "Addresse_Update", "Addresse_Update" },
                    { "2b835c4a-621a-4124-8e42-99fb7bd33efa", "4", "UrbanArea_Delete", "UrbanArea_Delete" },
                    { "2de22149-bd4e-4718-ac7a-da86aa158aac", "4", "Permission_Create", "Permission_Create" },
                    { "2e459ebd-83c8-4acd-b189-c24cb666f77f", "4", "Customer_DeleteMultiple", "Customer_DeleteMultiple" },
                    { "2ff16b90-1e2c-402a-852f-6faea2643b99", "4", "Customer_Update", "Customer_Update" },
                    { "30be87d5-cf9b-41cf-98b9-53ff7ad95798", "4", "User_Update", "User_Update" },
                    { "31b0a30a-56d9-4a56-a489-f77c3af95d2a", "4", "UrbanArea_GetAll", "UrbanArea_GetAll" },
                    { "34ca1629-6ceb-4920-bf70-de3e19a70518", "4", "User_Create", "User_Create" },
                    { "3d284f4d-87eb-4848-8e86-3f0cdd1aaf5a", "4", "Permission_Update", "Permission_Update" },
                    { "3d4ed85f-76c2-4fcf-a096-a4d92977865a", "4", "Customer_Create", "Customer_Create" },
                    { "4643503f-43e0-47f8-baec-e56dd760624d", "4", "Addresse_Create", "Addresse_Create" },
                    { "494ab336-096d-4cce-9339-6068bfb57fe2", "4", "Permission_GetAll", "Permission_GetAll" },
                    { "575b74ea-1a25-4a9a-ba6f-0639c903590e", "4", "BuildingCategorie_Delete", "BuildingCategorie_Delete" },
                    { "5da222c1-6944-49f0-a9ed-de13fe05eae5", "4", "UrbanArea_DeleteMultiple", "UrbanArea_DeleteMultiple" },
                    { "621344a9-d10e-44e6-9a1a-c0115c9fc249", "4", "Customer_Delete", "Customer_Delete" },
                    { "6cd2d88b-7b13-49b5-b912-4592384d26bc", "4", "Resident_Update", "Resident_Update" },
                    { "748dacff-0ac4-4d6f-98fc-46ae843dc6f7", "4", "Resident_GetAll", "Resident_GetAll" },
                    { "79d6d719-629f-4ff1-bf89-15c0b1f9de61", "4", "Apartment_GetById", "Apartment_GetById" },
                    { "81c9c002-44c5-419b-8e5a-f4ba7e786edc", "4", "BuildingCategorie_GetById", "BuildingCategorie_GetById" },
                    { "8b58af50-11cd-4dfd-b566-1ddb0bf6f893", "4", "Resident_Delete", "Resident_Delete" },
                    { "93c73660-7e57-4614-99e6-1ec8923b3c1d", "4", "Apartment_DeleteMultiple", "Apartment_DeleteMultiple" },
                    { "97873acf-dfd8-498b-be6f-ee738e35972b", "4", "BuildingCategorie_Update", "BuildingCategorie_Update" },
                    { "9ab7a4aa-2a06-433a-b9ed-ee5eb00689f1", "4", "UrbanArea_GetById", "UrbanArea_GetById" },
                    { "a9888cfc-4e8f-4bd7-8532-abe5005f5e5b", "4", "BuildingCategorie_GetAll", "BuildingCategorie_GetAll" },
                    { "b5b2b89b-73af-4855-8af7-b56c375668ec", "4", "Permission_DeleteMultiple", "Permission_DeleteMultiple" },
                    { "bd064553-2d31-4e8c-91b3-d374517f7d87", "4", "User_Delete", "User_Delete" },
                    { "befa0e07-ff87-4260-8e9d-7d3d361c80c4", "4", "BuildingCategorie_DeleteMultiple", "BuildingCategorie_DeleteMultiple" },
                    { "c1b7b1c4-574a-43e7-9d44-24df4a6d6258", "4", "User_DeleteMultiple", "User_DeleteMultiple" },
                    { "c831cf13-1441-4894-877b-bc6385f39aea", "4", "Customer_GetById", "Customer_GetById" },
                    { "d979562d-557e-4ae6-b98f-4469fdafaf89", "4", "Resident_Create", "Resident_Create" },
                    { "e27a2d8b-edc9-4d46-8169-7ecb8dc7a18f", "4", "Apartment_GetAll", "Apartment_GetAll" },
                    { "e2914001-8c15-4eae-af06-1b2b0b91cf9d", "4", "Apartment_Create", "Apartment_Create" },
                    { "e5b1f53c-b267-4ade-b6e4-71e0b32c0bcd", "4", "UrbanArea_Update", "UrbanArea_Update" },
                    { "e7d0f281-baaa-4245-b27a-da41ae1dbe3a", "4", "Addresse_DeleteMultiple", "Addresse_DeleteMultiple" },
                    { "efc82805-fc30-48c1-a720-5a4b6d128bdc", "4", "Resident_DeleteMultiple", "Resident_DeleteMultiple" },
                    { "efd88de2-4db2-4e34-b8c3-133dae667867", "4", "UrbanArea_Create", "UrbanArea_Create" },
                    { "f584ccd2-05c7-455b-8fe2-2ea1e7f91809", "4", "Resident_GetById", "Resident_GetById" },
                    { "f7844037-00dc-4417-ab26-a144eb82bdce", "4", "User_GetAll", "User_GetAll" },
                    { "f8eab6e3-c054-4f67-af49-d497d883a05e", "4", "Apartment_Update", "Apartment_Update" },
                    { "fbce72ed-d485-4cc0-9ab4-6683db048c4c", "4", "Addresse_GetById", "Addresse_GetById" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BuildingCategories_UrbanAreaUrbanId",
                table: "BuildingCategories",
                column: "UrbanAreaUrbanId");

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingCategories_UrbanAreas_UrbanAreaUrbanId",
                table: "BuildingCategories",
                column: "UrbanAreaUrbanId",
                principalTable: "UrbanAreas",
                principalColumn: "UrbanId");
        }
    }
}
