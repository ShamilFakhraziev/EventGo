using EventGo.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGo.Database
{
    public class AppDbContext: IdentityDbContext<User>
    {
        public DbSet<Event> Events { get; set; }

        public DbSet<UserEvent> UserEvents { get;set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<UserEvent>().HasKey(ue => new { ue.UserId ,ue.EventId });
            builder.Entity<Event>().HasKey(e => e.Id);
            builder.Entity<Event>().HasData(new Event { Id = 1, Name = "Планетарий № 1", Description = "Это классное мероприятие", UserId = "2", NumberOfSeats = 10, DateOfTheEvent = DateTime.Now, Image = null, Location = "наб. Обводного канала, д. 74ц" }) ;

            builder.Entity<User>().ToTable("Users", "dbo");
            builder.Entity<User>().Property(u => u.Balance).HasDefaultValue(0);
            builder.Entity<User>().Ignore(c => c.EmailConfirmed)
                                          .Ignore(c => c.PhoneNumberConfirmed)
                                          .Ignore(c => c.TwoFactorEnabled);

            builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims");
            builder.Entity<IdentityRole>().ToTable("Roles");
            builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims");
            builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins");
            builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles");
            builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens");

            builder.Entity<User>().Property(p => p.Name).HasMaxLength(450);
            builder.Entity<User>().Property(p => p.Address).HasMaxLength(450);
            builder.Entity<User>().Property(p => p.PhoneNumber).HasMaxLength(15);
            builder.Entity<User>().HasData(
            new User
            {
                Id = "1",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@mail.ru",
                NormalizedEmail = "ADMIN@MAIL.RU",
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "admin123")
            },
            new User
            {
                Id = "3",
                UserName = "alex",
                NormalizedUserName = "ALEX",
                Email = "alex@mail.ru",
                NormalizedEmail = "ALEX@MAIL.RU",
                Name = "Ivanov Alexander",
                Address = "Санкт-Петербург, ул. Невский проспект, д 41, кв 3",
                Balance = (decimal) 400.5,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "alex123")
            },
            new User
            {
                Id = "2",
                UserName = "planetarium",
                NormalizedUserName = "PLANETARIUM",
                Email = "planetarium@mail.ru",
                NormalizedEmail = "PLANETARIUM@MAIL.RU",
                Name = "Планетарий № 1",
                Address = "наб. Обводного канала, 74Ц, Санкт-Петербург",
                Balance = 0,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "planetarium123")
            },
            new User
            {
                Id = "4",
                UserName = "uncorg",
                NormalizedUserName = "UNCORG",
                Email = "uncorg@mail.ru",
                NormalizedEmail = "UNCORG@MAIL.RU",
                Name = "Непотвержденный организатор тестовый",
                Address = "наб. Обводного канала, 74Ц, Санкт-Петербург",
                Balance = 0,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "uncorg123")
            }
            );
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "1",
                    Name = "admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Id = "2",
                    Name = "organizer",
                    NormalizedName = "ORGANIZER"
                },
                new IdentityRole
                {
                    Id = "3",
                    Name = "unconfirmed organizer",
                    NormalizedName = "UNCONFIRMED ORGANIZER"
                }
                );
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "1",
                    UserId = "1"
                }, 
                new IdentityUserRole<string>
                {
                    RoleId = "2",
                    UserId = "2"
                }, 
                new IdentityUserRole<string>
                {
                    RoleId = "3",
                    UserId = "4"
                }
                );
        }
    }
}
