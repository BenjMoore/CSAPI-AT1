using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AT1__PerfectPolicy_.Migrations
{
    public partial class ChangedEntityNameforQuizQuestionCountReport : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Quizs",
                keyColumn: "QuizID",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 5, 13, 13, 5, 2, 800, DateTimeKind.Local).AddTicks(5592));

            migrationBuilder.UpdateData(
                table: "Quizs",
                keyColumn: "QuizID",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 5, 13, 13, 5, 2, 801, DateTimeKind.Local).AddTicks(2464));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Quizs",
                keyColumn: "QuizID",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 5, 13, 11, 58, 55, 422, DateTimeKind.Local).AddTicks(7159));

            migrationBuilder.UpdateData(
                table: "Quizs",
                keyColumn: "QuizID",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 5, 13, 11, 58, 55, 423, DateTimeKind.Local).AddTicks(4886));
        }
    }
}
