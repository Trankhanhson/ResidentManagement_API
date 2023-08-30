using AuthenticationProject.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationProject.Models
{
    public class AuthenticationDBContext : IdentityDbContext<ApplicationUser>
    {
        public AuthenticationDBContext(DbContextOptions<AuthenticationDBContext> options) : base(options) { }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<ResidentApartment> ResidentApartment { get; set; }
        public DbSet<Resident> Resident { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<PermissionUser> PermissionUsers { get; set; }
        public DbSet<PermissionRole> PermissionRoles { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<UrbanArea> UrbanAreas { get; set; }
        public DbSet<BuildingCategory> BuildingCategories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-6T5FIK85\SQLEXPRESS;Database=Authentication_DB;TrustServerCertificate=True;Trusted_Connection=True;");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PermissionRole>()
                .HasOne(pr => pr.Role)
                .WithMany()  // Đặt mối quan hệ 1-nhiều với vai trò (role)
                .HasForeignKey(pr => pr.RoleId);

            modelBuilder.Entity<PermissionUser>()
    .HasOne(pu => pu.User)
    .WithMany()  // Đặt mối quan hệ 1-nhiều với người dùng (user)
    .HasForeignKey(pu => pu.UserId);

            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Name = "Apartment_Create", ConcurrencyStamp = "4", NormalizedName = "Apartment_Create" },
                new IdentityRole { Name = "Apartment_Update", ConcurrencyStamp = "4", NormalizedName = "Apartment_Update" },
                new IdentityRole { Name = "Apartment_Delete", ConcurrencyStamp = "4", NormalizedName = "Apartment_Delete" },
                new IdentityRole { Name = "Apartment_DeleteMultiple", ConcurrencyStamp = "4", NormalizedName = "Apartment_DeleteMultiple" },
                new IdentityRole { Name = "Apartment_GetAll", ConcurrencyStamp = "4", NormalizedName = "Apartment_GetAll" },
                new IdentityRole { Name = "Apartment_GetById", ConcurrencyStamp = "4", NormalizedName = "Apartment_GetById" },

                new IdentityRole { Name = "User_Create", ConcurrencyStamp = "4", NormalizedName = "User_Create" },
                new IdentityRole { Name = "User_Update", ConcurrencyStamp = "4", NormalizedName = "User_Update" },
                new IdentityRole { Name = "User_Delete", ConcurrencyStamp = "4", NormalizedName = "User_Delete" },
                new IdentityRole { Name = "User_DeleteMultiple", ConcurrencyStamp = "4", NormalizedName = "User_DeleteMultiple" },
                new IdentityRole { Name = "User_GetAll", ConcurrencyStamp = "4", NormalizedName = "User_GetAll" },
                new IdentityRole { Name = "User_GetById", ConcurrencyStamp = "4", NormalizedName = "User_GetById" },

                new IdentityRole { Name = "Resident_Create", ConcurrencyStamp = "4", NormalizedName = "Resident_Create" },
                new IdentityRole { Name = "Resident_Update", ConcurrencyStamp = "4", NormalizedName = "Resident_Update" },
                new IdentityRole { Name = "Resident_Delete", ConcurrencyStamp = "4", NormalizedName = "Resident_Delete" },
                new IdentityRole { Name = "Resident_DeleteMultiple", ConcurrencyStamp = "4", NormalizedName = "Resident_DeleteMultiple" },
                new IdentityRole { Name = "Resident_GetAll", ConcurrencyStamp = "4", NormalizedName = "Resident_GetAll" },
                new IdentityRole { Name = "Resident_GetById", ConcurrencyStamp = "4", NormalizedName = "Resident_GetById" },

                new IdentityRole { Name = "Permission_Create", ConcurrencyStamp = "4", NormalizedName = "Permission_Create" },
                new IdentityRole { Name = "Permission_Update", ConcurrencyStamp = "4", NormalizedName = "Permission_Update" },
                new IdentityRole { Name = "Permission_Delete", ConcurrencyStamp = "4", NormalizedName = "Permission_Delete" },
                new IdentityRole { Name = "Permission_DeleteMultiple", ConcurrencyStamp = "4", NormalizedName = "Permission_DeleteMultiple" },
                new IdentityRole { Name = "Permission_GetAll", ConcurrencyStamp = "4", NormalizedName = "Permission_GetAll" },
                new IdentityRole { Name = "Permission_GetById", ConcurrencyStamp = "4", NormalizedName = "Permission_GetById" },

                new IdentityRole { Name = "Customer_Create", ConcurrencyStamp = "4", NormalizedName = "Customer_Create" },
                new IdentityRole { Name = "Customer_Update", ConcurrencyStamp = "4", NormalizedName = "Customer_Update" },
                new IdentityRole { Name = "Customer_Delete", ConcurrencyStamp = "4", NormalizedName = "Customer_Delete" },
                new IdentityRole { Name = "Customer_DeleteMultiple", ConcurrencyStamp = "4", NormalizedName = "Customer_DeleteMultiple" },
                new IdentityRole { Name = "Customer_GetAll", ConcurrencyStamp = "4", NormalizedName = "Customer_GetAll" },
                new IdentityRole { Name = "Customer_GetById", ConcurrencyStamp = "4", NormalizedName = "Customer_GetById" },
                new IdentityRole { Name = "UrbanArea_Create", ConcurrencyStamp = "4", NormalizedName = "UrbanArea_Create" },
            new IdentityRole { Name = "UrbanArea_Update", ConcurrencyStamp = "4", NormalizedName = "UrbanArea_Update" },
            new IdentityRole { Name = "UrbanArea_Delete", ConcurrencyStamp = "4", NormalizedName = "UrbanArea_Delete" },
            new IdentityRole { Name = "UrbanArea_DeleteMultiple", ConcurrencyStamp = "4", NormalizedName = "UrbanArea_DeleteMultiple" },
            new IdentityRole { Name = "UrbanArea_GetAll", ConcurrencyStamp = "4", NormalizedName = "UrbanArea_GetAll" },
            new IdentityRole { Name = "UrbanArea_GetById", ConcurrencyStamp = "4", NormalizedName = "UrbanArea_GetById" },

            new IdentityRole { Name = "BuildingCategorie_Create", ConcurrencyStamp = "4", NormalizedName = "BuildingCategorie_Create" },
            new IdentityRole { Name = "BuildingCategorie_Update", ConcurrencyStamp = "4", NormalizedName = "BuildingCategorie_Update" },
            new IdentityRole { Name = "BuildingCategorie_Delete", ConcurrencyStamp = "4", NormalizedName = "BuildingCategorie_Delete" },
            new IdentityRole { Name = "BuildingCategorie_DeleteMultiple", ConcurrencyStamp = "4", NormalizedName = "BuildingCategorie_DeleteMultiple" },
            new IdentityRole { Name = "BuildingCategorie_GetAll", ConcurrencyStamp = "4", NormalizedName = "BuildingCategorie_GetAll" },
            new IdentityRole { Name = "BuildingCategorie_GetById", ConcurrencyStamp = "4", NormalizedName = "BuildingCategorie_GetById" },


            new IdentityRole { Name = "Addresse_Create", ConcurrencyStamp = "4", NormalizedName = "Addresse_Create" },
            new IdentityRole { Name = "Addresse_Update", ConcurrencyStamp = "4", NormalizedName = "Addresse_Update" },
            new IdentityRole { Name = "Addresse_Delete", ConcurrencyStamp = "4", NormalizedName = "Addresse_Delete" },
            new IdentityRole { Name = "Addresse_DeleteMultiple", ConcurrencyStamp = "4", NormalizedName = "Addresse_DeleteMultiple" },
            new IdentityRole { Name = "Addresse_GetAll", ConcurrencyStamp = "4", NormalizedName = "Addresse_GetAll" },
            new IdentityRole { Name = "Addresse_GetById", ConcurrencyStamp = "4", NormalizedName = "Addresse_GetById" },
                        new IdentityRole { Name = "Admin", ConcurrencyStamp = "4", NormalizedName = "Admin" }
            );
        }
    }
}
