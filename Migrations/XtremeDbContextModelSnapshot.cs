﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Xtreme.Data;

#nullable disable

namespace Xtreme_Motorsports.Migrations
{
    [DbContext(typeof(XtremeDbContext))]
    partial class XtremeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "c3aaeb97-d2ba-4a53-a521-4eea61e59b35",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "e1f7e4a2-4a52-48b3-a3e4-d39ff43d6f7c",
                            Name = "Mechanic",
                            NormalizedName = "MECHANIC"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a933dfcb-ce06-4c4a-94b1-1dcbc9036587",
                            Email = "admin@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@EXAMPLE.COM",
                            NormalizedUserName = "ADMINISTRATOR",
                            PasswordHash = "AQAAAAIAAYagAAAAEFHsHsXIqr9MUvoj82+7cg0hDAf6YNiN/12Qpy/N5mJYqJZqk6y07MFPA3EqkjCKHg==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "Administrator"
                        },
                        new
                        {
                            Id = "fc2b5e3b-9b25-4d7e-a3e4-91f7d3f7c4e5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1c6ddfe3-6aba-4e36-b338-f88f75b19e62",
                            Email = "mechanic@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "MECHANIC@EXAMPLE.COM",
                            NormalizedUserName = "MECHANICUSER",
                            PasswordHash = "AQAAAAIAAYagAAAAEHiACU7s2xcz4txB+1zHrSR5Y8mhdKECCddPZnOkpfz3YOLP8acaXfHXdRMB7Mv0Tg==",
                            PhoneNumber = "0987654321",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "MechanicUser"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                            RoleId = "c3aaeb97-d2ba-4a53-a521-4eea61e59b35"
                        },
                        new
                        {
                            UserId = "fc2b5e3b-9b25-4d7e-a3e4-91f7d3f7c4e5",
                            RoleId = "e1f7e4a2-4a52-48b3-a3e4-d39ff43d6f7c"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Xtreme.Models.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Make = "Honda"
                        },
                        new
                        {
                            Id = 2,
                            Make = "Yamaha"
                        },
                        new
                        {
                            Id = 3,
                            Make = "Kawasaki"
                        },
                        new
                        {
                            Id = 4,
                            Make = "KTM"
                        },
                        new
                        {
                            Id = 5,
                            Make = "Suzuki"
                        },
                        new
                        {
                            Id = 6,
                            Make = "Polaris"
                        },
                        new
                        {
                            Id = 7,
                            Make = "Can-Am"
                        },
                        new
                        {
                            Id = 8,
                            Make = "BMW"
                        },
                        new
                        {
                            Id = 9,
                            Make = "Ducati"
                        },
                        new
                        {
                            Id = 10,
                            Make = "Harley-Davidson"
                        },
                        new
                        {
                            Id = 11,
                            Make = "CF Moto"
                        },
                        new
                        {
                            Id = 12,
                            Make = "Triumph"
                        },
                        new
                        {
                            Id = 13,
                            Make = "Beta"
                        },
                        new
                        {
                            Id = 14,
                            Make = "GasGas"
                        },
                        new
                        {
                            Id = 15,
                            Make = "Husqvarna"
                        },
                        new
                        {
                            Id = 16,
                            Make = "Aprilia"
                        },
                        new
                        {
                            Id = 17,
                            Make = "MV Agusta"
                        },
                        new
                        {
                            Id = 18,
                            Make = "Royal Enfield"
                        },
                        new
                        {
                            Id = 19,
                            Make = "Indian Motorcycle"
                        },
                        new
                        {
                            Id = 20,
                            Make = "Moto Guzzi"
                        },
                        new
                        {
                            Id = 21,
                            Make = "Benelli"
                        },
                        new
                        {
                            Id = 22,
                            Make = "Bultaco"
                        },
                        new
                        {
                            Id = 23,
                            Make = "Sherco"
                        },
                        new
                        {
                            Id = 24,
                            Make = "Arctic Cat"
                        },
                        new
                        {
                            Id = 25,
                            Make = "Kymco"
                        },
                        new
                        {
                            Id = 26,
                            Make = "Hyosung"
                        });
                });

            modelBuilder.Entity("Xtreme.Models.Size", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CubicCentimeters")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Sizes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CubicCentimeters = 50
                        },
                        new
                        {
                            Id = 2,
                            CubicCentimeters = 100
                        },
                        new
                        {
                            Id = 3,
                            CubicCentimeters = 110
                        },
                        new
                        {
                            Id = 4,
                            CubicCentimeters = 125
                        },
                        new
                        {
                            Id = 5,
                            CubicCentimeters = 200
                        },
                        new
                        {
                            Id = 6,
                            CubicCentimeters = 250
                        },
                        new
                        {
                            Id = 7,
                            CubicCentimeters = 300
                        },
                        new
                        {
                            Id = 8,
                            CubicCentimeters = 350
                        },
                        new
                        {
                            Id = 9,
                            CubicCentimeters = 400
                        },
                        new
                        {
                            Id = 10,
                            CubicCentimeters = 450
                        },
                        new
                        {
                            Id = 11,
                            CubicCentimeters = 500
                        },
                        new
                        {
                            Id = 12,
                            CubicCentimeters = 600
                        },
                        new
                        {
                            Id = 13,
                            CubicCentimeters = 650
                        },
                        new
                        {
                            Id = 14,
                            CubicCentimeters = 750
                        },
                        new
                        {
                            Id = 15,
                            CubicCentimeters = 900
                        },
                        new
                        {
                            Id = 16,
                            CubicCentimeters = 1000
                        },
                        new
                        {
                            Id = 17,
                            CubicCentimeters = 1100
                        },
                        new
                        {
                            Id = 18,
                            CubicCentimeters = 1200
                        },
                        new
                        {
                            Id = 19,
                            CubicCentimeters = 1300
                        },
                        new
                        {
                            Id = 20,
                            CubicCentimeters = 1400
                        });
                });

            modelBuilder.Entity("Xtreme.Models.TypeOfVehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("TypeOfVehicles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Type = "Atv"
                        },
                        new
                        {
                            Id = 2,
                            Type = "Dirt Bike"
                        },
                        new
                        {
                            Id = 3,
                            Type = "Street Bike"
                        },
                        new
                        {
                            Id = 4,
                            Type = "Utv"
                        });
                });

            modelBuilder.Entity("Xtreme.Models.UserProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("IdentityUserId")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<byte[]>("ImageBlob")
                        .HasColumnType("bytea");

                    b.Property<string>("ImageLocation")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdentityUserId")
                        .IsUnique();

                    b.ToTable("UserProfiles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateTime(2024, 7, 9, 14, 12, 8, 273, DateTimeKind.Local).AddTicks(7148),
                            FirstName = "Admin",
                            IdentityUserId = "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                            ImageLocation = "https://example.com/default-avatar.jpg",
                            LastName = "User"
                        },
                        new
                        {
                            Id = 2,
                            DateCreated = new DateTime(2024, 7, 9, 14, 12, 8, 273, DateTimeKind.Local).AddTicks(7229),
                            FirstName = "Mechanic",
                            IdentityUserId = "fc2b5e3b-9b25-4d7e-a3e4-91f7d3f7c4e5",
                            ImageLocation = "https://example.com/default-avatar.jpg",
                            LastName = "User"
                        });
                });

            modelBuilder.Entity("Xtreme.Models.Vehicles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("BrandId")
                        .HasColumnType("integer");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("SizeId")
                        .HasColumnType("integer");

                    b.Property<int>("TypeOfVehicleId")
                        .HasColumnType("integer");

                    b.Property<int>("UserProfileId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("SizeId");

                    b.HasIndex("TypeOfVehicleId");

                    b.HasIndex("UserProfileId");

                    b.ToTable("Vehicles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 1,
                            ImageUrl = "https://example.com/car.jpg",
                            SizeId = 1,
                            TypeOfVehicleId = 1,
                            UserProfileId = 1
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 2,
                            ImageUrl = "https://example.com/car.jpg",
                            SizeId = 2,
                            TypeOfVehicleId = 2,
                            UserProfileId = 2
                        });
                });

            modelBuilder.Entity("Xtreme.Models.WorkOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("VehicleId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("WorkOrders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Needs carb cleaned",
                            VehicleId = 2
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Xtreme.Models.UserProfile", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "IdentityUser")
                        .WithOne()
                        .HasForeignKey("Xtreme.Models.UserProfile", "IdentityUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdentityUser");
                });

            modelBuilder.Entity("Xtreme.Models.Vehicles", b =>
                {
                    b.HasOne("Xtreme.Models.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Xtreme.Models.Size", "Size")
                        .WithMany()
                        .HasForeignKey("SizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Xtreme.Models.TypeOfVehicle", "TypeOfVehicle")
                        .WithMany()
                        .HasForeignKey("TypeOfVehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Xtreme.Models.UserProfile", "UserProfile")
                        .WithMany()
                        .HasForeignKey("UserProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Size");

                    b.Navigation("TypeOfVehicle");

                    b.Navigation("UserProfile");
                });
#pragma warning restore 612, 618
        }
    }
}
