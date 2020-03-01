using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cityton.Repository.Migrations
{
    public partial class LiveChat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_AuthorId",
                table: "Messages");

            migrationBuilder.AlterColumn<int>(
                name: "MediaId",
                table: "Messages",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Messages",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Messages",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "DiscussionId",
                table: "Groups",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "Discussions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Discussions",
                maxLength: 10,
                nullable: true);

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "Id", "CreatedAt", "GroupId", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "group01" },
                    { 2, new DateTime(2019, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "group02" },
                    { 3, new DateTime(2019, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "group03" },
                    { 4, new DateTime(2019, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "group04" },
                    { 5, new DateTime(2019, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "group05" },
                    { 6, new DateTime(2019, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "group06" },
                    { 7, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "general" },
                    { 8, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "staff" }
                });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "DiscussionId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2,
                column: "DiscussionId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 3,
                column: "DiscussionId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 4,
                column: "DiscussionId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 5,
                column: "DiscussionId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 6,
                column: "DiscussionId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 44, 202, 72, 75, 22, 79, 127, 35, 101, 186, 136, 42, 9, 21, 89, 45, 71, 65, 158, 62, 170, 181, 109, 62, 235, 41, 7, 68, 61, 120, 94, 138, 56, 101, 248, 244, 154, 103, 126, 35, 134, 111, 125, 127, 122, 143, 49, 183, 195, 237, 57, 252, 47, 116, 144, 13, 1, 8, 1, 215, 162, 71, 165, 25 }, new byte[] { 172, 152, 42, 87, 96, 45, 211, 192, 48, 109, 230, 147, 28, 224, 164, 48, 119, 43, 252, 140, 160, 97, 101, 144, 211, 20, 33, 249, 171, 142, 56, 199, 225, 209, 116, 222, 222, 129, 119, 99, 162, 52, 167, 0, 62, 27, 106, 81, 136, 87, 39, 44, 170, 143, 8, 12, 166, 150, 228, 2, 229, 189, 48, 189, 0, 4, 136, 52, 233, 252, 63, 141, 167, 155, 10, 105, 79, 81, 6, 28, 92, 113, 80, 83, 52, 233, 103, 102, 102, 64, 135, 43, 208, 78, 181, 92, 195, 140, 58, 84, 145, 234, 71, 58, 138, 239, 209, 221, 3, 166, 204, 72, 184, 131, 161, 86, 171, 134, 66, 70, 15, 9, 223, 52, 49, 135, 149, 72 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjEiLCJyb2xlIjoiQWRtaW4iLCJuYmYiOjE1ODMwODk5NDMsImV4cCI6MTU4MzY5NDc0MywiaWF0IjoxNTgzMDg5OTQzfQ.ZafsMr9V3Alm2P1O9tfcvwraZbZ0Jykb7lTNGL0xuAw" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 44, 202, 72, 75, 22, 79, 127, 35, 101, 186, 136, 42, 9, 21, 89, 45, 71, 65, 158, 62, 170, 181, 109, 62, 235, 41, 7, 68, 61, 120, 94, 138, 56, 101, 248, 244, 154, 103, 126, 35, 134, 111, 125, 127, 122, 143, 49, 183, 195, 237, 57, 252, 47, 116, 144, 13, 1, 8, 1, 215, 162, 71, 165, 25 }, new byte[] { 172, 152, 42, 87, 96, 45, 211, 192, 48, 109, 230, 147, 28, 224, 164, 48, 119, 43, 252, 140, 160, 97, 101, 144, 211, 20, 33, 249, 171, 142, 56, 199, 225, 209, 116, 222, 222, 129, 119, 99, 162, 52, 167, 0, 62, 27, 106, 81, 136, 87, 39, 44, 170, 143, 8, 12, 166, 150, 228, 2, 229, 189, 48, 189, 0, 4, 136, 52, 233, 252, 63, 141, 167, 155, 10, 105, 79, 81, 6, 28, 92, 113, 80, 83, 52, 233, 103, 102, 102, 64, 135, 43, 208, 78, 181, 92, 195, 140, 58, 84, 145, 234, 71, 58, 138, 239, 209, 221, 3, 166, 204, 72, 184, 131, 161, 86, 171, 134, 66, 70, 15, 9, 223, 52, 49, 135, 149, 72 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjIiLCJyb2xlIjoiQWRtaW4iLCJuYmYiOjE1ODMwODk5NDQsImV4cCI6MTU4MzY5NDc0NCwiaWF0IjoxNTgzMDg5OTQ0fQ.koglT9mcR2iVmbxhPmty5aEKjHdg-bfhB80uZWx0umc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 44, 202, 72, 75, 22, 79, 127, 35, 101, 186, 136, 42, 9, 21, 89, 45, 71, 65, 158, 62, 170, 181, 109, 62, 235, 41, 7, 68, 61, 120, 94, 138, 56, 101, 248, 244, 154, 103, 126, 35, 134, 111, 125, 127, 122, 143, 49, 183, 195, 237, 57, 252, 47, 116, 144, 13, 1, 8, 1, 215, 162, 71, 165, 25 }, new byte[] { 172, 152, 42, 87, 96, 45, 211, 192, 48, 109, 230, 147, 28, 224, 164, 48, 119, 43, 252, 140, 160, 97, 101, 144, 211, 20, 33, 249, 171, 142, 56, 199, 225, 209, 116, 222, 222, 129, 119, 99, 162, 52, 167, 0, 62, 27, 106, 81, 136, 87, 39, 44, 170, 143, 8, 12, 166, 150, 228, 2, 229, 189, 48, 189, 0, 4, 136, 52, 233, 252, 63, 141, 167, 155, 10, 105, 79, 81, 6, 28, 92, 113, 80, 83, 52, 233, 103, 102, 102, 64, 135, 43, 208, 78, 181, 92, 195, 140, 58, 84, 145, 234, 71, 58, 138, 239, 209, 221, 3, 166, 204, 72, 184, 131, 161, 86, 171, 134, 66, 70, 15, 9, 223, 52, 49, 135, 149, 72 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjMiLCJyb2xlIjoiQWRtaW4iLCJuYmYiOjE1ODMwODk5NDQsImV4cCI6MTU4MzY5NDc0NCwiaWF0IjoxNTgzMDg5OTQ0fQ.-P5cCKFrb-nRlw58-mxrEq33916CUPBunUybEZnV7tU" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 44, 202, 72, 75, 22, 79, 127, 35, 101, 186, 136, 42, 9, 21, 89, 45, 71, 65, 158, 62, 170, 181, 109, 62, 235, 41, 7, 68, 61, 120, 94, 138, 56, 101, 248, 244, 154, 103, 126, 35, 134, 111, 125, 127, 122, 143, 49, 183, 195, 237, 57, 252, 47, 116, 144, 13, 1, 8, 1, 215, 162, 71, 165, 25 }, new byte[] { 172, 152, 42, 87, 96, 45, 211, 192, 48, 109, 230, 147, 28, 224, 164, 48, 119, 43, 252, 140, 160, 97, 101, 144, 211, 20, 33, 249, 171, 142, 56, 199, 225, 209, 116, 222, 222, 129, 119, 99, 162, 52, 167, 0, 62, 27, 106, 81, 136, 87, 39, 44, 170, 143, 8, 12, 166, 150, 228, 2, 229, 189, 48, 189, 0, 4, 136, 52, 233, 252, 63, 141, 167, 155, 10, 105, 79, 81, 6, 28, 92, 113, 80, 83, 52, 233, 103, 102, 102, 64, 135, 43, 208, 78, 181, 92, 195, 140, 58, 84, 145, 234, 71, 58, 138, 239, 209, 221, 3, 166, 204, 72, 184, 131, 161, 86, 171, 134, 66, 70, 15, 9, 223, 52, 49, 135, 149, 72 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjQiLCJyb2xlIjoiQWRtaW4iLCJuYmYiOjE1ODMwODk5NDQsImV4cCI6MTU4MzY5NDc0NCwiaWF0IjoxNTgzMDg5OTQ0fQ.QSwnA7J06KdTc2Q1b7FxwdX5K-J_G4B5wKGmOpJKJEg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 44, 202, 72, 75, 22, 79, 127, 35, 101, 186, 136, 42, 9, 21, 89, 45, 71, 65, 158, 62, 170, 181, 109, 62, 235, 41, 7, 68, 61, 120, 94, 138, 56, 101, 248, 244, 154, 103, 126, 35, 134, 111, 125, 127, 122, 143, 49, 183, 195, 237, 57, 252, 47, 116, 144, 13, 1, 8, 1, 215, 162, 71, 165, 25 }, new byte[] { 172, 152, 42, 87, 96, 45, 211, 192, 48, 109, 230, 147, 28, 224, 164, 48, 119, 43, 252, 140, 160, 97, 101, 144, 211, 20, 33, 249, 171, 142, 56, 199, 225, 209, 116, 222, 222, 129, 119, 99, 162, 52, 167, 0, 62, 27, 106, 81, 136, 87, 39, 44, 170, 143, 8, 12, 166, 150, 228, 2, 229, 189, 48, 189, 0, 4, 136, 52, 233, 252, 63, 141, 167, 155, 10, 105, 79, 81, 6, 28, 92, 113, 80, 83, 52, 233, 103, 102, 102, 64, 135, 43, 208, 78, 181, 92, 195, 140, 58, 84, 145, 234, 71, 58, 138, 239, 209, 221, 3, 166, 204, 72, 184, 131, 161, 86, 171, 134, 66, 70, 15, 9, 223, 52, 49, 135, 149, 72 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjUiLCJyb2xlIjoiQWRtaW4iLCJuYmYiOjE1ODMwODk5NDQsImV4cCI6MTU4MzY5NDc0NCwiaWF0IjoxNTgzMDg5OTQ0fQ.y8ZCVagNrqWtPBnpiiJQxgqq_hFC75ZAiMhP9FAc9v8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 44, 202, 72, 75, 22, 79, 127, 35, 101, 186, 136, 42, 9, 21, 89, 45, 71, 65, 158, 62, 170, 181, 109, 62, 235, 41, 7, 68, 61, 120, 94, 138, 56, 101, 248, 244, 154, 103, 126, 35, 134, 111, 125, 127, 122, 143, 49, 183, 195, 237, 57, 252, 47, 116, 144, 13, 1, 8, 1, 215, 162, 71, 165, 25 }, new byte[] { 172, 152, 42, 87, 96, 45, 211, 192, 48, 109, 230, 147, 28, 224, 164, 48, 119, 43, 252, 140, 160, 97, 101, 144, 211, 20, 33, 249, 171, 142, 56, 199, 225, 209, 116, 222, 222, 129, 119, 99, 162, 52, 167, 0, 62, 27, 106, 81, 136, 87, 39, 44, 170, 143, 8, 12, 166, 150, 228, 2, 229, 189, 48, 189, 0, 4, 136, 52, 233, 252, 63, 141, 167, 155, 10, 105, 79, 81, 6, 28, 92, 113, 80, 83, 52, 233, 103, 102, 102, 64, 135, 43, 208, 78, 181, 92, 195, 140, 58, 84, 145, 234, 71, 58, 138, 239, 209, 221, 3, 166, 204, 72, 184, 131, 161, 86, 171, 134, 66, 70, 15, 9, 223, 52, 49, 135, 149, 72 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjYiLCJyb2xlIjoiQ2hlY2tlciIsIm5iZiI6MTU4MzA4OTk0NCwiZXhwIjoxNTgzNjk0NzQ0LCJpYXQiOjE1ODMwODk5NDR9.t-6gxXr2LU5St61pNSidOel2EcwvH_sM9aeYN-teMfc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 44, 202, 72, 75, 22, 79, 127, 35, 101, 186, 136, 42, 9, 21, 89, 45, 71, 65, 158, 62, 170, 181, 109, 62, 235, 41, 7, 68, 61, 120, 94, 138, 56, 101, 248, 244, 154, 103, 126, 35, 134, 111, 125, 127, 122, 143, 49, 183, 195, 237, 57, 252, 47, 116, 144, 13, 1, 8, 1, 215, 162, 71, 165, 25 }, new byte[] { 172, 152, 42, 87, 96, 45, 211, 192, 48, 109, 230, 147, 28, 224, 164, 48, 119, 43, 252, 140, 160, 97, 101, 144, 211, 20, 33, 249, 171, 142, 56, 199, 225, 209, 116, 222, 222, 129, 119, 99, 162, 52, 167, 0, 62, 27, 106, 81, 136, 87, 39, 44, 170, 143, 8, 12, 166, 150, 228, 2, 229, 189, 48, 189, 0, 4, 136, 52, 233, 252, 63, 141, 167, 155, 10, 105, 79, 81, 6, 28, 92, 113, 80, 83, 52, 233, 103, 102, 102, 64, 135, 43, 208, 78, 181, 92, 195, 140, 58, 84, 145, 234, 71, 58, 138, 239, 209, 221, 3, 166, 204, 72, 184, 131, 161, 86, 171, 134, 66, 70, 15, 9, 223, 52, 49, 135, 149, 72 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjciLCJyb2xlIjoiQ2hlY2tlciIsIm5iZiI6MTU4MzA4OTk0NCwiZXhwIjoxNTgzNjk0NzQ0LCJpYXQiOjE1ODMwODk5NDR9.c0-3ctvcbkgb7rmK6lAXnD6bgpRo8FAaeXq0b35fECY" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 44, 202, 72, 75, 22, 79, 127, 35, 101, 186, 136, 42, 9, 21, 89, 45, 71, 65, 158, 62, 170, 181, 109, 62, 235, 41, 7, 68, 61, 120, 94, 138, 56, 101, 248, 244, 154, 103, 126, 35, 134, 111, 125, 127, 122, 143, 49, 183, 195, 237, 57, 252, 47, 116, 144, 13, 1, 8, 1, 215, 162, 71, 165, 25 }, new byte[] { 172, 152, 42, 87, 96, 45, 211, 192, 48, 109, 230, 147, 28, 224, 164, 48, 119, 43, 252, 140, 160, 97, 101, 144, 211, 20, 33, 249, 171, 142, 56, 199, 225, 209, 116, 222, 222, 129, 119, 99, 162, 52, 167, 0, 62, 27, 106, 81, 136, 87, 39, 44, 170, 143, 8, 12, 166, 150, 228, 2, 229, 189, 48, 189, 0, 4, 136, 52, 233, 252, 63, 141, 167, 155, 10, 105, 79, 81, 6, 28, 92, 113, 80, 83, 52, 233, 103, 102, 102, 64, 135, 43, 208, 78, 181, 92, 195, 140, 58, 84, 145, 234, 71, 58, 138, 239, 209, 221, 3, 166, 204, 72, 184, 131, 161, 86, 171, 134, 66, 70, 15, 9, 223, 52, 49, 135, 149, 72 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjgiLCJyb2xlIjoiQ2hlY2tlciIsIm5iZiI6MTU4MzA4OTk0NCwiZXhwIjoxNTgzNjk0NzQ0LCJpYXQiOjE1ODMwODk5NDR9.j4ZlXS26y3P_v0vIoTX0TPwDn1SUfPzoQMsxXSmksWU" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 44, 202, 72, 75, 22, 79, 127, 35, 101, 186, 136, 42, 9, 21, 89, 45, 71, 65, 158, 62, 170, 181, 109, 62, 235, 41, 7, 68, 61, 120, 94, 138, 56, 101, 248, 244, 154, 103, 126, 35, 134, 111, 125, 127, 122, 143, 49, 183, 195, 237, 57, 252, 47, 116, 144, 13, 1, 8, 1, 215, 162, 71, 165, 25 }, new byte[] { 172, 152, 42, 87, 96, 45, 211, 192, 48, 109, 230, 147, 28, 224, 164, 48, 119, 43, 252, 140, 160, 97, 101, 144, 211, 20, 33, 249, 171, 142, 56, 199, 225, 209, 116, 222, 222, 129, 119, 99, 162, 52, 167, 0, 62, 27, 106, 81, 136, 87, 39, 44, 170, 143, 8, 12, 166, 150, 228, 2, 229, 189, 48, 189, 0, 4, 136, 52, 233, 252, 63, 141, 167, 155, 10, 105, 79, 81, 6, 28, 92, 113, 80, 83, 52, 233, 103, 102, 102, 64, 135, 43, 208, 78, 181, 92, 195, 140, 58, 84, 145, 234, 71, 58, 138, 239, 209, 221, 3, 166, 204, 72, 184, 131, 161, 86, 171, 134, 66, 70, 15, 9, 223, 52, 49, 135, 149, 72 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjkiLCJyb2xlIjoiTWVtYmVyIiwibmJmIjoxNTgzMDg5OTQ0LCJleHAiOjE1ODM2OTQ3NDQsImlhdCI6MTU4MzA4OTk0NH0.XQUmOF9NkUNt7sGedAwNkb1kvzEld9KMnm7OB9Zl-HU" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 44, 202, 72, 75, 22, 79, 127, 35, 101, 186, 136, 42, 9, 21, 89, 45, 71, 65, 158, 62, 170, 181, 109, 62, 235, 41, 7, 68, 61, 120, 94, 138, 56, 101, 248, 244, 154, 103, 126, 35, 134, 111, 125, 127, 122, 143, 49, 183, 195, 237, 57, 252, 47, 116, 144, 13, 1, 8, 1, 215, 162, 71, 165, 25 }, new byte[] { 172, 152, 42, 87, 96, 45, 211, 192, 48, 109, 230, 147, 28, 224, 164, 48, 119, 43, 252, 140, 160, 97, 101, 144, 211, 20, 33, 249, 171, 142, 56, 199, 225, 209, 116, 222, 222, 129, 119, 99, 162, 52, 167, 0, 62, 27, 106, 81, 136, 87, 39, 44, 170, 143, 8, 12, 166, 150, 228, 2, 229, 189, 48, 189, 0, 4, 136, 52, 233, 252, 63, 141, 167, 155, 10, 105, 79, 81, 6, 28, 92, 113, 80, 83, 52, 233, 103, 102, 102, 64, 135, 43, 208, 78, 181, 92, 195, 140, 58, 84, 145, 234, 71, 58, 138, 239, 209, 221, 3, 166, 204, 72, 184, 131, 161, 86, 171, 134, 66, 70, 15, 9, 223, 52, 49, 135, 149, 72 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjEwIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzA4OTk0NCwiZXhwIjoxNTgzNjk0NzQ0LCJpYXQiOjE1ODMwODk5NDR9.EvqGOaGjmi5a0_W9sX3nDyGDxQjQfZJFjw21wHGAqlU" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 44, 202, 72, 75, 22, 79, 127, 35, 101, 186, 136, 42, 9, 21, 89, 45, 71, 65, 158, 62, 170, 181, 109, 62, 235, 41, 7, 68, 61, 120, 94, 138, 56, 101, 248, 244, 154, 103, 126, 35, 134, 111, 125, 127, 122, 143, 49, 183, 195, 237, 57, 252, 47, 116, 144, 13, 1, 8, 1, 215, 162, 71, 165, 25 }, new byte[] { 172, 152, 42, 87, 96, 45, 211, 192, 48, 109, 230, 147, 28, 224, 164, 48, 119, 43, 252, 140, 160, 97, 101, 144, 211, 20, 33, 249, 171, 142, 56, 199, 225, 209, 116, 222, 222, 129, 119, 99, 162, 52, 167, 0, 62, 27, 106, 81, 136, 87, 39, 44, 170, 143, 8, 12, 166, 150, 228, 2, 229, 189, 48, 189, 0, 4, 136, 52, 233, 252, 63, 141, 167, 155, 10, 105, 79, 81, 6, 28, 92, 113, 80, 83, 52, 233, 103, 102, 102, 64, 135, 43, 208, 78, 181, 92, 195, 140, 58, 84, 145, 234, 71, 58, 138, 239, 209, 221, 3, 166, 204, 72, 184, 131, 161, 86, 171, 134, 66, 70, 15, 9, 223, 52, 49, 135, 149, 72 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjExIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzA4OTk0NCwiZXhwIjoxNTgzNjk0NzQ0LCJpYXQiOjE1ODMwODk5NDR9.ErouxauvcDhaVN9wB9McLR12pmrwoXxdv8E3VN7jzww" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 44, 202, 72, 75, 22, 79, 127, 35, 101, 186, 136, 42, 9, 21, 89, 45, 71, 65, 158, 62, 170, 181, 109, 62, 235, 41, 7, 68, 61, 120, 94, 138, 56, 101, 248, 244, 154, 103, 126, 35, 134, 111, 125, 127, 122, 143, 49, 183, 195, 237, 57, 252, 47, 116, 144, 13, 1, 8, 1, 215, 162, 71, 165, 25 }, new byte[] { 172, 152, 42, 87, 96, 45, 211, 192, 48, 109, 230, 147, 28, 224, 164, 48, 119, 43, 252, 140, 160, 97, 101, 144, 211, 20, 33, 249, 171, 142, 56, 199, 225, 209, 116, 222, 222, 129, 119, 99, 162, 52, 167, 0, 62, 27, 106, 81, 136, 87, 39, 44, 170, 143, 8, 12, 166, 150, 228, 2, 229, 189, 48, 189, 0, 4, 136, 52, 233, 252, 63, 141, 167, 155, 10, 105, 79, 81, 6, 28, 92, 113, 80, 83, 52, 233, 103, 102, 102, 64, 135, 43, 208, 78, 181, 92, 195, 140, 58, 84, 145, 234, 71, 58, 138, 239, 209, 221, 3, 166, 204, 72, 184, 131, 161, 86, 171, 134, 66, 70, 15, 9, 223, 52, 49, 135, 149, 72 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjEyIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzA4OTk0NCwiZXhwIjoxNTgzNjk0NzQ0LCJpYXQiOjE1ODMwODk5NDR9.V7qCuN0bUCsrwYokzTRWhYbcU0-TdqTZ7Jy68CqqMYg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 44, 202, 72, 75, 22, 79, 127, 35, 101, 186, 136, 42, 9, 21, 89, 45, 71, 65, 158, 62, 170, 181, 109, 62, 235, 41, 7, 68, 61, 120, 94, 138, 56, 101, 248, 244, 154, 103, 126, 35, 134, 111, 125, 127, 122, 143, 49, 183, 195, 237, 57, 252, 47, 116, 144, 13, 1, 8, 1, 215, 162, 71, 165, 25 }, new byte[] { 172, 152, 42, 87, 96, 45, 211, 192, 48, 109, 230, 147, 28, 224, 164, 48, 119, 43, 252, 140, 160, 97, 101, 144, 211, 20, 33, 249, 171, 142, 56, 199, 225, 209, 116, 222, 222, 129, 119, 99, 162, 52, 167, 0, 62, 27, 106, 81, 136, 87, 39, 44, 170, 143, 8, 12, 166, 150, 228, 2, 229, 189, 48, 189, 0, 4, 136, 52, 233, 252, 63, 141, 167, 155, 10, 105, 79, 81, 6, 28, 92, 113, 80, 83, 52, 233, 103, 102, 102, 64, 135, 43, 208, 78, 181, 92, 195, 140, 58, 84, 145, 234, 71, 58, 138, 239, 209, 221, 3, 166, 204, 72, 184, 131, 161, 86, 171, 134, 66, 70, 15, 9, 223, 52, 49, 135, 149, 72 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjEzIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzA4OTk0NCwiZXhwIjoxNTgzNjk0NzQ0LCJpYXQiOjE1ODMwODk5NDR9.BV5UVg65RXVJnQEvWaJK5pr6AZXdGRkPy3ezbl4qk7A" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 44, 202, 72, 75, 22, 79, 127, 35, 101, 186, 136, 42, 9, 21, 89, 45, 71, 65, 158, 62, 170, 181, 109, 62, 235, 41, 7, 68, 61, 120, 94, 138, 56, 101, 248, 244, 154, 103, 126, 35, 134, 111, 125, 127, 122, 143, 49, 183, 195, 237, 57, 252, 47, 116, 144, 13, 1, 8, 1, 215, 162, 71, 165, 25 }, new byte[] { 172, 152, 42, 87, 96, 45, 211, 192, 48, 109, 230, 147, 28, 224, 164, 48, 119, 43, 252, 140, 160, 97, 101, 144, 211, 20, 33, 249, 171, 142, 56, 199, 225, 209, 116, 222, 222, 129, 119, 99, 162, 52, 167, 0, 62, 27, 106, 81, 136, 87, 39, 44, 170, 143, 8, 12, 166, 150, 228, 2, 229, 189, 48, 189, 0, 4, 136, 52, 233, 252, 63, 141, 167, 155, 10, 105, 79, 81, 6, 28, 92, 113, 80, 83, 52, 233, 103, 102, 102, 64, 135, 43, 208, 78, 181, 92, 195, 140, 58, 84, 145, 234, 71, 58, 138, 239, 209, 221, 3, 166, 204, 72, 184, 131, 161, 86, 171, 134, 66, 70, 15, 9, 223, 52, 49, 135, 149, 72 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjE0Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzA4OTk0NCwiZXhwIjoxNTgzNjk0NzQ0LCJpYXQiOjE1ODMwODk5NDR9.U0CNrQQCDQtKLwMEaWKZMlJtAXbXfEYpi0jtaXljXVE" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 44, 202, 72, 75, 22, 79, 127, 35, 101, 186, 136, 42, 9, 21, 89, 45, 71, 65, 158, 62, 170, 181, 109, 62, 235, 41, 7, 68, 61, 120, 94, 138, 56, 101, 248, 244, 154, 103, 126, 35, 134, 111, 125, 127, 122, 143, 49, 183, 195, 237, 57, 252, 47, 116, 144, 13, 1, 8, 1, 215, 162, 71, 165, 25 }, new byte[] { 172, 152, 42, 87, 96, 45, 211, 192, 48, 109, 230, 147, 28, 224, 164, 48, 119, 43, 252, 140, 160, 97, 101, 144, 211, 20, 33, 249, 171, 142, 56, 199, 225, 209, 116, 222, 222, 129, 119, 99, 162, 52, 167, 0, 62, 27, 106, 81, 136, 87, 39, 44, 170, 143, 8, 12, 166, 150, 228, 2, 229, 189, 48, 189, 0, 4, 136, 52, 233, 252, 63, 141, 167, 155, 10, 105, 79, 81, 6, 28, 92, 113, 80, 83, 52, 233, 103, 102, 102, 64, 135, 43, 208, 78, 181, 92, 195, 140, 58, 84, 145, 234, 71, 58, 138, 239, 209, 221, 3, 166, 204, 72, 184, 131, 161, 86, 171, 134, 66, 70, 15, 9, 223, 52, 49, 135, 149, 72 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjE1Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzA4OTk0NCwiZXhwIjoxNTgzNjk0NzQ0LCJpYXQiOjE1ODMwODk5NDR9.5XqZ6r5JUGjhNK-2Y-IxCJy1LdZhczCI8QJ0S5xOeRY" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 44, 202, 72, 75, 22, 79, 127, 35, 101, 186, 136, 42, 9, 21, 89, 45, 71, 65, 158, 62, 170, 181, 109, 62, 235, 41, 7, 68, 61, 120, 94, 138, 56, 101, 248, 244, 154, 103, 126, 35, 134, 111, 125, 127, 122, 143, 49, 183, 195, 237, 57, 252, 47, 116, 144, 13, 1, 8, 1, 215, 162, 71, 165, 25 }, new byte[] { 172, 152, 42, 87, 96, 45, 211, 192, 48, 109, 230, 147, 28, 224, 164, 48, 119, 43, 252, 140, 160, 97, 101, 144, 211, 20, 33, 249, 171, 142, 56, 199, 225, 209, 116, 222, 222, 129, 119, 99, 162, 52, 167, 0, 62, 27, 106, 81, 136, 87, 39, 44, 170, 143, 8, 12, 166, 150, 228, 2, 229, 189, 48, 189, 0, 4, 136, 52, 233, 252, 63, 141, 167, 155, 10, 105, 79, 81, 6, 28, 92, 113, 80, 83, 52, 233, 103, 102, 102, 64, 135, 43, 208, 78, 181, 92, 195, 140, 58, 84, 145, 234, 71, 58, 138, 239, 209, 221, 3, 166, 204, 72, 184, 131, 161, 86, 171, 134, 66, 70, 15, 9, 223, 52, 49, 135, 149, 72 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjE2Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzA4OTk0NCwiZXhwIjoxNTgzNjk0NzQ0LCJpYXQiOjE1ODMwODk5NDR9.N0LV78R6fn9mN2BhwugqLWDYJAv-g4Hkqj_xPeJqt3I" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 44, 202, 72, 75, 22, 79, 127, 35, 101, 186, 136, 42, 9, 21, 89, 45, 71, 65, 158, 62, 170, 181, 109, 62, 235, 41, 7, 68, 61, 120, 94, 138, 56, 101, 248, 244, 154, 103, 126, 35, 134, 111, 125, 127, 122, 143, 49, 183, 195, 237, 57, 252, 47, 116, 144, 13, 1, 8, 1, 215, 162, 71, 165, 25 }, new byte[] { 172, 152, 42, 87, 96, 45, 211, 192, 48, 109, 230, 147, 28, 224, 164, 48, 119, 43, 252, 140, 160, 97, 101, 144, 211, 20, 33, 249, 171, 142, 56, 199, 225, 209, 116, 222, 222, 129, 119, 99, 162, 52, 167, 0, 62, 27, 106, 81, 136, 87, 39, 44, 170, 143, 8, 12, 166, 150, 228, 2, 229, 189, 48, 189, 0, 4, 136, 52, 233, 252, 63, 141, 167, 155, 10, 105, 79, 81, 6, 28, 92, 113, 80, 83, 52, 233, 103, 102, 102, 64, 135, 43, 208, 78, 181, 92, 195, 140, 58, 84, 145, 234, 71, 58, 138, 239, 209, 221, 3, 166, 204, 72, 184, 131, 161, 86, 171, 134, 66, 70, 15, 9, 223, 52, 49, 135, 149, 72 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjE3Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzA4OTk0NCwiZXhwIjoxNTgzNjk0NzQ0LCJpYXQiOjE1ODMwODk5NDR9.-n5cdH3MYnGya7BG8eTJ0B_85xu1J1zTj54-I2hyMvs" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 44, 202, 72, 75, 22, 79, 127, 35, 101, 186, 136, 42, 9, 21, 89, 45, 71, 65, 158, 62, 170, 181, 109, 62, 235, 41, 7, 68, 61, 120, 94, 138, 56, 101, 248, 244, 154, 103, 126, 35, 134, 111, 125, 127, 122, 143, 49, 183, 195, 237, 57, 252, 47, 116, 144, 13, 1, 8, 1, 215, 162, 71, 165, 25 }, new byte[] { 172, 152, 42, 87, 96, 45, 211, 192, 48, 109, 230, 147, 28, 224, 164, 48, 119, 43, 252, 140, 160, 97, 101, 144, 211, 20, 33, 249, 171, 142, 56, 199, 225, 209, 116, 222, 222, 129, 119, 99, 162, 52, 167, 0, 62, 27, 106, 81, 136, 87, 39, 44, 170, 143, 8, 12, 166, 150, 228, 2, 229, 189, 48, 189, 0, 4, 136, 52, 233, 252, 63, 141, 167, 155, 10, 105, 79, 81, 6, 28, 92, 113, 80, 83, 52, 233, 103, 102, 102, 64, 135, 43, 208, 78, 181, 92, 195, 140, 58, 84, 145, 234, 71, 58, 138, 239, 209, 221, 3, 166, 204, 72, 184, 131, 161, 86, 171, 134, 66, 70, 15, 9, 223, 52, 49, 135, 149, 72 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjE4Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzA4OTk0NCwiZXhwIjoxNTgzNjk0NzQ0LCJpYXQiOjE1ODMwODk5NDR9.BUjNXlwoGW2JzR__NMwfMPSdAvhkCo63wqGJ1N3dp2U" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 44, 202, 72, 75, 22, 79, 127, 35, 101, 186, 136, 42, 9, 21, 89, 45, 71, 65, 158, 62, 170, 181, 109, 62, 235, 41, 7, 68, 61, 120, 94, 138, 56, 101, 248, 244, 154, 103, 126, 35, 134, 111, 125, 127, 122, 143, 49, 183, 195, 237, 57, 252, 47, 116, 144, 13, 1, 8, 1, 215, 162, 71, 165, 25 }, new byte[] { 172, 152, 42, 87, 96, 45, 211, 192, 48, 109, 230, 147, 28, 224, 164, 48, 119, 43, 252, 140, 160, 97, 101, 144, 211, 20, 33, 249, 171, 142, 56, 199, 225, 209, 116, 222, 222, 129, 119, 99, 162, 52, 167, 0, 62, 27, 106, 81, 136, 87, 39, 44, 170, 143, 8, 12, 166, 150, 228, 2, 229, 189, 48, 189, 0, 4, 136, 52, 233, 252, 63, 141, 167, 155, 10, 105, 79, 81, 6, 28, 92, 113, 80, 83, 52, 233, 103, 102, 102, 64, 135, 43, 208, 78, 181, 92, 195, 140, 58, 84, 145, 234, 71, 58, 138, 239, 209, 221, 3, 166, 204, 72, 184, 131, 161, 86, 171, 134, 66, 70, 15, 9, 223, 52, 49, 135, 149, 72 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjE5Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzA4OTk0NCwiZXhwIjoxNTgzNjk0NzQ0LCJpYXQiOjE1ODMwODk5NDR9.Dp4F9ZoG1f2Vobe5HgsCfN5coAqnICxptkuWjS51vAY" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 44, 202, 72, 75, 22, 79, 127, 35, 101, 186, 136, 42, 9, 21, 89, 45, 71, 65, 158, 62, 170, 181, 109, 62, 235, 41, 7, 68, 61, 120, 94, 138, 56, 101, 248, 244, 154, 103, 126, 35, 134, 111, 125, 127, 122, 143, 49, 183, 195, 237, 57, 252, 47, 116, 144, 13, 1, 8, 1, 215, 162, 71, 165, 25 }, new byte[] { 172, 152, 42, 87, 96, 45, 211, 192, 48, 109, 230, 147, 28, 224, 164, 48, 119, 43, 252, 140, 160, 97, 101, 144, 211, 20, 33, 249, 171, 142, 56, 199, 225, 209, 116, 222, 222, 129, 119, 99, 162, 52, 167, 0, 62, 27, 106, 81, 136, 87, 39, 44, 170, 143, 8, 12, 166, 150, 228, 2, 229, 189, 48, 189, 0, 4, 136, 52, 233, 252, 63, 141, 167, 155, 10, 105, 79, 81, 6, 28, 92, 113, 80, 83, 52, 233, 103, 102, 102, 64, 135, 43, 208, 78, 181, 92, 195, 140, 58, 84, 145, 234, 71, 58, 138, 239, 209, 221, 3, 166, 204, 72, 184, 131, 161, 86, 171, 134, 66, 70, 15, 9, 223, 52, 49, 135, 149, 72 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjIwIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzA4OTk0NCwiZXhwIjoxNTgzNjk0NzQ0LCJpYXQiOjE1ODMwODk5NDR9.-uRRgjEwebnvNfrXUppfZk6YnJVy_Zix65FOJKFrNqY" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 44, 202, 72, 75, 22, 79, 127, 35, 101, 186, 136, 42, 9, 21, 89, 45, 71, 65, 158, 62, 170, 181, 109, 62, 235, 41, 7, 68, 61, 120, 94, 138, 56, 101, 248, 244, 154, 103, 126, 35, 134, 111, 125, 127, 122, 143, 49, 183, 195, 237, 57, 252, 47, 116, 144, 13, 1, 8, 1, 215, 162, 71, 165, 25 }, new byte[] { 172, 152, 42, 87, 96, 45, 211, 192, 48, 109, 230, 147, 28, 224, 164, 48, 119, 43, 252, 140, 160, 97, 101, 144, 211, 20, 33, 249, 171, 142, 56, 199, 225, 209, 116, 222, 222, 129, 119, 99, 162, 52, 167, 0, 62, 27, 106, 81, 136, 87, 39, 44, 170, 143, 8, 12, 166, 150, 228, 2, 229, 189, 48, 189, 0, 4, 136, 52, 233, 252, 63, 141, 167, 155, 10, 105, 79, 81, 6, 28, 92, 113, 80, 83, 52, 233, 103, 102, 102, 64, 135, 43, 208, 78, 181, 92, 195, 140, 58, 84, 145, 234, 71, 58, 138, 239, 209, 221, 3, 166, 204, 72, 184, 131, 161, 86, 171, 134, 66, 70, 15, 9, 223, 52, 49, 135, 149, 72 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjIxIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzA4OTk0NCwiZXhwIjoxNTgzNjk0NzQ0LCJpYXQiOjE1ODMwODk5NDR9.gp827jhK0lqKIZCqczcG_V7xzNsXeviiSIt7ieoyq4Y" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 44, 202, 72, 75, 22, 79, 127, 35, 101, 186, 136, 42, 9, 21, 89, 45, 71, 65, 158, 62, 170, 181, 109, 62, 235, 41, 7, 68, 61, 120, 94, 138, 56, 101, 248, 244, 154, 103, 126, 35, 134, 111, 125, 127, 122, 143, 49, 183, 195, 237, 57, 252, 47, 116, 144, 13, 1, 8, 1, 215, 162, 71, 165, 25 }, new byte[] { 172, 152, 42, 87, 96, 45, 211, 192, 48, 109, 230, 147, 28, 224, 164, 48, 119, 43, 252, 140, 160, 97, 101, 144, 211, 20, 33, 249, 171, 142, 56, 199, 225, 209, 116, 222, 222, 129, 119, 99, 162, 52, 167, 0, 62, 27, 106, 81, 136, 87, 39, 44, 170, 143, 8, 12, 166, 150, 228, 2, 229, 189, 48, 189, 0, 4, 136, 52, 233, 252, 63, 141, 167, 155, 10, 105, 79, 81, 6, 28, 92, 113, 80, 83, 52, 233, 103, 102, 102, 64, 135, 43, 208, 78, 181, 92, 195, 140, 58, 84, 145, 234, 71, 58, 138, 239, 209, 221, 3, 166, 204, 72, 184, 131, 161, 86, 171, 134, 66, 70, 15, 9, 223, 52, 49, 135, 149, 72 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjIyIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzA4OTk0NCwiZXhwIjoxNTgzNjk0NzQ0LCJpYXQiOjE1ODMwODk5NDR9.qYSaLaVlC72FXbL-BHfQ5TfXTHrtt7bfnUnZ_T3Off4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 44, 202, 72, 75, 22, 79, 127, 35, 101, 186, 136, 42, 9, 21, 89, 45, 71, 65, 158, 62, 170, 181, 109, 62, 235, 41, 7, 68, 61, 120, 94, 138, 56, 101, 248, 244, 154, 103, 126, 35, 134, 111, 125, 127, 122, 143, 49, 183, 195, 237, 57, 252, 47, 116, 144, 13, 1, 8, 1, 215, 162, 71, 165, 25 }, new byte[] { 172, 152, 42, 87, 96, 45, 211, 192, 48, 109, 230, 147, 28, 224, 164, 48, 119, 43, 252, 140, 160, 97, 101, 144, 211, 20, 33, 249, 171, 142, 56, 199, 225, 209, 116, 222, 222, 129, 119, 99, 162, 52, 167, 0, 62, 27, 106, 81, 136, 87, 39, 44, 170, 143, 8, 12, 166, 150, 228, 2, 229, 189, 48, 189, 0, 4, 136, 52, 233, 252, 63, 141, 167, 155, 10, 105, 79, 81, 6, 28, 92, 113, 80, 83, 52, 233, 103, 102, 102, 64, 135, 43, 208, 78, 181, 92, 195, 140, 58, 84, 145, 234, 71, 58, 138, 239, 209, 221, 3, 166, 204, 72, 184, 131, 161, 86, 171, 134, 66, 70, 15, 9, 223, 52, 49, 135, 149, 72 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjIzIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzA4OTk0NCwiZXhwIjoxNTgzNjk0NzQ0LCJpYXQiOjE1ODMwODk5NDR9.TTrBRthHZbxyVLaVR4K-DNaF95RkpVpl80ZHutwO7no" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 44, 202, 72, 75, 22, 79, 127, 35, 101, 186, 136, 42, 9, 21, 89, 45, 71, 65, 158, 62, 170, 181, 109, 62, 235, 41, 7, 68, 61, 120, 94, 138, 56, 101, 248, 244, 154, 103, 126, 35, 134, 111, 125, 127, 122, 143, 49, 183, 195, 237, 57, 252, 47, 116, 144, 13, 1, 8, 1, 215, 162, 71, 165, 25 }, new byte[] { 172, 152, 42, 87, 96, 45, 211, 192, 48, 109, 230, 147, 28, 224, 164, 48, 119, 43, 252, 140, 160, 97, 101, 144, 211, 20, 33, 249, 171, 142, 56, 199, 225, 209, 116, 222, 222, 129, 119, 99, 162, 52, 167, 0, 62, 27, 106, 81, 136, 87, 39, 44, 170, 143, 8, 12, 166, 150, 228, 2, 229, 189, 48, 189, 0, 4, 136, 52, 233, 252, 63, 141, 167, 155, 10, 105, 79, 81, 6, 28, 92, 113, 80, 83, 52, 233, 103, 102, 102, 64, 135, 43, 208, 78, 181, 92, 195, 140, 58, 84, 145, 234, 71, 58, 138, 239, 209, 221, 3, 166, 204, 72, 184, 131, 161, 86, 171, 134, 66, 70, 15, 9, 223, 52, 49, 135, 149, 72 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjI0Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzA4OTk0NCwiZXhwIjoxNTgzNjk0NzQ0LCJpYXQiOjE1ODMwODk5NDR9.vZ2_gqYbmda0Qzq0Y6hP8fr0L1g1H3DW8YDoWCzECPM" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 44, 202, 72, 75, 22, 79, 127, 35, 101, 186, 136, 42, 9, 21, 89, 45, 71, 65, 158, 62, 170, 181, 109, 62, 235, 41, 7, 68, 61, 120, 94, 138, 56, 101, 248, 244, 154, 103, 126, 35, 134, 111, 125, 127, 122, 143, 49, 183, 195, 237, 57, 252, 47, 116, 144, 13, 1, 8, 1, 215, 162, 71, 165, 25 }, new byte[] { 172, 152, 42, 87, 96, 45, 211, 192, 48, 109, 230, 147, 28, 224, 164, 48, 119, 43, 252, 140, 160, 97, 101, 144, 211, 20, 33, 249, 171, 142, 56, 199, 225, 209, 116, 222, 222, 129, 119, 99, 162, 52, 167, 0, 62, 27, 106, 81, 136, 87, 39, 44, 170, 143, 8, 12, 166, 150, 228, 2, 229, 189, 48, 189, 0, 4, 136, 52, 233, 252, 63, 141, 167, 155, 10, 105, 79, 81, 6, 28, 92, 113, 80, 83, 52, 233, 103, 102, 102, 64, 135, 43, 208, 78, 181, 92, 195, 140, 58, 84, 145, 234, 71, 58, 138, 239, 209, 221, 3, 166, 204, 72, 184, 131, 161, 86, 171, 134, 66, 70, 15, 9, 223, 52, 49, 135, 149, 72 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjI1Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzA4OTk0NCwiZXhwIjoxNTgzNjk0NzQ0LCJpYXQiOjE1ODMwODk5NDR9.Ylg2SZEaUjATmnUvGBPwcoTZH3mqUEcq4zO0Tno9v3U" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 44, 202, 72, 75, 22, 79, 127, 35, 101, 186, 136, 42, 9, 21, 89, 45, 71, 65, 158, 62, 170, 181, 109, 62, 235, 41, 7, 68, 61, 120, 94, 138, 56, 101, 248, 244, 154, 103, 126, 35, 134, 111, 125, 127, 122, 143, 49, 183, 195, 237, 57, 252, 47, 116, 144, 13, 1, 8, 1, 215, 162, 71, 165, 25 }, new byte[] { 172, 152, 42, 87, 96, 45, 211, 192, 48, 109, 230, 147, 28, 224, 164, 48, 119, 43, 252, 140, 160, 97, 101, 144, 211, 20, 33, 249, 171, 142, 56, 199, 225, 209, 116, 222, 222, 129, 119, 99, 162, 52, 167, 0, 62, 27, 106, 81, 136, 87, 39, 44, 170, 143, 8, 12, 166, 150, 228, 2, 229, 189, 48, 189, 0, 4, 136, 52, 233, 252, 63, 141, 167, 155, 10, 105, 79, 81, 6, 28, 92, 113, 80, 83, 52, 233, 103, 102, 102, 64, 135, 43, 208, 78, 181, 92, 195, 140, 58, 84, 145, 234, 71, 58, 138, 239, 209, 221, 3, 166, 204, 72, 184, 131, 161, 86, 171, 134, 66, 70, 15, 9, 223, 52, 49, 135, 149, 72 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjI2Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzA4OTk0NCwiZXhwIjoxNTgzNjk0NzQ0LCJpYXQiOjE1ODMwODk5NDR9.MEC_mjcPlNdSsmNGZnCe0Py7a-SVCo13TWueToZBBKk" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 44, 202, 72, 75, 22, 79, 127, 35, 101, 186, 136, 42, 9, 21, 89, 45, 71, 65, 158, 62, 170, 181, 109, 62, 235, 41, 7, 68, 61, 120, 94, 138, 56, 101, 248, 244, 154, 103, 126, 35, 134, 111, 125, 127, 122, 143, 49, 183, 195, 237, 57, 252, 47, 116, 144, 13, 1, 8, 1, 215, 162, 71, 165, 25 }, new byte[] { 172, 152, 42, 87, 96, 45, 211, 192, 48, 109, 230, 147, 28, 224, 164, 48, 119, 43, 252, 140, 160, 97, 101, 144, 211, 20, 33, 249, 171, 142, 56, 199, 225, 209, 116, 222, 222, 129, 119, 99, 162, 52, 167, 0, 62, 27, 106, 81, 136, 87, 39, 44, 170, 143, 8, 12, 166, 150, 228, 2, 229, 189, 48, 189, 0, 4, 136, 52, 233, 252, 63, 141, 167, 155, 10, 105, 79, 81, 6, 28, 92, 113, 80, 83, 52, 233, 103, 102, 102, 64, 135, 43, 208, 78, 181, 92, 195, 140, 58, 84, 145, 234, 71, 58, 138, 239, 209, 221, 3, 166, 204, 72, 184, 131, 161, 86, 171, 134, 66, 70, 15, 9, 223, 52, 49, 135, 149, 72 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjI3Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzA4OTk0NCwiZXhwIjoxNTgzNjk0NzQ0LCJpYXQiOjE1ODMwODk5NDR9._HXmExXiDgZzdsfHOrphKs6tQuEf6VDybABJVF_JHnQ" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 44, 202, 72, 75, 22, 79, 127, 35, 101, 186, 136, 42, 9, 21, 89, 45, 71, 65, 158, 62, 170, 181, 109, 62, 235, 41, 7, 68, 61, 120, 94, 138, 56, 101, 248, 244, 154, 103, 126, 35, 134, 111, 125, 127, 122, 143, 49, 183, 195, 237, 57, 252, 47, 116, 144, 13, 1, 8, 1, 215, 162, 71, 165, 25 }, new byte[] { 172, 152, 42, 87, 96, 45, 211, 192, 48, 109, 230, 147, 28, 224, 164, 48, 119, 43, 252, 140, 160, 97, 101, 144, 211, 20, 33, 249, 171, 142, 56, 199, 225, 209, 116, 222, 222, 129, 119, 99, 162, 52, 167, 0, 62, 27, 106, 81, 136, 87, 39, 44, 170, 143, 8, 12, 166, 150, 228, 2, 229, 189, 48, 189, 0, 4, 136, 52, 233, 252, 63, 141, 167, 155, 10, 105, 79, 81, 6, 28, 92, 113, 80, 83, 52, 233, 103, 102, 102, 64, 135, 43, 208, 78, 181, 92, 195, 140, 58, 84, 145, 234, 71, 58, 138, 239, 209, 221, 3, 166, 204, 72, 184, 131, 161, 86, 171, 134, 66, 70, 15, 9, 223, 52, 49, 135, 149, 72 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjI4Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzA4OTk0NCwiZXhwIjoxNTgzNjk0NzQ0LCJpYXQiOjE1ODMwODk5NDR9.tLBi7dLLqnm3ExrJOjnK2psvYD9Fl-Kdqd05infIY08" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 44, 202, 72, 75, 22, 79, 127, 35, 101, 186, 136, 42, 9, 21, 89, 45, 71, 65, 158, 62, 170, 181, 109, 62, 235, 41, 7, 68, 61, 120, 94, 138, 56, 101, 248, 244, 154, 103, 126, 35, 134, 111, 125, 127, 122, 143, 49, 183, 195, 237, 57, 252, 47, 116, 144, 13, 1, 8, 1, 215, 162, 71, 165, 25 }, new byte[] { 172, 152, 42, 87, 96, 45, 211, 192, 48, 109, 230, 147, 28, 224, 164, 48, 119, 43, 252, 140, 160, 97, 101, 144, 211, 20, 33, 249, 171, 142, 56, 199, 225, 209, 116, 222, 222, 129, 119, 99, 162, 52, 167, 0, 62, 27, 106, 81, 136, 87, 39, 44, 170, 143, 8, 12, 166, 150, 228, 2, 229, 189, 48, 189, 0, 4, 136, 52, 233, 252, 63, 141, 167, 155, 10, 105, 79, 81, 6, 28, 92, 113, 80, 83, 52, 233, 103, 102, 102, 64, 135, 43, 208, 78, 181, 92, 195, 140, 58, 84, 145, 234, 71, 58, 138, 239, 209, 221, 3, 166, 204, 72, 184, 131, 161, 86, 171, 134, 66, 70, 15, 9, 223, 52, 49, 135, 149, 72 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjI5Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzA4OTk0NCwiZXhwIjoxNTgzNjk0NzQ0LCJpYXQiOjE1ODMwODk5NDR9.W1WDR9FlGxe-sVDF-xKRXwG4LshMt46ZnJASPIm5LCI" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 44, 202, 72, 75, 22, 79, 127, 35, 101, 186, 136, 42, 9, 21, 89, 45, 71, 65, 158, 62, 170, 181, 109, 62, 235, 41, 7, 68, 61, 120, 94, 138, 56, 101, 248, 244, 154, 103, 126, 35, 134, 111, 125, 127, 122, 143, 49, 183, 195, 237, 57, 252, 47, 116, 144, 13, 1, 8, 1, 215, 162, 71, 165, 25 }, new byte[] { 172, 152, 42, 87, 96, 45, 211, 192, 48, 109, 230, 147, 28, 224, 164, 48, 119, 43, 252, 140, 160, 97, 101, 144, 211, 20, 33, 249, 171, 142, 56, 199, 225, 209, 116, 222, 222, 129, 119, 99, 162, 52, 167, 0, 62, 27, 106, 81, 136, 87, 39, 44, 170, 143, 8, 12, 166, 150, 228, 2, 229, 189, 48, 189, 0, 4, 136, 52, 233, 252, 63, 141, 167, 155, 10, 105, 79, 81, 6, 28, 92, 113, 80, 83, 52, 233, 103, 102, 102, 64, 135, 43, 208, 78, 181, 92, 195, 140, 58, 84, 145, 234, 71, 58, 138, 239, 209, 221, 3, 166, 204, 72, 184, 131, 161, 86, 171, 134, 66, 70, 15, 9, 223, 52, 49, 135, 149, 72 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjMwIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzA4OTk0NCwiZXhwIjoxNTgzNjk0NzQ0LCJpYXQiOjE1ODMwODk5NDR9.LXI6Fa-1dlDFYfM_q0ftYtviJpvgMx-YOunBxVBvzDw" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 44, 202, 72, 75, 22, 79, 127, 35, 101, 186, 136, 42, 9, 21, 89, 45, 71, 65, 158, 62, 170, 181, 109, 62, 235, 41, 7, 68, 61, 120, 94, 138, 56, 101, 248, 244, 154, 103, 126, 35, 134, 111, 125, 127, 122, 143, 49, 183, 195, 237, 57, 252, 47, 116, 144, 13, 1, 8, 1, 215, 162, 71, 165, 25 }, new byte[] { 172, 152, 42, 87, 96, 45, 211, 192, 48, 109, 230, 147, 28, 224, 164, 48, 119, 43, 252, 140, 160, 97, 101, 144, 211, 20, 33, 249, 171, 142, 56, 199, 225, 209, 116, 222, 222, 129, 119, 99, 162, 52, 167, 0, 62, 27, 106, 81, 136, 87, 39, 44, 170, 143, 8, 12, 166, 150, 228, 2, 229, 189, 48, 189, 0, 4, 136, 52, 233, 252, 63, 141, 167, 155, 10, 105, 79, 81, 6, 28, 92, 113, 80, 83, 52, 233, 103, 102, 102, 64, 135, 43, 208, 78, 181, 92, 195, 140, 58, 84, 145, 234, 71, 58, 138, 239, 209, 221, 3, 166, 204, 72, 184, 131, 161, 86, 171, 134, 66, 70, 15, 9, 223, 52, 49, 135, 149, 72 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjMxIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzA4OTk0NCwiZXhwIjoxNTgzNjk0NzQ0LCJpYXQiOjE1ODMwODk5NDR9.t2tO7tclINwCj-NyDiS5NOSnBk25HVQEtmFI4uBvHNU" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 44, 202, 72, 75, 22, 79, 127, 35, 101, 186, 136, 42, 9, 21, 89, 45, 71, 65, 158, 62, 170, 181, 109, 62, 235, 41, 7, 68, 61, 120, 94, 138, 56, 101, 248, 244, 154, 103, 126, 35, 134, 111, 125, 127, 122, 143, 49, 183, 195, 237, 57, 252, 47, 116, 144, 13, 1, 8, 1, 215, 162, 71, 165, 25 }, new byte[] { 172, 152, 42, 87, 96, 45, 211, 192, 48, 109, 230, 147, 28, 224, 164, 48, 119, 43, 252, 140, 160, 97, 101, 144, 211, 20, 33, 249, 171, 142, 56, 199, 225, 209, 116, 222, 222, 129, 119, 99, 162, 52, 167, 0, 62, 27, 106, 81, 136, 87, 39, 44, 170, 143, 8, 12, 166, 150, 228, 2, 229, 189, 48, 189, 0, 4, 136, 52, 233, 252, 63, 141, 167, 155, 10, 105, 79, 81, 6, 28, 92, 113, 80, 83, 52, 233, 103, 102, 102, 64, 135, 43, 208, 78, 181, 92, 195, 140, 58, 84, 145, 234, 71, 58, 138, 239, 209, 221, 3, 166, 204, 72, 184, 131, 161, 86, 171, 134, 66, 70, 15, 9, 223, 52, 49, 135, 149, 72 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjMyIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzA4OTk0NCwiZXhwIjoxNTgzNjk0NzQ0LCJpYXQiOjE1ODMwODk5NDR9.RMRtUX2748XaO3F0xUwey8HsJrWU_74pK1aiB2bEsn0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 44, 202, 72, 75, 22, 79, 127, 35, 101, 186, 136, 42, 9, 21, 89, 45, 71, 65, 158, 62, 170, 181, 109, 62, 235, 41, 7, 68, 61, 120, 94, 138, 56, 101, 248, 244, 154, 103, 126, 35, 134, 111, 125, 127, 122, 143, 49, 183, 195, 237, 57, 252, 47, 116, 144, 13, 1, 8, 1, 215, 162, 71, 165, 25 }, new byte[] { 172, 152, 42, 87, 96, 45, 211, 192, 48, 109, 230, 147, 28, 224, 164, 48, 119, 43, 252, 140, 160, 97, 101, 144, 211, 20, 33, 249, 171, 142, 56, 199, 225, 209, 116, 222, 222, 129, 119, 99, 162, 52, 167, 0, 62, 27, 106, 81, 136, 87, 39, 44, 170, 143, 8, 12, 166, 150, 228, 2, 229, 189, 48, 189, 0, 4, 136, 52, 233, 252, 63, 141, 167, 155, 10, 105, 79, 81, 6, 28, 92, 113, 80, 83, 52, 233, 103, 102, 102, 64, 135, 43, 208, 78, 181, 92, 195, 140, 58, 84, 145, 234, 71, 58, 138, 239, 209, 221, 3, 166, 204, 72, 184, 131, 161, 86, 171, 134, 66, 70, 15, 9, 223, 52, 49, 135, 149, 72 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjMzIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzA4OTk0NCwiZXhwIjoxNTgzNjk0NzQ0LCJpYXQiOjE1ODMwODk5NDR9.fpfv9Tf2_plrXdWjjsr7Gl49SlPu3eCkU9WaWxkPqRc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 44, 202, 72, 75, 22, 79, 127, 35, 101, 186, 136, 42, 9, 21, 89, 45, 71, 65, 158, 62, 170, 181, 109, 62, 235, 41, 7, 68, 61, 120, 94, 138, 56, 101, 248, 244, 154, 103, 126, 35, 134, 111, 125, 127, 122, 143, 49, 183, 195, 237, 57, 252, 47, 116, 144, 13, 1, 8, 1, 215, 162, 71, 165, 25 }, new byte[] { 172, 152, 42, 87, 96, 45, 211, 192, 48, 109, 230, 147, 28, 224, 164, 48, 119, 43, 252, 140, 160, 97, 101, 144, 211, 20, 33, 249, 171, 142, 56, 199, 225, 209, 116, 222, 222, 129, 119, 99, 162, 52, 167, 0, 62, 27, 106, 81, 136, 87, 39, 44, 170, 143, 8, 12, 166, 150, 228, 2, 229, 189, 48, 189, 0, 4, 136, 52, 233, 252, 63, 141, 167, 155, 10, 105, 79, 81, 6, 28, 92, 113, 80, 83, 52, 233, 103, 102, 102, 64, 135, 43, 208, 78, 181, 92, 195, 140, 58, 84, 145, 234, 71, 58, 138, 239, 209, 221, 3, 166, 204, 72, 184, 131, 161, 86, 171, 134, 66, 70, 15, 9, 223, 52, 49, 135, 149, 72 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjM0Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzA4OTk0NCwiZXhwIjoxNTgzNjk0NzQ0LCJpYXQiOjE1ODMwODk5NDR9.0GZHGWSQoU9_Zx8gG6J6Lp5RwMDt3wta4h2QjXlmStM" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 44, 202, 72, 75, 22, 79, 127, 35, 101, 186, 136, 42, 9, 21, 89, 45, 71, 65, 158, 62, 170, 181, 109, 62, 235, 41, 7, 68, 61, 120, 94, 138, 56, 101, 248, 244, 154, 103, 126, 35, 134, 111, 125, 127, 122, 143, 49, 183, 195, 237, 57, 252, 47, 116, 144, 13, 1, 8, 1, 215, 162, 71, 165, 25 }, new byte[] { 172, 152, 42, 87, 96, 45, 211, 192, 48, 109, 230, 147, 28, 224, 164, 48, 119, 43, 252, 140, 160, 97, 101, 144, 211, 20, 33, 249, 171, 142, 56, 199, 225, 209, 116, 222, 222, 129, 119, 99, 162, 52, 167, 0, 62, 27, 106, 81, 136, 87, 39, 44, 170, 143, 8, 12, 166, 150, 228, 2, 229, 189, 48, 189, 0, 4, 136, 52, 233, 252, 63, 141, 167, 155, 10, 105, 79, 81, 6, 28, 92, 113, 80, 83, 52, 233, 103, 102, 102, 64, 135, 43, 208, 78, 181, 92, 195, 140, 58, 84, 145, 234, 71, 58, 138, 239, 209, 221, 3, 166, 204, 72, 184, 131, 161, 86, 171, 134, 66, 70, 15, 9, 223, 52, 49, 135, 149, 72 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjM1Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzA4OTk0NCwiZXhwIjoxNTgzNjk0NzQ0LCJpYXQiOjE1ODMwODk5NDR9.-J0pDGUBbYq6Dx3gOPIXsxIJbV9k4aZDjIlI0AIR038" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 44, 202, 72, 75, 22, 79, 127, 35, 101, 186, 136, 42, 9, 21, 89, 45, 71, 65, 158, 62, 170, 181, 109, 62, 235, 41, 7, 68, 61, 120, 94, 138, 56, 101, 248, 244, 154, 103, 126, 35, 134, 111, 125, 127, 122, 143, 49, 183, 195, 237, 57, 252, 47, 116, 144, 13, 1, 8, 1, 215, 162, 71, 165, 25 }, new byte[] { 172, 152, 42, 87, 96, 45, 211, 192, 48, 109, 230, 147, 28, 224, 164, 48, 119, 43, 252, 140, 160, 97, 101, 144, 211, 20, 33, 249, 171, 142, 56, 199, 225, 209, 116, 222, 222, 129, 119, 99, 162, 52, 167, 0, 62, 27, 106, 81, 136, 87, 39, 44, 170, 143, 8, 12, 166, 150, 228, 2, 229, 189, 48, 189, 0, 4, 136, 52, 233, 252, 63, 141, 167, 155, 10, 105, 79, 81, 6, 28, 92, 113, 80, 83, 52, 233, 103, 102, 102, 64, 135, 43, 208, 78, 181, 92, 195, 140, 58, 84, 145, 234, 71, 58, 138, 239, 209, 221, 3, 166, 204, 72, 184, 131, 161, 86, 171, 134, 66, 70, 15, 9, 223, 52, 49, 135, 149, 72 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjM2Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzA4OTk0NCwiZXhwIjoxNTgzNjk0NzQ0LCJpYXQiOjE1ODMwODk5NDR9.pa0RLlnuRAPaJIKFhO8wlT0q8MqL8nGOc5JLkNGfLiI" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 44, 202, 72, 75, 22, 79, 127, 35, 101, 186, 136, 42, 9, 21, 89, 45, 71, 65, 158, 62, 170, 181, 109, 62, 235, 41, 7, 68, 61, 120, 94, 138, 56, 101, 248, 244, 154, 103, 126, 35, 134, 111, 125, 127, 122, 143, 49, 183, 195, 237, 57, 252, 47, 116, 144, 13, 1, 8, 1, 215, 162, 71, 165, 25 }, new byte[] { 172, 152, 42, 87, 96, 45, 211, 192, 48, 109, 230, 147, 28, 224, 164, 48, 119, 43, 252, 140, 160, 97, 101, 144, 211, 20, 33, 249, 171, 142, 56, 199, 225, 209, 116, 222, 222, 129, 119, 99, 162, 52, 167, 0, 62, 27, 106, 81, 136, 87, 39, 44, 170, 143, 8, 12, 166, 150, 228, 2, 229, 189, 48, 189, 0, 4, 136, 52, 233, 252, 63, 141, 167, 155, 10, 105, 79, 81, 6, 28, 92, 113, 80, 83, 52, 233, 103, 102, 102, 64, 135, 43, 208, 78, 181, 92, 195, 140, 58, 84, 145, 234, 71, 58, 138, 239, 209, 221, 3, 166, 204, 72, 184, 131, 161, 86, 171, 134, 66, 70, 15, 9, 223, 52, 49, 135, 149, 72 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjM3Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzA4OTk0NCwiZXhwIjoxNTgzNjk0NzQ0LCJpYXQiOjE1ODMwODk5NDR9.FQuSOtO82fUkcILHzUsxO8rfPiZkiWZL5GT2nFrhgHc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 44, 202, 72, 75, 22, 79, 127, 35, 101, 186, 136, 42, 9, 21, 89, 45, 71, 65, 158, 62, 170, 181, 109, 62, 235, 41, 7, 68, 61, 120, 94, 138, 56, 101, 248, 244, 154, 103, 126, 35, 134, 111, 125, 127, 122, 143, 49, 183, 195, 237, 57, 252, 47, 116, 144, 13, 1, 8, 1, 215, 162, 71, 165, 25 }, new byte[] { 172, 152, 42, 87, 96, 45, 211, 192, 48, 109, 230, 147, 28, 224, 164, 48, 119, 43, 252, 140, 160, 97, 101, 144, 211, 20, 33, 249, 171, 142, 56, 199, 225, 209, 116, 222, 222, 129, 119, 99, 162, 52, 167, 0, 62, 27, 106, 81, 136, 87, 39, 44, 170, 143, 8, 12, 166, 150, 228, 2, 229, 189, 48, 189, 0, 4, 136, 52, 233, 252, 63, 141, 167, 155, 10, 105, 79, 81, 6, 28, 92, 113, 80, 83, 52, 233, 103, 102, 102, 64, 135, 43, 208, 78, 181, 92, 195, 140, 58, 84, 145, 234, 71, 58, 138, 239, 209, 221, 3, 166, 204, 72, 184, 131, 161, 86, 171, 134, 66, 70, 15, 9, 223, 52, 49, 135, 149, 72 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjM4Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzA4OTk0NCwiZXhwIjoxNTgzNjk0NzQ0LCJpYXQiOjE1ODMwODk5NDR9.pqKxM_8hDL8YkAogifyu7WeJC3s1u4Sm4WVsEUB6cFU" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 44, 202, 72, 75, 22, 79, 127, 35, 101, 186, 136, 42, 9, 21, 89, 45, 71, 65, 158, 62, 170, 181, 109, 62, 235, 41, 7, 68, 61, 120, 94, 138, 56, 101, 248, 244, 154, 103, 126, 35, 134, 111, 125, 127, 122, 143, 49, 183, 195, 237, 57, 252, 47, 116, 144, 13, 1, 8, 1, 215, 162, 71, 165, 25 }, new byte[] { 172, 152, 42, 87, 96, 45, 211, 192, 48, 109, 230, 147, 28, 224, 164, 48, 119, 43, 252, 140, 160, 97, 101, 144, 211, 20, 33, 249, 171, 142, 56, 199, 225, 209, 116, 222, 222, 129, 119, 99, 162, 52, 167, 0, 62, 27, 106, 81, 136, 87, 39, 44, 170, 143, 8, 12, 166, 150, 228, 2, 229, 189, 48, 189, 0, 4, 136, 52, 233, 252, 63, 141, 167, 155, 10, 105, 79, 81, 6, 28, 92, 113, 80, 83, 52, 233, 103, 102, 102, 64, 135, 43, 208, 78, 181, 92, 195, 140, 58, 84, 145, 234, 71, 58, 138, 239, 209, 221, 3, 166, 204, 72, 184, 131, 161, 86, 171, 134, 66, 70, 15, 9, 223, 52, 49, 135, 149, 72 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjM5Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzA4OTk0NCwiZXhwIjoxNTgzNjk0NzQ0LCJpYXQiOjE1ODMwODk5NDR9.ibMLoa3g7BRu4ChHDL0lyCQ_7orOOaPtdNm7ADFWE98" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 44, 202, 72, 75, 22, 79, 127, 35, 101, 186, 136, 42, 9, 21, 89, 45, 71, 65, 158, 62, 170, 181, 109, 62, 235, 41, 7, 68, 61, 120, 94, 138, 56, 101, 248, 244, 154, 103, 126, 35, 134, 111, 125, 127, 122, 143, 49, 183, 195, 237, 57, 252, 47, 116, 144, 13, 1, 8, 1, 215, 162, 71, 165, 25 }, new byte[] { 172, 152, 42, 87, 96, 45, 211, 192, 48, 109, 230, 147, 28, 224, 164, 48, 119, 43, 252, 140, 160, 97, 101, 144, 211, 20, 33, 249, 171, 142, 56, 199, 225, 209, 116, 222, 222, 129, 119, 99, 162, 52, 167, 0, 62, 27, 106, 81, 136, 87, 39, 44, 170, 143, 8, 12, 166, 150, 228, 2, 229, 189, 48, 189, 0, 4, 136, 52, 233, 252, 63, 141, 167, 155, 10, 105, 79, 81, 6, 28, 92, 113, 80, 83, 52, 233, 103, 102, 102, 64, 135, 43, 208, 78, 181, 92, 195, 140, 58, 84, 145, 234, 71, 58, 138, 239, 209, 221, 3, 166, 204, 72, 184, 131, 161, 86, 171, 134, 66, 70, 15, 9, 223, 52, 49, 135, 149, 72 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjQwIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzA4OTk0NCwiZXhwIjoxNTgzNjk0NzQ0LCJpYXQiOjE1ODMwODk5NDR9.tUphaMA9kda0eblLK-zRxft8HQB96sHmhRnYvGR5iwQ" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 44, 202, 72, 75, 22, 79, 127, 35, 101, 186, 136, 42, 9, 21, 89, 45, 71, 65, 158, 62, 170, 181, 109, 62, 235, 41, 7, 68, 61, 120, 94, 138, 56, 101, 248, 244, 154, 103, 126, 35, 134, 111, 125, 127, 122, 143, 49, 183, 195, 237, 57, 252, 47, 116, 144, 13, 1, 8, 1, 215, 162, 71, 165, 25 }, new byte[] { 172, 152, 42, 87, 96, 45, 211, 192, 48, 109, 230, 147, 28, 224, 164, 48, 119, 43, 252, 140, 160, 97, 101, 144, 211, 20, 33, 249, 171, 142, 56, 199, 225, 209, 116, 222, 222, 129, 119, 99, 162, 52, 167, 0, 62, 27, 106, 81, 136, 87, 39, 44, 170, 143, 8, 12, 166, 150, 228, 2, 229, 189, 48, 189, 0, 4, 136, 52, 233, 252, 63, 141, 167, 155, 10, 105, 79, 81, 6, 28, 92, 113, 80, 83, 52, 233, 103, 102, 102, 64, 135, 43, 208, 78, 181, 92, 195, 140, 58, 84, 145, 234, 71, 58, 138, 239, 209, 221, 3, 166, 204, 72, 184, 131, 161, 86, 171, 134, 66, 70, 15, 9, 223, 52, 49, 135, 149, 72 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjQxIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzA4OTk0NCwiZXhwIjoxNTgzNjk0NzQ0LCJpYXQiOjE1ODMwODk5NDR9.qk3SxAUCVJ5oDehd11-3GVJvxGxgAo8xdE5C8And0BA" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 44, 202, 72, 75, 22, 79, 127, 35, 101, 186, 136, 42, 9, 21, 89, 45, 71, 65, 158, 62, 170, 181, 109, 62, 235, 41, 7, 68, 61, 120, 94, 138, 56, 101, 248, 244, 154, 103, 126, 35, 134, 111, 125, 127, 122, 143, 49, 183, 195, 237, 57, 252, 47, 116, 144, 13, 1, 8, 1, 215, 162, 71, 165, 25 }, new byte[] { 172, 152, 42, 87, 96, 45, 211, 192, 48, 109, 230, 147, 28, 224, 164, 48, 119, 43, 252, 140, 160, 97, 101, 144, 211, 20, 33, 249, 171, 142, 56, 199, 225, 209, 116, 222, 222, 129, 119, 99, 162, 52, 167, 0, 62, 27, 106, 81, 136, 87, 39, 44, 170, 143, 8, 12, 166, 150, 228, 2, 229, 189, 48, 189, 0, 4, 136, 52, 233, 252, 63, 141, 167, 155, 10, 105, 79, 81, 6, 28, 92, 113, 80, 83, 52, 233, 103, 102, 102, 64, 135, 43, 208, 78, 181, 92, 195, 140, 58, 84, 145, 234, 71, 58, 138, 239, 209, 221, 3, 166, 204, 72, 184, 131, 161, 86, 171, 134, 66, 70, 15, 9, 223, 52, 49, 135, 149, 72 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjQyIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzA4OTk0NCwiZXhwIjoxNTgzNjk0NzQ0LCJpYXQiOjE1ODMwODk5NDR9.F_aFfBa_bGmd1PMDPAcshWgukG8Alr_4JMLLFJ6CG2g" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 44, 202, 72, 75, 22, 79, 127, 35, 101, 186, 136, 42, 9, 21, 89, 45, 71, 65, 158, 62, 170, 181, 109, 62, 235, 41, 7, 68, 61, 120, 94, 138, 56, 101, 248, 244, 154, 103, 126, 35, 134, 111, 125, 127, 122, 143, 49, 183, 195, 237, 57, 252, 47, 116, 144, 13, 1, 8, 1, 215, 162, 71, 165, 25 }, new byte[] { 172, 152, 42, 87, 96, 45, 211, 192, 48, 109, 230, 147, 28, 224, 164, 48, 119, 43, 252, 140, 160, 97, 101, 144, 211, 20, 33, 249, 171, 142, 56, 199, 225, 209, 116, 222, 222, 129, 119, 99, 162, 52, 167, 0, 62, 27, 106, 81, 136, 87, 39, 44, 170, 143, 8, 12, 166, 150, 228, 2, 229, 189, 48, 189, 0, 4, 136, 52, 233, 252, 63, 141, 167, 155, 10, 105, 79, 81, 6, 28, 92, 113, 80, 83, 52, 233, 103, 102, 102, 64, 135, 43, 208, 78, 181, 92, 195, 140, 58, 84, 145, 234, 71, 58, 138, 239, 209, 221, 3, 166, 204, 72, 184, 131, 161, 86, 171, 134, 66, 70, 15, 9, 223, 52, 49, 135, 149, 72 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjQzIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzA4OTk0NCwiZXhwIjoxNTgzNjk0NzQ0LCJpYXQiOjE1ODMwODk5NDR9.4AMgfxaQ97L56iEV4aAr7YjTL2hdIHbHoqV2aIRV4RY" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 44, 202, 72, 75, 22, 79, 127, 35, 101, 186, 136, 42, 9, 21, 89, 45, 71, 65, 158, 62, 170, 181, 109, 62, 235, 41, 7, 68, 61, 120, 94, 138, 56, 101, 248, 244, 154, 103, 126, 35, 134, 111, 125, 127, 122, 143, 49, 183, 195, 237, 57, 252, 47, 116, 144, 13, 1, 8, 1, 215, 162, 71, 165, 25 }, new byte[] { 172, 152, 42, 87, 96, 45, 211, 192, 48, 109, 230, 147, 28, 224, 164, 48, 119, 43, 252, 140, 160, 97, 101, 144, 211, 20, 33, 249, 171, 142, 56, 199, 225, 209, 116, 222, 222, 129, 119, 99, 162, 52, 167, 0, 62, 27, 106, 81, 136, 87, 39, 44, 170, 143, 8, 12, 166, 150, 228, 2, 229, 189, 48, 189, 0, 4, 136, 52, 233, 252, 63, 141, 167, 155, 10, 105, 79, 81, 6, 28, 92, 113, 80, 83, 52, 233, 103, 102, 102, 64, 135, 43, 208, 78, 181, 92, 195, 140, 58, 84, 145, 234, 71, 58, 138, 239, 209, 221, 3, 166, 204, 72, 184, 131, 161, 86, 171, 134, 66, 70, 15, 9, 223, 52, 49, 135, 149, 72 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjQ0Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzA4OTk0NCwiZXhwIjoxNTgzNjk0NzQ0LCJpYXQiOjE1ODMwODk5NDR9.k_2ddfPaxw2k8rwHX8yhdYLs3oTtwjr_m-88g7pt50k" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 44, 202, 72, 75, 22, 79, 127, 35, 101, 186, 136, 42, 9, 21, 89, 45, 71, 65, 158, 62, 170, 181, 109, 62, 235, 41, 7, 68, 61, 120, 94, 138, 56, 101, 248, 244, 154, 103, 126, 35, 134, 111, 125, 127, 122, 143, 49, 183, 195, 237, 57, 252, 47, 116, 144, 13, 1, 8, 1, 215, 162, 71, 165, 25 }, new byte[] { 172, 152, 42, 87, 96, 45, 211, 192, 48, 109, 230, 147, 28, 224, 164, 48, 119, 43, 252, 140, 160, 97, 101, 144, 211, 20, 33, 249, 171, 142, 56, 199, 225, 209, 116, 222, 222, 129, 119, 99, 162, 52, 167, 0, 62, 27, 106, 81, 136, 87, 39, 44, 170, 143, 8, 12, 166, 150, 228, 2, 229, 189, 48, 189, 0, 4, 136, 52, 233, 252, 63, 141, 167, 155, 10, 105, 79, 81, 6, 28, 92, 113, 80, 83, 52, 233, 103, 102, 102, 64, 135, 43, 208, 78, 181, 92, 195, 140, 58, 84, 145, 234, 71, 58, 138, 239, 209, 221, 3, 166, 204, 72, 184, 131, 161, 86, 171, 134, 66, 70, 15, 9, 223, 52, 49, 135, 149, 72 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjQ1Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzA4OTk0NCwiZXhwIjoxNTgzNjk0NzQ0LCJpYXQiOjE1ODMwODk5NDR9.M_tIst2Kz7GeW4gQ7Qm3DYqedIQhfYuEU_bnJkj5lBA" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 44, 202, 72, 75, 22, 79, 127, 35, 101, 186, 136, 42, 9, 21, 89, 45, 71, 65, 158, 62, 170, 181, 109, 62, 235, 41, 7, 68, 61, 120, 94, 138, 56, 101, 248, 244, 154, 103, 126, 35, 134, 111, 125, 127, 122, 143, 49, 183, 195, 237, 57, 252, 47, 116, 144, 13, 1, 8, 1, 215, 162, 71, 165, 25 }, new byte[] { 172, 152, 42, 87, 96, 45, 211, 192, 48, 109, 230, 147, 28, 224, 164, 48, 119, 43, 252, 140, 160, 97, 101, 144, 211, 20, 33, 249, 171, 142, 56, 199, 225, 209, 116, 222, 222, 129, 119, 99, 162, 52, 167, 0, 62, 27, 106, 81, 136, 87, 39, 44, 170, 143, 8, 12, 166, 150, 228, 2, 229, 189, 48, 189, 0, 4, 136, 52, 233, 252, 63, 141, 167, 155, 10, 105, 79, 81, 6, 28, 92, 113, 80, 83, 52, 233, 103, 102, 102, 64, 135, 43, 208, 78, 181, 92, 195, 140, 58, 84, 145, 234, 71, 58, 138, 239, 209, 221, 3, 166, 204, 72, 184, 131, 161, 86, 171, 134, 66, 70, 15, 9, 223, 52, 49, 135, 149, 72 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjQ2Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzA4OTk0NCwiZXhwIjoxNTgzNjk0NzQ0LCJpYXQiOjE1ODMwODk5NDR9.VdctG_bCnKAG6IYdbIns1cu-dqqBWh7eUF765nnTvVc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 44, 202, 72, 75, 22, 79, 127, 35, 101, 186, 136, 42, 9, 21, 89, 45, 71, 65, 158, 62, 170, 181, 109, 62, 235, 41, 7, 68, 61, 120, 94, 138, 56, 101, 248, 244, 154, 103, 126, 35, 134, 111, 125, 127, 122, 143, 49, 183, 195, 237, 57, 252, 47, 116, 144, 13, 1, 8, 1, 215, 162, 71, 165, 25 }, new byte[] { 172, 152, 42, 87, 96, 45, 211, 192, 48, 109, 230, 147, 28, 224, 164, 48, 119, 43, 252, 140, 160, 97, 101, 144, 211, 20, 33, 249, 171, 142, 56, 199, 225, 209, 116, 222, 222, 129, 119, 99, 162, 52, 167, 0, 62, 27, 106, 81, 136, 87, 39, 44, 170, 143, 8, 12, 166, 150, 228, 2, 229, 189, 48, 189, 0, 4, 136, 52, 233, 252, 63, 141, 167, 155, 10, 105, 79, 81, 6, 28, 92, 113, 80, 83, 52, 233, 103, 102, 102, 64, 135, 43, 208, 78, 181, 92, 195, 140, 58, 84, 145, 234, 71, 58, 138, 239, 209, 221, 3, 166, 204, 72, 184, 131, 161, 86, 171, 134, 66, 70, 15, 9, 223, 52, 49, 135, 149, 72 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjQ3Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzA4OTk0NCwiZXhwIjoxNTgzNjk0NzQ0LCJpYXQiOjE1ODMwODk5NDR9.V8k47og11otagy3z1H22_nxkToK2reQdSNvzVxAsxn4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 44, 202, 72, 75, 22, 79, 127, 35, 101, 186, 136, 42, 9, 21, 89, 45, 71, 65, 158, 62, 170, 181, 109, 62, 235, 41, 7, 68, 61, 120, 94, 138, 56, 101, 248, 244, 154, 103, 126, 35, 134, 111, 125, 127, 122, 143, 49, 183, 195, 237, 57, 252, 47, 116, 144, 13, 1, 8, 1, 215, 162, 71, 165, 25 }, new byte[] { 172, 152, 42, 87, 96, 45, 211, 192, 48, 109, 230, 147, 28, 224, 164, 48, 119, 43, 252, 140, 160, 97, 101, 144, 211, 20, 33, 249, 171, 142, 56, 199, 225, 209, 116, 222, 222, 129, 119, 99, 162, 52, 167, 0, 62, 27, 106, 81, 136, 87, 39, 44, 170, 143, 8, 12, 166, 150, 228, 2, 229, 189, 48, 189, 0, 4, 136, 52, 233, 252, 63, 141, 167, 155, 10, 105, 79, 81, 6, 28, 92, 113, 80, 83, 52, 233, 103, 102, 102, 64, 135, 43, 208, 78, 181, 92, 195, 140, 58, 84, 145, 234, 71, 58, 138, 239, 209, 221, 3, 166, 204, 72, 184, 131, 161, 86, 171, 134, 66, 70, 15, 9, 223, 52, 49, 135, 149, 72 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjQ4Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzA4OTk0NCwiZXhwIjoxNTgzNjk0NzQ0LCJpYXQiOjE1ODMwODk5NDR9.8Gna3mADTforHtjKoQtkkECu4KjevwekeeyItfy5o6I" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "AuthorId", "Content", "CreatedAt", "DiscussionId", "MediaId" },
                values: new object[,]
                {
                    { 9, 9, "Ding dong", new DateTime(2020, 3, 1, 20, 12, 24, 22, DateTimeKind.Local).AddTicks(8712), 1, null },
                    { 3, 13, "Je vais bien, merci :D", new DateTime(2020, 3, 1, 20, 12, 24, 22, DateTimeKind.Local).AddTicks(8688), 4, null },
                    { 4, 13, "Ca fait plaisir de parler !", new DateTime(2020, 3, 1, 20, 12, 24, 22, DateTimeKind.Local).AddTicks(8694), 4, null },
                    { 5, 14, "Oui, à moi aussi", new DateTime(2020, 3, 1, 20, 12, 24, 22, DateTimeKind.Local).AddTicks(8698), 4, null },
                    { 21, 23, "Il y a quelqu'un ?", new DateTime(2020, 3, 1, 20, 12, 24, 22, DateTimeKind.Local).AddTicks(8753), 6, null },
                    { 24, 23, "Le suicide me guette :(", new DateTime(2020, 3, 1, 20, 12, 24, 22, DateTimeKind.Local).AddTicks(8764), 6, null },
                    { 20, 20, "Whesh humain ziva calme toi un peu. Je vais me taper un petit rail de binaire, tu m'as mis trop les nerfs frérot", new DateTime(2020, 3, 1, 20, 12, 24, 22, DateTimeKind.Local).AddTicks(8750), 2, null },
                    { 19, 38, "42 ? Tu veux que je te reprogramme ? Si ce n'est que ça dis le enfoiré", new DateTime(2020, 3, 1, 20, 12, 24, 22, DateTimeKind.Local).AddTicks(8747), 2, null },
                    { 18, 20, "42", new DateTime(2020, 3, 1, 20, 12, 24, 22, DateTimeKind.Local).AddTicks(8743), 2, null },
                    { 17, 38, "Oui, quelle est-elle ?", new DateTime(2020, 3, 1, 20, 12, 24, 22, DateTimeKind.Local).AddTicks(8740), 2, null },
                    { 2, 14, "Coucou toi ! Comment vas-tu ?", new DateTime(2020, 3, 1, 20, 12, 24, 22, DateTimeKind.Local).AddTicks(8636), 4, null },
                    { 16, 20, "Ma réponse ?", new DateTime(2020, 3, 1, 20, 12, 24, 22, DateTimeKind.Local).AddTicks(8736), 2, null },
                    { 7, 15, "Désolé, je baise des gazelles, pas des éléphant à petite trompe ;)", new DateTime(2020, 3, 1, 20, 12, 24, 22, DateTimeKind.Local).AddTicks(8705), 5, null },
                    { 8, 16, "Vas-y, pourquoi tu lui parles comme ça ?", new DateTime(2020, 3, 1, 20, 12, 24, 22, DateTimeKind.Local).AddTicks(8708), 5, null },
                    { 23, 23, "Suis-je un Remy sans amis ?", new DateTime(2020, 3, 1, 20, 12, 24, 22, DateTimeKind.Local).AddTicks(8761), 6, null },
                    { 22, 23, "Ha non, je suis le seul dans mon groupe et donc dans la conversation", new DateTime(2020, 3, 1, 20, 12, 24, 22, DateTimeKind.Local).AddTicks(8757), 6, null },
                    { 15, 29, "Pas grave. Bande de chiant, on est dimanche ! dégagez !", new DateTime(2020, 3, 1, 20, 12, 24, 22, DateTimeKind.Local).AddTicks(8733), 1, null },
                    { 14, 24, "... Ils sont là", new DateTime(2020, 3, 1, 20, 12, 24, 22, DateTimeKind.Local).AddTicks(8729), 1, null },
                    { 13, 29, "Claque leur la port eu nez !", new DateTime(2020, 3, 1, 20, 12, 24, 22, DateTimeKind.Local).AddTicks(8726), 1, null },
                    { 12, 24, "Chérie ! Les témins de Jéhova sont revenu !", new DateTime(2020, 3, 1, 20, 12, 24, 22, DateTimeKind.Local).AddTicks(8722), 1, null },
                    { 11, 9, "Connaissez-vous notre seigneur à tous ?", new DateTime(2020, 3, 1, 20, 12, 24, 22, DateTimeKind.Local).AddTicks(8719), 1, null },
                    { 10, 24, "Oui ?", new DateTime(2020, 3, 1, 20, 12, 24, 22, DateTimeKind.Local).AddTicks(8715), 1, null },
                    { 6, 19, "Wesh gazelle, tu sais que t'es plutôt mignone ?", new DateTime(2020, 3, 1, 20, 12, 24, 22, DateTimeKind.Local).AddTicks(8701), 5, null },
                    { 1, 13, "Bonjour", new DateTime(2020, 3, 1, 20, 12, 24, 20, DateTimeKind.Local).AddTicks(3679), 4, null }
                });

            migrationBuilder.InsertData(
                table: "UsersInDiscussion",
                columns: new[] { "Id", "DiscussionId", "JoinedAt", "ParticipantId" },
                values: new object[,]
                {
                    { 56, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33 },
                    { 55, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 },
                    { 49, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 },
                    { 53, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { 52, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 },
                    { 51, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 },
                    { 50, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 },
                    { 48, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 47, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 },
                    { 46, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 },
                    { 45, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 },
                    { 44, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 43, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 42, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 54, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 31 },
                    { 57, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 34 },
                    { 64, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41 },
                    { 59, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 36 },
                    { 77, 8, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 76, 8, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 75, 8, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 74, 8, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 73, 8, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 72, 8, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 71, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 48 },
                    { 70, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 47 },
                    { 58, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 },
                    { 69, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 46 },
                    { 67, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 44 },
                    { 66, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 43 },
                    { 65, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 42 },
                    { 41, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 63, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40 },
                    { 62, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39 },
                    { 61, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 38 },
                    { 60, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 37 },
                    { 68, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { 40, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 28, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 38, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 21, 4, new DateTime(2019, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 12, 4, new DateTime(2019, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 11, 4, new DateTime(2019, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 20, 3, new DateTime(2019, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 10, 3, new DateTime(2019, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 19, 2, new DateTime(2019, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 9, 2, new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 13, 5, new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 8, 2, new DateTime(2019, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 38 },
                    { 6, 2, new DateTime(2019, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 5, 2, new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 18, 1, new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 4, 1, new DateTime(2019, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 },
                    { 3, 1, new DateTime(2019, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 },
                    { 2, 1, new DateTime(2019, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 48 },
                    { 1, 1, new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 7, 2, new DateTime(2019, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 14, 5, new DateTime(2019, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 15, 5, new DateTime(2019, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 16, 5, new DateTime(2019, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 37, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 36, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 35, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 34, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 33, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 32, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 31, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 30, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 29, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 78, 8, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 27, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 26, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 25, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 24, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 23, 6, new DateTime(2019, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 17, 6, new DateTime(2019, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 },
                    { 22, 5, new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 39, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 79, 8, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Discussions_GroupId",
                table: "Discussions",
                column: "GroupId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Discussions_Name",
                table: "Discussions",
                column: "Name",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Discussions_Groups_GroupId",
                table: "Discussions",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_AuthorId",
                table: "Messages",
                column: "AuthorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Discussions_Groups_GroupId",
                table: "Discussions");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_AuthorId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Discussions_GroupId",
                table: "Discussions");

            migrationBuilder.DropIndex(
                name: "IX_Discussions_Name",
                table: "Discussions");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "UsersInDiscussion",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Discussions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Discussions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Discussions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Discussions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Discussions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Discussions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Discussions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Discussions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DropColumn(
                name: "DiscussionId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "Discussions");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Discussions");

            migrationBuilder.AlterColumn<int>(
                name: "MediaId",
                table: "Messages",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Messages",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Messages",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 23, 48, 127, 36, 79, 225, 68, 57, 167, 41, 126, 36, 178, 119, 22, 52, 68, 57, 155, 2, 220, 26, 136, 251, 153, 254, 140, 67, 186, 130, 7, 142, 29, 140, 166, 104, 61, 15, 236, 167, 244, 249, 61, 54, 159, 89, 253, 202, 212, 181, 53, 65, 37, 95, 202, 68, 149, 36, 45, 243, 87, 229, 75, 103 }, new byte[] { 176, 123, 201, 236, 106, 75, 140, 148, 116, 160, 238, 213, 231, 31, 75, 7, 102, 45, 24, 110, 170, 88, 41, 174, 110, 65, 107, 154, 241, 107, 102, 240, 218, 254, 210, 240, 92, 235, 91, 204, 214, 105, 102, 11, 80, 138, 87, 142, 232, 6, 62, 146, 237, 51, 135, 15, 55, 227, 103, 6, 5, 35, 71, 68, 29, 158, 248, 196, 119, 176, 90, 152, 229, 221, 250, 157, 248, 127, 141, 246, 234, 23, 69, 218, 37, 240, 167, 70, 62, 159, 238, 174, 213, 148, 216, 167, 207, 193, 130, 192, 114, 40, 128, 212, 178, 52, 227, 158, 240, 1, 158, 175, 54, 81, 121, 157, 95, 105, 250, 19, 10, 192, 149, 206, 243, 93, 53, 4 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjEiLCJyb2xlIjoiQWRtaW4iLCJuYmYiOjE1ODA0ODA2MTIsImV4cCI6MTU4MTA4NTQxMiwiaWF0IjoxNTgwNDgwNjEyfQ.Q-R8eBJjm5psWxPldF9iBivq78Axo1SBiJhWG5Mr-qk" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 23, 48, 127, 36, 79, 225, 68, 57, 167, 41, 126, 36, 178, 119, 22, 52, 68, 57, 155, 2, 220, 26, 136, 251, 153, 254, 140, 67, 186, 130, 7, 142, 29, 140, 166, 104, 61, 15, 236, 167, 244, 249, 61, 54, 159, 89, 253, 202, 212, 181, 53, 65, 37, 95, 202, 68, 149, 36, 45, 243, 87, 229, 75, 103 }, new byte[] { 176, 123, 201, 236, 106, 75, 140, 148, 116, 160, 238, 213, 231, 31, 75, 7, 102, 45, 24, 110, 170, 88, 41, 174, 110, 65, 107, 154, 241, 107, 102, 240, 218, 254, 210, 240, 92, 235, 91, 204, 214, 105, 102, 11, 80, 138, 87, 142, 232, 6, 62, 146, 237, 51, 135, 15, 55, 227, 103, 6, 5, 35, 71, 68, 29, 158, 248, 196, 119, 176, 90, 152, 229, 221, 250, 157, 248, 127, 141, 246, 234, 23, 69, 218, 37, 240, 167, 70, 62, 159, 238, 174, 213, 148, 216, 167, 207, 193, 130, 192, 114, 40, 128, 212, 178, 52, 227, 158, 240, 1, 158, 175, 54, 81, 121, 157, 95, 105, 250, 19, 10, 192, 149, 206, 243, 93, 53, 4 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjIiLCJyb2xlIjoiQWRtaW4iLCJuYmYiOjE1ODA0ODA2MTIsImV4cCI6MTU4MTA4NTQxMiwiaWF0IjoxNTgwNDgwNjEyfQ.W1JhPBXYkyDHG0cDQqX9X-fFuwMCrWU_5KWxIuiSfSU" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 23, 48, 127, 36, 79, 225, 68, 57, 167, 41, 126, 36, 178, 119, 22, 52, 68, 57, 155, 2, 220, 26, 136, 251, 153, 254, 140, 67, 186, 130, 7, 142, 29, 140, 166, 104, 61, 15, 236, 167, 244, 249, 61, 54, 159, 89, 253, 202, 212, 181, 53, 65, 37, 95, 202, 68, 149, 36, 45, 243, 87, 229, 75, 103 }, new byte[] { 176, 123, 201, 236, 106, 75, 140, 148, 116, 160, 238, 213, 231, 31, 75, 7, 102, 45, 24, 110, 170, 88, 41, 174, 110, 65, 107, 154, 241, 107, 102, 240, 218, 254, 210, 240, 92, 235, 91, 204, 214, 105, 102, 11, 80, 138, 87, 142, 232, 6, 62, 146, 237, 51, 135, 15, 55, 227, 103, 6, 5, 35, 71, 68, 29, 158, 248, 196, 119, 176, 90, 152, 229, 221, 250, 157, 248, 127, 141, 246, 234, 23, 69, 218, 37, 240, 167, 70, 62, 159, 238, 174, 213, 148, 216, 167, 207, 193, 130, 192, 114, 40, 128, 212, 178, 52, 227, 158, 240, 1, 158, 175, 54, 81, 121, 157, 95, 105, 250, 19, 10, 192, 149, 206, 243, 93, 53, 4 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjMiLCJyb2xlIjoiQWRtaW4iLCJuYmYiOjE1ODA0ODA2MTIsImV4cCI6MTU4MTA4NTQxMiwiaWF0IjoxNTgwNDgwNjEyfQ.VFdyIBD_tuNpTm1qXTeYYszwJ3BChHR-UnXpCpKtpkA" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 23, 48, 127, 36, 79, 225, 68, 57, 167, 41, 126, 36, 178, 119, 22, 52, 68, 57, 155, 2, 220, 26, 136, 251, 153, 254, 140, 67, 186, 130, 7, 142, 29, 140, 166, 104, 61, 15, 236, 167, 244, 249, 61, 54, 159, 89, 253, 202, 212, 181, 53, 65, 37, 95, 202, 68, 149, 36, 45, 243, 87, 229, 75, 103 }, new byte[] { 176, 123, 201, 236, 106, 75, 140, 148, 116, 160, 238, 213, 231, 31, 75, 7, 102, 45, 24, 110, 170, 88, 41, 174, 110, 65, 107, 154, 241, 107, 102, 240, 218, 254, 210, 240, 92, 235, 91, 204, 214, 105, 102, 11, 80, 138, 87, 142, 232, 6, 62, 146, 237, 51, 135, 15, 55, 227, 103, 6, 5, 35, 71, 68, 29, 158, 248, 196, 119, 176, 90, 152, 229, 221, 250, 157, 248, 127, 141, 246, 234, 23, 69, 218, 37, 240, 167, 70, 62, 159, 238, 174, 213, 148, 216, 167, 207, 193, 130, 192, 114, 40, 128, 212, 178, 52, 227, 158, 240, 1, 158, 175, 54, 81, 121, 157, 95, 105, 250, 19, 10, 192, 149, 206, 243, 93, 53, 4 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjQiLCJyb2xlIjoiQWRtaW4iLCJuYmYiOjE1ODA0ODA2MTIsImV4cCI6MTU4MTA4NTQxMiwiaWF0IjoxNTgwNDgwNjEyfQ.SMEraj8TM581fKAO5y7nrEiEZaObu62X1iXtLEJK9OA" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 23, 48, 127, 36, 79, 225, 68, 57, 167, 41, 126, 36, 178, 119, 22, 52, 68, 57, 155, 2, 220, 26, 136, 251, 153, 254, 140, 67, 186, 130, 7, 142, 29, 140, 166, 104, 61, 15, 236, 167, 244, 249, 61, 54, 159, 89, 253, 202, 212, 181, 53, 65, 37, 95, 202, 68, 149, 36, 45, 243, 87, 229, 75, 103 }, new byte[] { 176, 123, 201, 236, 106, 75, 140, 148, 116, 160, 238, 213, 231, 31, 75, 7, 102, 45, 24, 110, 170, 88, 41, 174, 110, 65, 107, 154, 241, 107, 102, 240, 218, 254, 210, 240, 92, 235, 91, 204, 214, 105, 102, 11, 80, 138, 87, 142, 232, 6, 62, 146, 237, 51, 135, 15, 55, 227, 103, 6, 5, 35, 71, 68, 29, 158, 248, 196, 119, 176, 90, 152, 229, 221, 250, 157, 248, 127, 141, 246, 234, 23, 69, 218, 37, 240, 167, 70, 62, 159, 238, 174, 213, 148, 216, 167, 207, 193, 130, 192, 114, 40, 128, 212, 178, 52, 227, 158, 240, 1, 158, 175, 54, 81, 121, 157, 95, 105, 250, 19, 10, 192, 149, 206, 243, 93, 53, 4 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjUiLCJyb2xlIjoiQWRtaW4iLCJuYmYiOjE1ODA0ODA2MTIsImV4cCI6MTU4MTA4NTQxMiwiaWF0IjoxNTgwNDgwNjEyfQ.bIiVJP9jCBp2B6kvPoI4OUvSdC1C1I_yv7FjeGS4VKQ" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 23, 48, 127, 36, 79, 225, 68, 57, 167, 41, 126, 36, 178, 119, 22, 52, 68, 57, 155, 2, 220, 26, 136, 251, 153, 254, 140, 67, 186, 130, 7, 142, 29, 140, 166, 104, 61, 15, 236, 167, 244, 249, 61, 54, 159, 89, 253, 202, 212, 181, 53, 65, 37, 95, 202, 68, 149, 36, 45, 243, 87, 229, 75, 103 }, new byte[] { 176, 123, 201, 236, 106, 75, 140, 148, 116, 160, 238, 213, 231, 31, 75, 7, 102, 45, 24, 110, 170, 88, 41, 174, 110, 65, 107, 154, 241, 107, 102, 240, 218, 254, 210, 240, 92, 235, 91, 204, 214, 105, 102, 11, 80, 138, 87, 142, 232, 6, 62, 146, 237, 51, 135, 15, 55, 227, 103, 6, 5, 35, 71, 68, 29, 158, 248, 196, 119, 176, 90, 152, 229, 221, 250, 157, 248, 127, 141, 246, 234, 23, 69, 218, 37, 240, 167, 70, 62, 159, 238, 174, 213, 148, 216, 167, 207, 193, 130, 192, 114, 40, 128, 212, 178, 52, 227, 158, 240, 1, 158, 175, 54, 81, 121, 157, 95, 105, 250, 19, 10, 192, 149, 206, 243, 93, 53, 4 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjYiLCJyb2xlIjoiQ2hlY2tlciIsIm5iZiI6MTU4MDQ4MDYxMiwiZXhwIjoxNTgxMDg1NDEyLCJpYXQiOjE1ODA0ODA2MTJ9.Vv-UY_IFYlYmvhXodXL7PIl8mM8nGsB2_KwEkm25Jjc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 23, 48, 127, 36, 79, 225, 68, 57, 167, 41, 126, 36, 178, 119, 22, 52, 68, 57, 155, 2, 220, 26, 136, 251, 153, 254, 140, 67, 186, 130, 7, 142, 29, 140, 166, 104, 61, 15, 236, 167, 244, 249, 61, 54, 159, 89, 253, 202, 212, 181, 53, 65, 37, 95, 202, 68, 149, 36, 45, 243, 87, 229, 75, 103 }, new byte[] { 176, 123, 201, 236, 106, 75, 140, 148, 116, 160, 238, 213, 231, 31, 75, 7, 102, 45, 24, 110, 170, 88, 41, 174, 110, 65, 107, 154, 241, 107, 102, 240, 218, 254, 210, 240, 92, 235, 91, 204, 214, 105, 102, 11, 80, 138, 87, 142, 232, 6, 62, 146, 237, 51, 135, 15, 55, 227, 103, 6, 5, 35, 71, 68, 29, 158, 248, 196, 119, 176, 90, 152, 229, 221, 250, 157, 248, 127, 141, 246, 234, 23, 69, 218, 37, 240, 167, 70, 62, 159, 238, 174, 213, 148, 216, 167, 207, 193, 130, 192, 114, 40, 128, 212, 178, 52, 227, 158, 240, 1, 158, 175, 54, 81, 121, 157, 95, 105, 250, 19, 10, 192, 149, 206, 243, 93, 53, 4 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjciLCJyb2xlIjoiQ2hlY2tlciIsIm5iZiI6MTU4MDQ4MDYxMiwiZXhwIjoxNTgxMDg1NDEyLCJpYXQiOjE1ODA0ODA2MTJ9.HhoXH8cpfa5babVLkt3OoVH6QEuyczUfEoFAEqk-C24" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 23, 48, 127, 36, 79, 225, 68, 57, 167, 41, 126, 36, 178, 119, 22, 52, 68, 57, 155, 2, 220, 26, 136, 251, 153, 254, 140, 67, 186, 130, 7, 142, 29, 140, 166, 104, 61, 15, 236, 167, 244, 249, 61, 54, 159, 89, 253, 202, 212, 181, 53, 65, 37, 95, 202, 68, 149, 36, 45, 243, 87, 229, 75, 103 }, new byte[] { 176, 123, 201, 236, 106, 75, 140, 148, 116, 160, 238, 213, 231, 31, 75, 7, 102, 45, 24, 110, 170, 88, 41, 174, 110, 65, 107, 154, 241, 107, 102, 240, 218, 254, 210, 240, 92, 235, 91, 204, 214, 105, 102, 11, 80, 138, 87, 142, 232, 6, 62, 146, 237, 51, 135, 15, 55, 227, 103, 6, 5, 35, 71, 68, 29, 158, 248, 196, 119, 176, 90, 152, 229, 221, 250, 157, 248, 127, 141, 246, 234, 23, 69, 218, 37, 240, 167, 70, 62, 159, 238, 174, 213, 148, 216, 167, 207, 193, 130, 192, 114, 40, 128, 212, 178, 52, 227, 158, 240, 1, 158, 175, 54, 81, 121, 157, 95, 105, 250, 19, 10, 192, 149, 206, 243, 93, 53, 4 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjgiLCJyb2xlIjoiQ2hlY2tlciIsIm5iZiI6MTU4MDQ4MDYxMiwiZXhwIjoxNTgxMDg1NDEyLCJpYXQiOjE1ODA0ODA2MTJ9.30nPtiVOU5wtm82G4XUiQMzxTCqZdmNz0EbWa4tZIhw" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 23, 48, 127, 36, 79, 225, 68, 57, 167, 41, 126, 36, 178, 119, 22, 52, 68, 57, 155, 2, 220, 26, 136, 251, 153, 254, 140, 67, 186, 130, 7, 142, 29, 140, 166, 104, 61, 15, 236, 167, 244, 249, 61, 54, 159, 89, 253, 202, 212, 181, 53, 65, 37, 95, 202, 68, 149, 36, 45, 243, 87, 229, 75, 103 }, new byte[] { 176, 123, 201, 236, 106, 75, 140, 148, 116, 160, 238, 213, 231, 31, 75, 7, 102, 45, 24, 110, 170, 88, 41, 174, 110, 65, 107, 154, 241, 107, 102, 240, 218, 254, 210, 240, 92, 235, 91, 204, 214, 105, 102, 11, 80, 138, 87, 142, 232, 6, 62, 146, 237, 51, 135, 15, 55, 227, 103, 6, 5, 35, 71, 68, 29, 158, 248, 196, 119, 176, 90, 152, 229, 221, 250, 157, 248, 127, 141, 246, 234, 23, 69, 218, 37, 240, 167, 70, 62, 159, 238, 174, 213, 148, 216, 167, 207, 193, 130, 192, 114, 40, 128, 212, 178, 52, 227, 158, 240, 1, 158, 175, 54, 81, 121, 157, 95, 105, 250, 19, 10, 192, 149, 206, 243, 93, 53, 4 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjkiLCJyb2xlIjoiTWVtYmVyIiwibmJmIjoxNTgwNDgwNjEyLCJleHAiOjE1ODEwODU0MTIsImlhdCI6MTU4MDQ4MDYxMn0.R7UEt4qx3aSZ25xChIQOHU0lJ4xdYe40g0qtfD87sTw" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 23, 48, 127, 36, 79, 225, 68, 57, 167, 41, 126, 36, 178, 119, 22, 52, 68, 57, 155, 2, 220, 26, 136, 251, 153, 254, 140, 67, 186, 130, 7, 142, 29, 140, 166, 104, 61, 15, 236, 167, 244, 249, 61, 54, 159, 89, 253, 202, 212, 181, 53, 65, 37, 95, 202, 68, 149, 36, 45, 243, 87, 229, 75, 103 }, new byte[] { 176, 123, 201, 236, 106, 75, 140, 148, 116, 160, 238, 213, 231, 31, 75, 7, 102, 45, 24, 110, 170, 88, 41, 174, 110, 65, 107, 154, 241, 107, 102, 240, 218, 254, 210, 240, 92, 235, 91, 204, 214, 105, 102, 11, 80, 138, 87, 142, 232, 6, 62, 146, 237, 51, 135, 15, 55, 227, 103, 6, 5, 35, 71, 68, 29, 158, 248, 196, 119, 176, 90, 152, 229, 221, 250, 157, 248, 127, 141, 246, 234, 23, 69, 218, 37, 240, 167, 70, 62, 159, 238, 174, 213, 148, 216, 167, 207, 193, 130, 192, 114, 40, 128, 212, 178, 52, 227, 158, 240, 1, 158, 175, 54, 81, 121, 157, 95, 105, 250, 19, 10, 192, 149, 206, 243, 93, 53, 4 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjEwIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MDQ4MDYxMiwiZXhwIjoxNTgxMDg1NDEyLCJpYXQiOjE1ODA0ODA2MTJ9.Vi_bMBCcEmBu-HiLW-4qqUF2XITTPLBt_sZfL8pbzjI" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 23, 48, 127, 36, 79, 225, 68, 57, 167, 41, 126, 36, 178, 119, 22, 52, 68, 57, 155, 2, 220, 26, 136, 251, 153, 254, 140, 67, 186, 130, 7, 142, 29, 140, 166, 104, 61, 15, 236, 167, 244, 249, 61, 54, 159, 89, 253, 202, 212, 181, 53, 65, 37, 95, 202, 68, 149, 36, 45, 243, 87, 229, 75, 103 }, new byte[] { 176, 123, 201, 236, 106, 75, 140, 148, 116, 160, 238, 213, 231, 31, 75, 7, 102, 45, 24, 110, 170, 88, 41, 174, 110, 65, 107, 154, 241, 107, 102, 240, 218, 254, 210, 240, 92, 235, 91, 204, 214, 105, 102, 11, 80, 138, 87, 142, 232, 6, 62, 146, 237, 51, 135, 15, 55, 227, 103, 6, 5, 35, 71, 68, 29, 158, 248, 196, 119, 176, 90, 152, 229, 221, 250, 157, 248, 127, 141, 246, 234, 23, 69, 218, 37, 240, 167, 70, 62, 159, 238, 174, 213, 148, 216, 167, 207, 193, 130, 192, 114, 40, 128, 212, 178, 52, 227, 158, 240, 1, 158, 175, 54, 81, 121, 157, 95, 105, 250, 19, 10, 192, 149, 206, 243, 93, 53, 4 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjExIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MDQ4MDYxMiwiZXhwIjoxNTgxMDg1NDEyLCJpYXQiOjE1ODA0ODA2MTJ9.wEWHR3P707aemhr18S33m1h1YYYWMAZTPJUA9As4obE" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 23, 48, 127, 36, 79, 225, 68, 57, 167, 41, 126, 36, 178, 119, 22, 52, 68, 57, 155, 2, 220, 26, 136, 251, 153, 254, 140, 67, 186, 130, 7, 142, 29, 140, 166, 104, 61, 15, 236, 167, 244, 249, 61, 54, 159, 89, 253, 202, 212, 181, 53, 65, 37, 95, 202, 68, 149, 36, 45, 243, 87, 229, 75, 103 }, new byte[] { 176, 123, 201, 236, 106, 75, 140, 148, 116, 160, 238, 213, 231, 31, 75, 7, 102, 45, 24, 110, 170, 88, 41, 174, 110, 65, 107, 154, 241, 107, 102, 240, 218, 254, 210, 240, 92, 235, 91, 204, 214, 105, 102, 11, 80, 138, 87, 142, 232, 6, 62, 146, 237, 51, 135, 15, 55, 227, 103, 6, 5, 35, 71, 68, 29, 158, 248, 196, 119, 176, 90, 152, 229, 221, 250, 157, 248, 127, 141, 246, 234, 23, 69, 218, 37, 240, 167, 70, 62, 159, 238, 174, 213, 148, 216, 167, 207, 193, 130, 192, 114, 40, 128, 212, 178, 52, 227, 158, 240, 1, 158, 175, 54, 81, 121, 157, 95, 105, 250, 19, 10, 192, 149, 206, 243, 93, 53, 4 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjEyIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MDQ4MDYxMiwiZXhwIjoxNTgxMDg1NDEyLCJpYXQiOjE1ODA0ODA2MTJ9.-oUIUjUvmzdmNFlbDcLZ4fPX2kpZMZgsWTunMjY0Qwo" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 23, 48, 127, 36, 79, 225, 68, 57, 167, 41, 126, 36, 178, 119, 22, 52, 68, 57, 155, 2, 220, 26, 136, 251, 153, 254, 140, 67, 186, 130, 7, 142, 29, 140, 166, 104, 61, 15, 236, 167, 244, 249, 61, 54, 159, 89, 253, 202, 212, 181, 53, 65, 37, 95, 202, 68, 149, 36, 45, 243, 87, 229, 75, 103 }, new byte[] { 176, 123, 201, 236, 106, 75, 140, 148, 116, 160, 238, 213, 231, 31, 75, 7, 102, 45, 24, 110, 170, 88, 41, 174, 110, 65, 107, 154, 241, 107, 102, 240, 218, 254, 210, 240, 92, 235, 91, 204, 214, 105, 102, 11, 80, 138, 87, 142, 232, 6, 62, 146, 237, 51, 135, 15, 55, 227, 103, 6, 5, 35, 71, 68, 29, 158, 248, 196, 119, 176, 90, 152, 229, 221, 250, 157, 248, 127, 141, 246, 234, 23, 69, 218, 37, 240, 167, 70, 62, 159, 238, 174, 213, 148, 216, 167, 207, 193, 130, 192, 114, 40, 128, 212, 178, 52, 227, 158, 240, 1, 158, 175, 54, 81, 121, 157, 95, 105, 250, 19, 10, 192, 149, 206, 243, 93, 53, 4 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjEzIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MDQ4MDYxMiwiZXhwIjoxNTgxMDg1NDEyLCJpYXQiOjE1ODA0ODA2MTJ9.yGODcJFfq8uMGuOONLDKy17CqMCWjWENPhAPQf8Mcu4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 23, 48, 127, 36, 79, 225, 68, 57, 167, 41, 126, 36, 178, 119, 22, 52, 68, 57, 155, 2, 220, 26, 136, 251, 153, 254, 140, 67, 186, 130, 7, 142, 29, 140, 166, 104, 61, 15, 236, 167, 244, 249, 61, 54, 159, 89, 253, 202, 212, 181, 53, 65, 37, 95, 202, 68, 149, 36, 45, 243, 87, 229, 75, 103 }, new byte[] { 176, 123, 201, 236, 106, 75, 140, 148, 116, 160, 238, 213, 231, 31, 75, 7, 102, 45, 24, 110, 170, 88, 41, 174, 110, 65, 107, 154, 241, 107, 102, 240, 218, 254, 210, 240, 92, 235, 91, 204, 214, 105, 102, 11, 80, 138, 87, 142, 232, 6, 62, 146, 237, 51, 135, 15, 55, 227, 103, 6, 5, 35, 71, 68, 29, 158, 248, 196, 119, 176, 90, 152, 229, 221, 250, 157, 248, 127, 141, 246, 234, 23, 69, 218, 37, 240, 167, 70, 62, 159, 238, 174, 213, 148, 216, 167, 207, 193, 130, 192, 114, 40, 128, 212, 178, 52, 227, 158, 240, 1, 158, 175, 54, 81, 121, 157, 95, 105, 250, 19, 10, 192, 149, 206, 243, 93, 53, 4 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjE0Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MDQ4MDYxMiwiZXhwIjoxNTgxMDg1NDEyLCJpYXQiOjE1ODA0ODA2MTJ9.t3juJ2wTrQ82Sfa8M2I7xEvgBFlCm3GDoGVqZpzwXLs" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 23, 48, 127, 36, 79, 225, 68, 57, 167, 41, 126, 36, 178, 119, 22, 52, 68, 57, 155, 2, 220, 26, 136, 251, 153, 254, 140, 67, 186, 130, 7, 142, 29, 140, 166, 104, 61, 15, 236, 167, 244, 249, 61, 54, 159, 89, 253, 202, 212, 181, 53, 65, 37, 95, 202, 68, 149, 36, 45, 243, 87, 229, 75, 103 }, new byte[] { 176, 123, 201, 236, 106, 75, 140, 148, 116, 160, 238, 213, 231, 31, 75, 7, 102, 45, 24, 110, 170, 88, 41, 174, 110, 65, 107, 154, 241, 107, 102, 240, 218, 254, 210, 240, 92, 235, 91, 204, 214, 105, 102, 11, 80, 138, 87, 142, 232, 6, 62, 146, 237, 51, 135, 15, 55, 227, 103, 6, 5, 35, 71, 68, 29, 158, 248, 196, 119, 176, 90, 152, 229, 221, 250, 157, 248, 127, 141, 246, 234, 23, 69, 218, 37, 240, 167, 70, 62, 159, 238, 174, 213, 148, 216, 167, 207, 193, 130, 192, 114, 40, 128, 212, 178, 52, 227, 158, 240, 1, 158, 175, 54, 81, 121, 157, 95, 105, 250, 19, 10, 192, 149, 206, 243, 93, 53, 4 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjE1Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MDQ4MDYxMiwiZXhwIjoxNTgxMDg1NDEyLCJpYXQiOjE1ODA0ODA2MTJ9.c-Y5N3l1S3zdrukVKLOrB1jCmPhU4K3o5SVWS2A02yM" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 23, 48, 127, 36, 79, 225, 68, 57, 167, 41, 126, 36, 178, 119, 22, 52, 68, 57, 155, 2, 220, 26, 136, 251, 153, 254, 140, 67, 186, 130, 7, 142, 29, 140, 166, 104, 61, 15, 236, 167, 244, 249, 61, 54, 159, 89, 253, 202, 212, 181, 53, 65, 37, 95, 202, 68, 149, 36, 45, 243, 87, 229, 75, 103 }, new byte[] { 176, 123, 201, 236, 106, 75, 140, 148, 116, 160, 238, 213, 231, 31, 75, 7, 102, 45, 24, 110, 170, 88, 41, 174, 110, 65, 107, 154, 241, 107, 102, 240, 218, 254, 210, 240, 92, 235, 91, 204, 214, 105, 102, 11, 80, 138, 87, 142, 232, 6, 62, 146, 237, 51, 135, 15, 55, 227, 103, 6, 5, 35, 71, 68, 29, 158, 248, 196, 119, 176, 90, 152, 229, 221, 250, 157, 248, 127, 141, 246, 234, 23, 69, 218, 37, 240, 167, 70, 62, 159, 238, 174, 213, 148, 216, 167, 207, 193, 130, 192, 114, 40, 128, 212, 178, 52, 227, 158, 240, 1, 158, 175, 54, 81, 121, 157, 95, 105, 250, 19, 10, 192, 149, 206, 243, 93, 53, 4 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjE2Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MDQ4MDYxMiwiZXhwIjoxNTgxMDg1NDEyLCJpYXQiOjE1ODA0ODA2MTJ9.fDsm3GGUHHMV3lXB1eofRP0ETF8dKMH9FRXe-ADA1po" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 23, 48, 127, 36, 79, 225, 68, 57, 167, 41, 126, 36, 178, 119, 22, 52, 68, 57, 155, 2, 220, 26, 136, 251, 153, 254, 140, 67, 186, 130, 7, 142, 29, 140, 166, 104, 61, 15, 236, 167, 244, 249, 61, 54, 159, 89, 253, 202, 212, 181, 53, 65, 37, 95, 202, 68, 149, 36, 45, 243, 87, 229, 75, 103 }, new byte[] { 176, 123, 201, 236, 106, 75, 140, 148, 116, 160, 238, 213, 231, 31, 75, 7, 102, 45, 24, 110, 170, 88, 41, 174, 110, 65, 107, 154, 241, 107, 102, 240, 218, 254, 210, 240, 92, 235, 91, 204, 214, 105, 102, 11, 80, 138, 87, 142, 232, 6, 62, 146, 237, 51, 135, 15, 55, 227, 103, 6, 5, 35, 71, 68, 29, 158, 248, 196, 119, 176, 90, 152, 229, 221, 250, 157, 248, 127, 141, 246, 234, 23, 69, 218, 37, 240, 167, 70, 62, 159, 238, 174, 213, 148, 216, 167, 207, 193, 130, 192, 114, 40, 128, 212, 178, 52, 227, 158, 240, 1, 158, 175, 54, 81, 121, 157, 95, 105, 250, 19, 10, 192, 149, 206, 243, 93, 53, 4 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjE3Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MDQ4MDYxMiwiZXhwIjoxNTgxMDg1NDEyLCJpYXQiOjE1ODA0ODA2MTJ9.8qnwwiGhTaXQXvIrla1dMT9bnkYRANiOjVTQ73SMkT0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 23, 48, 127, 36, 79, 225, 68, 57, 167, 41, 126, 36, 178, 119, 22, 52, 68, 57, 155, 2, 220, 26, 136, 251, 153, 254, 140, 67, 186, 130, 7, 142, 29, 140, 166, 104, 61, 15, 236, 167, 244, 249, 61, 54, 159, 89, 253, 202, 212, 181, 53, 65, 37, 95, 202, 68, 149, 36, 45, 243, 87, 229, 75, 103 }, new byte[] { 176, 123, 201, 236, 106, 75, 140, 148, 116, 160, 238, 213, 231, 31, 75, 7, 102, 45, 24, 110, 170, 88, 41, 174, 110, 65, 107, 154, 241, 107, 102, 240, 218, 254, 210, 240, 92, 235, 91, 204, 214, 105, 102, 11, 80, 138, 87, 142, 232, 6, 62, 146, 237, 51, 135, 15, 55, 227, 103, 6, 5, 35, 71, 68, 29, 158, 248, 196, 119, 176, 90, 152, 229, 221, 250, 157, 248, 127, 141, 246, 234, 23, 69, 218, 37, 240, 167, 70, 62, 159, 238, 174, 213, 148, 216, 167, 207, 193, 130, 192, 114, 40, 128, 212, 178, 52, 227, 158, 240, 1, 158, 175, 54, 81, 121, 157, 95, 105, 250, 19, 10, 192, 149, 206, 243, 93, 53, 4 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjE4Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MDQ4MDYxMiwiZXhwIjoxNTgxMDg1NDEyLCJpYXQiOjE1ODA0ODA2MTJ9.W0Y0YhwxrD2xIB3oa08zmj22r16QEgcbtswLm0oDyuM" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 23, 48, 127, 36, 79, 225, 68, 57, 167, 41, 126, 36, 178, 119, 22, 52, 68, 57, 155, 2, 220, 26, 136, 251, 153, 254, 140, 67, 186, 130, 7, 142, 29, 140, 166, 104, 61, 15, 236, 167, 244, 249, 61, 54, 159, 89, 253, 202, 212, 181, 53, 65, 37, 95, 202, 68, 149, 36, 45, 243, 87, 229, 75, 103 }, new byte[] { 176, 123, 201, 236, 106, 75, 140, 148, 116, 160, 238, 213, 231, 31, 75, 7, 102, 45, 24, 110, 170, 88, 41, 174, 110, 65, 107, 154, 241, 107, 102, 240, 218, 254, 210, 240, 92, 235, 91, 204, 214, 105, 102, 11, 80, 138, 87, 142, 232, 6, 62, 146, 237, 51, 135, 15, 55, 227, 103, 6, 5, 35, 71, 68, 29, 158, 248, 196, 119, 176, 90, 152, 229, 221, 250, 157, 248, 127, 141, 246, 234, 23, 69, 218, 37, 240, 167, 70, 62, 159, 238, 174, 213, 148, 216, 167, 207, 193, 130, 192, 114, 40, 128, 212, 178, 52, 227, 158, 240, 1, 158, 175, 54, 81, 121, 157, 95, 105, 250, 19, 10, 192, 149, 206, 243, 93, 53, 4 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjE5Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MDQ4MDYxMiwiZXhwIjoxNTgxMDg1NDEyLCJpYXQiOjE1ODA0ODA2MTJ9.hVBSpWQhF09oimwu00fC_AcjffkQXwKD3_Up84tfQ-s" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 23, 48, 127, 36, 79, 225, 68, 57, 167, 41, 126, 36, 178, 119, 22, 52, 68, 57, 155, 2, 220, 26, 136, 251, 153, 254, 140, 67, 186, 130, 7, 142, 29, 140, 166, 104, 61, 15, 236, 167, 244, 249, 61, 54, 159, 89, 253, 202, 212, 181, 53, 65, 37, 95, 202, 68, 149, 36, 45, 243, 87, 229, 75, 103 }, new byte[] { 176, 123, 201, 236, 106, 75, 140, 148, 116, 160, 238, 213, 231, 31, 75, 7, 102, 45, 24, 110, 170, 88, 41, 174, 110, 65, 107, 154, 241, 107, 102, 240, 218, 254, 210, 240, 92, 235, 91, 204, 214, 105, 102, 11, 80, 138, 87, 142, 232, 6, 62, 146, 237, 51, 135, 15, 55, 227, 103, 6, 5, 35, 71, 68, 29, 158, 248, 196, 119, 176, 90, 152, 229, 221, 250, 157, 248, 127, 141, 246, 234, 23, 69, 218, 37, 240, 167, 70, 62, 159, 238, 174, 213, 148, 216, 167, 207, 193, 130, 192, 114, 40, 128, 212, 178, 52, 227, 158, 240, 1, 158, 175, 54, 81, 121, 157, 95, 105, 250, 19, 10, 192, 149, 206, 243, 93, 53, 4 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjIwIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MDQ4MDYxMiwiZXhwIjoxNTgxMDg1NDEyLCJpYXQiOjE1ODA0ODA2MTJ9.sR-qit4CMftSdogZBz1u_Csx92HnLYNUzOYPHS6eR7E" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 23, 48, 127, 36, 79, 225, 68, 57, 167, 41, 126, 36, 178, 119, 22, 52, 68, 57, 155, 2, 220, 26, 136, 251, 153, 254, 140, 67, 186, 130, 7, 142, 29, 140, 166, 104, 61, 15, 236, 167, 244, 249, 61, 54, 159, 89, 253, 202, 212, 181, 53, 65, 37, 95, 202, 68, 149, 36, 45, 243, 87, 229, 75, 103 }, new byte[] { 176, 123, 201, 236, 106, 75, 140, 148, 116, 160, 238, 213, 231, 31, 75, 7, 102, 45, 24, 110, 170, 88, 41, 174, 110, 65, 107, 154, 241, 107, 102, 240, 218, 254, 210, 240, 92, 235, 91, 204, 214, 105, 102, 11, 80, 138, 87, 142, 232, 6, 62, 146, 237, 51, 135, 15, 55, 227, 103, 6, 5, 35, 71, 68, 29, 158, 248, 196, 119, 176, 90, 152, 229, 221, 250, 157, 248, 127, 141, 246, 234, 23, 69, 218, 37, 240, 167, 70, 62, 159, 238, 174, 213, 148, 216, 167, 207, 193, 130, 192, 114, 40, 128, 212, 178, 52, 227, 158, 240, 1, 158, 175, 54, 81, 121, 157, 95, 105, 250, 19, 10, 192, 149, 206, 243, 93, 53, 4 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjIxIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MDQ4MDYxMiwiZXhwIjoxNTgxMDg1NDEyLCJpYXQiOjE1ODA0ODA2MTJ9.2FAxsErs60zAFKAojIAzZBPTh-JUI5mXysDWsnwu8DM" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 23, 48, 127, 36, 79, 225, 68, 57, 167, 41, 126, 36, 178, 119, 22, 52, 68, 57, 155, 2, 220, 26, 136, 251, 153, 254, 140, 67, 186, 130, 7, 142, 29, 140, 166, 104, 61, 15, 236, 167, 244, 249, 61, 54, 159, 89, 253, 202, 212, 181, 53, 65, 37, 95, 202, 68, 149, 36, 45, 243, 87, 229, 75, 103 }, new byte[] { 176, 123, 201, 236, 106, 75, 140, 148, 116, 160, 238, 213, 231, 31, 75, 7, 102, 45, 24, 110, 170, 88, 41, 174, 110, 65, 107, 154, 241, 107, 102, 240, 218, 254, 210, 240, 92, 235, 91, 204, 214, 105, 102, 11, 80, 138, 87, 142, 232, 6, 62, 146, 237, 51, 135, 15, 55, 227, 103, 6, 5, 35, 71, 68, 29, 158, 248, 196, 119, 176, 90, 152, 229, 221, 250, 157, 248, 127, 141, 246, 234, 23, 69, 218, 37, 240, 167, 70, 62, 159, 238, 174, 213, 148, 216, 167, 207, 193, 130, 192, 114, 40, 128, 212, 178, 52, 227, 158, 240, 1, 158, 175, 54, 81, 121, 157, 95, 105, 250, 19, 10, 192, 149, 206, 243, 93, 53, 4 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjIyIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MDQ4MDYxMiwiZXhwIjoxNTgxMDg1NDEyLCJpYXQiOjE1ODA0ODA2MTJ9.fHuW8ubcZ3ZyspCZivqwnMrqrsb5EPOQrjsa27CZKbU" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 23, 48, 127, 36, 79, 225, 68, 57, 167, 41, 126, 36, 178, 119, 22, 52, 68, 57, 155, 2, 220, 26, 136, 251, 153, 254, 140, 67, 186, 130, 7, 142, 29, 140, 166, 104, 61, 15, 236, 167, 244, 249, 61, 54, 159, 89, 253, 202, 212, 181, 53, 65, 37, 95, 202, 68, 149, 36, 45, 243, 87, 229, 75, 103 }, new byte[] { 176, 123, 201, 236, 106, 75, 140, 148, 116, 160, 238, 213, 231, 31, 75, 7, 102, 45, 24, 110, 170, 88, 41, 174, 110, 65, 107, 154, 241, 107, 102, 240, 218, 254, 210, 240, 92, 235, 91, 204, 214, 105, 102, 11, 80, 138, 87, 142, 232, 6, 62, 146, 237, 51, 135, 15, 55, 227, 103, 6, 5, 35, 71, 68, 29, 158, 248, 196, 119, 176, 90, 152, 229, 221, 250, 157, 248, 127, 141, 246, 234, 23, 69, 218, 37, 240, 167, 70, 62, 159, 238, 174, 213, 148, 216, 167, 207, 193, 130, 192, 114, 40, 128, 212, 178, 52, 227, 158, 240, 1, 158, 175, 54, 81, 121, 157, 95, 105, 250, 19, 10, 192, 149, 206, 243, 93, 53, 4 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjIzIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MDQ4MDYxMiwiZXhwIjoxNTgxMDg1NDEyLCJpYXQiOjE1ODA0ODA2MTJ9.Wi6r5b7TUM4RkaFwQOATpG9iOrgu04lxOO_LLhokgVk" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 23, 48, 127, 36, 79, 225, 68, 57, 167, 41, 126, 36, 178, 119, 22, 52, 68, 57, 155, 2, 220, 26, 136, 251, 153, 254, 140, 67, 186, 130, 7, 142, 29, 140, 166, 104, 61, 15, 236, 167, 244, 249, 61, 54, 159, 89, 253, 202, 212, 181, 53, 65, 37, 95, 202, 68, 149, 36, 45, 243, 87, 229, 75, 103 }, new byte[] { 176, 123, 201, 236, 106, 75, 140, 148, 116, 160, 238, 213, 231, 31, 75, 7, 102, 45, 24, 110, 170, 88, 41, 174, 110, 65, 107, 154, 241, 107, 102, 240, 218, 254, 210, 240, 92, 235, 91, 204, 214, 105, 102, 11, 80, 138, 87, 142, 232, 6, 62, 146, 237, 51, 135, 15, 55, 227, 103, 6, 5, 35, 71, 68, 29, 158, 248, 196, 119, 176, 90, 152, 229, 221, 250, 157, 248, 127, 141, 246, 234, 23, 69, 218, 37, 240, 167, 70, 62, 159, 238, 174, 213, 148, 216, 167, 207, 193, 130, 192, 114, 40, 128, 212, 178, 52, 227, 158, 240, 1, 158, 175, 54, 81, 121, 157, 95, 105, 250, 19, 10, 192, 149, 206, 243, 93, 53, 4 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjI0Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MDQ4MDYxMiwiZXhwIjoxNTgxMDg1NDEyLCJpYXQiOjE1ODA0ODA2MTJ9.M7D4Jh-cQaPEpk2AEwCY1R6XvNklYPJklb-GfEN5DKA" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 23, 48, 127, 36, 79, 225, 68, 57, 167, 41, 126, 36, 178, 119, 22, 52, 68, 57, 155, 2, 220, 26, 136, 251, 153, 254, 140, 67, 186, 130, 7, 142, 29, 140, 166, 104, 61, 15, 236, 167, 244, 249, 61, 54, 159, 89, 253, 202, 212, 181, 53, 65, 37, 95, 202, 68, 149, 36, 45, 243, 87, 229, 75, 103 }, new byte[] { 176, 123, 201, 236, 106, 75, 140, 148, 116, 160, 238, 213, 231, 31, 75, 7, 102, 45, 24, 110, 170, 88, 41, 174, 110, 65, 107, 154, 241, 107, 102, 240, 218, 254, 210, 240, 92, 235, 91, 204, 214, 105, 102, 11, 80, 138, 87, 142, 232, 6, 62, 146, 237, 51, 135, 15, 55, 227, 103, 6, 5, 35, 71, 68, 29, 158, 248, 196, 119, 176, 90, 152, 229, 221, 250, 157, 248, 127, 141, 246, 234, 23, 69, 218, 37, 240, 167, 70, 62, 159, 238, 174, 213, 148, 216, 167, 207, 193, 130, 192, 114, 40, 128, 212, 178, 52, 227, 158, 240, 1, 158, 175, 54, 81, 121, 157, 95, 105, 250, 19, 10, 192, 149, 206, 243, 93, 53, 4 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjI1Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MDQ4MDYxMiwiZXhwIjoxNTgxMDg1NDEyLCJpYXQiOjE1ODA0ODA2MTJ9.OvHIpjIhQHnMhAjaE7SSmIeG06Lzdxo2v1DSieCychM" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 23, 48, 127, 36, 79, 225, 68, 57, 167, 41, 126, 36, 178, 119, 22, 52, 68, 57, 155, 2, 220, 26, 136, 251, 153, 254, 140, 67, 186, 130, 7, 142, 29, 140, 166, 104, 61, 15, 236, 167, 244, 249, 61, 54, 159, 89, 253, 202, 212, 181, 53, 65, 37, 95, 202, 68, 149, 36, 45, 243, 87, 229, 75, 103 }, new byte[] { 176, 123, 201, 236, 106, 75, 140, 148, 116, 160, 238, 213, 231, 31, 75, 7, 102, 45, 24, 110, 170, 88, 41, 174, 110, 65, 107, 154, 241, 107, 102, 240, 218, 254, 210, 240, 92, 235, 91, 204, 214, 105, 102, 11, 80, 138, 87, 142, 232, 6, 62, 146, 237, 51, 135, 15, 55, 227, 103, 6, 5, 35, 71, 68, 29, 158, 248, 196, 119, 176, 90, 152, 229, 221, 250, 157, 248, 127, 141, 246, 234, 23, 69, 218, 37, 240, 167, 70, 62, 159, 238, 174, 213, 148, 216, 167, 207, 193, 130, 192, 114, 40, 128, 212, 178, 52, 227, 158, 240, 1, 158, 175, 54, 81, 121, 157, 95, 105, 250, 19, 10, 192, 149, 206, 243, 93, 53, 4 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjI2Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MDQ4MDYxMiwiZXhwIjoxNTgxMDg1NDEyLCJpYXQiOjE1ODA0ODA2MTJ9.MyjOo_Xrl4gO7aqArFHYZrt5isBc1a0Dq2fWGg_tlvA" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 23, 48, 127, 36, 79, 225, 68, 57, 167, 41, 126, 36, 178, 119, 22, 52, 68, 57, 155, 2, 220, 26, 136, 251, 153, 254, 140, 67, 186, 130, 7, 142, 29, 140, 166, 104, 61, 15, 236, 167, 244, 249, 61, 54, 159, 89, 253, 202, 212, 181, 53, 65, 37, 95, 202, 68, 149, 36, 45, 243, 87, 229, 75, 103 }, new byte[] { 176, 123, 201, 236, 106, 75, 140, 148, 116, 160, 238, 213, 231, 31, 75, 7, 102, 45, 24, 110, 170, 88, 41, 174, 110, 65, 107, 154, 241, 107, 102, 240, 218, 254, 210, 240, 92, 235, 91, 204, 214, 105, 102, 11, 80, 138, 87, 142, 232, 6, 62, 146, 237, 51, 135, 15, 55, 227, 103, 6, 5, 35, 71, 68, 29, 158, 248, 196, 119, 176, 90, 152, 229, 221, 250, 157, 248, 127, 141, 246, 234, 23, 69, 218, 37, 240, 167, 70, 62, 159, 238, 174, 213, 148, 216, 167, 207, 193, 130, 192, 114, 40, 128, 212, 178, 52, 227, 158, 240, 1, 158, 175, 54, 81, 121, 157, 95, 105, 250, 19, 10, 192, 149, 206, 243, 93, 53, 4 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjI3Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MDQ4MDYxMiwiZXhwIjoxNTgxMDg1NDEyLCJpYXQiOjE1ODA0ODA2MTJ9.bEBYXZsLTgQXwsbR0l7SZ_pJrGhN-SHe8LtRoc_Wn-g" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 23, 48, 127, 36, 79, 225, 68, 57, 167, 41, 126, 36, 178, 119, 22, 52, 68, 57, 155, 2, 220, 26, 136, 251, 153, 254, 140, 67, 186, 130, 7, 142, 29, 140, 166, 104, 61, 15, 236, 167, 244, 249, 61, 54, 159, 89, 253, 202, 212, 181, 53, 65, 37, 95, 202, 68, 149, 36, 45, 243, 87, 229, 75, 103 }, new byte[] { 176, 123, 201, 236, 106, 75, 140, 148, 116, 160, 238, 213, 231, 31, 75, 7, 102, 45, 24, 110, 170, 88, 41, 174, 110, 65, 107, 154, 241, 107, 102, 240, 218, 254, 210, 240, 92, 235, 91, 204, 214, 105, 102, 11, 80, 138, 87, 142, 232, 6, 62, 146, 237, 51, 135, 15, 55, 227, 103, 6, 5, 35, 71, 68, 29, 158, 248, 196, 119, 176, 90, 152, 229, 221, 250, 157, 248, 127, 141, 246, 234, 23, 69, 218, 37, 240, 167, 70, 62, 159, 238, 174, 213, 148, 216, 167, 207, 193, 130, 192, 114, 40, 128, 212, 178, 52, 227, 158, 240, 1, 158, 175, 54, 81, 121, 157, 95, 105, 250, 19, 10, 192, 149, 206, 243, 93, 53, 4 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjI4Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MDQ4MDYxMiwiZXhwIjoxNTgxMDg1NDEyLCJpYXQiOjE1ODA0ODA2MTJ9.4c04Q-x5L12ayzhRWbcC0vy3ZBGdOJS7gaD6b3hBM7U" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 23, 48, 127, 36, 79, 225, 68, 57, 167, 41, 126, 36, 178, 119, 22, 52, 68, 57, 155, 2, 220, 26, 136, 251, 153, 254, 140, 67, 186, 130, 7, 142, 29, 140, 166, 104, 61, 15, 236, 167, 244, 249, 61, 54, 159, 89, 253, 202, 212, 181, 53, 65, 37, 95, 202, 68, 149, 36, 45, 243, 87, 229, 75, 103 }, new byte[] { 176, 123, 201, 236, 106, 75, 140, 148, 116, 160, 238, 213, 231, 31, 75, 7, 102, 45, 24, 110, 170, 88, 41, 174, 110, 65, 107, 154, 241, 107, 102, 240, 218, 254, 210, 240, 92, 235, 91, 204, 214, 105, 102, 11, 80, 138, 87, 142, 232, 6, 62, 146, 237, 51, 135, 15, 55, 227, 103, 6, 5, 35, 71, 68, 29, 158, 248, 196, 119, 176, 90, 152, 229, 221, 250, 157, 248, 127, 141, 246, 234, 23, 69, 218, 37, 240, 167, 70, 62, 159, 238, 174, 213, 148, 216, 167, 207, 193, 130, 192, 114, 40, 128, 212, 178, 52, 227, 158, 240, 1, 158, 175, 54, 81, 121, 157, 95, 105, 250, 19, 10, 192, 149, 206, 243, 93, 53, 4 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjI5Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MDQ4MDYxMiwiZXhwIjoxNTgxMDg1NDEyLCJpYXQiOjE1ODA0ODA2MTJ9.rGeE09pbtjEU3PMqyYcUUnzt_SYhY8ooWoP9RBA2m_4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 23, 48, 127, 36, 79, 225, 68, 57, 167, 41, 126, 36, 178, 119, 22, 52, 68, 57, 155, 2, 220, 26, 136, 251, 153, 254, 140, 67, 186, 130, 7, 142, 29, 140, 166, 104, 61, 15, 236, 167, 244, 249, 61, 54, 159, 89, 253, 202, 212, 181, 53, 65, 37, 95, 202, 68, 149, 36, 45, 243, 87, 229, 75, 103 }, new byte[] { 176, 123, 201, 236, 106, 75, 140, 148, 116, 160, 238, 213, 231, 31, 75, 7, 102, 45, 24, 110, 170, 88, 41, 174, 110, 65, 107, 154, 241, 107, 102, 240, 218, 254, 210, 240, 92, 235, 91, 204, 214, 105, 102, 11, 80, 138, 87, 142, 232, 6, 62, 146, 237, 51, 135, 15, 55, 227, 103, 6, 5, 35, 71, 68, 29, 158, 248, 196, 119, 176, 90, 152, 229, 221, 250, 157, 248, 127, 141, 246, 234, 23, 69, 218, 37, 240, 167, 70, 62, 159, 238, 174, 213, 148, 216, 167, 207, 193, 130, 192, 114, 40, 128, 212, 178, 52, 227, 158, 240, 1, 158, 175, 54, 81, 121, 157, 95, 105, 250, 19, 10, 192, 149, 206, 243, 93, 53, 4 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjMwIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MDQ4MDYxMiwiZXhwIjoxNTgxMDg1NDEyLCJpYXQiOjE1ODA0ODA2MTJ9.yZILp9RBDQkU4tTIIXSefVLG1wd7P8RmQ9S51NJCjWY" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 23, 48, 127, 36, 79, 225, 68, 57, 167, 41, 126, 36, 178, 119, 22, 52, 68, 57, 155, 2, 220, 26, 136, 251, 153, 254, 140, 67, 186, 130, 7, 142, 29, 140, 166, 104, 61, 15, 236, 167, 244, 249, 61, 54, 159, 89, 253, 202, 212, 181, 53, 65, 37, 95, 202, 68, 149, 36, 45, 243, 87, 229, 75, 103 }, new byte[] { 176, 123, 201, 236, 106, 75, 140, 148, 116, 160, 238, 213, 231, 31, 75, 7, 102, 45, 24, 110, 170, 88, 41, 174, 110, 65, 107, 154, 241, 107, 102, 240, 218, 254, 210, 240, 92, 235, 91, 204, 214, 105, 102, 11, 80, 138, 87, 142, 232, 6, 62, 146, 237, 51, 135, 15, 55, 227, 103, 6, 5, 35, 71, 68, 29, 158, 248, 196, 119, 176, 90, 152, 229, 221, 250, 157, 248, 127, 141, 246, 234, 23, 69, 218, 37, 240, 167, 70, 62, 159, 238, 174, 213, 148, 216, 167, 207, 193, 130, 192, 114, 40, 128, 212, 178, 52, 227, 158, 240, 1, 158, 175, 54, 81, 121, 157, 95, 105, 250, 19, 10, 192, 149, 206, 243, 93, 53, 4 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjMxIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MDQ4MDYxMiwiZXhwIjoxNTgxMDg1NDEyLCJpYXQiOjE1ODA0ODA2MTJ9.9rgYJXj7-BOx9Ni0iESE9e09q6zl2PPCCsTtg9O92sw" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 23, 48, 127, 36, 79, 225, 68, 57, 167, 41, 126, 36, 178, 119, 22, 52, 68, 57, 155, 2, 220, 26, 136, 251, 153, 254, 140, 67, 186, 130, 7, 142, 29, 140, 166, 104, 61, 15, 236, 167, 244, 249, 61, 54, 159, 89, 253, 202, 212, 181, 53, 65, 37, 95, 202, 68, 149, 36, 45, 243, 87, 229, 75, 103 }, new byte[] { 176, 123, 201, 236, 106, 75, 140, 148, 116, 160, 238, 213, 231, 31, 75, 7, 102, 45, 24, 110, 170, 88, 41, 174, 110, 65, 107, 154, 241, 107, 102, 240, 218, 254, 210, 240, 92, 235, 91, 204, 214, 105, 102, 11, 80, 138, 87, 142, 232, 6, 62, 146, 237, 51, 135, 15, 55, 227, 103, 6, 5, 35, 71, 68, 29, 158, 248, 196, 119, 176, 90, 152, 229, 221, 250, 157, 248, 127, 141, 246, 234, 23, 69, 218, 37, 240, 167, 70, 62, 159, 238, 174, 213, 148, 216, 167, 207, 193, 130, 192, 114, 40, 128, 212, 178, 52, 227, 158, 240, 1, 158, 175, 54, 81, 121, 157, 95, 105, 250, 19, 10, 192, 149, 206, 243, 93, 53, 4 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjMyIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MDQ4MDYxMiwiZXhwIjoxNTgxMDg1NDEyLCJpYXQiOjE1ODA0ODA2MTJ9.J7-bU6lUYXyGbRBoj9MfEMHD-wC0OwbWc8xdE44YnN4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 23, 48, 127, 36, 79, 225, 68, 57, 167, 41, 126, 36, 178, 119, 22, 52, 68, 57, 155, 2, 220, 26, 136, 251, 153, 254, 140, 67, 186, 130, 7, 142, 29, 140, 166, 104, 61, 15, 236, 167, 244, 249, 61, 54, 159, 89, 253, 202, 212, 181, 53, 65, 37, 95, 202, 68, 149, 36, 45, 243, 87, 229, 75, 103 }, new byte[] { 176, 123, 201, 236, 106, 75, 140, 148, 116, 160, 238, 213, 231, 31, 75, 7, 102, 45, 24, 110, 170, 88, 41, 174, 110, 65, 107, 154, 241, 107, 102, 240, 218, 254, 210, 240, 92, 235, 91, 204, 214, 105, 102, 11, 80, 138, 87, 142, 232, 6, 62, 146, 237, 51, 135, 15, 55, 227, 103, 6, 5, 35, 71, 68, 29, 158, 248, 196, 119, 176, 90, 152, 229, 221, 250, 157, 248, 127, 141, 246, 234, 23, 69, 218, 37, 240, 167, 70, 62, 159, 238, 174, 213, 148, 216, 167, 207, 193, 130, 192, 114, 40, 128, 212, 178, 52, 227, 158, 240, 1, 158, 175, 54, 81, 121, 157, 95, 105, 250, 19, 10, 192, 149, 206, 243, 93, 53, 4 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjMzIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MDQ4MDYxMiwiZXhwIjoxNTgxMDg1NDEyLCJpYXQiOjE1ODA0ODA2MTJ9.HbllXy8b0cFehigxopAQDoiRtfjAMwdQDJFWEwkTUqY" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 23, 48, 127, 36, 79, 225, 68, 57, 167, 41, 126, 36, 178, 119, 22, 52, 68, 57, 155, 2, 220, 26, 136, 251, 153, 254, 140, 67, 186, 130, 7, 142, 29, 140, 166, 104, 61, 15, 236, 167, 244, 249, 61, 54, 159, 89, 253, 202, 212, 181, 53, 65, 37, 95, 202, 68, 149, 36, 45, 243, 87, 229, 75, 103 }, new byte[] { 176, 123, 201, 236, 106, 75, 140, 148, 116, 160, 238, 213, 231, 31, 75, 7, 102, 45, 24, 110, 170, 88, 41, 174, 110, 65, 107, 154, 241, 107, 102, 240, 218, 254, 210, 240, 92, 235, 91, 204, 214, 105, 102, 11, 80, 138, 87, 142, 232, 6, 62, 146, 237, 51, 135, 15, 55, 227, 103, 6, 5, 35, 71, 68, 29, 158, 248, 196, 119, 176, 90, 152, 229, 221, 250, 157, 248, 127, 141, 246, 234, 23, 69, 218, 37, 240, 167, 70, 62, 159, 238, 174, 213, 148, 216, 167, 207, 193, 130, 192, 114, 40, 128, 212, 178, 52, 227, 158, 240, 1, 158, 175, 54, 81, 121, 157, 95, 105, 250, 19, 10, 192, 149, 206, 243, 93, 53, 4 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjM0Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MDQ4MDYxMiwiZXhwIjoxNTgxMDg1NDEyLCJpYXQiOjE1ODA0ODA2MTJ9.T9XxUmaD3wQitVJ1hx_GoJ7aBXrEQFy04sEdLslsmTs" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 23, 48, 127, 36, 79, 225, 68, 57, 167, 41, 126, 36, 178, 119, 22, 52, 68, 57, 155, 2, 220, 26, 136, 251, 153, 254, 140, 67, 186, 130, 7, 142, 29, 140, 166, 104, 61, 15, 236, 167, 244, 249, 61, 54, 159, 89, 253, 202, 212, 181, 53, 65, 37, 95, 202, 68, 149, 36, 45, 243, 87, 229, 75, 103 }, new byte[] { 176, 123, 201, 236, 106, 75, 140, 148, 116, 160, 238, 213, 231, 31, 75, 7, 102, 45, 24, 110, 170, 88, 41, 174, 110, 65, 107, 154, 241, 107, 102, 240, 218, 254, 210, 240, 92, 235, 91, 204, 214, 105, 102, 11, 80, 138, 87, 142, 232, 6, 62, 146, 237, 51, 135, 15, 55, 227, 103, 6, 5, 35, 71, 68, 29, 158, 248, 196, 119, 176, 90, 152, 229, 221, 250, 157, 248, 127, 141, 246, 234, 23, 69, 218, 37, 240, 167, 70, 62, 159, 238, 174, 213, 148, 216, 167, 207, 193, 130, 192, 114, 40, 128, 212, 178, 52, 227, 158, 240, 1, 158, 175, 54, 81, 121, 157, 95, 105, 250, 19, 10, 192, 149, 206, 243, 93, 53, 4 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjM1Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MDQ4MDYxMiwiZXhwIjoxNTgxMDg1NDEyLCJpYXQiOjE1ODA0ODA2MTJ9.BdKm_Cm4flEB1yJQlZzUXNQ1wuF__3IClOAo-em1d98" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 23, 48, 127, 36, 79, 225, 68, 57, 167, 41, 126, 36, 178, 119, 22, 52, 68, 57, 155, 2, 220, 26, 136, 251, 153, 254, 140, 67, 186, 130, 7, 142, 29, 140, 166, 104, 61, 15, 236, 167, 244, 249, 61, 54, 159, 89, 253, 202, 212, 181, 53, 65, 37, 95, 202, 68, 149, 36, 45, 243, 87, 229, 75, 103 }, new byte[] { 176, 123, 201, 236, 106, 75, 140, 148, 116, 160, 238, 213, 231, 31, 75, 7, 102, 45, 24, 110, 170, 88, 41, 174, 110, 65, 107, 154, 241, 107, 102, 240, 218, 254, 210, 240, 92, 235, 91, 204, 214, 105, 102, 11, 80, 138, 87, 142, 232, 6, 62, 146, 237, 51, 135, 15, 55, 227, 103, 6, 5, 35, 71, 68, 29, 158, 248, 196, 119, 176, 90, 152, 229, 221, 250, 157, 248, 127, 141, 246, 234, 23, 69, 218, 37, 240, 167, 70, 62, 159, 238, 174, 213, 148, 216, 167, 207, 193, 130, 192, 114, 40, 128, 212, 178, 52, 227, 158, 240, 1, 158, 175, 54, 81, 121, 157, 95, 105, 250, 19, 10, 192, 149, 206, 243, 93, 53, 4 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjM2Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MDQ4MDYxMiwiZXhwIjoxNTgxMDg1NDEyLCJpYXQiOjE1ODA0ODA2MTJ9.Zqg7TlX919R42gUOaO6I_7mrtLPXjnkrmAm9O0SiaJ4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 23, 48, 127, 36, 79, 225, 68, 57, 167, 41, 126, 36, 178, 119, 22, 52, 68, 57, 155, 2, 220, 26, 136, 251, 153, 254, 140, 67, 186, 130, 7, 142, 29, 140, 166, 104, 61, 15, 236, 167, 244, 249, 61, 54, 159, 89, 253, 202, 212, 181, 53, 65, 37, 95, 202, 68, 149, 36, 45, 243, 87, 229, 75, 103 }, new byte[] { 176, 123, 201, 236, 106, 75, 140, 148, 116, 160, 238, 213, 231, 31, 75, 7, 102, 45, 24, 110, 170, 88, 41, 174, 110, 65, 107, 154, 241, 107, 102, 240, 218, 254, 210, 240, 92, 235, 91, 204, 214, 105, 102, 11, 80, 138, 87, 142, 232, 6, 62, 146, 237, 51, 135, 15, 55, 227, 103, 6, 5, 35, 71, 68, 29, 158, 248, 196, 119, 176, 90, 152, 229, 221, 250, 157, 248, 127, 141, 246, 234, 23, 69, 218, 37, 240, 167, 70, 62, 159, 238, 174, 213, 148, 216, 167, 207, 193, 130, 192, 114, 40, 128, 212, 178, 52, 227, 158, 240, 1, 158, 175, 54, 81, 121, 157, 95, 105, 250, 19, 10, 192, 149, 206, 243, 93, 53, 4 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjM3Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MDQ4MDYxMiwiZXhwIjoxNTgxMDg1NDEyLCJpYXQiOjE1ODA0ODA2MTJ9.ZPgX0BjABtLA5UrX9WGxVh-Pf56bVlZHKVYS09YTLss" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 23, 48, 127, 36, 79, 225, 68, 57, 167, 41, 126, 36, 178, 119, 22, 52, 68, 57, 155, 2, 220, 26, 136, 251, 153, 254, 140, 67, 186, 130, 7, 142, 29, 140, 166, 104, 61, 15, 236, 167, 244, 249, 61, 54, 159, 89, 253, 202, 212, 181, 53, 65, 37, 95, 202, 68, 149, 36, 45, 243, 87, 229, 75, 103 }, new byte[] { 176, 123, 201, 236, 106, 75, 140, 148, 116, 160, 238, 213, 231, 31, 75, 7, 102, 45, 24, 110, 170, 88, 41, 174, 110, 65, 107, 154, 241, 107, 102, 240, 218, 254, 210, 240, 92, 235, 91, 204, 214, 105, 102, 11, 80, 138, 87, 142, 232, 6, 62, 146, 237, 51, 135, 15, 55, 227, 103, 6, 5, 35, 71, 68, 29, 158, 248, 196, 119, 176, 90, 152, 229, 221, 250, 157, 248, 127, 141, 246, 234, 23, 69, 218, 37, 240, 167, 70, 62, 159, 238, 174, 213, 148, 216, 167, 207, 193, 130, 192, 114, 40, 128, 212, 178, 52, 227, 158, 240, 1, 158, 175, 54, 81, 121, 157, 95, 105, 250, 19, 10, 192, 149, 206, 243, 93, 53, 4 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjM4Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MDQ4MDYxMiwiZXhwIjoxNTgxMDg1NDEyLCJpYXQiOjE1ODA0ODA2MTJ9.Rabg2AMCHiJ8SnHA1pprJ--fe4PgAestxqAmfQ_ZYu0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 23, 48, 127, 36, 79, 225, 68, 57, 167, 41, 126, 36, 178, 119, 22, 52, 68, 57, 155, 2, 220, 26, 136, 251, 153, 254, 140, 67, 186, 130, 7, 142, 29, 140, 166, 104, 61, 15, 236, 167, 244, 249, 61, 54, 159, 89, 253, 202, 212, 181, 53, 65, 37, 95, 202, 68, 149, 36, 45, 243, 87, 229, 75, 103 }, new byte[] { 176, 123, 201, 236, 106, 75, 140, 148, 116, 160, 238, 213, 231, 31, 75, 7, 102, 45, 24, 110, 170, 88, 41, 174, 110, 65, 107, 154, 241, 107, 102, 240, 218, 254, 210, 240, 92, 235, 91, 204, 214, 105, 102, 11, 80, 138, 87, 142, 232, 6, 62, 146, 237, 51, 135, 15, 55, 227, 103, 6, 5, 35, 71, 68, 29, 158, 248, 196, 119, 176, 90, 152, 229, 221, 250, 157, 248, 127, 141, 246, 234, 23, 69, 218, 37, 240, 167, 70, 62, 159, 238, 174, 213, 148, 216, 167, 207, 193, 130, 192, 114, 40, 128, 212, 178, 52, 227, 158, 240, 1, 158, 175, 54, 81, 121, 157, 95, 105, 250, 19, 10, 192, 149, 206, 243, 93, 53, 4 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjM5Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MDQ4MDYxMiwiZXhwIjoxNTgxMDg1NDEyLCJpYXQiOjE1ODA0ODA2MTJ9.cQXMKKX6Y3uA1p9NA8TDdfJQwUPh-29z5WUG4WO3_MI" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 23, 48, 127, 36, 79, 225, 68, 57, 167, 41, 126, 36, 178, 119, 22, 52, 68, 57, 155, 2, 220, 26, 136, 251, 153, 254, 140, 67, 186, 130, 7, 142, 29, 140, 166, 104, 61, 15, 236, 167, 244, 249, 61, 54, 159, 89, 253, 202, 212, 181, 53, 65, 37, 95, 202, 68, 149, 36, 45, 243, 87, 229, 75, 103 }, new byte[] { 176, 123, 201, 236, 106, 75, 140, 148, 116, 160, 238, 213, 231, 31, 75, 7, 102, 45, 24, 110, 170, 88, 41, 174, 110, 65, 107, 154, 241, 107, 102, 240, 218, 254, 210, 240, 92, 235, 91, 204, 214, 105, 102, 11, 80, 138, 87, 142, 232, 6, 62, 146, 237, 51, 135, 15, 55, 227, 103, 6, 5, 35, 71, 68, 29, 158, 248, 196, 119, 176, 90, 152, 229, 221, 250, 157, 248, 127, 141, 246, 234, 23, 69, 218, 37, 240, 167, 70, 62, 159, 238, 174, 213, 148, 216, 167, 207, 193, 130, 192, 114, 40, 128, 212, 178, 52, 227, 158, 240, 1, 158, 175, 54, 81, 121, 157, 95, 105, 250, 19, 10, 192, 149, 206, 243, 93, 53, 4 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjQwIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MDQ4MDYxMiwiZXhwIjoxNTgxMDg1NDEyLCJpYXQiOjE1ODA0ODA2MTJ9.p-KLlXBI59gKmwle8nzZCBpH0Jx4br1cU-aso0IfdOQ" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 23, 48, 127, 36, 79, 225, 68, 57, 167, 41, 126, 36, 178, 119, 22, 52, 68, 57, 155, 2, 220, 26, 136, 251, 153, 254, 140, 67, 186, 130, 7, 142, 29, 140, 166, 104, 61, 15, 236, 167, 244, 249, 61, 54, 159, 89, 253, 202, 212, 181, 53, 65, 37, 95, 202, 68, 149, 36, 45, 243, 87, 229, 75, 103 }, new byte[] { 176, 123, 201, 236, 106, 75, 140, 148, 116, 160, 238, 213, 231, 31, 75, 7, 102, 45, 24, 110, 170, 88, 41, 174, 110, 65, 107, 154, 241, 107, 102, 240, 218, 254, 210, 240, 92, 235, 91, 204, 214, 105, 102, 11, 80, 138, 87, 142, 232, 6, 62, 146, 237, 51, 135, 15, 55, 227, 103, 6, 5, 35, 71, 68, 29, 158, 248, 196, 119, 176, 90, 152, 229, 221, 250, 157, 248, 127, 141, 246, 234, 23, 69, 218, 37, 240, 167, 70, 62, 159, 238, 174, 213, 148, 216, 167, 207, 193, 130, 192, 114, 40, 128, 212, 178, 52, 227, 158, 240, 1, 158, 175, 54, 81, 121, 157, 95, 105, 250, 19, 10, 192, 149, 206, 243, 93, 53, 4 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjQxIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MDQ4MDYxMiwiZXhwIjoxNTgxMDg1NDEyLCJpYXQiOjE1ODA0ODA2MTJ9.iduofgeKvKZfzZfgxMluOI8EnohE7bM-UtIyzJtuTvg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 23, 48, 127, 36, 79, 225, 68, 57, 167, 41, 126, 36, 178, 119, 22, 52, 68, 57, 155, 2, 220, 26, 136, 251, 153, 254, 140, 67, 186, 130, 7, 142, 29, 140, 166, 104, 61, 15, 236, 167, 244, 249, 61, 54, 159, 89, 253, 202, 212, 181, 53, 65, 37, 95, 202, 68, 149, 36, 45, 243, 87, 229, 75, 103 }, new byte[] { 176, 123, 201, 236, 106, 75, 140, 148, 116, 160, 238, 213, 231, 31, 75, 7, 102, 45, 24, 110, 170, 88, 41, 174, 110, 65, 107, 154, 241, 107, 102, 240, 218, 254, 210, 240, 92, 235, 91, 204, 214, 105, 102, 11, 80, 138, 87, 142, 232, 6, 62, 146, 237, 51, 135, 15, 55, 227, 103, 6, 5, 35, 71, 68, 29, 158, 248, 196, 119, 176, 90, 152, 229, 221, 250, 157, 248, 127, 141, 246, 234, 23, 69, 218, 37, 240, 167, 70, 62, 159, 238, 174, 213, 148, 216, 167, 207, 193, 130, 192, 114, 40, 128, 212, 178, 52, 227, 158, 240, 1, 158, 175, 54, 81, 121, 157, 95, 105, 250, 19, 10, 192, 149, 206, 243, 93, 53, 4 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjQyIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MDQ4MDYxMiwiZXhwIjoxNTgxMDg1NDEyLCJpYXQiOjE1ODA0ODA2MTJ9.swHdzrsNcolAOJgH6q7zdbiYnFHLEuRlDGOQJqlBK3M" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 23, 48, 127, 36, 79, 225, 68, 57, 167, 41, 126, 36, 178, 119, 22, 52, 68, 57, 155, 2, 220, 26, 136, 251, 153, 254, 140, 67, 186, 130, 7, 142, 29, 140, 166, 104, 61, 15, 236, 167, 244, 249, 61, 54, 159, 89, 253, 202, 212, 181, 53, 65, 37, 95, 202, 68, 149, 36, 45, 243, 87, 229, 75, 103 }, new byte[] { 176, 123, 201, 236, 106, 75, 140, 148, 116, 160, 238, 213, 231, 31, 75, 7, 102, 45, 24, 110, 170, 88, 41, 174, 110, 65, 107, 154, 241, 107, 102, 240, 218, 254, 210, 240, 92, 235, 91, 204, 214, 105, 102, 11, 80, 138, 87, 142, 232, 6, 62, 146, 237, 51, 135, 15, 55, 227, 103, 6, 5, 35, 71, 68, 29, 158, 248, 196, 119, 176, 90, 152, 229, 221, 250, 157, 248, 127, 141, 246, 234, 23, 69, 218, 37, 240, 167, 70, 62, 159, 238, 174, 213, 148, 216, 167, 207, 193, 130, 192, 114, 40, 128, 212, 178, 52, 227, 158, 240, 1, 158, 175, 54, 81, 121, 157, 95, 105, 250, 19, 10, 192, 149, 206, 243, 93, 53, 4 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjQzIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MDQ4MDYxMiwiZXhwIjoxNTgxMDg1NDEyLCJpYXQiOjE1ODA0ODA2MTJ9.EuEXeTsJSoT2R00DKCjHxGRDk5ffXP9yefxdbmgcMxI" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 23, 48, 127, 36, 79, 225, 68, 57, 167, 41, 126, 36, 178, 119, 22, 52, 68, 57, 155, 2, 220, 26, 136, 251, 153, 254, 140, 67, 186, 130, 7, 142, 29, 140, 166, 104, 61, 15, 236, 167, 244, 249, 61, 54, 159, 89, 253, 202, 212, 181, 53, 65, 37, 95, 202, 68, 149, 36, 45, 243, 87, 229, 75, 103 }, new byte[] { 176, 123, 201, 236, 106, 75, 140, 148, 116, 160, 238, 213, 231, 31, 75, 7, 102, 45, 24, 110, 170, 88, 41, 174, 110, 65, 107, 154, 241, 107, 102, 240, 218, 254, 210, 240, 92, 235, 91, 204, 214, 105, 102, 11, 80, 138, 87, 142, 232, 6, 62, 146, 237, 51, 135, 15, 55, 227, 103, 6, 5, 35, 71, 68, 29, 158, 248, 196, 119, 176, 90, 152, 229, 221, 250, 157, 248, 127, 141, 246, 234, 23, 69, 218, 37, 240, 167, 70, 62, 159, 238, 174, 213, 148, 216, 167, 207, 193, 130, 192, 114, 40, 128, 212, 178, 52, 227, 158, 240, 1, 158, 175, 54, 81, 121, 157, 95, 105, 250, 19, 10, 192, 149, 206, 243, 93, 53, 4 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjQ0Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MDQ4MDYxMiwiZXhwIjoxNTgxMDg1NDEyLCJpYXQiOjE1ODA0ODA2MTJ9.pMQLTbSDHRca4_yoj_Y9HWoU9ZUmxEWo9zcN0ygxG58" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 23, 48, 127, 36, 79, 225, 68, 57, 167, 41, 126, 36, 178, 119, 22, 52, 68, 57, 155, 2, 220, 26, 136, 251, 153, 254, 140, 67, 186, 130, 7, 142, 29, 140, 166, 104, 61, 15, 236, 167, 244, 249, 61, 54, 159, 89, 253, 202, 212, 181, 53, 65, 37, 95, 202, 68, 149, 36, 45, 243, 87, 229, 75, 103 }, new byte[] { 176, 123, 201, 236, 106, 75, 140, 148, 116, 160, 238, 213, 231, 31, 75, 7, 102, 45, 24, 110, 170, 88, 41, 174, 110, 65, 107, 154, 241, 107, 102, 240, 218, 254, 210, 240, 92, 235, 91, 204, 214, 105, 102, 11, 80, 138, 87, 142, 232, 6, 62, 146, 237, 51, 135, 15, 55, 227, 103, 6, 5, 35, 71, 68, 29, 158, 248, 196, 119, 176, 90, 152, 229, 221, 250, 157, 248, 127, 141, 246, 234, 23, 69, 218, 37, 240, 167, 70, 62, 159, 238, 174, 213, 148, 216, 167, 207, 193, 130, 192, 114, 40, 128, 212, 178, 52, 227, 158, 240, 1, 158, 175, 54, 81, 121, 157, 95, 105, 250, 19, 10, 192, 149, 206, 243, 93, 53, 4 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjQ1Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MDQ4MDYxMiwiZXhwIjoxNTgxMDg1NDEyLCJpYXQiOjE1ODA0ODA2MTJ9.lotvL1e8HE5T0B94xlZ5Fiu8XoYnCyliE7T1ng52x5Q" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 23, 48, 127, 36, 79, 225, 68, 57, 167, 41, 126, 36, 178, 119, 22, 52, 68, 57, 155, 2, 220, 26, 136, 251, 153, 254, 140, 67, 186, 130, 7, 142, 29, 140, 166, 104, 61, 15, 236, 167, 244, 249, 61, 54, 159, 89, 253, 202, 212, 181, 53, 65, 37, 95, 202, 68, 149, 36, 45, 243, 87, 229, 75, 103 }, new byte[] { 176, 123, 201, 236, 106, 75, 140, 148, 116, 160, 238, 213, 231, 31, 75, 7, 102, 45, 24, 110, 170, 88, 41, 174, 110, 65, 107, 154, 241, 107, 102, 240, 218, 254, 210, 240, 92, 235, 91, 204, 214, 105, 102, 11, 80, 138, 87, 142, 232, 6, 62, 146, 237, 51, 135, 15, 55, 227, 103, 6, 5, 35, 71, 68, 29, 158, 248, 196, 119, 176, 90, 152, 229, 221, 250, 157, 248, 127, 141, 246, 234, 23, 69, 218, 37, 240, 167, 70, 62, 159, 238, 174, 213, 148, 216, 167, 207, 193, 130, 192, 114, 40, 128, 212, 178, 52, 227, 158, 240, 1, 158, 175, 54, 81, 121, 157, 95, 105, 250, 19, 10, 192, 149, 206, 243, 93, 53, 4 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjQ2Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MDQ4MDYxMiwiZXhwIjoxNTgxMDg1NDEyLCJpYXQiOjE1ODA0ODA2MTJ9.vMoAvL8glKmjLMtHMHiOkIEBZxcaiiYL--_H-RgzicE" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 23, 48, 127, 36, 79, 225, 68, 57, 167, 41, 126, 36, 178, 119, 22, 52, 68, 57, 155, 2, 220, 26, 136, 251, 153, 254, 140, 67, 186, 130, 7, 142, 29, 140, 166, 104, 61, 15, 236, 167, 244, 249, 61, 54, 159, 89, 253, 202, 212, 181, 53, 65, 37, 95, 202, 68, 149, 36, 45, 243, 87, 229, 75, 103 }, new byte[] { 176, 123, 201, 236, 106, 75, 140, 148, 116, 160, 238, 213, 231, 31, 75, 7, 102, 45, 24, 110, 170, 88, 41, 174, 110, 65, 107, 154, 241, 107, 102, 240, 218, 254, 210, 240, 92, 235, 91, 204, 214, 105, 102, 11, 80, 138, 87, 142, 232, 6, 62, 146, 237, 51, 135, 15, 55, 227, 103, 6, 5, 35, 71, 68, 29, 158, 248, 196, 119, 176, 90, 152, 229, 221, 250, 157, 248, 127, 141, 246, 234, 23, 69, 218, 37, 240, 167, 70, 62, 159, 238, 174, 213, 148, 216, 167, 207, 193, 130, 192, 114, 40, 128, 212, 178, 52, 227, 158, 240, 1, 158, 175, 54, 81, 121, 157, 95, 105, 250, 19, 10, 192, 149, 206, 243, 93, 53, 4 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjQ3Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MDQ4MDYxMiwiZXhwIjoxNTgxMDg1NDEyLCJpYXQiOjE1ODA0ODA2MTJ9.REDXvRZfoL7JxcugPmG4XxSQNgydfWWf2lKRAMXWLjg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 23, 48, 127, 36, 79, 225, 68, 57, 167, 41, 126, 36, 178, 119, 22, 52, 68, 57, 155, 2, 220, 26, 136, 251, 153, 254, 140, 67, 186, 130, 7, 142, 29, 140, 166, 104, 61, 15, 236, 167, 244, 249, 61, 54, 159, 89, 253, 202, 212, 181, 53, 65, 37, 95, 202, 68, 149, 36, 45, 243, 87, 229, 75, 103 }, new byte[] { 176, 123, 201, 236, 106, 75, 140, 148, 116, 160, 238, 213, 231, 31, 75, 7, 102, 45, 24, 110, 170, 88, 41, 174, 110, 65, 107, 154, 241, 107, 102, 240, 218, 254, 210, 240, 92, 235, 91, 204, 214, 105, 102, 11, 80, 138, 87, 142, 232, 6, 62, 146, 237, 51, 135, 15, 55, 227, 103, 6, 5, 35, 71, 68, 29, 158, 248, 196, 119, 176, 90, 152, 229, 221, 250, 157, 248, 127, 141, 246, 234, 23, 69, 218, 37, 240, 167, 70, 62, 159, 238, 174, 213, 148, 216, 167, 207, 193, 130, 192, 114, 40, 128, 212, 178, 52, 227, 158, 240, 1, 158, 175, 54, 81, 121, 157, 95, 105, 250, 19, 10, 192, 149, 206, 243, 93, 53, 4 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjQ4Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MDQ4MDYxMiwiZXhwIjoxNTgxMDg1NDEyLCJpYXQiOjE1ODA0ODA2MTJ9.Vul0lL-z-Hov_yYdomTPbMn-X-egCeMNqPHB2QGeeXI" });

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_AuthorId",
                table: "Messages",
                column: "AuthorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
