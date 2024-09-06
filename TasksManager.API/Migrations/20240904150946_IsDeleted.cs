using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TasksManager.API.Migrations
{
    /// <inheritdoc />
    public partial class IsDeleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Collaborators",
                keyColumn: "Id",
                keyValue: new Guid("de9ba586-4947-453b-be89-14f541b85a2f"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("20a71112-6939-49b3-b941-b23a94af5be1"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("88f60560-f3c4-47f0-b1da-23c1c80069a8"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("99403190-e7fb-44f1-a904-6d63603c0dbd"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("2da4b9ee-53c2-43f5-b9ac-c468cfeff187"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a1a4c3f8-a06f-446c-8c10-75493ea27034"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TimeTrackers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Tasks",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Projects",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Collaborators",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[] { new Guid("9f2c6fbc-1bbb-48c1-9b53-c84e8b58cec9"), new DateTime(2024, 9, 4, 15, 9, 45, 922, DateTimeKind.Utc).AddTicks(8), null, false, "Projeto Validações", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsDeleted", "Password", "UpdatedAt", "UserName" },
                values: new object[] { new Guid("4f3c7efd-fca5-4469-b0a0-bff6236c4040"), new DateTime(2024, 9, 4, 15, 9, 45, 921, DateTimeKind.Utc).AddTicks(9819), null, false, "123@Test", null, "Edu Brandão" });

            migrationBuilder.InsertData(
                table: "Collaborators",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsDeleted", "Name", "UpdatedAt", "UserId" },
                values: new object[] { new Guid("dfaeee36-623b-4ec5-af23-b15f4cf87b6d"), new DateTime(2024, 9, 4, 15, 9, 45, 921, DateTimeKind.Utc).AddTicks(9988), null, false, "Edu Brandão", null, new Guid("4f3c7efd-fca5-4469-b0a0-bff6236c4040") });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "IsDeleted", "Name", "ProjectId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("7138dcdc-8c23-463d-953e-e4289627833c"), new DateTime(2024, 9, 4, 15, 9, 45, 922, DateTimeKind.Utc).AddTicks(63), null, "Desenvolver tela para cadastro de usuários", false, "Desenvolvimento atividade 1", new Guid("9f2c6fbc-1bbb-48c1-9b53-c84e8b58cec9"), null },
                    { new Guid("9d98439f-30b6-43fc-b302-a60fb3561657"), new DateTime(2024, 9, 4, 15, 9, 45, 922, DateTimeKind.Utc).AddTicks(45), null, "Analisando atividades da demanda", false, "Análise da demanada", new Guid("9f2c6fbc-1bbb-48c1-9b53-c84e8b58cec9"), null },
                    { new Guid("acd96614-b660-4a01-924d-3b464caa2ec3"), new DateTime(2024, 9, 4, 15, 9, 45, 922, DateTimeKind.Utc).AddTicks(29), null, "Levantamento de Requisitos da demanda", false, "Levantamento de Requisitos", new Guid("9f2c6fbc-1bbb-48c1-9b53-c84e8b58cec9"), null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Collaborators",
                keyColumn: "Id",
                keyValue: new Guid("dfaeee36-623b-4ec5-af23-b15f4cf87b6d"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("7138dcdc-8c23-463d-953e-e4289627833c"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("9d98439f-30b6-43fc-b302-a60fb3561657"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("acd96614-b660-4a01-924d-3b464caa2ec3"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("9f2c6fbc-1bbb-48c1-9b53-c84e8b58cec9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4f3c7efd-fca5-4469-b0a0-bff6236c4040"));

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TimeTrackers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Collaborators");

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("2da4b9ee-53c2-43f5-b9ac-c468cfeff187"), new DateTime(2024, 9, 4, 14, 37, 35, 86, DateTimeKind.Utc).AddTicks(52), null, "Projeto Validações", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Password", "UpdatedAt", "UserName" },
                values: new object[] { new Guid("a1a4c3f8-a06f-446c-8c10-75493ea27034"), new DateTime(2024, 9, 4, 14, 37, 35, 85, DateTimeKind.Utc).AddTicks(9890), null, "123@Test", null, "Edu Brandão" });

            migrationBuilder.InsertData(
                table: "Collaborators",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "UpdatedAt", "UserId" },
                values: new object[] { new Guid("de9ba586-4947-453b-be89-14f541b85a2f"), new DateTime(2024, 9, 4, 14, 37, 35, 86, DateTimeKind.Utc).AddTicks(31), null, "Edu Brandão", null, new Guid("a1a4c3f8-a06f-446c-8c10-75493ea27034") });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "Name", "ProjectId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("20a71112-6939-49b3-b941-b23a94af5be1"), new DateTime(2024, 9, 4, 14, 37, 35, 86, DateTimeKind.Utc).AddTicks(77), null, "Levantamento de Requisitos da demanda", "Levantamento de Requisitos", new Guid("2da4b9ee-53c2-43f5-b9ac-c468cfeff187"), null },
                    { new Guid("88f60560-f3c4-47f0-b1da-23c1c80069a8"), new DateTime(2024, 9, 4, 14, 37, 35, 86, DateTimeKind.Utc).AddTicks(121), null, "Desenvolver tela para cadastro de usuários", "Desenvolvimento atividade 1", new Guid("2da4b9ee-53c2-43f5-b9ac-c468cfeff187"), null },
                    { new Guid("99403190-e7fb-44f1-a904-6d63603c0dbd"), new DateTime(2024, 9, 4, 14, 37, 35, 86, DateTimeKind.Utc).AddTicks(101), null, "Analisando atividades da demanda", "Análise da demanada", new Guid("2da4b9ee-53c2-43f5-b9ac-c468cfeff187"), null }
                });
        }
    }
}
