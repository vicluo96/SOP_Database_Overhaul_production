using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class schl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "veteran",
                table: "studentdetail",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(sbyte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "ushp",
                table: "studentdetail",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(sbyte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "usCitizen",
                table: "studentdetail",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(sbyte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "urop",
                table: "studentdetail",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(sbyte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "sage",
                table: "studentdetail",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(sbyte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "pbk",
                table: "studentdetail",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(sbyte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "paa",
                table: "studentdetail",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(sbyte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "lowIncome",
                table: "studentdetail",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(sbyte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "larc",
                table: "studentdetail",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(sbyte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "honorProg",
                table: "studentdetail",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(sbyte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "chc",
                table: "studentdetail",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(sbyte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "asuci",
                table: "studentdetail",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(sbyte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "age",
                table: "studentbasic",
                type: "tinyint unsigned",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "prepStatus",
                table: "advising",
                type: "varchar(10)",
                maxLength: 10,
                nullable: true,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldMaxLength: 10)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "orienT10",
                table: "advising",
                type: "varchar(10)",
                maxLength: 10,
                nullable: true,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldMaxLength: 10)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "orienE11",
                table: "advising",
                type: "varchar(10)",
                maxLength: 10,
                nullable: true,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldMaxLength: 10)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "colleges",
                columns: table => new
                {
                    collegeID = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    studentbasic_studentID = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    collegeName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    gpa = table.Column<decimal>(type: "decimal(3,2)", precision: 3, scale: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.collegeID, x.studentbasic_studentID })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                    table.ForeignKey(
                        name: "fk_colleges_studentbasic1",
                        column: x => x.studentbasic_studentID,
                        principalTable: "studentbasic",
                        principalColumn: "studentID");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "majors",
                columns: table => new
                {
                    majorID = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    studentbasic_studentID = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    majorName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.majorID, x.studentbasic_studentID })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                    table.ForeignKey(
                        name: "fk_majors_studentbasic1",
                        column: x => x.studentbasic_studentID,
                        principalTable: "studentbasic",
                        principalColumn: "studentID");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "minors",
                columns: table => new
                {
                    minorID = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    studentbasic_studentID = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    minorName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.minorID, x.studentbasic_studentID })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                    table.ForeignKey(
                        name: "fk_minors_studentbasic1",
                        column: x => x.studentbasic_studentID,
                        principalTable: "studentbasic",
                        principalColumn: "studentID");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "questions",
                columns: table => new
                {
                    questionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    questionText = table.Column<string>(type: "varchar(1500)", maxLength: 1500, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    t10ORe11 = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.questionID);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "QuestionScholarship",
                columns: table => new
                {
                    QuestionsQuestionId = table.Column<int>(type: "int", nullable: false),
                    ScholarshipsScholId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionScholarship", x => new { x.QuestionsQuestionId, x.ScholarshipsScholId });
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "recommenders",
                columns: table => new
                {
                    recomID = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    studentbasic_studentID = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    recommender = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cycle = table.Column<string>(type: "varchar(3)", maxLength: 3, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.recomID, x.studentbasic_studentID })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                    table.ForeignKey(
                        name: "fk_recommenders_studentbasic1",
                        column: x => x.studentbasic_studentID,
                        principalTable: "studentbasic",
                        principalColumn: "studentID");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "results",
                columns: table => new
                {
                    resultID = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    studentbasic_studentID = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    curStatus = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sopProfile = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    sopSurvey = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.resultID, x.studentbasic_studentID })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                    table.ForeignKey(
                        name: "fk_results_studentbasic1",
                        column: x => x.studentbasic_studentID,
                        principalTable: "studentbasic",
                        principalColumn: "studentID");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "scholarships",
                columns: table => new
                {
                    scholID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    scholName = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.scholID);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "ScholarshipStudentbasic",
                columns: table => new
                {
                    ScholarshipsScholId = table.Column<int>(type: "int", nullable: false),
                    StudentbasicStudentId = table.Column<string>(type: "varchar(255)", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScholarshipStudentbasic", x => new { x.ScholarshipsScholId, x.StudentbasicStudentId });
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "questionResponse",
                columns: table => new
                {
                    questions_questionID = table.Column<int>(type: "int", nullable: false),
                    studentbasic_studentID = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    responseText = table.Column<string>(type: "mediumtext", nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.questions_questionID, x.studentbasic_studentID })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                    table.ForeignKey(
                        name: "fk_questionResponse_questions1",
                        column: x => x.questions_questionID,
                        principalTable: "questions",
                        principalColumn: "questionID");
                    table.ForeignKey(
                        name: "fk_questionResponse_studentbasic1",
                        column: x => x.studentbasic_studentID,
                        principalTable: "studentbasic",
                        principalColumn: "studentID");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "questionCorrespond",
                columns: table => new
                {
                    scholarships_scholID = table.Column<int>(type: "int", nullable: false),
                    questions_questionID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.scholarships_scholID, x.questions_questionID })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                    table.ForeignKey(
                        name: "fk_questionCorrespond_questions1",
                        column: x => x.questions_questionID,
                        principalTable: "questions",
                        principalColumn: "questionID");
                    table.ForeignKey(
                        name: "fk_questionCorrespond_scholarships1",
                        column: x => x.scholarships_scholID,
                        principalTable: "scholarships",
                        principalColumn: "scholID");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "scholarSelection",
                columns: table => new
                {
                    studentbasic_studentID = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    scholarships_scholID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.studentbasic_studentID, x.scholarships_scholID })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                    table.ForeignKey(
                        name: "fk_e11_has_studentbasic_studentbasic1",
                        column: x => x.studentbasic_studentID,
                        principalTable: "studentbasic",
                        principalColumn: "studentID");
                    table.ForeignKey(
                        name: "fk_questionSelection_scholarships1",
                        column: x => x.scholarships_scholID,
                        principalTable: "scholarships",
                        principalColumn: "scholID");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateIndex(
                name: "studentID_UNIQUE",
                table: "studentbasic",
                column: "studentID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "e11ID_UNIQUE",
                table: "colleges",
                column: "collegeID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_colleges_studentbasic1",
                table: "colleges",
                column: "studentbasic_studentID");

            migrationBuilder.CreateIndex(
                name: "fk_majors_studentbasic1",
                table: "majors",
                column: "studentbasic_studentID");

            migrationBuilder.CreateIndex(
                name: "majorID_UNIQUE",
                table: "majors",
                column: "majorID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_minors_studentbasic1",
                table: "minors",
                column: "studentbasic_studentID");

            migrationBuilder.CreateIndex(
                name: "majorID_UNIQUE1",
                table: "minors",
                column: "minorID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_questionCorrespond_questions1",
                table: "questionCorrespond",
                column: "questions_questionID");

            migrationBuilder.CreateIndex(
                name: "fk_questionResponse_studentbasic1",
                table: "questionResponse",
                column: "studentbasic_studentID");

            migrationBuilder.CreateIndex(
                name: "questionID_UNIQUE",
                table: "questions",
                column: "questionID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_recommenders_studentbasic1",
                table: "recommenders",
                column: "studentbasic_studentID");

            migrationBuilder.CreateIndex(
                name: "recomID_UNIQUE",
                table: "recommenders",
                column: "recomID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_results_studentbasic1",
                table: "results",
                column: "studentbasic_studentID");

            migrationBuilder.CreateIndex(
                name: "resultID_UNIQUE",
                table: "results",
                column: "resultID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_questionSelection_scholarships1",
                table: "scholarSelection",
                column: "scholarships_scholID");

            migrationBuilder.CreateIndex(
                name: "e11ID_UNIQUE1",
                table: "scholarships",
                column: "scholID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "colleges");

            migrationBuilder.DropTable(
                name: "majors");

            migrationBuilder.DropTable(
                name: "minors");

            migrationBuilder.DropTable(
                name: "questionCorrespond");

            migrationBuilder.DropTable(
                name: "questionResponse");

            migrationBuilder.DropTable(
                name: "QuestionScholarship");

            migrationBuilder.DropTable(
                name: "recommenders");

            migrationBuilder.DropTable(
                name: "results");

            migrationBuilder.DropTable(
                name: "scholarSelection");

            migrationBuilder.DropTable(
                name: "ScholarshipStudentbasic");

            migrationBuilder.DropTable(
                name: "questions");

            migrationBuilder.DropTable(
                name: "scholarships");

            migrationBuilder.DropIndex(
                name: "studentID_UNIQUE",
                table: "studentbasic");

            migrationBuilder.DropColumn(
                name: "age",
                table: "studentbasic");

            migrationBuilder.AlterColumn<sbyte>(
                name: "veteran",
                table: "studentdetail",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<sbyte>(
                name: "ushp",
                table: "studentdetail",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<sbyte>(
                name: "usCitizen",
                table: "studentdetail",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<sbyte>(
                name: "urop",
                table: "studentdetail",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<sbyte>(
                name: "sage",
                table: "studentdetail",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<sbyte>(
                name: "pbk",
                table: "studentdetail",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<sbyte>(
                name: "paa",
                table: "studentdetail",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<sbyte>(
                name: "lowIncome",
                table: "studentdetail",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<sbyte>(
                name: "larc",
                table: "studentdetail",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<sbyte>(
                name: "honorProg",
                table: "studentdetail",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<sbyte>(
                name: "chc",
                table: "studentdetail",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<sbyte>(
                name: "asuci",
                table: "studentdetail",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "advising",
                keyColumn: "prepStatus",
                keyValue: null,
                column: "prepStatus",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "prepStatus",
                table: "advising",
                type: "varchar(10)",
                maxLength: 10,
                nullable: false,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldMaxLength: 10,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.UpdateData(
                table: "advising",
                keyColumn: "orienT10",
                keyValue: null,
                column: "orienT10",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "orienT10",
                table: "advising",
                type: "varchar(10)",
                maxLength: 10,
                nullable: false,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldMaxLength: 10,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.UpdateData(
                table: "advising",
                keyColumn: "orienE11",
                keyValue: null,
                column: "orienE11",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "orienE11",
                table: "advising",
                type: "varchar(10)",
                maxLength: 10,
                nullable: false,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldMaxLength: 10,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");
        }
    }
}
