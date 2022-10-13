using Microsoft.EntityFrameworkCore.Migrations;

namespace BamBoo_SoftToothbrush.Migrations.BamBoo_SoftToothbrush
{
    public partial class ToothbrushContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BrushClass",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    BrushSize = table.Column<decimal>(nullable: false),
                    Category = table.Column<string>(nullable: true),
                    Bristles_Color = table.Column<string>(nullable: true),
                    Review = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrushClass", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BrushClass");
        }
    }
}
