using System;
using System.Collections.Generic;
using System.Text;
using Cityton.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cityton.Data.Mapping
{
    public class GroupMap
    {

        public GroupMap(EntityTypeBuilder<Group> entityBuilder)
        {
            entityBuilder.HasKey(g => g.Id);
            entityBuilder.Property(g => g.Name).IsRequired();
            entityBuilder.HasIndex(g => g.Name).IsUnique();

            entityBuilder.Property(g => g.Picture).IsRequired();
            entityBuilder.Property(g => g.CreatedAt).IsRequired();

            /*****/

            entityBuilder.HasMany(g => g.Members).WithOne(pg => pg.BelongingGroup);
            entityBuilder.HasMany(g => g.ChallengesGiven).WithOne(cg => cg.ChallengedGroup);

            /*****/

            //entityBuilder.Ignore(g => g.Members);
            //entityBuilder.Ignore(g => g.ChallengesGiven);
        }

    }
}
