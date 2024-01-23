using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace course.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CourseNumber = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CourseName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CourseDescription = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.CourseId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Instructor",
                columns: table => new
                {
                    InstructorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailAddress = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CourseTeach = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructor", x => x.InstructorId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Phone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    courseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Student_Course_courseId",
                        column: x => x.courseId,
                        principalTable: "Course",
                        principalColumn: "CourseId");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseId", "CourseDescription", "CourseName", "CourseNumber" },
                values: new object[,]
                {
                    { 211, "Accounting Courses detials", "Accounting I", "ACCT" },
                    { 212, "Accounting Courses details", "Accounting II", "ACCT" },
                    { 220, "Database and implemetation course details", "Database Design and Implementation", "CIS" },
                    { 261, "Intro to Statistics details", "Intro to Statistics", "CIS " },
                    { 362, "Statistical Applications", "Statistical Applications", "CIS" }
                });

            migrationBuilder.InsertData(
                table: "Instructor",
                columns: new[] { "InstructorId", "CourseTeach", "EmailAddress", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 103, "CIS", "John@gmail.com", "John", "Job" },
                    { 104, "ACCT", "Willam@gmail.com", "willam", "John" },
                    { 105, "CIS", "xxxYYY@gmail.com", "xxx", "yyy" },
                    { 106, "ACCT", "abcdef@gmail.com", "abc", "def" },
                    { 107, "CIS", "pqrstr@gmail.com", "pqr", "stu" }
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Email", "FirstName", "LastName", "Phone", "courseId" },
                values: new object[,]
                {
                    { 400, "Johu@gmail.com", "Johu", "Job", "403-222-3222", null },
                    { 401, "brewer@gmail.com", "Brewer", "Juliette", "403-354-2321", null },
                    { 402, "john@gmail.com", "John", "Smith", "403-342-3432", null },
                    { 403, "robertson@gmail.com", "Robertson", "Gerald", "403-322-2322", null },
                    { 404, "robertson@gmail.com", "Robertson", "Gerald", "403-322-2322", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Student_courseId",
                table: "Student",
                column: "courseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Instructor");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Course");
        }
    }
}
