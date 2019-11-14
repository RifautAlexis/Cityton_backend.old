using Cityton.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cityton.Data.Mapping
{
    class ChallengeMap
    {

        public ChallengeMap(EntityTypeBuilder<Challenge> entityBuilder)
        {
            entityBuilder.HasKey(c => c.Id);
            entityBuilder.Property(c => c.Statement).IsRequired();
            entityBuilder.HasIndex(c => c.Statement).IsUnique();
            entityBuilder.Property(c => c.Name).IsRequired();
            entityBuilder.Property(c => c.Status).IsRequired();
            entityBuilder.Property(c => c.CreatedAt).IsRequired();

            /*****/

            entityBuilder.Ignore(c => c.Author);
            entityBuilder.Ignore(c => c.Achievements);
            entityBuilder.Ignore(c => c.ChallengeGivens);
        }

    }
}
