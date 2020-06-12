using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options) : base(options)
    {
    }

    public DbSet<Animal> Animals { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
        .HasData(

          new Animal
          {
            AnimalId = 1,
            Name = "Roger",
            Family = "Dromaeosauridae",
            Species = "Deinonychus antirrhopus",
            Age = 2,
            ImgUrl = "https://www.dododex.com/media/creature/deinonychus.png",
            Gender = "Male",
            Mass = "160 – 220 lbs (Adult)",
            Diet = "‎Carnivore",
            Period = "Cretaceous",
            PreferredFood = "Tenontosaurus & Zephyrosaurus"
          },

          new Animal
          {
            AnimalId = 2,
            Name = "Simba",
            Family = "Thylacoleonidae",
            Species = "Thylacoleo carnifex",
            Age = 1,
            ImgUrl = "https://i.redd.it/4501o17gouv31.jpg",
            Gender = "Male",
            Mass = "101 to 130 kg (Adult)",
            Diet = "‎Carnivore",
            Period = "Pliocene to the late Pleistocene",
            PreferredFood = "Diprotodon & Giant kangaroos"
          },

          new Animal
          {
            AnimalId = 3,
            Name = "Sally",
            Family = "Spinosauridae",
            Species = "Spinosaurus aegyptiacus",
            Age = 4,
            ImgUrl = "https://asset-manager.bbcchannels.com/i/2cxqp0000001000",
            Gender = "Female",
            Mass = "14,000 – 17,000 lbs",
            Diet = "‎Carnivore",
            Period = "Albian - Campanian",
            PreferredFood = "Onchopristis, Mawsonia"
          },

          new Animal
          {
            AnimalId = 4,
            Name = "Ralph",
            Family = "Allosauridae",
            Species = "Allosaurus fragilis",
            Age = 5,
            ImgUrl = "https://nhmu.utah.edu/sites/default/files/allosaurusg1610_ORIG_adj%20copy_6.jpg",
            Gender = "Male",
            Mass = "1,000 kg (Adult)",
            Diet = "‎Carnivore",
            Period = "Late Jurassic - Turonian",
            PreferredFood = "Stegosaurus, Brachiosaurus"
          },

          new Animal
          {
            AnimalId = 5,
            Name = "Meg",
            Family = "Ankylosauridae",
            Species = "Ankylosaurus magniventris",
            Age = 3,
            ImgUrl = "https://2e.aonprd.com/Images/Monsters/Dinosaur_Ankylosaurus.png",
            Gender = "Female",
            Mass = "11,000 – 18,000 lbs (Adult)",
            Diet = "Herbivore",
            Period = "Cretaceous – Paleogene",
            PreferredFood = "Tough leaves, ferns and pulpy fruits"
          }
        );
    }
  }
}