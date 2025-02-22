using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace C43_G01_EFCore02.Migrations
{
    /// <inheritdoc />
    public partial class createTopCourseTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Top_Id",
                table: "courses",
                newName: "Top_IdId");

            migrationBuilder.CreateIndex(
                name: "IX_courses_Top_IdId",
                table: "courses",
                column: "Top_IdId");

            migrationBuilder.AddForeignKey(
                name: "FK_courses_Topics_Top_IdId",
                table: "courses",
                column: "Top_IdId",
                principalTable: "Topics",
                principalColumn: "Topic_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_courses_Topics_Top_IdId",
                table: "courses");

            migrationBuilder.DropIndex(
                name: "IX_courses_Top_IdId",
                table: "courses");

            migrationBuilder.RenameColumn(
                name: "Top_IdId",
                table: "courses",
                newName: "Top_Id");
        }
    }
}
