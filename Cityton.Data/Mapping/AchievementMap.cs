using Cityton.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cityton.Data.Mapping
{
    class AchievementMap
    {
        public AchievementMap(EntityTypeBuilder<Achievement> entityBuilder)
        {
            entityBuilder.HasKey(a => a.Id);
            entityBuilder.Property(a => a.UnlockedAt).IsRequired();

            /*****/

            entityBuilder.Ignore(a => a.Winner);
            entityBuilder.Ignore(a => a.FromChallenge);
        }

    }
}
