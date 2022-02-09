using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class AddCoffeeShops : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"INSERT INTO CoffeeShop (Name, OpeningHours, Address) VALUES ('PJ''s Coffee of new Orelans','9-5 Mon-Sat','9079 West Loctus St BuffalO, nY 14211')");
            migrationBuilder.Sql($"INSERT INTO CoffeeShop (Name, OpeningHours, Address) VALUES ('PJ1''s Coffee of new Orelans1','9-5 Mon-Sat','9079 West Loctus St BuffalO1, nY 14211')");
            migrationBuilder.Sql($"INSERT INTO CoffeeShop (Name, OpeningHours, Address) VALUES ('PJ2''s Coffee of new Orelans2','9-5 Mon-Sat','9079 West Loctus St BuffalO2, nY 14211')");
            migrationBuilder.Sql($"INSERT INTO CoffeeShop (Name, OpeningHours, Address) VALUES ('PJ3''s Coffee of new Orelans3','9-5 Mon-Sat','9079 West Loctus St BuffalO3, nY 14211')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
