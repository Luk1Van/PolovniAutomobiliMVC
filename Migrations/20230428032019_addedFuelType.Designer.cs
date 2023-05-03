﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PolovniAutomobiliMVC.Models;

#nullable disable

namespace PolovniAutomobiliMVC.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230428032019_addedFuelType")]
    partial class addedFuelType
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PolovniAutomobiliMVC.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionShort")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FuelTypeId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrlThumbnail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsSpecialOffer")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("FuelTypeId");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 3,
                            Description = "When an SUV delivers as crisp a driving experience as the 2022 Hyundai Kona, it's hard to get hung up on the usual anti-crossover sentiment—so we won't. The subcompact Kona is, simply put, a great package that blends carlike on-road behavior with bold styling, a dose of practicality, and an elevated driving position. Two four-cylinder engines are offered: a 2.0-liter four, which is admittedly pretty poky, and a more desirable turbocharged 1.6-liter four that delivers a lot more punch.",
                            DescriptionShort = "The subcompact Kona is, simply put, a great package that blends carlike on-road behavior with bold styling, a dose of practicality, and an elevated driving position.",
                            FuelTypeId = 1,
                            ImageUrl = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2022-hyundai-kona-101-1613496529.jpg?crop=1xw:1xh;center,top&resize=980:*",
                            ImageUrlThumbnail = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2022-hyundai-kona-101-1613496529.jpg?crop=1xw:1xh;center,top&resize=980:*",
                            IsSpecialOffer = false,
                            Name = "Hyundai Kona",
                            Price = 22135m
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 3,
                            Description = "With a bold exterior look and a surprisingly spacious cabin, the 2021 Nissan Kicks is a stylish small SUV with a practical side. Its powertrain leaves us wanting, especially when traveling at highway speeds, but as a city-focused commuter the Kicks is, um, a kick. Standard equipment is plentiful and includes driver-assistance features and popular infotainment tech such as Apple CarPlay and Android Auto.",
                            DescriptionShort = "Its powertrain leaves us wanting, especially when traveling at highway speeds, but as a city-focused commuter the Kicks is, um, a kick.",
                            FuelTypeId = 2,
                            ImageUrl = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2021-nissan-kicks-35-1607442145.jpg?crop=0.854xw:0.665xh;0.130xw,0.335xh&resize=2048:*",
                            ImageUrlThumbnail = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2021-nissan-kicks-35-1607442145.jpg?crop=0.854xw:0.665xh;0.130xw,0.335xh&resize=800:*",
                            IsSpecialOffer = true,
                            Name = "Nissan Kicks",
                            Price = 20650m
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            Description = "Few compact hatchbacks are better than the 2021 Volkswagen Golf, but one that is happens to share the same showroom: the sporty GTI (reviewed separately). Apart from the standard Golf's lower asking price and higher fuel efficiency, it isn't as desirable as its more powerful, better-equipped sibling. While that's partly why VW will only offer the next-generation GTI and high-performance Golf R on our shores, it doesn't diminish that the regular version remains a terrific value in its final year.",
                            DescriptionShort = "Apart from the standard Golf's lower asking price and higher fuel efficiency, it isn't as desirable as its more powerful, better-equipped sibling. ",
                            FuelTypeId = 1,
                            ImageUrl = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2021-volkswagen-golf-mmp-1-1604508183.jpg?crop=0.814xw:0.688xh;0.175xw,0.255xh&resize=2048:*",
                            ImageUrlThumbnail = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2021-volkswagen-golf-mmp-1-1604508183.jpg?crop=0.814xw:0.688xh;0.175xw,0.255xh&resize=800:*",
                            IsSpecialOffer = false,
                            Name = "VW Golf",
                            Price = 24190m
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 3,
                            Description = "With room for up to eight passengers plus their cargo and a stout towing capacity, the 2021 Ford Expedition is a workhorse for active families. It's available in both standard-length and long-wheelbase Expedition Max body styles and is powered by a twin-turbocharged V-6 engine with a 10-speed automatic transmission. Rear-wheel drive is standard, but buyers who need four-wheel action can have it on any trim level for a price.",
                            DescriptionShort = "With room for up to eight passengers plus their cargo and a stout towing capacity, the 2021 Ford Expedition is a workhorse for active families. ",
                            FuelTypeId = 2,
                            ImageUrl = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2021-ford-expedition-mmp-1-1596491024.jpeg?crop=1xw:0.8428720083246618xh;center,top&resize=2048:*",
                            ImageUrlThumbnail = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2021-ford-expedition-mmp-1-1596491024.jpeg?crop=1xw:0.8428720083246618xh;center,top&resize=800:*",
                            IsSpecialOffer = false,
                            Name = "Ford Expedition",
                            Price = 51690m
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Description = "The 2021 Kia Rio sedan and hatchback are classified as economical subcompact cars—we used to call such cars econoboxesS—but they're surprisingly more sophisticated than that. So much so that we named the Rio to our Editors' Choice list. The Kia couple shares a cabin design that exudes an elegant simplicity thanks to a smart layout and pleasing materials.",
                            DescriptionShort = "The 2021 Kia Rio sedan and hatchback are classified as economical subcompact cars—we used to call such cars econoboxes—but they're surprisingly more sophisticated than that.",
                            FuelTypeId = 1,
                            ImageUrl = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/medium-14620-electrifiedpowerbigcartechnologyandrefresheddesignforupgradedkiario-1596645908.jpg?crop=0.776xw:0.654xh;0.106xw,0.303xh&resize=2048:*",
                            ImageUrlThumbnail = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/medium-14620-electrifiedpowerbigcartechnologyandrefresheddesignforupgradedkiario-1596645908.jpg?crop=0.776xw:0.654xh;0.106xw,0.303xh&resize=800:*",
                            IsSpecialOffer = true,
                            Name = "Kia Rio",
                            Price = 17045m
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 1,
                            Description = "The 2021 Toyota Corolla continues its tradition of being an inexpensive, safety-minded, and well-equipped compact car. Available as either a four-door hatchback or sedan, the little Toyota offers a variety of personalities. Both body styles feature a pair of dutiful four-cylinder engines, and they're also offered with an extremely frugal hybrid powertrain.",
                            DescriptionShort = "The 2021 Toyota Corolla continues its tradition of being an inexpensive, safety-minded, and well-equipped compact car.",
                            FuelTypeId = 1,
                            ImageUrl = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2021-toyota-corolla-se-apex-mmp-1-1601668779.jpg?crop=0.861xw:0.724xh;0.0641xw,0.194xh&resize=2048:*",
                            ImageUrlThumbnail = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2021-toyota-corolla-se-apex-mmp-1-1601668779.jpg?crop=0.861xw:0.724xh;0.0641xw,0.194xh&resize=800:*",
                            IsSpecialOffer = true,
                            Name = "Toyota Corolla",
                            Price = 21020m
                        });
                });

            modelBuilder.Entity("PolovniAutomobiliMVC.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A sedan has four doors and a traditional trunk.",
                            Name = "Sedan"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Traditionally, the term hatchback has meant a compact or subcompact sedan with a squared-off roof and a rear flip-up hatch door that provides access to the vehicle's cargo area instead of a conventional trunk.",
                            Name = "Hatchback"
                        },
                        new
                        {
                            Id = 3,
                            Description = "SUVs—often also referred to as crossovers—tend to be taller and boxier than sedans, offer an elevated seating position, and have more ground clearance than a car. ",
                            Name = "SUV"
                        });
                });

            modelBuilder.Entity("PolovniAutomobiliMVC.Models.FuelType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FuelTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Gasoline is the most common automobile fuel and is used all over the world to power cars, motorcycles, scooters, boats, lawnmowers, and other machinery.",
                            Name = "Gasoline"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Diesel fuel is also made from petroleum but is refined using a different method than that used to create gasoline.",
                            Name = "Diesel"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Diesel fuel that is created using vegetable oils or animal fats is called bio-diesel.",
                            Name = "Bio-Diesel"
                        });
                });

            modelBuilder.Entity("PolovniAutomobiliMVC.Models.Car", b =>
                {
                    b.HasOne("PolovniAutomobiliMVC.Models.Category", "Category")
                        .WithMany("Cars")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PolovniAutomobiliMVC.Models.FuelType", "FuelType")
                        .WithMany()
                        .HasForeignKey("FuelTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("FuelType");
                });

            modelBuilder.Entity("PolovniAutomobiliMVC.Models.Category", b =>
                {
                    b.Navigation("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}
