using Cityton.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cityton.Data.Mapping
{
    public class ChallengeGivenMap
    {
        public ChallengeGivenMap(EntityTypeBuilder<ChallengeGiven> entityBuilder)
        {
            entityBuilder.HasKey(cg => cg.Id);
            entityBuilder.Property(cg => cg.Status).IsRequired();

            /*****/

            //entityBuilder.Ignore(a => a.Challenge);
            //entityBuilder.Ignore(a => a.ChallengedGroup);
        }

    }
}