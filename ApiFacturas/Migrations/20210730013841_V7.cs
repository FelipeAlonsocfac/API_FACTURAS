using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiFacturas.Migrations
{
    public partial class V7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetalleFacturas_Productos_ProductoId",
                table: "DetalleFacturas");

            migrationBuilder.DropForeignKey(
                name: "FK_Sedes_Empresas_EmpresaId",
                table: "Sedes");

            migrationBuilder.DropIndex(
                name: "IX_DetalleFacturas_ProductoId",
                table: "DetalleFacturas");

            migrationBuilder.DropColumn(
                name: "MetodoPago",
                table: "DetalleFacturas");

            migrationBuilder.RenameColumn(
                name: "IvaId",
                table: "Productos",
                newName: "ImpuestoId");

            migrationBuilder.AlterColumn<int>(
                name: "EmpresaId",
                table: "Sedes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ciudad",
                table: "Sedes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pais",
                table: "Sedes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Telefono",
                table: "Sedes",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<int>(
                name: "ZipCode",
                table: "Sedes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "Impuestos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Impuestos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MetodoPago",
                table: "EncabezadosFacturas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NumeroFactura",
                table: "EncabezadosFacturas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Total",
                table: "EncabezadosFacturas",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "NIT",
                table: "Empresas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cedula",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Productos_ImpuestoId",
                table: "Productos",
                column: "ImpuestoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Impuestos_ImpuestoId",
                table: "Productos",
                column: "ImpuestoId",
                principalTable: "Impuestos",
                principalColumn: "ImpuestoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sedes_Empresas_EmpresaId",
                table: "Sedes",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "EmpresaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Impuestos_ImpuestoId",
                table: "Productos");

            migrationBuilder.DropForeignKey(
                name: "FK_Sedes_Empresas_EmpresaId",
                table: "Sedes");

            migrationBuilder.DropIndex(
                name: "IX_Productos_ImpuestoId",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "Ciudad",
                table: "Sedes");

            migrationBuilder.DropColumn(
                name: "Pais",
                table: "Sedes");

            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "Sedes");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Sedes");

            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "Impuestos");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Impuestos");

            migrationBuilder.DropColumn(
                name: "MetodoPago",
                table: "EncabezadosFacturas");

            migrationBuilder.DropColumn(
                name: "NumeroFactura",
                table: "EncabezadosFacturas");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "EncabezadosFacturas");

            migrationBuilder.DropColumn(
                name: "NIT",
                table: "Empresas");

            migrationBuilder.DropColumn(
                name: "Cedula",
                table: "Clientes");

            migrationBuilder.RenameColumn(
                name: "ImpuestoId",
                table: "Productos",
                newName: "IvaId");

            migrationBuilder.AlterColumn<int>(
                name: "EmpresaId",
                table: "Sedes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "MetodoPago",
                table: "DetalleFacturas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DetalleFacturas_ProductoId",
                table: "DetalleFacturas",
                column: "ProductoId");

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleFacturas_Productos_ProductoId",
                table: "DetalleFacturas",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "ProductoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sedes_Empresas_EmpresaId",
                table: "Sedes",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "EmpresaId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
