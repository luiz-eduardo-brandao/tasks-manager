using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TasksManager.API.Migrations
{
    /// <inheritdoc />
    public partial class alterTimeTrackerDatesColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "TimeTrackers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "TimeTrackers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[] { new Guid("866d9c4c-ba09-4ba9-83ea-c2974c5f0066"), new DateTime(2024, 9, 10, 20, 15, 52, 395, DateTimeKind.Utc).AddTicks(1479), null, false, "Projeto Validações", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsDeleted", "Password", "UpdatedAt", "UserName" },
                values: new object[] { new Guid("044f4a92-81b3-4038-8bd0-22a05edb91d6"), new DateTime(2024, 9, 10, 20, 15, 52, 395, DateTimeKind.Utc).AddTicks(573), null, false, "61da6cee5f5e9aae4f368ea36b169be83d9595bd", null, "edu" });

            migrationBuilder.InsertData(
                table: "Collaborators",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsDeleted", "Name", "UpdatedAt", "UserId" },
                values: new object[] { new Guid("5023590b-26eb-48bd-a7b8-9e452fb86975"), new DateTime(2024, 9, 10, 20, 15, 52, 395, DateTimeKind.Utc).AddTicks(1453), null, false, "Edu Brandão", null, new Guid("044f4a92-81b3-4038-8bd0-22a05edb91d6") });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "IsDeleted", "Name", "ProjectId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1ac1cfa0-5610-4838-8f05-5b764f67d2f9"), new DateTime(2024, 9, 10, 20, 15, 52, 395, DateTimeKind.Utc).AddTicks(1501), null, "Levantamento de Requisitos da demanda", false, "Levantamento de Requisitos", new Guid("866d9c4c-ba09-4ba9-83ea-c2974c5f0066"), null },
                    { new Guid("a252cbb8-09ad-48c8-acbb-de1dd83c2bfa"), new DateTime(2024, 9, 10, 20, 15, 52, 395, DateTimeKind.Utc).AddTicks(1545), null, "Desenvolver tela para cadastro de usuários", false, "Desenvolvimento atividade 1", new Guid("866d9c4c-ba09-4ba9-83ea-c2974c5f0066"), null },
                    { new Guid("f12780c9-6480-46ce-8fb8-304c853691a7"), new DateTime(2024, 9, 10, 20, 15, 52, 395, DateTimeKind.Utc).AddTicks(1523), null, "Analisando atividades da demanda", false, "Análise da demanada", new Guid("866d9c4c-ba09-4ba9-83ea-c2974c5f0066"), null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Collaborators",
                keyColumn: "Id",
                keyValue: new Guid("5023590b-26eb-48bd-a7b8-9e452fb86975"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("1ac1cfa0-5610-4838-8f05-5b764f67d2f9"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("a252cbb8-09ad-48c8-acbb-de1dd83c2bfa"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("f12780c9-6480-46ce-8fb8-304c853691a7"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("866d9c4c-ba09-4ba9-83ea-c2974c5f0066"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("044f4a92-81b3-4038-8bd0-22a05edb91d6"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "TimeTrackers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "TimeTrackers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

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
    }
}
