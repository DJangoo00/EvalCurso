using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /* migrationBuilder.CreateTable(
                name: "estado",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__estado__3213E83F72621988", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "role",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    roleName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_role", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    correo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__user__3213E83FA57CA06D", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "curso",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    img = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    idInstructorFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__curso__3213E83F117E3898", x => x.id);
                    table.ForeignKey(
                        name: "FK__curso__idInstruc__4222D4EF",
                        column: x => x.idInstructorFk,
                        principalTable: "user",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "RefreshToken",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUserFk = table.Column<int>(type: "int", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Expires = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Revoked = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshToken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshToken_user_IdUserFk",
                        column: x => x.IdUserFk,
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    IdUserFk = table.Column<int>(type: "int", nullable: false),
                    IdRoleFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => new { x.IdUserFk, x.IdRoleFk });
                    table.ForeignKey(
                        name: "FK_UserRole_role_IdRoleFk",
                        column: x => x.IdRoleFk,
                        principalTable: "role",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRole_user_IdUserFk",
                        column: x => x.IdUserFk,
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "usercurso",
                columns: table => new
                {
                    idUserFk = table.Column<int>(type: "int", nullable: false),
                    idCursoFk = table.Column<int>(type: "int", nullable: false),
                    idEstadoFk = table.Column<int>(type: "int", nullable: false),
                    calificacion = table.Column<int>(type: "int", nullable: true),
                    comentario = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__usercurs__0C6128E894DD7FFB", x => new { x.idUserFk, x.idCursoFk });
                    table.ForeignKey(
                        name: "FK__usercurso__idCur__47DBAE45",
                        column: x => x.idCursoFk,
                        principalTable: "curso",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__usercurso__idEst__48CFD27E",
                        column: x => x.idEstadoFk,
                        principalTable: "estado",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__usercurso__idUse__46E78A0C",
                        column: x => x.idUserFk,
                        principalTable: "user",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "index_4",
                table: "curso",
                columns: new[] { "id", "nombre" });

            migrationBuilder.CreateIndex(
                name: "IX_curso_idInstructorFk",
                table: "curso",
                column: "idInstructorFk");

            migrationBuilder.CreateIndex(
                name: "index_5",
                table: "estado",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshToken_IdUserFk",
                table: "RefreshToken",
                column: "IdUserFk");

            migrationBuilder.CreateIndex(
                name: "index_1",
                table: "user",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "index_6",
                table: "usercurso",
                columns: new[] { "idUserFk", "idCursoFk", "idEstadoFk", "calificacion" });

            migrationBuilder.CreateIndex(
                name: "IX_usercurso_idCursoFk",
                table: "usercurso",
                column: "idCursoFk");

            migrationBuilder.CreateIndex(
                name: "IX_usercurso_idEstadoFk",
                table: "usercurso",
                column: "idEstadoFk");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_IdRoleFk",
                table: "UserRole",
                column: "IdRoleFk"); */
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            /* migrationBuilder.DropTable(
                name: "RefreshToken");

            migrationBuilder.DropTable(
                name: "usercurso");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "curso");

            migrationBuilder.DropTable(
                name: "estado");

            migrationBuilder.DropTable(
                name: "role");

            migrationBuilder.DropTable(
                name: "user"); */
        }
    }
}
