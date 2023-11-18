using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialT : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "advising",
                columns: table => new
                {
                    prepID = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    prepStatus = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    orienT10 = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    orienE11 = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    paAppNo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.prepID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "studentdetail",
                columns: table => new
                {
                    detailId = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    studentID = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    gradYear = table.Column<short>(type: "year", nullable: true),
                    serveExpMon = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: true),
                    leadExpMon = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: true),
                    usCitizen = table.Column<sbyte>(type: "tinyint", nullable: true),
                    tranStu = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    lowIncome = table.Column<sbyte>(type: "tinyint", nullable: true),
                    pbk = table.Column<sbyte>(type: "tinyint", nullable: true),
                    chc = table.Column<sbyte>(type: "tinyint", nullable: true),
                    urop = table.Column<sbyte>(type: "tinyint", nullable: true),
                    ushp = table.Column<sbyte>(type: "tinyint", nullable: true),
                    honorProg = table.Column<sbyte>(type: "tinyint", nullable: true),
                    sage = table.Column<sbyte>(type: "tinyint", nullable: true),
                    paa = table.Column<sbyte>(type: "tinyint", nullable: true),
                    larc = table.Column<sbyte>(type: "tinyint", nullable: true),
                    asuci = table.Column<sbyte>(type: "tinyint", nullable: true),
                    veteran = table.Column<sbyte>(type: "tinyint", nullable: true),
                    highDegree = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    consentForm = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    transcript = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cv = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.detailId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "studentbasic",
                columns: table => new
                {
                    studentID = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    studentdetail_detailId = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    advising_prepID = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    legalFirstName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    legalLastName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    preferredFirstName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pronouns = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PersonalEmail = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phoneNumber = table.Column<string>(type: "varchar(14)", maxLength: 14, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    uciGPA = table.Column<decimal>(type: "decimal(3,2)", precision: 3, scale: 2, nullable: true),
                    AdvisingPrepId1 = table.Column<string>(type: "varchar(45)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.studentID, x.studentdetail_detailId, x.advising_prepID })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
                    table.ForeignKey(
                        name: "FK_studentbasic_advising_AdvisingPrepId1",
                        column: x => x.AdvisingPrepId1,
                        principalTable: "advising",
                        principalColumn: "prepID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_studentbasic_studentdetail1",
                        column: x => x.advising_prepID,
                        principalTable: "studentdetail",
                        principalColumn: "detailId");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "prepID_UNIQUE",
                table: "advising",
                column: "prepID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "EmailAddress",
                table: "studentbasic",
                column: "PersonalEmail",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_studentbasic_advising_prepID",
                table: "studentbasic",
                column: "advising_prepID");

            migrationBuilder.CreateIndex(
                name: "IX_studentbasic_AdvisingPrepId1",
                table: "studentbasic",
                column: "AdvisingPrepId1");

            migrationBuilder.CreateIndex(
                name: "detailId_UNIQUE",
                table: "studentdetail",
                column: "detailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "studentID_UNIQUE",
                table: "studentdetail",
                column: "studentID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "studentbasic");

            migrationBuilder.DropTable(
                name: "advising");

            migrationBuilder.DropTable(
                name: "studentdetail");
        }
    }
}
