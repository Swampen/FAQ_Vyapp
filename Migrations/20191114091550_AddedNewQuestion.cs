using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace FAQ_Vyapp.Migrations
{
    public partial class AddedNewQuestion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NewQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Question = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewQuestions", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "NewQuestions",
                columns: new[] { "Id", "Date", "Email", "Name", "Question" },
                values: new object[] { 1, new DateTime(2019, 11, 14, 10, 15, 50, 372, DateTimeKind.Local).AddTicks(5124), "email@example.com", "Ola Normann", "How can I find my ticket after the purchase?" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NewQuestions");
        }
    }
}
