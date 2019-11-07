using Cityton.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cityton.Data.Mapping
{
    class ParticipantGroupMap
    {

        public ParticipantGroupMap(EntityTypeBuilder<ParticipantGroup> entityBuilder)
        {
            entityBuilder.HasKey(pg => pg.Id);
            entityBuilder.Property(pg => pg.IsCreator).IsRequired();
            entityBuilder.Property(pg => pg.Status).IsRequired();

            /*****/

            entityBuilder.Ignore(pg => pg.BelongingGroup);
            entityBuilder.Ignore(pg => pg.User);
        }

    }
}
