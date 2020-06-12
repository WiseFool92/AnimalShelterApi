using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Species = table.Column<string>(maxLength: 255, nullable: false),
                    Family = table.Column<string>(maxLength: 100, nullable: false),
                    Age = table.Column<int>(nullable: false),
                    ImgUrl = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: false),
                    Mass = table.Column<string>(maxLength: 255, nullable: true),
                    Diet = table.Column<string>(maxLength: 255, nullable: true),
                    Period = table.Column<string>(maxLength: 255, nullable: true),
                    PreferredFood = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Diet", "Family", "Gender", "ImgUrl", "Mass", "Name", "Period", "PreferredFood", "Species" },
                values: new object[,]
                {
                    { 1, 2, "‎Carnivore", "Dromaeosauridae", "Male", "https://www.dododex.com/media/creature/deinonychus.png", "160 – 220 lbs (Adult)", "Roger", "Cretaceous", "Tenontosaurus & Zephyrosaurus", "Deinonychus antirrhopus" },
                    { 2, 1, "‎Carnivore", "Thylacoleonidae", "Male", "https://i.redd.it/4501o17gouv31.jpg", "101 to 130 kg (Adult)", "Simba", "Pliocene to the late Pleistocene", "Diprotodon & Giant kangaroos", "Thylacoleo carnifex" },
                    { 3, 4, "‎Carnivore", "Spinosauridae", "Female", "https://asset-manager.bbcchannels.com/i/2cxqp0000001000", "14,000 – 17,000 lbs", "Sally", "Albian - Campanian", "Onchopristis, Mawsonia", "Spinosaurus aegyptiacus" },
                    { 4, 5, "‎Carnivore", "Allosauridae", "Male", "https://nhmu.utah.edu/sites/default/files/allosaurusg1610_ORIG_adj%20copy_6.jpg", "1,000 kg (Adult)", "Ralph", "Late Jurassic - Turonian", "Stegosaurus, Brachiosaurus", "Allosaurus fragilis" },
                    { 5, 3, "Herbivore", "Ankylosauridae", "Female", "https://2e.aonprd.com/Images/Monsters/Dinosaur_Ankylosaurus.png", "11,000 – 18,000 lbs (Adult)", "Meg", "Cretaceous – Paleogene", "Tough leaves, ferns and pulpy fruits", "Ankylosaurus magniventris" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}
