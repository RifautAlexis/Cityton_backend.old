using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cityton.Repository.Migrations
{
    public partial class LiveChat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medias_Messages_MessageId",
                table: "Medias");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_AuthorId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Medias_Name",
                table: "Medias");

            migrationBuilder.DropColumn(
                name: "ContainedInId",
                table: "Medias");

            migrationBuilder.DropColumn(
                name: "Extension",
                table: "Medias");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Medias");

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

            migrationBuilder.AlterColumn<int>(
                name: "MessageId",
                table: "Medias",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Medias",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Medias",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4");

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
                values: new object[] { new byte[] { 204, 107, 210, 215, 248, 245, 181, 3, 241, 226, 40, 58, 223, 152, 166, 128, 201, 245, 49, 41, 62, 207, 31, 32, 73, 184, 252, 244, 61, 10, 14, 165, 80, 249, 84, 76, 123, 188, 115, 235, 3, 144, 108, 77, 176, 174, 7, 32, 221, 21, 134, 243, 43, 220, 91, 136, 71, 24, 94, 101, 3, 252, 8, 16 }, new byte[] { 212, 80, 175, 108, 132, 64, 31, 61, 182, 151, 124, 206, 106, 29, 236, 56, 26, 60, 35, 76, 32, 20, 34, 92, 2, 52, 91, 29, 110, 112, 147, 221, 249, 193, 98, 254, 155, 56, 151, 113, 168, 73, 76, 18, 193, 44, 154, 55, 165, 179, 162, 22, 65, 85, 201, 151, 49, 225, 238, 177, 234, 228, 66, 28, 19, 224, 88, 35, 169, 98, 144, 195, 41, 202, 46, 242, 239, 37, 116, 147, 251, 96, 188, 66, 31, 210, 192, 36, 238, 32, 13, 38, 113, 52, 74, 165, 18, 218, 56, 101, 229, 213, 165, 30, 47, 109, 121, 166, 58, 119, 254, 78, 54, 12, 154, 34, 244, 91, 51, 113, 135, 162, 142, 75, 119, 190, 221, 156 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjEiLCJyb2xlIjoiQWRtaW4iLCJuYmYiOjE1ODMzNTMyNDAsImV4cCI6MTU4Mzk1ODA0MCwiaWF0IjoxNTgzMzUzMjQwfQ.LPbAULwvbIs6B4dYCrGKWEx8lCNEW1UPXs93p8dnmBs" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 204, 107, 210, 215, 248, 245, 181, 3, 241, 226, 40, 58, 223, 152, 166, 128, 201, 245, 49, 41, 62, 207, 31, 32, 73, 184, 252, 244, 61, 10, 14, 165, 80, 249, 84, 76, 123, 188, 115, 235, 3, 144, 108, 77, 176, 174, 7, 32, 221, 21, 134, 243, 43, 220, 91, 136, 71, 24, 94, 101, 3, 252, 8, 16 }, new byte[] { 212, 80, 175, 108, 132, 64, 31, 61, 182, 151, 124, 206, 106, 29, 236, 56, 26, 60, 35, 76, 32, 20, 34, 92, 2, 52, 91, 29, 110, 112, 147, 221, 249, 193, 98, 254, 155, 56, 151, 113, 168, 73, 76, 18, 193, 44, 154, 55, 165, 179, 162, 22, 65, 85, 201, 151, 49, 225, 238, 177, 234, 228, 66, 28, 19, 224, 88, 35, 169, 98, 144, 195, 41, 202, 46, 242, 239, 37, 116, 147, 251, 96, 188, 66, 31, 210, 192, 36, 238, 32, 13, 38, 113, 52, 74, 165, 18, 218, 56, 101, 229, 213, 165, 30, 47, 109, 121, 166, 58, 119, 254, 78, 54, 12, 154, 34, 244, 91, 51, 113, 135, 162, 142, 75, 119, 190, 221, 156 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjIiLCJyb2xlIjoiQWRtaW4iLCJuYmYiOjE1ODMzNTMyNDAsImV4cCI6MTU4Mzk1ODA0MCwiaWF0IjoxNTgzMzUzMjQwfQ.uwPMbFmgbKqNKs2FPqQ4cJkCF2_-1bxZvMbQmvL_VTE" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 204, 107, 210, 215, 248, 245, 181, 3, 241, 226, 40, 58, 223, 152, 166, 128, 201, 245, 49, 41, 62, 207, 31, 32, 73, 184, 252, 244, 61, 10, 14, 165, 80, 249, 84, 76, 123, 188, 115, 235, 3, 144, 108, 77, 176, 174, 7, 32, 221, 21, 134, 243, 43, 220, 91, 136, 71, 24, 94, 101, 3, 252, 8, 16 }, new byte[] { 212, 80, 175, 108, 132, 64, 31, 61, 182, 151, 124, 206, 106, 29, 236, 56, 26, 60, 35, 76, 32, 20, 34, 92, 2, 52, 91, 29, 110, 112, 147, 221, 249, 193, 98, 254, 155, 56, 151, 113, 168, 73, 76, 18, 193, 44, 154, 55, 165, 179, 162, 22, 65, 85, 201, 151, 49, 225, 238, 177, 234, 228, 66, 28, 19, 224, 88, 35, 169, 98, 144, 195, 41, 202, 46, 242, 239, 37, 116, 147, 251, 96, 188, 66, 31, 210, 192, 36, 238, 32, 13, 38, 113, 52, 74, 165, 18, 218, 56, 101, 229, 213, 165, 30, 47, 109, 121, 166, 58, 119, 254, 78, 54, 12, 154, 34, 244, 91, 51, 113, 135, 162, 142, 75, 119, 190, 221, 156 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjMiLCJyb2xlIjoiQWRtaW4iLCJuYmYiOjE1ODMzNTMyNDAsImV4cCI6MTU4Mzk1ODA0MCwiaWF0IjoxNTgzMzUzMjQwfQ.ZcvzZjLW1vuVeThJb3Uff6uzIRFrQkmCNBQmk-X3AVI" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 204, 107, 210, 215, 248, 245, 181, 3, 241, 226, 40, 58, 223, 152, 166, 128, 201, 245, 49, 41, 62, 207, 31, 32, 73, 184, 252, 244, 61, 10, 14, 165, 80, 249, 84, 76, 123, 188, 115, 235, 3, 144, 108, 77, 176, 174, 7, 32, 221, 21, 134, 243, 43, 220, 91, 136, 71, 24, 94, 101, 3, 252, 8, 16 }, new byte[] { 212, 80, 175, 108, 132, 64, 31, 61, 182, 151, 124, 206, 106, 29, 236, 56, 26, 60, 35, 76, 32, 20, 34, 92, 2, 52, 91, 29, 110, 112, 147, 221, 249, 193, 98, 254, 155, 56, 151, 113, 168, 73, 76, 18, 193, 44, 154, 55, 165, 179, 162, 22, 65, 85, 201, 151, 49, 225, 238, 177, 234, 228, 66, 28, 19, 224, 88, 35, 169, 98, 144, 195, 41, 202, 46, 242, 239, 37, 116, 147, 251, 96, 188, 66, 31, 210, 192, 36, 238, 32, 13, 38, 113, 52, 74, 165, 18, 218, 56, 101, 229, 213, 165, 30, 47, 109, 121, 166, 58, 119, 254, 78, 54, 12, 154, 34, 244, 91, 51, 113, 135, 162, 142, 75, 119, 190, 221, 156 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjQiLCJyb2xlIjoiQWRtaW4iLCJuYmYiOjE1ODMzNTMyNDAsImV4cCI6MTU4Mzk1ODA0MCwiaWF0IjoxNTgzMzUzMjQwfQ.vYoRf_w_9qotHvusvB0793OcWO3jYnKL4Z_mvTyI_QU" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 204, 107, 210, 215, 248, 245, 181, 3, 241, 226, 40, 58, 223, 152, 166, 128, 201, 245, 49, 41, 62, 207, 31, 32, 73, 184, 252, 244, 61, 10, 14, 165, 80, 249, 84, 76, 123, 188, 115, 235, 3, 144, 108, 77, 176, 174, 7, 32, 221, 21, 134, 243, 43, 220, 91, 136, 71, 24, 94, 101, 3, 252, 8, 16 }, new byte[] { 212, 80, 175, 108, 132, 64, 31, 61, 182, 151, 124, 206, 106, 29, 236, 56, 26, 60, 35, 76, 32, 20, 34, 92, 2, 52, 91, 29, 110, 112, 147, 221, 249, 193, 98, 254, 155, 56, 151, 113, 168, 73, 76, 18, 193, 44, 154, 55, 165, 179, 162, 22, 65, 85, 201, 151, 49, 225, 238, 177, 234, 228, 66, 28, 19, 224, 88, 35, 169, 98, 144, 195, 41, 202, 46, 242, 239, 37, 116, 147, 251, 96, 188, 66, 31, 210, 192, 36, 238, 32, 13, 38, 113, 52, 74, 165, 18, 218, 56, 101, 229, 213, 165, 30, 47, 109, 121, 166, 58, 119, 254, 78, 54, 12, 154, 34, 244, 91, 51, 113, 135, 162, 142, 75, 119, 190, 221, 156 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjUiLCJyb2xlIjoiQWRtaW4iLCJuYmYiOjE1ODMzNTMyNDAsImV4cCI6MTU4Mzk1ODA0MCwiaWF0IjoxNTgzMzUzMjQwfQ.4zoMON-3Gwu1Kho8CL7NBZcts0OCReT1q0mxLtu-Tic" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 204, 107, 210, 215, 248, 245, 181, 3, 241, 226, 40, 58, 223, 152, 166, 128, 201, 245, 49, 41, 62, 207, 31, 32, 73, 184, 252, 244, 61, 10, 14, 165, 80, 249, 84, 76, 123, 188, 115, 235, 3, 144, 108, 77, 176, 174, 7, 32, 221, 21, 134, 243, 43, 220, 91, 136, 71, 24, 94, 101, 3, 252, 8, 16 }, new byte[] { 212, 80, 175, 108, 132, 64, 31, 61, 182, 151, 124, 206, 106, 29, 236, 56, 26, 60, 35, 76, 32, 20, 34, 92, 2, 52, 91, 29, 110, 112, 147, 221, 249, 193, 98, 254, 155, 56, 151, 113, 168, 73, 76, 18, 193, 44, 154, 55, 165, 179, 162, 22, 65, 85, 201, 151, 49, 225, 238, 177, 234, 228, 66, 28, 19, 224, 88, 35, 169, 98, 144, 195, 41, 202, 46, 242, 239, 37, 116, 147, 251, 96, 188, 66, 31, 210, 192, 36, 238, 32, 13, 38, 113, 52, 74, 165, 18, 218, 56, 101, 229, 213, 165, 30, 47, 109, 121, 166, 58, 119, 254, 78, 54, 12, 154, 34, 244, 91, 51, 113, 135, 162, 142, 75, 119, 190, 221, 156 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjYiLCJyb2xlIjoiQ2hlY2tlciIsIm5iZiI6MTU4MzM1MzI0MCwiZXhwIjoxNTgzOTU4MDQwLCJpYXQiOjE1ODMzNTMyNDB9.f_TtUhr4uy04yXIqXWbXRKCE2nAKpaVvDaGZ7R8emGk" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 204, 107, 210, 215, 248, 245, 181, 3, 241, 226, 40, 58, 223, 152, 166, 128, 201, 245, 49, 41, 62, 207, 31, 32, 73, 184, 252, 244, 61, 10, 14, 165, 80, 249, 84, 76, 123, 188, 115, 235, 3, 144, 108, 77, 176, 174, 7, 32, 221, 21, 134, 243, 43, 220, 91, 136, 71, 24, 94, 101, 3, 252, 8, 16 }, new byte[] { 212, 80, 175, 108, 132, 64, 31, 61, 182, 151, 124, 206, 106, 29, 236, 56, 26, 60, 35, 76, 32, 20, 34, 92, 2, 52, 91, 29, 110, 112, 147, 221, 249, 193, 98, 254, 155, 56, 151, 113, 168, 73, 76, 18, 193, 44, 154, 55, 165, 179, 162, 22, 65, 85, 201, 151, 49, 225, 238, 177, 234, 228, 66, 28, 19, 224, 88, 35, 169, 98, 144, 195, 41, 202, 46, 242, 239, 37, 116, 147, 251, 96, 188, 66, 31, 210, 192, 36, 238, 32, 13, 38, 113, 52, 74, 165, 18, 218, 56, 101, 229, 213, 165, 30, 47, 109, 121, 166, 58, 119, 254, 78, 54, 12, 154, 34, 244, 91, 51, 113, 135, 162, 142, 75, 119, 190, 221, 156 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjciLCJyb2xlIjoiQ2hlY2tlciIsIm5iZiI6MTU4MzM1MzI0MCwiZXhwIjoxNTgzOTU4MDQwLCJpYXQiOjE1ODMzNTMyNDB9.Tjd_nzCkeSJSeOBI4sGuwY_Y4hCf5ccNyWMlocZ2K90" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 204, 107, 210, 215, 248, 245, 181, 3, 241, 226, 40, 58, 223, 152, 166, 128, 201, 245, 49, 41, 62, 207, 31, 32, 73, 184, 252, 244, 61, 10, 14, 165, 80, 249, 84, 76, 123, 188, 115, 235, 3, 144, 108, 77, 176, 174, 7, 32, 221, 21, 134, 243, 43, 220, 91, 136, 71, 24, 94, 101, 3, 252, 8, 16 }, new byte[] { 212, 80, 175, 108, 132, 64, 31, 61, 182, 151, 124, 206, 106, 29, 236, 56, 26, 60, 35, 76, 32, 20, 34, 92, 2, 52, 91, 29, 110, 112, 147, 221, 249, 193, 98, 254, 155, 56, 151, 113, 168, 73, 76, 18, 193, 44, 154, 55, 165, 179, 162, 22, 65, 85, 201, 151, 49, 225, 238, 177, 234, 228, 66, 28, 19, 224, 88, 35, 169, 98, 144, 195, 41, 202, 46, 242, 239, 37, 116, 147, 251, 96, 188, 66, 31, 210, 192, 36, 238, 32, 13, 38, 113, 52, 74, 165, 18, 218, 56, 101, 229, 213, 165, 30, 47, 109, 121, 166, 58, 119, 254, 78, 54, 12, 154, 34, 244, 91, 51, 113, 135, 162, 142, 75, 119, 190, 221, 156 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjgiLCJyb2xlIjoiQ2hlY2tlciIsIm5iZiI6MTU4MzM1MzI0MCwiZXhwIjoxNTgzOTU4MDQwLCJpYXQiOjE1ODMzNTMyNDB9.QlK0qTZxh1Va0H9uerKlqaSu0HIrtX0937qiLLHdhCk" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 204, 107, 210, 215, 248, 245, 181, 3, 241, 226, 40, 58, 223, 152, 166, 128, 201, 245, 49, 41, 62, 207, 31, 32, 73, 184, 252, 244, 61, 10, 14, 165, 80, 249, 84, 76, 123, 188, 115, 235, 3, 144, 108, 77, 176, 174, 7, 32, 221, 21, 134, 243, 43, 220, 91, 136, 71, 24, 94, 101, 3, 252, 8, 16 }, new byte[] { 212, 80, 175, 108, 132, 64, 31, 61, 182, 151, 124, 206, 106, 29, 236, 56, 26, 60, 35, 76, 32, 20, 34, 92, 2, 52, 91, 29, 110, 112, 147, 221, 249, 193, 98, 254, 155, 56, 151, 113, 168, 73, 76, 18, 193, 44, 154, 55, 165, 179, 162, 22, 65, 85, 201, 151, 49, 225, 238, 177, 234, 228, 66, 28, 19, 224, 88, 35, 169, 98, 144, 195, 41, 202, 46, 242, 239, 37, 116, 147, 251, 96, 188, 66, 31, 210, 192, 36, 238, 32, 13, 38, 113, 52, 74, 165, 18, 218, 56, 101, 229, 213, 165, 30, 47, 109, 121, 166, 58, 119, 254, 78, 54, 12, 154, 34, 244, 91, 51, 113, 135, 162, 142, 75, 119, 190, 221, 156 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjkiLCJyb2xlIjoiTWVtYmVyIiwibmJmIjoxNTgzMzUzMjQwLCJleHAiOjE1ODM5NTgwNDAsImlhdCI6MTU4MzM1MzI0MH0.ypPbuOr9sYul3klK18w7QSKJAL9Uxdl4gvCtjCxyvKk" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 204, 107, 210, 215, 248, 245, 181, 3, 241, 226, 40, 58, 223, 152, 166, 128, 201, 245, 49, 41, 62, 207, 31, 32, 73, 184, 252, 244, 61, 10, 14, 165, 80, 249, 84, 76, 123, 188, 115, 235, 3, 144, 108, 77, 176, 174, 7, 32, 221, 21, 134, 243, 43, 220, 91, 136, 71, 24, 94, 101, 3, 252, 8, 16 }, new byte[] { 212, 80, 175, 108, 132, 64, 31, 61, 182, 151, 124, 206, 106, 29, 236, 56, 26, 60, 35, 76, 32, 20, 34, 92, 2, 52, 91, 29, 110, 112, 147, 221, 249, 193, 98, 254, 155, 56, 151, 113, 168, 73, 76, 18, 193, 44, 154, 55, 165, 179, 162, 22, 65, 85, 201, 151, 49, 225, 238, 177, 234, 228, 66, 28, 19, 224, 88, 35, 169, 98, 144, 195, 41, 202, 46, 242, 239, 37, 116, 147, 251, 96, 188, 66, 31, 210, 192, 36, 238, 32, 13, 38, 113, 52, 74, 165, 18, 218, 56, 101, 229, 213, 165, 30, 47, 109, 121, 166, 58, 119, 254, 78, 54, 12, 154, 34, 244, 91, 51, 113, 135, 162, 142, 75, 119, 190, 221, 156 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjEwIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzM1MzI0MCwiZXhwIjoxNTgzOTU4MDQwLCJpYXQiOjE1ODMzNTMyNDB9.udwfapbK7Xlg3zrhqaOVmZzTz4loyI2Z3dVShN-a6-I" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 204, 107, 210, 215, 248, 245, 181, 3, 241, 226, 40, 58, 223, 152, 166, 128, 201, 245, 49, 41, 62, 207, 31, 32, 73, 184, 252, 244, 61, 10, 14, 165, 80, 249, 84, 76, 123, 188, 115, 235, 3, 144, 108, 77, 176, 174, 7, 32, 221, 21, 134, 243, 43, 220, 91, 136, 71, 24, 94, 101, 3, 252, 8, 16 }, new byte[] { 212, 80, 175, 108, 132, 64, 31, 61, 182, 151, 124, 206, 106, 29, 236, 56, 26, 60, 35, 76, 32, 20, 34, 92, 2, 52, 91, 29, 110, 112, 147, 221, 249, 193, 98, 254, 155, 56, 151, 113, 168, 73, 76, 18, 193, 44, 154, 55, 165, 179, 162, 22, 65, 85, 201, 151, 49, 225, 238, 177, 234, 228, 66, 28, 19, 224, 88, 35, 169, 98, 144, 195, 41, 202, 46, 242, 239, 37, 116, 147, 251, 96, 188, 66, 31, 210, 192, 36, 238, 32, 13, 38, 113, 52, 74, 165, 18, 218, 56, 101, 229, 213, 165, 30, 47, 109, 121, 166, 58, 119, 254, 78, 54, 12, 154, 34, 244, 91, 51, 113, 135, 162, 142, 75, 119, 190, 221, 156 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjExIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzM1MzI0MCwiZXhwIjoxNTgzOTU4MDQwLCJpYXQiOjE1ODMzNTMyNDB9.2yyOT8GtM3sdu6Cm5TFd_XDk9uR4r11zGeJJ9-LcaFI" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 204, 107, 210, 215, 248, 245, 181, 3, 241, 226, 40, 58, 223, 152, 166, 128, 201, 245, 49, 41, 62, 207, 31, 32, 73, 184, 252, 244, 61, 10, 14, 165, 80, 249, 84, 76, 123, 188, 115, 235, 3, 144, 108, 77, 176, 174, 7, 32, 221, 21, 134, 243, 43, 220, 91, 136, 71, 24, 94, 101, 3, 252, 8, 16 }, new byte[] { 212, 80, 175, 108, 132, 64, 31, 61, 182, 151, 124, 206, 106, 29, 236, 56, 26, 60, 35, 76, 32, 20, 34, 92, 2, 52, 91, 29, 110, 112, 147, 221, 249, 193, 98, 254, 155, 56, 151, 113, 168, 73, 76, 18, 193, 44, 154, 55, 165, 179, 162, 22, 65, 85, 201, 151, 49, 225, 238, 177, 234, 228, 66, 28, 19, 224, 88, 35, 169, 98, 144, 195, 41, 202, 46, 242, 239, 37, 116, 147, 251, 96, 188, 66, 31, 210, 192, 36, 238, 32, 13, 38, 113, 52, 74, 165, 18, 218, 56, 101, 229, 213, 165, 30, 47, 109, 121, 166, 58, 119, 254, 78, 54, 12, 154, 34, 244, 91, 51, 113, 135, 162, 142, 75, 119, 190, 221, 156 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjEyIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzM1MzI0MCwiZXhwIjoxNTgzOTU4MDQwLCJpYXQiOjE1ODMzNTMyNDB9.IvIJBTHncrh6VgXhGanrOVf3MW1MY4VU7dh6eU6XW_4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 204, 107, 210, 215, 248, 245, 181, 3, 241, 226, 40, 58, 223, 152, 166, 128, 201, 245, 49, 41, 62, 207, 31, 32, 73, 184, 252, 244, 61, 10, 14, 165, 80, 249, 84, 76, 123, 188, 115, 235, 3, 144, 108, 77, 176, 174, 7, 32, 221, 21, 134, 243, 43, 220, 91, 136, 71, 24, 94, 101, 3, 252, 8, 16 }, new byte[] { 212, 80, 175, 108, 132, 64, 31, 61, 182, 151, 124, 206, 106, 29, 236, 56, 26, 60, 35, 76, 32, 20, 34, 92, 2, 52, 91, 29, 110, 112, 147, 221, 249, 193, 98, 254, 155, 56, 151, 113, 168, 73, 76, 18, 193, 44, 154, 55, 165, 179, 162, 22, 65, 85, 201, 151, 49, 225, 238, 177, 234, 228, 66, 28, 19, 224, 88, 35, 169, 98, 144, 195, 41, 202, 46, 242, 239, 37, 116, 147, 251, 96, 188, 66, 31, 210, 192, 36, 238, 32, 13, 38, 113, 52, 74, 165, 18, 218, 56, 101, 229, 213, 165, 30, 47, 109, 121, 166, 58, 119, 254, 78, 54, 12, 154, 34, 244, 91, 51, 113, 135, 162, 142, 75, 119, 190, 221, 156 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjEzIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzM1MzI0MCwiZXhwIjoxNTgzOTU4MDQwLCJpYXQiOjE1ODMzNTMyNDB9.gDzDXU9S3PSLz94C9hdTJt50aElBnl5ai-KobQEKacM" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 204, 107, 210, 215, 248, 245, 181, 3, 241, 226, 40, 58, 223, 152, 166, 128, 201, 245, 49, 41, 62, 207, 31, 32, 73, 184, 252, 244, 61, 10, 14, 165, 80, 249, 84, 76, 123, 188, 115, 235, 3, 144, 108, 77, 176, 174, 7, 32, 221, 21, 134, 243, 43, 220, 91, 136, 71, 24, 94, 101, 3, 252, 8, 16 }, new byte[] { 212, 80, 175, 108, 132, 64, 31, 61, 182, 151, 124, 206, 106, 29, 236, 56, 26, 60, 35, 76, 32, 20, 34, 92, 2, 52, 91, 29, 110, 112, 147, 221, 249, 193, 98, 254, 155, 56, 151, 113, 168, 73, 76, 18, 193, 44, 154, 55, 165, 179, 162, 22, 65, 85, 201, 151, 49, 225, 238, 177, 234, 228, 66, 28, 19, 224, 88, 35, 169, 98, 144, 195, 41, 202, 46, 242, 239, 37, 116, 147, 251, 96, 188, 66, 31, 210, 192, 36, 238, 32, 13, 38, 113, 52, 74, 165, 18, 218, 56, 101, 229, 213, 165, 30, 47, 109, 121, 166, 58, 119, 254, 78, 54, 12, 154, 34, 244, 91, 51, 113, 135, 162, 142, 75, 119, 190, 221, 156 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjE0Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzM1MzI0MCwiZXhwIjoxNTgzOTU4MDQwLCJpYXQiOjE1ODMzNTMyNDB9.YZfc_1r_M9B__L4619tZyFuIW4NFfaZ7pi8uz7KZlhw" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 204, 107, 210, 215, 248, 245, 181, 3, 241, 226, 40, 58, 223, 152, 166, 128, 201, 245, 49, 41, 62, 207, 31, 32, 73, 184, 252, 244, 61, 10, 14, 165, 80, 249, 84, 76, 123, 188, 115, 235, 3, 144, 108, 77, 176, 174, 7, 32, 221, 21, 134, 243, 43, 220, 91, 136, 71, 24, 94, 101, 3, 252, 8, 16 }, new byte[] { 212, 80, 175, 108, 132, 64, 31, 61, 182, 151, 124, 206, 106, 29, 236, 56, 26, 60, 35, 76, 32, 20, 34, 92, 2, 52, 91, 29, 110, 112, 147, 221, 249, 193, 98, 254, 155, 56, 151, 113, 168, 73, 76, 18, 193, 44, 154, 55, 165, 179, 162, 22, 65, 85, 201, 151, 49, 225, 238, 177, 234, 228, 66, 28, 19, 224, 88, 35, 169, 98, 144, 195, 41, 202, 46, 242, 239, 37, 116, 147, 251, 96, 188, 66, 31, 210, 192, 36, 238, 32, 13, 38, 113, 52, 74, 165, 18, 218, 56, 101, 229, 213, 165, 30, 47, 109, 121, 166, 58, 119, 254, 78, 54, 12, 154, 34, 244, 91, 51, 113, 135, 162, 142, 75, 119, 190, 221, 156 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjE1Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzM1MzI0MCwiZXhwIjoxNTgzOTU4MDQwLCJpYXQiOjE1ODMzNTMyNDB9.D5h2xmE7qI6r04Q-zybgpx2qkuxwAQ8n_VminFqYA38" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 204, 107, 210, 215, 248, 245, 181, 3, 241, 226, 40, 58, 223, 152, 166, 128, 201, 245, 49, 41, 62, 207, 31, 32, 73, 184, 252, 244, 61, 10, 14, 165, 80, 249, 84, 76, 123, 188, 115, 235, 3, 144, 108, 77, 176, 174, 7, 32, 221, 21, 134, 243, 43, 220, 91, 136, 71, 24, 94, 101, 3, 252, 8, 16 }, new byte[] { 212, 80, 175, 108, 132, 64, 31, 61, 182, 151, 124, 206, 106, 29, 236, 56, 26, 60, 35, 76, 32, 20, 34, 92, 2, 52, 91, 29, 110, 112, 147, 221, 249, 193, 98, 254, 155, 56, 151, 113, 168, 73, 76, 18, 193, 44, 154, 55, 165, 179, 162, 22, 65, 85, 201, 151, 49, 225, 238, 177, 234, 228, 66, 28, 19, 224, 88, 35, 169, 98, 144, 195, 41, 202, 46, 242, 239, 37, 116, 147, 251, 96, 188, 66, 31, 210, 192, 36, 238, 32, 13, 38, 113, 52, 74, 165, 18, 218, 56, 101, 229, 213, 165, 30, 47, 109, 121, 166, 58, 119, 254, 78, 54, 12, 154, 34, 244, 91, 51, 113, 135, 162, 142, 75, 119, 190, 221, 156 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjE2Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzM1MzI0MCwiZXhwIjoxNTgzOTU4MDQwLCJpYXQiOjE1ODMzNTMyNDB9.drOd7odVGmLV8O-2cBo1Wum6V0M_MVoeiGNPhTkZpA8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 204, 107, 210, 215, 248, 245, 181, 3, 241, 226, 40, 58, 223, 152, 166, 128, 201, 245, 49, 41, 62, 207, 31, 32, 73, 184, 252, 244, 61, 10, 14, 165, 80, 249, 84, 76, 123, 188, 115, 235, 3, 144, 108, 77, 176, 174, 7, 32, 221, 21, 134, 243, 43, 220, 91, 136, 71, 24, 94, 101, 3, 252, 8, 16 }, new byte[] { 212, 80, 175, 108, 132, 64, 31, 61, 182, 151, 124, 206, 106, 29, 236, 56, 26, 60, 35, 76, 32, 20, 34, 92, 2, 52, 91, 29, 110, 112, 147, 221, 249, 193, 98, 254, 155, 56, 151, 113, 168, 73, 76, 18, 193, 44, 154, 55, 165, 179, 162, 22, 65, 85, 201, 151, 49, 225, 238, 177, 234, 228, 66, 28, 19, 224, 88, 35, 169, 98, 144, 195, 41, 202, 46, 242, 239, 37, 116, 147, 251, 96, 188, 66, 31, 210, 192, 36, 238, 32, 13, 38, 113, 52, 74, 165, 18, 218, 56, 101, 229, 213, 165, 30, 47, 109, 121, 166, 58, 119, 254, 78, 54, 12, 154, 34, 244, 91, 51, 113, 135, 162, 142, 75, 119, 190, 221, 156 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjE3Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzM1MzI0MCwiZXhwIjoxNTgzOTU4MDQwLCJpYXQiOjE1ODMzNTMyNDB9.C8JNiRWUffAAqBsI0LCbUPmMe4nKRpM97g8k7XqCOE0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 204, 107, 210, 215, 248, 245, 181, 3, 241, 226, 40, 58, 223, 152, 166, 128, 201, 245, 49, 41, 62, 207, 31, 32, 73, 184, 252, 244, 61, 10, 14, 165, 80, 249, 84, 76, 123, 188, 115, 235, 3, 144, 108, 77, 176, 174, 7, 32, 221, 21, 134, 243, 43, 220, 91, 136, 71, 24, 94, 101, 3, 252, 8, 16 }, new byte[] { 212, 80, 175, 108, 132, 64, 31, 61, 182, 151, 124, 206, 106, 29, 236, 56, 26, 60, 35, 76, 32, 20, 34, 92, 2, 52, 91, 29, 110, 112, 147, 221, 249, 193, 98, 254, 155, 56, 151, 113, 168, 73, 76, 18, 193, 44, 154, 55, 165, 179, 162, 22, 65, 85, 201, 151, 49, 225, 238, 177, 234, 228, 66, 28, 19, 224, 88, 35, 169, 98, 144, 195, 41, 202, 46, 242, 239, 37, 116, 147, 251, 96, 188, 66, 31, 210, 192, 36, 238, 32, 13, 38, 113, 52, 74, 165, 18, 218, 56, 101, 229, 213, 165, 30, 47, 109, 121, 166, 58, 119, 254, 78, 54, 12, 154, 34, 244, 91, 51, 113, 135, 162, 142, 75, 119, 190, 221, 156 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjE4Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzM1MzI0MCwiZXhwIjoxNTgzOTU4MDQwLCJpYXQiOjE1ODMzNTMyNDB9.c8_Q2w7N5Xo1qM3-C4Y4iUDyUPO88le3K_hFQeqoQwk" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 204, 107, 210, 215, 248, 245, 181, 3, 241, 226, 40, 58, 223, 152, 166, 128, 201, 245, 49, 41, 62, 207, 31, 32, 73, 184, 252, 244, 61, 10, 14, 165, 80, 249, 84, 76, 123, 188, 115, 235, 3, 144, 108, 77, 176, 174, 7, 32, 221, 21, 134, 243, 43, 220, 91, 136, 71, 24, 94, 101, 3, 252, 8, 16 }, new byte[] { 212, 80, 175, 108, 132, 64, 31, 61, 182, 151, 124, 206, 106, 29, 236, 56, 26, 60, 35, 76, 32, 20, 34, 92, 2, 52, 91, 29, 110, 112, 147, 221, 249, 193, 98, 254, 155, 56, 151, 113, 168, 73, 76, 18, 193, 44, 154, 55, 165, 179, 162, 22, 65, 85, 201, 151, 49, 225, 238, 177, 234, 228, 66, 28, 19, 224, 88, 35, 169, 98, 144, 195, 41, 202, 46, 242, 239, 37, 116, 147, 251, 96, 188, 66, 31, 210, 192, 36, 238, 32, 13, 38, 113, 52, 74, 165, 18, 218, 56, 101, 229, 213, 165, 30, 47, 109, 121, 166, 58, 119, 254, 78, 54, 12, 154, 34, 244, 91, 51, 113, 135, 162, 142, 75, 119, 190, 221, 156 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjE5Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzM1MzI0MCwiZXhwIjoxNTgzOTU4MDQwLCJpYXQiOjE1ODMzNTMyNDB9.vuaYRfUEu2TsDSpDEcvplTHY_IOKyPUg_z2lln20Shg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 204, 107, 210, 215, 248, 245, 181, 3, 241, 226, 40, 58, 223, 152, 166, 128, 201, 245, 49, 41, 62, 207, 31, 32, 73, 184, 252, 244, 61, 10, 14, 165, 80, 249, 84, 76, 123, 188, 115, 235, 3, 144, 108, 77, 176, 174, 7, 32, 221, 21, 134, 243, 43, 220, 91, 136, 71, 24, 94, 101, 3, 252, 8, 16 }, new byte[] { 212, 80, 175, 108, 132, 64, 31, 61, 182, 151, 124, 206, 106, 29, 236, 56, 26, 60, 35, 76, 32, 20, 34, 92, 2, 52, 91, 29, 110, 112, 147, 221, 249, 193, 98, 254, 155, 56, 151, 113, 168, 73, 76, 18, 193, 44, 154, 55, 165, 179, 162, 22, 65, 85, 201, 151, 49, 225, 238, 177, 234, 228, 66, 28, 19, 224, 88, 35, 169, 98, 144, 195, 41, 202, 46, 242, 239, 37, 116, 147, 251, 96, 188, 66, 31, 210, 192, 36, 238, 32, 13, 38, 113, 52, 74, 165, 18, 218, 56, 101, 229, 213, 165, 30, 47, 109, 121, 166, 58, 119, 254, 78, 54, 12, 154, 34, 244, 91, 51, 113, 135, 162, 142, 75, 119, 190, 221, 156 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjIwIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzM1MzI0MCwiZXhwIjoxNTgzOTU4MDQwLCJpYXQiOjE1ODMzNTMyNDB9.otXMS2TXMLixK-l6zykL3eNn5rEiLXmbMG7M33dvhJw" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 204, 107, 210, 215, 248, 245, 181, 3, 241, 226, 40, 58, 223, 152, 166, 128, 201, 245, 49, 41, 62, 207, 31, 32, 73, 184, 252, 244, 61, 10, 14, 165, 80, 249, 84, 76, 123, 188, 115, 235, 3, 144, 108, 77, 176, 174, 7, 32, 221, 21, 134, 243, 43, 220, 91, 136, 71, 24, 94, 101, 3, 252, 8, 16 }, new byte[] { 212, 80, 175, 108, 132, 64, 31, 61, 182, 151, 124, 206, 106, 29, 236, 56, 26, 60, 35, 76, 32, 20, 34, 92, 2, 52, 91, 29, 110, 112, 147, 221, 249, 193, 98, 254, 155, 56, 151, 113, 168, 73, 76, 18, 193, 44, 154, 55, 165, 179, 162, 22, 65, 85, 201, 151, 49, 225, 238, 177, 234, 228, 66, 28, 19, 224, 88, 35, 169, 98, 144, 195, 41, 202, 46, 242, 239, 37, 116, 147, 251, 96, 188, 66, 31, 210, 192, 36, 238, 32, 13, 38, 113, 52, 74, 165, 18, 218, 56, 101, 229, 213, 165, 30, 47, 109, 121, 166, 58, 119, 254, 78, 54, 12, 154, 34, 244, 91, 51, 113, 135, 162, 142, 75, 119, 190, 221, 156 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjIxIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzM1MzI0MCwiZXhwIjoxNTgzOTU4MDQwLCJpYXQiOjE1ODMzNTMyNDB9.NdRM0QKn4z4pAzLSZNC1r0WnammbERggspz4SqnMYJs" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 204, 107, 210, 215, 248, 245, 181, 3, 241, 226, 40, 58, 223, 152, 166, 128, 201, 245, 49, 41, 62, 207, 31, 32, 73, 184, 252, 244, 61, 10, 14, 165, 80, 249, 84, 76, 123, 188, 115, 235, 3, 144, 108, 77, 176, 174, 7, 32, 221, 21, 134, 243, 43, 220, 91, 136, 71, 24, 94, 101, 3, 252, 8, 16 }, new byte[] { 212, 80, 175, 108, 132, 64, 31, 61, 182, 151, 124, 206, 106, 29, 236, 56, 26, 60, 35, 76, 32, 20, 34, 92, 2, 52, 91, 29, 110, 112, 147, 221, 249, 193, 98, 254, 155, 56, 151, 113, 168, 73, 76, 18, 193, 44, 154, 55, 165, 179, 162, 22, 65, 85, 201, 151, 49, 225, 238, 177, 234, 228, 66, 28, 19, 224, 88, 35, 169, 98, 144, 195, 41, 202, 46, 242, 239, 37, 116, 147, 251, 96, 188, 66, 31, 210, 192, 36, 238, 32, 13, 38, 113, 52, 74, 165, 18, 218, 56, 101, 229, 213, 165, 30, 47, 109, 121, 166, 58, 119, 254, 78, 54, 12, 154, 34, 244, 91, 51, 113, 135, 162, 142, 75, 119, 190, 221, 156 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjIyIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzM1MzI0MCwiZXhwIjoxNTgzOTU4MDQwLCJpYXQiOjE1ODMzNTMyNDB9.TiR790krCTFwtMUKpTjo2OE-dO7mVTtQCFkE0YRPaHU" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 204, 107, 210, 215, 248, 245, 181, 3, 241, 226, 40, 58, 223, 152, 166, 128, 201, 245, 49, 41, 62, 207, 31, 32, 73, 184, 252, 244, 61, 10, 14, 165, 80, 249, 84, 76, 123, 188, 115, 235, 3, 144, 108, 77, 176, 174, 7, 32, 221, 21, 134, 243, 43, 220, 91, 136, 71, 24, 94, 101, 3, 252, 8, 16 }, new byte[] { 212, 80, 175, 108, 132, 64, 31, 61, 182, 151, 124, 206, 106, 29, 236, 56, 26, 60, 35, 76, 32, 20, 34, 92, 2, 52, 91, 29, 110, 112, 147, 221, 249, 193, 98, 254, 155, 56, 151, 113, 168, 73, 76, 18, 193, 44, 154, 55, 165, 179, 162, 22, 65, 85, 201, 151, 49, 225, 238, 177, 234, 228, 66, 28, 19, 224, 88, 35, 169, 98, 144, 195, 41, 202, 46, 242, 239, 37, 116, 147, 251, 96, 188, 66, 31, 210, 192, 36, 238, 32, 13, 38, 113, 52, 74, 165, 18, 218, 56, 101, 229, 213, 165, 30, 47, 109, 121, 166, 58, 119, 254, 78, 54, 12, 154, 34, 244, 91, 51, 113, 135, 162, 142, 75, 119, 190, 221, 156 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjIzIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzM1MzI0MCwiZXhwIjoxNTgzOTU4MDQwLCJpYXQiOjE1ODMzNTMyNDB9.Lzo2Nh87dCg_X2keW7xFLFEamXqgws0dQGDVWc_eF0U" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 204, 107, 210, 215, 248, 245, 181, 3, 241, 226, 40, 58, 223, 152, 166, 128, 201, 245, 49, 41, 62, 207, 31, 32, 73, 184, 252, 244, 61, 10, 14, 165, 80, 249, 84, 76, 123, 188, 115, 235, 3, 144, 108, 77, 176, 174, 7, 32, 221, 21, 134, 243, 43, 220, 91, 136, 71, 24, 94, 101, 3, 252, 8, 16 }, new byte[] { 212, 80, 175, 108, 132, 64, 31, 61, 182, 151, 124, 206, 106, 29, 236, 56, 26, 60, 35, 76, 32, 20, 34, 92, 2, 52, 91, 29, 110, 112, 147, 221, 249, 193, 98, 254, 155, 56, 151, 113, 168, 73, 76, 18, 193, 44, 154, 55, 165, 179, 162, 22, 65, 85, 201, 151, 49, 225, 238, 177, 234, 228, 66, 28, 19, 224, 88, 35, 169, 98, 144, 195, 41, 202, 46, 242, 239, 37, 116, 147, 251, 96, 188, 66, 31, 210, 192, 36, 238, 32, 13, 38, 113, 52, 74, 165, 18, 218, 56, 101, 229, 213, 165, 30, 47, 109, 121, 166, 58, 119, 254, 78, 54, 12, 154, 34, 244, 91, 51, 113, 135, 162, 142, 75, 119, 190, 221, 156 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjI0Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzM1MzI0MCwiZXhwIjoxNTgzOTU4MDQwLCJpYXQiOjE1ODMzNTMyNDB9.WHGH2mC2iuqpZVZjCtjlpG6NMxw4MZ3PVo9ouhL3CmA" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 204, 107, 210, 215, 248, 245, 181, 3, 241, 226, 40, 58, 223, 152, 166, 128, 201, 245, 49, 41, 62, 207, 31, 32, 73, 184, 252, 244, 61, 10, 14, 165, 80, 249, 84, 76, 123, 188, 115, 235, 3, 144, 108, 77, 176, 174, 7, 32, 221, 21, 134, 243, 43, 220, 91, 136, 71, 24, 94, 101, 3, 252, 8, 16 }, new byte[] { 212, 80, 175, 108, 132, 64, 31, 61, 182, 151, 124, 206, 106, 29, 236, 56, 26, 60, 35, 76, 32, 20, 34, 92, 2, 52, 91, 29, 110, 112, 147, 221, 249, 193, 98, 254, 155, 56, 151, 113, 168, 73, 76, 18, 193, 44, 154, 55, 165, 179, 162, 22, 65, 85, 201, 151, 49, 225, 238, 177, 234, 228, 66, 28, 19, 224, 88, 35, 169, 98, 144, 195, 41, 202, 46, 242, 239, 37, 116, 147, 251, 96, 188, 66, 31, 210, 192, 36, 238, 32, 13, 38, 113, 52, 74, 165, 18, 218, 56, 101, 229, 213, 165, 30, 47, 109, 121, 166, 58, 119, 254, 78, 54, 12, 154, 34, 244, 91, 51, 113, 135, 162, 142, 75, 119, 190, 221, 156 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjI1Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzM1MzI0MCwiZXhwIjoxNTgzOTU4MDQwLCJpYXQiOjE1ODMzNTMyNDB9.SW1eqNlty3W_vCMlQwrBhvHxmpyG0rjCwqO6Jkk_s3k" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 204, 107, 210, 215, 248, 245, 181, 3, 241, 226, 40, 58, 223, 152, 166, 128, 201, 245, 49, 41, 62, 207, 31, 32, 73, 184, 252, 244, 61, 10, 14, 165, 80, 249, 84, 76, 123, 188, 115, 235, 3, 144, 108, 77, 176, 174, 7, 32, 221, 21, 134, 243, 43, 220, 91, 136, 71, 24, 94, 101, 3, 252, 8, 16 }, new byte[] { 212, 80, 175, 108, 132, 64, 31, 61, 182, 151, 124, 206, 106, 29, 236, 56, 26, 60, 35, 76, 32, 20, 34, 92, 2, 52, 91, 29, 110, 112, 147, 221, 249, 193, 98, 254, 155, 56, 151, 113, 168, 73, 76, 18, 193, 44, 154, 55, 165, 179, 162, 22, 65, 85, 201, 151, 49, 225, 238, 177, 234, 228, 66, 28, 19, 224, 88, 35, 169, 98, 144, 195, 41, 202, 46, 242, 239, 37, 116, 147, 251, 96, 188, 66, 31, 210, 192, 36, 238, 32, 13, 38, 113, 52, 74, 165, 18, 218, 56, 101, 229, 213, 165, 30, 47, 109, 121, 166, 58, 119, 254, 78, 54, 12, 154, 34, 244, 91, 51, 113, 135, 162, 142, 75, 119, 190, 221, 156 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjI2Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzM1MzI0MCwiZXhwIjoxNTgzOTU4MDQwLCJpYXQiOjE1ODMzNTMyNDB9.udSheQDlyciPuZxWj9QlNkpmTSDLn90U5uNYgpnwDrY" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 204, 107, 210, 215, 248, 245, 181, 3, 241, 226, 40, 58, 223, 152, 166, 128, 201, 245, 49, 41, 62, 207, 31, 32, 73, 184, 252, 244, 61, 10, 14, 165, 80, 249, 84, 76, 123, 188, 115, 235, 3, 144, 108, 77, 176, 174, 7, 32, 221, 21, 134, 243, 43, 220, 91, 136, 71, 24, 94, 101, 3, 252, 8, 16 }, new byte[] { 212, 80, 175, 108, 132, 64, 31, 61, 182, 151, 124, 206, 106, 29, 236, 56, 26, 60, 35, 76, 32, 20, 34, 92, 2, 52, 91, 29, 110, 112, 147, 221, 249, 193, 98, 254, 155, 56, 151, 113, 168, 73, 76, 18, 193, 44, 154, 55, 165, 179, 162, 22, 65, 85, 201, 151, 49, 225, 238, 177, 234, 228, 66, 28, 19, 224, 88, 35, 169, 98, 144, 195, 41, 202, 46, 242, 239, 37, 116, 147, 251, 96, 188, 66, 31, 210, 192, 36, 238, 32, 13, 38, 113, 52, 74, 165, 18, 218, 56, 101, 229, 213, 165, 30, 47, 109, 121, 166, 58, 119, 254, 78, 54, 12, 154, 34, 244, 91, 51, 113, 135, 162, 142, 75, 119, 190, 221, 156 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjI3Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzM1MzI0MCwiZXhwIjoxNTgzOTU4MDQwLCJpYXQiOjE1ODMzNTMyNDB9.whT_w7fOtR9txmQQf21tovuJf18ok09-0OZRsN9T2Ns" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 204, 107, 210, 215, 248, 245, 181, 3, 241, 226, 40, 58, 223, 152, 166, 128, 201, 245, 49, 41, 62, 207, 31, 32, 73, 184, 252, 244, 61, 10, 14, 165, 80, 249, 84, 76, 123, 188, 115, 235, 3, 144, 108, 77, 176, 174, 7, 32, 221, 21, 134, 243, 43, 220, 91, 136, 71, 24, 94, 101, 3, 252, 8, 16 }, new byte[] { 212, 80, 175, 108, 132, 64, 31, 61, 182, 151, 124, 206, 106, 29, 236, 56, 26, 60, 35, 76, 32, 20, 34, 92, 2, 52, 91, 29, 110, 112, 147, 221, 249, 193, 98, 254, 155, 56, 151, 113, 168, 73, 76, 18, 193, 44, 154, 55, 165, 179, 162, 22, 65, 85, 201, 151, 49, 225, 238, 177, 234, 228, 66, 28, 19, 224, 88, 35, 169, 98, 144, 195, 41, 202, 46, 242, 239, 37, 116, 147, 251, 96, 188, 66, 31, 210, 192, 36, 238, 32, 13, 38, 113, 52, 74, 165, 18, 218, 56, 101, 229, 213, 165, 30, 47, 109, 121, 166, 58, 119, 254, 78, 54, 12, 154, 34, 244, 91, 51, 113, 135, 162, 142, 75, 119, 190, 221, 156 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjI4Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzM1MzI0MCwiZXhwIjoxNTgzOTU4MDQwLCJpYXQiOjE1ODMzNTMyNDB9.NjhfAaekxP_awg11qSTnJh3QHjVI9MGKs3lcmVTBB48" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 204, 107, 210, 215, 248, 245, 181, 3, 241, 226, 40, 58, 223, 152, 166, 128, 201, 245, 49, 41, 62, 207, 31, 32, 73, 184, 252, 244, 61, 10, 14, 165, 80, 249, 84, 76, 123, 188, 115, 235, 3, 144, 108, 77, 176, 174, 7, 32, 221, 21, 134, 243, 43, 220, 91, 136, 71, 24, 94, 101, 3, 252, 8, 16 }, new byte[] { 212, 80, 175, 108, 132, 64, 31, 61, 182, 151, 124, 206, 106, 29, 236, 56, 26, 60, 35, 76, 32, 20, 34, 92, 2, 52, 91, 29, 110, 112, 147, 221, 249, 193, 98, 254, 155, 56, 151, 113, 168, 73, 76, 18, 193, 44, 154, 55, 165, 179, 162, 22, 65, 85, 201, 151, 49, 225, 238, 177, 234, 228, 66, 28, 19, 224, 88, 35, 169, 98, 144, 195, 41, 202, 46, 242, 239, 37, 116, 147, 251, 96, 188, 66, 31, 210, 192, 36, 238, 32, 13, 38, 113, 52, 74, 165, 18, 218, 56, 101, 229, 213, 165, 30, 47, 109, 121, 166, 58, 119, 254, 78, 54, 12, 154, 34, 244, 91, 51, 113, 135, 162, 142, 75, 119, 190, 221, 156 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjI5Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzM1MzI0MCwiZXhwIjoxNTgzOTU4MDQwLCJpYXQiOjE1ODMzNTMyNDB9.qzR9UirnVAm67ZvaqQwh-ABiNMxb-cXenqtbfQB8IFs" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 204, 107, 210, 215, 248, 245, 181, 3, 241, 226, 40, 58, 223, 152, 166, 128, 201, 245, 49, 41, 62, 207, 31, 32, 73, 184, 252, 244, 61, 10, 14, 165, 80, 249, 84, 76, 123, 188, 115, 235, 3, 144, 108, 77, 176, 174, 7, 32, 221, 21, 134, 243, 43, 220, 91, 136, 71, 24, 94, 101, 3, 252, 8, 16 }, new byte[] { 212, 80, 175, 108, 132, 64, 31, 61, 182, 151, 124, 206, 106, 29, 236, 56, 26, 60, 35, 76, 32, 20, 34, 92, 2, 52, 91, 29, 110, 112, 147, 221, 249, 193, 98, 254, 155, 56, 151, 113, 168, 73, 76, 18, 193, 44, 154, 55, 165, 179, 162, 22, 65, 85, 201, 151, 49, 225, 238, 177, 234, 228, 66, 28, 19, 224, 88, 35, 169, 98, 144, 195, 41, 202, 46, 242, 239, 37, 116, 147, 251, 96, 188, 66, 31, 210, 192, 36, 238, 32, 13, 38, 113, 52, 74, 165, 18, 218, 56, 101, 229, 213, 165, 30, 47, 109, 121, 166, 58, 119, 254, 78, 54, 12, 154, 34, 244, 91, 51, 113, 135, 162, 142, 75, 119, 190, 221, 156 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjMwIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzM1MzI0MCwiZXhwIjoxNTgzOTU4MDQwLCJpYXQiOjE1ODMzNTMyNDB9.754fiJvM-Fb7W8OMmKaTbBa8eEcSIKbMUnXzjgWIAXI" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 204, 107, 210, 215, 248, 245, 181, 3, 241, 226, 40, 58, 223, 152, 166, 128, 201, 245, 49, 41, 62, 207, 31, 32, 73, 184, 252, 244, 61, 10, 14, 165, 80, 249, 84, 76, 123, 188, 115, 235, 3, 144, 108, 77, 176, 174, 7, 32, 221, 21, 134, 243, 43, 220, 91, 136, 71, 24, 94, 101, 3, 252, 8, 16 }, new byte[] { 212, 80, 175, 108, 132, 64, 31, 61, 182, 151, 124, 206, 106, 29, 236, 56, 26, 60, 35, 76, 32, 20, 34, 92, 2, 52, 91, 29, 110, 112, 147, 221, 249, 193, 98, 254, 155, 56, 151, 113, 168, 73, 76, 18, 193, 44, 154, 55, 165, 179, 162, 22, 65, 85, 201, 151, 49, 225, 238, 177, 234, 228, 66, 28, 19, 224, 88, 35, 169, 98, 144, 195, 41, 202, 46, 242, 239, 37, 116, 147, 251, 96, 188, 66, 31, 210, 192, 36, 238, 32, 13, 38, 113, 52, 74, 165, 18, 218, 56, 101, 229, 213, 165, 30, 47, 109, 121, 166, 58, 119, 254, 78, 54, 12, 154, 34, 244, 91, 51, 113, 135, 162, 142, 75, 119, 190, 221, 156 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjMxIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzM1MzI0MCwiZXhwIjoxNTgzOTU4MDQwLCJpYXQiOjE1ODMzNTMyNDB9.SuL8nCF1aQ_oQyY4-nwmT5LYEALZFp957WUif5FgILA" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 204, 107, 210, 215, 248, 245, 181, 3, 241, 226, 40, 58, 223, 152, 166, 128, 201, 245, 49, 41, 62, 207, 31, 32, 73, 184, 252, 244, 61, 10, 14, 165, 80, 249, 84, 76, 123, 188, 115, 235, 3, 144, 108, 77, 176, 174, 7, 32, 221, 21, 134, 243, 43, 220, 91, 136, 71, 24, 94, 101, 3, 252, 8, 16 }, new byte[] { 212, 80, 175, 108, 132, 64, 31, 61, 182, 151, 124, 206, 106, 29, 236, 56, 26, 60, 35, 76, 32, 20, 34, 92, 2, 52, 91, 29, 110, 112, 147, 221, 249, 193, 98, 254, 155, 56, 151, 113, 168, 73, 76, 18, 193, 44, 154, 55, 165, 179, 162, 22, 65, 85, 201, 151, 49, 225, 238, 177, 234, 228, 66, 28, 19, 224, 88, 35, 169, 98, 144, 195, 41, 202, 46, 242, 239, 37, 116, 147, 251, 96, 188, 66, 31, 210, 192, 36, 238, 32, 13, 38, 113, 52, 74, 165, 18, 218, 56, 101, 229, 213, 165, 30, 47, 109, 121, 166, 58, 119, 254, 78, 54, 12, 154, 34, 244, 91, 51, 113, 135, 162, 142, 75, 119, 190, 221, 156 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjMyIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzM1MzI0MCwiZXhwIjoxNTgzOTU4MDQwLCJpYXQiOjE1ODMzNTMyNDB9.PFyTOCwJuqi-OhBQfyh-rFjJ3ikuFIE711eb7FEWENA" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 204, 107, 210, 215, 248, 245, 181, 3, 241, 226, 40, 58, 223, 152, 166, 128, 201, 245, 49, 41, 62, 207, 31, 32, 73, 184, 252, 244, 61, 10, 14, 165, 80, 249, 84, 76, 123, 188, 115, 235, 3, 144, 108, 77, 176, 174, 7, 32, 221, 21, 134, 243, 43, 220, 91, 136, 71, 24, 94, 101, 3, 252, 8, 16 }, new byte[] { 212, 80, 175, 108, 132, 64, 31, 61, 182, 151, 124, 206, 106, 29, 236, 56, 26, 60, 35, 76, 32, 20, 34, 92, 2, 52, 91, 29, 110, 112, 147, 221, 249, 193, 98, 254, 155, 56, 151, 113, 168, 73, 76, 18, 193, 44, 154, 55, 165, 179, 162, 22, 65, 85, 201, 151, 49, 225, 238, 177, 234, 228, 66, 28, 19, 224, 88, 35, 169, 98, 144, 195, 41, 202, 46, 242, 239, 37, 116, 147, 251, 96, 188, 66, 31, 210, 192, 36, 238, 32, 13, 38, 113, 52, 74, 165, 18, 218, 56, 101, 229, 213, 165, 30, 47, 109, 121, 166, 58, 119, 254, 78, 54, 12, 154, 34, 244, 91, 51, 113, 135, 162, 142, 75, 119, 190, 221, 156 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjMzIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzM1MzI0MCwiZXhwIjoxNTgzOTU4MDQwLCJpYXQiOjE1ODMzNTMyNDB9.5t1-zfxoxJpZ2RuRu0VJHhBso8qAFtiwlZJHTM2uYFU" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 204, 107, 210, 215, 248, 245, 181, 3, 241, 226, 40, 58, 223, 152, 166, 128, 201, 245, 49, 41, 62, 207, 31, 32, 73, 184, 252, 244, 61, 10, 14, 165, 80, 249, 84, 76, 123, 188, 115, 235, 3, 144, 108, 77, 176, 174, 7, 32, 221, 21, 134, 243, 43, 220, 91, 136, 71, 24, 94, 101, 3, 252, 8, 16 }, new byte[] { 212, 80, 175, 108, 132, 64, 31, 61, 182, 151, 124, 206, 106, 29, 236, 56, 26, 60, 35, 76, 32, 20, 34, 92, 2, 52, 91, 29, 110, 112, 147, 221, 249, 193, 98, 254, 155, 56, 151, 113, 168, 73, 76, 18, 193, 44, 154, 55, 165, 179, 162, 22, 65, 85, 201, 151, 49, 225, 238, 177, 234, 228, 66, 28, 19, 224, 88, 35, 169, 98, 144, 195, 41, 202, 46, 242, 239, 37, 116, 147, 251, 96, 188, 66, 31, 210, 192, 36, 238, 32, 13, 38, 113, 52, 74, 165, 18, 218, 56, 101, 229, 213, 165, 30, 47, 109, 121, 166, 58, 119, 254, 78, 54, 12, 154, 34, 244, 91, 51, 113, 135, 162, 142, 75, 119, 190, 221, 156 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjM0Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzM1MzI0MCwiZXhwIjoxNTgzOTU4MDQwLCJpYXQiOjE1ODMzNTMyNDB9.oVPjtxOwe2dIp6DH7LCOaiV2bu-_KlzG0zxQN1bYyGg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 204, 107, 210, 215, 248, 245, 181, 3, 241, 226, 40, 58, 223, 152, 166, 128, 201, 245, 49, 41, 62, 207, 31, 32, 73, 184, 252, 244, 61, 10, 14, 165, 80, 249, 84, 76, 123, 188, 115, 235, 3, 144, 108, 77, 176, 174, 7, 32, 221, 21, 134, 243, 43, 220, 91, 136, 71, 24, 94, 101, 3, 252, 8, 16 }, new byte[] { 212, 80, 175, 108, 132, 64, 31, 61, 182, 151, 124, 206, 106, 29, 236, 56, 26, 60, 35, 76, 32, 20, 34, 92, 2, 52, 91, 29, 110, 112, 147, 221, 249, 193, 98, 254, 155, 56, 151, 113, 168, 73, 76, 18, 193, 44, 154, 55, 165, 179, 162, 22, 65, 85, 201, 151, 49, 225, 238, 177, 234, 228, 66, 28, 19, 224, 88, 35, 169, 98, 144, 195, 41, 202, 46, 242, 239, 37, 116, 147, 251, 96, 188, 66, 31, 210, 192, 36, 238, 32, 13, 38, 113, 52, 74, 165, 18, 218, 56, 101, 229, 213, 165, 30, 47, 109, 121, 166, 58, 119, 254, 78, 54, 12, 154, 34, 244, 91, 51, 113, 135, 162, 142, 75, 119, 190, 221, 156 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjM1Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzM1MzI0MCwiZXhwIjoxNTgzOTU4MDQwLCJpYXQiOjE1ODMzNTMyNDB9.CC6ND2dz_flSRYoDguYCLUz1hemMOD47O5zUEtcpDfQ" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 204, 107, 210, 215, 248, 245, 181, 3, 241, 226, 40, 58, 223, 152, 166, 128, 201, 245, 49, 41, 62, 207, 31, 32, 73, 184, 252, 244, 61, 10, 14, 165, 80, 249, 84, 76, 123, 188, 115, 235, 3, 144, 108, 77, 176, 174, 7, 32, 221, 21, 134, 243, 43, 220, 91, 136, 71, 24, 94, 101, 3, 252, 8, 16 }, new byte[] { 212, 80, 175, 108, 132, 64, 31, 61, 182, 151, 124, 206, 106, 29, 236, 56, 26, 60, 35, 76, 32, 20, 34, 92, 2, 52, 91, 29, 110, 112, 147, 221, 249, 193, 98, 254, 155, 56, 151, 113, 168, 73, 76, 18, 193, 44, 154, 55, 165, 179, 162, 22, 65, 85, 201, 151, 49, 225, 238, 177, 234, 228, 66, 28, 19, 224, 88, 35, 169, 98, 144, 195, 41, 202, 46, 242, 239, 37, 116, 147, 251, 96, 188, 66, 31, 210, 192, 36, 238, 32, 13, 38, 113, 52, 74, 165, 18, 218, 56, 101, 229, 213, 165, 30, 47, 109, 121, 166, 58, 119, 254, 78, 54, 12, 154, 34, 244, 91, 51, 113, 135, 162, 142, 75, 119, 190, 221, 156 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjM2Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzM1MzI0MCwiZXhwIjoxNTgzOTU4MDQwLCJpYXQiOjE1ODMzNTMyNDB9.kee5iXPvkDd-KRQDG4aITcUvFPT3UWLD2nSSbABbGsw" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 204, 107, 210, 215, 248, 245, 181, 3, 241, 226, 40, 58, 223, 152, 166, 128, 201, 245, 49, 41, 62, 207, 31, 32, 73, 184, 252, 244, 61, 10, 14, 165, 80, 249, 84, 76, 123, 188, 115, 235, 3, 144, 108, 77, 176, 174, 7, 32, 221, 21, 134, 243, 43, 220, 91, 136, 71, 24, 94, 101, 3, 252, 8, 16 }, new byte[] { 212, 80, 175, 108, 132, 64, 31, 61, 182, 151, 124, 206, 106, 29, 236, 56, 26, 60, 35, 76, 32, 20, 34, 92, 2, 52, 91, 29, 110, 112, 147, 221, 249, 193, 98, 254, 155, 56, 151, 113, 168, 73, 76, 18, 193, 44, 154, 55, 165, 179, 162, 22, 65, 85, 201, 151, 49, 225, 238, 177, 234, 228, 66, 28, 19, 224, 88, 35, 169, 98, 144, 195, 41, 202, 46, 242, 239, 37, 116, 147, 251, 96, 188, 66, 31, 210, 192, 36, 238, 32, 13, 38, 113, 52, 74, 165, 18, 218, 56, 101, 229, 213, 165, 30, 47, 109, 121, 166, 58, 119, 254, 78, 54, 12, 154, 34, 244, 91, 51, 113, 135, 162, 142, 75, 119, 190, 221, 156 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjM3Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzM1MzI0MCwiZXhwIjoxNTgzOTU4MDQwLCJpYXQiOjE1ODMzNTMyNDB9.gcjYywEandEA38qqQy-5KG2KEmmhdJj2b6SK-Xz8V34" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 204, 107, 210, 215, 248, 245, 181, 3, 241, 226, 40, 58, 223, 152, 166, 128, 201, 245, 49, 41, 62, 207, 31, 32, 73, 184, 252, 244, 61, 10, 14, 165, 80, 249, 84, 76, 123, 188, 115, 235, 3, 144, 108, 77, 176, 174, 7, 32, 221, 21, 134, 243, 43, 220, 91, 136, 71, 24, 94, 101, 3, 252, 8, 16 }, new byte[] { 212, 80, 175, 108, 132, 64, 31, 61, 182, 151, 124, 206, 106, 29, 236, 56, 26, 60, 35, 76, 32, 20, 34, 92, 2, 52, 91, 29, 110, 112, 147, 221, 249, 193, 98, 254, 155, 56, 151, 113, 168, 73, 76, 18, 193, 44, 154, 55, 165, 179, 162, 22, 65, 85, 201, 151, 49, 225, 238, 177, 234, 228, 66, 28, 19, 224, 88, 35, 169, 98, 144, 195, 41, 202, 46, 242, 239, 37, 116, 147, 251, 96, 188, 66, 31, 210, 192, 36, 238, 32, 13, 38, 113, 52, 74, 165, 18, 218, 56, 101, 229, 213, 165, 30, 47, 109, 121, 166, 58, 119, 254, 78, 54, 12, 154, 34, 244, 91, 51, 113, 135, 162, 142, 75, 119, 190, 221, 156 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjM4Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzM1MzI0MCwiZXhwIjoxNTgzOTU4MDQwLCJpYXQiOjE1ODMzNTMyNDB9.x-I9pWJZhbZY-HOiJrpzcWL4_DnYLNihk23yLpDwOy0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 204, 107, 210, 215, 248, 245, 181, 3, 241, 226, 40, 58, 223, 152, 166, 128, 201, 245, 49, 41, 62, 207, 31, 32, 73, 184, 252, 244, 61, 10, 14, 165, 80, 249, 84, 76, 123, 188, 115, 235, 3, 144, 108, 77, 176, 174, 7, 32, 221, 21, 134, 243, 43, 220, 91, 136, 71, 24, 94, 101, 3, 252, 8, 16 }, new byte[] { 212, 80, 175, 108, 132, 64, 31, 61, 182, 151, 124, 206, 106, 29, 236, 56, 26, 60, 35, 76, 32, 20, 34, 92, 2, 52, 91, 29, 110, 112, 147, 221, 249, 193, 98, 254, 155, 56, 151, 113, 168, 73, 76, 18, 193, 44, 154, 55, 165, 179, 162, 22, 65, 85, 201, 151, 49, 225, 238, 177, 234, 228, 66, 28, 19, 224, 88, 35, 169, 98, 144, 195, 41, 202, 46, 242, 239, 37, 116, 147, 251, 96, 188, 66, 31, 210, 192, 36, 238, 32, 13, 38, 113, 52, 74, 165, 18, 218, 56, 101, 229, 213, 165, 30, 47, 109, 121, 166, 58, 119, 254, 78, 54, 12, 154, 34, 244, 91, 51, 113, 135, 162, 142, 75, 119, 190, 221, 156 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjM5Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzM1MzI0MCwiZXhwIjoxNTgzOTU4MDQwLCJpYXQiOjE1ODMzNTMyNDB9.GAyVbutV7eAfWgrdwgV3hf6t9Q9Sv2i5oPtey0D9k4E" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 204, 107, 210, 215, 248, 245, 181, 3, 241, 226, 40, 58, 223, 152, 166, 128, 201, 245, 49, 41, 62, 207, 31, 32, 73, 184, 252, 244, 61, 10, 14, 165, 80, 249, 84, 76, 123, 188, 115, 235, 3, 144, 108, 77, 176, 174, 7, 32, 221, 21, 134, 243, 43, 220, 91, 136, 71, 24, 94, 101, 3, 252, 8, 16 }, new byte[] { 212, 80, 175, 108, 132, 64, 31, 61, 182, 151, 124, 206, 106, 29, 236, 56, 26, 60, 35, 76, 32, 20, 34, 92, 2, 52, 91, 29, 110, 112, 147, 221, 249, 193, 98, 254, 155, 56, 151, 113, 168, 73, 76, 18, 193, 44, 154, 55, 165, 179, 162, 22, 65, 85, 201, 151, 49, 225, 238, 177, 234, 228, 66, 28, 19, 224, 88, 35, 169, 98, 144, 195, 41, 202, 46, 242, 239, 37, 116, 147, 251, 96, 188, 66, 31, 210, 192, 36, 238, 32, 13, 38, 113, 52, 74, 165, 18, 218, 56, 101, 229, 213, 165, 30, 47, 109, 121, 166, 58, 119, 254, 78, 54, 12, 154, 34, 244, 91, 51, 113, 135, 162, 142, 75, 119, 190, 221, 156 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjQwIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzM1MzI0MCwiZXhwIjoxNTgzOTU4MDQwLCJpYXQiOjE1ODMzNTMyNDB9.PZWpR_MF9wePldz_D7Zf-MocQ1ISu1EB6Xz3DuvIm9g" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 204, 107, 210, 215, 248, 245, 181, 3, 241, 226, 40, 58, 223, 152, 166, 128, 201, 245, 49, 41, 62, 207, 31, 32, 73, 184, 252, 244, 61, 10, 14, 165, 80, 249, 84, 76, 123, 188, 115, 235, 3, 144, 108, 77, 176, 174, 7, 32, 221, 21, 134, 243, 43, 220, 91, 136, 71, 24, 94, 101, 3, 252, 8, 16 }, new byte[] { 212, 80, 175, 108, 132, 64, 31, 61, 182, 151, 124, 206, 106, 29, 236, 56, 26, 60, 35, 76, 32, 20, 34, 92, 2, 52, 91, 29, 110, 112, 147, 221, 249, 193, 98, 254, 155, 56, 151, 113, 168, 73, 76, 18, 193, 44, 154, 55, 165, 179, 162, 22, 65, 85, 201, 151, 49, 225, 238, 177, 234, 228, 66, 28, 19, 224, 88, 35, 169, 98, 144, 195, 41, 202, 46, 242, 239, 37, 116, 147, 251, 96, 188, 66, 31, 210, 192, 36, 238, 32, 13, 38, 113, 52, 74, 165, 18, 218, 56, 101, 229, 213, 165, 30, 47, 109, 121, 166, 58, 119, 254, 78, 54, 12, 154, 34, 244, 91, 51, 113, 135, 162, 142, 75, 119, 190, 221, 156 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjQxIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzM1MzI0MCwiZXhwIjoxNTgzOTU4MDQwLCJpYXQiOjE1ODMzNTMyNDB9.Xve5_YkF2wtBBW3J_iUwqsFkXLIJTUfJHtbsLthY3T0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 204, 107, 210, 215, 248, 245, 181, 3, 241, 226, 40, 58, 223, 152, 166, 128, 201, 245, 49, 41, 62, 207, 31, 32, 73, 184, 252, 244, 61, 10, 14, 165, 80, 249, 84, 76, 123, 188, 115, 235, 3, 144, 108, 77, 176, 174, 7, 32, 221, 21, 134, 243, 43, 220, 91, 136, 71, 24, 94, 101, 3, 252, 8, 16 }, new byte[] { 212, 80, 175, 108, 132, 64, 31, 61, 182, 151, 124, 206, 106, 29, 236, 56, 26, 60, 35, 76, 32, 20, 34, 92, 2, 52, 91, 29, 110, 112, 147, 221, 249, 193, 98, 254, 155, 56, 151, 113, 168, 73, 76, 18, 193, 44, 154, 55, 165, 179, 162, 22, 65, 85, 201, 151, 49, 225, 238, 177, 234, 228, 66, 28, 19, 224, 88, 35, 169, 98, 144, 195, 41, 202, 46, 242, 239, 37, 116, 147, 251, 96, 188, 66, 31, 210, 192, 36, 238, 32, 13, 38, 113, 52, 74, 165, 18, 218, 56, 101, 229, 213, 165, 30, 47, 109, 121, 166, 58, 119, 254, 78, 54, 12, 154, 34, 244, 91, 51, 113, 135, 162, 142, 75, 119, 190, 221, 156 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjQyIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzM1MzI0MCwiZXhwIjoxNTgzOTU4MDQwLCJpYXQiOjE1ODMzNTMyNDB9.KaG2xJoEURWaIfq1f9HI0HGGxSpF0SjLDBVdlPKtnEc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 204, 107, 210, 215, 248, 245, 181, 3, 241, 226, 40, 58, 223, 152, 166, 128, 201, 245, 49, 41, 62, 207, 31, 32, 73, 184, 252, 244, 61, 10, 14, 165, 80, 249, 84, 76, 123, 188, 115, 235, 3, 144, 108, 77, 176, 174, 7, 32, 221, 21, 134, 243, 43, 220, 91, 136, 71, 24, 94, 101, 3, 252, 8, 16 }, new byte[] { 212, 80, 175, 108, 132, 64, 31, 61, 182, 151, 124, 206, 106, 29, 236, 56, 26, 60, 35, 76, 32, 20, 34, 92, 2, 52, 91, 29, 110, 112, 147, 221, 249, 193, 98, 254, 155, 56, 151, 113, 168, 73, 76, 18, 193, 44, 154, 55, 165, 179, 162, 22, 65, 85, 201, 151, 49, 225, 238, 177, 234, 228, 66, 28, 19, 224, 88, 35, 169, 98, 144, 195, 41, 202, 46, 242, 239, 37, 116, 147, 251, 96, 188, 66, 31, 210, 192, 36, 238, 32, 13, 38, 113, 52, 74, 165, 18, 218, 56, 101, 229, 213, 165, 30, 47, 109, 121, 166, 58, 119, 254, 78, 54, 12, 154, 34, 244, 91, 51, 113, 135, 162, 142, 75, 119, 190, 221, 156 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjQzIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzM1MzI0MCwiZXhwIjoxNTgzOTU4MDQwLCJpYXQiOjE1ODMzNTMyNDB9.vlsKT7ZjaYbOINxu_hjigRqRQdP7fw7hJrY2PoWNLio" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 204, 107, 210, 215, 248, 245, 181, 3, 241, 226, 40, 58, 223, 152, 166, 128, 201, 245, 49, 41, 62, 207, 31, 32, 73, 184, 252, 244, 61, 10, 14, 165, 80, 249, 84, 76, 123, 188, 115, 235, 3, 144, 108, 77, 176, 174, 7, 32, 221, 21, 134, 243, 43, 220, 91, 136, 71, 24, 94, 101, 3, 252, 8, 16 }, new byte[] { 212, 80, 175, 108, 132, 64, 31, 61, 182, 151, 124, 206, 106, 29, 236, 56, 26, 60, 35, 76, 32, 20, 34, 92, 2, 52, 91, 29, 110, 112, 147, 221, 249, 193, 98, 254, 155, 56, 151, 113, 168, 73, 76, 18, 193, 44, 154, 55, 165, 179, 162, 22, 65, 85, 201, 151, 49, 225, 238, 177, 234, 228, 66, 28, 19, 224, 88, 35, 169, 98, 144, 195, 41, 202, 46, 242, 239, 37, 116, 147, 251, 96, 188, 66, 31, 210, 192, 36, 238, 32, 13, 38, 113, 52, 74, 165, 18, 218, 56, 101, 229, 213, 165, 30, 47, 109, 121, 166, 58, 119, 254, 78, 54, 12, 154, 34, 244, 91, 51, 113, 135, 162, 142, 75, 119, 190, 221, 156 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjQ0Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzM1MzI0MCwiZXhwIjoxNTgzOTU4MDQwLCJpYXQiOjE1ODMzNTMyNDB9.qS679KtgjPYa1wQQTqeI1BGNEGybPrgjOH6_NtPSqRU" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 204, 107, 210, 215, 248, 245, 181, 3, 241, 226, 40, 58, 223, 152, 166, 128, 201, 245, 49, 41, 62, 207, 31, 32, 73, 184, 252, 244, 61, 10, 14, 165, 80, 249, 84, 76, 123, 188, 115, 235, 3, 144, 108, 77, 176, 174, 7, 32, 221, 21, 134, 243, 43, 220, 91, 136, 71, 24, 94, 101, 3, 252, 8, 16 }, new byte[] { 212, 80, 175, 108, 132, 64, 31, 61, 182, 151, 124, 206, 106, 29, 236, 56, 26, 60, 35, 76, 32, 20, 34, 92, 2, 52, 91, 29, 110, 112, 147, 221, 249, 193, 98, 254, 155, 56, 151, 113, 168, 73, 76, 18, 193, 44, 154, 55, 165, 179, 162, 22, 65, 85, 201, 151, 49, 225, 238, 177, 234, 228, 66, 28, 19, 224, 88, 35, 169, 98, 144, 195, 41, 202, 46, 242, 239, 37, 116, 147, 251, 96, 188, 66, 31, 210, 192, 36, 238, 32, 13, 38, 113, 52, 74, 165, 18, 218, 56, 101, 229, 213, 165, 30, 47, 109, 121, 166, 58, 119, 254, 78, 54, 12, 154, 34, 244, 91, 51, 113, 135, 162, 142, 75, 119, 190, 221, 156 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjQ1Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzM1MzI0MCwiZXhwIjoxNTgzOTU4MDQwLCJpYXQiOjE1ODMzNTMyNDB9.0vHMZecEC-JRZztwL_o0h5UBsZzDK1ZvLd6yWtqfKfw" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 204, 107, 210, 215, 248, 245, 181, 3, 241, 226, 40, 58, 223, 152, 166, 128, 201, 245, 49, 41, 62, 207, 31, 32, 73, 184, 252, 244, 61, 10, 14, 165, 80, 249, 84, 76, 123, 188, 115, 235, 3, 144, 108, 77, 176, 174, 7, 32, 221, 21, 134, 243, 43, 220, 91, 136, 71, 24, 94, 101, 3, 252, 8, 16 }, new byte[] { 212, 80, 175, 108, 132, 64, 31, 61, 182, 151, 124, 206, 106, 29, 236, 56, 26, 60, 35, 76, 32, 20, 34, 92, 2, 52, 91, 29, 110, 112, 147, 221, 249, 193, 98, 254, 155, 56, 151, 113, 168, 73, 76, 18, 193, 44, 154, 55, 165, 179, 162, 22, 65, 85, 201, 151, 49, 225, 238, 177, 234, 228, 66, 28, 19, 224, 88, 35, 169, 98, 144, 195, 41, 202, 46, 242, 239, 37, 116, 147, 251, 96, 188, 66, 31, 210, 192, 36, 238, 32, 13, 38, 113, 52, 74, 165, 18, 218, 56, 101, 229, 213, 165, 30, 47, 109, 121, 166, 58, 119, 254, 78, 54, 12, 154, 34, 244, 91, 51, 113, 135, 162, 142, 75, 119, 190, 221, 156 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjQ2Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzM1MzI0MCwiZXhwIjoxNTgzOTU4MDQwLCJpYXQiOjE1ODMzNTMyNDB9.eYV_ONWjQmsdY6EuVAcko0IqqufZcU3tgQtqjzJXThc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 204, 107, 210, 215, 248, 245, 181, 3, 241, 226, 40, 58, 223, 152, 166, 128, 201, 245, 49, 41, 62, 207, 31, 32, 73, 184, 252, 244, 61, 10, 14, 165, 80, 249, 84, 76, 123, 188, 115, 235, 3, 144, 108, 77, 176, 174, 7, 32, 221, 21, 134, 243, 43, 220, 91, 136, 71, 24, 94, 101, 3, 252, 8, 16 }, new byte[] { 212, 80, 175, 108, 132, 64, 31, 61, 182, 151, 124, 206, 106, 29, 236, 56, 26, 60, 35, 76, 32, 20, 34, 92, 2, 52, 91, 29, 110, 112, 147, 221, 249, 193, 98, 254, 155, 56, 151, 113, 168, 73, 76, 18, 193, 44, 154, 55, 165, 179, 162, 22, 65, 85, 201, 151, 49, 225, 238, 177, 234, 228, 66, 28, 19, 224, 88, 35, 169, 98, 144, 195, 41, 202, 46, 242, 239, 37, 116, 147, 251, 96, 188, 66, 31, 210, 192, 36, 238, 32, 13, 38, 113, 52, 74, 165, 18, 218, 56, 101, 229, 213, 165, 30, 47, 109, 121, 166, 58, 119, 254, 78, 54, 12, 154, 34, 244, 91, 51, 113, 135, 162, 142, 75, 119, 190, 221, 156 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjQ3Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzM1MzI0MCwiZXhwIjoxNTgzOTU4MDQwLCJpYXQiOjE1ODMzNTMyNDB9.NDrXxb4qo9bSU9gz79r9QZY8P7lz-iO2paeZWq2CWbM" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 204, 107, 210, 215, 248, 245, 181, 3, 241, 226, 40, 58, 223, 152, 166, 128, 201, 245, 49, 41, 62, 207, 31, 32, 73, 184, 252, 244, 61, 10, 14, 165, 80, 249, 84, 76, 123, 188, 115, 235, 3, 144, 108, 77, 176, 174, 7, 32, 221, 21, 134, 243, 43, 220, 91, 136, 71, 24, 94, 101, 3, 252, 8, 16 }, new byte[] { 212, 80, 175, 108, 132, 64, 31, 61, 182, 151, 124, 206, 106, 29, 236, 56, 26, 60, 35, 76, 32, 20, 34, 92, 2, 52, 91, 29, 110, 112, 147, 221, 249, 193, 98, 254, 155, 56, 151, 113, 168, 73, 76, 18, 193, 44, 154, 55, 165, 179, 162, 22, 65, 85, 201, 151, 49, 225, 238, 177, 234, 228, 66, 28, 19, 224, 88, 35, 169, 98, 144, 195, 41, 202, 46, 242, 239, 37, 116, 147, 251, 96, 188, 66, 31, 210, 192, 36, 238, 32, 13, 38, 113, 52, 74, 165, 18, 218, 56, 101, 229, 213, 165, 30, 47, 109, 121, 166, 58, 119, 254, 78, 54, 12, 154, 34, 244, 91, 51, 113, 135, 162, 142, 75, 119, 190, 221, 156 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjQ4Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzM1MzI0MCwiZXhwIjoxNTgzOTU4MDQwLCJpYXQiOjE1ODMzNTMyNDB9.ZAq7Owerssi51pZ6yk6lCbe5lj5JTQ4G1n7N_TshA6U" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "AuthorId", "Content", "CreatedAt", "DiscussionId", "MediaId" },
                values: new object[,]
                {
                    { 9, 9, "Ding dong", new DateTime(2020, 3, 4, 21, 20, 40, 229, DateTimeKind.Local).AddTicks(1814), 1, null },
                    { 25, 38, "42 ? Tu veux que je te reprogramme ? Si ce n'est que ça dis le enfoiré", new DateTime(2020, 3, 4, 21, 20, 40, 229, DateTimeKind.Local).AddTicks(2224), 2, null },
                    { 26, 20, "Whesh humain ziva calme toi un peu. Je vais me taper un petit rail de binaire, tu m'as mis trop les nerfs frérot", new DateTime(2020, 3, 4, 21, 20, 40, 229, DateTimeKind.Local).AddTicks(2227), 2, null },
                    { 27, 18, null, new DateTime(2020, 3, 4, 21, 20, 40, 229, DateTimeKind.Local).AddTicks(2231), 2, 7 },
                    { 28, 18, null, new DateTime(2020, 3, 4, 21, 20, 40, 229, DateTimeKind.Local).AddTicks(2235), 2, 8 },
                    { 29, 38, null, new DateTime(2020, 3, 4, 21, 20, 40, 229, DateTimeKind.Local).AddTicks(2239), 2, 9 },
                    { 1, 13, "Bonjour", new DateTime(2020, 3, 4, 21, 20, 40, 226, DateTimeKind.Local).AddTicks(5124), 4, null },
                    { 3, 13, "Je vais bien, merci :D", new DateTime(2020, 3, 4, 21, 20, 40, 229, DateTimeKind.Local).AddTicks(1788), 4, null },
                    { 24, 20, "42", new DateTime(2020, 3, 4, 21, 20, 40, 229, DateTimeKind.Local).AddTicks(2219), 2, null },
                    { 4, 13, "Ca fait plaisir de parler !", new DateTime(2020, 3, 4, 21, 20, 40, 229, DateTimeKind.Local).AddTicks(1794), 4, null },
                    { 6, 19, "Wesh gazelle, tu sais que t'es plutôt mignone ?", new DateTime(2020, 3, 4, 21, 20, 40, 229, DateTimeKind.Local).AddTicks(1802), 5, null },
                    { 7, 15, "Désolé, je baise des gazelles, pas des éléphant à petite trompe ;)", new DateTime(2020, 3, 4, 21, 20, 40, 229, DateTimeKind.Local).AddTicks(1806), 5, null },
                    { 8, 16, "Vas-y, pourquoi tu lui parles comme ça ?", new DateTime(2020, 3, 4, 21, 20, 40, 229, DateTimeKind.Local).AddTicks(1810), 5, null },
                    { 30, 23, "Il y a quelqu'un ?", new DateTime(2020, 3, 4, 21, 20, 40, 229, DateTimeKind.Local).AddTicks(2242), 6, null },
                    { 31, 23, "Ha non, je suis le seul dans mon groupe et donc dans la conversation", new DateTime(2020, 3, 4, 21, 20, 40, 229, DateTimeKind.Local).AddTicks(2246), 6, null },
                    { 32, 23, "Suis-je un Remy sans amis ?", new DateTime(2020, 3, 4, 21, 20, 40, 229, DateTimeKind.Local).AddTicks(2249), 6, null },
                    { 33, 23, "Le suicide me guette :(", new DateTime(2020, 3, 4, 21, 20, 40, 229, DateTimeKind.Local).AddTicks(2253), 6, null },
                    { 5, 14, "Oui, à moi aussi", new DateTime(2020, 3, 4, 21, 20, 40, 229, DateTimeKind.Local).AddTicks(1798), 4, null },
                    { 23, 38, "Oui, quelle est-elle ?", new DateTime(2020, 3, 4, 21, 20, 40, 229, DateTimeKind.Local).AddTicks(2216), 2, null },
                    { 2, 14, "Coucou toi ! Comment vas-tu ?", new DateTime(2020, 3, 4, 21, 20, 40, 229, DateTimeKind.Local).AddTicks(1728), 4, null },
                    { 20, 48, null, new DateTime(2020, 3, 4, 21, 20, 40, 229, DateTimeKind.Local).AddTicks(2205), 1, 5 },
                    { 11, 48, null, new DateTime(2020, 3, 4, 21, 20, 40, 229, DateTimeKind.Local).AddTicks(2147), 1, 2 },
                    { 22, 20, "Ma réponse ?", new DateTime(2020, 3, 4, 21, 20, 40, 229, DateTimeKind.Local).AddTicks(2213), 2, null },
                    { 14, 24, "Chérie ! Les témins de Jéhova sont revenu !", new DateTime(2020, 3, 4, 21, 20, 40, 229, DateTimeKind.Local).AddTicks(2182), 1, null },
                    { 15, 29, "Claque leur la port eu nez !", new DateTime(2020, 3, 4, 21, 20, 40, 229, DateTimeKind.Local).AddTicks(2185), 1, null },
                    { 16, 24, "... Ils sont là", new DateTime(2020, 3, 4, 21, 20, 40, 229, DateTimeKind.Local).AddTicks(2189), 1, null },
                    { 10, 48, null, new DateTime(2020, 3, 4, 21, 20, 40, 229, DateTimeKind.Local).AddTicks(1817), 1, 1 },
                    { 17, 48, null, new DateTime(2020, 3, 4, 21, 20, 40, 229, DateTimeKind.Local).AddTicks(2193), 1, 3 },
                    { 18, 29, "Pas grave. Bande de chiant, on est dimanche ! dégagez !", new DateTime(2020, 3, 4, 21, 20, 40, 229, DateTimeKind.Local).AddTicks(2197), 1, null },
                    { 19, 48, null, new DateTime(2020, 3, 4, 21, 20, 40, 229, DateTimeKind.Local).AddTicks(2201), 1, 4 },
                    { 12, 24, "Oui ?", new DateTime(2020, 3, 4, 21, 20, 40, 229, DateTimeKind.Local).AddTicks(2174), 1, null },
                    { 13, 9, "Connaissez-vous notre seigneur à tous ?", new DateTime(2020, 3, 4, 21, 20, 40, 229, DateTimeKind.Local).AddTicks(2178), 1, null },
                    { 21, 48, null, new DateTime(2020, 3, 4, 21, 20, 40, 229, DateTimeKind.Local).AddTicks(2208), 1, 6 }
                });

            migrationBuilder.InsertData(
                table: "UsersInDiscussion",
                columns: new[] { "Id", "DiscussionId", "JoinedAt", "ParticipantId" },
                values: new object[,]
                {
                    { 52, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 },
                    { 42, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 43, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 44, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 45, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 },
                    { 46, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 },
                    { 51, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 },
                    { 56, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33 },
                    { 47, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 },
                    { 48, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 49, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 },
                    { 54, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 31 },
                    { 50, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 },
                    { 53, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { 55, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 },
                    { 73, 8, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 61, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 38 },
                    { 58, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 },
                    { 74, 8, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 75, 8, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 76, 8, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 77, 8, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 72, 8, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 71, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 48 },
                    { 70, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 47 },
                    { 69, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 46 },
                    { 57, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 34 },
                    { 68, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { 66, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 43 },
                    { 65, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 42 },
                    { 41, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 64, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41 },
                    { 63, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40 },
                    { 62, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39 },
                    { 60, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 37 },
                    { 59, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 36 },
                    { 67, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 44 },
                    { 40, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 23, 6, new DateTime(2019, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
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
                    { 28, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 27, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 26, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 25, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 24, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 78, 8, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 17, 6, new DateTime(2019, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 },
                    { 22, 5, new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 39, 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 79, 8, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 }
                });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "CreatedAt", "Location", "MessageId" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 3, 4, 21, 20, 40, 229, DateTimeKind.Local).AddTicks(3192), "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 10 },
                    { 2, new DateTime(2020, 3, 4, 21, 20, 40, 229, DateTimeKind.Local).AddTicks(3805), "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 11 },
                    { 3, new DateTime(2020, 3, 4, 21, 20, 40, 229, DateTimeKind.Local).AddTicks(3834), "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 17 },
                    { 4, new DateTime(2020, 3, 4, 21, 20, 40, 229, DateTimeKind.Local).AddTicks(3838), null, 19 },
                    { 5, new DateTime(2020, 3, 4, 21, 20, 40, 229, DateTimeKind.Local).AddTicks(3842), "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 20 },
                    { 6, new DateTime(2020, 3, 4, 21, 20, 40, 229, DateTimeKind.Local).AddTicks(3845), "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 21 },
                    { 7, new DateTime(2020, 3, 4, 21, 20, 40, 229, DateTimeKind.Local).AddTicks(3848), null, 27 },
                    { 8, new DateTime(2020, 3, 4, 21, 20, 40, 229, DateTimeKind.Local).AddTicks(3852), "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png", 28 },
                    { 9, new DateTime(2020, 3, 4, 21, 20, 40, 229, DateTimeKind.Local).AddTicks(3855), null, 29 }
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
                name: "FK_Medias_Messages_MessageId",
                table: "Medias",
                column: "MessageId",
                principalTable: "Messages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_Medias_Messages_MessageId",
                table: "Medias");

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
                table: "Medias",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 9);

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
                keyValue: 18);

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
                table: "Messages",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33);

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
                keyValue: 17);

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
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Discussions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Discussions",
                keyColumn: "Id",
                keyValue: 2);

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

            migrationBuilder.AlterColumn<int>(
                name: "MessageId",
                table: "Medias",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Medias",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedAt",
                table: "Medias",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<int>(
                name: "ContainedInId",
                table: "Medias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Extension",
                table: "Medias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Medias",
                type: "varchar(255) CHARACTER SET utf8mb4",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.CreateIndex(
                name: "IX_Medias_Name",
                table: "Medias",
                column: "Name",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Medias_Messages_MessageId",
                table: "Medias",
                column: "MessageId",
                principalTable: "Messages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
