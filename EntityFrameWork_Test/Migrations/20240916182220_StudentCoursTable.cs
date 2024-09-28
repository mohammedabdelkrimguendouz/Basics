using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameWork_Test.Migrations
{
    /// <inheritdoc />
    public partial class StudentCoursTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentsCourses",
                columns: table => new
                {
                    StudentCoursID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    CoursID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsCourses", x => x.StudentCoursID);
                    table.ForeignKey(
                        name: "FK_StudentsCourses_Courses_CoursID",
                        column: x => x.CoursID,
                        principalTable: "Courses",
                        principalColumn: "CoursID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentsCourses_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentsCourses_CoursID",
                table: "StudentsCourses",
                column: "CoursID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsCourses_StudentID",
                table: "StudentsCourses",
                column: "StudentID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentsCourses");
        }
    }
}
