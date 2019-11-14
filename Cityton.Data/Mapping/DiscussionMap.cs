using Cityton.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cityton.Data.Mapping
{
    class DiscussionMap
    {

        public DiscussionMap(EntityTypeBuilder<Discussion> entityBuilder)
        {
            entityBuilder.HasKey(d => d.Id);
            entityBuilder.Property(d => d.CreatedAt).IsRequired();

            /*****/

            entityBuilder.Ignore(d => d.UserInDiscussion);
            entityBuilder.Ignore(d => d.Messages);
        }

    }
}
