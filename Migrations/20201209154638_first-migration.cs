using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductosApp.Migrations
{
    public partial class firstmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Inventario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Codigo);
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "Codigo", "Descripcion", "Inventario", "Precio" },
                values: new object[,]
                {
                    { 1, "Zapato", 25, 150m },
                    { 2, "Toallas", 25, 165m },
                    { 3, "Celular", 25, 8900m },
                    { 4, "Computadora", 25, 18900m },
                    { 5, "Control Remoto", 25, 80m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productos");
        }
    }
}
