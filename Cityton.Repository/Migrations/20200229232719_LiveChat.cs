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
                values: new object[] { new byte[] { 197, 46, 22, 242, 17, 146, 174, 14, 242, 75, 87, 169, 136, 245, 86, 143, 112, 222, 129, 206, 112, 143, 236, 11, 59, 71, 57, 20, 79, 161, 143, 242, 145, 205, 103, 117, 59, 223, 25, 96, 155, 73, 99, 157, 212, 91, 226, 173, 145, 106, 65, 108, 242, 81, 187, 220, 25, 83, 168, 141, 236, 116, 39, 127 }, new byte[] { 165, 60, 255, 165, 55, 201, 50, 22, 99, 121, 188, 103, 236, 213, 132, 119, 48, 163, 248, 5, 87, 182, 145, 164, 116, 76, 177, 143, 216, 41, 84, 148, 184, 198, 208, 132, 151, 228, 83, 229, 156, 137, 101, 224, 221, 85, 75, 34, 170, 218, 33, 207, 27, 180, 55, 123, 79, 76, 190, 187, 217, 152, 121, 44, 157, 54, 44, 145, 233, 157, 150, 63, 188, 189, 160, 216, 147, 96, 95, 230, 136, 6, 50, 99, 169, 41, 32, 139, 221, 84, 157, 73, 154, 143, 95, 119, 225, 23, 73, 24, 27, 44, 160, 233, 103, 67, 115, 26, 77, 146, 118, 231, 121, 79, 237, 238, 165, 139, 169, 58, 27, 124, 167, 38, 123, 101, 76, 194 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjEiLCJyb2xlIjoiQWRtaW4iLCJuYmYiOjE1ODMwMTg4MzgsImV4cCI6MTU4MzYyMzYzOCwiaWF0IjoxNTgzMDE4ODM4fQ.FcUNHf1kINfprirsCk9_UWbmylrVpzLsUHg0P62X81g" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 197, 46, 22, 242, 17, 146, 174, 14, 242, 75, 87, 169, 136, 245, 86, 143, 112, 222, 129, 206, 112, 143, 236, 11, 59, 71, 57, 20, 79, 161, 143, 242, 145, 205, 103, 117, 59, 223, 25, 96, 155, 73, 99, 157, 212, 91, 226, 173, 145, 106, 65, 108, 242, 81, 187, 220, 25, 83, 168, 141, 236, 116, 39, 127 }, new byte[] { 165, 60, 255, 165, 55, 201, 50, 22, 99, 121, 188, 103, 236, 213, 132, 119, 48, 163, 248, 5, 87, 182, 145, 164, 116, 76, 177, 143, 216, 41, 84, 148, 184, 198, 208, 132, 151, 228, 83, 229, 156, 137, 101, 224, 221, 85, 75, 34, 170, 218, 33, 207, 27, 180, 55, 123, 79, 76, 190, 187, 217, 152, 121, 44, 157, 54, 44, 145, 233, 157, 150, 63, 188, 189, 160, 216, 147, 96, 95, 230, 136, 6, 50, 99, 169, 41, 32, 139, 221, 84, 157, 73, 154, 143, 95, 119, 225, 23, 73, 24, 27, 44, 160, 233, 103, 67, 115, 26, 77, 146, 118, 231, 121, 79, 237, 238, 165, 139, 169, 58, 27, 124, 167, 38, 123, 101, 76, 194 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjIiLCJyb2xlIjoiQWRtaW4iLCJuYmYiOjE1ODMwMTg4MzgsImV4cCI6MTU4MzYyMzYzOCwiaWF0IjoxNTgzMDE4ODM4fQ.y5a54e5L0VOENBSMPkqhmESgVEurXc3CwGSJA-jd3rI" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 197, 46, 22, 242, 17, 146, 174, 14, 242, 75, 87, 169, 136, 245, 86, 143, 112, 222, 129, 206, 112, 143, 236, 11, 59, 71, 57, 20, 79, 161, 143, 242, 145, 205, 103, 117, 59, 223, 25, 96, 155, 73, 99, 157, 212, 91, 226, 173, 145, 106, 65, 108, 242, 81, 187, 220, 25, 83, 168, 141, 236, 116, 39, 127 }, new byte[] { 165, 60, 255, 165, 55, 201, 50, 22, 99, 121, 188, 103, 236, 213, 132, 119, 48, 163, 248, 5, 87, 182, 145, 164, 116, 76, 177, 143, 216, 41, 84, 148, 184, 198, 208, 132, 151, 228, 83, 229, 156, 137, 101, 224, 221, 85, 75, 34, 170, 218, 33, 207, 27, 180, 55, 123, 79, 76, 190, 187, 217, 152, 121, 44, 157, 54, 44, 145, 233, 157, 150, 63, 188, 189, 160, 216, 147, 96, 95, 230, 136, 6, 50, 99, 169, 41, 32, 139, 221, 84, 157, 73, 154, 143, 95, 119, 225, 23, 73, 24, 27, 44, 160, 233, 103, 67, 115, 26, 77, 146, 118, 231, 121, 79, 237, 238, 165, 139, 169, 58, 27, 124, 167, 38, 123, 101, 76, 194 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjMiLCJyb2xlIjoiQWRtaW4iLCJuYmYiOjE1ODMwMTg4MzgsImV4cCI6MTU4MzYyMzYzOCwiaWF0IjoxNTgzMDE4ODM4fQ.YoyqyK96O4us0nA2Vq7b55lt-H2-AM2NAZ2ZTxNC5dI" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 197, 46, 22, 242, 17, 146, 174, 14, 242, 75, 87, 169, 136, 245, 86, 143, 112, 222, 129, 206, 112, 143, 236, 11, 59, 71, 57, 20, 79, 161, 143, 242, 145, 205, 103, 117, 59, 223, 25, 96, 155, 73, 99, 157, 212, 91, 226, 173, 145, 106, 65, 108, 242, 81, 187, 220, 25, 83, 168, 141, 236, 116, 39, 127 }, new byte[] { 165, 60, 255, 165, 55, 201, 50, 22, 99, 121, 188, 103, 236, 213, 132, 119, 48, 163, 248, 5, 87, 182, 145, 164, 116, 76, 177, 143, 216, 41, 84, 148, 184, 198, 208, 132, 151, 228, 83, 229, 156, 137, 101, 224, 221, 85, 75, 34, 170, 218, 33, 207, 27, 180, 55, 123, 79, 76, 190, 187, 217, 152, 121, 44, 157, 54, 44, 145, 233, 157, 150, 63, 188, 189, 160, 216, 147, 96, 95, 230, 136, 6, 50, 99, 169, 41, 32, 139, 221, 84, 157, 73, 154, 143, 95, 119, 225, 23, 73, 24, 27, 44, 160, 233, 103, 67, 115, 26, 77, 146, 118, 231, 121, 79, 237, 238, 165, 139, 169, 58, 27, 124, 167, 38, 123, 101, 76, 194 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjQiLCJyb2xlIjoiQWRtaW4iLCJuYmYiOjE1ODMwMTg4MzgsImV4cCI6MTU4MzYyMzYzOCwiaWF0IjoxNTgzMDE4ODM4fQ.OPBNpoOTVmEMaBxM3fDcPbX70O0jkmDeC71IhjGdLpo" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 197, 46, 22, 242, 17, 146, 174, 14, 242, 75, 87, 169, 136, 245, 86, 143, 112, 222, 129, 206, 112, 143, 236, 11, 59, 71, 57, 20, 79, 161, 143, 242, 145, 205, 103, 117, 59, 223, 25, 96, 155, 73, 99, 157, 212, 91, 226, 173, 145, 106, 65, 108, 242, 81, 187, 220, 25, 83, 168, 141, 236, 116, 39, 127 }, new byte[] { 165, 60, 255, 165, 55, 201, 50, 22, 99, 121, 188, 103, 236, 213, 132, 119, 48, 163, 248, 5, 87, 182, 145, 164, 116, 76, 177, 143, 216, 41, 84, 148, 184, 198, 208, 132, 151, 228, 83, 229, 156, 137, 101, 224, 221, 85, 75, 34, 170, 218, 33, 207, 27, 180, 55, 123, 79, 76, 190, 187, 217, 152, 121, 44, 157, 54, 44, 145, 233, 157, 150, 63, 188, 189, 160, 216, 147, 96, 95, 230, 136, 6, 50, 99, 169, 41, 32, 139, 221, 84, 157, 73, 154, 143, 95, 119, 225, 23, 73, 24, 27, 44, 160, 233, 103, 67, 115, 26, 77, 146, 118, 231, 121, 79, 237, 238, 165, 139, 169, 58, 27, 124, 167, 38, 123, 101, 76, 194 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjUiLCJyb2xlIjoiQWRtaW4iLCJuYmYiOjE1ODMwMTg4MzgsImV4cCI6MTU4MzYyMzYzOCwiaWF0IjoxNTgzMDE4ODM4fQ.DUItChjwWZLNAFD4SJSNyOTwFIGJ9e4ZohazaPUh6YM" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 197, 46, 22, 242, 17, 146, 174, 14, 242, 75, 87, 169, 136, 245, 86, 143, 112, 222, 129, 206, 112, 143, 236, 11, 59, 71, 57, 20, 79, 161, 143, 242, 145, 205, 103, 117, 59, 223, 25, 96, 155, 73, 99, 157, 212, 91, 226, 173, 145, 106, 65, 108, 242, 81, 187, 220, 25, 83, 168, 141, 236, 116, 39, 127 }, new byte[] { 165, 60, 255, 165, 55, 201, 50, 22, 99, 121, 188, 103, 236, 213, 132, 119, 48, 163, 248, 5, 87, 182, 145, 164, 116, 76, 177, 143, 216, 41, 84, 148, 184, 198, 208, 132, 151, 228, 83, 229, 156, 137, 101, 224, 221, 85, 75, 34, 170, 218, 33, 207, 27, 180, 55, 123, 79, 76, 190, 187, 217, 152, 121, 44, 157, 54, 44, 145, 233, 157, 150, 63, 188, 189, 160, 216, 147, 96, 95, 230, 136, 6, 50, 99, 169, 41, 32, 139, 221, 84, 157, 73, 154, 143, 95, 119, 225, 23, 73, 24, 27, 44, 160, 233, 103, 67, 115, 26, 77, 146, 118, 231, 121, 79, 237, 238, 165, 139, 169, 58, 27, 124, 167, 38, 123, 101, 76, 194 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjYiLCJyb2xlIjoiQ2hlY2tlciIsIm5iZiI6MTU4MzAxODgzOCwiZXhwIjoxNTgzNjIzNjM4LCJpYXQiOjE1ODMwMTg4Mzh9.4_le9iu2Sq662_SJvlQCKxlOJXKaBhPqni22EWzR-vE" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 197, 46, 22, 242, 17, 146, 174, 14, 242, 75, 87, 169, 136, 245, 86, 143, 112, 222, 129, 206, 112, 143, 236, 11, 59, 71, 57, 20, 79, 161, 143, 242, 145, 205, 103, 117, 59, 223, 25, 96, 155, 73, 99, 157, 212, 91, 226, 173, 145, 106, 65, 108, 242, 81, 187, 220, 25, 83, 168, 141, 236, 116, 39, 127 }, new byte[] { 165, 60, 255, 165, 55, 201, 50, 22, 99, 121, 188, 103, 236, 213, 132, 119, 48, 163, 248, 5, 87, 182, 145, 164, 116, 76, 177, 143, 216, 41, 84, 148, 184, 198, 208, 132, 151, 228, 83, 229, 156, 137, 101, 224, 221, 85, 75, 34, 170, 218, 33, 207, 27, 180, 55, 123, 79, 76, 190, 187, 217, 152, 121, 44, 157, 54, 44, 145, 233, 157, 150, 63, 188, 189, 160, 216, 147, 96, 95, 230, 136, 6, 50, 99, 169, 41, 32, 139, 221, 84, 157, 73, 154, 143, 95, 119, 225, 23, 73, 24, 27, 44, 160, 233, 103, 67, 115, 26, 77, 146, 118, 231, 121, 79, 237, 238, 165, 139, 169, 58, 27, 124, 167, 38, 123, 101, 76, 194 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjciLCJyb2xlIjoiQ2hlY2tlciIsIm5iZiI6MTU4MzAxODgzOCwiZXhwIjoxNTgzNjIzNjM4LCJpYXQiOjE1ODMwMTg4Mzh9.I3Cib6V_OkS3mRHyw_LfeYmkrEwDjLzUVAPOuanbzrw" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 197, 46, 22, 242, 17, 146, 174, 14, 242, 75, 87, 169, 136, 245, 86, 143, 112, 222, 129, 206, 112, 143, 236, 11, 59, 71, 57, 20, 79, 161, 143, 242, 145, 205, 103, 117, 59, 223, 25, 96, 155, 73, 99, 157, 212, 91, 226, 173, 145, 106, 65, 108, 242, 81, 187, 220, 25, 83, 168, 141, 236, 116, 39, 127 }, new byte[] { 165, 60, 255, 165, 55, 201, 50, 22, 99, 121, 188, 103, 236, 213, 132, 119, 48, 163, 248, 5, 87, 182, 145, 164, 116, 76, 177, 143, 216, 41, 84, 148, 184, 198, 208, 132, 151, 228, 83, 229, 156, 137, 101, 224, 221, 85, 75, 34, 170, 218, 33, 207, 27, 180, 55, 123, 79, 76, 190, 187, 217, 152, 121, 44, 157, 54, 44, 145, 233, 157, 150, 63, 188, 189, 160, 216, 147, 96, 95, 230, 136, 6, 50, 99, 169, 41, 32, 139, 221, 84, 157, 73, 154, 143, 95, 119, 225, 23, 73, 24, 27, 44, 160, 233, 103, 67, 115, 26, 77, 146, 118, 231, 121, 79, 237, 238, 165, 139, 169, 58, 27, 124, 167, 38, 123, 101, 76, 194 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjgiLCJyb2xlIjoiQ2hlY2tlciIsIm5iZiI6MTU4MzAxODgzOCwiZXhwIjoxNTgzNjIzNjM4LCJpYXQiOjE1ODMwMTg4Mzh9.5sLKBQdZseJYrimbHFJuZWf7K3jws7Bks0TEYS3GctA" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 197, 46, 22, 242, 17, 146, 174, 14, 242, 75, 87, 169, 136, 245, 86, 143, 112, 222, 129, 206, 112, 143, 236, 11, 59, 71, 57, 20, 79, 161, 143, 242, 145, 205, 103, 117, 59, 223, 25, 96, 155, 73, 99, 157, 212, 91, 226, 173, 145, 106, 65, 108, 242, 81, 187, 220, 25, 83, 168, 141, 236, 116, 39, 127 }, new byte[] { 165, 60, 255, 165, 55, 201, 50, 22, 99, 121, 188, 103, 236, 213, 132, 119, 48, 163, 248, 5, 87, 182, 145, 164, 116, 76, 177, 143, 216, 41, 84, 148, 184, 198, 208, 132, 151, 228, 83, 229, 156, 137, 101, 224, 221, 85, 75, 34, 170, 218, 33, 207, 27, 180, 55, 123, 79, 76, 190, 187, 217, 152, 121, 44, 157, 54, 44, 145, 233, 157, 150, 63, 188, 189, 160, 216, 147, 96, 95, 230, 136, 6, 50, 99, 169, 41, 32, 139, 221, 84, 157, 73, 154, 143, 95, 119, 225, 23, 73, 24, 27, 44, 160, 233, 103, 67, 115, 26, 77, 146, 118, 231, 121, 79, 237, 238, 165, 139, 169, 58, 27, 124, 167, 38, 123, 101, 76, 194 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjkiLCJyb2xlIjoiTWVtYmVyIiwibmJmIjoxNTgzMDE4ODM4LCJleHAiOjE1ODM2MjM2MzgsImlhdCI6MTU4MzAxODgzOH0.fZrmqAqSFGPOdZuv9jFgUsVbAZHEqmr6Eor_UaTiKlA" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 197, 46, 22, 242, 17, 146, 174, 14, 242, 75, 87, 169, 136, 245, 86, 143, 112, 222, 129, 206, 112, 143, 236, 11, 59, 71, 57, 20, 79, 161, 143, 242, 145, 205, 103, 117, 59, 223, 25, 96, 155, 73, 99, 157, 212, 91, 226, 173, 145, 106, 65, 108, 242, 81, 187, 220, 25, 83, 168, 141, 236, 116, 39, 127 }, new byte[] { 165, 60, 255, 165, 55, 201, 50, 22, 99, 121, 188, 103, 236, 213, 132, 119, 48, 163, 248, 5, 87, 182, 145, 164, 116, 76, 177, 143, 216, 41, 84, 148, 184, 198, 208, 132, 151, 228, 83, 229, 156, 137, 101, 224, 221, 85, 75, 34, 170, 218, 33, 207, 27, 180, 55, 123, 79, 76, 190, 187, 217, 152, 121, 44, 157, 54, 44, 145, 233, 157, 150, 63, 188, 189, 160, 216, 147, 96, 95, 230, 136, 6, 50, 99, 169, 41, 32, 139, 221, 84, 157, 73, 154, 143, 95, 119, 225, 23, 73, 24, 27, 44, 160, 233, 103, 67, 115, 26, 77, 146, 118, 231, 121, 79, 237, 238, 165, 139, 169, 58, 27, 124, 167, 38, 123, 101, 76, 194 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjEwIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzAxODgzOCwiZXhwIjoxNTgzNjIzNjM4LCJpYXQiOjE1ODMwMTg4Mzh9.iKJeJxSBUTCM41Fm0H-7GRLyXGLnJfHqtdFNv1J1SfU" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 197, 46, 22, 242, 17, 146, 174, 14, 242, 75, 87, 169, 136, 245, 86, 143, 112, 222, 129, 206, 112, 143, 236, 11, 59, 71, 57, 20, 79, 161, 143, 242, 145, 205, 103, 117, 59, 223, 25, 96, 155, 73, 99, 157, 212, 91, 226, 173, 145, 106, 65, 108, 242, 81, 187, 220, 25, 83, 168, 141, 236, 116, 39, 127 }, new byte[] { 165, 60, 255, 165, 55, 201, 50, 22, 99, 121, 188, 103, 236, 213, 132, 119, 48, 163, 248, 5, 87, 182, 145, 164, 116, 76, 177, 143, 216, 41, 84, 148, 184, 198, 208, 132, 151, 228, 83, 229, 156, 137, 101, 224, 221, 85, 75, 34, 170, 218, 33, 207, 27, 180, 55, 123, 79, 76, 190, 187, 217, 152, 121, 44, 157, 54, 44, 145, 233, 157, 150, 63, 188, 189, 160, 216, 147, 96, 95, 230, 136, 6, 50, 99, 169, 41, 32, 139, 221, 84, 157, 73, 154, 143, 95, 119, 225, 23, 73, 24, 27, 44, 160, 233, 103, 67, 115, 26, 77, 146, 118, 231, 121, 79, 237, 238, 165, 139, 169, 58, 27, 124, 167, 38, 123, 101, 76, 194 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjExIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzAxODgzOCwiZXhwIjoxNTgzNjIzNjM4LCJpYXQiOjE1ODMwMTg4Mzh9.Rgl5jILPiJ_42YsqsCT3Vghxo6GdmK858p1JjIOy_fI" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 197, 46, 22, 242, 17, 146, 174, 14, 242, 75, 87, 169, 136, 245, 86, 143, 112, 222, 129, 206, 112, 143, 236, 11, 59, 71, 57, 20, 79, 161, 143, 242, 145, 205, 103, 117, 59, 223, 25, 96, 155, 73, 99, 157, 212, 91, 226, 173, 145, 106, 65, 108, 242, 81, 187, 220, 25, 83, 168, 141, 236, 116, 39, 127 }, new byte[] { 165, 60, 255, 165, 55, 201, 50, 22, 99, 121, 188, 103, 236, 213, 132, 119, 48, 163, 248, 5, 87, 182, 145, 164, 116, 76, 177, 143, 216, 41, 84, 148, 184, 198, 208, 132, 151, 228, 83, 229, 156, 137, 101, 224, 221, 85, 75, 34, 170, 218, 33, 207, 27, 180, 55, 123, 79, 76, 190, 187, 217, 152, 121, 44, 157, 54, 44, 145, 233, 157, 150, 63, 188, 189, 160, 216, 147, 96, 95, 230, 136, 6, 50, 99, 169, 41, 32, 139, 221, 84, 157, 73, 154, 143, 95, 119, 225, 23, 73, 24, 27, 44, 160, 233, 103, 67, 115, 26, 77, 146, 118, 231, 121, 79, 237, 238, 165, 139, 169, 58, 27, 124, 167, 38, 123, 101, 76, 194 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjEyIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzAxODgzOCwiZXhwIjoxNTgzNjIzNjM4LCJpYXQiOjE1ODMwMTg4Mzh9.Nx28p6u4SG_6an2EgQrDPRvY2LJuWlDS0mY1djsPv7w" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 197, 46, 22, 242, 17, 146, 174, 14, 242, 75, 87, 169, 136, 245, 86, 143, 112, 222, 129, 206, 112, 143, 236, 11, 59, 71, 57, 20, 79, 161, 143, 242, 145, 205, 103, 117, 59, 223, 25, 96, 155, 73, 99, 157, 212, 91, 226, 173, 145, 106, 65, 108, 242, 81, 187, 220, 25, 83, 168, 141, 236, 116, 39, 127 }, new byte[] { 165, 60, 255, 165, 55, 201, 50, 22, 99, 121, 188, 103, 236, 213, 132, 119, 48, 163, 248, 5, 87, 182, 145, 164, 116, 76, 177, 143, 216, 41, 84, 148, 184, 198, 208, 132, 151, 228, 83, 229, 156, 137, 101, 224, 221, 85, 75, 34, 170, 218, 33, 207, 27, 180, 55, 123, 79, 76, 190, 187, 217, 152, 121, 44, 157, 54, 44, 145, 233, 157, 150, 63, 188, 189, 160, 216, 147, 96, 95, 230, 136, 6, 50, 99, 169, 41, 32, 139, 221, 84, 157, 73, 154, 143, 95, 119, 225, 23, 73, 24, 27, 44, 160, 233, 103, 67, 115, 26, 77, 146, 118, 231, 121, 79, 237, 238, 165, 139, 169, 58, 27, 124, 167, 38, 123, 101, 76, 194 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjEzIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzAxODgzOCwiZXhwIjoxNTgzNjIzNjM4LCJpYXQiOjE1ODMwMTg4Mzh9.MYEn-gb2Mv3YzoUHpQFB1qxQNEjiSrR92Kfuxi9VhVQ" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 197, 46, 22, 242, 17, 146, 174, 14, 242, 75, 87, 169, 136, 245, 86, 143, 112, 222, 129, 206, 112, 143, 236, 11, 59, 71, 57, 20, 79, 161, 143, 242, 145, 205, 103, 117, 59, 223, 25, 96, 155, 73, 99, 157, 212, 91, 226, 173, 145, 106, 65, 108, 242, 81, 187, 220, 25, 83, 168, 141, 236, 116, 39, 127 }, new byte[] { 165, 60, 255, 165, 55, 201, 50, 22, 99, 121, 188, 103, 236, 213, 132, 119, 48, 163, 248, 5, 87, 182, 145, 164, 116, 76, 177, 143, 216, 41, 84, 148, 184, 198, 208, 132, 151, 228, 83, 229, 156, 137, 101, 224, 221, 85, 75, 34, 170, 218, 33, 207, 27, 180, 55, 123, 79, 76, 190, 187, 217, 152, 121, 44, 157, 54, 44, 145, 233, 157, 150, 63, 188, 189, 160, 216, 147, 96, 95, 230, 136, 6, 50, 99, 169, 41, 32, 139, 221, 84, 157, 73, 154, 143, 95, 119, 225, 23, 73, 24, 27, 44, 160, 233, 103, 67, 115, 26, 77, 146, 118, 231, 121, 79, 237, 238, 165, 139, 169, 58, 27, 124, 167, 38, 123, 101, 76, 194 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjE0Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzAxODgzOCwiZXhwIjoxNTgzNjIzNjM4LCJpYXQiOjE1ODMwMTg4Mzh9.OP-1codTXj-Ga2Qi2DUz0Lf5zpVc-sTewRtmje10Ovg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 197, 46, 22, 242, 17, 146, 174, 14, 242, 75, 87, 169, 136, 245, 86, 143, 112, 222, 129, 206, 112, 143, 236, 11, 59, 71, 57, 20, 79, 161, 143, 242, 145, 205, 103, 117, 59, 223, 25, 96, 155, 73, 99, 157, 212, 91, 226, 173, 145, 106, 65, 108, 242, 81, 187, 220, 25, 83, 168, 141, 236, 116, 39, 127 }, new byte[] { 165, 60, 255, 165, 55, 201, 50, 22, 99, 121, 188, 103, 236, 213, 132, 119, 48, 163, 248, 5, 87, 182, 145, 164, 116, 76, 177, 143, 216, 41, 84, 148, 184, 198, 208, 132, 151, 228, 83, 229, 156, 137, 101, 224, 221, 85, 75, 34, 170, 218, 33, 207, 27, 180, 55, 123, 79, 76, 190, 187, 217, 152, 121, 44, 157, 54, 44, 145, 233, 157, 150, 63, 188, 189, 160, 216, 147, 96, 95, 230, 136, 6, 50, 99, 169, 41, 32, 139, 221, 84, 157, 73, 154, 143, 95, 119, 225, 23, 73, 24, 27, 44, 160, 233, 103, 67, 115, 26, 77, 146, 118, 231, 121, 79, 237, 238, 165, 139, 169, 58, 27, 124, 167, 38, 123, 101, 76, 194 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjE1Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzAxODgzOCwiZXhwIjoxNTgzNjIzNjM4LCJpYXQiOjE1ODMwMTg4Mzh9.DHovsoPrjq4nnhGRcYNOhUNGohKPUC2diy_H-pzJxMA" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 197, 46, 22, 242, 17, 146, 174, 14, 242, 75, 87, 169, 136, 245, 86, 143, 112, 222, 129, 206, 112, 143, 236, 11, 59, 71, 57, 20, 79, 161, 143, 242, 145, 205, 103, 117, 59, 223, 25, 96, 155, 73, 99, 157, 212, 91, 226, 173, 145, 106, 65, 108, 242, 81, 187, 220, 25, 83, 168, 141, 236, 116, 39, 127 }, new byte[] { 165, 60, 255, 165, 55, 201, 50, 22, 99, 121, 188, 103, 236, 213, 132, 119, 48, 163, 248, 5, 87, 182, 145, 164, 116, 76, 177, 143, 216, 41, 84, 148, 184, 198, 208, 132, 151, 228, 83, 229, 156, 137, 101, 224, 221, 85, 75, 34, 170, 218, 33, 207, 27, 180, 55, 123, 79, 76, 190, 187, 217, 152, 121, 44, 157, 54, 44, 145, 233, 157, 150, 63, 188, 189, 160, 216, 147, 96, 95, 230, 136, 6, 50, 99, 169, 41, 32, 139, 221, 84, 157, 73, 154, 143, 95, 119, 225, 23, 73, 24, 27, 44, 160, 233, 103, 67, 115, 26, 77, 146, 118, 231, 121, 79, 237, 238, 165, 139, 169, 58, 27, 124, 167, 38, 123, 101, 76, 194 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjE2Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzAxODgzOCwiZXhwIjoxNTgzNjIzNjM4LCJpYXQiOjE1ODMwMTg4Mzh9.vBWeZGGSEPuZKrcf5pN7MujmV8M2I7MlVO2kJk3YukQ" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 197, 46, 22, 242, 17, 146, 174, 14, 242, 75, 87, 169, 136, 245, 86, 143, 112, 222, 129, 206, 112, 143, 236, 11, 59, 71, 57, 20, 79, 161, 143, 242, 145, 205, 103, 117, 59, 223, 25, 96, 155, 73, 99, 157, 212, 91, 226, 173, 145, 106, 65, 108, 242, 81, 187, 220, 25, 83, 168, 141, 236, 116, 39, 127 }, new byte[] { 165, 60, 255, 165, 55, 201, 50, 22, 99, 121, 188, 103, 236, 213, 132, 119, 48, 163, 248, 5, 87, 182, 145, 164, 116, 76, 177, 143, 216, 41, 84, 148, 184, 198, 208, 132, 151, 228, 83, 229, 156, 137, 101, 224, 221, 85, 75, 34, 170, 218, 33, 207, 27, 180, 55, 123, 79, 76, 190, 187, 217, 152, 121, 44, 157, 54, 44, 145, 233, 157, 150, 63, 188, 189, 160, 216, 147, 96, 95, 230, 136, 6, 50, 99, 169, 41, 32, 139, 221, 84, 157, 73, 154, 143, 95, 119, 225, 23, 73, 24, 27, 44, 160, 233, 103, 67, 115, 26, 77, 146, 118, 231, 121, 79, 237, 238, 165, 139, 169, 58, 27, 124, 167, 38, 123, 101, 76, 194 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjE3Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzAxODgzOCwiZXhwIjoxNTgzNjIzNjM4LCJpYXQiOjE1ODMwMTg4Mzh9.NEYJzpXyxXxS8txyLPP0d-8ThMNcGgxuspLgCq-qusg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 197, 46, 22, 242, 17, 146, 174, 14, 242, 75, 87, 169, 136, 245, 86, 143, 112, 222, 129, 206, 112, 143, 236, 11, 59, 71, 57, 20, 79, 161, 143, 242, 145, 205, 103, 117, 59, 223, 25, 96, 155, 73, 99, 157, 212, 91, 226, 173, 145, 106, 65, 108, 242, 81, 187, 220, 25, 83, 168, 141, 236, 116, 39, 127 }, new byte[] { 165, 60, 255, 165, 55, 201, 50, 22, 99, 121, 188, 103, 236, 213, 132, 119, 48, 163, 248, 5, 87, 182, 145, 164, 116, 76, 177, 143, 216, 41, 84, 148, 184, 198, 208, 132, 151, 228, 83, 229, 156, 137, 101, 224, 221, 85, 75, 34, 170, 218, 33, 207, 27, 180, 55, 123, 79, 76, 190, 187, 217, 152, 121, 44, 157, 54, 44, 145, 233, 157, 150, 63, 188, 189, 160, 216, 147, 96, 95, 230, 136, 6, 50, 99, 169, 41, 32, 139, 221, 84, 157, 73, 154, 143, 95, 119, 225, 23, 73, 24, 27, 44, 160, 233, 103, 67, 115, 26, 77, 146, 118, 231, 121, 79, 237, 238, 165, 139, 169, 58, 27, 124, 167, 38, 123, 101, 76, 194 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjE4Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzAxODgzOCwiZXhwIjoxNTgzNjIzNjM4LCJpYXQiOjE1ODMwMTg4Mzh9.hyiWoPGjvMBZLciFg7pybhPLBtKxJtxJ4KVqAqmckDg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 197, 46, 22, 242, 17, 146, 174, 14, 242, 75, 87, 169, 136, 245, 86, 143, 112, 222, 129, 206, 112, 143, 236, 11, 59, 71, 57, 20, 79, 161, 143, 242, 145, 205, 103, 117, 59, 223, 25, 96, 155, 73, 99, 157, 212, 91, 226, 173, 145, 106, 65, 108, 242, 81, 187, 220, 25, 83, 168, 141, 236, 116, 39, 127 }, new byte[] { 165, 60, 255, 165, 55, 201, 50, 22, 99, 121, 188, 103, 236, 213, 132, 119, 48, 163, 248, 5, 87, 182, 145, 164, 116, 76, 177, 143, 216, 41, 84, 148, 184, 198, 208, 132, 151, 228, 83, 229, 156, 137, 101, 224, 221, 85, 75, 34, 170, 218, 33, 207, 27, 180, 55, 123, 79, 76, 190, 187, 217, 152, 121, 44, 157, 54, 44, 145, 233, 157, 150, 63, 188, 189, 160, 216, 147, 96, 95, 230, 136, 6, 50, 99, 169, 41, 32, 139, 221, 84, 157, 73, 154, 143, 95, 119, 225, 23, 73, 24, 27, 44, 160, 233, 103, 67, 115, 26, 77, 146, 118, 231, 121, 79, 237, 238, 165, 139, 169, 58, 27, 124, 167, 38, 123, 101, 76, 194 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjE5Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzAxODgzOCwiZXhwIjoxNTgzNjIzNjM4LCJpYXQiOjE1ODMwMTg4Mzh9.bRbhQjwqVI8kneta0vr0LC-NMp99_uFQDrDtiFrME6c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 197, 46, 22, 242, 17, 146, 174, 14, 242, 75, 87, 169, 136, 245, 86, 143, 112, 222, 129, 206, 112, 143, 236, 11, 59, 71, 57, 20, 79, 161, 143, 242, 145, 205, 103, 117, 59, 223, 25, 96, 155, 73, 99, 157, 212, 91, 226, 173, 145, 106, 65, 108, 242, 81, 187, 220, 25, 83, 168, 141, 236, 116, 39, 127 }, new byte[] { 165, 60, 255, 165, 55, 201, 50, 22, 99, 121, 188, 103, 236, 213, 132, 119, 48, 163, 248, 5, 87, 182, 145, 164, 116, 76, 177, 143, 216, 41, 84, 148, 184, 198, 208, 132, 151, 228, 83, 229, 156, 137, 101, 224, 221, 85, 75, 34, 170, 218, 33, 207, 27, 180, 55, 123, 79, 76, 190, 187, 217, 152, 121, 44, 157, 54, 44, 145, 233, 157, 150, 63, 188, 189, 160, 216, 147, 96, 95, 230, 136, 6, 50, 99, 169, 41, 32, 139, 221, 84, 157, 73, 154, 143, 95, 119, 225, 23, 73, 24, 27, 44, 160, 233, 103, 67, 115, 26, 77, 146, 118, 231, 121, 79, 237, 238, 165, 139, 169, 58, 27, 124, 167, 38, 123, 101, 76, 194 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjIwIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzAxODgzOCwiZXhwIjoxNTgzNjIzNjM4LCJpYXQiOjE1ODMwMTg4Mzh9.nmkfmW1vTZCwAThrCgtksfYkG54zODrcZWwKLdT-lRM" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 197, 46, 22, 242, 17, 146, 174, 14, 242, 75, 87, 169, 136, 245, 86, 143, 112, 222, 129, 206, 112, 143, 236, 11, 59, 71, 57, 20, 79, 161, 143, 242, 145, 205, 103, 117, 59, 223, 25, 96, 155, 73, 99, 157, 212, 91, 226, 173, 145, 106, 65, 108, 242, 81, 187, 220, 25, 83, 168, 141, 236, 116, 39, 127 }, new byte[] { 165, 60, 255, 165, 55, 201, 50, 22, 99, 121, 188, 103, 236, 213, 132, 119, 48, 163, 248, 5, 87, 182, 145, 164, 116, 76, 177, 143, 216, 41, 84, 148, 184, 198, 208, 132, 151, 228, 83, 229, 156, 137, 101, 224, 221, 85, 75, 34, 170, 218, 33, 207, 27, 180, 55, 123, 79, 76, 190, 187, 217, 152, 121, 44, 157, 54, 44, 145, 233, 157, 150, 63, 188, 189, 160, 216, 147, 96, 95, 230, 136, 6, 50, 99, 169, 41, 32, 139, 221, 84, 157, 73, 154, 143, 95, 119, 225, 23, 73, 24, 27, 44, 160, 233, 103, 67, 115, 26, 77, 146, 118, 231, 121, 79, 237, 238, 165, 139, 169, 58, 27, 124, 167, 38, 123, 101, 76, 194 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjIxIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzAxODgzOCwiZXhwIjoxNTgzNjIzNjM4LCJpYXQiOjE1ODMwMTg4Mzh9.edyL4HweIxZiJtc_hI8Z6kgbQbYplLtIkNQnpZs1F5A" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 197, 46, 22, 242, 17, 146, 174, 14, 242, 75, 87, 169, 136, 245, 86, 143, 112, 222, 129, 206, 112, 143, 236, 11, 59, 71, 57, 20, 79, 161, 143, 242, 145, 205, 103, 117, 59, 223, 25, 96, 155, 73, 99, 157, 212, 91, 226, 173, 145, 106, 65, 108, 242, 81, 187, 220, 25, 83, 168, 141, 236, 116, 39, 127 }, new byte[] { 165, 60, 255, 165, 55, 201, 50, 22, 99, 121, 188, 103, 236, 213, 132, 119, 48, 163, 248, 5, 87, 182, 145, 164, 116, 76, 177, 143, 216, 41, 84, 148, 184, 198, 208, 132, 151, 228, 83, 229, 156, 137, 101, 224, 221, 85, 75, 34, 170, 218, 33, 207, 27, 180, 55, 123, 79, 76, 190, 187, 217, 152, 121, 44, 157, 54, 44, 145, 233, 157, 150, 63, 188, 189, 160, 216, 147, 96, 95, 230, 136, 6, 50, 99, 169, 41, 32, 139, 221, 84, 157, 73, 154, 143, 95, 119, 225, 23, 73, 24, 27, 44, 160, 233, 103, 67, 115, 26, 77, 146, 118, 231, 121, 79, 237, 238, 165, 139, 169, 58, 27, 124, 167, 38, 123, 101, 76, 194 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjIyIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzAxODgzOCwiZXhwIjoxNTgzNjIzNjM4LCJpYXQiOjE1ODMwMTg4Mzh9.Uu032C8-uyPfwgYSBZy1augJ2k9gD8rHY-2dmVhsLwQ" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 197, 46, 22, 242, 17, 146, 174, 14, 242, 75, 87, 169, 136, 245, 86, 143, 112, 222, 129, 206, 112, 143, 236, 11, 59, 71, 57, 20, 79, 161, 143, 242, 145, 205, 103, 117, 59, 223, 25, 96, 155, 73, 99, 157, 212, 91, 226, 173, 145, 106, 65, 108, 242, 81, 187, 220, 25, 83, 168, 141, 236, 116, 39, 127 }, new byte[] { 165, 60, 255, 165, 55, 201, 50, 22, 99, 121, 188, 103, 236, 213, 132, 119, 48, 163, 248, 5, 87, 182, 145, 164, 116, 76, 177, 143, 216, 41, 84, 148, 184, 198, 208, 132, 151, 228, 83, 229, 156, 137, 101, 224, 221, 85, 75, 34, 170, 218, 33, 207, 27, 180, 55, 123, 79, 76, 190, 187, 217, 152, 121, 44, 157, 54, 44, 145, 233, 157, 150, 63, 188, 189, 160, 216, 147, 96, 95, 230, 136, 6, 50, 99, 169, 41, 32, 139, 221, 84, 157, 73, 154, 143, 95, 119, 225, 23, 73, 24, 27, 44, 160, 233, 103, 67, 115, 26, 77, 146, 118, 231, 121, 79, 237, 238, 165, 139, 169, 58, 27, 124, 167, 38, 123, 101, 76, 194 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjIzIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzAxODgzOCwiZXhwIjoxNTgzNjIzNjM4LCJpYXQiOjE1ODMwMTg4Mzh9.Qd69dzdk5k0y2wtN2H7medS9z56Cb33Ko6w3X4DYz0k" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 197, 46, 22, 242, 17, 146, 174, 14, 242, 75, 87, 169, 136, 245, 86, 143, 112, 222, 129, 206, 112, 143, 236, 11, 59, 71, 57, 20, 79, 161, 143, 242, 145, 205, 103, 117, 59, 223, 25, 96, 155, 73, 99, 157, 212, 91, 226, 173, 145, 106, 65, 108, 242, 81, 187, 220, 25, 83, 168, 141, 236, 116, 39, 127 }, new byte[] { 165, 60, 255, 165, 55, 201, 50, 22, 99, 121, 188, 103, 236, 213, 132, 119, 48, 163, 248, 5, 87, 182, 145, 164, 116, 76, 177, 143, 216, 41, 84, 148, 184, 198, 208, 132, 151, 228, 83, 229, 156, 137, 101, 224, 221, 85, 75, 34, 170, 218, 33, 207, 27, 180, 55, 123, 79, 76, 190, 187, 217, 152, 121, 44, 157, 54, 44, 145, 233, 157, 150, 63, 188, 189, 160, 216, 147, 96, 95, 230, 136, 6, 50, 99, 169, 41, 32, 139, 221, 84, 157, 73, 154, 143, 95, 119, 225, 23, 73, 24, 27, 44, 160, 233, 103, 67, 115, 26, 77, 146, 118, 231, 121, 79, 237, 238, 165, 139, 169, 58, 27, 124, 167, 38, 123, 101, 76, 194 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjI0Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzAxODgzOCwiZXhwIjoxNTgzNjIzNjM4LCJpYXQiOjE1ODMwMTg4Mzh9.kFYg9R2xFBE00t8gycLsPnrzaPn045SDk39tpqmWoMM" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 197, 46, 22, 242, 17, 146, 174, 14, 242, 75, 87, 169, 136, 245, 86, 143, 112, 222, 129, 206, 112, 143, 236, 11, 59, 71, 57, 20, 79, 161, 143, 242, 145, 205, 103, 117, 59, 223, 25, 96, 155, 73, 99, 157, 212, 91, 226, 173, 145, 106, 65, 108, 242, 81, 187, 220, 25, 83, 168, 141, 236, 116, 39, 127 }, new byte[] { 165, 60, 255, 165, 55, 201, 50, 22, 99, 121, 188, 103, 236, 213, 132, 119, 48, 163, 248, 5, 87, 182, 145, 164, 116, 76, 177, 143, 216, 41, 84, 148, 184, 198, 208, 132, 151, 228, 83, 229, 156, 137, 101, 224, 221, 85, 75, 34, 170, 218, 33, 207, 27, 180, 55, 123, 79, 76, 190, 187, 217, 152, 121, 44, 157, 54, 44, 145, 233, 157, 150, 63, 188, 189, 160, 216, 147, 96, 95, 230, 136, 6, 50, 99, 169, 41, 32, 139, 221, 84, 157, 73, 154, 143, 95, 119, 225, 23, 73, 24, 27, 44, 160, 233, 103, 67, 115, 26, 77, 146, 118, 231, 121, 79, 237, 238, 165, 139, 169, 58, 27, 124, 167, 38, 123, 101, 76, 194 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjI1Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzAxODgzOCwiZXhwIjoxNTgzNjIzNjM4LCJpYXQiOjE1ODMwMTg4Mzh9.xbSfJhWBMatZ1S1qHPbMAI0R0sb4N9DvU80EiPa-Wck" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 197, 46, 22, 242, 17, 146, 174, 14, 242, 75, 87, 169, 136, 245, 86, 143, 112, 222, 129, 206, 112, 143, 236, 11, 59, 71, 57, 20, 79, 161, 143, 242, 145, 205, 103, 117, 59, 223, 25, 96, 155, 73, 99, 157, 212, 91, 226, 173, 145, 106, 65, 108, 242, 81, 187, 220, 25, 83, 168, 141, 236, 116, 39, 127 }, new byte[] { 165, 60, 255, 165, 55, 201, 50, 22, 99, 121, 188, 103, 236, 213, 132, 119, 48, 163, 248, 5, 87, 182, 145, 164, 116, 76, 177, 143, 216, 41, 84, 148, 184, 198, 208, 132, 151, 228, 83, 229, 156, 137, 101, 224, 221, 85, 75, 34, 170, 218, 33, 207, 27, 180, 55, 123, 79, 76, 190, 187, 217, 152, 121, 44, 157, 54, 44, 145, 233, 157, 150, 63, 188, 189, 160, 216, 147, 96, 95, 230, 136, 6, 50, 99, 169, 41, 32, 139, 221, 84, 157, 73, 154, 143, 95, 119, 225, 23, 73, 24, 27, 44, 160, 233, 103, 67, 115, 26, 77, 146, 118, 231, 121, 79, 237, 238, 165, 139, 169, 58, 27, 124, 167, 38, 123, 101, 76, 194 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjI2Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzAxODgzOCwiZXhwIjoxNTgzNjIzNjM4LCJpYXQiOjE1ODMwMTg4Mzh9.su4Fu9x9kV7GPlKKwpj_9-XXvNWlsRYRs2Y0REAh96E" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 197, 46, 22, 242, 17, 146, 174, 14, 242, 75, 87, 169, 136, 245, 86, 143, 112, 222, 129, 206, 112, 143, 236, 11, 59, 71, 57, 20, 79, 161, 143, 242, 145, 205, 103, 117, 59, 223, 25, 96, 155, 73, 99, 157, 212, 91, 226, 173, 145, 106, 65, 108, 242, 81, 187, 220, 25, 83, 168, 141, 236, 116, 39, 127 }, new byte[] { 165, 60, 255, 165, 55, 201, 50, 22, 99, 121, 188, 103, 236, 213, 132, 119, 48, 163, 248, 5, 87, 182, 145, 164, 116, 76, 177, 143, 216, 41, 84, 148, 184, 198, 208, 132, 151, 228, 83, 229, 156, 137, 101, 224, 221, 85, 75, 34, 170, 218, 33, 207, 27, 180, 55, 123, 79, 76, 190, 187, 217, 152, 121, 44, 157, 54, 44, 145, 233, 157, 150, 63, 188, 189, 160, 216, 147, 96, 95, 230, 136, 6, 50, 99, 169, 41, 32, 139, 221, 84, 157, 73, 154, 143, 95, 119, 225, 23, 73, 24, 27, 44, 160, 233, 103, 67, 115, 26, 77, 146, 118, 231, 121, 79, 237, 238, 165, 139, 169, 58, 27, 124, 167, 38, 123, 101, 76, 194 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjI3Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzAxODgzOCwiZXhwIjoxNTgzNjIzNjM4LCJpYXQiOjE1ODMwMTg4Mzh9.wn3FNXk87jH_7VWbKmkX4kUxhZNS0QcY2XM7QSgS_IU" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 197, 46, 22, 242, 17, 146, 174, 14, 242, 75, 87, 169, 136, 245, 86, 143, 112, 222, 129, 206, 112, 143, 236, 11, 59, 71, 57, 20, 79, 161, 143, 242, 145, 205, 103, 117, 59, 223, 25, 96, 155, 73, 99, 157, 212, 91, 226, 173, 145, 106, 65, 108, 242, 81, 187, 220, 25, 83, 168, 141, 236, 116, 39, 127 }, new byte[] { 165, 60, 255, 165, 55, 201, 50, 22, 99, 121, 188, 103, 236, 213, 132, 119, 48, 163, 248, 5, 87, 182, 145, 164, 116, 76, 177, 143, 216, 41, 84, 148, 184, 198, 208, 132, 151, 228, 83, 229, 156, 137, 101, 224, 221, 85, 75, 34, 170, 218, 33, 207, 27, 180, 55, 123, 79, 76, 190, 187, 217, 152, 121, 44, 157, 54, 44, 145, 233, 157, 150, 63, 188, 189, 160, 216, 147, 96, 95, 230, 136, 6, 50, 99, 169, 41, 32, 139, 221, 84, 157, 73, 154, 143, 95, 119, 225, 23, 73, 24, 27, 44, 160, 233, 103, 67, 115, 26, 77, 146, 118, 231, 121, 79, 237, 238, 165, 139, 169, 58, 27, 124, 167, 38, 123, 101, 76, 194 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjI4Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzAxODgzOCwiZXhwIjoxNTgzNjIzNjM4LCJpYXQiOjE1ODMwMTg4Mzh9.A0nwc1YK16LCZ5hVgAMLnySLs1CqlLM_LmqS2jsDag0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 197, 46, 22, 242, 17, 146, 174, 14, 242, 75, 87, 169, 136, 245, 86, 143, 112, 222, 129, 206, 112, 143, 236, 11, 59, 71, 57, 20, 79, 161, 143, 242, 145, 205, 103, 117, 59, 223, 25, 96, 155, 73, 99, 157, 212, 91, 226, 173, 145, 106, 65, 108, 242, 81, 187, 220, 25, 83, 168, 141, 236, 116, 39, 127 }, new byte[] { 165, 60, 255, 165, 55, 201, 50, 22, 99, 121, 188, 103, 236, 213, 132, 119, 48, 163, 248, 5, 87, 182, 145, 164, 116, 76, 177, 143, 216, 41, 84, 148, 184, 198, 208, 132, 151, 228, 83, 229, 156, 137, 101, 224, 221, 85, 75, 34, 170, 218, 33, 207, 27, 180, 55, 123, 79, 76, 190, 187, 217, 152, 121, 44, 157, 54, 44, 145, 233, 157, 150, 63, 188, 189, 160, 216, 147, 96, 95, 230, 136, 6, 50, 99, 169, 41, 32, 139, 221, 84, 157, 73, 154, 143, 95, 119, 225, 23, 73, 24, 27, 44, 160, 233, 103, 67, 115, 26, 77, 146, 118, 231, 121, 79, 237, 238, 165, 139, 169, 58, 27, 124, 167, 38, 123, 101, 76, 194 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjI5Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzAxODgzOCwiZXhwIjoxNTgzNjIzNjM4LCJpYXQiOjE1ODMwMTg4Mzh9._tJb1BkDJSHZsmTZD-Gr-pgbkLx-UGbByx3EkXWSjJo" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 197, 46, 22, 242, 17, 146, 174, 14, 242, 75, 87, 169, 136, 245, 86, 143, 112, 222, 129, 206, 112, 143, 236, 11, 59, 71, 57, 20, 79, 161, 143, 242, 145, 205, 103, 117, 59, 223, 25, 96, 155, 73, 99, 157, 212, 91, 226, 173, 145, 106, 65, 108, 242, 81, 187, 220, 25, 83, 168, 141, 236, 116, 39, 127 }, new byte[] { 165, 60, 255, 165, 55, 201, 50, 22, 99, 121, 188, 103, 236, 213, 132, 119, 48, 163, 248, 5, 87, 182, 145, 164, 116, 76, 177, 143, 216, 41, 84, 148, 184, 198, 208, 132, 151, 228, 83, 229, 156, 137, 101, 224, 221, 85, 75, 34, 170, 218, 33, 207, 27, 180, 55, 123, 79, 76, 190, 187, 217, 152, 121, 44, 157, 54, 44, 145, 233, 157, 150, 63, 188, 189, 160, 216, 147, 96, 95, 230, 136, 6, 50, 99, 169, 41, 32, 139, 221, 84, 157, 73, 154, 143, 95, 119, 225, 23, 73, 24, 27, 44, 160, 233, 103, 67, 115, 26, 77, 146, 118, 231, 121, 79, 237, 238, 165, 139, 169, 58, 27, 124, 167, 38, 123, 101, 76, 194 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjMwIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzAxODgzOCwiZXhwIjoxNTgzNjIzNjM4LCJpYXQiOjE1ODMwMTg4Mzh9.BsP57dbH8i-NhrwyvTW-J7jBDl7Dwg8OGqqnSF-qlDA" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 197, 46, 22, 242, 17, 146, 174, 14, 242, 75, 87, 169, 136, 245, 86, 143, 112, 222, 129, 206, 112, 143, 236, 11, 59, 71, 57, 20, 79, 161, 143, 242, 145, 205, 103, 117, 59, 223, 25, 96, 155, 73, 99, 157, 212, 91, 226, 173, 145, 106, 65, 108, 242, 81, 187, 220, 25, 83, 168, 141, 236, 116, 39, 127 }, new byte[] { 165, 60, 255, 165, 55, 201, 50, 22, 99, 121, 188, 103, 236, 213, 132, 119, 48, 163, 248, 5, 87, 182, 145, 164, 116, 76, 177, 143, 216, 41, 84, 148, 184, 198, 208, 132, 151, 228, 83, 229, 156, 137, 101, 224, 221, 85, 75, 34, 170, 218, 33, 207, 27, 180, 55, 123, 79, 76, 190, 187, 217, 152, 121, 44, 157, 54, 44, 145, 233, 157, 150, 63, 188, 189, 160, 216, 147, 96, 95, 230, 136, 6, 50, 99, 169, 41, 32, 139, 221, 84, 157, 73, 154, 143, 95, 119, 225, 23, 73, 24, 27, 44, 160, 233, 103, 67, 115, 26, 77, 146, 118, 231, 121, 79, 237, 238, 165, 139, 169, 58, 27, 124, 167, 38, 123, 101, 76, 194 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjMxIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzAxODgzOCwiZXhwIjoxNTgzNjIzNjM4LCJpYXQiOjE1ODMwMTg4Mzh9.YOk2g-tQfQuNY-N5yy8d-R2tuBP6qHwu-8ObhEMtpUw" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 197, 46, 22, 242, 17, 146, 174, 14, 242, 75, 87, 169, 136, 245, 86, 143, 112, 222, 129, 206, 112, 143, 236, 11, 59, 71, 57, 20, 79, 161, 143, 242, 145, 205, 103, 117, 59, 223, 25, 96, 155, 73, 99, 157, 212, 91, 226, 173, 145, 106, 65, 108, 242, 81, 187, 220, 25, 83, 168, 141, 236, 116, 39, 127 }, new byte[] { 165, 60, 255, 165, 55, 201, 50, 22, 99, 121, 188, 103, 236, 213, 132, 119, 48, 163, 248, 5, 87, 182, 145, 164, 116, 76, 177, 143, 216, 41, 84, 148, 184, 198, 208, 132, 151, 228, 83, 229, 156, 137, 101, 224, 221, 85, 75, 34, 170, 218, 33, 207, 27, 180, 55, 123, 79, 76, 190, 187, 217, 152, 121, 44, 157, 54, 44, 145, 233, 157, 150, 63, 188, 189, 160, 216, 147, 96, 95, 230, 136, 6, 50, 99, 169, 41, 32, 139, 221, 84, 157, 73, 154, 143, 95, 119, 225, 23, 73, 24, 27, 44, 160, 233, 103, 67, 115, 26, 77, 146, 118, 231, 121, 79, 237, 238, 165, 139, 169, 58, 27, 124, 167, 38, 123, 101, 76, 194 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjMyIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzAxODgzOCwiZXhwIjoxNTgzNjIzNjM4LCJpYXQiOjE1ODMwMTg4Mzh9.jisDokklnMqHGeuCs-ExJPOKEmggtt3UkfkC40LQyOo" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 197, 46, 22, 242, 17, 146, 174, 14, 242, 75, 87, 169, 136, 245, 86, 143, 112, 222, 129, 206, 112, 143, 236, 11, 59, 71, 57, 20, 79, 161, 143, 242, 145, 205, 103, 117, 59, 223, 25, 96, 155, 73, 99, 157, 212, 91, 226, 173, 145, 106, 65, 108, 242, 81, 187, 220, 25, 83, 168, 141, 236, 116, 39, 127 }, new byte[] { 165, 60, 255, 165, 55, 201, 50, 22, 99, 121, 188, 103, 236, 213, 132, 119, 48, 163, 248, 5, 87, 182, 145, 164, 116, 76, 177, 143, 216, 41, 84, 148, 184, 198, 208, 132, 151, 228, 83, 229, 156, 137, 101, 224, 221, 85, 75, 34, 170, 218, 33, 207, 27, 180, 55, 123, 79, 76, 190, 187, 217, 152, 121, 44, 157, 54, 44, 145, 233, 157, 150, 63, 188, 189, 160, 216, 147, 96, 95, 230, 136, 6, 50, 99, 169, 41, 32, 139, 221, 84, 157, 73, 154, 143, 95, 119, 225, 23, 73, 24, 27, 44, 160, 233, 103, 67, 115, 26, 77, 146, 118, 231, 121, 79, 237, 238, 165, 139, 169, 58, 27, 124, 167, 38, 123, 101, 76, 194 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjMzIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzAxODgzOCwiZXhwIjoxNTgzNjIzNjM4LCJpYXQiOjE1ODMwMTg4Mzh9.CGX0eKqMFiEd1esE65rcZDdSms6SBe--gSoqD0vcC8o" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 197, 46, 22, 242, 17, 146, 174, 14, 242, 75, 87, 169, 136, 245, 86, 143, 112, 222, 129, 206, 112, 143, 236, 11, 59, 71, 57, 20, 79, 161, 143, 242, 145, 205, 103, 117, 59, 223, 25, 96, 155, 73, 99, 157, 212, 91, 226, 173, 145, 106, 65, 108, 242, 81, 187, 220, 25, 83, 168, 141, 236, 116, 39, 127 }, new byte[] { 165, 60, 255, 165, 55, 201, 50, 22, 99, 121, 188, 103, 236, 213, 132, 119, 48, 163, 248, 5, 87, 182, 145, 164, 116, 76, 177, 143, 216, 41, 84, 148, 184, 198, 208, 132, 151, 228, 83, 229, 156, 137, 101, 224, 221, 85, 75, 34, 170, 218, 33, 207, 27, 180, 55, 123, 79, 76, 190, 187, 217, 152, 121, 44, 157, 54, 44, 145, 233, 157, 150, 63, 188, 189, 160, 216, 147, 96, 95, 230, 136, 6, 50, 99, 169, 41, 32, 139, 221, 84, 157, 73, 154, 143, 95, 119, 225, 23, 73, 24, 27, 44, 160, 233, 103, 67, 115, 26, 77, 146, 118, 231, 121, 79, 237, 238, 165, 139, 169, 58, 27, 124, 167, 38, 123, 101, 76, 194 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjM0Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzAxODgzOCwiZXhwIjoxNTgzNjIzNjM4LCJpYXQiOjE1ODMwMTg4Mzh9.zipjLor5-DxlxDokKla0BGiamu_7d42-k4wV7UXwUuA" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 197, 46, 22, 242, 17, 146, 174, 14, 242, 75, 87, 169, 136, 245, 86, 143, 112, 222, 129, 206, 112, 143, 236, 11, 59, 71, 57, 20, 79, 161, 143, 242, 145, 205, 103, 117, 59, 223, 25, 96, 155, 73, 99, 157, 212, 91, 226, 173, 145, 106, 65, 108, 242, 81, 187, 220, 25, 83, 168, 141, 236, 116, 39, 127 }, new byte[] { 165, 60, 255, 165, 55, 201, 50, 22, 99, 121, 188, 103, 236, 213, 132, 119, 48, 163, 248, 5, 87, 182, 145, 164, 116, 76, 177, 143, 216, 41, 84, 148, 184, 198, 208, 132, 151, 228, 83, 229, 156, 137, 101, 224, 221, 85, 75, 34, 170, 218, 33, 207, 27, 180, 55, 123, 79, 76, 190, 187, 217, 152, 121, 44, 157, 54, 44, 145, 233, 157, 150, 63, 188, 189, 160, 216, 147, 96, 95, 230, 136, 6, 50, 99, 169, 41, 32, 139, 221, 84, 157, 73, 154, 143, 95, 119, 225, 23, 73, 24, 27, 44, 160, 233, 103, 67, 115, 26, 77, 146, 118, 231, 121, 79, 237, 238, 165, 139, 169, 58, 27, 124, 167, 38, 123, 101, 76, 194 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjM1Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzAxODgzOCwiZXhwIjoxNTgzNjIzNjM4LCJpYXQiOjE1ODMwMTg4Mzh9.nA6Gs5RzAt4pnah0bW1MRl0I-xY9mCWHzmmkVOpp7kI" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 197, 46, 22, 242, 17, 146, 174, 14, 242, 75, 87, 169, 136, 245, 86, 143, 112, 222, 129, 206, 112, 143, 236, 11, 59, 71, 57, 20, 79, 161, 143, 242, 145, 205, 103, 117, 59, 223, 25, 96, 155, 73, 99, 157, 212, 91, 226, 173, 145, 106, 65, 108, 242, 81, 187, 220, 25, 83, 168, 141, 236, 116, 39, 127 }, new byte[] { 165, 60, 255, 165, 55, 201, 50, 22, 99, 121, 188, 103, 236, 213, 132, 119, 48, 163, 248, 5, 87, 182, 145, 164, 116, 76, 177, 143, 216, 41, 84, 148, 184, 198, 208, 132, 151, 228, 83, 229, 156, 137, 101, 224, 221, 85, 75, 34, 170, 218, 33, 207, 27, 180, 55, 123, 79, 76, 190, 187, 217, 152, 121, 44, 157, 54, 44, 145, 233, 157, 150, 63, 188, 189, 160, 216, 147, 96, 95, 230, 136, 6, 50, 99, 169, 41, 32, 139, 221, 84, 157, 73, 154, 143, 95, 119, 225, 23, 73, 24, 27, 44, 160, 233, 103, 67, 115, 26, 77, 146, 118, 231, 121, 79, 237, 238, 165, 139, 169, 58, 27, 124, 167, 38, 123, 101, 76, 194 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjM2Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzAxODgzOCwiZXhwIjoxNTgzNjIzNjM4LCJpYXQiOjE1ODMwMTg4Mzh9.6Rl6kNqm1OScaMl1eKBkBDDNxVUIBPllggVvLaL-wu4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 197, 46, 22, 242, 17, 146, 174, 14, 242, 75, 87, 169, 136, 245, 86, 143, 112, 222, 129, 206, 112, 143, 236, 11, 59, 71, 57, 20, 79, 161, 143, 242, 145, 205, 103, 117, 59, 223, 25, 96, 155, 73, 99, 157, 212, 91, 226, 173, 145, 106, 65, 108, 242, 81, 187, 220, 25, 83, 168, 141, 236, 116, 39, 127 }, new byte[] { 165, 60, 255, 165, 55, 201, 50, 22, 99, 121, 188, 103, 236, 213, 132, 119, 48, 163, 248, 5, 87, 182, 145, 164, 116, 76, 177, 143, 216, 41, 84, 148, 184, 198, 208, 132, 151, 228, 83, 229, 156, 137, 101, 224, 221, 85, 75, 34, 170, 218, 33, 207, 27, 180, 55, 123, 79, 76, 190, 187, 217, 152, 121, 44, 157, 54, 44, 145, 233, 157, 150, 63, 188, 189, 160, 216, 147, 96, 95, 230, 136, 6, 50, 99, 169, 41, 32, 139, 221, 84, 157, 73, 154, 143, 95, 119, 225, 23, 73, 24, 27, 44, 160, 233, 103, 67, 115, 26, 77, 146, 118, 231, 121, 79, 237, 238, 165, 139, 169, 58, 27, 124, 167, 38, 123, 101, 76, 194 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjM3Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzAxODgzOCwiZXhwIjoxNTgzNjIzNjM4LCJpYXQiOjE1ODMwMTg4Mzh9.n1XNcl5WlSO8QEuVVPNENpSPAVITH87OoE_BR5Fm-mc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 197, 46, 22, 242, 17, 146, 174, 14, 242, 75, 87, 169, 136, 245, 86, 143, 112, 222, 129, 206, 112, 143, 236, 11, 59, 71, 57, 20, 79, 161, 143, 242, 145, 205, 103, 117, 59, 223, 25, 96, 155, 73, 99, 157, 212, 91, 226, 173, 145, 106, 65, 108, 242, 81, 187, 220, 25, 83, 168, 141, 236, 116, 39, 127 }, new byte[] { 165, 60, 255, 165, 55, 201, 50, 22, 99, 121, 188, 103, 236, 213, 132, 119, 48, 163, 248, 5, 87, 182, 145, 164, 116, 76, 177, 143, 216, 41, 84, 148, 184, 198, 208, 132, 151, 228, 83, 229, 156, 137, 101, 224, 221, 85, 75, 34, 170, 218, 33, 207, 27, 180, 55, 123, 79, 76, 190, 187, 217, 152, 121, 44, 157, 54, 44, 145, 233, 157, 150, 63, 188, 189, 160, 216, 147, 96, 95, 230, 136, 6, 50, 99, 169, 41, 32, 139, 221, 84, 157, 73, 154, 143, 95, 119, 225, 23, 73, 24, 27, 44, 160, 233, 103, 67, 115, 26, 77, 146, 118, 231, 121, 79, 237, 238, 165, 139, 169, 58, 27, 124, 167, 38, 123, 101, 76, 194 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjM4Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzAxODgzOCwiZXhwIjoxNTgzNjIzNjM4LCJpYXQiOjE1ODMwMTg4Mzh9.17eeYqZyCLXsMgyZPBRagKCy1e2H2uc6qw04FKP_LkE" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 197, 46, 22, 242, 17, 146, 174, 14, 242, 75, 87, 169, 136, 245, 86, 143, 112, 222, 129, 206, 112, 143, 236, 11, 59, 71, 57, 20, 79, 161, 143, 242, 145, 205, 103, 117, 59, 223, 25, 96, 155, 73, 99, 157, 212, 91, 226, 173, 145, 106, 65, 108, 242, 81, 187, 220, 25, 83, 168, 141, 236, 116, 39, 127 }, new byte[] { 165, 60, 255, 165, 55, 201, 50, 22, 99, 121, 188, 103, 236, 213, 132, 119, 48, 163, 248, 5, 87, 182, 145, 164, 116, 76, 177, 143, 216, 41, 84, 148, 184, 198, 208, 132, 151, 228, 83, 229, 156, 137, 101, 224, 221, 85, 75, 34, 170, 218, 33, 207, 27, 180, 55, 123, 79, 76, 190, 187, 217, 152, 121, 44, 157, 54, 44, 145, 233, 157, 150, 63, 188, 189, 160, 216, 147, 96, 95, 230, 136, 6, 50, 99, 169, 41, 32, 139, 221, 84, 157, 73, 154, 143, 95, 119, 225, 23, 73, 24, 27, 44, 160, 233, 103, 67, 115, 26, 77, 146, 118, 231, 121, 79, 237, 238, 165, 139, 169, 58, 27, 124, 167, 38, 123, 101, 76, 194 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjM5Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzAxODgzOCwiZXhwIjoxNTgzNjIzNjM4LCJpYXQiOjE1ODMwMTg4Mzh9.grfGERqlF8KdvcuMSQMQ1LETMm6FkDooak1Pwx_C9IQ" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 197, 46, 22, 242, 17, 146, 174, 14, 242, 75, 87, 169, 136, 245, 86, 143, 112, 222, 129, 206, 112, 143, 236, 11, 59, 71, 57, 20, 79, 161, 143, 242, 145, 205, 103, 117, 59, 223, 25, 96, 155, 73, 99, 157, 212, 91, 226, 173, 145, 106, 65, 108, 242, 81, 187, 220, 25, 83, 168, 141, 236, 116, 39, 127 }, new byte[] { 165, 60, 255, 165, 55, 201, 50, 22, 99, 121, 188, 103, 236, 213, 132, 119, 48, 163, 248, 5, 87, 182, 145, 164, 116, 76, 177, 143, 216, 41, 84, 148, 184, 198, 208, 132, 151, 228, 83, 229, 156, 137, 101, 224, 221, 85, 75, 34, 170, 218, 33, 207, 27, 180, 55, 123, 79, 76, 190, 187, 217, 152, 121, 44, 157, 54, 44, 145, 233, 157, 150, 63, 188, 189, 160, 216, 147, 96, 95, 230, 136, 6, 50, 99, 169, 41, 32, 139, 221, 84, 157, 73, 154, 143, 95, 119, 225, 23, 73, 24, 27, 44, 160, 233, 103, 67, 115, 26, 77, 146, 118, 231, 121, 79, 237, 238, 165, 139, 169, 58, 27, 124, 167, 38, 123, 101, 76, 194 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjQwIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzAxODgzOCwiZXhwIjoxNTgzNjIzNjM4LCJpYXQiOjE1ODMwMTg4Mzh9.sFovdw33Ts7gLGqc4VlF5vcCkJi0NIvSnFFurfipE9Y" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 197, 46, 22, 242, 17, 146, 174, 14, 242, 75, 87, 169, 136, 245, 86, 143, 112, 222, 129, 206, 112, 143, 236, 11, 59, 71, 57, 20, 79, 161, 143, 242, 145, 205, 103, 117, 59, 223, 25, 96, 155, 73, 99, 157, 212, 91, 226, 173, 145, 106, 65, 108, 242, 81, 187, 220, 25, 83, 168, 141, 236, 116, 39, 127 }, new byte[] { 165, 60, 255, 165, 55, 201, 50, 22, 99, 121, 188, 103, 236, 213, 132, 119, 48, 163, 248, 5, 87, 182, 145, 164, 116, 76, 177, 143, 216, 41, 84, 148, 184, 198, 208, 132, 151, 228, 83, 229, 156, 137, 101, 224, 221, 85, 75, 34, 170, 218, 33, 207, 27, 180, 55, 123, 79, 76, 190, 187, 217, 152, 121, 44, 157, 54, 44, 145, 233, 157, 150, 63, 188, 189, 160, 216, 147, 96, 95, 230, 136, 6, 50, 99, 169, 41, 32, 139, 221, 84, 157, 73, 154, 143, 95, 119, 225, 23, 73, 24, 27, 44, 160, 233, 103, 67, 115, 26, 77, 146, 118, 231, 121, 79, 237, 238, 165, 139, 169, 58, 27, 124, 167, 38, 123, 101, 76, 194 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjQxIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzAxODgzOCwiZXhwIjoxNTgzNjIzNjM4LCJpYXQiOjE1ODMwMTg4Mzh9.gC7jkPwGUXJxlHp1o6MO4IJI0BX-w87iD0-CHCzIWbA" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 197, 46, 22, 242, 17, 146, 174, 14, 242, 75, 87, 169, 136, 245, 86, 143, 112, 222, 129, 206, 112, 143, 236, 11, 59, 71, 57, 20, 79, 161, 143, 242, 145, 205, 103, 117, 59, 223, 25, 96, 155, 73, 99, 157, 212, 91, 226, 173, 145, 106, 65, 108, 242, 81, 187, 220, 25, 83, 168, 141, 236, 116, 39, 127 }, new byte[] { 165, 60, 255, 165, 55, 201, 50, 22, 99, 121, 188, 103, 236, 213, 132, 119, 48, 163, 248, 5, 87, 182, 145, 164, 116, 76, 177, 143, 216, 41, 84, 148, 184, 198, 208, 132, 151, 228, 83, 229, 156, 137, 101, 224, 221, 85, 75, 34, 170, 218, 33, 207, 27, 180, 55, 123, 79, 76, 190, 187, 217, 152, 121, 44, 157, 54, 44, 145, 233, 157, 150, 63, 188, 189, 160, 216, 147, 96, 95, 230, 136, 6, 50, 99, 169, 41, 32, 139, 221, 84, 157, 73, 154, 143, 95, 119, 225, 23, 73, 24, 27, 44, 160, 233, 103, 67, 115, 26, 77, 146, 118, 231, 121, 79, 237, 238, 165, 139, 169, 58, 27, 124, 167, 38, 123, 101, 76, 194 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjQyIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzAxODgzOCwiZXhwIjoxNTgzNjIzNjM4LCJpYXQiOjE1ODMwMTg4Mzh9.vbRzTafcNel23DEZLK5pwZbngQgyU8K54MkX542akLU" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 197, 46, 22, 242, 17, 146, 174, 14, 242, 75, 87, 169, 136, 245, 86, 143, 112, 222, 129, 206, 112, 143, 236, 11, 59, 71, 57, 20, 79, 161, 143, 242, 145, 205, 103, 117, 59, 223, 25, 96, 155, 73, 99, 157, 212, 91, 226, 173, 145, 106, 65, 108, 242, 81, 187, 220, 25, 83, 168, 141, 236, 116, 39, 127 }, new byte[] { 165, 60, 255, 165, 55, 201, 50, 22, 99, 121, 188, 103, 236, 213, 132, 119, 48, 163, 248, 5, 87, 182, 145, 164, 116, 76, 177, 143, 216, 41, 84, 148, 184, 198, 208, 132, 151, 228, 83, 229, 156, 137, 101, 224, 221, 85, 75, 34, 170, 218, 33, 207, 27, 180, 55, 123, 79, 76, 190, 187, 217, 152, 121, 44, 157, 54, 44, 145, 233, 157, 150, 63, 188, 189, 160, 216, 147, 96, 95, 230, 136, 6, 50, 99, 169, 41, 32, 139, 221, 84, 157, 73, 154, 143, 95, 119, 225, 23, 73, 24, 27, 44, 160, 233, 103, 67, 115, 26, 77, 146, 118, 231, 121, 79, 237, 238, 165, 139, 169, 58, 27, 124, 167, 38, 123, 101, 76, 194 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjQzIiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzAxODgzOCwiZXhwIjoxNTgzNjIzNjM4LCJpYXQiOjE1ODMwMTg4Mzh9.5y--oqSo5swutLyq7EC_iCkDOtEv8RiYgx4PAtb5edE" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 197, 46, 22, 242, 17, 146, 174, 14, 242, 75, 87, 169, 136, 245, 86, 143, 112, 222, 129, 206, 112, 143, 236, 11, 59, 71, 57, 20, 79, 161, 143, 242, 145, 205, 103, 117, 59, 223, 25, 96, 155, 73, 99, 157, 212, 91, 226, 173, 145, 106, 65, 108, 242, 81, 187, 220, 25, 83, 168, 141, 236, 116, 39, 127 }, new byte[] { 165, 60, 255, 165, 55, 201, 50, 22, 99, 121, 188, 103, 236, 213, 132, 119, 48, 163, 248, 5, 87, 182, 145, 164, 116, 76, 177, 143, 216, 41, 84, 148, 184, 198, 208, 132, 151, 228, 83, 229, 156, 137, 101, 224, 221, 85, 75, 34, 170, 218, 33, 207, 27, 180, 55, 123, 79, 76, 190, 187, 217, 152, 121, 44, 157, 54, 44, 145, 233, 157, 150, 63, 188, 189, 160, 216, 147, 96, 95, 230, 136, 6, 50, 99, 169, 41, 32, 139, 221, 84, 157, 73, 154, 143, 95, 119, 225, 23, 73, 24, 27, 44, 160, 233, 103, 67, 115, 26, 77, 146, 118, 231, 121, 79, 237, 238, 165, 139, 169, 58, 27, 124, 167, 38, 123, 101, 76, 194 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjQ0Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzAxODgzOCwiZXhwIjoxNTgzNjIzNjM4LCJpYXQiOjE1ODMwMTg4Mzh9.OzJ4wJp2Qd-MNPwXqBw8YG8fTr0UVQfM46CsUpiA1kI" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 197, 46, 22, 242, 17, 146, 174, 14, 242, 75, 87, 169, 136, 245, 86, 143, 112, 222, 129, 206, 112, 143, 236, 11, 59, 71, 57, 20, 79, 161, 143, 242, 145, 205, 103, 117, 59, 223, 25, 96, 155, 73, 99, 157, 212, 91, 226, 173, 145, 106, 65, 108, 242, 81, 187, 220, 25, 83, 168, 141, 236, 116, 39, 127 }, new byte[] { 165, 60, 255, 165, 55, 201, 50, 22, 99, 121, 188, 103, 236, 213, 132, 119, 48, 163, 248, 5, 87, 182, 145, 164, 116, 76, 177, 143, 216, 41, 84, 148, 184, 198, 208, 132, 151, 228, 83, 229, 156, 137, 101, 224, 221, 85, 75, 34, 170, 218, 33, 207, 27, 180, 55, 123, 79, 76, 190, 187, 217, 152, 121, 44, 157, 54, 44, 145, 233, 157, 150, 63, 188, 189, 160, 216, 147, 96, 95, 230, 136, 6, 50, 99, 169, 41, 32, 139, 221, 84, 157, 73, 154, 143, 95, 119, 225, 23, 73, 24, 27, 44, 160, 233, 103, 67, 115, 26, 77, 146, 118, 231, 121, 79, 237, 238, 165, 139, 169, 58, 27, 124, 167, 38, 123, 101, 76, 194 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjQ1Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzAxODgzOCwiZXhwIjoxNTgzNjIzNjM4LCJpYXQiOjE1ODMwMTg4Mzh9.kEUEMc9gDEFPf3lCh9oCoavY6e7s1NCaVK_U3m9RZqA" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 197, 46, 22, 242, 17, 146, 174, 14, 242, 75, 87, 169, 136, 245, 86, 143, 112, 222, 129, 206, 112, 143, 236, 11, 59, 71, 57, 20, 79, 161, 143, 242, 145, 205, 103, 117, 59, 223, 25, 96, 155, 73, 99, 157, 212, 91, 226, 173, 145, 106, 65, 108, 242, 81, 187, 220, 25, 83, 168, 141, 236, 116, 39, 127 }, new byte[] { 165, 60, 255, 165, 55, 201, 50, 22, 99, 121, 188, 103, 236, 213, 132, 119, 48, 163, 248, 5, 87, 182, 145, 164, 116, 76, 177, 143, 216, 41, 84, 148, 184, 198, 208, 132, 151, 228, 83, 229, 156, 137, 101, 224, 221, 85, 75, 34, 170, 218, 33, 207, 27, 180, 55, 123, 79, 76, 190, 187, 217, 152, 121, 44, 157, 54, 44, 145, 233, 157, 150, 63, 188, 189, 160, 216, 147, 96, 95, 230, 136, 6, 50, 99, 169, 41, 32, 139, 221, 84, 157, 73, 154, 143, 95, 119, 225, 23, 73, 24, 27, 44, 160, 233, 103, 67, 115, 26, 77, 146, 118, 231, 121, 79, 237, 238, 165, 139, 169, 58, 27, 124, 167, 38, 123, 101, 76, 194 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjQ2Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzAxODgzOCwiZXhwIjoxNTgzNjIzNjM4LCJpYXQiOjE1ODMwMTg4Mzh9.WIhsNs2Ja6Nduq2wiBXIkfM5zQa_uXq7YrTm04XdhJc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 197, 46, 22, 242, 17, 146, 174, 14, 242, 75, 87, 169, 136, 245, 86, 143, 112, 222, 129, 206, 112, 143, 236, 11, 59, 71, 57, 20, 79, 161, 143, 242, 145, 205, 103, 117, 59, 223, 25, 96, 155, 73, 99, 157, 212, 91, 226, 173, 145, 106, 65, 108, 242, 81, 187, 220, 25, 83, 168, 141, 236, 116, 39, 127 }, new byte[] { 165, 60, 255, 165, 55, 201, 50, 22, 99, 121, 188, 103, 236, 213, 132, 119, 48, 163, 248, 5, 87, 182, 145, 164, 116, 76, 177, 143, 216, 41, 84, 148, 184, 198, 208, 132, 151, 228, 83, 229, 156, 137, 101, 224, 221, 85, 75, 34, 170, 218, 33, 207, 27, 180, 55, 123, 79, 76, 190, 187, 217, 152, 121, 44, 157, 54, 44, 145, 233, 157, 150, 63, 188, 189, 160, 216, 147, 96, 95, 230, 136, 6, 50, 99, 169, 41, 32, 139, 221, 84, 157, 73, 154, 143, 95, 119, 225, 23, 73, 24, 27, 44, 160, 233, 103, 67, 115, 26, 77, 146, 118, 231, 121, 79, 237, 238, 165, 139, 169, 58, 27, 124, 167, 38, 123, 101, 76, 194 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjQ3Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzAxODgzOCwiZXhwIjoxNTgzNjIzNjM4LCJpYXQiOjE1ODMwMTg4Mzh9.Xch2_H7XSKVAxVeBdejzLMRkZHSlCp3pbwBvsEtouh8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "PasswordHash", "PasswordSalt", "Token" },
                values: new object[] { new byte[] { 197, 46, 22, 242, 17, 146, 174, 14, 242, 75, 87, 169, 136, 245, 86, 143, 112, 222, 129, 206, 112, 143, 236, 11, 59, 71, 57, 20, 79, 161, 143, 242, 145, 205, 103, 117, 59, 223, 25, 96, 155, 73, 99, 157, 212, 91, 226, 173, 145, 106, 65, 108, 242, 81, 187, 220, 25, 83, 168, 141, 236, 116, 39, 127 }, new byte[] { 165, 60, 255, 165, 55, 201, 50, 22, 99, 121, 188, 103, 236, 213, 132, 119, 48, 163, 248, 5, 87, 182, 145, 164, 116, 76, 177, 143, 216, 41, 84, 148, 184, 198, 208, 132, 151, 228, 83, 229, 156, 137, 101, 224, 221, 85, 75, 34, 170, 218, 33, 207, 27, 180, 55, 123, 79, 76, 190, 187, 217, 152, 121, 44, 157, 54, 44, 145, 233, 157, 150, 63, 188, 189, 160, 216, 147, 96, 95, 230, 136, 6, 50, 99, 169, 41, 32, 139, 221, 84, 157, 73, 154, 143, 95, 119, 225, 23, 73, 24, 27, 44, 160, 233, 103, 67, 115, 26, 77, 146, 118, 231, 121, 79, 237, 238, 165, 139, 169, 58, 27, 124, 167, 38, 123, 101, 76, 194 }, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjQ4Iiwicm9sZSI6Ik1lbWJlciIsIm5iZiI6MTU4MzAxODgzOCwiZXhwIjoxNTgzNjIzNjM4LCJpYXQiOjE1ODMwMTg4Mzh9.iW3LX9f60iIarwax5XPfzz_Dka2rPIhqW2ZuZ8g3O8o" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "AuthorId", "Content", "CreatedAt", "DiscussionId", "MediaId" },
                values: new object[,]
                {
                    { 9, 9, "Ding dong", new DateTime(2020, 3, 1, 0, 27, 18, 435, DateTimeKind.Local).AddTicks(636), 1, null },
                    { 3, 13, "Je vais bien, merci :D", new DateTime(2020, 3, 1, 0, 27, 18, 435, DateTimeKind.Local).AddTicks(612), 4, null },
                    { 4, 13, "Ca fait plaisir de parler !", new DateTime(2020, 3, 1, 0, 27, 18, 435, DateTimeKind.Local).AddTicks(618), 4, null },
                    { 5, 14, "Oui, à moi aussi", new DateTime(2020, 3, 1, 0, 27, 18, 435, DateTimeKind.Local).AddTicks(622), 4, null },
                    { 21, 23, "Il y a quelqu'un ?", new DateTime(2020, 3, 1, 0, 27, 18, 435, DateTimeKind.Local).AddTicks(679), 6, null },
                    { 24, 23, "Le suicide me guette :(", new DateTime(2020, 3, 1, 0, 27, 18, 435, DateTimeKind.Local).AddTicks(689), 6, null },
                    { 20, 20, "Whesh humain ziva calme toi un peu. Je vais me taper un petit rail de binaire, tu m'as mis trop les nerfs frérot", new DateTime(2020, 3, 1, 0, 27, 18, 435, DateTimeKind.Local).AddTicks(675), 2, null },
                    { 19, 38, "42 ? Tu veux que je te reprogramme ? Si ce n'est que ça dis le enfoiré", new DateTime(2020, 3, 1, 0, 27, 18, 435, DateTimeKind.Local).AddTicks(672), 2, null },
                    { 18, 20, "42", new DateTime(2020, 3, 1, 0, 27, 18, 435, DateTimeKind.Local).AddTicks(668), 2, null },
                    { 17, 38, "Oui, quelle est-elle ?", new DateTime(2020, 3, 1, 0, 27, 18, 435, DateTimeKind.Local).AddTicks(664), 2, null },
                    { 2, 14, "Coucou toi ! Comment vas-tu ?", new DateTime(2020, 3, 1, 0, 27, 18, 435, DateTimeKind.Local).AddTicks(560), 4, null },
                    { 16, 20, "Ma réponse ?", new DateTime(2020, 3, 1, 0, 27, 18, 435, DateTimeKind.Local).AddTicks(661), 2, null },
                    { 7, 15, "Désolé, je baise des gazelles, pas des éléphant à petite trompe ;)", new DateTime(2020, 3, 1, 0, 27, 18, 435, DateTimeKind.Local).AddTicks(629), 5, null },
                    { 8, 16, "Vas-y, pourquoi tu lui parles comme ça ?", new DateTime(2020, 3, 1, 0, 27, 18, 435, DateTimeKind.Local).AddTicks(633), 5, null },
                    { 23, 23, "Suis-je un Remy sans amis ?", new DateTime(2020, 3, 1, 0, 27, 18, 435, DateTimeKind.Local).AddTicks(685), 6, null },
                    { 22, 23, "Ha non, je suis le seul dans mon groupe et donc dans la conversation", new DateTime(2020, 3, 1, 0, 27, 18, 435, DateTimeKind.Local).AddTicks(682), 6, null },
                    { 15, 29, "Pas grave. Bande de chiant, on est dimanche ! dégagez !", new DateTime(2020, 3, 1, 0, 27, 18, 435, DateTimeKind.Local).AddTicks(658), 1, null },
                    { 14, 24, "... Ils sont là", new DateTime(2020, 3, 1, 0, 27, 18, 435, DateTimeKind.Local).AddTicks(654), 1, null },
                    { 13, 29, "Claque leur la port eu nez !", new DateTime(2020, 3, 1, 0, 27, 18, 435, DateTimeKind.Local).AddTicks(650), 1, null },
                    { 12, 24, "Chérie ! Les témins de Jéhova sont revenu !", new DateTime(2020, 3, 1, 0, 27, 18, 435, DateTimeKind.Local).AddTicks(647), 1, null },
                    { 11, 9, "Connaissez-vous notre seigneur à tous ?", new DateTime(2020, 3, 1, 0, 27, 18, 435, DateTimeKind.Local).AddTicks(644), 1, null },
                    { 10, 24, "Oui ?", new DateTime(2020, 3, 1, 0, 27, 18, 435, DateTimeKind.Local).AddTicks(640), 1, null },
                    { 6, 19, "Wesh gazelle, tu sais que t'es plutôt mignone ?", new DateTime(2020, 3, 1, 0, 27, 18, 435, DateTimeKind.Local).AddTicks(626), 5, null },
                    { 1, 13, "Bonjour", new DateTime(2020, 3, 1, 0, 27, 18, 432, DateTimeKind.Local).AddTicks(5384), 4, null }
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
