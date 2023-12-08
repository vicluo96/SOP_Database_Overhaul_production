using System;
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
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

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
                name: "studentbasic",
                columns: table => new
                {
                    studentID = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    legalFirstName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    legalLastName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    preferredFirstName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pronouns = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    personalEmail = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phoneNumber = table.Column<string>(type: "varchar(21)", maxLength: 21, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    uciGPA = table.Column<decimal>(type: "decimal(3,2)", precision: 3, scale: 2, nullable: true),
                    age = table.Column<byte>(type: "tinyint unsigned", nullable: true),
                    submitTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.studentID);
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
                name: "advising",
                columns: table => new
                {
                    prepID = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    studentbasic_studentID = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    prepStatus = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    orienT10 = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    orienE11 = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    adviserName = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CEWCName = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    paAppNo = table.Column<byte>(type: "tinyint unsigned", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.prepID, x.studentbasic_studentID })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                    table.ForeignKey(
                        name: "fk_advising_studentbasic1",
                        column: x => x.studentbasic_studentID,
                        principalTable: "studentbasic",
                        principalColumn: "studentID");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

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
                    minorName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8mb4_0900_ai_ci")
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
                name: "recommenders",
                columns: table => new
                {
                    recomID = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    studentbasic_studentID = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    recommender = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, collation: "utf8mb4_0900_ai_ci")
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

            migrationBuilder.CreateTable(
                name: "studentdetail",
                columns: table => new
                {
                    detailID = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    studentbasic_studentID = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    gradYear = table.Column<short>(type: "year", nullable: false),
                    serveExpMon = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: true),
                    leadExpMon = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: true),
                    usCitizen = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    tranStu = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    lowIncome = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    pbk = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    chc = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    urop = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ushp = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    honorProg = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    sage = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    honorProgPrev = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    paa = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    larc = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    asuci = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    veteran = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    highDegree = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.detailID, x.studentbasic_studentID })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                    table.ForeignKey(
                        name: "fk_studentdetail_studentbasic1",
                        column: x => x.studentbasic_studentID,
                        principalTable: "studentbasic",
                        principalColumn: "studentID");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "documents",
                columns: table => new
                {
                    documentID = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    advising_prepID = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    advising_studentbasic_studentID = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    consentForm = table.Column<string>(type: "mediumtext", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    transcript = table.Column<string>(type: "mediumtext", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cv = table.Column<string>(type: "mediumtext", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.documentID, x.advising_prepID, x.advising_studentbasic_studentID })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
                    table.ForeignKey(
                        name: "fk_documents_advising1",
                        columns: x => new { x.advising_prepID, x.advising_studentbasic_studentID },
                        principalTable: "advising",
                        principalColumns: new[] { "prepID", "studentbasic_studentID" });
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateIndex(
                name: "fk_advising_studentbasic1",
                table: "advising",
                column: "studentbasic_studentID");

            migrationBuilder.CreateIndex(
                name: "prepID_UNIQUE",
                table: "advising",
                column: "prepID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_colleges_studentbasic1",
                table: "colleges",
                column: "studentbasic_studentID");

            migrationBuilder.CreateIndex(
                name: "documentID_UNIQUE",
                table: "documents",
                column: "documentID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_documents_advising1",
                table: "documents",
                columns: new[] { "advising_prepID", "advising_studentbasic_studentID" });

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
                name: "e11ID_UNIQUE",
                table: "scholarships",
                column: "scholID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "studentID_UNIQUE",
                table: "studentbasic",
                column: "studentID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "detailId_UNIQUE",
                table: "studentdetail",
                column: "detailID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_studentdetail_studentbasic1",
                table: "studentdetail",
                column: "studentbasic_studentID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "colleges");

            migrationBuilder.DropTable(
                name: "documents");

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
                name: "studentdetail");

            migrationBuilder.DropTable(
                name: "advising");

            migrationBuilder.DropTable(
                name: "questions");

            migrationBuilder.DropTable(
                name: "scholarships");

            migrationBuilder.DropTable(
                name: "studentbasic");
        }
    }
}
