using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FacultyInformationSystemWebAPI.Migrations.FIS_DB
{
    public partial class MyDbMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DeptID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeptName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Dept_ID_PK", x => x.DeptID);
                });

            migrationBuilder.CreateTable(
                name: "Designation",
                columns: table => new
                {
                    DesignationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesignationName = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designation", x => x.DesignationID);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    SubjectID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectName = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.SubjectID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    UserPassword = table.Column<byte[]>(type: "binary(16)", fixedLength: true, maxLength: 16, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    CourseCredits = table.Column<int>(type: "int", nullable: false),
                    DeptID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseID);
                    table.ForeignKey(
                        name: "Department_Course_ID_FK",
                        column: x => x.DeptID,
                        principalTable: "Department",
                        principalColumn: "DeptID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Faculty",
                columns: table => new
                {
                    FacultyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    FacultyAddress = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: false),
                    City = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    Faculty_State = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    Pincode = table.Column<int>(type: "int", nullable: false),
                    MobileNo = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    HireDate = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    EmailAddress = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    DateOfBirth = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    DeptID = table.Column<int>(type: "int", nullable: true),
                    DesignationID = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculty", x => x.FacultyID);
                    table.ForeignKey(
                        name: "Dept_Faculty_FK",
                        column: x => x.DeptID,
                        principalTable: "Department",
                        principalColumn: "DeptID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Designation_Faculty_FK",
                        column: x => x.DesignationID,
                        principalTable: "Designation",
                        principalColumn: "DesignationID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CourseSubject",
                columns: table => new
                {
                    CourseSubjectID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseID = table.Column<int>(type: "int", nullable: false),
                    SubjectID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseSubject", x => x.CourseSubjectID);
                    table.ForeignKey(
                        name: "CourseSubject_CourseID_FK",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "CourseSubject_SubjectID_FK",
                        column: x => x.SubjectID,
                        principalTable: "Subjects",
                        principalColumn: "SubjectID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CourseTaught",
                columns: table => new
                {
                    CourseTaughtID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseID = table.Column<int>(type: "int", nullable: false),
                    FacultyID = table.Column<int>(type: "int", nullable: false),
                    SubjectID = table.Column<int>(type: "int", nullable: false),
                    FirstDateTaught = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseTaught", x => x.CourseTaughtID);
                    table.ForeignKey(
                        name: "Courses_Course_ID_CourseTaught_FK",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "CourseTaught_FacultyID_FK",
                        column: x => x.FacultyID,
                        principalTable: "Faculty",
                        principalColumn: "FacultyID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "CourseTaught_SubjectID_FK",
                        column: x => x.SubjectID,
                        principalTable: "Subjects",
                        principalColumn: "SubjectID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Faculty_Degrees",
                columns: table => new
                {
                    DegreeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacultyID = table.Column<int>(type: "int", nullable: true),
                    Degree = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Specialization = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    DegreeYear = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Faculty_Degrees_ID_PK", x => x.DegreeID);
                    table.ForeignKey(
                        name: "Degree_FacultyID_FK",
                        column: x => x.FacultyID,
                        principalTable: "Faculty",
                        principalColumn: "FacultyID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Grants",
                columns: table => new
                {
                    GrantID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacultyID = table.Column<int>(type: "int", nullable: true),
                    GrantTitle = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    GrantDescription = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grants", x => x.GrantID);
                    table.ForeignKey(
                        name: "Faculty_Grants_FK",
                        column: x => x.FacultyID,
                        principalTable: "Faculty",
                        principalColumn: "FacultyID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Publications",
                columns: table => new
                {
                    PublicationID = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    FacultyID = table.Column<int>(type: "int", nullable: false),
                    PublicationTitle = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ArticleName = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: false),
                    PublisherName = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: false),
                    PublicationLocation = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CitationDate = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publications", x => x.PublicationID);
                    table.ForeignKey(
                        name: "Faculty_ID_FK",
                        column: x => x.FacultyID,
                        principalTable: "Faculty",
                        principalColumn: "FacultyID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WorkHistory",
                columns: table => new
                {
                    WorkHistoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacultyID = table.Column<int>(type: "int", nullable: false),
                    Organization = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    JobTitle = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: true),
                    JobBeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    JobEndDate = table.Column<DateTime>(type: "date", nullable: true),
                    JobResponsibilities = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    JobType = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkHistory", x => x.WorkHistoryID);
                    table.ForeignKey(
                        name: "Faculty_Work_ID_FK",
                        column: x => x.FacultyID,
                        principalTable: "Faculty",
                        principalColumn: "FacultyID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_DeptID",
                table: "Courses",
                column: "DeptID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSubject_CourseID",
                table: "CourseSubject",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSubject_SubjectID",
                table: "CourseSubject",
                column: "SubjectID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseTaught_CourseID",
                table: "CourseTaught",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseTaught_FacultyID",
                table: "CourseTaught",
                column: "FacultyID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseTaught_SubjectID",
                table: "CourseTaught",
                column: "SubjectID");

            migrationBuilder.CreateIndex(
                name: "IX_Faculty_DeptID",
                table: "Faculty",
                column: "DeptID");

            migrationBuilder.CreateIndex(
                name: "IX_Faculty_DesignationID",
                table: "Faculty",
                column: "DesignationID");

            migrationBuilder.CreateIndex(
                name: "UQ__Faculty__D6D73A8638616B3E",
                table: "Faculty",
                column: "MobileNo",
                unique: true,
                filter: "[MobileNo] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Faculty_Degrees_FacultyID",
                table: "Faculty_Degrees",
                column: "FacultyID");

            migrationBuilder.CreateIndex(
                name: "IX_Grants_FacultyID",
                table: "Grants",
                column: "FacultyID");

            migrationBuilder.CreateIndex(
                name: "IX_Publications_FacultyID",
                table: "Publications",
                column: "FacultyID");

            migrationBuilder.CreateIndex(
                name: "UQ__Users__C9F2845684AB4D4C",
                table: "Users",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkHistory_FacultyID",
                table: "WorkHistory",
                column: "FacultyID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseSubject");

            migrationBuilder.DropTable(
                name: "CourseTaught");

            migrationBuilder.DropTable(
                name: "Faculty_Degrees");

            migrationBuilder.DropTable(
                name: "Grants");

            migrationBuilder.DropTable(
                name: "Publications");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "WorkHistory");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Faculty");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Designation");
        }
    }
}
