using Cityton.Data.Common;
using Cityton.Data.DTOs;
using Cityton.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cityton.Data
{
    public static class Mapper
    {

        public static void DeepCopy(this User user, UserUpdateDTO userToUpdate)
        {
            user.Username = userToUpdate.Username;
            user.PhoneNumber = userToUpdate.PhoneNumber;
            user.Email = userToUpdate.Email;
            user.Picture = userToUpdate.Picture;
            user.Role = userToUpdate.Role;
            user.Token = userToUpdate.Token;
        }

        public static Role ToRole(this string role)
        {
            Enum.TryParse(role, out Role roleToReturn);
            return roleToReturn;
        }

        public static UserDTO ToDTO(this User data)
        {
            if (data == null) return null;

            return new UserDTO
            {
                Id = data.Id,
                Username = data.Username,
                PhoneNumber = data.PhoneNumber,
                Email = data.Email,
                Picture = data.Picture,
                Role = Role.Member,
                Token = data.Token
            };
        }

        public static User ToUser(this UserUpdateDTO data)
        {
            if (data == null) return null;

            return new User
            {
                Id = data.Id,
                Username = data.Username,
                PhoneNumber = data.PhoneNumber,
                Email = data.Email,
                Picture = data.Picture,
                Role = Role.Member,
                Token = data.Token
            };
        }

        public static User ToUser(this RegisterDTO data)
        {
            if (data == null) return null;

            return new User
            {
                Username = data.Username,
                PhoneNumber = data.PhoneNumber,
                Email = data.Email,
                Picture = "Default",
                Role = Role.Member,
                PasswordHash = null,
                PasswordSalt = null,
                Token = null,
                CompanyId = 1
            };
        }

        public static User ToUser(this UserDTO data)
        {
            if (data == null) return null;

            return new User
            {
                Id = data.Id,
                Username = data.Username,
                PhoneNumber = data.PhoneNumber,
                Email = data.Email,
                Picture = data.Picture,
                Role = data.Role,
                PasswordHash = null,
                PasswordSalt = null,
                Token = data.Token,
                CompanyId = 1
            };
        }
    }
}