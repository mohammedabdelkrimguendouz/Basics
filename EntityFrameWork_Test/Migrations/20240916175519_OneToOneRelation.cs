using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameWork_Test.Migrations
{
    /// <inheritdoc />
    public partial class OneToOneRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Grade",
                table: "Students");

            migrationBuilder.AddColumn<int>(
                name: "GradeID",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Students_GradeID",
                table: "Students",
                column: "GradeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Grades_GradeID",
                table: "Students",
                column: "GradeID",
                principalTable: "Grades",
                principalColumn: "GradeID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Grades_GradeID",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_GradeID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "GradeID",
                table: "Students");

            migrationBuilder.AddColumn<short>(
                name: "Grade",
                table: "Students",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);
        }
    }
}
