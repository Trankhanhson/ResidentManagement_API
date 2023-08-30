using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AuthenticationProject.Migrations
{
    /// <inheritdoc />
    public partial class remove : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apartments_BuildingCategories_BuildingCategoryCategoryId",
                table: "Apartments");

            migrationBuilder.DropIndex(
                name: "IX_Apartments_BuildingCategoryCategoryId",
                table: "Apartments");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "05138b36-f0fd-42a2-ba2c-df0e3833e444");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ca7ec81-a15e-4b1b-950f-c58ce92b9adc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "145e479d-3c19-4e1c-a2a8-e70efeade9b9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18438c3f-0419-41a1-a95b-3edc70af8971");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e85f124-cfec-490b-9e59-b42df68fd02b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21b14071-87c1-4da4-836d-63036f3d0c88");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d6eb1ed-7c54-4bdd-8154-879707538db9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31c0726d-f114-4d22-a161-f87e3d0de659");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "45e51b35-a9c6-444c-9989-87fb6855e282");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60768870-8f8c-4d36-bb7f-e2fd61fc1d94");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6171750f-a321-4d11-94c1-9baeedd2f89c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "661f677c-1b54-4e17-892c-61df4ea5b42a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "662d1a22-cb23-494a-8aa8-eaeb927f9a13");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68a5592f-4c88-4392-817a-ee0e42290368");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "708df00e-d640-4b5f-891d-9663f780ec1f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "711a13a7-6f5f-4992-9a48-4dcf47bf5fc1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "754088df-9a66-4566-8397-c5619f97ca7a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "77fa7ad2-86a9-4b1e-8bce-eebf297bb50b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d18cb29-03f7-4683-9301-1de20600232d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8135f3b9-896f-4902-acb6-d26cfda6b43c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "85f4867e-bcb0-44e9-ae76-59bc3c0ff565");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8997ba6d-a60f-40e3-b920-5f1d958ade0b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8c40dfcb-a851-43c2-9c5e-9cca665609ff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ec79f31-2c60-4fee-a97c-370ff2ca959f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93c0f295-0a25-411a-a6c7-564aaf8d6ca4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93eb864e-e698-4700-ac77-4fea6c56d4ab");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a17d9bb-e178-44ae-ba56-d8073565760b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b7d47c3-bbac-4e0a-b5af-3573a9682dd8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a378bbd0-b66a-4547-92e6-976b630d56d2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7222042-4a62-471c-850d-95824ae471a7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a923f822-6ca7-4172-a2cf-d38968877638");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac0ef910-df9b-46f5-b81f-25637a04e80d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aedf4e34-66d7-40eb-b952-5a1b9770fe98");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0f9c342-18ed-41b7-9881-a1032c32ecca");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b58b34ea-b7e8-452a-86fe-09bdae445fd7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b74c56a4-6fa4-43d0-8f94-28f2cf8c3d69");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c20d89a4-1a1d-4d96-83c3-88f29a962a36");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4c752bc-31ef-4984-9fcd-fe70835475e0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb59eeb9-5f54-4c85-972a-30c67f3cf1b7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "df39e523-092e-46f2-9ba3-982d1dc83df5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e42694b7-9d73-4b8e-9ed5-78cd9a2db30a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e7ce56ac-8c48-46e4-b020-9b32e38b3ef6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e8d503bb-b993-43c8-8839-c23ac692a871");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e9fc8a9d-a24e-4331-a5d2-32214b113b1a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee9a1eb6-8c5b-4cf5-b56f-f25804f35526");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "efb0fcb4-071a-4aad-87c4-39819d683d94");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f34914f6-dbca-4898-9ea2-79de87f3df3f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc26265c-9087-45ff-b23a-d92cf1416fab");

            migrationBuilder.DropColumn(
                name: "BuildingCategoryCategoryId",
                table: "Apartments");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Apartments");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0b98ff73-af7e-4331-9df8-a80683c73875", "4", "Apartment_GetById", "Apartment_GetById" },
                    { "12d5e426-ede7-4db7-97cc-3242e7300710", "4", "BuildingCategorie_GetById", "BuildingCategorie_GetById" },
                    { "14ce767b-105e-468e-a8b5-ba852ec435e6", "4", "Addresse_Update", "Addresse_Update" },
                    { "1500a952-683d-4a50-8c2b-f28d5f9b5033", "4", "User_Delete", "User_Delete" },
                    { "171e7a8a-ff29-4a59-b44a-6da2badcff73", "4", "Addresse_GetById", "Addresse_GetById" },
                    { "1f024b97-ae49-49a6-91d3-9e45a332b155", "4", "Addresse_Delete", "Addresse_Delete" },
                    { "2269edb5-4493-4881-b3c9-eeae69991566", "4", "UrbanArea_Create", "UrbanArea_Create" },
                    { "28513c82-aea9-4f15-a683-ef776e6727c6", "4", "Permission_Update", "Permission_Update" },
                    { "2ae569ee-c6f6-4290-bce4-fc572f8d7140", "4", "Apartment_DeleteMultiple", "Apartment_DeleteMultiple" },
                    { "2cc90c62-f085-4532-9863-54eae9b4a2c9", "4", "UrbanArea_Delete", "UrbanArea_Delete" },
                    { "2f751b59-7a80-4280-92a0-524d465f5e8d", "4", "UrbanArea_Update", "UrbanArea_Update" },
                    { "309d94b6-50a7-4965-9ee2-6f2092f21577", "4", "User_Update", "User_Update" },
                    { "368175ab-8324-41dd-bebe-ad5bedacd5ff", "4", "Permission_GetById", "Permission_GetById" },
                    { "4914524a-1049-4f99-8275-6d2809ae9855", "4", "Resident_Update", "Resident_Update" },
                    { "4c966b9e-06ca-42bd-945d-7c485b7818f7", "4", "User_GetById", "User_GetById" },
                    { "52c293fc-5011-4486-8e05-7c585af8b54b", "4", "UrbanArea_GetById", "UrbanArea_GetById" },
                    { "542cf6f6-449d-438f-8ea7-4d53b2c96fe6", "4", "Customer_Create", "Customer_Create" },
                    { "57e8a51a-edbd-4132-a7a9-5d675d7e29c5", "4", "Resident_DeleteMultiple", "Resident_DeleteMultiple" },
                    { "58b4a66d-b35f-40fe-b0c9-1cb36cb5cebd", "4", "Apartment_Update", "Apartment_Update" },
                    { "597c0b4f-3595-4a97-a604-aad8a9b78d1e", "4", "User_DeleteMultiple", "User_DeleteMultiple" },
                    { "5a77a8cf-0374-4116-9c19-0877ce3a1099", "4", "Addresse_DeleteMultiple", "Addresse_DeleteMultiple" },
                    { "647b1f7e-b022-4e86-bf55-67243b76fd94", "4", "Customer_Delete", "Customer_Delete" },
                    { "64991497-1dda-41e6-9bff-5fe166c3cc35", "4", "UrbanArea_DeleteMultiple", "UrbanArea_DeleteMultiple" },
                    { "6914b347-a908-4e5f-b033-b5452dd62282", "4", "BuildingCategorie_Create", "BuildingCategorie_Create" },
                    { "6996b994-1041-4a02-a30b-d6ac2a7680e4", "4", "Resident_GetAll", "Resident_GetAll" },
                    { "6cc419f1-cdb4-4b02-bfe0-0caf783df0d3", "4", "Addresse_GetAll", "Addresse_GetAll" },
                    { "7492212e-87a6-47d1-adfa-5e5bae0322aa", "4", "Permission_Delete", "Permission_Delete" },
                    { "76e2ecd1-96b2-4641-bf30-00bf628d3b9c", "4", "Permission_DeleteMultiple", "Permission_DeleteMultiple" },
                    { "7bfe9689-b260-4f7b-8107-cda8edb53000", "4", "BuildingCategorie_DeleteMultiple", "BuildingCategorie_DeleteMultiple" },
                    { "8121b53c-53f8-4a9e-aa3a-2723d06941b6", "4", "Resident_Delete", "Resident_Delete" },
                    { "8511d679-f2bd-4953-8a14-b799efef9ca9", "4", "Customer_DeleteMultiple", "Customer_DeleteMultiple" },
                    { "8620d1e8-b07e-4b71-af70-3400e1d98c27", "4", "User_Create", "User_Create" },
                    { "86f8a226-01f9-4933-a277-cce15ae330da", "4", "User_GetAll", "User_GetAll" },
                    { "878aefac-e82e-45ee-b11d-e91fe194fe6b", "4", "Apartment_Delete", "Apartment_Delete" },
                    { "8991278c-8bc5-4ffe-b298-6adc53d69f68", "4", "Resident_Create", "Resident_Create" },
                    { "a477ac29-7daa-4b6c-b87a-9c349572511b", "4", "Permission_Create", "Permission_Create" },
                    { "a5a9502a-3c0d-4481-a053-989dacb66d74", "4", "BuildingCategorie_Delete", "BuildingCategorie_Delete" },
                    { "ab763c5e-92d5-445d-8f28-fbf13cfc50f3", "4", "Resident_GetById", "Resident_GetById" },
                    { "bf70ca64-da4a-4d70-b6f4-45becf9ffb55", "4", "BuildingCategorie_GetAll", "BuildingCategorie_GetAll" },
                    { "c2e87dfb-cc8a-40f8-ab65-84d2ce6da87b", "4", "Apartment_GetAll", "Apartment_GetAll" },
                    { "c4fb5aec-c977-485b-935f-d50a12291073", "4", "Addresse_Create", "Addresse_Create" },
                    { "ca96471b-6d22-4854-9801-300db2e6b998", "4", "Customer_GetById", "Customer_GetById" },
                    { "dafe84f5-638e-4d27-84a2-7fe0f5907dea", "4", "BuildingCategorie_Update", "BuildingCategorie_Update" },
                    { "df2e924f-d28d-450b-aadb-7e0bdafcc6c9", "4", "UrbanArea_GetAll", "UrbanArea_GetAll" },
                    { "e23a46c2-7fd6-46bb-b2f0-e21c49a3d099", "4", "Apartment_Create", "Apartment_Create" },
                    { "f53200b1-9eee-4806-b3c0-c040fe1d1423", "4", "Customer_GetAll", "Customer_GetAll" },
                    { "f9b4fcbe-c1ad-4739-a3e4-caf575393d73", "4", "Customer_Update", "Customer_Update" },
                    { "ff8625ec-61d4-44f8-be66-3d1d3941e2cf", "4", "Permission_GetAll", "Permission_GetAll" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b98ff73-af7e-4331-9df8-a80683c73875");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12d5e426-ede7-4db7-97cc-3242e7300710");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "14ce767b-105e-468e-a8b5-ba852ec435e6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1500a952-683d-4a50-8c2b-f28d5f9b5033");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "171e7a8a-ff29-4a59-b44a-6da2badcff73");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f024b97-ae49-49a6-91d3-9e45a332b155");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2269edb5-4493-4881-b3c9-eeae69991566");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "28513c82-aea9-4f15-a683-ef776e6727c6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2ae569ee-c6f6-4290-bce4-fc572f8d7140");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2cc90c62-f085-4532-9863-54eae9b4a2c9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f751b59-7a80-4280-92a0-524d465f5e8d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "309d94b6-50a7-4965-9ee2-6f2092f21577");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "368175ab-8324-41dd-bebe-ad5bedacd5ff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4914524a-1049-4f99-8275-6d2809ae9855");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c966b9e-06ca-42bd-945d-7c485b7818f7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52c293fc-5011-4486-8e05-7c585af8b54b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "542cf6f6-449d-438f-8ea7-4d53b2c96fe6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57e8a51a-edbd-4132-a7a9-5d675d7e29c5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "58b4a66d-b35f-40fe-b0c9-1cb36cb5cebd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "597c0b4f-3595-4a97-a604-aad8a9b78d1e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a77a8cf-0374-4116-9c19-0877ce3a1099");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "647b1f7e-b022-4e86-bf55-67243b76fd94");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64991497-1dda-41e6-9bff-5fe166c3cc35");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6914b347-a908-4e5f-b033-b5452dd62282");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6996b994-1041-4a02-a30b-d6ac2a7680e4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6cc419f1-cdb4-4b02-bfe0-0caf783df0d3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7492212e-87a6-47d1-adfa-5e5bae0322aa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "76e2ecd1-96b2-4641-bf30-00bf628d3b9c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7bfe9689-b260-4f7b-8107-cda8edb53000");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8121b53c-53f8-4a9e-aa3a-2723d06941b6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8511d679-f2bd-4953-8a14-b799efef9ca9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8620d1e8-b07e-4b71-af70-3400e1d98c27");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "86f8a226-01f9-4933-a277-cce15ae330da");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "878aefac-e82e-45ee-b11d-e91fe194fe6b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8991278c-8bc5-4ffe-b298-6adc53d69f68");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a477ac29-7daa-4b6c-b87a-9c349572511b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5a9502a-3c0d-4481-a053-989dacb66d74");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ab763c5e-92d5-445d-8f28-fbf13cfc50f3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf70ca64-da4a-4d70-b6f4-45becf9ffb55");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2e87dfb-cc8a-40f8-ab65-84d2ce6da87b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4fb5aec-c977-485b-935f-d50a12291073");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca96471b-6d22-4854-9801-300db2e6b998");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dafe84f5-638e-4d27-84a2-7fe0f5907dea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "df2e924f-d28d-450b-aadb-7e0bdafcc6c9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e23a46c2-7fd6-46bb-b2f0-e21c49a3d099");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f53200b1-9eee-4806-b3c0-c040fe1d1423");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f9b4fcbe-c1ad-4739-a3e4-caf575393d73");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff8625ec-61d4-44f8-be66-3d1d3941e2cf");

            migrationBuilder.AddColumn<int>(
                name: "BuildingCategoryCategoryId",
                table: "Apartments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Apartments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "05138b36-f0fd-42a2-ba2c-df0e3833e444", "4", "UrbanArea_Update", "UrbanArea_Update" },
                    { "0ca7ec81-a15e-4b1b-950f-c58ce92b9adc", "4", "Addresse_Update", "Addresse_Update" },
                    { "145e479d-3c19-4e1c-a2a8-e70efeade9b9", "4", "User_GetAll", "User_GetAll" },
                    { "18438c3f-0419-41a1-a95b-3edc70af8971", "4", "Resident_Delete", "Resident_Delete" },
                    { "1e85f124-cfec-490b-9e59-b42df68fd02b", "4", "Apartment_GetById", "Apartment_GetById" },
                    { "21b14071-87c1-4da4-836d-63036f3d0c88", "4", "User_DeleteMultiple", "User_DeleteMultiple" },
                    { "2d6eb1ed-7c54-4bdd-8154-879707538db9", "4", "Permission_Delete", "Permission_Delete" },
                    { "31c0726d-f114-4d22-a161-f87e3d0de659", "4", "Customer_GetAll", "Customer_GetAll" },
                    { "45e51b35-a9c6-444c-9989-87fb6855e282", "4", "Resident_DeleteMultiple", "Resident_DeleteMultiple" },
                    { "60768870-8f8c-4d36-bb7f-e2fd61fc1d94", "4", "BuildingCategorie_GetAll", "BuildingCategorie_GetAll" },
                    { "6171750f-a321-4d11-94c1-9baeedd2f89c", "4", "User_Delete", "User_Delete" },
                    { "661f677c-1b54-4e17-892c-61df4ea5b42a", "4", "Addresse_Delete", "Addresse_Delete" },
                    { "662d1a22-cb23-494a-8aa8-eaeb927f9a13", "4", "Resident_GetAll", "Resident_GetAll" },
                    { "68a5592f-4c88-4392-817a-ee0e42290368", "4", "Customer_Create", "Customer_Create" },
                    { "708df00e-d640-4b5f-891d-9663f780ec1f", "4", "Customer_DeleteMultiple", "Customer_DeleteMultiple" },
                    { "711a13a7-6f5f-4992-9a48-4dcf47bf5fc1", "4", "Apartment_Update", "Apartment_Update" },
                    { "754088df-9a66-4566-8397-c5619f97ca7a", "4", "Customer_Delete", "Customer_Delete" },
                    { "77fa7ad2-86a9-4b1e-8bce-eebf297bb50b", "4", "UrbanArea_Delete", "UrbanArea_Delete" },
                    { "7d18cb29-03f7-4683-9301-1de20600232d", "4", "User_GetById", "User_GetById" },
                    { "8135f3b9-896f-4902-acb6-d26cfda6b43c", "4", "User_Create", "User_Create" },
                    { "85f4867e-bcb0-44e9-ae76-59bc3c0ff565", "4", "Permission_Create", "Permission_Create" },
                    { "8997ba6d-a60f-40e3-b920-5f1d958ade0b", "4", "BuildingCategorie_Update", "BuildingCategorie_Update" },
                    { "8c40dfcb-a851-43c2-9c5e-9cca665609ff", "4", "UrbanArea_GetById", "UrbanArea_GetById" },
                    { "8ec79f31-2c60-4fee-a97c-370ff2ca959f", "4", "UrbanArea_DeleteMultiple", "UrbanArea_DeleteMultiple" },
                    { "93c0f295-0a25-411a-a6c7-564aaf8d6ca4", "4", "User_Update", "User_Update" },
                    { "93eb864e-e698-4700-ac77-4fea6c56d4ab", "4", "Resident_GetById", "Resident_GetById" },
                    { "9a17d9bb-e178-44ae-ba56-d8073565760b", "4", "Addresse_GetAll", "Addresse_GetAll" },
                    { "9b7d47c3-bbac-4e0a-b5af-3573a9682dd8", "4", "Customer_GetById", "Customer_GetById" },
                    { "a378bbd0-b66a-4547-92e6-976b630d56d2", "4", "Resident_Create", "Resident_Create" },
                    { "a7222042-4a62-471c-850d-95824ae471a7", "4", "Apartment_Create", "Apartment_Create" },
                    { "a923f822-6ca7-4172-a2cf-d38968877638", "4", "BuildingCategorie_Create", "BuildingCategorie_Create" },
                    { "ac0ef910-df9b-46f5-b81f-25637a04e80d", "4", "Permission_Update", "Permission_Update" },
                    { "aedf4e34-66d7-40eb-b952-5a1b9770fe98", "4", "Resident_Update", "Resident_Update" },
                    { "b0f9c342-18ed-41b7-9881-a1032c32ecca", "4", "Apartment_DeleteMultiple", "Apartment_DeleteMultiple" },
                    { "b58b34ea-b7e8-452a-86fe-09bdae445fd7", "4", "Addresse_Create", "Addresse_Create" },
                    { "b74c56a4-6fa4-43d0-8f94-28f2cf8c3d69", "4", "BuildingCategorie_GetById", "BuildingCategorie_GetById" },
                    { "c20d89a4-1a1d-4d96-83c3-88f29a962a36", "4", "BuildingCategorie_Delete", "BuildingCategorie_Delete" },
                    { "c4c752bc-31ef-4984-9fcd-fe70835475e0", "4", "Addresse_DeleteMultiple", "Addresse_DeleteMultiple" },
                    { "cb59eeb9-5f54-4c85-972a-30c67f3cf1b7", "4", "Apartment_GetAll", "Apartment_GetAll" },
                    { "df39e523-092e-46f2-9ba3-982d1dc83df5", "4", "Customer_Update", "Customer_Update" },
                    { "e42694b7-9d73-4b8e-9ed5-78cd9a2db30a", "4", "Permission_DeleteMultiple", "Permission_DeleteMultiple" },
                    { "e7ce56ac-8c48-46e4-b020-9b32e38b3ef6", "4", "UrbanArea_GetAll", "UrbanArea_GetAll" },
                    { "e8d503bb-b993-43c8-8839-c23ac692a871", "4", "Permission_GetAll", "Permission_GetAll" },
                    { "e9fc8a9d-a24e-4331-a5d2-32214b113b1a", "4", "UrbanArea_Create", "UrbanArea_Create" },
                    { "ee9a1eb6-8c5b-4cf5-b56f-f25804f35526", "4", "Permission_GetById", "Permission_GetById" },
                    { "efb0fcb4-071a-4aad-87c4-39819d683d94", "4", "Addresse_GetById", "Addresse_GetById" },
                    { "f34914f6-dbca-4898-9ea2-79de87f3df3f", "4", "Apartment_Delete", "Apartment_Delete" },
                    { "fc26265c-9087-45ff-b23a-d92cf1416fab", "4", "BuildingCategorie_DeleteMultiple", "BuildingCategorie_DeleteMultiple" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_BuildingCategoryCategoryId",
                table: "Apartments",
                column: "BuildingCategoryCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Apartments_BuildingCategories_BuildingCategoryCategoryId",
                table: "Apartments",
                column: "BuildingCategoryCategoryId",
                principalTable: "BuildingCategories",
                principalColumn: "CategoryId");
        }
    }
}
