using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TasksManager.API.Migrations
{
    /// <inheritdoc />
    public partial class ProjectsAndTasks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Collaborators",
                keyColumn: "Id",
                keyValue: new Guid("836a71ac-dce0-42f5-842a-47bdcf97e0cc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("92ade701-9811-4344-b864-594755224980"));

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tasks_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_ProjectId",
                table: "Tasks",
                column: "ProjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DeleteData(
                table: "Collaborators",
                keyColumn: "Id",
                keyValue: new Guid("277c966a-d6ae-42c2-9c8d-08d03aff68b1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("465191a0-6a17-49eb-a234-3068bc13af19"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Password", "UpdatedAt", "UserName" },
                values: new object[] { new Guid("92ade701-9811-4344-b864-594755224980"), new DateTime(2024, 9, 4, 14, 19, 51, 521, DateTimeKind.Utc).AddTicks(6054), null, "123@Test", null, "Edu Brandão" });

            migrationBuilder.InsertData(
                table: "Collaborators",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "UpdatedAt", "UserId" },
                values: new object[] { new Guid("836a71ac-dce0-42f5-842a-47bdcf97e0cc"), new DateTime(2024, 9, 4, 14, 19, 51, 521, DateTimeKind.Utc).AddTicks(6185), null, "Edu Brandão", null, new Guid("92ade701-9811-4344-b864-594755224980") });
        }
    }
}
