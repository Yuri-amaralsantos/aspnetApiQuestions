using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace question_api.Migrations
{
    /// <inheritdoc />
    public partial class novo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuestoesAnonimas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Prompt = table.Column<string>(type: "TEXT", nullable: false),
                    Option1 = table.Column<string>(type: "TEXT", nullable: false),
                    Option2 = table.Column<string>(type: "TEXT", nullable: false),
                    Option3 = table.Column<string>(type: "TEXT", nullable: false),
                    Option4 = table.Column<string>(type: "TEXT", nullable: false),
                    Option5 = table.Column<string>(type: "TEXT", nullable: false),
                    CorrectAnswer = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestoesAnonimas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "QuestoesAnonimas",
                columns: new[] { "Id", "CorrectAnswer", "Option1", "Option2", "Option3", "Option4", "Option5", "Prompt" },
                values: new object[,]
                {
                    { new Guid("4f2a1272-a40e-4b8d-9db3-523d2c92485c"), 1, "Object", "Base", "Core", "System", "Root", "Qual é a classe base para todas as classes no .NET?" },
                    { new Guid("704c4a7b-0c0d-4cc0-bbe7-3ad0aead54a7"), 2, "null", "void", "empty", "none", "nil", "Qual palavra-chave é usada para definir um método que não retorna valor?" },
                    { new Guid("bc6afd20-75d1-4a07-9cf8-4c817b9955ad"), 1, "Garbage Collector", "Memory Allocator", "Memory Manager", "Heap Manager", "Stack Manager", "Qual das seguintes opções é usada para gerenciar a memória no .NET?" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuestoesAnonimas");
        }
    }
}
