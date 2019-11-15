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

            entityBuilder.HasMany(d => d.UsersInDiscussion).WithOne(uid => uid.Discussion);
            entityBuilder.HasMany(d => d.Messages).WithOne(m => m.Discussion);

            /*****/

            entityBuilder.Ignore(d => d.UsersInDiscussion);
            entityBuilder.Ignore(d => d.Messages);
        }

    }
}
