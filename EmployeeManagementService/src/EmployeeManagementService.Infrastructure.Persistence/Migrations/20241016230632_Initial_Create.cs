using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EmployeeManagementService.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Initial_Create : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "emaployeemanagement");

            migrationBuilder.CreateTable(
                name: "Departments",
                schema: "emaployeemanagement",
                columns: table => new
                {
                    Id = table.Column<string>(type: "character varying(36)", maxLength: 36, nullable: false),
                    Name = table.Column<string>(type: "character varying(220)", maxLength: 220, nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2024, 10, 16, 23, 6, 31, 625, DateTimeKind.Unspecified).AddTicks(3306), new TimeSpan(0, 0, 0, 0, 0))),
                    CreatedBy = table.Column<string>(type: "character varying(320)", maxLength: 320, nullable: false),
                    LastModifiedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2024, 10, 16, 23, 6, 31, 625, DateTimeKind.Unspecified).AddTicks(3679), new TimeSpan(0, 0, 0, 0, 0))),
                    LastModifiedBy = table.Column<string>(type: "character varying(320)", maxLength: 320, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaxInformations",
                schema: "emaployeemanagement",
                columns: table => new
                {
                    Id = table.Column<string>(type: "character varying(36)", maxLength: 36, nullable: false),
                    Code = table.Column<string>(type: "character varying(220)", maxLength: 220, nullable: false),
                    Rate = table.Column<decimal>(type: "numeric(5,2)", precision: 5, scale: 2, nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2024, 10, 16, 23, 6, 31, 625, DateTimeKind.Unspecified).AddTicks(4903), new TimeSpan(0, 0, 0, 0, 0))),
                    CreatedBy = table.Column<string>(type: "character varying(320)", maxLength: 320, nullable: false),
                    LastModifiedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2024, 10, 16, 23, 6, 31, 625, DateTimeKind.Unspecified).AddTicks(5239), new TimeSpan(0, 0, 0, 0, 0))),
                    LastModifiedBy = table.Column<string>(type: "character varying(320)", maxLength: 320, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxInformations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaxYears",
                schema: "emaployeemanagement",
                columns: table => new
                {
                    Id = table.Column<string>(type: "character varying(36)", maxLength: 36, nullable: false),
                    Name = table.Column<string>(type: "character varying(220)", maxLength: 220, nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2024, 10, 16, 23, 6, 31, 625, DateTimeKind.Unspecified).AddTicks(6611), new TimeSpan(0, 0, 0, 0, 0))),
                    CreatedBy = table.Column<string>(type: "character varying(320)", maxLength: 320, nullable: false),
                    LastModifiedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2024, 10, 16, 23, 6, 31, 625, DateTimeKind.Unspecified).AddTicks(6978), new TimeSpan(0, 0, 0, 0, 0))),
                    LastModifiedBy = table.Column<string>(type: "character varying(320)", maxLength: 320, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxYears", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                schema: "emaployeemanagement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", maxLength: 36, nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "character varying(35)", maxLength: 35, nullable: false),
                    LastName = table.Column<string>(type: "character varying(35)", maxLength: 35, nullable: false),
                    Email = table.Column<string>(type: "character varying(320)", maxLength: 320, nullable: false),
                    HireDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    DepartmentId = table.Column<string>(type: "character varying(36)", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2024, 10, 16, 23, 6, 31, 625, DateTimeKind.Unspecified).AddTicks(7995), new TimeSpan(0, 0, 0, 0, 0))),
                    CreatedBy = table.Column<string>(type: "character varying(320)", maxLength: 320, nullable: false),
                    LastModifiedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2024, 10, 16, 23, 6, 31, 625, DateTimeKind.Unspecified).AddTicks(8439), new TimeSpan(0, 0, 0, 0, 0))),
                    LastModifiedBy = table.Column<string>(type: "character varying(320)", maxLength: 320, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalSchema: "emaployeemanagement",
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeTaxes",
                schema: "emaployeemanagement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmployeeId = table.Column<int>(type: "integer", nullable: false),
                    TaxYearId = table.Column<string>(type: "character varying(36)", nullable: true),
                    TaxInformationId = table.Column<string>(type: "character varying(36)", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    LastModifiedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTaxes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeTaxes_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalSchema: "emaployeemanagement",
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeTaxes_TaxInformations_TaxInformationId",
                        column: x => x.TaxInformationId,
                        principalSchema: "emaployeemanagement",
                        principalTable: "TaxInformations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeTaxes_TaxYears_TaxYearId",
                        column: x => x.TaxYearId,
                        principalSchema: "emaployeemanagement",
                        principalTable: "TaxYears",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departments_Name",
                schema: "emaployeemanagement",
                table: "Departments",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTaxes_EmployeeId",
                schema: "emaployeemanagement",
                table: "EmployeeTaxes",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTaxes_TaxInformationId",
                schema: "emaployeemanagement",
                table: "EmployeeTaxes",
                column: "TaxInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTaxes_TaxYearId",
                schema: "emaployeemanagement",
                table: "EmployeeTaxes",
                column: "TaxYearId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                schema: "emaployeemanagement",
                table: "Employees",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Email",
                schema: "emaployeemanagement",
                table: "Employees",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TaxInformations_Code",
                schema: "emaployeemanagement",
                table: "TaxInformations",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TaxYears_Name",
                schema: "emaployeemanagement",
                table: "TaxYears",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeTaxes",
                schema: "emaployeemanagement");

            migrationBuilder.DropTable(
                name: "Employees",
                schema: "emaployeemanagement");

            migrationBuilder.DropTable(
                name: "TaxInformations",
                schema: "emaployeemanagement");

            migrationBuilder.DropTable(
                name: "TaxYears",
                schema: "emaployeemanagement");

            migrationBuilder.DropTable(
                name: "Departments",
                schema: "emaployeemanagement");
        }
    }
}
