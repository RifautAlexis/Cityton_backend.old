using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cityton.Repository.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    MinGroupSize = table.Column<int>(nullable: false),
                    MaxGroupSize = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Discussions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discussions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Picture = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 10, nullable: true),
                    Email = table.Column<string>(nullable: false),
                    Picture = table.Column<string>(nullable: false),
                    Role = table.Column<int>(nullable: false),
                    PasswordHash = table.Column<byte[]>(nullable: false),
                    PasswordSalt = table.Column<byte[]>(nullable: false),
                    Token = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Challenges",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Statement = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    AuthorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Challenges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Challenges_Users_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Content = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    AuthorId = table.Column<int>(nullable: false),
                    DiscussionId = table.Column<int>(nullable: false),
                    MediaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_Users_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Messages_Discussions_DiscussionId",
                        column: x => x.DiscussionId,
                        principalTable: "Discussions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParticipantGroups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IsCreator = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    BelongingGroupId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParticipantGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParticipantGroups_Groups_BelongingGroupId",
                        column: x => x.BelongingGroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParticipantGroups_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsersInDiscussion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    JoinedAt = table.Column<DateTime>(nullable: false),
                    ParticipantId = table.Column<int>(nullable: false),
                    DiscussionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersInDiscussion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsersInDiscussion_Discussions_DiscussionId",
                        column: x => x.DiscussionId,
                        principalTable: "Discussions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsersInDiscussion_Users_ParticipantId",
                        column: x => x.ParticipantId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Achievements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UnlockedAt = table.Column<DateTime>(nullable: false),
                    WinnerId = table.Column<int>(nullable: false),
                    FromChallengeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Achievements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Achievements_Challenges_FromChallengeId",
                        column: x => x.FromChallengeId,
                        principalTable: "Challenges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Achievements_Users_WinnerId",
                        column: x => x.WinnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChallengesGiven",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<int>(nullable: false),
                    ChallengeId = table.Column<int>(nullable: false),
                    ChallengedGroupId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChallengesGiven", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChallengesGiven_Challenges_ChallengeId",
                        column: x => x.ChallengeId,
                        principalTable: "Challenges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChallengesGiven_Groups_ChallengedGroupId",
                        column: x => x.ChallengedGroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Medias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Location = table.Column<string>(nullable: false),
                    Extension = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<string>(nullable: false),
                    MessageId = table.Column<int>(nullable: true),
                    ContainedInId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Medias_Messages_MessageId",
                        column: x => x.MessageId,
                        principalTable: "Messages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CreatedAt", "MaxGroupSize", "MinGroupSize", "Name" },
                values: new object[] { 1, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 4, "Bruxton" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CompanyId", "Email", "PasswordHash", "PasswordSalt", "PhoneNumber", "Picture", "Role", "Token", "Username" },
                values: new object[,]
                {
                    { 1, 1, "admin01@gmail.com", new byte[] { 160, 129, 112, 37, 2, 20, 60, 102, 148, 76, 60, 204, 160, 7, 91, 137, 93, 84, 222, 102, 228, 2, 69, 237, 31, 140, 9, 142, 205, 28, 69, 176, 55, 176, 53, 177, 43, 144, 61, 177, 23, 211, 33, 4, 244, 176, 101, 66, 213, 136, 74, 210, 36, 200, 140, 215, 66, 113, 118, 140, 223, 68, 243, 59 }, new byte[] { 243, 93, 100, 116, 18, 141, 208, 161, 50, 21, 131, 44, 67, 141, 218, 211, 191, 15, 169, 154, 120, 178, 9, 20, 126, 210, 247, 24, 15, 164, 214, 247, 207, 188, 24, 241, 116, 136, 106, 179, 96, 198, 97, 150, 176, 147, 255, 189, 155, 174, 94, 238, 152, 88, 111, 162, 188, 126, 36, 133, 185, 13, 241, 7, 99, 79, 110, 186, 187, 39, 250, 231, 249, 171, 214, 5, 154, 118, 179, 249, 0, 131, 224, 231, 104, 124, 148, 153, 113, 71, 250, 132, 47, 29, 198, 36, 166, 145, 244, 194, 45, 19, 32, 24, 201, 214, 28, 214, 161, 123, 234, 108, 51, 134, 71, 101, 212, 123, 203, 224, 25, 143, 71, 209, 130, 247, 77, 212 }, "6019911684 ", "do\\not\\know", 2, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwibmJmIjoxNTc1MTIyOTA4LCJleHAiOjE1NzU3Mjc3MDgsImlhdCI6MTU3NTEyMjkwOH0.GcTOWUdwVBuMMK5i2CfThwHPYV7BBzSbRJScSOVoMps", "admin01" },
                    { 16, 1, "member08@gmail.com", new byte[] { 160, 129, 112, 37, 2, 20, 60, 102, 148, 76, 60, 204, 160, 7, 91, 137, 93, 84, 222, 102, 228, 2, 69, 237, 31, 140, 9, 142, 205, 28, 69, 176, 55, 176, 53, 177, 43, 144, 61, 177, 23, 211, 33, 4, 244, 176, 101, 66, 213, 136, 74, 210, 36, 200, 140, 215, 66, 113, 118, 140, 223, 68, 243, 59 }, new byte[] { 243, 93, 100, 116, 18, 141, 208, 161, 50, 21, 131, 44, 67, 141, 218, 211, 191, 15, 169, 154, 120, 178, 9, 20, 126, 210, 247, 24, 15, 164, 214, 247, 207, 188, 24, 241, 116, 136, 106, 179, 96, 198, 97, 150, 176, 147, 255, 189, 155, 174, 94, 238, 152, 88, 111, 162, 188, 126, 36, 133, 185, 13, 241, 7, 99, 79, 110, 186, 187, 39, 250, 231, 249, 171, 214, 5, 154, 118, 179, 249, 0, 131, 224, 231, 104, 124, 148, 153, 113, 71, 250, 132, 47, 29, 198, 36, 166, 145, 244, 194, 45, 19, 32, 24, 201, 214, 28, 214, 161, 123, 234, 108, 51, 134, 71, 101, 212, 123, 203, 224, 25, 143, 71, 209, 130, 247, 77, 212 }, "334355105 ", "do\\not\\know", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxNiIsIm5iZiI6MTU3NTEyMjkwOCwiZXhwIjoxNTc1NzI3NzA4LCJpYXQiOjE1NzUxMjI5MDh9.eD5Scb6PkPd8J6URxiBvGTODwRWnaNGsCklfVNuLT8E", "member08" },
                    { 15, 1, "member07@gmail.com", new byte[] { 160, 129, 112, 37, 2, 20, 60, 102, 148, 76, 60, 204, 160, 7, 91, 137, 93, 84, 222, 102, 228, 2, 69, 237, 31, 140, 9, 142, 205, 28, 69, 176, 55, 176, 53, 177, 43, 144, 61, 177, 23, 211, 33, 4, 244, 176, 101, 66, 213, 136, 74, 210, 36, 200, 140, 215, 66, 113, 118, 140, 223, 68, 243, 59 }, new byte[] { 243, 93, 100, 116, 18, 141, 208, 161, 50, 21, 131, 44, 67, 141, 218, 211, 191, 15, 169, 154, 120, 178, 9, 20, 126, 210, 247, 24, 15, 164, 214, 247, 207, 188, 24, 241, 116, 136, 106, 179, 96, 198, 97, 150, 176, 147, 255, 189, 155, 174, 94, 238, 152, 88, 111, 162, 188, 126, 36, 133, 185, 13, 241, 7, 99, 79, 110, 186, 187, 39, 250, 231, 249, 171, 214, 5, 154, 118, 179, 249, 0, 131, 224, 231, 104, 124, 148, 153, 113, 71, 250, 132, 47, 29, 198, 36, 166, 145, 244, 194, 45, 19, 32, 24, 201, 214, 28, 214, 161, 123, 234, 108, 51, 134, 71, 101, 212, 123, 203, 224, 25, 143, 71, 209, 130, 247, 77, 212 }, "5071973872 ", "do\\not\\know", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxNSIsIm5iZiI6MTU3NTEyMjkwOCwiZXhwIjoxNTc1NzI3NzA4LCJpYXQiOjE1NzUxMjI5MDh9.6ulHRMbomsCoTK0T5T3LYlD1fsQ-oh4pV__dICNqWxQ", "member07" },
                    { 14, 1, "member06@gmail.com", new byte[] { 160, 129, 112, 37, 2, 20, 60, 102, 148, 76, 60, 204, 160, 7, 91, 137, 93, 84, 222, 102, 228, 2, 69, 237, 31, 140, 9, 142, 205, 28, 69, 176, 55, 176, 53, 177, 43, 144, 61, 177, 23, 211, 33, 4, 244, 176, 101, 66, 213, 136, 74, 210, 36, 200, 140, 215, 66, 113, 118, 140, 223, 68, 243, 59 }, new byte[] { 243, 93, 100, 116, 18, 141, 208, 161, 50, 21, 131, 44, 67, 141, 218, 211, 191, 15, 169, 154, 120, 178, 9, 20, 126, 210, 247, 24, 15, 164, 214, 247, 207, 188, 24, 241, 116, 136, 106, 179, 96, 198, 97, 150, 176, 147, 255, 189, 155, 174, 94, 238, 152, 88, 111, 162, 188, 126, 36, 133, 185, 13, 241, 7, 99, 79, 110, 186, 187, 39, 250, 231, 249, 171, 214, 5, 154, 118, 179, 249, 0, 131, 224, 231, 104, 124, 148, 153, 113, 71, 250, 132, 47, 29, 198, 36, 166, 145, 244, 194, 45, 19, 32, 24, 201, 214, 28, 214, 161, 123, 234, 108, 51, 134, 71, 101, 212, 123, 203, 224, 25, 143, 71, 209, 130, 247, 77, 212 }, "4686272886 ", "do\\not\\know", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxNCIsIm5iZiI6MTU3NTEyMjkwOCwiZXhwIjoxNTc1NzI3NzA4LCJpYXQiOjE1NzUxMjI5MDh9.4gRNAS0qTczv8aqwEkyXNmZoHaW1tZHI3v6dvXmdejQ", "member06" },
                    { 13, 1, "member05@gmail.com", new byte[] { 160, 129, 112, 37, 2, 20, 60, 102, 148, 76, 60, 204, 160, 7, 91, 137, 93, 84, 222, 102, 228, 2, 69, 237, 31, 140, 9, 142, 205, 28, 69, 176, 55, 176, 53, 177, 43, 144, 61, 177, 23, 211, 33, 4, 244, 176, 101, 66, 213, 136, 74, 210, 36, 200, 140, 215, 66, 113, 118, 140, 223, 68, 243, 59 }, new byte[] { 243, 93, 100, 116, 18, 141, 208, 161, 50, 21, 131, 44, 67, 141, 218, 211, 191, 15, 169, 154, 120, 178, 9, 20, 126, 210, 247, 24, 15, 164, 214, 247, 207, 188, 24, 241, 116, 136, 106, 179, 96, 198, 97, 150, 176, 147, 255, 189, 155, 174, 94, 238, 152, 88, 111, 162, 188, 126, 36, 133, 185, 13, 241, 7, 99, 79, 110, 186, 187, 39, 250, 231, 249, 171, 214, 5, 154, 118, 179, 249, 0, 131, 224, 231, 104, 124, 148, 153, 113, 71, 250, 132, 47, 29, 198, 36, 166, 145, 244, 194, 45, 19, 32, 24, 201, 214, 28, 214, 161, 123, 234, 108, 51, 134, 71, 101, 212, 123, 203, 224, 25, 143, 71, 209, 130, 247, 77, 212 }, "1064846605 ", "do\\not\\know", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxMyIsIm5iZiI6MTU3NTEyMjkwOCwiZXhwIjoxNTc1NzI3NzA4LCJpYXQiOjE1NzUxMjI5MDh9._KZZy74Cqlv2oZCxIGQepYrw74XZ2J1nKKmM-a3aktw", "member05" },
                    { 12, 1, "member04@gmail.com", new byte[] { 160, 129, 112, 37, 2, 20, 60, 102, 148, 76, 60, 204, 160, 7, 91, 137, 93, 84, 222, 102, 228, 2, 69, 237, 31, 140, 9, 142, 205, 28, 69, 176, 55, 176, 53, 177, 43, 144, 61, 177, 23, 211, 33, 4, 244, 176, 101, 66, 213, 136, 74, 210, 36, 200, 140, 215, 66, 113, 118, 140, 223, 68, 243, 59 }, new byte[] { 243, 93, 100, 116, 18, 141, 208, 161, 50, 21, 131, 44, 67, 141, 218, 211, 191, 15, 169, 154, 120, 178, 9, 20, 126, 210, 247, 24, 15, 164, 214, 247, 207, 188, 24, 241, 116, 136, 106, 179, 96, 198, 97, 150, 176, 147, 255, 189, 155, 174, 94, 238, 152, 88, 111, 162, 188, 126, 36, 133, 185, 13, 241, 7, 99, 79, 110, 186, 187, 39, 250, 231, 249, 171, 214, 5, 154, 118, 179, 249, 0, 131, 224, 231, 104, 124, 148, 153, 113, 71, 250, 132, 47, 29, 198, 36, 166, 145, 244, 194, 45, 19, 32, 24, 201, 214, 28, 214, 161, 123, 234, 108, 51, 134, 71, 101, 212, 123, 203, 224, 25, 143, 71, 209, 130, 247, 77, 212 }, "2358305614 ", "do\\not\\know", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxMiIsIm5iZiI6MTU3NTEyMjkwOCwiZXhwIjoxNTc1NzI3NzA4LCJpYXQiOjE1NzUxMjI5MDh9.V6woWEwQvQShjrUBcyAopp59lMWI1RZHUZ20wxRx1cc", "member04" },
                    { 11, 1, "member03@gmail.com", new byte[] { 160, 129, 112, 37, 2, 20, 60, 102, 148, 76, 60, 204, 160, 7, 91, 137, 93, 84, 222, 102, 228, 2, 69, 237, 31, 140, 9, 142, 205, 28, 69, 176, 55, 176, 53, 177, 43, 144, 61, 177, 23, 211, 33, 4, 244, 176, 101, 66, 213, 136, 74, 210, 36, 200, 140, 215, 66, 113, 118, 140, 223, 68, 243, 59 }, new byte[] { 243, 93, 100, 116, 18, 141, 208, 161, 50, 21, 131, 44, 67, 141, 218, 211, 191, 15, 169, 154, 120, 178, 9, 20, 126, 210, 247, 24, 15, 164, 214, 247, 207, 188, 24, 241, 116, 136, 106, 179, 96, 198, 97, 150, 176, 147, 255, 189, 155, 174, 94, 238, 152, 88, 111, 162, 188, 126, 36, 133, 185, 13, 241, 7, 99, 79, 110, 186, 187, 39, 250, 231, 249, 171, 214, 5, 154, 118, 179, 249, 0, 131, 224, 231, 104, 124, 148, 153, 113, 71, 250, 132, 47, 29, 198, 36, 166, 145, 244, 194, 45, 19, 32, 24, 201, 214, 28, 214, 161, 123, 234, 108, 51, 134, 71, 101, 212, 123, 203, 224, 25, 143, 71, 209, 130, 247, 77, 212 }, "4786399505 ", "do\\not\\know", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxMSIsIm5iZiI6MTU3NTEyMjkwOCwiZXhwIjoxNTc1NzI3NzA4LCJpYXQiOjE1NzUxMjI5MDh9.yWG89y3MIgNAjulUFw6aAEGy_JeD6e8GQrpHvS_8P1w", "member03" },
                    { 10, 1, "member02@gmail.com", new byte[] { 160, 129, 112, 37, 2, 20, 60, 102, 148, 76, 60, 204, 160, 7, 91, 137, 93, 84, 222, 102, 228, 2, 69, 237, 31, 140, 9, 142, 205, 28, 69, 176, 55, 176, 53, 177, 43, 144, 61, 177, 23, 211, 33, 4, 244, 176, 101, 66, 213, 136, 74, 210, 36, 200, 140, 215, 66, 113, 118, 140, 223, 68, 243, 59 }, new byte[] { 243, 93, 100, 116, 18, 141, 208, 161, 50, 21, 131, 44, 67, 141, 218, 211, 191, 15, 169, 154, 120, 178, 9, 20, 126, 210, 247, 24, 15, 164, 214, 247, 207, 188, 24, 241, 116, 136, 106, 179, 96, 198, 97, 150, 176, 147, 255, 189, 155, 174, 94, 238, 152, 88, 111, 162, 188, 126, 36, 133, 185, 13, 241, 7, 99, 79, 110, 186, 187, 39, 250, 231, 249, 171, 214, 5, 154, 118, 179, 249, 0, 131, 224, 231, 104, 124, 148, 153, 113, 71, 250, 132, 47, 29, 198, 36, 166, 145, 244, 194, 45, 19, 32, 24, 201, 214, 28, 214, 161, 123, 234, 108, 51, 134, 71, 101, 212, 123, 203, 224, 25, 143, 71, 209, 130, 247, 77, 212 }, "5414887288 ", "do\\not\\know", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxMCIsIm5iZiI6MTU3NTEyMjkwOCwiZXhwIjoxNTc1NzI3NzA4LCJpYXQiOjE1NzUxMjI5MDh9.OLlFS4-OCw5cPwFtAmXRSe1uuokiIJDDDehC4M0Lo04", "member02" },
                    { 9, 1, "member01@gmail.com", new byte[] { 160, 129, 112, 37, 2, 20, 60, 102, 148, 76, 60, 204, 160, 7, 91, 137, 93, 84, 222, 102, 228, 2, 69, 237, 31, 140, 9, 142, 205, 28, 69, 176, 55, 176, 53, 177, 43, 144, 61, 177, 23, 211, 33, 4, 244, 176, 101, 66, 213, 136, 74, 210, 36, 200, 140, 215, 66, 113, 118, 140, 223, 68, 243, 59 }, new byte[] { 243, 93, 100, 116, 18, 141, 208, 161, 50, 21, 131, 44, 67, 141, 218, 211, 191, 15, 169, 154, 120, 178, 9, 20, 126, 210, 247, 24, 15, 164, 214, 247, 207, 188, 24, 241, 116, 136, 106, 179, 96, 198, 97, 150, 176, 147, 255, 189, 155, 174, 94, 238, 152, 88, 111, 162, 188, 126, 36, 133, 185, 13, 241, 7, 99, 79, 110, 186, 187, 39, 250, 231, 249, 171, 214, 5, 154, 118, 179, 249, 0, 131, 224, 231, 104, 124, 148, 153, 113, 71, 250, 132, 47, 29, 198, 36, 166, 145, 244, 194, 45, 19, 32, 24, 201, 214, 28, 214, 161, 123, 234, 108, 51, 134, 71, 101, 212, 123, 203, 224, 25, 143, 71, 209, 130, 247, 77, 212 }, "3272464106 ", "do\\not\\know", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiI5IiwibmJmIjoxNTc1MTIyOTA4LCJleHAiOjE1NzU3Mjc3MDgsImlhdCI6MTU3NTEyMjkwOH0.dl8Jga67X8pJ-7KKs-JJC14TvQCaLeqg2GSg_MSwGVI", "member01" },
                    { 8, 1, "checker03@gmail.com", new byte[] { 160, 129, 112, 37, 2, 20, 60, 102, 148, 76, 60, 204, 160, 7, 91, 137, 93, 84, 222, 102, 228, 2, 69, 237, 31, 140, 9, 142, 205, 28, 69, 176, 55, 176, 53, 177, 43, 144, 61, 177, 23, 211, 33, 4, 244, 176, 101, 66, 213, 136, 74, 210, 36, 200, 140, 215, 66, 113, 118, 140, 223, 68, 243, 59 }, new byte[] { 243, 93, 100, 116, 18, 141, 208, 161, 50, 21, 131, 44, 67, 141, 218, 211, 191, 15, 169, 154, 120, 178, 9, 20, 126, 210, 247, 24, 15, 164, 214, 247, 207, 188, 24, 241, 116, 136, 106, 179, 96, 198, 97, 150, 176, 147, 255, 189, 155, 174, 94, 238, 152, 88, 111, 162, 188, 126, 36, 133, 185, 13, 241, 7, 99, 79, 110, 186, 187, 39, 250, 231, 249, 171, 214, 5, 154, 118, 179, 249, 0, 131, 224, 231, 104, 124, 148, 153, 113, 71, 250, 132, 47, 29, 198, 36, 166, 145, 244, 194, 45, 19, 32, 24, 201, 214, 28, 214, 161, 123, 234, 108, 51, 134, 71, 101, 212, 123, 203, 224, 25, 143, 71, 209, 130, 247, 77, 212 }, "5598781614 ", "do\\not\\know", 1, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiI4IiwibmJmIjoxNTc1MTIyOTA4LCJleHAiOjE1NzU3Mjc3MDgsImlhdCI6MTU3NTEyMjkwOH0.OViMNtpZTppgc8mfbVIitAgWT35vujK8T_bL1ETHA2Y", "checker03" },
                    { 7, 1, "checker02@gmail.com", new byte[] { 160, 129, 112, 37, 2, 20, 60, 102, 148, 76, 60, 204, 160, 7, 91, 137, 93, 84, 222, 102, 228, 2, 69, 237, 31, 140, 9, 142, 205, 28, 69, 176, 55, 176, 53, 177, 43, 144, 61, 177, 23, 211, 33, 4, 244, 176, 101, 66, 213, 136, 74, 210, 36, 200, 140, 215, 66, 113, 118, 140, 223, 68, 243, 59 }, new byte[] { 243, 93, 100, 116, 18, 141, 208, 161, 50, 21, 131, 44, 67, 141, 218, 211, 191, 15, 169, 154, 120, 178, 9, 20, 126, 210, 247, 24, 15, 164, 214, 247, 207, 188, 24, 241, 116, 136, 106, 179, 96, 198, 97, 150, 176, 147, 255, 189, 155, 174, 94, 238, 152, 88, 111, 162, 188, 126, 36, 133, 185, 13, 241, 7, 99, 79, 110, 186, 187, 39, 250, 231, 249, 171, 214, 5, 154, 118, 179, 249, 0, 131, 224, 231, 104, 124, 148, 153, 113, 71, 250, 132, 47, 29, 198, 36, 166, 145, 244, 194, 45, 19, 32, 24, 201, 214, 28, 214, 161, 123, 234, 108, 51, 134, 71, 101, 212, 123, 203, 224, 25, 143, 71, 209, 130, 247, 77, 212 }, "1669765414 ", "do\\not\\know", 1, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiI3IiwibmJmIjoxNTc1MTIyOTA4LCJleHAiOjE1NzU3Mjc3MDgsImlhdCI6MTU3NTEyMjkwOH0.FbsETyAnK4GHL6NkTbOFvlAv5B369Et5p2KUzeFrKJk", "checker02" },
                    { 6, 1, "checker01@gmail.com", new byte[] { 160, 129, 112, 37, 2, 20, 60, 102, 148, 76, 60, 204, 160, 7, 91, 137, 93, 84, 222, 102, 228, 2, 69, 237, 31, 140, 9, 142, 205, 28, 69, 176, 55, 176, 53, 177, 43, 144, 61, 177, 23, 211, 33, 4, 244, 176, 101, 66, 213, 136, 74, 210, 36, 200, 140, 215, 66, 113, 118, 140, 223, 68, 243, 59 }, new byte[] { 243, 93, 100, 116, 18, 141, 208, 161, 50, 21, 131, 44, 67, 141, 218, 211, 191, 15, 169, 154, 120, 178, 9, 20, 126, 210, 247, 24, 15, 164, 214, 247, 207, 188, 24, 241, 116, 136, 106, 179, 96, 198, 97, 150, 176, 147, 255, 189, 155, 174, 94, 238, 152, 88, 111, 162, 188, 126, 36, 133, 185, 13, 241, 7, 99, 79, 110, 186, 187, 39, 250, 231, 249, 171, 214, 5, 154, 118, 179, 249, 0, 131, 224, 231, 104, 124, 148, 153, 113, 71, 250, 132, 47, 29, 198, 36, 166, 145, 244, 194, 45, 19, 32, 24, 201, 214, 28, 214, 161, 123, 234, 108, 51, 134, 71, 101, 212, 123, 203, 224, 25, 143, 71, 209, 130, 247, 77, 212 }, "5844956388 ", "do\\not\\know", 1, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiI2IiwibmJmIjoxNTc1MTIyOTA4LCJleHAiOjE1NzU3Mjc3MDgsImlhdCI6MTU3NTEyMjkwOH0.X2_mVZgL6c11JAN1UhHFlRIy2FzON-UKjY_fRQGqeNA", "checker01" },
                    { 5, 1, "admin05@gmail.com", new byte[] { 160, 129, 112, 37, 2, 20, 60, 102, 148, 76, 60, 204, 160, 7, 91, 137, 93, 84, 222, 102, 228, 2, 69, 237, 31, 140, 9, 142, 205, 28, 69, 176, 55, 176, 53, 177, 43, 144, 61, 177, 23, 211, 33, 4, 244, 176, 101, 66, 213, 136, 74, 210, 36, 200, 140, 215, 66, 113, 118, 140, 223, 68, 243, 59 }, new byte[] { 243, 93, 100, 116, 18, 141, 208, 161, 50, 21, 131, 44, 67, 141, 218, 211, 191, 15, 169, 154, 120, 178, 9, 20, 126, 210, 247, 24, 15, 164, 214, 247, 207, 188, 24, 241, 116, 136, 106, 179, 96, 198, 97, 150, 176, 147, 255, 189, 155, 174, 94, 238, 152, 88, 111, 162, 188, 126, 36, 133, 185, 13, 241, 7, 99, 79, 110, 186, 187, 39, 250, 231, 249, 171, 214, 5, 154, 118, 179, 249, 0, 131, 224, 231, 104, 124, 148, 153, 113, 71, 250, 132, 47, 29, 198, 36, 166, 145, 244, 194, 45, 19, 32, 24, 201, 214, 28, 214, 161, 123, 234, 108, 51, 134, 71, 101, 212, 123, 203, 224, 25, 143, 71, 209, 130, 247, 77, 212 }, "8659710084 ", "do\\not\\know", 2, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiI1IiwibmJmIjoxNTc1MTIyOTA4LCJleHAiOjE1NzU3Mjc3MDgsImlhdCI6MTU3NTEyMjkwOH0.D_eFZ83fFG3fkGntfMWdS2YGWbKH5mDJj1vNpNNgF3U", "admin05" },
                    { 4, 1, "admin04@gmail.com", new byte[] { 160, 129, 112, 37, 2, 20, 60, 102, 148, 76, 60, 204, 160, 7, 91, 137, 93, 84, 222, 102, 228, 2, 69, 237, 31, 140, 9, 142, 205, 28, 69, 176, 55, 176, 53, 177, 43, 144, 61, 177, 23, 211, 33, 4, 244, 176, 101, 66, 213, 136, 74, 210, 36, 200, 140, 215, 66, 113, 118, 140, 223, 68, 243, 59 }, new byte[] { 243, 93, 100, 116, 18, 141, 208, 161, 50, 21, 131, 44, 67, 141, 218, 211, 191, 15, 169, 154, 120, 178, 9, 20, 126, 210, 247, 24, 15, 164, 214, 247, 207, 188, 24, 241, 116, 136, 106, 179, 96, 198, 97, 150, 176, 147, 255, 189, 155, 174, 94, 238, 152, 88, 111, 162, 188, 126, 36, 133, 185, 13, 241, 7, 99, 79, 110, 186, 187, 39, 250, 231, 249, 171, 214, 5, 154, 118, 179, 249, 0, 131, 224, 231, 104, 124, 148, 153, 113, 71, 250, 132, 47, 29, 198, 36, 166, 145, 244, 194, 45, 19, 32, 24, 201, 214, 28, 214, 161, 123, 234, 108, 51, 134, 71, 101, 212, 123, 203, 224, 25, 143, 71, 209, 130, 247, 77, 212 }, "4866078694 ", "do\\not\\know", 2, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiI0IiwibmJmIjoxNTc1MTIyOTA4LCJleHAiOjE1NzU3Mjc3MDgsImlhdCI6MTU3NTEyMjkwOH0.BthUU8xL3BdjB2Kl3urQFpmKV-kzw7PBPEc-VeZOytg", "admin04" },
                    { 3, 1, "admin03@gmail.com", new byte[] { 160, 129, 112, 37, 2, 20, 60, 102, 148, 76, 60, 204, 160, 7, 91, 137, 93, 84, 222, 102, 228, 2, 69, 237, 31, 140, 9, 142, 205, 28, 69, 176, 55, 176, 53, 177, 43, 144, 61, 177, 23, 211, 33, 4, 244, 176, 101, 66, 213, 136, 74, 210, 36, 200, 140, 215, 66, 113, 118, 140, 223, 68, 243, 59 }, new byte[] { 243, 93, 100, 116, 18, 141, 208, 161, 50, 21, 131, 44, 67, 141, 218, 211, 191, 15, 169, 154, 120, 178, 9, 20, 126, 210, 247, 24, 15, 164, 214, 247, 207, 188, 24, 241, 116, 136, 106, 179, 96, 198, 97, 150, 176, 147, 255, 189, 155, 174, 94, 238, 152, 88, 111, 162, 188, 126, 36, 133, 185, 13, 241, 7, 99, 79, 110, 186, 187, 39, 250, 231, 249, 171, 214, 5, 154, 118, 179, 249, 0, 131, 224, 231, 104, 124, 148, 153, 113, 71, 250, 132, 47, 29, 198, 36, 166, 145, 244, 194, 45, 19, 32, 24, 201, 214, 28, 214, 161, 123, 234, 108, 51, 134, 71, 101, 212, 123, 203, 224, 25, 143, 71, 209, 130, 247, 77, 212 }, "105989609 ", "do\\not\\know", 2, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIzIiwibmJmIjoxNTc1MTIyOTA4LCJleHAiOjE1NzU3Mjc3MDgsImlhdCI6MTU3NTEyMjkwOH0.8P-T2n9TvWdDZyKKOT5fBq2RAzU2j0vgSzdlff17syg", "admin03" },
                    { 2, 1, "admin02@gmail.com", new byte[] { 160, 129, 112, 37, 2, 20, 60, 102, 148, 76, 60, 204, 160, 7, 91, 137, 93, 84, 222, 102, 228, 2, 69, 237, 31, 140, 9, 142, 205, 28, 69, 176, 55, 176, 53, 177, 43, 144, 61, 177, 23, 211, 33, 4, 244, 176, 101, 66, 213, 136, 74, 210, 36, 200, 140, 215, 66, 113, 118, 140, 223, 68, 243, 59 }, new byte[] { 243, 93, 100, 116, 18, 141, 208, 161, 50, 21, 131, 44, 67, 141, 218, 211, 191, 15, 169, 154, 120, 178, 9, 20, 126, 210, 247, 24, 15, 164, 214, 247, 207, 188, 24, 241, 116, 136, 106, 179, 96, 198, 97, 150, 176, 147, 255, 189, 155, 174, 94, 238, 152, 88, 111, 162, 188, 126, 36, 133, 185, 13, 241, 7, 99, 79, 110, 186, 187, 39, 250, 231, 249, 171, 214, 5, 154, 118, 179, 249, 0, 131, 224, 231, 104, 124, 148, 153, 113, 71, 250, 132, 47, 29, 198, 36, 166, 145, 244, 194, 45, 19, 32, 24, 201, 214, 28, 214, 161, 123, 234, 108, 51, 134, 71, 101, 212, 123, 203, 224, 25, 143, 71, 209, 130, 247, 77, 212 }, "3069338796 ", "do\\not\\know", 2, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIyIiwibmJmIjoxNTc1MTIyOTA4LCJleHAiOjE1NzU3Mjc3MDgsImlhdCI6MTU3NTEyMjkwOH0._M8LdsCBFFI4bYNe38LmR6WQyoDslo_o5NvkrYQRHgE", "admin02" },
                    { 17, 1, "member09@gmail.com", new byte[] { 160, 129, 112, 37, 2, 20, 60, 102, 148, 76, 60, 204, 160, 7, 91, 137, 93, 84, 222, 102, 228, 2, 69, 237, 31, 140, 9, 142, 205, 28, 69, 176, 55, 176, 53, 177, 43, 144, 61, 177, 23, 211, 33, 4, 244, 176, 101, 66, 213, 136, 74, 210, 36, 200, 140, 215, 66, 113, 118, 140, 223, 68, 243, 59 }, new byte[] { 243, 93, 100, 116, 18, 141, 208, 161, 50, 21, 131, 44, 67, 141, 218, 211, 191, 15, 169, 154, 120, 178, 9, 20, 126, 210, 247, 24, 15, 164, 214, 247, 207, 188, 24, 241, 116, 136, 106, 179, 96, 198, 97, 150, 176, 147, 255, 189, 155, 174, 94, 238, 152, 88, 111, 162, 188, 126, 36, 133, 185, 13, 241, 7, 99, 79, 110, 186, 187, 39, 250, 231, 249, 171, 214, 5, 154, 118, 179, 249, 0, 131, 224, 231, 104, 124, 148, 153, 113, 71, 250, 132, 47, 29, 198, 36, 166, 145, 244, 194, 45, 19, 32, 24, 201, 214, 28, 214, 161, 123, 234, 108, 51, 134, 71, 101, 212, 123, 203, 224, 25, 143, 71, 209, 130, 247, 77, 212 }, "5471673152 ", "do\\not\\know", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxNyIsIm5iZiI6MTU3NTEyMjkwOCwiZXhwIjoxNTc1NzI3NzA4LCJpYXQiOjE1NzUxMjI5MDh9.zaLDgJ9caaUM7TJ_nDwdscj9aXptfERgbsc7596T1GU", "member09" },
                    { 18, 1, "member10@gmail.com", new byte[] { 160, 129, 112, 37, 2, 20, 60, 102, 148, 76, 60, 204, 160, 7, 91, 137, 93, 84, 222, 102, 228, 2, 69, 237, 31, 140, 9, 142, 205, 28, 69, 176, 55, 176, 53, 177, 43, 144, 61, 177, 23, 211, 33, 4, 244, 176, 101, 66, 213, 136, 74, 210, 36, 200, 140, 215, 66, 113, 118, 140, 223, 68, 243, 59 }, new byte[] { 243, 93, 100, 116, 18, 141, 208, 161, 50, 21, 131, 44, 67, 141, 218, 211, 191, 15, 169, 154, 120, 178, 9, 20, 126, 210, 247, 24, 15, 164, 214, 247, 207, 188, 24, 241, 116, 136, 106, 179, 96, 198, 97, 150, 176, 147, 255, 189, 155, 174, 94, 238, 152, 88, 111, 162, 188, 126, 36, 133, 185, 13, 241, 7, 99, 79, 110, 186, 187, 39, 250, 231, 249, 171, 214, 5, 154, 118, 179, 249, 0, 131, 224, 231, 104, 124, 148, 153, 113, 71, 250, 132, 47, 29, 198, 36, 166, 145, 244, 194, 45, 19, 32, 24, 201, 214, 28, 214, 161, 123, 234, 108, 51, 134, 71, 101, 212, 123, 203, 224, 25, 143, 71, 209, 130, 247, 77, 212 }, "8758801056", "do\\not\\know", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxOCIsIm5iZiI6MTU3NTEyMjkwOCwiZXhwIjoxNTc1NzI3NzA4LCJpYXQiOjE1NzUxMjI5MDh9.ZUCMe5yhGw1HKPHoAtTUVHblCiqfXPiuzdUxAqWhE8g", "member10" }
                });

            migrationBuilder.InsertData(
                table: "Challenges",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "Name", "Statement", "Status" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2019, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chien trop chou", "Faire une photo avec un chien", 1 },
                    { 2, 1, new DateTime(2019, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Début d'un amour", "Avoir le numéro de quelqu'un", 1 },
                    { 3, 4, new DateTime(2019, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ô belles boules", "Faire une vidéo devant l'Atomium", 1 },
                    { 4, 4, new DateTime(2019, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grande mais petite", "Faire une photo sur la grande place", 0 },
                    { 5, 9, new DateTime(2019, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bonne et bien chaude", "Faire une vidéo en mangeant une gauffre", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Achievements_FromChallengeId",
                table: "Achievements",
                column: "FromChallengeId");

            migrationBuilder.CreateIndex(
                name: "IX_Achievements_WinnerId",
                table: "Achievements",
                column: "WinnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Challenges_AuthorId",
                table: "Challenges",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Challenges_Statement",
                table: "Challenges",
                column: "Statement",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ChallengesGiven_ChallengeId",
                table: "ChallengesGiven",
                column: "ChallengeId");

            migrationBuilder.CreateIndex(
                name: "IX_ChallengesGiven_ChallengedGroupId",
                table: "ChallengesGiven",
                column: "ChallengedGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_Name",
                table: "Companies",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Groups_Name",
                table: "Groups",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Medias_MessageId",
                table: "Medias",
                column: "MessageId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Medias_Name",
                table: "Medias",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Messages_AuthorId",
                table: "Messages",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_DiscussionId",
                table: "Messages",
                column: "DiscussionId");

            migrationBuilder.CreateIndex(
                name: "IX_ParticipantGroups_BelongingGroupId",
                table: "ParticipantGroups",
                column: "BelongingGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_ParticipantGroups_UserId",
                table: "ParticipantGroups",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CompanyId",
                table: "Users",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_PhoneNumber",
                table: "Users",
                column: "PhoneNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Token",
                table: "Users",
                column: "Token",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UsersInDiscussion_DiscussionId",
                table: "UsersInDiscussion",
                column: "DiscussionId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersInDiscussion_ParticipantId",
                table: "UsersInDiscussion",
                column: "ParticipantId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Achievements");

            migrationBuilder.DropTable(
                name: "ChallengesGiven");

            migrationBuilder.DropTable(
                name: "Medias");

            migrationBuilder.DropTable(
                name: "ParticipantGroups");

            migrationBuilder.DropTable(
                name: "UsersInDiscussion");

            migrationBuilder.DropTable(
                name: "Challenges");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Discussions");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
