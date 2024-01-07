using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebNotas.Migrations
{
    /// <inheritdoc />
    public partial class PrimeiraMigracao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notas",
                columns: table => new
                {
                    NotaFiscalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NumeroNf = table.Column<int>(type: "INTEGER", nullable: false),
                    ValorTotal = table.Column<decimal>(type: "DECIMAL(7,2)", nullable: false),
                    DataNf = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    CnpjEmissorNf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CnpjDestinatarioNf = table.Column<string>(type: "VARCHAR(14)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notas", x => x.NotaFiscalId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notas");
        }
    }
}
