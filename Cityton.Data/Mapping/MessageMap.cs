using Cityton.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cityton.Data.Mapping
{
    class MessageMap
    {

        public MessageMap(EntityTypeBuilder<Message> entityBuilder)
        {
            entityBuilder.HasKey(m => m.Id);
            entityBuilder.Property(m => m.Content).IsRequired();
            entityBuilder.Property(m => m.CreatedAt).IsRequired();

            /*****/

            entityBuilder.HasOne(m => m.Media).WithOne(m => m.ContainedIn);

            /*****/

            entityBuilder.Ignore(m => m.Author);
            entityBuilder.Ignore(m => m.Discussion);
            entityBuilder.Ignore(m => m.Media);
        }

    }
}
