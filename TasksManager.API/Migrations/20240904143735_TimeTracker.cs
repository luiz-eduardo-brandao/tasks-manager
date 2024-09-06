using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TasksManager.API.Migrations
{
    /// <inheritdoc />
    public partial class TimeTracker : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Collaborators",
                keyColumn: "Id",
                keyValue: new Guid("277c966a-d6ae-42c2-9c8d-08d03aff68b1"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("3fa52e58-2dea-4951-9812-0c6f637f3714"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("5395e9ad-81ef-46fe-a2dc-21f0f13ef9b2"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("7391bfbd-d2be-460b-b070-d7a0fc441177"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("3c68374c-dcad-471e-b20a-6ac88f4a4d45"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("465191a0-6a17-49eb-a234-3068bc13af19"));

            migrationBuilder.CreateTable(
                name: "TimeTrackers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeZoneId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TaskId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CollaboratorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TaskModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeTrackers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TimeTrackers_Collaborators_CollaboratorId",
                        column: x => x.CollaboratorId,
                        principalTable: "Collaborators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TimeTrackers_Tasks_TaskModelId",
                        column: x => x.TaskModelId,
                        principalTable: "Tasks",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_TimeTrackers_CollaboratorId",
                table: "TimeTrackers",
                column: "CollaboratorId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeTrackers_TaskModelId",
                table: "TimeTrackers",
                column: "TaskModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TimeTrackers");

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

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("3c68374c-dcad-471e-b20a-6ac88f4a4d45"), new DateTime(2024, 9, 4, 14, 29, 35, 304, DateTimeKind.Utc).AddTicks(6608), null, "Projeto Validações", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Password", "UpdatedAt", "UserName" },
                values: new object[] { new Guid("465191a0-6a17-49eb-a234-3068bc13af19"), new DateTime(2024, 9, 4, 14, 29, 35, 304, DateTimeKind.Utc).AddTicks(6458), null, "123@Test", null, "Edu Brandão" });

            migrationBuilder.InsertData(
                table: "Collaborators",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "UpdatedAt", "UserId" },
                values: new object[] { new Guid("277c966a-d6ae-42c2-9c8d-08d03aff68b1"), new DateTime(2024, 9, 4, 14, 29, 35, 304, DateTimeKind.Utc).AddTicks(6580), null, "Edu Brandão", null, new Guid("465191a0-6a17-49eb-a234-3068bc13af19") });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "Name", "ProjectId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("3fa52e58-2dea-4951-9812-0c6f637f3714"), new DateTime(2024, 9, 4, 14, 29, 35, 304, DateTimeKind.Utc).AddTicks(6639), null, "Analisando atividades da demanda", "Análise da demanada", new Guid("3c68374c-dcad-471e-b20a-6ac88f4a4d45"), null },
                    { new Guid("5395e9ad-81ef-46fe-a2dc-21f0f13ef9b2"), new DateTime(2024, 9, 4, 14, 29, 35, 304, DateTimeKind.Utc).AddTicks(6652), null, "Desenvolver tela para cadastro de usuários", "Desenvolvimento atividade 1", new Guid("3c68374c-dcad-471e-b20a-6ac88f4a4d45"), null },
                    { new Guid("7391bfbd-d2be-460b-b070-d7a0fc441177"), new DateTime(2024, 9, 4, 14, 29, 35, 304, DateTimeKind.Utc).AddTicks(6624), null, "Levantamento de Requisitos da demanda", "Levantamento de Requisitos", new Guid("3c68374c-dcad-471e-b20a-6ac88f4a4d45"), null }
                });
        }
    }
}
