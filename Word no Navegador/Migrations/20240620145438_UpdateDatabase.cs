using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Word_no_Navegador.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataAtualiazacao",
                table: "Documentos",
                newName: "DataAtualizacao");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataAtualizacao",
                table: "Documentos",
                newName: "DataAtualiazacao");
        }
    }
}
