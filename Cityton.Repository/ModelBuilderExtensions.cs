using Cityton.Data.Models;
using Cityton.Data.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cityton.Repository
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().HasData(
                new Company
                {
                    Id = 1,
                    Name = "Bruxton",
                    MinGroupSize = 4,
                    MaxGroupSize = 6,
                    CreatedAt = new DateTime(2019, 01, 01)
                }
            );

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Username = "admin01", PhoneNumber = "0123456789", Email = "admin01@gmail.com", Picture = "do\\not\\know", Role = Role.Admin, PasswordHash = new byte[0] , PasswordSalt = new byte[0] },
                new User { Id = 2, Username = "admin02", PhoneNumber = "9876543210", Email = "admin02@gmail.com", Picture = "do\\not\\know", Role = Role.Admin, PasswordHash = new byte[0], PasswordSalt = new byte[0] },
                new User { Id = 3, Username = "admin03", PhoneNumber = "0147852963", Email = "admin03@gmail.com", Picture = "do\\not\\know", Role = Role.Admin, PasswordHash = new byte[0], PasswordSalt = new byte[0] },
                new User { Id = 4, Username = "checker01", PhoneNumber = "3692581470", Email = "checker01@gmail.com", Picture = "do\\not\\know", Role = Role.Checker, PasswordHash = new byte[0], PasswordSalt = new byte[0] },
                new User { Id = 5, Username = "checker02", PhoneNumber = "7539518524", Email = "checker02@gmail.com", Picture = "do\\not\\know", Role = Role.Checker, PasswordHash = new byte[0], PasswordSalt = new byte[0] },
                new User { Id = 6, Username = "member01", PhoneNumber = "4568521593", Email = "member01@gmail.com", Picture = "do\\not\\know", Role = Role.Member, PasswordHash = new byte[0], PasswordSalt = new byte[0] },
                new User { Id = 7, Username = "member02", PhoneNumber = "7419635802", Email = "member02@gmail.com", Picture = "do\\not\\know", Role = Role.Member, PasswordHash = new byte[0], PasswordSalt = new byte[0] },
                new User { Id = 8, Username = "member03", PhoneNumber = "0172839976", Email = "member03@gmail.com", Picture = "do\\not\\know", Role = Role.Member, PasswordHash = new byte[0], PasswordSalt = new byte[0] },
                new User { Id = 9, Username = "member04", PhoneNumber = "7538527419", Email = "member04@gmail.com", Picture = "do\\not\\know", Role = Role.Member, PasswordHash = new byte[0], PasswordSalt = new byte[0] },
                new User { Id = 10, Username = "member05", PhoneNumber = "9638520153", Email = "member05@gmail.com", Picture = "do\\not\\know", Role = Role.Member, PasswordHash = new byte[0], PasswordSalt = new byte[0] },
            );

            modelBuilder.Entity<Challenge>().HasData(
                new Challenge { Id = 1, Statement = "Faire une photo avec un chien", Name = "Chien trop chou", Status = Status.Accepted, CreatedAt = new DateTime(2019, 01, 02), AuthorId = 1 },
                new Challenge { Id = 2, Statement = "Avoir le numéro de quelqu'un", Name = "Début d'un amour", Status = Status.Accepted, CreatedAt = new DateTime(2019, 01, 05), AuthorId = 1 },
                new Challenge { Id = 3, Statement = "Faire une vidéo devant l'Atomium", Name = "Ô belles boules", Status = Status.Accepted, CreatedAt = new DateTime(2019, 01, 02), AuthorId = 4 },
                new Challenge { Id = 4, Statement = "Faire une photo sur la grande place", Name = "Grande mais petite", Status = Status.Waiting, CreatedAt = new DateTime(2019, 01, 03), AuthorId = 4 },
                new Challenge { Id = 5, Statement = "Faire une vidéo en mangeant une gauffre", Name = "Bonne et bien chaude", Status = Status.Waiting, CreatedAt = new DateTime(2019, 01, 04), AuthorId = 9 }
            );

            //modelBuilder.Entity<Achievement>().HasDa
        }
    }
}