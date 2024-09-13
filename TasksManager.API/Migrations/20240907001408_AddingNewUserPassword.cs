using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TasksManager.API.Migrations
{
    /// <inheritdoc />
    public partial class AddingNewUserPassword : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Collaborators",
                keyColumn: "Id",
                keyValue: new Guid("79411f40-7493-4677-b9e8-126c7d0f1a95"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("41131160-8534-4f5e-98d1-4dd5dc2b3c45"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("516d92a4-abd5-4e98-9b82-6c574aae1cb3"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("7e00e887-dc7e-4c2c-9836-9e00a4c585c4"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("6fb91203-a84d-4055-9d36-ebe406cd2d9b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dbc4f749-d94f-4f67-963a-5a8bb812c8aa"));

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[] { new Guid("152f27bb-dfef-4ff3-a6be-aa57fe32473f"), new DateTime(2024, 9, 7, 0, 14, 7, 332, DateTimeKind.Utc).AddTicks(2906), null, false, "Projeto Validações", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsDeleted", "Password", "UpdatedAt", "UserName" },
                values: new object[] { new Guid("707d520e-dcfc-46dd-86ec-ba3cd1986afe"), new DateTime(2024, 9, 7, 0, 14, 7, 332, DateTimeKind.Utc).AddTicks(2103), null, false, "61da6cee5f5e9aae4f368ea36b169be83d9595bd", null, "edu" });

            migrationBuilder.InsertData(
                table: "Collaborators",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsDeleted", "Name", "UpdatedAt", "UserId" },
                values: new object[] { new Guid("5034067e-1874-4652-a343-af66d96e3d95"), new DateTime(2024, 9, 7, 0, 14, 7, 332, DateTimeKind.Utc).AddTicks(2879), null, false, "Edu Brandão", null, new Guid("707d520e-dcfc-46dd-86ec-ba3cd1986afe") });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "IsDeleted", "Name", "ProjectId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0c9b6ae8-9678-4641-a4d2-97f3579cf57f"), new DateTime(2024, 9, 7, 0, 14, 7, 332, DateTimeKind.Utc).AddTicks(2928), null, "Levantamento de Requisitos da demanda", false, "Levantamento de Requisitos", new Guid("152f27bb-dfef-4ff3-a6be-aa57fe32473f"), null },
                    { new Guid("1a0f3f4f-e7e9-4b72-b05f-f9353dcfad40"), new DateTime(2024, 9, 7, 0, 14, 7, 332, DateTimeKind.Utc).AddTicks(2969), null, "Desenvolver tela para cadastro de usuários", false, "Desenvolvimento atividade 1", new Guid("152f27bb-dfef-4ff3-a6be-aa57fe32473f"), null },
                    { new Guid("f17d743d-c9eb-429d-a478-0f8aa829f0e4"), new DateTime(2024, 9, 7, 0, 14, 7, 332, DateTimeKind.Utc).AddTicks(2947), null, "Analisando atividades da demanda", false, "Análise da demanada", new Guid("152f27bb-dfef-4ff3-a6be-aa57fe32473f"), null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Collaborators",
                keyColumn: "Id",
                keyValue: new Guid("5034067e-1874-4652-a343-af66d96e3d95"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("0c9b6ae8-9678-4641-a4d2-97f3579cf57f"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("1a0f3f4f-e7e9-4b72-b05f-f9353dcfad40"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("f17d743d-c9eb-429d-a478-0f8aa829f0e4"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("152f27bb-dfef-4ff3-a6be-aa57fe32473f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("707d520e-dcfc-46dd-86ec-ba3cd1986afe"));

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[] { new Guid("6fb91203-a84d-4055-9d36-ebe406cd2d9b"), new DateTime(2024, 9, 6, 22, 37, 57, 783, DateTimeKind.Utc).AddTicks(2001), null, false, "Projeto Validações", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsDeleted", "Password", "UpdatedAt", "UserName" },
                values: new object[] { new Guid("dbc4f749-d94f-4f67-963a-5a8bb812c8aa"), new DateTime(2024, 9, 6, 22, 37, 57, 783, DateTimeKind.Utc).AddTicks(1847), null, false, "123@Test", null, "Edu Brandão" });

            migrationBuilder.InsertData(
                table: "Collaborators",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsDeleted", "Name", "UpdatedAt", "UserId" },
                values: new object[] { new Guid("79411f40-7493-4677-b9e8-126c7d0f1a95"), new DateTime(2024, 9, 6, 22, 37, 57, 783, DateTimeKind.Utc).AddTicks(1975), null, false, "Edu Brandão", null, new Guid("dbc4f749-d94f-4f67-963a-5a8bb812c8aa") });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "IsDeleted", "Name", "ProjectId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("41131160-8534-4f5e-98d1-4dd5dc2b3c45"), new DateTime(2024, 9, 6, 22, 37, 57, 783, DateTimeKind.Utc).AddTicks(2069), null, "Analisando atividades da demanda", false, "Análise da demanada", new Guid("6fb91203-a84d-4055-9d36-ebe406cd2d9b"), null },
                    { new Guid("516d92a4-abd5-4e98-9b82-6c574aae1cb3"), new DateTime(2024, 9, 6, 22, 37, 57, 783, DateTimeKind.Utc).AddTicks(2041), null, "Levantamento de Requisitos da demanda", false, "Levantamento de Requisitos", new Guid("6fb91203-a84d-4055-9d36-ebe406cd2d9b"), null },
                    { new Guid("7e00e887-dc7e-4c2c-9836-9e00a4c585c4"), new DateTime(2024, 9, 6, 22, 37, 57, 783, DateTimeKind.Utc).AddTicks(2091), null, "Desenvolver tela para cadastro de usuários", false, "Desenvolvimento atividade 1", new Guid("6fb91203-a84d-4055-9d36-ebe406cd2d9b"), null }
                });
        }
    }
}
