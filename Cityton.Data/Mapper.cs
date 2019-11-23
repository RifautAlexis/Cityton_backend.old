﻿using Cityton.Data.Common;
using Cityton.Data.DTOs;
using Cityton.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cityton.Data
{
    public static class Mapper
    {

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
    }
}