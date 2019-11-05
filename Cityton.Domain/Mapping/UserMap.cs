using Cityton.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cityton.Data.Mapping
{
    class UserMap
    {

        public UserMap(EntityTypeBuilder<User> entityBuilder)
        {
            entityBuilder.HasKey(u => u.Id);
            entityBuilder.Property(u => u.Username).IsRequired();
            entityBuilder.Property(u => u.PhoneNumber).IsRequired();
            entityBuilder.Property(u => u.Email).IsRequired();
            entityBuilder.Property(u => u.Password).IsRequired();
            entityBuilder.Property(u => u.Picture).IsRequired();
            entityBuilder.Property(u => u.Role).IsRequired();
            entityBuilder.Ignore(u => u.Company);
        }
    }
}