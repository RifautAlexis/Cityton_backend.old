using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cityton.Repository.Migrations
{
    public partial class init : Migration
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
                    { 1, 1, "admin01@gmail.com", new byte[] { 35, 219, 58, 82, 86, 244, 71, 216, 164, 106, 69, 160, 179, 31, 132, 243, 129, 158, 160, 183, 155, 145, 88, 236, 99, 205, 11, 169, 84, 222, 59, 121, 42, 191, 226, 105, 155, 29, 135, 246, 173, 129, 27, 246, 40, 226, 236, 13, 211, 190, 30, 216, 19, 60, 86, 192, 218, 147, 205, 41, 240, 14, 70, 32 }, new byte[] { 132, 95, 223, 118, 198, 70, 173, 131, 224, 137, 86, 178, 15, 32, 105, 249, 133, 75, 210, 194, 51, 128, 203, 182, 180, 101, 227, 115, 36, 118, 66, 173, 218, 94, 219, 37, 126, 74, 124, 69, 166, 209, 170, 63, 199, 146, 98, 178, 205, 165, 110, 233, 247, 105, 208, 22, 168, 243, 108, 125, 141, 189, 5, 180, 0, 207, 125, 49, 3, 132, 213, 120, 118, 102, 232, 168, 0, 217, 149, 216, 184, 90, 148, 97, 25, 105, 118, 58, 255, 16, 220, 195, 224, 218, 27, 114, 196, 62, 56, 50, 223, 43, 64, 44, 119, 226, 174, 152, 214, 148, 133, 188, 180, 210, 213, 38, 66, 131, 70, 11, 176, 88, 67, 170, 236, 169, 226, 137 }, "6019911684 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 2, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwibmJmIjoxNTc2MDAzMTk4LCJleHAiOjE1NzY2MDc5OTgsImlhdCI6MTU3NjAwMzE5OH0.GVPlUzPhKJcChjGuSOOFJmSzSrqdVW0wEeG0VqGqe-M", "admin01" },
                    { 16, 1, "member08@gmail.com", new byte[] { 35, 219, 58, 82, 86, 244, 71, 216, 164, 106, 69, 160, 179, 31, 132, 243, 129, 158, 160, 183, 155, 145, 88, 236, 99, 205, 11, 169, 84, 222, 59, 121, 42, 191, 226, 105, 155, 29, 135, 246, 173, 129, 27, 246, 40, 226, 236, 13, 211, 190, 30, 216, 19, 60, 86, 192, 218, 147, 205, 41, 240, 14, 70, 32 }, new byte[] { 132, 95, 223, 118, 198, 70, 173, 131, 224, 137, 86, 178, 15, 32, 105, 249, 133, 75, 210, 194, 51, 128, 203, 182, 180, 101, 227, 115, 36, 118, 66, 173, 218, 94, 219, 37, 126, 74, 124, 69, 166, 209, 170, 63, 199, 146, 98, 178, 205, 165, 110, 233, 247, 105, 208, 22, 168, 243, 108, 125, 141, 189, 5, 180, 0, 207, 125, 49, 3, 132, 213, 120, 118, 102, 232, 168, 0, 217, 149, 216, 184, 90, 148, 97, 25, 105, 118, 58, 255, 16, 220, 195, 224, 218, 27, 114, 196, 62, 56, 50, 223, 43, 64, 44, 119, 226, 174, 152, 214, 148, 133, 188, 180, 210, 213, 38, 66, 131, 70, 11, 176, 88, 67, 170, 236, 169, 226, 137 }, "334355105 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxNiIsIm5iZiI6MTU3NjAwMzE5OCwiZXhwIjoxNTc2NjA3OTk4LCJpYXQiOjE1NzYwMDMxOTh9.0x-TP_MBYbcCZQuJ3MnTKc3o23wPFGob-28XRyUCyNA", "member08" },
                    { 15, 1, "member07@gmail.com", new byte[] { 35, 219, 58, 82, 86, 244, 71, 216, 164, 106, 69, 160, 179, 31, 132, 243, 129, 158, 160, 183, 155, 145, 88, 236, 99, 205, 11, 169, 84, 222, 59, 121, 42, 191, 226, 105, 155, 29, 135, 246, 173, 129, 27, 246, 40, 226, 236, 13, 211, 190, 30, 216, 19, 60, 86, 192, 218, 147, 205, 41, 240, 14, 70, 32 }, new byte[] { 132, 95, 223, 118, 198, 70, 173, 131, 224, 137, 86, 178, 15, 32, 105, 249, 133, 75, 210, 194, 51, 128, 203, 182, 180, 101, 227, 115, 36, 118, 66, 173, 218, 94, 219, 37, 126, 74, 124, 69, 166, 209, 170, 63, 199, 146, 98, 178, 205, 165, 110, 233, 247, 105, 208, 22, 168, 243, 108, 125, 141, 189, 5, 180, 0, 207, 125, 49, 3, 132, 213, 120, 118, 102, 232, 168, 0, 217, 149, 216, 184, 90, 148, 97, 25, 105, 118, 58, 255, 16, 220, 195, 224, 218, 27, 114, 196, 62, 56, 50, 223, 43, 64, 44, 119, 226, 174, 152, 214, 148, 133, 188, 180, 210, 213, 38, 66, 131, 70, 11, 176, 88, 67, 170, 236, 169, 226, 137 }, "5071973872 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxNSIsIm5iZiI6MTU3NjAwMzE5OCwiZXhwIjoxNTc2NjA3OTk4LCJpYXQiOjE1NzYwMDMxOTh9.JKaCnj0YU-vnI46FbTB3SbLsVFoaRrm61rxMkJmruNQ", "member07" },
                    { 14, 1, "member06@gmail.com", new byte[] { 35, 219, 58, 82, 86, 244, 71, 216, 164, 106, 69, 160, 179, 31, 132, 243, 129, 158, 160, 183, 155, 145, 88, 236, 99, 205, 11, 169, 84, 222, 59, 121, 42, 191, 226, 105, 155, 29, 135, 246, 173, 129, 27, 246, 40, 226, 236, 13, 211, 190, 30, 216, 19, 60, 86, 192, 218, 147, 205, 41, 240, 14, 70, 32 }, new byte[] { 132, 95, 223, 118, 198, 70, 173, 131, 224, 137, 86, 178, 15, 32, 105, 249, 133, 75, 210, 194, 51, 128, 203, 182, 180, 101, 227, 115, 36, 118, 66, 173, 218, 94, 219, 37, 126, 74, 124, 69, 166, 209, 170, 63, 199, 146, 98, 178, 205, 165, 110, 233, 247, 105, 208, 22, 168, 243, 108, 125, 141, 189, 5, 180, 0, 207, 125, 49, 3, 132, 213, 120, 118, 102, 232, 168, 0, 217, 149, 216, 184, 90, 148, 97, 25, 105, 118, 58, 255, 16, 220, 195, 224, 218, 27, 114, 196, 62, 56, 50, 223, 43, 64, 44, 119, 226, 174, 152, 214, 148, 133, 188, 180, 210, 213, 38, 66, 131, 70, 11, 176, 88, 67, 170, 236, 169, 226, 137 }, "4686272886 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxNCIsIm5iZiI6MTU3NjAwMzE5OCwiZXhwIjoxNTc2NjA3OTk4LCJpYXQiOjE1NzYwMDMxOTh9.Yfpz1KKG3FF-gDGYCNiX8eRNl6E0QYjcZ_0MBxwilqo", "member06" },
                    { 13, 1, "member05@gmail.com", new byte[] { 35, 219, 58, 82, 86, 244, 71, 216, 164, 106, 69, 160, 179, 31, 132, 243, 129, 158, 160, 183, 155, 145, 88, 236, 99, 205, 11, 169, 84, 222, 59, 121, 42, 191, 226, 105, 155, 29, 135, 246, 173, 129, 27, 246, 40, 226, 236, 13, 211, 190, 30, 216, 19, 60, 86, 192, 218, 147, 205, 41, 240, 14, 70, 32 }, new byte[] { 132, 95, 223, 118, 198, 70, 173, 131, 224, 137, 86, 178, 15, 32, 105, 249, 133, 75, 210, 194, 51, 128, 203, 182, 180, 101, 227, 115, 36, 118, 66, 173, 218, 94, 219, 37, 126, 74, 124, 69, 166, 209, 170, 63, 199, 146, 98, 178, 205, 165, 110, 233, 247, 105, 208, 22, 168, 243, 108, 125, 141, 189, 5, 180, 0, 207, 125, 49, 3, 132, 213, 120, 118, 102, 232, 168, 0, 217, 149, 216, 184, 90, 148, 97, 25, 105, 118, 58, 255, 16, 220, 195, 224, 218, 27, 114, 196, 62, 56, 50, 223, 43, 64, 44, 119, 226, 174, 152, 214, 148, 133, 188, 180, 210, 213, 38, 66, 131, 70, 11, 176, 88, 67, 170, 236, 169, 226, 137 }, "1064846605 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxMyIsIm5iZiI6MTU3NjAwMzE5OCwiZXhwIjoxNTc2NjA3OTk4LCJpYXQiOjE1NzYwMDMxOTh9.6wBJ7gNysYU7PkYBzY0Wggy2CVBSm8m8IjYoQyShHPU", "member05" },
                    { 12, 1, "member04@gmail.com", new byte[] { 35, 219, 58, 82, 86, 244, 71, 216, 164, 106, 69, 160, 179, 31, 132, 243, 129, 158, 160, 183, 155, 145, 88, 236, 99, 205, 11, 169, 84, 222, 59, 121, 42, 191, 226, 105, 155, 29, 135, 246, 173, 129, 27, 246, 40, 226, 236, 13, 211, 190, 30, 216, 19, 60, 86, 192, 218, 147, 205, 41, 240, 14, 70, 32 }, new byte[] { 132, 95, 223, 118, 198, 70, 173, 131, 224, 137, 86, 178, 15, 32, 105, 249, 133, 75, 210, 194, 51, 128, 203, 182, 180, 101, 227, 115, 36, 118, 66, 173, 218, 94, 219, 37, 126, 74, 124, 69, 166, 209, 170, 63, 199, 146, 98, 178, 205, 165, 110, 233, 247, 105, 208, 22, 168, 243, 108, 125, 141, 189, 5, 180, 0, 207, 125, 49, 3, 132, 213, 120, 118, 102, 232, 168, 0, 217, 149, 216, 184, 90, 148, 97, 25, 105, 118, 58, 255, 16, 220, 195, 224, 218, 27, 114, 196, 62, 56, 50, 223, 43, 64, 44, 119, 226, 174, 152, 214, 148, 133, 188, 180, 210, 213, 38, 66, 131, 70, 11, 176, 88, 67, 170, 236, 169, 226, 137 }, "2358305614 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxMiIsIm5iZiI6MTU3NjAwMzE5OCwiZXhwIjoxNTc2NjA3OTk4LCJpYXQiOjE1NzYwMDMxOTh9.oQlY0xUkI2y2bDMpj6vt2l98MvozR5IaPQKDsSighYQ", "member04" },
                    { 11, 1, "member03@gmail.com", new byte[] { 35, 219, 58, 82, 86, 244, 71, 216, 164, 106, 69, 160, 179, 31, 132, 243, 129, 158, 160, 183, 155, 145, 88, 236, 99, 205, 11, 169, 84, 222, 59, 121, 42, 191, 226, 105, 155, 29, 135, 246, 173, 129, 27, 246, 40, 226, 236, 13, 211, 190, 30, 216, 19, 60, 86, 192, 218, 147, 205, 41, 240, 14, 70, 32 }, new byte[] { 132, 95, 223, 118, 198, 70, 173, 131, 224, 137, 86, 178, 15, 32, 105, 249, 133, 75, 210, 194, 51, 128, 203, 182, 180, 101, 227, 115, 36, 118, 66, 173, 218, 94, 219, 37, 126, 74, 124, 69, 166, 209, 170, 63, 199, 146, 98, 178, 205, 165, 110, 233, 247, 105, 208, 22, 168, 243, 108, 125, 141, 189, 5, 180, 0, 207, 125, 49, 3, 132, 213, 120, 118, 102, 232, 168, 0, 217, 149, 216, 184, 90, 148, 97, 25, 105, 118, 58, 255, 16, 220, 195, 224, 218, 27, 114, 196, 62, 56, 50, 223, 43, 64, 44, 119, 226, 174, 152, 214, 148, 133, 188, 180, 210, 213, 38, 66, 131, 70, 11, 176, 88, 67, 170, 236, 169, 226, 137 }, "4786399505 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxMSIsIm5iZiI6MTU3NjAwMzE5OCwiZXhwIjoxNTc2NjA3OTk4LCJpYXQiOjE1NzYwMDMxOTh9.evcYpJSuqrUhj6jfNFyrbbp26lZCF40qtOMlAz-dzAs", "member03" },
                    { 10, 1, "member02@gmail.com", new byte[] { 35, 219, 58, 82, 86, 244, 71, 216, 164, 106, 69, 160, 179, 31, 132, 243, 129, 158, 160, 183, 155, 145, 88, 236, 99, 205, 11, 169, 84, 222, 59, 121, 42, 191, 226, 105, 155, 29, 135, 246, 173, 129, 27, 246, 40, 226, 236, 13, 211, 190, 30, 216, 19, 60, 86, 192, 218, 147, 205, 41, 240, 14, 70, 32 }, new byte[] { 132, 95, 223, 118, 198, 70, 173, 131, 224, 137, 86, 178, 15, 32, 105, 249, 133, 75, 210, 194, 51, 128, 203, 182, 180, 101, 227, 115, 36, 118, 66, 173, 218, 94, 219, 37, 126, 74, 124, 69, 166, 209, 170, 63, 199, 146, 98, 178, 205, 165, 110, 233, 247, 105, 208, 22, 168, 243, 108, 125, 141, 189, 5, 180, 0, 207, 125, 49, 3, 132, 213, 120, 118, 102, 232, 168, 0, 217, 149, 216, 184, 90, 148, 97, 25, 105, 118, 58, 255, 16, 220, 195, 224, 218, 27, 114, 196, 62, 56, 50, 223, 43, 64, 44, 119, 226, 174, 152, 214, 148, 133, 188, 180, 210, 213, 38, 66, 131, 70, 11, 176, 88, 67, 170, 236, 169, 226, 137 }, "5414887288 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxMCIsIm5iZiI6MTU3NjAwMzE5OCwiZXhwIjoxNTc2NjA3OTk4LCJpYXQiOjE1NzYwMDMxOTh9.z5oSAPYE2dPVUUUk2cVMnmAdEseS0jTV6Bb1C7DNaKc", "member02" },
                    { 9, 1, "member01@gmail.com", new byte[] { 35, 219, 58, 82, 86, 244, 71, 216, 164, 106, 69, 160, 179, 31, 132, 243, 129, 158, 160, 183, 155, 145, 88, 236, 99, 205, 11, 169, 84, 222, 59, 121, 42, 191, 226, 105, 155, 29, 135, 246, 173, 129, 27, 246, 40, 226, 236, 13, 211, 190, 30, 216, 19, 60, 86, 192, 218, 147, 205, 41, 240, 14, 70, 32 }, new byte[] { 132, 95, 223, 118, 198, 70, 173, 131, 224, 137, 86, 178, 15, 32, 105, 249, 133, 75, 210, 194, 51, 128, 203, 182, 180, 101, 227, 115, 36, 118, 66, 173, 218, 94, 219, 37, 126, 74, 124, 69, 166, 209, 170, 63, 199, 146, 98, 178, 205, 165, 110, 233, 247, 105, 208, 22, 168, 243, 108, 125, 141, 189, 5, 180, 0, 207, 125, 49, 3, 132, 213, 120, 118, 102, 232, 168, 0, 217, 149, 216, 184, 90, 148, 97, 25, 105, 118, 58, 255, 16, 220, 195, 224, 218, 27, 114, 196, 62, 56, 50, 223, 43, 64, 44, 119, 226, 174, 152, 214, 148, 133, 188, 180, 210, 213, 38, 66, 131, 70, 11, 176, 88, 67, 170, 236, 169, 226, 137 }, "3272464106 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiI5IiwibmJmIjoxNTc2MDAzMTk4LCJleHAiOjE1NzY2MDc5OTgsImlhdCI6MTU3NjAwMzE5OH0.kqzp33HWOnKuKc7YXqYvF_q4TJk9LoGp7nvJxDeTmF8", "member01" },
                    { 8, 1, "checker03@gmail.com", new byte[] { 35, 219, 58, 82, 86, 244, 71, 216, 164, 106, 69, 160, 179, 31, 132, 243, 129, 158, 160, 183, 155, 145, 88, 236, 99, 205, 11, 169, 84, 222, 59, 121, 42, 191, 226, 105, 155, 29, 135, 246, 173, 129, 27, 246, 40, 226, 236, 13, 211, 190, 30, 216, 19, 60, 86, 192, 218, 147, 205, 41, 240, 14, 70, 32 }, new byte[] { 132, 95, 223, 118, 198, 70, 173, 131, 224, 137, 86, 178, 15, 32, 105, 249, 133, 75, 210, 194, 51, 128, 203, 182, 180, 101, 227, 115, 36, 118, 66, 173, 218, 94, 219, 37, 126, 74, 124, 69, 166, 209, 170, 63, 199, 146, 98, 178, 205, 165, 110, 233, 247, 105, 208, 22, 168, 243, 108, 125, 141, 189, 5, 180, 0, 207, 125, 49, 3, 132, 213, 120, 118, 102, 232, 168, 0, 217, 149, 216, 184, 90, 148, 97, 25, 105, 118, 58, 255, 16, 220, 195, 224, 218, 27, 114, 196, 62, 56, 50, 223, 43, 64, 44, 119, 226, 174, 152, 214, 148, 133, 188, 180, 210, 213, 38, 66, 131, 70, 11, 176, 88, 67, 170, 236, 169, 226, 137 }, "5598781614 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 1, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiI4IiwibmJmIjoxNTc2MDAzMTk4LCJleHAiOjE1NzY2MDc5OTgsImlhdCI6MTU3NjAwMzE5OH0.yxMEEqm3e6csSe-r4TJRhT1JNne36USTraDL-M1LHCU", "checker03" },
                    { 7, 1, "checker02@gmail.com", new byte[] { 35, 219, 58, 82, 86, 244, 71, 216, 164, 106, 69, 160, 179, 31, 132, 243, 129, 158, 160, 183, 155, 145, 88, 236, 99, 205, 11, 169, 84, 222, 59, 121, 42, 191, 226, 105, 155, 29, 135, 246, 173, 129, 27, 246, 40, 226, 236, 13, 211, 190, 30, 216, 19, 60, 86, 192, 218, 147, 205, 41, 240, 14, 70, 32 }, new byte[] { 132, 95, 223, 118, 198, 70, 173, 131, 224, 137, 86, 178, 15, 32, 105, 249, 133, 75, 210, 194, 51, 128, 203, 182, 180, 101, 227, 115, 36, 118, 66, 173, 218, 94, 219, 37, 126, 74, 124, 69, 166, 209, 170, 63, 199, 146, 98, 178, 205, 165, 110, 233, 247, 105, 208, 22, 168, 243, 108, 125, 141, 189, 5, 180, 0, 207, 125, 49, 3, 132, 213, 120, 118, 102, 232, 168, 0, 217, 149, 216, 184, 90, 148, 97, 25, 105, 118, 58, 255, 16, 220, 195, 224, 218, 27, 114, 196, 62, 56, 50, 223, 43, 64, 44, 119, 226, 174, 152, 214, 148, 133, 188, 180, 210, 213, 38, 66, 131, 70, 11, 176, 88, 67, 170, 236, 169, 226, 137 }, "1669765414 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 1, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiI3IiwibmJmIjoxNTc2MDAzMTk4LCJleHAiOjE1NzY2MDc5OTgsImlhdCI6MTU3NjAwMzE5OH0.JkPvNDXGns1awbBDqoP1BF1saLk-EFyg9qpEqS3qvfs", "checker02" },
                    { 6, 1, "checker01@gmail.com", new byte[] { 35, 219, 58, 82, 86, 244, 71, 216, 164, 106, 69, 160, 179, 31, 132, 243, 129, 158, 160, 183, 155, 145, 88, 236, 99, 205, 11, 169, 84, 222, 59, 121, 42, 191, 226, 105, 155, 29, 135, 246, 173, 129, 27, 246, 40, 226, 236, 13, 211, 190, 30, 216, 19, 60, 86, 192, 218, 147, 205, 41, 240, 14, 70, 32 }, new byte[] { 132, 95, 223, 118, 198, 70, 173, 131, 224, 137, 86, 178, 15, 32, 105, 249, 133, 75, 210, 194, 51, 128, 203, 182, 180, 101, 227, 115, 36, 118, 66, 173, 218, 94, 219, 37, 126, 74, 124, 69, 166, 209, 170, 63, 199, 146, 98, 178, 205, 165, 110, 233, 247, 105, 208, 22, 168, 243, 108, 125, 141, 189, 5, 180, 0, 207, 125, 49, 3, 132, 213, 120, 118, 102, 232, 168, 0, 217, 149, 216, 184, 90, 148, 97, 25, 105, 118, 58, 255, 16, 220, 195, 224, 218, 27, 114, 196, 62, 56, 50, 223, 43, 64, 44, 119, 226, 174, 152, 214, 148, 133, 188, 180, 210, 213, 38, 66, 131, 70, 11, 176, 88, 67, 170, 236, 169, 226, 137 }, "5844956388 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 1, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiI2IiwibmJmIjoxNTc2MDAzMTk4LCJleHAiOjE1NzY2MDc5OTgsImlhdCI6MTU3NjAwMzE5OH0.3U1OUPDxoQGRLzhzYFwqPj-sWkVSW3GpidYtFdLkz7A", "checker01" },
                    { 5, 1, "admin05@gmail.com", new byte[] { 35, 219, 58, 82, 86, 244, 71, 216, 164, 106, 69, 160, 179, 31, 132, 243, 129, 158, 160, 183, 155, 145, 88, 236, 99, 205, 11, 169, 84, 222, 59, 121, 42, 191, 226, 105, 155, 29, 135, 246, 173, 129, 27, 246, 40, 226, 236, 13, 211, 190, 30, 216, 19, 60, 86, 192, 218, 147, 205, 41, 240, 14, 70, 32 }, new byte[] { 132, 95, 223, 118, 198, 70, 173, 131, 224, 137, 86, 178, 15, 32, 105, 249, 133, 75, 210, 194, 51, 128, 203, 182, 180, 101, 227, 115, 36, 118, 66, 173, 218, 94, 219, 37, 126, 74, 124, 69, 166, 209, 170, 63, 199, 146, 98, 178, 205, 165, 110, 233, 247, 105, 208, 22, 168, 243, 108, 125, 141, 189, 5, 180, 0, 207, 125, 49, 3, 132, 213, 120, 118, 102, 232, 168, 0, 217, 149, 216, 184, 90, 148, 97, 25, 105, 118, 58, 255, 16, 220, 195, 224, 218, 27, 114, 196, 62, 56, 50, 223, 43, 64, 44, 119, 226, 174, 152, 214, 148, 133, 188, 180, 210, 213, 38, 66, 131, 70, 11, 176, 88, 67, 170, 236, 169, 226, 137 }, "8659710084 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 2, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiI1IiwibmJmIjoxNTc2MDAzMTk4LCJleHAiOjE1NzY2MDc5OTgsImlhdCI6MTU3NjAwMzE5OH0.FXSWSMHVB3TMNeHONowktWbfVlCmiJsg-AH-l6akq0k", "admin05" },
                    { 4, 1, "admin04@gmail.com", new byte[] { 35, 219, 58, 82, 86, 244, 71, 216, 164, 106, 69, 160, 179, 31, 132, 243, 129, 158, 160, 183, 155, 145, 88, 236, 99, 205, 11, 169, 84, 222, 59, 121, 42, 191, 226, 105, 155, 29, 135, 246, 173, 129, 27, 246, 40, 226, 236, 13, 211, 190, 30, 216, 19, 60, 86, 192, 218, 147, 205, 41, 240, 14, 70, 32 }, new byte[] { 132, 95, 223, 118, 198, 70, 173, 131, 224, 137, 86, 178, 15, 32, 105, 249, 133, 75, 210, 194, 51, 128, 203, 182, 180, 101, 227, 115, 36, 118, 66, 173, 218, 94, 219, 37, 126, 74, 124, 69, 166, 209, 170, 63, 199, 146, 98, 178, 205, 165, 110, 233, 247, 105, 208, 22, 168, 243, 108, 125, 141, 189, 5, 180, 0, 207, 125, 49, 3, 132, 213, 120, 118, 102, 232, 168, 0, 217, 149, 216, 184, 90, 148, 97, 25, 105, 118, 58, 255, 16, 220, 195, 224, 218, 27, 114, 196, 62, 56, 50, 223, 43, 64, 44, 119, 226, 174, 152, 214, 148, 133, 188, 180, 210, 213, 38, 66, 131, 70, 11, 176, 88, 67, 170, 236, 169, 226, 137 }, "4866078694 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 2, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiI0IiwibmJmIjoxNTc2MDAzMTk4LCJleHAiOjE1NzY2MDc5OTgsImlhdCI6MTU3NjAwMzE5OH0.k_2DoHfMda9YBDo62qE-fNPuJahpdVnlulUNb3rmEgQ", "admin04" },
                    { 3, 1, "admin03@gmail.com", new byte[] { 35, 219, 58, 82, 86, 244, 71, 216, 164, 106, 69, 160, 179, 31, 132, 243, 129, 158, 160, 183, 155, 145, 88, 236, 99, 205, 11, 169, 84, 222, 59, 121, 42, 191, 226, 105, 155, 29, 135, 246, 173, 129, 27, 246, 40, 226, 236, 13, 211, 190, 30, 216, 19, 60, 86, 192, 218, 147, 205, 41, 240, 14, 70, 32 }, new byte[] { 132, 95, 223, 118, 198, 70, 173, 131, 224, 137, 86, 178, 15, 32, 105, 249, 133, 75, 210, 194, 51, 128, 203, 182, 180, 101, 227, 115, 36, 118, 66, 173, 218, 94, 219, 37, 126, 74, 124, 69, 166, 209, 170, 63, 199, 146, 98, 178, 205, 165, 110, 233, 247, 105, 208, 22, 168, 243, 108, 125, 141, 189, 5, 180, 0, 207, 125, 49, 3, 132, 213, 120, 118, 102, 232, 168, 0, 217, 149, 216, 184, 90, 148, 97, 25, 105, 118, 58, 255, 16, 220, 195, 224, 218, 27, 114, 196, 62, 56, 50, 223, 43, 64, 44, 119, 226, 174, 152, 214, 148, 133, 188, 180, 210, 213, 38, 66, 131, 70, 11, 176, 88, 67, 170, 236, 169, 226, 137 }, "105989609 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 2, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIzIiwibmJmIjoxNTc2MDAzMTk4LCJleHAiOjE1NzY2MDc5OTgsImlhdCI6MTU3NjAwMzE5OH0.KTc0ajIjhO4ZKPNkgGmeDPSzJgT1N_OmY-xxtO_GDjo", "admin03" },
                    { 2, 1, "admin02@gmail.com", new byte[] { 35, 219, 58, 82, 86, 244, 71, 216, 164, 106, 69, 160, 179, 31, 132, 243, 129, 158, 160, 183, 155, 145, 88, 236, 99, 205, 11, 169, 84, 222, 59, 121, 42, 191, 226, 105, 155, 29, 135, 246, 173, 129, 27, 246, 40, 226, 236, 13, 211, 190, 30, 216, 19, 60, 86, 192, 218, 147, 205, 41, 240, 14, 70, 32 }, new byte[] { 132, 95, 223, 118, 198, 70, 173, 131, 224, 137, 86, 178, 15, 32, 105, 249, 133, 75, 210, 194, 51, 128, 203, 182, 180, 101, 227, 115, 36, 118, 66, 173, 218, 94, 219, 37, 126, 74, 124, 69, 166, 209, 170, 63, 199, 146, 98, 178, 205, 165, 110, 233, 247, 105, 208, 22, 168, 243, 108, 125, 141, 189, 5, 180, 0, 207, 125, 49, 3, 132, 213, 120, 118, 102, 232, 168, 0, 217, 149, 216, 184, 90, 148, 97, 25, 105, 118, 58, 255, 16, 220, 195, 224, 218, 27, 114, 196, 62, 56, 50, 223, 43, 64, 44, 119, 226, 174, 152, 214, 148, 133, 188, 180, 210, 213, 38, 66, 131, 70, 11, 176, 88, 67, 170, 236, 169, 226, 137 }, "3069338796 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 2, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIyIiwibmJmIjoxNTc2MDAzMTk4LCJleHAiOjE1NzY2MDc5OTgsImlhdCI6MTU3NjAwMzE5OH0.y6-KgCDURMZ-mWj1QX5SKpeAeJOiRqqh3zq33wJN-wI", "admin02" },
                    { 17, 1, "member09@gmail.com", new byte[] { 35, 219, 58, 82, 86, 244, 71, 216, 164, 106, 69, 160, 179, 31, 132, 243, 129, 158, 160, 183, 155, 145, 88, 236, 99, 205, 11, 169, 84, 222, 59, 121, 42, 191, 226, 105, 155, 29, 135, 246, 173, 129, 27, 246, 40, 226, 236, 13, 211, 190, 30, 216, 19, 60, 86, 192, 218, 147, 205, 41, 240, 14, 70, 32 }, new byte[] { 132, 95, 223, 118, 198, 70, 173, 131, 224, 137, 86, 178, 15, 32, 105, 249, 133, 75, 210, 194, 51, 128, 203, 182, 180, 101, 227, 115, 36, 118, 66, 173, 218, 94, 219, 37, 126, 74, 124, 69, 166, 209, 170, 63, 199, 146, 98, 178, 205, 165, 110, 233, 247, 105, 208, 22, 168, 243, 108, 125, 141, 189, 5, 180, 0, 207, 125, 49, 3, 132, 213, 120, 118, 102, 232, 168, 0, 217, 149, 216, 184, 90, 148, 97, 25, 105, 118, 58, 255, 16, 220, 195, 224, 218, 27, 114, 196, 62, 56, 50, 223, 43, 64, 44, 119, 226, 174, 152, 214, 148, 133, 188, 180, 210, 213, 38, 66, 131, 70, 11, 176, 88, 67, 170, 236, 169, 226, 137 }, "5471673152 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxNyIsIm5iZiI6MTU3NjAwMzE5OCwiZXhwIjoxNTc2NjA3OTk4LCJpYXQiOjE1NzYwMDMxOTh9.FH41PYfxNlXOOCT9EOWFEwfW5KyS5D3JFqSDv7U_dbk", "member09" },
                    { 18, 1, "member10@gmail.com", new byte[] { 35, 219, 58, 82, 86, 244, 71, 216, 164, 106, 69, 160, 179, 31, 132, 243, 129, 158, 160, 183, 155, 145, 88, 236, 99, 205, 11, 169, 84, 222, 59, 121, 42, 191, 226, 105, 155, 29, 135, 246, 173, 129, 27, 246, 40, 226, 236, 13, 211, 190, 30, 216, 19, 60, 86, 192, 218, 147, 205, 41, 240, 14, 70, 32 }, new byte[] { 132, 95, 223, 118, 198, 70, 173, 131, 224, 137, 86, 178, 15, 32, 105, 249, 133, 75, 210, 194, 51, 128, 203, 182, 180, 101, 227, 115, 36, 118, 66, 173, 218, 94, 219, 37, 126, 74, 124, 69, 166, 209, 170, 63, 199, 146, 98, 178, 205, 165, 110, 233, 247, 105, 208, 22, 168, 243, 108, 125, 141, 189, 5, 180, 0, 207, 125, 49, 3, 132, 213, 120, 118, 102, 232, 168, 0, 217, 149, 216, 184, 90, 148, 97, 25, 105, 118, 58, 255, 16, 220, 195, 224, 218, 27, 114, 196, 62, 56, 50, 223, 43, 64, 44, 119, 226, 174, 152, 214, 148, 133, 188, 180, 210, 213, 38, 66, 131, 70, 11, 176, 88, 67, 170, 236, 169, 226, 137 }, "8758801056", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxOCIsIm5iZiI6MTU3NjAwMzE5OCwiZXhwIjoxNTc2NjA3OTk4LCJpYXQiOjE1NzYwMDMxOTh9.QULExawBrYnN2IXX4fHkWKpt7LECGcYL_q7U7uhikqA", "member10" }
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
