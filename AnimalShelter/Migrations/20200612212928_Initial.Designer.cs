﻿// <auto-generated />
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalShelter.Migrations
{
    [DbContext(typeof(AnimalShelterContext))]
    [Migration("20200612212928_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AnimalShelter.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Diet")
                        .HasMaxLength(255);

                    b.Property<string>("Family")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Gender")
                        .IsRequired();

                    b.Property<string>("ImgUrl");

                    b.Property<string>("Mass")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Period")
                        .HasMaxLength(255);

                    b.Property<string>("PreferredFood")
                        .HasMaxLength(255);

                    b.Property<string>("Species")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 2,
                            Diet = "‎Carnivore",
                            Family = "Dromaeosauridae",
                            Gender = "Male",
                            ImgUrl = "https://www.dododex.com/media/creature/deinonychus.png",
                            Mass = "160 – 220 lbs (Adult)",
                            Name = "Roger",
                            Period = "Cretaceous",
                            PreferredFood = "Tenontosaurus & Zephyrosaurus",
                            Species = "Deinonychus antirrhopus"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 1,
                            Diet = "‎Carnivore",
                            Family = "Thylacoleonidae",
                            Gender = "Male",
                            ImgUrl = "https://i.redd.it/4501o17gouv31.jpg",
                            Mass = "101 to 130 kg (Adult)",
                            Name = "Simba",
                            Period = "Pliocene to the late Pleistocene",
                            PreferredFood = "Diprotodon & Giant kangaroos",
                            Species = "Thylacoleo carnifex"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 4,
                            Diet = "‎Carnivore",
                            Family = "Spinosauridae",
                            Gender = "Female",
                            ImgUrl = "https://asset-manager.bbcchannels.com/i/2cxqp0000001000",
                            Mass = "14,000 – 17,000 lbs",
                            Name = "Sally",
                            Period = "Albian - Campanian",
                            PreferredFood = "Onchopristis, Mawsonia",
                            Species = "Spinosaurus aegyptiacus"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = 5,
                            Diet = "‎Carnivore",
                            Family = "Allosauridae",
                            Gender = "Male",
                            ImgUrl = "https://nhmu.utah.edu/sites/default/files/allosaurusg1610_ORIG_adj%20copy_6.jpg",
                            Mass = "1,000 kg (Adult)",
                            Name = "Ralph",
                            Period = "Late Jurassic - Turonian",
                            PreferredFood = "Stegosaurus, Brachiosaurus",
                            Species = "Allosaurus fragilis"
                        },
                        new
                        {
                            AnimalId = 5,
                            Age = 3,
                            Diet = "Herbivore",
                            Family = "Ankylosauridae",
                            Gender = "Female",
                            ImgUrl = "https://2e.aonprd.com/Images/Monsters/Dinosaur_Ankylosaurus.png",
                            Mass = "11,000 – 18,000 lbs (Adult)",
                            Name = "Meg",
                            Period = "Cretaceous – Paleogene",
                            PreferredFood = "Tough leaves, ferns and pulpy fruits",
                            Species = "Ankylosaurus magniventris"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
