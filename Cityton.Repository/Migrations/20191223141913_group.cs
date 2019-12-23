using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cityton.Repository.Migrations
{
    public partial class group : Migration
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
                    CreatedAt = table.Column<DateTime>(nullable: false),
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
                table: "Groups",
                columns: new[] { "Id", "CreatedAt", "Name", "Picture" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "group01", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png" },
                    { 2, new DateTime(2019, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "group02", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png" },
                    { 3, new DateTime(2019, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "group03", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png" },
                    { 4, new DateTime(2019, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "group04", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png" },
                    { 5, new DateTime(2019, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "group05", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png" },
                    { 6, new DateTime(2019, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "group06", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CompanyId", "Email", "PasswordHash", "PasswordSalt", "PhoneNumber", "Picture", "Role", "Token", "Username" },
                values: new object[,]
                {
                    { 1, 1, "admin01@gmail.com", new byte[] { 47, 205, 254, 255, 90, 128, 39, 234, 245, 87, 44, 15, 236, 39, 195, 15, 207, 247, 121, 135, 216, 12, 88, 249, 46, 239, 170, 125, 135, 201, 178, 217, 54, 210, 119, 159, 160, 234, 209, 29, 143, 73, 187, 233, 185, 139, 119, 56, 117, 91, 227, 226, 84, 178, 203, 44, 149, 149, 181, 197, 6, 248, 32, 214 }, new byte[] { 139, 131, 243, 76, 235, 216, 253, 228, 227, 154, 99, 252, 163, 118, 122, 127, 78, 155, 2, 161, 145, 29, 84, 220, 67, 151, 254, 35, 120, 94, 171, 141, 61, 183, 160, 10, 157, 56, 114, 28, 127, 27, 251, 127, 211, 73, 152, 8, 108, 206, 183, 221, 190, 146, 24, 129, 25, 181, 178, 52, 213, 219, 143, 0, 183, 196, 41, 97, 29, 125, 148, 178, 245, 131, 200, 48, 205, 155, 168, 153, 12, 153, 44, 170, 17, 175, 17, 135, 34, 129, 164, 60, 10, 122, 43, 250, 64, 248, 87, 247, 79, 91, 92, 13, 17, 181, 51, 114, 15, 27, 235, 15, 253, 25, 79, 222, 57, 214, 72, 191, 44, 133, 184, 146, 19, 13, 91, 55 }, "6019911684 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 2, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwibmJmIjoxNTc3MTEwNzUzLCJleHAiOjE1Nzc3MTU1NTMsImlhdCI6MTU3NzExMDc1M30.ojuSQ7Oe4kdzVfumkOgEZcmpzY_nFmFixVEJzGJmfCs", "admin01" },
                    { 27, 1, "member19@gmail.com", new byte[] { 47, 205, 254, 255, 90, 128, 39, 234, 245, 87, 44, 15, 236, 39, 195, 15, 207, 247, 121, 135, 216, 12, 88, 249, 46, 239, 170, 125, 135, 201, 178, 217, 54, 210, 119, 159, 160, 234, 209, 29, 143, 73, 187, 233, 185, 139, 119, 56, 117, 91, 227, 226, 84, 178, 203, 44, 149, 149, 181, 197, 6, 248, 32, 214 }, new byte[] { 139, 131, 243, 76, 235, 216, 253, 228, 227, 154, 99, 252, 163, 118, 122, 127, 78, 155, 2, 161, 145, 29, 84, 220, 67, 151, 254, 35, 120, 94, 171, 141, 61, 183, 160, 10, 157, 56, 114, 28, 127, 27, 251, 127, 211, 73, 152, 8, 108, 206, 183, 221, 190, 146, 24, 129, 25, 181, 178, 52, 213, 219, 143, 0, 183, 196, 41, 97, 29, 125, 148, 178, 245, 131, 200, 48, 205, 155, 168, 153, 12, 153, 44, 170, 17, 175, 17, 135, 34, 129, 164, 60, 10, 122, 43, 250, 64, 248, 87, 247, 79, 91, 92, 13, 17, 181, 51, 114, 15, 27, 235, 15, 253, 25, 79, 222, 57, 214, 72, 191, 44, 133, 184, 146, 19, 13, 91, 55 }, "3534047331 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIyNyIsIm5iZiI6MTU3NzExMDc1MywiZXhwIjoxNTc3NzE1NTUzLCJpYXQiOjE1NzcxMTA3NTN9.WyTMD4KAPOo6lP4BvY-xJiyJcjTFT6KWGMOYzxLsByQ", "member19" },
                    { 28, 1, "member20@gmail.com", new byte[] { 47, 205, 254, 255, 90, 128, 39, 234, 245, 87, 44, 15, 236, 39, 195, 15, 207, 247, 121, 135, 216, 12, 88, 249, 46, 239, 170, 125, 135, 201, 178, 217, 54, 210, 119, 159, 160, 234, 209, 29, 143, 73, 187, 233, 185, 139, 119, 56, 117, 91, 227, 226, 84, 178, 203, 44, 149, 149, 181, 197, 6, 248, 32, 214 }, new byte[] { 139, 131, 243, 76, 235, 216, 253, 228, 227, 154, 99, 252, 163, 118, 122, 127, 78, 155, 2, 161, 145, 29, 84, 220, 67, 151, 254, 35, 120, 94, 171, 141, 61, 183, 160, 10, 157, 56, 114, 28, 127, 27, 251, 127, 211, 73, 152, 8, 108, 206, 183, 221, 190, 146, 24, 129, 25, 181, 178, 52, 213, 219, 143, 0, 183, 196, 41, 97, 29, 125, 148, 178, 245, 131, 200, 48, 205, 155, 168, 153, 12, 153, 44, 170, 17, 175, 17, 135, 34, 129, 164, 60, 10, 122, 43, 250, 64, 248, 87, 247, 79, 91, 92, 13, 17, 181, 51, 114, 15, 27, 235, 15, 253, 25, 79, 222, 57, 214, 72, 191, 44, 133, 184, 146, 19, 13, 91, 55 }, "2817549444 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIyOCIsIm5iZiI6MTU3NzExMDc1MywiZXhwIjoxNTc3NzE1NTUzLCJpYXQiOjE1NzcxMTA3NTN9.U88l7PiQG9rdWcdlbz4xHNqodHrFLvsHsUxbgKCF5_U", "member20" },
                    { 29, 1, "member21@gmail.com", new byte[] { 47, 205, 254, 255, 90, 128, 39, 234, 245, 87, 44, 15, 236, 39, 195, 15, 207, 247, 121, 135, 216, 12, 88, 249, 46, 239, 170, 125, 135, 201, 178, 217, 54, 210, 119, 159, 160, 234, 209, 29, 143, 73, 187, 233, 185, 139, 119, 56, 117, 91, 227, 226, 84, 178, 203, 44, 149, 149, 181, 197, 6, 248, 32, 214 }, new byte[] { 139, 131, 243, 76, 235, 216, 253, 228, 227, 154, 99, 252, 163, 118, 122, 127, 78, 155, 2, 161, 145, 29, 84, 220, 67, 151, 254, 35, 120, 94, 171, 141, 61, 183, 160, 10, 157, 56, 114, 28, 127, 27, 251, 127, 211, 73, 152, 8, 108, 206, 183, 221, 190, 146, 24, 129, 25, 181, 178, 52, 213, 219, 143, 0, 183, 196, 41, 97, 29, 125, 148, 178, 245, 131, 200, 48, 205, 155, 168, 153, 12, 153, 44, 170, 17, 175, 17, 135, 34, 129, 164, 60, 10, 122, 43, 250, 64, 248, 87, 247, 79, 91, 92, 13, 17, 181, 51, 114, 15, 27, 235, 15, 253, 25, 79, 222, 57, 214, 72, 191, 44, 133, 184, 146, 19, 13, 91, 55 }, "8865276623 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIyOSIsIm5iZiI6MTU3NzExMDc1MywiZXhwIjoxNTc3NzE1NTUzLCJpYXQiOjE1NzcxMTA3NTN9.uU4afYMNPhuxI9W0S28GX5bW9yuAzgmBLp7UfnpP2V4", "member21" },
                    { 30, 1, "member22@gmail.com", new byte[] { 47, 205, 254, 255, 90, 128, 39, 234, 245, 87, 44, 15, 236, 39, 195, 15, 207, 247, 121, 135, 216, 12, 88, 249, 46, 239, 170, 125, 135, 201, 178, 217, 54, 210, 119, 159, 160, 234, 209, 29, 143, 73, 187, 233, 185, 139, 119, 56, 117, 91, 227, 226, 84, 178, 203, 44, 149, 149, 181, 197, 6, 248, 32, 214 }, new byte[] { 139, 131, 243, 76, 235, 216, 253, 228, 227, 154, 99, 252, 163, 118, 122, 127, 78, 155, 2, 161, 145, 29, 84, 220, 67, 151, 254, 35, 120, 94, 171, 141, 61, 183, 160, 10, 157, 56, 114, 28, 127, 27, 251, 127, 211, 73, 152, 8, 108, 206, 183, 221, 190, 146, 24, 129, 25, 181, 178, 52, 213, 219, 143, 0, 183, 196, 41, 97, 29, 125, 148, 178, 245, 131, 200, 48, 205, 155, 168, 153, 12, 153, 44, 170, 17, 175, 17, 135, 34, 129, 164, 60, 10, 122, 43, 250, 64, 248, 87, 247, 79, 91, 92, 13, 17, 181, 51, 114, 15, 27, 235, 15, 253, 25, 79, 222, 57, 214, 72, 191, 44, 133, 184, 146, 19, 13, 91, 55 }, "5491062337 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIzMCIsIm5iZiI6MTU3NzExMDc1MywiZXhwIjoxNTc3NzE1NTUzLCJpYXQiOjE1NzcxMTA3NTN9.9sefZTosogZoTjM8eqawnbD2Cmw0C_ZAzVhF6uu8LfU", "member22" },
                    { 31, 1, "member23@gmail.com", new byte[] { 47, 205, 254, 255, 90, 128, 39, 234, 245, 87, 44, 15, 236, 39, 195, 15, 207, 247, 121, 135, 216, 12, 88, 249, 46, 239, 170, 125, 135, 201, 178, 217, 54, 210, 119, 159, 160, 234, 209, 29, 143, 73, 187, 233, 185, 139, 119, 56, 117, 91, 227, 226, 84, 178, 203, 44, 149, 149, 181, 197, 6, 248, 32, 214 }, new byte[] { 139, 131, 243, 76, 235, 216, 253, 228, 227, 154, 99, 252, 163, 118, 122, 127, 78, 155, 2, 161, 145, 29, 84, 220, 67, 151, 254, 35, 120, 94, 171, 141, 61, 183, 160, 10, 157, 56, 114, 28, 127, 27, 251, 127, 211, 73, 152, 8, 108, 206, 183, 221, 190, 146, 24, 129, 25, 181, 178, 52, 213, 219, 143, 0, 183, 196, 41, 97, 29, 125, 148, 178, 245, 131, 200, 48, 205, 155, 168, 153, 12, 153, 44, 170, 17, 175, 17, 135, 34, 129, 164, 60, 10, 122, 43, 250, 64, 248, 87, 247, 79, 91, 92, 13, 17, 181, 51, 114, 15, 27, 235, 15, 253, 25, 79, 222, 57, 214, 72, 191, 44, 133, 184, 146, 19, 13, 91, 55 }, "8547534376 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIzMSIsIm5iZiI6MTU3NzExMDc1MywiZXhwIjoxNTc3NzE1NTUzLCJpYXQiOjE1NzcxMTA3NTN9.-LCcygs3Nhzvk61A115_Zz1tvDzixsWopFUMkvTJ65k", "member23" },
                    { 32, 1, "member24@gmail.com", new byte[] { 47, 205, 254, 255, 90, 128, 39, 234, 245, 87, 44, 15, 236, 39, 195, 15, 207, 247, 121, 135, 216, 12, 88, 249, 46, 239, 170, 125, 135, 201, 178, 217, 54, 210, 119, 159, 160, 234, 209, 29, 143, 73, 187, 233, 185, 139, 119, 56, 117, 91, 227, 226, 84, 178, 203, 44, 149, 149, 181, 197, 6, 248, 32, 214 }, new byte[] { 139, 131, 243, 76, 235, 216, 253, 228, 227, 154, 99, 252, 163, 118, 122, 127, 78, 155, 2, 161, 145, 29, 84, 220, 67, 151, 254, 35, 120, 94, 171, 141, 61, 183, 160, 10, 157, 56, 114, 28, 127, 27, 251, 127, 211, 73, 152, 8, 108, 206, 183, 221, 190, 146, 24, 129, 25, 181, 178, 52, 213, 219, 143, 0, 183, 196, 41, 97, 29, 125, 148, 178, 245, 131, 200, 48, 205, 155, 168, 153, 12, 153, 44, 170, 17, 175, 17, 135, 34, 129, 164, 60, 10, 122, 43, 250, 64, 248, 87, 247, 79, 91, 92, 13, 17, 181, 51, 114, 15, 27, 235, 15, 253, 25, 79, 222, 57, 214, 72, 191, 44, 133, 184, 146, 19, 13, 91, 55 }, "1691707740 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIzMiIsIm5iZiI6MTU3NzExMDc1MywiZXhwIjoxNTc3NzE1NTUzLCJpYXQiOjE1NzcxMTA3NTN9.krxOY4MOlGyT97OU35iM6hcUB0NWdACqzAS3D8ua36Q", "member24" },
                    { 33, 1, "member25@gmail.com", new byte[] { 47, 205, 254, 255, 90, 128, 39, 234, 245, 87, 44, 15, 236, 39, 195, 15, 207, 247, 121, 135, 216, 12, 88, 249, 46, 239, 170, 125, 135, 201, 178, 217, 54, 210, 119, 159, 160, 234, 209, 29, 143, 73, 187, 233, 185, 139, 119, 56, 117, 91, 227, 226, 84, 178, 203, 44, 149, 149, 181, 197, 6, 248, 32, 214 }, new byte[] { 139, 131, 243, 76, 235, 216, 253, 228, 227, 154, 99, 252, 163, 118, 122, 127, 78, 155, 2, 161, 145, 29, 84, 220, 67, 151, 254, 35, 120, 94, 171, 141, 61, 183, 160, 10, 157, 56, 114, 28, 127, 27, 251, 127, 211, 73, 152, 8, 108, 206, 183, 221, 190, 146, 24, 129, 25, 181, 178, 52, 213, 219, 143, 0, 183, 196, 41, 97, 29, 125, 148, 178, 245, 131, 200, 48, 205, 155, 168, 153, 12, 153, 44, 170, 17, 175, 17, 135, 34, 129, 164, 60, 10, 122, 43, 250, 64, 248, 87, 247, 79, 91, 92, 13, 17, 181, 51, 114, 15, 27, 235, 15, 253, 25, 79, 222, 57, 214, 72, 191, 44, 133, 184, 146, 19, 13, 91, 55 }, "3483061802 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIzMyIsIm5iZiI6MTU3NzExMDc1MywiZXhwIjoxNTc3NzE1NTUzLCJpYXQiOjE1NzcxMTA3NTN9.7HcmqEYaS6HB8dI6jMvjaRV7Kh77Q0Czsl2TzQEDMbA", "member25" },
                    { 34, 1, "member26@gmail.com", new byte[] { 47, 205, 254, 255, 90, 128, 39, 234, 245, 87, 44, 15, 236, 39, 195, 15, 207, 247, 121, 135, 216, 12, 88, 249, 46, 239, 170, 125, 135, 201, 178, 217, 54, 210, 119, 159, 160, 234, 209, 29, 143, 73, 187, 233, 185, 139, 119, 56, 117, 91, 227, 226, 84, 178, 203, 44, 149, 149, 181, 197, 6, 248, 32, 214 }, new byte[] { 139, 131, 243, 76, 235, 216, 253, 228, 227, 154, 99, 252, 163, 118, 122, 127, 78, 155, 2, 161, 145, 29, 84, 220, 67, 151, 254, 35, 120, 94, 171, 141, 61, 183, 160, 10, 157, 56, 114, 28, 127, 27, 251, 127, 211, 73, 152, 8, 108, 206, 183, 221, 190, 146, 24, 129, 25, 181, 178, 52, 213, 219, 143, 0, 183, 196, 41, 97, 29, 125, 148, 178, 245, 131, 200, 48, 205, 155, 168, 153, 12, 153, 44, 170, 17, 175, 17, 135, 34, 129, 164, 60, 10, 122, 43, 250, 64, 248, 87, 247, 79, 91, 92, 13, 17, 181, 51, 114, 15, 27, 235, 15, 253, 25, 79, 222, 57, 214, 72, 191, 44, 133, 184, 146, 19, 13, 91, 55 }, "5955468148 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIzNCIsIm5iZiI6MTU3NzExMDc1MywiZXhwIjoxNTc3NzE1NTUzLCJpYXQiOjE1NzcxMTA3NTN9._n5L12junwWyATtktFKCp2wFq7WUaw7z75HbF37_j_Y", "member26" },
                    { 35, 1, "member27@gmail.com", new byte[] { 47, 205, 254, 255, 90, 128, 39, 234, 245, 87, 44, 15, 236, 39, 195, 15, 207, 247, 121, 135, 216, 12, 88, 249, 46, 239, 170, 125, 135, 201, 178, 217, 54, 210, 119, 159, 160, 234, 209, 29, 143, 73, 187, 233, 185, 139, 119, 56, 117, 91, 227, 226, 84, 178, 203, 44, 149, 149, 181, 197, 6, 248, 32, 214 }, new byte[] { 139, 131, 243, 76, 235, 216, 253, 228, 227, 154, 99, 252, 163, 118, 122, 127, 78, 155, 2, 161, 145, 29, 84, 220, 67, 151, 254, 35, 120, 94, 171, 141, 61, 183, 160, 10, 157, 56, 114, 28, 127, 27, 251, 127, 211, 73, 152, 8, 108, 206, 183, 221, 190, 146, 24, 129, 25, 181, 178, 52, 213, 219, 143, 0, 183, 196, 41, 97, 29, 125, 148, 178, 245, 131, 200, 48, 205, 155, 168, 153, 12, 153, 44, 170, 17, 175, 17, 135, 34, 129, 164, 60, 10, 122, 43, 250, 64, 248, 87, 247, 79, 91, 92, 13, 17, 181, 51, 114, 15, 27, 235, 15, 253, 25, 79, 222, 57, 214, 72, 191, 44, 133, 184, 146, 19, 13, 91, 55 }, "4206283982 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIzNSIsIm5iZiI6MTU3NzExMDc1MywiZXhwIjoxNTc3NzE1NTUzLCJpYXQiOjE1NzcxMTA3NTN9.DN-iJRx40FXIz8CTERy9uFFlFqxHFD1jIvGWh-saN98", "member27" },
                    { 26, 1, "member18@gmail.com", new byte[] { 47, 205, 254, 255, 90, 128, 39, 234, 245, 87, 44, 15, 236, 39, 195, 15, 207, 247, 121, 135, 216, 12, 88, 249, 46, 239, 170, 125, 135, 201, 178, 217, 54, 210, 119, 159, 160, 234, 209, 29, 143, 73, 187, 233, 185, 139, 119, 56, 117, 91, 227, 226, 84, 178, 203, 44, 149, 149, 181, 197, 6, 248, 32, 214 }, new byte[] { 139, 131, 243, 76, 235, 216, 253, 228, 227, 154, 99, 252, 163, 118, 122, 127, 78, 155, 2, 161, 145, 29, 84, 220, 67, 151, 254, 35, 120, 94, 171, 141, 61, 183, 160, 10, 157, 56, 114, 28, 127, 27, 251, 127, 211, 73, 152, 8, 108, 206, 183, 221, 190, 146, 24, 129, 25, 181, 178, 52, 213, 219, 143, 0, 183, 196, 41, 97, 29, 125, 148, 178, 245, 131, 200, 48, 205, 155, 168, 153, 12, 153, 44, 170, 17, 175, 17, 135, 34, 129, 164, 60, 10, 122, 43, 250, 64, 248, 87, 247, 79, 91, 92, 13, 17, 181, 51, 114, 15, 27, 235, 15, 253, 25, 79, 222, 57, 214, 72, 191, 44, 133, 184, 146, 19, 13, 91, 55 }, "2923858299 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 1, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIyNiIsIm5iZiI6MTU3NzExMDc1MywiZXhwIjoxNTc3NzE1NTUzLCJpYXQiOjE1NzcxMTA3NTN9.gTNxoTSXiumuyVVcF7iBkwTAShwFzByZAfyPLCqpCLA", "member18" },
                    { 36, 1, "member28@gmail.com", new byte[] { 47, 205, 254, 255, 90, 128, 39, 234, 245, 87, 44, 15, 236, 39, 195, 15, 207, 247, 121, 135, 216, 12, 88, 249, 46, 239, 170, 125, 135, 201, 178, 217, 54, 210, 119, 159, 160, 234, 209, 29, 143, 73, 187, 233, 185, 139, 119, 56, 117, 91, 227, 226, 84, 178, 203, 44, 149, 149, 181, 197, 6, 248, 32, 214 }, new byte[] { 139, 131, 243, 76, 235, 216, 253, 228, 227, 154, 99, 252, 163, 118, 122, 127, 78, 155, 2, 161, 145, 29, 84, 220, 67, 151, 254, 35, 120, 94, 171, 141, 61, 183, 160, 10, 157, 56, 114, 28, 127, 27, 251, 127, 211, 73, 152, 8, 108, 206, 183, 221, 190, 146, 24, 129, 25, 181, 178, 52, 213, 219, 143, 0, 183, 196, 41, 97, 29, 125, 148, 178, 245, 131, 200, 48, 205, 155, 168, 153, 12, 153, 44, 170, 17, 175, 17, 135, 34, 129, 164, 60, 10, 122, 43, 250, 64, 248, 87, 247, 79, 91, 92, 13, 17, 181, 51, 114, 15, 27, 235, 15, 253, 25, 79, 222, 57, 214, 72, 191, 44, 133, 184, 146, 19, 13, 91, 55 }, "2088176734", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIzNiIsIm5iZiI6MTU3NzExMDc1MywiZXhwIjoxNTc3NzE1NTUzLCJpYXQiOjE1NzcxMTA3NTN9.acj8z1Cpi0bSBAkfqbFtUxTiSTDIcnOk2yxeSG6A9pc", "member28" },
                    { 38, 1, "member30@gmail.com", new byte[] { 47, 205, 254, 255, 90, 128, 39, 234, 245, 87, 44, 15, 236, 39, 195, 15, 207, 247, 121, 135, 216, 12, 88, 249, 46, 239, 170, 125, 135, 201, 178, 217, 54, 210, 119, 159, 160, 234, 209, 29, 143, 73, 187, 233, 185, 139, 119, 56, 117, 91, 227, 226, 84, 178, 203, 44, 149, 149, 181, 197, 6, 248, 32, 214 }, new byte[] { 139, 131, 243, 76, 235, 216, 253, 228, 227, 154, 99, 252, 163, 118, 122, 127, 78, 155, 2, 161, 145, 29, 84, 220, 67, 151, 254, 35, 120, 94, 171, 141, 61, 183, 160, 10, 157, 56, 114, 28, 127, 27, 251, 127, 211, 73, 152, 8, 108, 206, 183, 221, 190, 146, 24, 129, 25, 181, 178, 52, 213, 219, 143, 0, 183, 196, 41, 97, 29, 125, 148, 178, 245, 131, 200, 48, 205, 155, 168, 153, 12, 153, 44, 170, 17, 175, 17, 135, 34, 129, 164, 60, 10, 122, 43, 250, 64, 248, 87, 247, 79, 91, 92, 13, 17, 181, 51, 114, 15, 27, 235, 15, 253, 25, 79, 222, 57, 214, 72, 191, 44, 133, 184, 146, 19, 13, 91, 55 }, "5475604706", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIzOCIsIm5iZiI6MTU3NzExMDc1MywiZXhwIjoxNTc3NzE1NTUzLCJpYXQiOjE1NzcxMTA3NTN9.mkUkk7SfeFZrrvoSN6a-37lMHCq3xf2QkPEcy6vrs3k", "member30" },
                    { 39, 1, "member31@gmail.com", new byte[] { 47, 205, 254, 255, 90, 128, 39, 234, 245, 87, 44, 15, 236, 39, 195, 15, 207, 247, 121, 135, 216, 12, 88, 249, 46, 239, 170, 125, 135, 201, 178, 217, 54, 210, 119, 159, 160, 234, 209, 29, 143, 73, 187, 233, 185, 139, 119, 56, 117, 91, 227, 226, 84, 178, 203, 44, 149, 149, 181, 197, 6, 248, 32, 214 }, new byte[] { 139, 131, 243, 76, 235, 216, 253, 228, 227, 154, 99, 252, 163, 118, 122, 127, 78, 155, 2, 161, 145, 29, 84, 220, 67, 151, 254, 35, 120, 94, 171, 141, 61, 183, 160, 10, 157, 56, 114, 28, 127, 27, 251, 127, 211, 73, 152, 8, 108, 206, 183, 221, 190, 146, 24, 129, 25, 181, 178, 52, 213, 219, 143, 0, 183, 196, 41, 97, 29, 125, 148, 178, 245, 131, 200, 48, 205, 155, 168, 153, 12, 153, 44, 170, 17, 175, 17, 135, 34, 129, 164, 60, 10, 122, 43, 250, 64, 248, 87, 247, 79, 91, 92, 13, 17, 181, 51, 114, 15, 27, 235, 15, 253, 25, 79, 222, 57, 214, 72, 191, 44, 133, 184, 146, 19, 13, 91, 55 }, "3419759237 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIzOSIsIm5iZiI6MTU3NzExMDc1MywiZXhwIjoxNTc3NzE1NTUzLCJpYXQiOjE1NzcxMTA3NTN9.6oh5NaX82r8y46F4txd2GDaC51cmyBTzhGkqAK2IHFQ", "member31" },
                    { 40, 1, "member32@gmail.com", new byte[] { 47, 205, 254, 255, 90, 128, 39, 234, 245, 87, 44, 15, 236, 39, 195, 15, 207, 247, 121, 135, 216, 12, 88, 249, 46, 239, 170, 125, 135, 201, 178, 217, 54, 210, 119, 159, 160, 234, 209, 29, 143, 73, 187, 233, 185, 139, 119, 56, 117, 91, 227, 226, 84, 178, 203, 44, 149, 149, 181, 197, 6, 248, 32, 214 }, new byte[] { 139, 131, 243, 76, 235, 216, 253, 228, 227, 154, 99, 252, 163, 118, 122, 127, 78, 155, 2, 161, 145, 29, 84, 220, 67, 151, 254, 35, 120, 94, 171, 141, 61, 183, 160, 10, 157, 56, 114, 28, 127, 27, 251, 127, 211, 73, 152, 8, 108, 206, 183, 221, 190, 146, 24, 129, 25, 181, 178, 52, 213, 219, 143, 0, 183, 196, 41, 97, 29, 125, 148, 178, 245, 131, 200, 48, 205, 155, 168, 153, 12, 153, 44, 170, 17, 175, 17, 135, 34, 129, 164, 60, 10, 122, 43, 250, 64, 248, 87, 247, 79, 91, 92, 13, 17, 181, 51, 114, 15, 27, 235, 15, 253, 25, 79, 222, 57, 214, 72, 191, 44, 133, 184, 146, 19, 13, 91, 55 }, "8137152193 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiI0MCIsIm5iZiI6MTU3NzExMDc1MywiZXhwIjoxNTc3NzE1NTUzLCJpYXQiOjE1NzcxMTA3NTN9.DVgmFHVIvP36s-ByZlbisyyMctnu3rnh57y-lAoMEgs", "member32" },
                    { 41, 1, "member33@gmail.com", new byte[] { 47, 205, 254, 255, 90, 128, 39, 234, 245, 87, 44, 15, 236, 39, 195, 15, 207, 247, 121, 135, 216, 12, 88, 249, 46, 239, 170, 125, 135, 201, 178, 217, 54, 210, 119, 159, 160, 234, 209, 29, 143, 73, 187, 233, 185, 139, 119, 56, 117, 91, 227, 226, 84, 178, 203, 44, 149, 149, 181, 197, 6, 248, 32, 214 }, new byte[] { 139, 131, 243, 76, 235, 216, 253, 228, 227, 154, 99, 252, 163, 118, 122, 127, 78, 155, 2, 161, 145, 29, 84, 220, 67, 151, 254, 35, 120, 94, 171, 141, 61, 183, 160, 10, 157, 56, 114, 28, 127, 27, 251, 127, 211, 73, 152, 8, 108, 206, 183, 221, 190, 146, 24, 129, 25, 181, 178, 52, 213, 219, 143, 0, 183, 196, 41, 97, 29, 125, 148, 178, 245, 131, 200, 48, 205, 155, 168, 153, 12, 153, 44, 170, 17, 175, 17, 135, 34, 129, 164, 60, 10, 122, 43, 250, 64, 248, 87, 247, 79, 91, 92, 13, 17, 181, 51, 114, 15, 27, 235, 15, 253, 25, 79, 222, 57, 214, 72, 191, 44, 133, 184, 146, 19, 13, 91, 55 }, "9675495629 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiI0MSIsIm5iZiI6MTU3NzExMDc1MywiZXhwIjoxNTc3NzE1NTUzLCJpYXQiOjE1NzcxMTA3NTN9.g4eGTio5GB96xJwo0mp_j6NpdpIE1Fuea9FXpMG8HGg", "member33" },
                    { 42, 1, "member34@gmail.com", new byte[] { 47, 205, 254, 255, 90, 128, 39, 234, 245, 87, 44, 15, 236, 39, 195, 15, 207, 247, 121, 135, 216, 12, 88, 249, 46, 239, 170, 125, 135, 201, 178, 217, 54, 210, 119, 159, 160, 234, 209, 29, 143, 73, 187, 233, 185, 139, 119, 56, 117, 91, 227, 226, 84, 178, 203, 44, 149, 149, 181, 197, 6, 248, 32, 214 }, new byte[] { 139, 131, 243, 76, 235, 216, 253, 228, 227, 154, 99, 252, 163, 118, 122, 127, 78, 155, 2, 161, 145, 29, 84, 220, 67, 151, 254, 35, 120, 94, 171, 141, 61, 183, 160, 10, 157, 56, 114, 28, 127, 27, 251, 127, 211, 73, 152, 8, 108, 206, 183, 221, 190, 146, 24, 129, 25, 181, 178, 52, 213, 219, 143, 0, 183, 196, 41, 97, 29, 125, 148, 178, 245, 131, 200, 48, 205, 155, 168, 153, 12, 153, 44, 170, 17, 175, 17, 135, 34, 129, 164, 60, 10, 122, 43, 250, 64, 248, 87, 247, 79, 91, 92, 13, 17, 181, 51, 114, 15, 27, 235, 15, 253, 25, 79, 222, 57, 214, 72, 191, 44, 133, 184, 146, 19, 13, 91, 55 }, "5161342920 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiI0MiIsIm5iZiI6MTU3NzExMDc1MywiZXhwIjoxNTc3NzE1NTUzLCJpYXQiOjE1NzcxMTA3NTN9.xh65yGwlhgX60C36LBMGhRaWf5OrR_u5PfF3MkLqYSw", "member34" },
                    { 43, 1, "member35@gmail.com", new byte[] { 47, 205, 254, 255, 90, 128, 39, 234, 245, 87, 44, 15, 236, 39, 195, 15, 207, 247, 121, 135, 216, 12, 88, 249, 46, 239, 170, 125, 135, 201, 178, 217, 54, 210, 119, 159, 160, 234, 209, 29, 143, 73, 187, 233, 185, 139, 119, 56, 117, 91, 227, 226, 84, 178, 203, 44, 149, 149, 181, 197, 6, 248, 32, 214 }, new byte[] { 139, 131, 243, 76, 235, 216, 253, 228, 227, 154, 99, 252, 163, 118, 122, 127, 78, 155, 2, 161, 145, 29, 84, 220, 67, 151, 254, 35, 120, 94, 171, 141, 61, 183, 160, 10, 157, 56, 114, 28, 127, 27, 251, 127, 211, 73, 152, 8, 108, 206, 183, 221, 190, 146, 24, 129, 25, 181, 178, 52, 213, 219, 143, 0, 183, 196, 41, 97, 29, 125, 148, 178, 245, 131, 200, 48, 205, 155, 168, 153, 12, 153, 44, 170, 17, 175, 17, 135, 34, 129, 164, 60, 10, 122, 43, 250, 64, 248, 87, 247, 79, 91, 92, 13, 17, 181, 51, 114, 15, 27, 235, 15, 253, 25, 79, 222, 57, 214, 72, 191, 44, 133, 184, 146, 19, 13, 91, 55 }, "4616055914 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiI0MyIsIm5iZiI6MTU3NzExMDc1MywiZXhwIjoxNTc3NzE1NTUzLCJpYXQiOjE1NzcxMTA3NTN9.fzssyqTewteSFNZGss9tvqLzCBXUTergk0LaGg_afy8", "member35" },
                    { 44, 1, "member36@gmail.com", new byte[] { 47, 205, 254, 255, 90, 128, 39, 234, 245, 87, 44, 15, 236, 39, 195, 15, 207, 247, 121, 135, 216, 12, 88, 249, 46, 239, 170, 125, 135, 201, 178, 217, 54, 210, 119, 159, 160, 234, 209, 29, 143, 73, 187, 233, 185, 139, 119, 56, 117, 91, 227, 226, 84, 178, 203, 44, 149, 149, 181, 197, 6, 248, 32, 214 }, new byte[] { 139, 131, 243, 76, 235, 216, 253, 228, 227, 154, 99, 252, 163, 118, 122, 127, 78, 155, 2, 161, 145, 29, 84, 220, 67, 151, 254, 35, 120, 94, 171, 141, 61, 183, 160, 10, 157, 56, 114, 28, 127, 27, 251, 127, 211, 73, 152, 8, 108, 206, 183, 221, 190, 146, 24, 129, 25, 181, 178, 52, 213, 219, 143, 0, 183, 196, 41, 97, 29, 125, 148, 178, 245, 131, 200, 48, 205, 155, 168, 153, 12, 153, 44, 170, 17, 175, 17, 135, 34, 129, 164, 60, 10, 122, 43, 250, 64, 248, 87, 247, 79, 91, 92, 13, 17, 181, 51, 114, 15, 27, 235, 15, 253, 25, 79, 222, 57, 214, 72, 191, 44, 133, 184, 146, 19, 13, 91, 55 }, "1531092443 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiI0NCIsIm5iZiI6MTU3NzExMDc1MywiZXhwIjoxNTc3NzE1NTUzLCJpYXQiOjE1NzcxMTA3NTN9.8vGEwHayZjzoXdNOHusrBIKUDWDC28lBatzIcLieejQ", "member36" },
                    { 45, 1, "member37@gmail.com", new byte[] { 47, 205, 254, 255, 90, 128, 39, 234, 245, 87, 44, 15, 236, 39, 195, 15, 207, 247, 121, 135, 216, 12, 88, 249, 46, 239, 170, 125, 135, 201, 178, 217, 54, 210, 119, 159, 160, 234, 209, 29, 143, 73, 187, 233, 185, 139, 119, 56, 117, 91, 227, 226, 84, 178, 203, 44, 149, 149, 181, 197, 6, 248, 32, 214 }, new byte[] { 139, 131, 243, 76, 235, 216, 253, 228, 227, 154, 99, 252, 163, 118, 122, 127, 78, 155, 2, 161, 145, 29, 84, 220, 67, 151, 254, 35, 120, 94, 171, 141, 61, 183, 160, 10, 157, 56, 114, 28, 127, 27, 251, 127, 211, 73, 152, 8, 108, 206, 183, 221, 190, 146, 24, 129, 25, 181, 178, 52, 213, 219, 143, 0, 183, 196, 41, 97, 29, 125, 148, 178, 245, 131, 200, 48, 205, 155, 168, 153, 12, 153, 44, 170, 17, 175, 17, 135, 34, 129, 164, 60, 10, 122, 43, 250, 64, 248, 87, 247, 79, 91, 92, 13, 17, 181, 51, 114, 15, 27, 235, 15, 253, 25, 79, 222, 57, 214, 72, 191, 44, 133, 184, 146, 19, 13, 91, 55 }, "3324710359 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiI0NSIsIm5iZiI6MTU3NzExMDc1MywiZXhwIjoxNTc3NzE1NTUzLCJpYXQiOjE1NzcxMTA3NTN9.KWTExUqxk_sUhX8zlvM9PtiWJZcI1r8S7qBdRqFpCyk", "member37" },
                    { 46, 1, "member38@gmail.com", new byte[] { 47, 205, 254, 255, 90, 128, 39, 234, 245, 87, 44, 15, 236, 39, 195, 15, 207, 247, 121, 135, 216, 12, 88, 249, 46, 239, 170, 125, 135, 201, 178, 217, 54, 210, 119, 159, 160, 234, 209, 29, 143, 73, 187, 233, 185, 139, 119, 56, 117, 91, 227, 226, 84, 178, 203, 44, 149, 149, 181, 197, 6, 248, 32, 214 }, new byte[] { 139, 131, 243, 76, 235, 216, 253, 228, 227, 154, 99, 252, 163, 118, 122, 127, 78, 155, 2, 161, 145, 29, 84, 220, 67, 151, 254, 35, 120, 94, 171, 141, 61, 183, 160, 10, 157, 56, 114, 28, 127, 27, 251, 127, 211, 73, 152, 8, 108, 206, 183, 221, 190, 146, 24, 129, 25, 181, 178, 52, 213, 219, 143, 0, 183, 196, 41, 97, 29, 125, 148, 178, 245, 131, 200, 48, 205, 155, 168, 153, 12, 153, 44, 170, 17, 175, 17, 135, 34, 129, 164, 60, 10, 122, 43, 250, 64, 248, 87, 247, 79, 91, 92, 13, 17, 181, 51, 114, 15, 27, 235, 15, 253, 25, 79, 222, 57, 214, 72, 191, 44, 133, 184, 146, 19, 13, 91, 55 }, "8667200845 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiI0NiIsIm5iZiI6MTU3NzExMDc1MywiZXhwIjoxNTc3NzE1NTUzLCJpYXQiOjE1NzcxMTA3NTN9.m3xAg7NBGI6W1R174vkDqv_zp4NoxH_AGlYvhd-3ZX0", "member38" },
                    { 37, 1, "member29@gmail.com", new byte[] { 47, 205, 254, 255, 90, 128, 39, 234, 245, 87, 44, 15, 236, 39, 195, 15, 207, 247, 121, 135, 216, 12, 88, 249, 46, 239, 170, 125, 135, 201, 178, 217, 54, 210, 119, 159, 160, 234, 209, 29, 143, 73, 187, 233, 185, 139, 119, 56, 117, 91, 227, 226, 84, 178, 203, 44, 149, 149, 181, 197, 6, 248, 32, 214 }, new byte[] { 139, 131, 243, 76, 235, 216, 253, 228, 227, 154, 99, 252, 163, 118, 122, 127, 78, 155, 2, 161, 145, 29, 84, 220, 67, 151, 254, 35, 120, 94, 171, 141, 61, 183, 160, 10, 157, 56, 114, 28, 127, 27, 251, 127, 211, 73, 152, 8, 108, 206, 183, 221, 190, 146, 24, 129, 25, 181, 178, 52, 213, 219, 143, 0, 183, 196, 41, 97, 29, 125, 148, 178, 245, 131, 200, 48, 205, 155, 168, 153, 12, 153, 44, 170, 17, 175, 17, 135, 34, 129, 164, 60, 10, 122, 43, 250, 64, 248, 87, 247, 79, 91, 92, 13, 17, 181, 51, 114, 15, 27, 235, 15, 253, 25, 79, 222, 57, 214, 72, 191, 44, 133, 184, 146, 19, 13, 91, 55 }, "5838001888 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIzNyIsIm5iZiI6MTU3NzExMDc1MywiZXhwIjoxNTc3NzE1NTUzLCJpYXQiOjE1NzcxMTA3NTN9.P3jm2o2Ach4WMEqchWN-q6VwOnZwa2xuJmjiesro8hI", "member29" },
                    { 25, 1, "member17@gmail.com", new byte[] { 47, 205, 254, 255, 90, 128, 39, 234, 245, 87, 44, 15, 236, 39, 195, 15, 207, 247, 121, 135, 216, 12, 88, 249, 46, 239, 170, 125, 135, 201, 178, 217, 54, 210, 119, 159, 160, 234, 209, 29, 143, 73, 187, 233, 185, 139, 119, 56, 117, 91, 227, 226, 84, 178, 203, 44, 149, 149, 181, 197, 6, 248, 32, 214 }, new byte[] { 139, 131, 243, 76, 235, 216, 253, 228, 227, 154, 99, 252, 163, 118, 122, 127, 78, 155, 2, 161, 145, 29, 84, 220, 67, 151, 254, 35, 120, 94, 171, 141, 61, 183, 160, 10, 157, 56, 114, 28, 127, 27, 251, 127, 211, 73, 152, 8, 108, 206, 183, 221, 190, 146, 24, 129, 25, 181, 178, 52, 213, 219, 143, 0, 183, 196, 41, 97, 29, 125, 148, 178, 245, 131, 200, 48, 205, 155, 168, 153, 12, 153, 44, 170, 17, 175, 17, 135, 34, 129, 164, 60, 10, 122, 43, 250, 64, 248, 87, 247, 79, 91, 92, 13, 17, 181, 51, 114, 15, 27, 235, 15, 253, 25, 79, 222, 57, 214, 72, 191, 44, 133, 184, 146, 19, 13, 91, 55 }, "1653986846 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 1, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIyNSIsIm5iZiI6MTU3NzExMDc1MywiZXhwIjoxNTc3NzE1NTUzLCJpYXQiOjE1NzcxMTA3NTN9.IBK-1KqbCwTmxZUPQx9izLCuPyv3wQj70d8jNKbryys", "member17" },
                    { 24, 1, "member16@gmail.com", new byte[] { 47, 205, 254, 255, 90, 128, 39, 234, 245, 87, 44, 15, 236, 39, 195, 15, 207, 247, 121, 135, 216, 12, 88, 249, 46, 239, 170, 125, 135, 201, 178, 217, 54, 210, 119, 159, 160, 234, 209, 29, 143, 73, 187, 233, 185, 139, 119, 56, 117, 91, 227, 226, 84, 178, 203, 44, 149, 149, 181, 197, 6, 248, 32, 214 }, new byte[] { 139, 131, 243, 76, 235, 216, 253, 228, 227, 154, 99, 252, 163, 118, 122, 127, 78, 155, 2, 161, 145, 29, 84, 220, 67, 151, 254, 35, 120, 94, 171, 141, 61, 183, 160, 10, 157, 56, 114, 28, 127, 27, 251, 127, 211, 73, 152, 8, 108, 206, 183, 221, 190, 146, 24, 129, 25, 181, 178, 52, 213, 219, 143, 0, 183, 196, 41, 97, 29, 125, 148, 178, 245, 131, 200, 48, 205, 155, 168, 153, 12, 153, 44, 170, 17, 175, 17, 135, 34, 129, 164, 60, 10, 122, 43, 250, 64, 248, 87, 247, 79, 91, 92, 13, 17, 181, 51, 114, 15, 27, 235, 15, 253, 25, 79, 222, 57, 214, 72, 191, 44, 133, 184, 146, 19, 13, 91, 55 }, "8743387328 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 1, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIyNCIsIm5iZiI6MTU3NzExMDc1MywiZXhwIjoxNTc3NzE1NTUzLCJpYXQiOjE1NzcxMTA3NTN9.QrChMSKcxn51air8hGHlBRlGrpbP6e4B_vgVLgaLNA4", "member16" },
                    { 23, 1, "member15@gmail.com", new byte[] { 47, 205, 254, 255, 90, 128, 39, 234, 245, 87, 44, 15, 236, 39, 195, 15, 207, 247, 121, 135, 216, 12, 88, 249, 46, 239, 170, 125, 135, 201, 178, 217, 54, 210, 119, 159, 160, 234, 209, 29, 143, 73, 187, 233, 185, 139, 119, 56, 117, 91, 227, 226, 84, 178, 203, 44, 149, 149, 181, 197, 6, 248, 32, 214 }, new byte[] { 139, 131, 243, 76, 235, 216, 253, 228, 227, 154, 99, 252, 163, 118, 122, 127, 78, 155, 2, 161, 145, 29, 84, 220, 67, 151, 254, 35, 120, 94, 171, 141, 61, 183, 160, 10, 157, 56, 114, 28, 127, 27, 251, 127, 211, 73, 152, 8, 108, 206, 183, 221, 190, 146, 24, 129, 25, 181, 178, 52, 213, 219, 143, 0, 183, 196, 41, 97, 29, 125, 148, 178, 245, 131, 200, 48, 205, 155, 168, 153, 12, 153, 44, 170, 17, 175, 17, 135, 34, 129, 164, 60, 10, 122, 43, 250, 64, 248, 87, 247, 79, 91, 92, 13, 17, 181, 51, 114, 15, 27, 235, 15, 253, 25, 79, 222, 57, 214, 72, 191, 44, 133, 184, 146, 19, 13, 91, 55 }, "1303405992 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 2, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIyMyIsIm5iZiI6MTU3NzExMDc1MywiZXhwIjoxNTc3NzE1NTUzLCJpYXQiOjE1NzcxMTA3NTN9.Nh9UQBwiOE-akyWSll5NHUnpI0qkRIkh-PB_HRDkktI", "member15" },
                    { 2, 1, "admin02@gmail.com", new byte[] { 47, 205, 254, 255, 90, 128, 39, 234, 245, 87, 44, 15, 236, 39, 195, 15, 207, 247, 121, 135, 216, 12, 88, 249, 46, 239, 170, 125, 135, 201, 178, 217, 54, 210, 119, 159, 160, 234, 209, 29, 143, 73, 187, 233, 185, 139, 119, 56, 117, 91, 227, 226, 84, 178, 203, 44, 149, 149, 181, 197, 6, 248, 32, 214 }, new byte[] { 139, 131, 243, 76, 235, 216, 253, 228, 227, 154, 99, 252, 163, 118, 122, 127, 78, 155, 2, 161, 145, 29, 84, 220, 67, 151, 254, 35, 120, 94, 171, 141, 61, 183, 160, 10, 157, 56, 114, 28, 127, 27, 251, 127, 211, 73, 152, 8, 108, 206, 183, 221, 190, 146, 24, 129, 25, 181, 178, 52, 213, 219, 143, 0, 183, 196, 41, 97, 29, 125, 148, 178, 245, 131, 200, 48, 205, 155, 168, 153, 12, 153, 44, 170, 17, 175, 17, 135, 34, 129, 164, 60, 10, 122, 43, 250, 64, 248, 87, 247, 79, 91, 92, 13, 17, 181, 51, 114, 15, 27, 235, 15, 253, 25, 79, 222, 57, 214, 72, 191, 44, 133, 184, 146, 19, 13, 91, 55 }, "3069338796 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 2, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIyIiwibmJmIjoxNTc3MTEwNzUzLCJleHAiOjE1Nzc3MTU1NTMsImlhdCI6MTU3NzExMDc1M30.agLi5RJGup0kOcZ9zHFitZvU5A5dMoWE59f6ecmFivY", "admin02" },
                    { 3, 1, "admin03@gmail.com", new byte[] { 47, 205, 254, 255, 90, 128, 39, 234, 245, 87, 44, 15, 236, 39, 195, 15, 207, 247, 121, 135, 216, 12, 88, 249, 46, 239, 170, 125, 135, 201, 178, 217, 54, 210, 119, 159, 160, 234, 209, 29, 143, 73, 187, 233, 185, 139, 119, 56, 117, 91, 227, 226, 84, 178, 203, 44, 149, 149, 181, 197, 6, 248, 32, 214 }, new byte[] { 139, 131, 243, 76, 235, 216, 253, 228, 227, 154, 99, 252, 163, 118, 122, 127, 78, 155, 2, 161, 145, 29, 84, 220, 67, 151, 254, 35, 120, 94, 171, 141, 61, 183, 160, 10, 157, 56, 114, 28, 127, 27, 251, 127, 211, 73, 152, 8, 108, 206, 183, 221, 190, 146, 24, 129, 25, 181, 178, 52, 213, 219, 143, 0, 183, 196, 41, 97, 29, 125, 148, 178, 245, 131, 200, 48, 205, 155, 168, 153, 12, 153, 44, 170, 17, 175, 17, 135, 34, 129, 164, 60, 10, 122, 43, 250, 64, 248, 87, 247, 79, 91, 92, 13, 17, 181, 51, 114, 15, 27, 235, 15, 253, 25, 79, 222, 57, 214, 72, 191, 44, 133, 184, 146, 19, 13, 91, 55 }, "105989609 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 2, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIzIiwibmJmIjoxNTc3MTEwNzUzLCJleHAiOjE1Nzc3MTU1NTMsImlhdCI6MTU3NzExMDc1M30.DFx6288cVcFOlSxFhHtWJ-eIgxY9lDxDDEcL_XC2iv0", "admin03" },
                    { 4, 1, "admin04@gmail.com", new byte[] { 47, 205, 254, 255, 90, 128, 39, 234, 245, 87, 44, 15, 236, 39, 195, 15, 207, 247, 121, 135, 216, 12, 88, 249, 46, 239, 170, 125, 135, 201, 178, 217, 54, 210, 119, 159, 160, 234, 209, 29, 143, 73, 187, 233, 185, 139, 119, 56, 117, 91, 227, 226, 84, 178, 203, 44, 149, 149, 181, 197, 6, 248, 32, 214 }, new byte[] { 139, 131, 243, 76, 235, 216, 253, 228, 227, 154, 99, 252, 163, 118, 122, 127, 78, 155, 2, 161, 145, 29, 84, 220, 67, 151, 254, 35, 120, 94, 171, 141, 61, 183, 160, 10, 157, 56, 114, 28, 127, 27, 251, 127, 211, 73, 152, 8, 108, 206, 183, 221, 190, 146, 24, 129, 25, 181, 178, 52, 213, 219, 143, 0, 183, 196, 41, 97, 29, 125, 148, 178, 245, 131, 200, 48, 205, 155, 168, 153, 12, 153, 44, 170, 17, 175, 17, 135, 34, 129, 164, 60, 10, 122, 43, 250, 64, 248, 87, 247, 79, 91, 92, 13, 17, 181, 51, 114, 15, 27, 235, 15, 253, 25, 79, 222, 57, 214, 72, 191, 44, 133, 184, 146, 19, 13, 91, 55 }, "4866078694 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 2, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiI0IiwibmJmIjoxNTc3MTEwNzUzLCJleHAiOjE1Nzc3MTU1NTMsImlhdCI6MTU3NzExMDc1M30.2xG8DkqAbkeJqHv6uHkmyCbvL5X6yNzvCIEZeRFvJuE", "admin04" },
                    { 5, 1, "admin05@gmail.com", new byte[] { 47, 205, 254, 255, 90, 128, 39, 234, 245, 87, 44, 15, 236, 39, 195, 15, 207, 247, 121, 135, 216, 12, 88, 249, 46, 239, 170, 125, 135, 201, 178, 217, 54, 210, 119, 159, 160, 234, 209, 29, 143, 73, 187, 233, 185, 139, 119, 56, 117, 91, 227, 226, 84, 178, 203, 44, 149, 149, 181, 197, 6, 248, 32, 214 }, new byte[] { 139, 131, 243, 76, 235, 216, 253, 228, 227, 154, 99, 252, 163, 118, 122, 127, 78, 155, 2, 161, 145, 29, 84, 220, 67, 151, 254, 35, 120, 94, 171, 141, 61, 183, 160, 10, 157, 56, 114, 28, 127, 27, 251, 127, 211, 73, 152, 8, 108, 206, 183, 221, 190, 146, 24, 129, 25, 181, 178, 52, 213, 219, 143, 0, 183, 196, 41, 97, 29, 125, 148, 178, 245, 131, 200, 48, 205, 155, 168, 153, 12, 153, 44, 170, 17, 175, 17, 135, 34, 129, 164, 60, 10, 122, 43, 250, 64, 248, 87, 247, 79, 91, 92, 13, 17, 181, 51, 114, 15, 27, 235, 15, 253, 25, 79, 222, 57, 214, 72, 191, 44, 133, 184, 146, 19, 13, 91, 55 }, "8659710084 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 2, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiI1IiwibmJmIjoxNTc3MTEwNzUzLCJleHAiOjE1Nzc3MTU1NTMsImlhdCI6MTU3NzExMDc1M30.fcn3MTpBUDWVVHqig7lg2VszrZywnND4sT8wu3RUz6s", "admin05" },
                    { 6, 1, "checker01@gmail.com", new byte[] { 47, 205, 254, 255, 90, 128, 39, 234, 245, 87, 44, 15, 236, 39, 195, 15, 207, 247, 121, 135, 216, 12, 88, 249, 46, 239, 170, 125, 135, 201, 178, 217, 54, 210, 119, 159, 160, 234, 209, 29, 143, 73, 187, 233, 185, 139, 119, 56, 117, 91, 227, 226, 84, 178, 203, 44, 149, 149, 181, 197, 6, 248, 32, 214 }, new byte[] { 139, 131, 243, 76, 235, 216, 253, 228, 227, 154, 99, 252, 163, 118, 122, 127, 78, 155, 2, 161, 145, 29, 84, 220, 67, 151, 254, 35, 120, 94, 171, 141, 61, 183, 160, 10, 157, 56, 114, 28, 127, 27, 251, 127, 211, 73, 152, 8, 108, 206, 183, 221, 190, 146, 24, 129, 25, 181, 178, 52, 213, 219, 143, 0, 183, 196, 41, 97, 29, 125, 148, 178, 245, 131, 200, 48, 205, 155, 168, 153, 12, 153, 44, 170, 17, 175, 17, 135, 34, 129, 164, 60, 10, 122, 43, 250, 64, 248, 87, 247, 79, 91, 92, 13, 17, 181, 51, 114, 15, 27, 235, 15, 253, 25, 79, 222, 57, 214, 72, 191, 44, 133, 184, 146, 19, 13, 91, 55 }, "5844956388 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 1, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiI2IiwibmJmIjoxNTc3MTEwNzUzLCJleHAiOjE1Nzc3MTU1NTMsImlhdCI6MTU3NzExMDc1M30.c_Rx_XU-D4n_Xytpw90ds3WBHdRzOZh9j94m4mu1dGY", "checker01" },
                    { 7, 1, "checker02@gmail.com", new byte[] { 47, 205, 254, 255, 90, 128, 39, 234, 245, 87, 44, 15, 236, 39, 195, 15, 207, 247, 121, 135, 216, 12, 88, 249, 46, 239, 170, 125, 135, 201, 178, 217, 54, 210, 119, 159, 160, 234, 209, 29, 143, 73, 187, 233, 185, 139, 119, 56, 117, 91, 227, 226, 84, 178, 203, 44, 149, 149, 181, 197, 6, 248, 32, 214 }, new byte[] { 139, 131, 243, 76, 235, 216, 253, 228, 227, 154, 99, 252, 163, 118, 122, 127, 78, 155, 2, 161, 145, 29, 84, 220, 67, 151, 254, 35, 120, 94, 171, 141, 61, 183, 160, 10, 157, 56, 114, 28, 127, 27, 251, 127, 211, 73, 152, 8, 108, 206, 183, 221, 190, 146, 24, 129, 25, 181, 178, 52, 213, 219, 143, 0, 183, 196, 41, 97, 29, 125, 148, 178, 245, 131, 200, 48, 205, 155, 168, 153, 12, 153, 44, 170, 17, 175, 17, 135, 34, 129, 164, 60, 10, 122, 43, 250, 64, 248, 87, 247, 79, 91, 92, 13, 17, 181, 51, 114, 15, 27, 235, 15, 253, 25, 79, 222, 57, 214, 72, 191, 44, 133, 184, 146, 19, 13, 91, 55 }, "1669765414 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 1, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiI3IiwibmJmIjoxNTc3MTEwNzUzLCJleHAiOjE1Nzc3MTU1NTMsImlhdCI6MTU3NzExMDc1M30.pThT2Rs57vBN_HJNv10o3WLHXV-83-aFmvvlLd3_9eg", "checker02" },
                    { 8, 1, "checker03@gmail.com", new byte[] { 47, 205, 254, 255, 90, 128, 39, 234, 245, 87, 44, 15, 236, 39, 195, 15, 207, 247, 121, 135, 216, 12, 88, 249, 46, 239, 170, 125, 135, 201, 178, 217, 54, 210, 119, 159, 160, 234, 209, 29, 143, 73, 187, 233, 185, 139, 119, 56, 117, 91, 227, 226, 84, 178, 203, 44, 149, 149, 181, 197, 6, 248, 32, 214 }, new byte[] { 139, 131, 243, 76, 235, 216, 253, 228, 227, 154, 99, 252, 163, 118, 122, 127, 78, 155, 2, 161, 145, 29, 84, 220, 67, 151, 254, 35, 120, 94, 171, 141, 61, 183, 160, 10, 157, 56, 114, 28, 127, 27, 251, 127, 211, 73, 152, 8, 108, 206, 183, 221, 190, 146, 24, 129, 25, 181, 178, 52, 213, 219, 143, 0, 183, 196, 41, 97, 29, 125, 148, 178, 245, 131, 200, 48, 205, 155, 168, 153, 12, 153, 44, 170, 17, 175, 17, 135, 34, 129, 164, 60, 10, 122, 43, 250, 64, 248, 87, 247, 79, 91, 92, 13, 17, 181, 51, 114, 15, 27, 235, 15, 253, 25, 79, 222, 57, 214, 72, 191, 44, 133, 184, 146, 19, 13, 91, 55 }, "5598781614 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 1, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiI4IiwibmJmIjoxNTc3MTEwNzUzLCJleHAiOjE1Nzc3MTU1NTMsImlhdCI6MTU3NzExMDc1M30.WnxRRKMlr3UavMnjjtHdmW91FHvXbURrF1YSwBOmPcA", "checker03" },
                    { 9, 1, "member01@gmail.com", new byte[] { 47, 205, 254, 255, 90, 128, 39, 234, 245, 87, 44, 15, 236, 39, 195, 15, 207, 247, 121, 135, 216, 12, 88, 249, 46, 239, 170, 125, 135, 201, 178, 217, 54, 210, 119, 159, 160, 234, 209, 29, 143, 73, 187, 233, 185, 139, 119, 56, 117, 91, 227, 226, 84, 178, 203, 44, 149, 149, 181, 197, 6, 248, 32, 214 }, new byte[] { 139, 131, 243, 76, 235, 216, 253, 228, 227, 154, 99, 252, 163, 118, 122, 127, 78, 155, 2, 161, 145, 29, 84, 220, 67, 151, 254, 35, 120, 94, 171, 141, 61, 183, 160, 10, 157, 56, 114, 28, 127, 27, 251, 127, 211, 73, 152, 8, 108, 206, 183, 221, 190, 146, 24, 129, 25, 181, 178, 52, 213, 219, 143, 0, 183, 196, 41, 97, 29, 125, 148, 178, 245, 131, 200, 48, 205, 155, 168, 153, 12, 153, 44, 170, 17, 175, 17, 135, 34, 129, 164, 60, 10, 122, 43, 250, 64, 248, 87, 247, 79, 91, 92, 13, 17, 181, 51, 114, 15, 27, 235, 15, 253, 25, 79, 222, 57, 214, 72, 191, 44, 133, 184, 146, 19, 13, 91, 55 }, "3272464106 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiI5IiwibmJmIjoxNTc3MTEwNzUzLCJleHAiOjE1Nzc3MTU1NTMsImlhdCI6MTU3NzExMDc1M30.60y7lcr3LAMsN--R0XsCLrPYOAFxw8JibHTNAmD_iT8", "member01" },
                    { 10, 1, "member02@gmail.com", new byte[] { 47, 205, 254, 255, 90, 128, 39, 234, 245, 87, 44, 15, 236, 39, 195, 15, 207, 247, 121, 135, 216, 12, 88, 249, 46, 239, 170, 125, 135, 201, 178, 217, 54, 210, 119, 159, 160, 234, 209, 29, 143, 73, 187, 233, 185, 139, 119, 56, 117, 91, 227, 226, 84, 178, 203, 44, 149, 149, 181, 197, 6, 248, 32, 214 }, new byte[] { 139, 131, 243, 76, 235, 216, 253, 228, 227, 154, 99, 252, 163, 118, 122, 127, 78, 155, 2, 161, 145, 29, 84, 220, 67, 151, 254, 35, 120, 94, 171, 141, 61, 183, 160, 10, 157, 56, 114, 28, 127, 27, 251, 127, 211, 73, 152, 8, 108, 206, 183, 221, 190, 146, 24, 129, 25, 181, 178, 52, 213, 219, 143, 0, 183, 196, 41, 97, 29, 125, 148, 178, 245, 131, 200, 48, 205, 155, 168, 153, 12, 153, 44, 170, 17, 175, 17, 135, 34, 129, 164, 60, 10, 122, 43, 250, 64, 248, 87, 247, 79, 91, 92, 13, 17, 181, 51, 114, 15, 27, 235, 15, 253, 25, 79, 222, 57, 214, 72, 191, 44, 133, 184, 146, 19, 13, 91, 55 }, "5414887288 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxMCIsIm5iZiI6MTU3NzExMDc1MywiZXhwIjoxNTc3NzE1NTUzLCJpYXQiOjE1NzcxMTA3NTN9.0ImICSn8GtojeN34vjra6TKhCR4O4vY_8Exnvr319YQ", "member02" },
                    { 11, 1, "member03@gmail.com", new byte[] { 47, 205, 254, 255, 90, 128, 39, 234, 245, 87, 44, 15, 236, 39, 195, 15, 207, 247, 121, 135, 216, 12, 88, 249, 46, 239, 170, 125, 135, 201, 178, 217, 54, 210, 119, 159, 160, 234, 209, 29, 143, 73, 187, 233, 185, 139, 119, 56, 117, 91, 227, 226, 84, 178, 203, 44, 149, 149, 181, 197, 6, 248, 32, 214 }, new byte[] { 139, 131, 243, 76, 235, 216, 253, 228, 227, 154, 99, 252, 163, 118, 122, 127, 78, 155, 2, 161, 145, 29, 84, 220, 67, 151, 254, 35, 120, 94, 171, 141, 61, 183, 160, 10, 157, 56, 114, 28, 127, 27, 251, 127, 211, 73, 152, 8, 108, 206, 183, 221, 190, 146, 24, 129, 25, 181, 178, 52, 213, 219, 143, 0, 183, 196, 41, 97, 29, 125, 148, 178, 245, 131, 200, 48, 205, 155, 168, 153, 12, 153, 44, 170, 17, 175, 17, 135, 34, 129, 164, 60, 10, 122, 43, 250, 64, 248, 87, 247, 79, 91, 92, 13, 17, 181, 51, 114, 15, 27, 235, 15, 253, 25, 79, 222, 57, 214, 72, 191, 44, 133, 184, 146, 19, 13, 91, 55 }, "4786399505 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxMSIsIm5iZiI6MTU3NzExMDc1MywiZXhwIjoxNTc3NzE1NTUzLCJpYXQiOjE1NzcxMTA3NTN9.TLRw39xFvRMrlEFgRNaL4HZ45tqW2Vp0c9QK7YvG7sQ", "member03" },
                    { 12, 1, "member04@gmail.com", new byte[] { 47, 205, 254, 255, 90, 128, 39, 234, 245, 87, 44, 15, 236, 39, 195, 15, 207, 247, 121, 135, 216, 12, 88, 249, 46, 239, 170, 125, 135, 201, 178, 217, 54, 210, 119, 159, 160, 234, 209, 29, 143, 73, 187, 233, 185, 139, 119, 56, 117, 91, 227, 226, 84, 178, 203, 44, 149, 149, 181, 197, 6, 248, 32, 214 }, new byte[] { 139, 131, 243, 76, 235, 216, 253, 228, 227, 154, 99, 252, 163, 118, 122, 127, 78, 155, 2, 161, 145, 29, 84, 220, 67, 151, 254, 35, 120, 94, 171, 141, 61, 183, 160, 10, 157, 56, 114, 28, 127, 27, 251, 127, 211, 73, 152, 8, 108, 206, 183, 221, 190, 146, 24, 129, 25, 181, 178, 52, 213, 219, 143, 0, 183, 196, 41, 97, 29, 125, 148, 178, 245, 131, 200, 48, 205, 155, 168, 153, 12, 153, 44, 170, 17, 175, 17, 135, 34, 129, 164, 60, 10, 122, 43, 250, 64, 248, 87, 247, 79, 91, 92, 13, 17, 181, 51, 114, 15, 27, 235, 15, 253, 25, 79, 222, 57, 214, 72, 191, 44, 133, 184, 146, 19, 13, 91, 55 }, "2358305614 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxMiIsIm5iZiI6MTU3NzExMDc1MywiZXhwIjoxNTc3NzE1NTUzLCJpYXQiOjE1NzcxMTA3NTN9.1T5O2Oin5AzBfmHY5Lpc9QF8ocIWS-SV4cKk_E-KpzU", "member04" },
                    { 13, 1, "member05@gmail.com", new byte[] { 47, 205, 254, 255, 90, 128, 39, 234, 245, 87, 44, 15, 236, 39, 195, 15, 207, 247, 121, 135, 216, 12, 88, 249, 46, 239, 170, 125, 135, 201, 178, 217, 54, 210, 119, 159, 160, 234, 209, 29, 143, 73, 187, 233, 185, 139, 119, 56, 117, 91, 227, 226, 84, 178, 203, 44, 149, 149, 181, 197, 6, 248, 32, 214 }, new byte[] { 139, 131, 243, 76, 235, 216, 253, 228, 227, 154, 99, 252, 163, 118, 122, 127, 78, 155, 2, 161, 145, 29, 84, 220, 67, 151, 254, 35, 120, 94, 171, 141, 61, 183, 160, 10, 157, 56, 114, 28, 127, 27, 251, 127, 211, 73, 152, 8, 108, 206, 183, 221, 190, 146, 24, 129, 25, 181, 178, 52, 213, 219, 143, 0, 183, 196, 41, 97, 29, 125, 148, 178, 245, 131, 200, 48, 205, 155, 168, 153, 12, 153, 44, 170, 17, 175, 17, 135, 34, 129, 164, 60, 10, 122, 43, 250, 64, 248, 87, 247, 79, 91, 92, 13, 17, 181, 51, 114, 15, 27, 235, 15, 253, 25, 79, 222, 57, 214, 72, 191, 44, 133, 184, 146, 19, 13, 91, 55 }, "1064846605 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxMyIsIm5iZiI6MTU3NzExMDc1MywiZXhwIjoxNTc3NzE1NTUzLCJpYXQiOjE1NzcxMTA3NTN9.WP_FhcKY6pS1L_h-8QUSf0xUCoUQsJVEsUqVUlWWByk", "member05" },
                    { 14, 1, "member06@gmail.com", new byte[] { 47, 205, 254, 255, 90, 128, 39, 234, 245, 87, 44, 15, 236, 39, 195, 15, 207, 247, 121, 135, 216, 12, 88, 249, 46, 239, 170, 125, 135, 201, 178, 217, 54, 210, 119, 159, 160, 234, 209, 29, 143, 73, 187, 233, 185, 139, 119, 56, 117, 91, 227, 226, 84, 178, 203, 44, 149, 149, 181, 197, 6, 248, 32, 214 }, new byte[] { 139, 131, 243, 76, 235, 216, 253, 228, 227, 154, 99, 252, 163, 118, 122, 127, 78, 155, 2, 161, 145, 29, 84, 220, 67, 151, 254, 35, 120, 94, 171, 141, 61, 183, 160, 10, 157, 56, 114, 28, 127, 27, 251, 127, 211, 73, 152, 8, 108, 206, 183, 221, 190, 146, 24, 129, 25, 181, 178, 52, 213, 219, 143, 0, 183, 196, 41, 97, 29, 125, 148, 178, 245, 131, 200, 48, 205, 155, 168, 153, 12, 153, 44, 170, 17, 175, 17, 135, 34, 129, 164, 60, 10, 122, 43, 250, 64, 248, 87, 247, 79, 91, 92, 13, 17, 181, 51, 114, 15, 27, 235, 15, 253, 25, 79, 222, 57, 214, 72, 191, 44, 133, 184, 146, 19, 13, 91, 55 }, "4686272886 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxNCIsIm5iZiI6MTU3NzExMDc1MywiZXhwIjoxNTc3NzE1NTUzLCJpYXQiOjE1NzcxMTA3NTN9.6e3esA48Iyz6u2tnnBbzIEtmOO8xcTVyqZAf0VAH5UQ", "member06" },
                    { 15, 1, "member07@gmail.com", new byte[] { 47, 205, 254, 255, 90, 128, 39, 234, 245, 87, 44, 15, 236, 39, 195, 15, 207, 247, 121, 135, 216, 12, 88, 249, 46, 239, 170, 125, 135, 201, 178, 217, 54, 210, 119, 159, 160, 234, 209, 29, 143, 73, 187, 233, 185, 139, 119, 56, 117, 91, 227, 226, 84, 178, 203, 44, 149, 149, 181, 197, 6, 248, 32, 214 }, new byte[] { 139, 131, 243, 76, 235, 216, 253, 228, 227, 154, 99, 252, 163, 118, 122, 127, 78, 155, 2, 161, 145, 29, 84, 220, 67, 151, 254, 35, 120, 94, 171, 141, 61, 183, 160, 10, 157, 56, 114, 28, 127, 27, 251, 127, 211, 73, 152, 8, 108, 206, 183, 221, 190, 146, 24, 129, 25, 181, 178, 52, 213, 219, 143, 0, 183, 196, 41, 97, 29, 125, 148, 178, 245, 131, 200, 48, 205, 155, 168, 153, 12, 153, 44, 170, 17, 175, 17, 135, 34, 129, 164, 60, 10, 122, 43, 250, 64, 248, 87, 247, 79, 91, 92, 13, 17, 181, 51, 114, 15, 27, 235, 15, 253, 25, 79, 222, 57, 214, 72, 191, 44, 133, 184, 146, 19, 13, 91, 55 }, "5071973872 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxNSIsIm5iZiI6MTU3NzExMDc1MywiZXhwIjoxNTc3NzE1NTUzLCJpYXQiOjE1NzcxMTA3NTN9.K8gkcukjZ4g8zX87ObQ0nVIruFbrQGDULoDm2kwvnno", "member07" },
                    { 16, 1, "member08@gmail.com", new byte[] { 47, 205, 254, 255, 90, 128, 39, 234, 245, 87, 44, 15, 236, 39, 195, 15, 207, 247, 121, 135, 216, 12, 88, 249, 46, 239, 170, 125, 135, 201, 178, 217, 54, 210, 119, 159, 160, 234, 209, 29, 143, 73, 187, 233, 185, 139, 119, 56, 117, 91, 227, 226, 84, 178, 203, 44, 149, 149, 181, 197, 6, 248, 32, 214 }, new byte[] { 139, 131, 243, 76, 235, 216, 253, 228, 227, 154, 99, 252, 163, 118, 122, 127, 78, 155, 2, 161, 145, 29, 84, 220, 67, 151, 254, 35, 120, 94, 171, 141, 61, 183, 160, 10, 157, 56, 114, 28, 127, 27, 251, 127, 211, 73, 152, 8, 108, 206, 183, 221, 190, 146, 24, 129, 25, 181, 178, 52, 213, 219, 143, 0, 183, 196, 41, 97, 29, 125, 148, 178, 245, 131, 200, 48, 205, 155, 168, 153, 12, 153, 44, 170, 17, 175, 17, 135, 34, 129, 164, 60, 10, 122, 43, 250, 64, 248, 87, 247, 79, 91, 92, 13, 17, 181, 51, 114, 15, 27, 235, 15, 253, 25, 79, 222, 57, 214, 72, 191, 44, 133, 184, 146, 19, 13, 91, 55 }, "334355105 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxNiIsIm5iZiI6MTU3NzExMDc1MywiZXhwIjoxNTc3NzE1NTUzLCJpYXQiOjE1NzcxMTA3NTN9.ap5Bogzvt85gCA32paA9fGajt3Q1vHrFgZi-MUvYRlQ", "member08" },
                    { 17, 1, "member09@gmail.com", new byte[] { 47, 205, 254, 255, 90, 128, 39, 234, 245, 87, 44, 15, 236, 39, 195, 15, 207, 247, 121, 135, 216, 12, 88, 249, 46, 239, 170, 125, 135, 201, 178, 217, 54, 210, 119, 159, 160, 234, 209, 29, 143, 73, 187, 233, 185, 139, 119, 56, 117, 91, 227, 226, 84, 178, 203, 44, 149, 149, 181, 197, 6, 248, 32, 214 }, new byte[] { 139, 131, 243, 76, 235, 216, 253, 228, 227, 154, 99, 252, 163, 118, 122, 127, 78, 155, 2, 161, 145, 29, 84, 220, 67, 151, 254, 35, 120, 94, 171, 141, 61, 183, 160, 10, 157, 56, 114, 28, 127, 27, 251, 127, 211, 73, 152, 8, 108, 206, 183, 221, 190, 146, 24, 129, 25, 181, 178, 52, 213, 219, 143, 0, 183, 196, 41, 97, 29, 125, 148, 178, 245, 131, 200, 48, 205, 155, 168, 153, 12, 153, 44, 170, 17, 175, 17, 135, 34, 129, 164, 60, 10, 122, 43, 250, 64, 248, 87, 247, 79, 91, 92, 13, 17, 181, 51, 114, 15, 27, 235, 15, 253, 25, 79, 222, 57, 214, 72, 191, 44, 133, 184, 146, 19, 13, 91, 55 }, "5471673152 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxNyIsIm5iZiI6MTU3NzExMDc1MywiZXhwIjoxNTc3NzE1NTUzLCJpYXQiOjE1NzcxMTA3NTN9.fyJAJbOkvcAA2I9HpUOWbOuL45K16JPM8_O31sWrfxM", "member09" },
                    { 18, 1, "member10@gmail.com", new byte[] { 47, 205, 254, 255, 90, 128, 39, 234, 245, 87, 44, 15, 236, 39, 195, 15, 207, 247, 121, 135, 216, 12, 88, 249, 46, 239, 170, 125, 135, 201, 178, 217, 54, 210, 119, 159, 160, 234, 209, 29, 143, 73, 187, 233, 185, 139, 119, 56, 117, 91, 227, 226, 84, 178, 203, 44, 149, 149, 181, 197, 6, 248, 32, 214 }, new byte[] { 139, 131, 243, 76, 235, 216, 253, 228, 227, 154, 99, 252, 163, 118, 122, 127, 78, 155, 2, 161, 145, 29, 84, 220, 67, 151, 254, 35, 120, 94, 171, 141, 61, 183, 160, 10, 157, 56, 114, 28, 127, 27, 251, 127, 211, 73, 152, 8, 108, 206, 183, 221, 190, 146, 24, 129, 25, 181, 178, 52, 213, 219, 143, 0, 183, 196, 41, 97, 29, 125, 148, 178, 245, 131, 200, 48, 205, 155, 168, 153, 12, 153, 44, 170, 17, 175, 17, 135, 34, 129, 164, 60, 10, 122, 43, 250, 64, 248, 87, 247, 79, 91, 92, 13, 17, 181, 51, 114, 15, 27, 235, 15, 253, 25, 79, 222, 57, 214, 72, 191, 44, 133, 184, 146, 19, 13, 91, 55 }, "8758801056", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxOCIsIm5iZiI6MTU3NzExMDc1MywiZXhwIjoxNTc3NzE1NTUzLCJpYXQiOjE1NzcxMTA3NTN9.60HwPCcF3FxAKfLxunAhCr77IELb3ijfhyvBmAb28To", "member10" },
                    { 19, 1, "member11@gmail.com", new byte[] { 47, 205, 254, 255, 90, 128, 39, 234, 245, 87, 44, 15, 236, 39, 195, 15, 207, 247, 121, 135, 216, 12, 88, 249, 46, 239, 170, 125, 135, 201, 178, 217, 54, 210, 119, 159, 160, 234, 209, 29, 143, 73, 187, 233, 185, 139, 119, 56, 117, 91, 227, 226, 84, 178, 203, 44, 149, 149, 181, 197, 6, 248, 32, 214 }, new byte[] { 139, 131, 243, 76, 235, 216, 253, 228, 227, 154, 99, 252, 163, 118, 122, 127, 78, 155, 2, 161, 145, 29, 84, 220, 67, 151, 254, 35, 120, 94, 171, 141, 61, 183, 160, 10, 157, 56, 114, 28, 127, 27, 251, 127, 211, 73, 152, 8, 108, 206, 183, 221, 190, 146, 24, 129, 25, 181, 178, 52, 213, 219, 143, 0, 183, 196, 41, 97, 29, 125, 148, 178, 245, 131, 200, 48, 205, 155, 168, 153, 12, 153, 44, 170, 17, 175, 17, 135, 34, 129, 164, 60, 10, 122, 43, 250, 64, 248, 87, 247, 79, 91, 92, 13, 17, 181, 51, 114, 15, 27, 235, 15, 253, 25, 79, 222, 57, 214, 72, 191, 44, 133, 184, 146, 19, 13, 91, 55 }, "1644035575 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 2, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxOSIsIm5iZiI6MTU3NzExMDc1MywiZXhwIjoxNTc3NzE1NTUzLCJpYXQiOjE1NzcxMTA3NTN9._uIAbgkGtQ9g6gu0pSLyKQSnqyH8Yfilv3WSC7daUHI", "member11" },
                    { 20, 1, "member12@gmail.com", new byte[] { 47, 205, 254, 255, 90, 128, 39, 234, 245, 87, 44, 15, 236, 39, 195, 15, 207, 247, 121, 135, 216, 12, 88, 249, 46, 239, 170, 125, 135, 201, 178, 217, 54, 210, 119, 159, 160, 234, 209, 29, 143, 73, 187, 233, 185, 139, 119, 56, 117, 91, 227, 226, 84, 178, 203, 44, 149, 149, 181, 197, 6, 248, 32, 214 }, new byte[] { 139, 131, 243, 76, 235, 216, 253, 228, 227, 154, 99, 252, 163, 118, 122, 127, 78, 155, 2, 161, 145, 29, 84, 220, 67, 151, 254, 35, 120, 94, 171, 141, 61, 183, 160, 10, 157, 56, 114, 28, 127, 27, 251, 127, 211, 73, 152, 8, 108, 206, 183, 221, 190, 146, 24, 129, 25, 181, 178, 52, 213, 219, 143, 0, 183, 196, 41, 97, 29, 125, 148, 178, 245, 131, 200, 48, 205, 155, 168, 153, 12, 153, 44, 170, 17, 175, 17, 135, 34, 129, 164, 60, 10, 122, 43, 250, 64, 248, 87, 247, 79, 91, 92, 13, 17, 181, 51, 114, 15, 27, 235, 15, 253, 25, 79, 222, 57, 214, 72, 191, 44, 133, 184, 146, 19, 13, 91, 55 }, "8414315717 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 2, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIyMCIsIm5iZiI6MTU3NzExMDc1MywiZXhwIjoxNTc3NzE1NTUzLCJpYXQiOjE1NzcxMTA3NTN9.ibLtxdei9nmmiajYOMXqtIgPZZ1guaCIZlYIJHsRueA", "member12" },
                    { 21, 1, "member13@gmail.com", new byte[] { 47, 205, 254, 255, 90, 128, 39, 234, 245, 87, 44, 15, 236, 39, 195, 15, 207, 247, 121, 135, 216, 12, 88, 249, 46, 239, 170, 125, 135, 201, 178, 217, 54, 210, 119, 159, 160, 234, 209, 29, 143, 73, 187, 233, 185, 139, 119, 56, 117, 91, 227, 226, 84, 178, 203, 44, 149, 149, 181, 197, 6, 248, 32, 214 }, new byte[] { 139, 131, 243, 76, 235, 216, 253, 228, 227, 154, 99, 252, 163, 118, 122, 127, 78, 155, 2, 161, 145, 29, 84, 220, 67, 151, 254, 35, 120, 94, 171, 141, 61, 183, 160, 10, 157, 56, 114, 28, 127, 27, 251, 127, 211, 73, 152, 8, 108, 206, 183, 221, 190, 146, 24, 129, 25, 181, 178, 52, 213, 219, 143, 0, 183, 196, 41, 97, 29, 125, 148, 178, 245, 131, 200, 48, 205, 155, 168, 153, 12, 153, 44, 170, 17, 175, 17, 135, 34, 129, 164, 60, 10, 122, 43, 250, 64, 248, 87, 247, 79, 91, 92, 13, 17, 181, 51, 114, 15, 27, 235, 15, 253, 25, 79, 222, 57, 214, 72, 191, 44, 133, 184, 146, 19, 13, 91, 55 }, "4867164497 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 2, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIyMSIsIm5iZiI6MTU3NzExMDc1MywiZXhwIjoxNTc3NzE1NTUzLCJpYXQiOjE1NzcxMTA3NTN9.Q8CzOzG5O1gWMGiwtimaod5lrGspRmnvhrNCF2087Y8", "member13" },
                    { 22, 1, "member14@gmail.com", new byte[] { 47, 205, 254, 255, 90, 128, 39, 234, 245, 87, 44, 15, 236, 39, 195, 15, 207, 247, 121, 135, 216, 12, 88, 249, 46, 239, 170, 125, 135, 201, 178, 217, 54, 210, 119, 159, 160, 234, 209, 29, 143, 73, 187, 233, 185, 139, 119, 56, 117, 91, 227, 226, 84, 178, 203, 44, 149, 149, 181, 197, 6, 248, 32, 214 }, new byte[] { 139, 131, 243, 76, 235, 216, 253, 228, 227, 154, 99, 252, 163, 118, 122, 127, 78, 155, 2, 161, 145, 29, 84, 220, 67, 151, 254, 35, 120, 94, 171, 141, 61, 183, 160, 10, 157, 56, 114, 28, 127, 27, 251, 127, 211, 73, 152, 8, 108, 206, 183, 221, 190, 146, 24, 129, 25, 181, 178, 52, 213, 219, 143, 0, 183, 196, 41, 97, 29, 125, 148, 178, 245, 131, 200, 48, 205, 155, 168, 153, 12, 153, 44, 170, 17, 175, 17, 135, 34, 129, 164, 60, 10, 122, 43, 250, 64, 248, 87, 247, 79, 91, 92, 13, 17, 181, 51, 114, 15, 27, 235, 15, 253, 25, 79, 222, 57, 214, 72, 191, 44, 133, 184, 146, 19, 13, 91, 55 }, "4375563597 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 2, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIyMiIsIm5iZiI6MTU3NzExMDc1MywiZXhwIjoxNTc3NzE1NTUzLCJpYXQiOjE1NzcxMTA3NTN9.y7-qJNTdI0DwhTK2wMGq4fdxatp4zFObdvmtQoHBneY", "member14" },
                    { 47, 1, "member39@gmail.com", new byte[] { 47, 205, 254, 255, 90, 128, 39, 234, 245, 87, 44, 15, 236, 39, 195, 15, 207, 247, 121, 135, 216, 12, 88, 249, 46, 239, 170, 125, 135, 201, 178, 217, 54, 210, 119, 159, 160, 234, 209, 29, 143, 73, 187, 233, 185, 139, 119, 56, 117, 91, 227, 226, 84, 178, 203, 44, 149, 149, 181, 197, 6, 248, 32, 214 }, new byte[] { 139, 131, 243, 76, 235, 216, 253, 228, 227, 154, 99, 252, 163, 118, 122, 127, 78, 155, 2, 161, 145, 29, 84, 220, 67, 151, 254, 35, 120, 94, 171, 141, 61, 183, 160, 10, 157, 56, 114, 28, 127, 27, 251, 127, 211, 73, 152, 8, 108, 206, 183, 221, 190, 146, 24, 129, 25, 181, 178, 52, 213, 219, 143, 0, 183, 196, 41, 97, 29, 125, 148, 178, 245, 131, 200, 48, 205, 155, 168, 153, 12, 153, 44, 170, 17, 175, 17, 135, 34, 129, 164, 60, 10, 122, 43, 250, 64, 248, 87, 247, 79, 91, 92, 13, 17, 181, 51, 114, 15, 27, 235, 15, 253, 25, 79, 222, 57, 214, 72, 191, 44, 133, 184, 146, 19, 13, 91, 55 }, "7849609736", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiI0NyIsIm5iZiI6MTU3NzExMDc1MywiZXhwIjoxNTc3NzE1NTUzLCJpYXQiOjE1NzcxMTA3NTN9.ZZJcVzC51K_Nc_XApyEbG1oN8T1oW_UKfuoN1PUPovo", "member39" },
                    { 48, 1, "member40@gmail.com", new byte[] { 47, 205, 254, 255, 90, 128, 39, 234, 245, 87, 44, 15, 236, 39, 195, 15, 207, 247, 121, 135, 216, 12, 88, 249, 46, 239, 170, 125, 135, 201, 178, 217, 54, 210, 119, 159, 160, 234, 209, 29, 143, 73, 187, 233, 185, 139, 119, 56, 117, 91, 227, 226, 84, 178, 203, 44, 149, 149, 181, 197, 6, 248, 32, 214 }, new byte[] { 139, 131, 243, 76, 235, 216, 253, 228, 227, 154, 99, 252, 163, 118, 122, 127, 78, 155, 2, 161, 145, 29, 84, 220, 67, 151, 254, 35, 120, 94, 171, 141, 61, 183, 160, 10, 157, 56, 114, 28, 127, 27, 251, 127, 211, 73, 152, 8, 108, 206, 183, 221, 190, 146, 24, 129, 25, 181, 178, 52, 213, 219, 143, 0, 183, 196, 41, 97, 29, 125, 148, 178, 245, 131, 200, 48, 205, 155, 168, 153, 12, 153, 44, 170, 17, 175, 17, 135, 34, 129, 164, 60, 10, 122, 43, 250, 64, 248, 87, 247, 79, 91, 92, 13, 17, 181, 51, 114, 15, 27, 235, 15, 253, 25, 79, 222, 57, 214, 72, 191, 44, 133, 184, 146, 19, 13, 91, 55 }, "6559816496 ", "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 0, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiI0OCIsIm5iZiI6MTU3NzExMDc1MywiZXhwIjoxNTc3NzE1NTUzLCJpYXQiOjE1NzcxMTA3NTN9.p40ubGm5n4_ceDaguhL0YpXUUy91lN4IJSQoE0TV5Lw", "member40" }
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

            migrationBuilder.InsertData(
                table: "ParticipantGroups",
                columns: new[] { "Id", "BelongingGroupId", "CreatedAt", "IsCreator", "Status", "UserId" },
                values: new object[,]
                {
                    { 24, 6, new DateTime(2019, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 0, 35 },
                    { 23, 3, new DateTime(2019, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 0, 31 },
                    { 22, 3, new DateTime(2019, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 0, 28 },
                    { 20, 2, new DateTime(2019, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 0, 26 },
                    { 21, 3, new DateTime(2019, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 0, 22 },
                    { 6, 2, new DateTime(2019, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1, 20 },
                    { 16, 5, new DateTime(2019, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1, 19 },
                    { 7, 2, new DateTime(2019, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1, 18 },
                    { 9, 2, new DateTime(2019, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1, 17 },
                    { 14, 5, new DateTime(2019, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1, 16 },
                    { 15, 5, new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1, 15 },
                    { 11, 4, new DateTime(2019, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, 13 },
                    { 19, 2, new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 0, 36 },
                    { 10, 3, new DateTime(2019, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, 12 },
                    { 5, 2, new DateTime(2019, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, 10 },
                    { 1, 1, new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, 9 },
                    { 2, 1, new DateTime(2019, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1, 7 },
                    { 13, 5, new DateTime(2019, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, 5 },
                    { 4, 1, new DateTime(2019, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1, 4 },
                    { 3, 1, new DateTime(2019, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1, 3 },
                    { 17, 6, new DateTime(2019, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, 2 },
                    { 8, 2, new DateTime(2019, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1, 1 },
                    { 12, 4, new DateTime(2019, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1, 14 },
                    { 18, 1, new DateTime(2019, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 0, 40 }
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
