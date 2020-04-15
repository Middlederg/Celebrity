using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Celebrity.Data.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("1d14a1fd-dc5c-4360-9584-431b5f23f8c9"), "Personajes famosos" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("ea3291d7-3bf2-4e77-ae8f-e3febdf5ed3e"), "Personajes de ficción famosos" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("c9fd9bf9-d9f1-4a7e-a7c0-137a00a7b392"), "Cultura" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("0205c909-3a3e-4127-bf20-deb796d839b4"), "Lugares" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("ead9ad1a-811a-446b-b6fc-b6122f1982bd"), "Citas" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("95233f82-5cc6-4a01-b4e9-f874634f7452"), "Universos de ficción" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("f3dd4583-5e3b-418c-9a56-69526e4005f7"), "Nacionalidades" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("1f407ee4-63ae-4a59-bed3-1eaebabf8b57"), "Tecnología" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("c4f79217-b113-4163-8ee3-0d734fa5b52c"), "Ciencia" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("c9d04f33-1934-4534-9958-1b9d9d4ce6c4"), "Deporte" });

            migrationBuilder.InsertData(
                table: "Concepts",
                columns: new[] { "Id", "Difficulty", "IsCustomized", "Name", "Type" },
                values: new object[] { new Guid("d8f4758b-34dc-4c9f-b3f1-4b57219dbcf4"), 0, false, "Alejandro Magno", 0 });

            migrationBuilder.InsertData(
                table: "Concepts",
                columns: new[] { "Id", "Difficulty", "IsCustomized", "Name", "Type" },
                values: new object[] { new Guid("d349e200-b6f3-4271-b1fa-7aaef4dae7ee"), 0, false, "Hércules", 0 });

            migrationBuilder.InsertData(
                table: "Concepts",
                columns: new[] { "Id", "Difficulty", "IsCustomized", "Name", "Type" },
                values: new object[] { new Guid("e9445dcd-10d2-4e31-b147-36fe31b423d1"), 1, false, "Amilcar Barca", 0 });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "IdCategory", "IsCustomized", "Name" },
                values: new object[] { new Guid("d89fa066-1a07-4a9d-9ba9-8bf3ff2e98ee"), new Guid("1d14a1fd-dc5c-4360-9584-431b5f23f8c9"), false, "Antigüedad" });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "IdCategory", "IsCustomized", "Name" },
                values: new object[] { new Guid("f75afdff-eccc-44b3-b352-1ecd44b56dd1"), new Guid("f3dd4583-5e3b-418c-9a56-69526e4005f7"), false, "Reino Unido" });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "IdCategory", "IsCustomized", "Name" },
                values: new object[] { new Guid("dac73aab-efb5-47c4-8115-2706ea5ced6e"), new Guid("f3dd4583-5e3b-418c-9a56-69526e4005f7"), false, "USA" });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "IdCategory", "IsCustomized", "Name" },
                values: new object[] { new Guid("b7019227-c356-4f7f-8f9d-443913b3a4d7"), new Guid("f3dd4583-5e3b-418c-9a56-69526e4005f7"), false, "España" });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "IdCategory", "IsCustomized", "Name" },
                values: new object[] { new Guid("d9b5b2d8-fb58-4ba1-b869-4725a3c36e5d"), new Guid("95233f82-5cc6-4a01-b4e9-f874634f7452"), false, "Disney" });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "IdCategory", "IsCustomized", "Name" },
                values: new object[] { new Guid("e50a300d-9906-4603-a6fe-7e3caef98731"), new Guid("95233f82-5cc6-4a01-b4e9-f874634f7452"), false, "Marvel" });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "IdCategory", "IsCustomized", "Name" },
                values: new object[] { new Guid("a60064fd-5160-4bda-980e-b229dba39ffa"), new Guid("95233f82-5cc6-4a01-b4e9-f874634f7452"), false, "Los Simpsons" });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "IdCategory", "IsCustomized", "Name" },
                values: new object[] { new Guid("ba6ed954-3ad0-48ae-ab86-071902ff412e"), new Guid("95233f82-5cc6-4a01-b4e9-f874634f7452"), false, "Harry Potter" });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "IdCategory", "IsCustomized", "Name" },
                values: new object[] { new Guid("359cf832-f93c-4787-a25e-292988925b33"), new Guid("95233f82-5cc6-4a01-b4e9-f874634f7452"), false, "Star Wars" });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "IdCategory", "IsCustomized", "Name" },
                values: new object[] { new Guid("bf5734dd-0c5a-407b-bb87-b970a49dd2bd"), new Guid("ead9ad1a-811a-446b-b6fc-b6122f1982bd"), false, "Frases de la tele" });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "IdCategory", "IsCustomized", "Name" },
                values: new object[] { new Guid("60b6b56b-2d9f-4936-b8c0-c631c7342a9c"), new Guid("ead9ad1a-811a-446b-b6fc-b6122f1982bd"), false, "Proverbios y refranes" });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "IdCategory", "IsCustomized", "Name" },
                values: new object[] { new Guid("146802de-e6af-4002-a017-1ae192e06a90"), new Guid("ead9ad1a-811a-446b-b6fc-b6122f1982bd"), false, "Citas históricas" });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "IdCategory", "IsCustomized", "Name" },
                values: new object[] { new Guid("5b854ea9-f8ce-4883-860f-c5f5dc624ac5"), new Guid("0205c909-3a3e-4127-bf20-deb796d839b4"), false, "Mares y lagos" });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "IdCategory", "IsCustomized", "Name" },
                values: new object[] { new Guid("ffba601c-81c8-4f91-a14f-98e68903da7b"), new Guid("0205c909-3a3e-4127-bf20-deb796d839b4"), false, "Montañas" });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "IdCategory", "IsCustomized", "Name" },
                values: new object[] { new Guid("970e4347-6765-42bf-ba01-e557ba0bfe50"), new Guid("f3dd4583-5e3b-418c-9a56-69526e4005f7"), false, "Italia" });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "IdCategory", "IsCustomized", "Name" },
                values: new object[] { new Guid("b7639fbc-1d30-446c-8794-030338b88da5"), new Guid("0205c909-3a3e-4127-bf20-deb796d839b4"), false, "Ríos" });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "IdCategory", "IsCustomized", "Name" },
                values: new object[] { new Guid("57dd762a-abe0-4296-9d2d-fcb1c40fab06"), new Guid("0205c909-3a3e-4127-bf20-deb796d839b4"), false, "Paises" });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "IdCategory", "IsCustomized", "Name" },
                values: new object[] { new Guid("152cf8ae-5831-43c5-977b-fe0e36cc8964"), new Guid("c9fd9bf9-d9f1-4a7e-a7c0-137a00a7b392"), false, "Juegos de mesa" });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "IdCategory", "IsCustomized", "Name" },
                values: new object[] { new Guid("9bd47488-a2d2-46bf-ba09-1687b2bdfdf2"), new Guid("c9fd9bf9-d9f1-4a7e-a7c0-137a00a7b392"), false, "Videojuegos" });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "IdCategory", "IsCustomized", "Name" },
                values: new object[] { new Guid("99b82e57-7720-4035-91fc-58f115c43267"), new Guid("c9fd9bf9-d9f1-4a7e-a7c0-137a00a7b392"), false, "Música" });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "IdCategory", "IsCustomized", "Name" },
                values: new object[] { new Guid("1750b138-7f94-41b4-95e2-aaba62e9132b"), new Guid("c9fd9bf9-d9f1-4a7e-a7c0-137a00a7b392"), false, "Cómic" });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "IdCategory", "IsCustomized", "Name" },
                values: new object[] { new Guid("32b9e3e7-afb8-4e6a-9e8c-521c3b6e8215"), new Guid("c9fd9bf9-d9f1-4a7e-a7c0-137a00a7b392"), false, "Teatro" });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "IdCategory", "IsCustomized", "Name" },
                values: new object[] { new Guid("0aca39af-d32e-48af-88cc-880d640907b1"), new Guid("c9fd9bf9-d9f1-4a7e-a7c0-137a00a7b392"), false, "Literatura" });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "IdCategory", "IsCustomized", "Name" },
                values: new object[] { new Guid("a199a564-ce38-484c-a0f8-6517b0e842d2"), new Guid("c9fd9bf9-d9f1-4a7e-a7c0-137a00a7b392"), false, "Series" });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "IdCategory", "IsCustomized", "Name" },
                values: new object[] { new Guid("4c5694b3-6b04-4094-9cab-557445a9325b"), new Guid("c9fd9bf9-d9f1-4a7e-a7c0-137a00a7b392"), false, "Películas" });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "IdCategory", "IsCustomized", "Name" },
                values: new object[] { new Guid("0681f87c-4ea2-448b-a28a-948ad9b9e0ba"), new Guid("ea3291d7-3bf2-4e77-ae8f-e3febdf5ed3e"), false, "Personaje de ficción" });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "IdCategory", "IsCustomized", "Name" },
                values: new object[] { new Guid("5b2a6026-11ad-44bc-a49c-928766e610ae"), new Guid("1d14a1fd-dc5c-4360-9584-431b5f23f8c9"), false, "Contemporáneo" });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "IdCategory", "IsCustomized", "Name" },
                values: new object[] { new Guid("bb2afc67-efcb-4c3e-950e-e5a8a5f5a139"), new Guid("1d14a1fd-dc5c-4360-9584-431b5f23f8c9"), false, "Moderno" });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "IdCategory", "IsCustomized", "Name" },
                values: new object[] { new Guid("0f188dc4-8b87-4581-9cd4-cd70b01a92f3"), new Guid("1d14a1fd-dc5c-4360-9584-431b5f23f8c9"), false, "Medieval" });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "IdCategory", "IsCustomized", "Name" },
                values: new object[] { new Guid("2adbd65a-94f3-415e-b749-522960c3da4f"), new Guid("0205c909-3a3e-4127-bf20-deb796d839b4"), false, "Ciudades" });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "IdCategory", "IsCustomized", "Name" },
                values: new object[] { new Guid("f47c5bbb-fe92-40f3-8b88-8e7f74f8bc5a"), new Guid("f3dd4583-5e3b-418c-9a56-69526e4005f7"), false, "Francia" });

            migrationBuilder.InsertData(
                table: "SubcategoriesInConcepts",
                columns: new[] { "Id", "ConceptId", "SubcategoryId" },
                values: new object[] { new Guid("f942862a-9bc1-4b2e-9ef3-2ccd66c287fc"), new Guid("d8f4758b-34dc-4c9f-b3f1-4b57219dbcf4"), new Guid("d89fa066-1a07-4a9d-9ba9-8bf3ff2e98ee") });

            migrationBuilder.InsertData(
                table: "SubcategoriesInConcepts",
                columns: new[] { "Id", "ConceptId", "SubcategoryId" },
                values: new object[] { new Guid("a32dae9e-ae17-499e-87d4-a0973efed1e2"), new Guid("d349e200-b6f3-4271-b1fa-7aaef4dae7ee"), new Guid("d89fa066-1a07-4a9d-9ba9-8bf3ff2e98ee") });

            migrationBuilder.InsertData(
                table: "SubcategoriesInConcepts",
                columns: new[] { "Id", "ConceptId", "SubcategoryId" },
                values: new object[] { new Guid("2fa0d9b9-ca09-44ca-aabd-0e50fd7b6dfb"), new Guid("e9445dcd-10d2-4e31-b147-36fe31b423d1"), new Guid("d89fa066-1a07-4a9d-9ba9-8bf3ff2e98ee") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1f407ee4-63ae-4a59-bed3-1eaebabf8b57"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c4f79217-b113-4163-8ee3-0d734fa5b52c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c9d04f33-1934-4534-9958-1b9d9d4ce6c4"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("0681f87c-4ea2-448b-a28a-948ad9b9e0ba"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("0aca39af-d32e-48af-88cc-880d640907b1"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("0f188dc4-8b87-4581-9cd4-cd70b01a92f3"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("146802de-e6af-4002-a017-1ae192e06a90"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("152cf8ae-5831-43c5-977b-fe0e36cc8964"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("1750b138-7f94-41b4-95e2-aaba62e9132b"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("2adbd65a-94f3-415e-b749-522960c3da4f"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("32b9e3e7-afb8-4e6a-9e8c-521c3b6e8215"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("359cf832-f93c-4787-a25e-292988925b33"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("4c5694b3-6b04-4094-9cab-557445a9325b"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("57dd762a-abe0-4296-9d2d-fcb1c40fab06"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("5b2a6026-11ad-44bc-a49c-928766e610ae"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("5b854ea9-f8ce-4883-860f-c5f5dc624ac5"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("60b6b56b-2d9f-4936-b8c0-c631c7342a9c"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("970e4347-6765-42bf-ba01-e557ba0bfe50"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("99b82e57-7720-4035-91fc-58f115c43267"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("9bd47488-a2d2-46bf-ba09-1687b2bdfdf2"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("a199a564-ce38-484c-a0f8-6517b0e842d2"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("a60064fd-5160-4bda-980e-b229dba39ffa"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("b7019227-c356-4f7f-8f9d-443913b3a4d7"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("b7639fbc-1d30-446c-8794-030338b88da5"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("ba6ed954-3ad0-48ae-ab86-071902ff412e"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("bb2afc67-efcb-4c3e-950e-e5a8a5f5a139"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("bf5734dd-0c5a-407b-bb87-b970a49dd2bd"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("d9b5b2d8-fb58-4ba1-b869-4725a3c36e5d"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("dac73aab-efb5-47c4-8115-2706ea5ced6e"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("e50a300d-9906-4603-a6fe-7e3caef98731"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("f47c5bbb-fe92-40f3-8b88-8e7f74f8bc5a"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("f75afdff-eccc-44b3-b352-1ecd44b56dd1"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("ffba601c-81c8-4f91-a14f-98e68903da7b"));

            migrationBuilder.DeleteData(
                table: "SubcategoriesInConcepts",
                keyColumn: "Id",
                keyValue: new Guid("2fa0d9b9-ca09-44ca-aabd-0e50fd7b6dfb"));

            migrationBuilder.DeleteData(
                table: "SubcategoriesInConcepts",
                keyColumn: "Id",
                keyValue: new Guid("a32dae9e-ae17-499e-87d4-a0973efed1e2"));

            migrationBuilder.DeleteData(
                table: "SubcategoriesInConcepts",
                keyColumn: "Id",
                keyValue: new Guid("f942862a-9bc1-4b2e-9ef3-2ccd66c287fc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0205c909-3a3e-4127-bf20-deb796d839b4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("95233f82-5cc6-4a01-b4e9-f874634f7452"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c9fd9bf9-d9f1-4a7e-a7c0-137a00a7b392"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ea3291d7-3bf2-4e77-ae8f-e3febdf5ed3e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ead9ad1a-811a-446b-b6fc-b6122f1982bd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f3dd4583-5e3b-418c-9a56-69526e4005f7"));

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: new Guid("d349e200-b6f3-4271-b1fa-7aaef4dae7ee"));

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: new Guid("d8f4758b-34dc-4c9f-b3f1-4b57219dbcf4"));

            migrationBuilder.DeleteData(
                table: "Concepts",
                keyColumn: "Id",
                keyValue: new Guid("e9445dcd-10d2-4e31-b147-36fe31b423d1"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("d89fa066-1a07-4a9d-9ba9-8bf3ff2e98ee"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1d14a1fd-dc5c-4360-9584-431b5f23f8c9"));
        }
    }
}
