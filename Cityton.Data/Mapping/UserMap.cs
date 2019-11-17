using Cityton.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cityton.Data.Mapping
{
    public class UserMap
    {

        public UserMap(EntityTypeBuilder<User> entityBuilder)
        {
            entityBuilder.HasKey(u => u.Id);

            entityBuilder.Property(u => u.Username).IsRequired();
            entityBuilder.HasIndex(u => u.Username).IsUnique();

            entityBuilder.Property(u => u.PhoneNumber).IsRequired(false).HasMaxLength(10);
            entityBuilder.HasIndex(u => u.PhoneNumber).IsUnique();

            entityBuilder.Property(u => u.Email).IsRequired();
            entityBuilder.HasIndex(u => u.PhoneNumber).IsUnique();

            entityBuilder.Property(u => u.Picture).IsRequired();
            entityBuilder.Property(u => u.Role).IsRequired();
            entityBuilder.Property(u => u.PasswordHash).IsRequired();
            entityBuilder.Property(u => u.PasswordSalt).IsRequired();

            /*****/

            entityBuilder.HasMany(u => u.ParticipantGroups).WithOne(pg => pg.User);
            entityBuilder.HasMany(u => u.Challenges).WithOne(c => c.Author);
            entityBuilder.HasMany(u => u.Achievements).WithOne(a => a.Winner);
            entityBuilder.HasMany(u => u.UsersInDiscussion).WithOne(uid => uid.Participant);
            entityBuilder.HasMany(u => u.MessagesWriten).WithOne(m => m.Author);

            /*****/

            //entityBuilder.Ignore(u => u.Company);
            //entityBuilder.Ignore(u => u.ParticipantGroups);
            //entityBuilder.Ignore(u => u.Challenges);
            //entityBuilder.Ignore(u => u.Achievements);
            //entityBuilder.Ignore(u => u.UsersInDiscussion);
            //entityBuilder.Ignore(u => u.MessagesWriten);
        }
    }
}