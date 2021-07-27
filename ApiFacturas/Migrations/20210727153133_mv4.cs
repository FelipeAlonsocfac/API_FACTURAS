using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiFacturas.Migrations
{
    public partial class mv4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IvaId",
                table: "Productos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Productos_IvaId",
                table: "Productos",
                column: "IvaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Impuestos_IvaId",
                table: "Productos",
                column: "IvaId",
                principalTable: "Impuestos",
                principalColumn: "ImpuestoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Impuestos_IvaId",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_IvaId",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "IvaId",
                table: "Productos");
        }
    }
}
