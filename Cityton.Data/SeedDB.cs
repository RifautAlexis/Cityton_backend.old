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
            
            byte[] passwordHash, passwordSalt;

            CreatePasswordHash("123", out passwordHash, out passwordSalt);

            List<User> users = new List<User> {
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
                new User { Id = 18, Username = "member10", PhoneNumber = "8758801056", Email = "member10@gmail.com", Role = Role.Member, PasswordHash = passwordHash, PasswordSalt = passwordSalt, CompanyId = 1 },
                new User { Id = 19, Username = "member11", PhoneNumber = "1644035575 ", Email = "member11@gmail.com", Role = Role.Member, PasswordHash = passwordHash, PasswordSalt = passwordSalt, CompanyId = 1 },
                new User { Id = 20, Username = "member12", PhoneNumber = "8414315717 ", Email = "member12@gmail.com", Role = Role.Member, PasswordHash = passwordHash, PasswordSalt = passwordSalt, CompanyId = 1 },
                new User { Id = 21, Username = "member13", PhoneNumber = "4867164497 ", Email = "member13@gmail.com", Role = Role.Member, PasswordHash = passwordHash, PasswordSalt = passwordSalt, CompanyId = 1 },
                new User { Id = 22, Username = "member14", PhoneNumber = "4375563597 ", Email = "member14@gmail.com", Role = Role.Member, PasswordHash = passwordHash, PasswordSalt = passwordSalt, CompanyId = 1 },
                new User { Id = 23, Username = "member15", PhoneNumber = "1303405992 ", Email = "member15@gmail.com", Role = Role.Member, PasswordHash = passwordHash, PasswordSalt = passwordSalt, CompanyId = 1 },
                new User { Id = 24, Username = "member16", PhoneNumber = "8743387328 ", Email = "member16@gmail.com", Role = Role.Member, PasswordHash = passwordHash, PasswordSalt = passwordSalt, CompanyId = 1 },
                new User { Id = 25, Username = "member17", PhoneNumber = "1653986846 ", Email = "member17@gmail.com", Role = Role.Member, PasswordHash = passwordHash, PasswordSalt = passwordSalt, CompanyId = 1 },
                new User { Id = 26, Username = "member18", PhoneNumber = "2923858299 ", Email = "member18@gmail.com", Role = Role.Member, PasswordHash = passwordHash, PasswordSalt = passwordSalt, CompanyId = 1 },
                new User { Id = 27, Username = "member19", PhoneNumber = "3534047331 ", Email = "member19@gmail.com", Role = Role.Member, PasswordHash = passwordHash, PasswordSalt = passwordSalt, CompanyId = 1 },
                new User { Id = 28, Username = "member20", PhoneNumber = "2817549444 ", Email = "member20@gmail.com", Role = Role.Member, PasswordHash = passwordHash, PasswordSalt = passwordSalt, CompanyId = 1 },
                new User { Id = 29, Username = "member21", PhoneNumber = "8865276623 ", Email = "member21@gmail.com", Role = Role.Member, PasswordHash = passwordHash, PasswordSalt = passwordSalt, CompanyId = 1 },
                new User { Id = 30, Username = "member22", PhoneNumber = "5491062337 ", Email = "member22@gmail.com", Role = Role.Member, PasswordHash = passwordHash, PasswordSalt = passwordSalt, CompanyId = 1 },
                new User { Id = 31, Username = "member23", PhoneNumber = "8547534376 ", Email = "member23@gmail.com", Role = Role.Member, PasswordHash = passwordHash, PasswordSalt = passwordSalt, CompanyId = 1 },
                new User { Id = 32, Username = "member24", PhoneNumber = "1691707740 ", Email = "member24@gmail.com", Role = Role.Member, PasswordHash = passwordHash, PasswordSalt = passwordSalt, CompanyId = 1 },
                new User { Id = 33, Username = "member25", PhoneNumber = "3483061802 ", Email = "member25@gmail.com", Role = Role.Member, PasswordHash = passwordHash, PasswordSalt = passwordSalt, CompanyId = 1 },
                new User { Id = 34, Username = "member26", PhoneNumber = "5955468148 ", Email = "member26@gmail.com", Role = Role.Member, PasswordHash = passwordHash, PasswordSalt = passwordSalt, CompanyId = 1 },
                new User { Id = 35, Username = "member27", PhoneNumber = "4206283982 ", Email = "member27@gmail.com", Role = Role.Member, PasswordHash = passwordHash, PasswordSalt = passwordSalt, CompanyId = 1 },
                new User { Id = 36, Username = "member28", PhoneNumber = "2088176734", Email = "member28@gmail.com", Role = Role.Member, PasswordHash = passwordHash, PasswordSalt = passwordSalt, CompanyId = 1 },
                new User { Id = 37, Username = "member29", PhoneNumber = "5838001888 ", Email = "member29@gmail.com", Role = Role.Member, PasswordHash = passwordHash, PasswordSalt = passwordSalt, CompanyId = 1 },
                new User { Id = 38, Username = "member30", PhoneNumber = "5475604706", Email = "member30@gmail.com", Role = Role.Member, PasswordHash = passwordHash, PasswordSalt = passwordSalt, CompanyId = 1 },
                new User { Id = 39, Username = "member31", PhoneNumber = "3419759237 ", Email = "member31@gmail.com", Role = Role.Member, PasswordHash = passwordHash, PasswordSalt = passwordSalt, CompanyId = 1 },
                new User { Id = 40, Username = "member32", PhoneNumber = "8137152193 ", Email = "member32@gmail.com", Role = Role.Member, PasswordHash = passwordHash, PasswordSalt = passwordSalt, CompanyId = 1 },
                new User { Id = 41, Username = "member33", PhoneNumber = "9675495629 ", Email = "member33@gmail.com", Role = Role.Member, PasswordHash = passwordHash, PasswordSalt = passwordSalt, CompanyId = 1 },
                new User { Id = 42, Username = "member34", PhoneNumber = "5161342920 ", Email = "member34@gmail.com", Role = Role.Member, PasswordHash = passwordHash, PasswordSalt = passwordSalt, CompanyId = 1 },
                new User { Id = 43, Username = "member35", PhoneNumber = "4616055914 ", Email = "member35@gmail.com", Role = Role.Member, PasswordHash = passwordHash, PasswordSalt = passwordSalt, CompanyId = 1 },
                new User { Id = 44, Username = "member36", PhoneNumber = "1531092443 ", Email = "member36@gmail.com", Role = Role.Member, PasswordHash = passwordHash, PasswordSalt = passwordSalt, CompanyId = 1 },
                new User { Id = 45, Username = "member37", PhoneNumber = "3324710359 ", Email = "member37@gmail.com", Role = Role.Member, PasswordHash = passwordHash, PasswordSalt = passwordSalt, CompanyId = 1 },
                new User { Id = 46, Username = "member38", PhoneNumber = "8667200845 ", Email = "member38@gmail.com", Role = Role.Member, PasswordHash = passwordHash, PasswordSalt = passwordSalt, CompanyId = 1 },
                new User { Id = 47, Username = "member39", PhoneNumber = "7849609736", Email = "member39@gmail.com", Role = Role.Member, PasswordHash = passwordHash, PasswordSalt = passwordSalt, CompanyId = 1 },
                new User { Id = 48, Username = "member40", PhoneNumber = "6559816496 ", Email = "member40@gmail.com", Role = Role.Member, PasswordHash = passwordHash, PasswordSalt = passwordSalt, CompanyId = 1 }
            };

            foreach (var user in users)
            {
                CreateToken(user);
            }

            List<Group> groups = new List<Group> {
                new Group { Id = 1, Name = "group01", CreatedAt = new DateTime(2019, 02, 01) },
                new Group { Id = 2, Name = "group02", CreatedAt = new DateTime(2019, 02, 10) },
                new Group { Id = 3, Name = "group03", CreatedAt = new DateTime(2019, 03, 11) },
                new Group { Id = 4, Name = "group04", CreatedAt = new DateTime(2019, 03, 11) },
                new Group { Id = 5, Name = "group05", CreatedAt = new DateTime(2019, 04, 03) },
                new Group { Id = 6, Name = "group06", CreatedAt = new DateTime(2019, 05, 05) },
            };

            List<ParticipantGroup> participantsGroup = new List<ParticipantGroup> {
                new ParticipantGroup { Id = 1, IsCreator = true, Status = Status.Accepted, CreatedAt = new DateTime(2019, 02, 01), BelongingGroupId = 1, UserId = 9 },
                new ParticipantGroup { Id = 2, IsCreator = false, Status = Status.Accepted, CreatedAt = new DateTime(2019, 02, 04), BelongingGroupId = 1, UserId = 48 },
                new ParticipantGroup { Id = 3, IsCreator = false, Status = Status.Accepted, CreatedAt = new DateTime(2019, 03, 15), BelongingGroupId = 1, UserId = 24 },
                new ParticipantGroup { Id = 4, IsCreator = false, Status = Status.Accepted, CreatedAt = new DateTime(2019, 03, 22), BelongingGroupId = 1, UserId = 29 },
                new ParticipantGroup { Id = 5, IsCreator = true, Status = Status.Accepted, CreatedAt = new DateTime(2019, 02, 10), BelongingGroupId = 2, UserId = 10 },
                new ParticipantGroup { Id = 6, IsCreator = false, Status = Status.Accepted, CreatedAt = new DateTime(2019, 02, 11), BelongingGroupId = 2, UserId = 20 },
                new ParticipantGroup { Id = 7, IsCreator = false, Status = Status.Accepted, CreatedAt = new DateTime(2019, 02, 11), BelongingGroupId = 2, UserId = 18 },
                new ParticipantGroup { Id = 8, IsCreator = false, Status = Status.Accepted, CreatedAt = new DateTime(2019, 03, 18), BelongingGroupId = 2, UserId = 38 },
                new ParticipantGroup { Id = 9, IsCreator = false, Status = Status.Accepted, CreatedAt = new DateTime(2019, 04, 24), BelongingGroupId = 2, UserId = 17 },
                new ParticipantGroup { Id = 10, IsCreator = true, Status = Status.Accepted, CreatedAt = new DateTime(2019, 03, 11), BelongingGroupId = 3, UserId = 12 },
                new ParticipantGroup { Id = 11, IsCreator = true, Status = Status.Accepted, CreatedAt = new DateTime(2019, 03, 11), BelongingGroupId = 4, UserId = 13 },
                new ParticipantGroup { Id = 12, IsCreator = false, Status = Status.Accepted, CreatedAt = new DateTime(2019, 03, 19), BelongingGroupId = 4, UserId = 14 },
                new ParticipantGroup { Id = 13, IsCreator = true, Status = Status.Accepted, CreatedAt = new DateTime(2019, 04, 03), BelongingGroupId = 5, UserId = 25 },
                new ParticipantGroup { Id = 14, IsCreator = false, Status = Status.Accepted, CreatedAt = new DateTime(2019, 04, 06), BelongingGroupId = 5, UserId = 16 },
                new ParticipantGroup { Id = 15, IsCreator = false, Status = Status.Accepted, CreatedAt = new DateTime(2019, 04, 09), BelongingGroupId = 5, UserId = 15 },
                new ParticipantGroup { Id = 16, IsCreator = false, Status = Status.Accepted, CreatedAt = new DateTime(2019, 04, 26), BelongingGroupId = 5, UserId = 19 },
                new ParticipantGroup { Id = 17, IsCreator = true, Status = Status.Accepted, CreatedAt = new DateTime(2019, 05, 05), BelongingGroupId = 6, UserId = 23 },
                new ParticipantGroup { Id = 18, IsCreator = false, Status = Status.Waiting, CreatedAt = new DateTime(2019, 02, 03), BelongingGroupId = 1, UserId = 40 },
                new ParticipantGroup { Id = 19, IsCreator = false, Status = Status.Waiting, CreatedAt = new DateTime(2019, 04, 09), BelongingGroupId = 2, UserId = 36 },
                new ParticipantGroup { Id = 20, IsCreator = false, Status = Status.Waiting, CreatedAt = new DateTime(2019, 04, 30), BelongingGroupId = 2, UserId = 26 },
                new ParticipantGroup { Id = 21, IsCreator = false, Status = Status.Waiting, CreatedAt = new DateTime(2019, 03, 12), BelongingGroupId = 3, UserId = 22 },
                new ParticipantGroup { Id = 22, IsCreator = false, Status = Status.Waiting, CreatedAt = new DateTime(2019, 03, 20), BelongingGroupId = 3, UserId = 28 },
                new ParticipantGroup { Id = 23, IsCreator = false, Status = Status.Waiting, CreatedAt = new DateTime(2019, 03, 21), BelongingGroupId = 3, UserId = 31 },
                new ParticipantGroup { Id = 24, IsCreator = false, Status = Status.Waiting, CreatedAt = new DateTime(2019, 06, 27), BelongingGroupId = 6, UserId = 35 }
            };

            modelBuilder.Entity<User>().HasData(
                users
            );

            modelBuilder.Entity<Group>().HasData(
                groups
            );

            modelBuilder.Entity<ParticipantGroup>().HasData(
                participantsGroup
            );

            modelBuilder.Entity<Challenge>().HasData(
                new Challenge { Id = 1, Statement = "Faire une photo avec un chien", Name = "Chien trop chou", Status = Status.Accepted, CreatedAt = new DateTime(2019, 01, 02), AuthorId = 1 },
                new Challenge { Id = 2, Statement = "Avoir le numéro de quelqu'un", Name = "Début d'un amour", Status = Status.Accepted, CreatedAt = new DateTime(2019, 01, 05), AuthorId = 1 },
                new Challenge { Id = 3, Statement = "Faire une vidéo devant l'Atomium", Name = "Ô belles boules", Status = Status.Accepted, CreatedAt = new DateTime(2019, 01, 02), AuthorId = 6 },
                new Challenge { Id = 4, Statement = "Faire une photo sur la grande place", Name = "Grande mais petite", Status = Status.Waiting, CreatedAt = new DateTime(2019, 01, 03), AuthorId = 25 },
                new Challenge { Id = 5, Statement = "Faire une vidéo en mangeant une gauffre", Name = "Bonne et bien chaude", Status = Status.Waiting, CreatedAt = new DateTime(2019, 01, 04), AuthorId = 14 },
                new Challenge { Id = 6, Statement = "Faire une photo avec un chat", Name = "Chat trop chou", Status = Status.Accepted, CreatedAt = new DateTime(2020, 01, 02), AuthorId = 16 },
                new Challenge { Id = 7, Statement = "Faire une photo devant la statue XXX", Name = "Ô belle statue", Status = Status.Accepted, CreatedAt = new DateTime(2020, 07, 14), AuthorId = 38 },
                new Challenge { Id = 8, Statement = "Faire une vidéo devant le monument XXX", Name = "Toi que l'on ne connait pas", Status = Status.Waiting, CreatedAt = new DateTime(2019, 09, 25), AuthorId = 40 },
                new Challenge { Id = 9, Statement = "Faire une photo avec des touristes", Name = "De nouveaux amis !", Status = Status.Accepted, CreatedAt = new DateTime(2019, 04, 03), AuthorId = 31 },
                new Challenge { Id = 10, Statement = "Faire une photo en sautant", Name = "Jump ! Jump ! Jump !", Status = Status.Accepted, CreatedAt = new DateTime(2020, 01, 30), AuthorId = 31 },
                new Challenge { Id = 11, Statement = "Faire une photo Avec un inconnu en lui faisant un bisou", Name = "Belle inconnu", Status = Status.Waiting, CreatedAt = new DateTime(2019, 08, 23), AuthorId = null },
                new Challenge { Id = 12, Statement = "Faire une photo sur la place XXX", Name = "Ho une place ! Photo, photo !", Status = Status.Accepted, CreatedAt = new DateTime(2019, 07, 13), AuthorId = null },
                new Challenge { Id = 13, Statement = "Faire une photo dans un photo bombing", Name = "Inception", Status = Status.Accepted, CreatedAt = new DateTime(2020, 01, 09), AuthorId = null }
            );

            modelBuilder.Entity<Achievement>().HasData(
                new Achievement { Id = 1, UnlockedAt = new DateTime(2019, 01, 09), WinnerId = 18, FromChallengeId = 1 },
                new Achievement { Id = 2, UnlockedAt = new DateTime(2019, 01, 09), WinnerId = 25, FromChallengeId = 1 },
                new Achievement { Id = 3, UnlockedAt = new DateTime(2019, 04, 15), WinnerId = 32, FromChallengeId = 10 },
                new Achievement { Id = 4, UnlockedAt = new DateTime(2019, 04, 15), WinnerId = 32, FromChallengeId = 2 },
                new Achievement { Id = 5, UnlockedAt = new DateTime(2019, 04, 15), WinnerId = 32, FromChallengeId = 6 },
                new Achievement { Id = 6, UnlockedAt = new DateTime(2019, 04, 16), WinnerId = 26, FromChallengeId = 6 },
                new Achievement { Id = 7, UnlockedAt = new DateTime(2019, 05, 28), WinnerId = 40, FromChallengeId = 2 },
                new Achievement { Id = 8, UnlockedAt = new DateTime(2019, 05, 28), WinnerId = 14, FromChallengeId = 2 },
                new Achievement { Id = 9, UnlockedAt = new DateTime(2019, 08, 20), WinnerId = 19, FromChallengeId = 1 },
                new Achievement { Id = 10, UnlockedAt = new DateTime(2019, 08, 20), WinnerId = 19, FromChallengeId = 3 },
                new Achievement { Id = 11, UnlockedAt = new DateTime(2019, 08, 20), WinnerId = 11, FromChallengeId = 3 },
                new Achievement { Id = 12, UnlockedAt = new DateTime(2019, 08, 20), WinnerId = 17, FromChallengeId = 3 },
                new Achievement { Id = 13, UnlockedAt = new DateTime(2019, 08, 20), WinnerId = 28, FromChallengeId = 3 },
                new Achievement { Id = 14, UnlockedAt = new DateTime(2019, 09, 14), WinnerId = 9, FromChallengeId = 3 },
                new Achievement { Id = 16, UnlockedAt = new DateTime(2019, 10, 04), WinnerId = 36, FromChallengeId = 1 },
                new Achievement { Id = 17, UnlockedAt = new DateTime(2019, 10, 04), WinnerId = 36, FromChallengeId = 6 },
                new Achievement { Id = 18, UnlockedAt = new DateTime(2019, 12, 08), WinnerId = 26, FromChallengeId = 9 },
                new Achievement { Id = 19, UnlockedAt = new DateTime(2019, 12, 09), WinnerId = 25, FromChallengeId = 7 },
                new Achievement { Id = 20, UnlockedAt = new DateTime(2019, 12, 10), WinnerId = 27, FromChallengeId = 7 },
                new Achievement { Id = 21, UnlockedAt = new DateTime(2020, 01, 13), WinnerId = 9, FromChallengeId = 1 },
                new Achievement { Id = 22, UnlockedAt = new DateTime(2020, 01, 13), WinnerId = 48, FromChallengeId = 1 },
                new Achievement { Id = 23, UnlockedAt = new DateTime(2020, 01, 13), WinnerId = 24, FromChallengeId = 1 },
                new Achievement { Id = 24, UnlockedAt = new DateTime(2020, 01, 13), WinnerId = 29, FromChallengeId = 1 },
                new Achievement { Id = 25, UnlockedAt = new DateTime(2020, 01, 13), WinnerId = 9, FromChallengeId = 2 },
                new Achievement { Id = 26, UnlockedAt = new DateTime(2020, 01, 13), WinnerId = 48, FromChallengeId = 2 },
                new Achievement { Id = 27, UnlockedAt = new DateTime(2020, 01, 13), WinnerId = 24, FromChallengeId = 2 },
                new Achievement { Id = 28, UnlockedAt = new DateTime(2020, 01, 13), WinnerId = 29, FromChallengeId = 2 },
                new Achievement { Id = 29, UnlockedAt = new DateTime(2020, 01, 15), WinnerId = 12, FromChallengeId = 9 },
                new Achievement { Id = 30, UnlockedAt = new DateTime(2020, 01, 15), WinnerId = 12, FromChallengeId = 4 },
                new Achievement { Id = 31, UnlockedAt = new DateTime(2020, 01, 15), WinnerId = 12, FromChallengeId = 2 }
            );

            modelBuilder.Entity<ChallengeGiven>().HasData(
                new ChallengeGiven { Id = 1, Status = StatusChallenge.Validated, ChallengeId = 1, ChallengedGroupId = 1 },
                new ChallengeGiven { Id = 2, Status = StatusChallenge.Validated, ChallengeId = 2, ChallengedGroupId = 1 },
                new ChallengeGiven { Id = 3, Status = StatusChallenge.InProgress, ChallengeId = 3, ChallengedGroupId = 1 },
                new ChallengeGiven { Id = 4, Status = StatusChallenge.Rejected, ChallengeId = 7, ChallengedGroupId = 1 },
                new ChallengeGiven { Id = 5, Status = StatusChallenge.Rejected, ChallengeId = 9, ChallengedGroupId = 1 },
                new ChallengeGiven { Id = 6, Status = StatusChallenge.InProgress, ChallengeId = 1, ChallengedGroupId = 2 },
                new ChallengeGiven { Id = 7, Status = StatusChallenge.InProgress, ChallengeId = 7, ChallengedGroupId = 2 },
                new ChallengeGiven { Id = 8, Status = StatusChallenge.InProgress, ChallengeId = 2, ChallengedGroupId = 2 },
                new ChallengeGiven { Id = 9, Status = StatusChallenge.Validated, ChallengeId = 9, ChallengedGroupId = 3 },
                new ChallengeGiven { Id = 10, Status = StatusChallenge.Validated, ChallengeId = 4, ChallengedGroupId = 3 },
                new ChallengeGiven { Id = 11, Status = StatusChallenge.Validated, ChallengeId = 2, ChallengedGroupId = 3 },
                new ChallengeGiven { Id = 12, Status = StatusChallenge.InProgress, ChallengeId = 1, ChallengedGroupId = 4 },
                new ChallengeGiven { Id = 13, Status = StatusChallenge.InProgress, ChallengeId = 9, ChallengedGroupId = 4 },
                new ChallengeGiven { Id = 14, Status = StatusChallenge.Rejected, ChallengeId = 2, ChallengedGroupId = 5 },
                new ChallengeGiven { Id = 15, Status = StatusChallenge.Rejected, ChallengeId = 3, ChallengedGroupId = 5 },
                new ChallengeGiven { Id = 16, Status = StatusChallenge.InProgress, ChallengeId = 1, ChallengedGroupId = 5 }
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
                    new Claim(ClaimTypes.Name, user.Id.ToString()),
                    new Claim(ClaimTypes.Role, user.Role.ToString())
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