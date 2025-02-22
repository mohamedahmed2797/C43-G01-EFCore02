using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace C43_G01_EFCore02.Migrations
{
    /// <inheritdoc />
    public partial class createInsDeptTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Dep_Id",
                table: "Instructors",
                newName: "Dept_IdId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_Dept_IdId",
                table: "Instructors",
                column: "Dept_IdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_Dept_IdId",
                table: "Instructors",
                column: "Dept_IdId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_Dept_IdId",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_Dept_IdId",
                table: "Instructors");

            migrationBuilder.RenameColumn(
                name: "Dept_IdId",
                table: "Instructors",
                newName: "Dep_Id");
        }
    }
}
