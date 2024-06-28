using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Xtreme.Models;

namespace Xtreme.Data
{
    public class XtremeDbContext : IdentityDbContext<IdentityUser>
    {
        private readonly IConfiguration _configuration;

        public XtremeDbContext(DbContextOptions<XtremeDbContext> options, IConfiguration configuration)
            : base(options)
        {
            _configuration = configuration;
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Vehicles> Vehicles { get; set; }
        public DbSet<TypeOfVehicle> TypeOfVehicles { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Brand> Brands { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserProfile>()
                .HasOne(up => up.IdentityUser)
                .WithOne()
                .HasForeignKey<UserProfile>(up => up.IdentityUserId);

            // Seed roles
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "c3aaeb97-d2ba-4a53-a521-4eea61e59b35",
                Name = "Admin",
                NormalizedName = "ADMIN"
            },
            new IdentityRole
            {
                Id = "e1f7e4a2-4a52-48b3-a3e4-d39ff43d6f7c",
                Name = "Mechanic",
                NormalizedName = "MECHANIC"
            });

            // Seed users
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser[]
            {
                new IdentityUser
                {
                    Id = "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                    UserName = "Administrator",
                    NormalizedUserName = "ADMINISTRATOR",
                    Email = "admin@example.com",
                    NormalizedEmail = "ADMIN@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PhoneNumber = "1234567890",
                    PhoneNumberConfirmed = true,
                    PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, _configuration["AdminPassword"]),
                    SecurityStamp = string.Empty
                },
                new IdentityUser
                {
                    Id = "fc2b5e3b-9b25-4d7e-a3e4-91f7d3f7c4e5",
                    UserName = "MechanicUser",
                    NormalizedUserName = "MECHANICUSER",
                    Email = "mechanic@example.com",
                    NormalizedEmail = "MECHANIC@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PhoneNumber = "0987654321",
                    PhoneNumberConfirmed = true,
                    PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, _configuration["MechanicPassword"]),
                    SecurityStamp = string.Empty
                }
            });

            // Assign roles to users
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "c3aaeb97-d2ba-4a53-a521-4eea61e59b35",
                UserId = "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f"
            },
            new IdentityUserRole<string>
            {
                RoleId = "e1f7e4a2-4a52-48b3-a3e4-d39ff43d6f7c",
                UserId = "fc2b5e3b-9b25-4d7e-a3e4-91f7d3f7c4e5"
            });

            // Seed user profiles
            modelBuilder.Entity<UserProfile>().HasData(new UserProfile
            {
                Id = 1,
                IdentityUserId = "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                FirstName = "Admin",
                LastName = "User",
                DateCreated = DateTime.Now,
                ImageLocation = "https://example.com/default-avatar.jpg"
            },
            new UserProfile
            {
                Id = 2,
                IdentityUserId = "fc2b5e3b-9b25-4d7e-a3e4-91f7d3f7c4e5",
                FirstName = "Mechanic",
                LastName = "User",
                DateCreated = DateTime.Now,
                ImageLocation = "https://example.com/default-avatar.jpg"
            });

            modelBuilder.Entity<Vehicles>().HasData(new Vehicles
            {
                Id = 1,
                TypeId = 1,
                SizeId = 1,
                BrandId = 1,
                ImageUrl = "https://example.com/car.jpg"
            },
            new Vehicles
            {
                Id = 2,
                TypeId = 2,
                SizeId = 2,
                BrandId = 2,
                ImageUrl = "https://example.com/car.jpg"
            });

            modelBuilder.Entity<TypeOfVehicle>().HasData(new TypeOfVehicle
            {
                Id = 1,
                Type = "Atv"
            },
            new TypeOfVehicle
            {
                Id = 2,
                Type = "Dirt Bike"
            },
            new TypeOfVehicle
            {
                Id = 3,
                Type = "Street Bike"
            },
            new TypeOfVehicle
            {
                Id = 4,
                Type = "Utv"
            });

            modelBuilder.Entity<Brand>().HasData(
                new Brand { Id = 1, Make = "Honda" },
                new Brand { Id = 2, Make = "Yamaha" },
                new Brand { Id = 3, Make = "Kawasaki" },
                new Brand { Id = 4, Make = "KTM" },
                new Brand { Id = 5, Make = "Suzuki" },
                new Brand { Id = 6, Make = "Polaris" },
                new Brand { Id = 7, Make = "Can-Am" },
                new Brand { Id = 8, Make = "BMW" },
                new Brand { Id = 9, Make = "Ducati" },
                new Brand { Id = 10, Make = "Harley-Davidson" },
                new Brand { Id = 11, Make = "CF Moto" },
                new Brand { Id = 12, Make = "Triumph" },
                new Brand { Id = 13, Make = "Beta" },
                new Brand { Id = 14, Make = "GasGas" },
                new Brand { Id = 15, Make = "Husqvarna" },
                new Brand { Id = 16, Make = "Aprilia" },
                new Brand { Id = 17, Make = "MV Agusta" },
                new Brand { Id = 18, Make = "Royal Enfield" },
                new Brand { Id = 19, Make = "Indian Motorcycle" },
                new Brand { Id = 20, Make = "Moto Guzzi" },
                new Brand { Id = 21, Make = "Benelli" },
                new Brand { Id = 22, Make = "Bultaco" },
                new Brand { Id = 23, Make = "Sherco" },
                new Brand { Id = 24, Make = "Arctic Cat" },
                new Brand { Id = 25, Make = "Kymco" },
                new Brand { Id = 26, Make = "Hyosung" }
            );

            modelBuilder.Entity<Size>().HasData(
                new Size { Id = 1, CubicCentimeters = 50 },
                new Size { Id = 2, CubicCentimeters = 100 },
                new Size { Id = 3, CubicCentimeters = 110 },
                new Size { Id = 4, CubicCentimeters = 125 },
                new Size { Id = 5, CubicCentimeters = 200 },
                new Size { Id = 6, CubicCentimeters = 250 },
                new Size { Id = 7, CubicCentimeters = 300 },
                new Size { Id = 8, CubicCentimeters = 350 },
                new Size { Id = 9, CubicCentimeters = 400 },
                new Size { Id = 10, CubicCentimeters = 450 },
                new Size { Id = 11, CubicCentimeters = 500 },
                new Size { Id = 12, CubicCentimeters = 600 },
                new Size { Id = 13, CubicCentimeters = 650 },
                new Size { Id = 14, CubicCentimeters = 750 },
                new Size { Id = 15, CubicCentimeters = 900 },
                new Size { Id = 16, CubicCentimeters = 1000 },
                new Size { Id = 17, CubicCentimeters = 1100 },
                new Size { Id = 18, CubicCentimeters = 1200 },
                new Size { Id = 19, CubicCentimeters = 1300 },
                new Size { Id = 20, CubicCentimeters = 1400}
                );
        }
    }
}

