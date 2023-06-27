using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp1.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<Int32>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(50)", nullable: true),
                    Apellido = table.Column<string>(type: "varchar(50)", nullable: true),
                    Direccion = table.Column<string>(type: "varchar(50)", nullable: true),
                    Telefono = table.Column<string>(type: "varchar(50)", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "date", nullable: true),
                    Estado = table.Column<Boolean>(type: "bit", nullable: true)





                },
                constraints: table =>
                {
                    table.PrimaryKey("Id", x => x.Id);
                });

            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
