using Cityton.Data.Models;
using Cityton.Data.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;

namespace Cityton.Repository
{
    public static class SeedDB
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            /*
            *   Company
            */
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

            /*
            *   User
            */
            byte[] passwordHash, passwordSalt;

            CreatePasswordHash("123", out passwordHash, out passwordSalt);

            User[] users = new User[] {
                new User { Id = 1, Username = "admin01", PhoneNumber = "6019911684 ", Email = "admin01@gmail.com", Role = Role.Admin, PasswordHash = passwordHash, PasswordSalt = passwordSalt, CompanyId = 1 },
                new User { Id = 2, Username = "admin02", PhoneNumber = "3069338796 ", Email = "admin02@gmail.com", Role = Role.Admin, PasswordHash = passwordHash, PasswordSalt = passwordSalt, CompanyId = 1 },
                new User { Id = 3, Username = "admin03", PhoneNumber = "105989609 ", Email = "admin03@gmail.com", Role = Role.Admin, PasswordHash = passwordHash, PasswordSalt = passwordSalt, CompanyId = 1 },
                new User { Id = 4, Username = "admin04", PhoneNumber = "4866078694 ", Email = "admin04@gmail.com", Role = Role.Admin, PasswordHash = passwordHash, PasswordSalt = passwordSalt, CompanyId = 1 },
                new User { Id = 5, Username = "admin05", PhoneNumber = "8659710084 ", Email = "admin05@gmail.com", Role = Role.Admin, PasswordHash = passwordHash, PasswordSalt = passwordSalt, CompanyId = 1 },
                new User { Id = 6, Username = "checker01", PhoneNumber = "5844956388 ", Email = "checker01@gmail.com", Role = Role.Checker, PasswordHash = passwordHash, PasswordSalt = passwordSalt, CompanyId = 1 },
                new User { Id = 7, Username = "checker02", PhoneNumber = "1669765414 ", Email = "checker02@gmail.com", Role = Role.Checker, PasswordHash = passwordHash, PasswordSalt = passwordSalt, CompanyId = 1 },
                new User { Id = 8, Username = "checker03", PhoneNumber = "5598781614 ", Email = "checker03@gmail.com", Role = Role.Checker, PasswordHash = passwordHash, PasswordSalt = passwordSalt, CompanyId = 1 },
                new User { Id = 9, Username = "member01", PhoneNumber = "3272464106 ", Email = "member01@gmail.com", Role = Role.Member, PasswordHash = passwordHash, PasswordSalt = passwordSalt, CompanyId = 1 },
                new User { Id = 10, Username = "member02", PhoneNumber = "5414887288 ", Email = "member02@gmail.com", Role = Role.Member, PasswordHash = passwordHash, PasswordSalt = passwordSalt, CompanyId = 1 },
                new User { Id = 11, Username = "member03", PhoneNumber = "4786399505 ", Email = "member03@gmail.com", Role = Role.Member, PasswordHash = passwordHash, PasswordSalt = passwordSalt, CompanyId = 1 },
                new User { Id = 12, Username = "member04", PhoneNumber = "2358305614 ", Email = "member04@gmail.com", Role = Role.Member, PasswordHash = passwordHash, PasswordSalt = passwordSalt, CompanyId = 1 },
                new User { Id = 13, Username = "member05", PhoneNumber = "1064846605 ", Email = "member05@gmail.com", Role = Role.Member, PasswordHash = passwordHash, PasswordSalt = passwordSalt, CompanyId = 1 },
                new User { Id = 14, Username = "member06", PhoneNumber = "4686272886 ", Email = "member06@gmail.com", Role = Role.Member, PasswordHash = passwordHash, PasswordSalt = passwordSalt, CompanyId = 1 },
                new User { Id = 15, Username = "member07", PhoneNumber = "5071973872 ", Email = "member07@gmail.com", Role = Role.Member, PasswordHash = passwordHash, PasswordSalt = passwordSalt, CompanyId = 1 },
                new User { Id = 16, Username = "member08", PhoneNumber = "334355105 ", Email = "member08@gmail.com", Role = Role.Member, PasswordHash = passwordHash, PasswordSalt = passwordSalt, CompanyId = 1 },
                new User { Id = 17, Username = "member09", PhoneNumber = "5471673152 ", Email = "member09@gmail.com", Role = Role.Member, PasswordHash = passwordHash, PasswordSalt = passwordSalt, CompanyId = 1 },
                new User { Id = 18, Username = "member10", PhoneNumber = "8758801056", Email = "member10@gmail.com", Role = Role.Member, PasswordHash = passwordHash, PasswordSalt = passwordSalt, CompanyId = 1 }
            };

            foreach (var user in users)
            {
                CreateToken(user);

            }

            modelBuilder.Entity<User>().HasData(
                users
            );

            /*
            *   Challenge
            */
            modelBuilder.Entity<Challenge>().HasData(
                new Challenge { Id = 1, Statement = "Faire une photo avec un chien", Name = "Chien trop chou", Status = Status.Accepted, CreatedAt = new DateTime(2019, 01, 02), AuthorId = 1 },
                new Challenge { Id = 2, Statement = "Avoir le numéro de quelqu'un", Name = "Début d'un amour", Status = Status.Accepted, CreatedAt = new DateTime(2019, 01, 05), AuthorId = 1 },
                new Challenge { Id = 3, Statement = "Faire une vidéo devant l'Atomium", Name = "Ô belles boules", Status = Status.Accepted, CreatedAt = new DateTime(2019, 01, 02), AuthorId = 4 },
                new Challenge { Id = 4, Statement = "Faire une photo sur la grande place", Name = "Grande mais petite", Status = Status.Waiting, CreatedAt = new DateTime(2019, 01, 03), AuthorId = 4 },
                new Challenge { Id = 5, Statement = "Faire une vidéo en mangeant une gauffre", Name = "Bonne et bien chaude", Status = Status.Waiting, CreatedAt = new DateTime(2019, 01, 04), AuthorId = 9 }
            );

            /*
            *   Achieve;ent
            */


            /*
            *   ChallengeGiven
            */


            /*
            *   Group
            */
            Group[] groups = new Group[] {
                new Group { Id = 1, Name = "group01", CreatedAt = new DateTime(2019, 01, 02) }
            };

            modelBuilder.Entity<Group>().HasData(
                groups
            );

            /*
            *   ParticipantGroup
            */
            ParticipantGroup[] ParticipantsGroup = new ParticipantGroup[] {
                new ParticipantGroup { Id = 1, IsCreator = false, Status = Status.Waiting, CreatedAt = new DateTime(2019, 01, 02) }
            };
            
            modelBuilder.Entity<ParticipantGroup>().HasData(
                ParticipantsGroup
            );

            /*
            *   Discussion
            */

            /*
            *   UserInDiscussion
            */

            /*
            *   Message
            */

            /*
            *   Media
            */

        }

        private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            if (password == null) throw new ArgumentNullException("password");

            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Value cannot be empty or whitespace only string.", "password");

            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }

        }

        private static void CreateToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("[35919A8D-76AA-4C29-926C-48E05D317F21]");

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            user.Token = tokenString;
        }
    }
}