using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_studentbasic_advising_AdvisingPrepId1",
                table: "studentbasic");

            migrationBuilder.DropForeignKey(
                name: "fk_studentbasic_studentdetail1",
                table: "studentbasic");

            migrationBuilder.DropPrimaryKey(
                name: "PRIMARY",
                table: "studentdetail");

            migrationBuilder.DropIndex(
                name: "studentID_UNIQUE",
                table: "studentdetail");

            migrationBuilder.DropPrimaryKey(
                name: "PRIMARY",
                table: "studentbasic");

            migrationBuilder.DropIndex(
                name: "EmailAddress",
                table: "studentbasic");

            migrationBuilder.DropIndex(
                name: "IX_studentbasic_advising_prepID",
                table: "studentbasic");

            migrationBuilder.DropIndex(
                name: "IX_studentbasic_AdvisingPrepId1",
                table: "studentbasic");

            migrationBuilder.DropPrimaryKey(
                name: "PRIMARY",
                table: "advising");

            migrationBuilder.DropColumn(
                name: "consentForm",
                table: "studentdetail");

            migrationBuilder.DropColumn(
                name: "studentID",
                table: "studentdetail");

            migrationBuilder.DropColumn(
                name: "studentdetail_detailId",
                table: "studentbasic");

            migrationBuilder.DropColumn(
                name: "advising_prepID",
                table: "studentbasic");

            migrationBuilder.DropColumn(
                name: "AdvisingPrepId1",
                table: "studentbasic");

            migrationBuilder.RenameColumn(
                name: "detailId",
                table: "studentdetail",
                newName: "detailID");

            migrationBuilder.RenameColumn(
                name: "transcript",
                table: "studentdetail",
                newName: "cvT10");

            migrationBuilder.RenameColumn(
                name: "cv",
                table: "studentdetail",
                newName: "cvE11");

            migrationBuilder.RenameColumn(
                name: "PersonalEmail",
                table: "studentbasic",
                newName: "personalEmail");

            migrationBuilder.AlterDatabase(
                collation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterTable(
                name: "studentdetail")
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterTable(
                name: "studentbasic")
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterTable(
                name: "advising")
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "highDegree",
                table: "studentdetail",
                type: "varchar(45)",
                maxLength: 45,
                nullable: true,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(45)",
                oldMaxLength: 45,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "detailID",
                table: "studentdetail",
                type: "varchar(36)",
                maxLength: 36,
                nullable: false,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "cvT10",
                table: "studentdetail",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "cvE11",
                table: "studentdetail",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "studentbasic_studentID",
                table: "studentdetail",
                type: "varchar(36)",
                maxLength: 36,
                nullable: false,
                defaultValue: "",
                collation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "consentFormE11",
                table: "studentdetail",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true,
                collation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "consentFormT10",
                table: "studentdetail",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true,
                collation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "transcriptE11",
                table: "studentdetail",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true,
                collation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "transcriptT10",
                table: "studentdetail",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true,
                collation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "pronouns",
                table: "studentbasic",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "preferredFirstName",
                table: "studentbasic",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "phoneNumber",
                table: "studentbasic",
                type: "varchar(14)",
                maxLength: 14,
                nullable: true,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(14)",
                oldMaxLength: 14,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "legalLastName",
                table: "studentbasic",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "legalFirstName",
                table: "studentbasic",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "studentbasic",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "personalEmail",
                table: "studentbasic",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "studentID",
                table: "studentbasic",
                type: "varchar(36)",
                maxLength: 36,
                nullable: false,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "prepStatus",
                table: "advising",
                type: "varchar(10)",
                maxLength: 10,
                nullable: false,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldMaxLength: 10)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "orienT10",
                table: "advising",
                type: "varchar(10)",
                maxLength: 10,
                nullable: false,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldMaxLength: 10)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "orienE11",
                table: "advising",
                type: "varchar(10)",
                maxLength: 10,
                nullable: false,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldMaxLength: 10)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "prepID",
                table: "advising",
                type: "varchar(36)",
                maxLength: 36,
                nullable: false,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(45)",
                oldMaxLength: 45)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "studentbasic_studentID",
                table: "advising",
                type: "varchar(36)",
                maxLength: 36,
                nullable: false,
                defaultValue: "",
                collation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PRIMARY",
                table: "studentdetail",
                columns: new[] { "detailID", "studentbasic_studentID" })
                .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            migrationBuilder.AddPrimaryKey(
                name: "PRIMARY",
                table: "studentbasic",
                column: "studentID");

            migrationBuilder.AddPrimaryKey(
                name: "PRIMARY",
                table: "advising",
                columns: new[] { "prepID", "studentbasic_studentID" })
                .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            migrationBuilder.CreateIndex(
                name: "fk_studentdetail_studentbasic1",
                table: "studentdetail",
                column: "studentbasic_studentID");

            migrationBuilder.CreateIndex(
                name: "fk_advising_studentbasic1",
                table: "advising",
                column: "studentbasic_studentID");

            migrationBuilder.AddForeignKey(
                name: "fk_advising_studentbasic1",
                table: "advising",
                column: "studentbasic_studentID",
                principalTable: "studentbasic",
                principalColumn: "studentID");

            migrationBuilder.AddForeignKey(
                name: "fk_studentdetail_studentbasic1",
                table: "studentdetail",
                column: "studentbasic_studentID",
                principalTable: "studentbasic",
                principalColumn: "studentID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_advising_studentbasic1",
                table: "advising");

            migrationBuilder.DropForeignKey(
                name: "fk_studentdetail_studentbasic1",
                table: "studentdetail");

            migrationBuilder.DropPrimaryKey(
                name: "PRIMARY",
                table: "studentdetail");

            migrationBuilder.DropIndex(
                name: "fk_studentdetail_studentbasic1",
                table: "studentdetail");

            migrationBuilder.DropPrimaryKey(
                name: "PRIMARY",
                table: "studentbasic");

            migrationBuilder.DropPrimaryKey(
                name: "PRIMARY",
                table: "advising");

            migrationBuilder.DropIndex(
                name: "fk_advising_studentbasic1",
                table: "advising");

            migrationBuilder.DropColumn(
                name: "studentbasic_studentID",
                table: "studentdetail");

            migrationBuilder.DropColumn(
                name: "consentFormE11",
                table: "studentdetail");

            migrationBuilder.DropColumn(
                name: "consentFormT10",
                table: "studentdetail");

            migrationBuilder.DropColumn(
                name: "transcriptE11",
                table: "studentdetail");

            migrationBuilder.DropColumn(
                name: "transcriptT10",
                table: "studentdetail");

            migrationBuilder.DropColumn(
                name: "studentbasic_studentID",
                table: "advising");

            migrationBuilder.RenameColumn(
                name: "detailID",
                table: "studentdetail",
                newName: "detailId");

            migrationBuilder.RenameColumn(
                name: "cvT10",
                table: "studentdetail",
                newName: "transcript");

            migrationBuilder.RenameColumn(
                name: "cvE11",
                table: "studentdetail",
                newName: "cv");

            migrationBuilder.RenameColumn(
                name: "personalEmail",
                table: "studentbasic",
                newName: "PersonalEmail");

            migrationBuilder.AlterDatabase(
                oldCollation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterTable(
                name: "studentdetail")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterTable(
                name: "studentbasic")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterTable(
                name: "advising")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "highDegree",
                table: "studentdetail",
                type: "varchar(45)",
                maxLength: 45,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(45)",
                oldMaxLength: 45,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "detailId",
                table: "studentdetail",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(36)",
                oldMaxLength: 36)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "transcript",
                table: "studentdetail",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "cv",
                table: "studentdetail",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AddColumn<string>(
                name: "consentForm",
                table: "studentdetail",
                type: "varchar(45)",
                maxLength: 45,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "studentID",
                table: "studentdetail",
                type: "varchar(45)",
                maxLength: 45,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "pronouns",
                table: "studentbasic",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "preferredFirstName",
                table: "studentbasic",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "phoneNumber",
                table: "studentbasic",
                type: "varchar(14)",
                maxLength: 14,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(14)",
                oldMaxLength: 14,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "PersonalEmail",
                table: "studentbasic",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "legalLastName",
                table: "studentbasic",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "legalFirstName",
                table: "studentbasic",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "studentbasic",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "studentID",
                table: "studentbasic",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(36)",
                oldMaxLength: 36)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AddColumn<string>(
                name: "studentdetail_detailId",
                table: "studentbasic",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "advising_prepID",
                table: "studentbasic",
                type: "varchar(45)",
                maxLength: 45,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "AdvisingPrepId1",
                table: "studentbasic",
                type: "varchar(45)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "prepStatus",
                table: "advising",
                type: "varchar(10)",
                maxLength: 10,
                nullable: false,
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
                nullable: false,
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
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldMaxLength: 10)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "prepID",
                table: "advising",
                type: "varchar(45)",
                maxLength: 45,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(36)",
                oldMaxLength: 36)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AddPrimaryKey(
                name: "PRIMARY",
                table: "studentdetail",
                column: "detailId");

            migrationBuilder.AddPrimaryKey(
                name: "PRIMARY",
                table: "studentbasic",
                columns: new[] { "studentID", "studentdetail_detailId", "advising_prepID" })
                .Annotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            migrationBuilder.AddPrimaryKey(
                name: "PRIMARY",
                table: "advising",
                column: "prepID");

            migrationBuilder.CreateIndex(
                name: "studentID_UNIQUE",
                table: "studentdetail",
                column: "studentID",
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

            migrationBuilder.AddForeignKey(
                name: "FK_studentbasic_advising_AdvisingPrepId1",
                table: "studentbasic",
                column: "AdvisingPrepId1",
                principalTable: "advising",
                principalColumn: "prepID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_studentbasic_studentdetail1",
                table: "studentbasic",
                column: "advising_prepID",
                principalTable: "studentdetail",
                principalColumn: "detailId");
        }
    }
}
