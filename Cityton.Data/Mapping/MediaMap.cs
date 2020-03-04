using Cityton.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cityton.Data.Mapping
{
    public class MediaMap
    {
        public MediaMap(EntityTypeBuilder<Media> entityBuilder)
        {
            entityBuilder.HasKey(m => m.Id);

            // entityBuilder.Property(m => m.Name).IsRequired();
            // entityBuilder.HasIndex(m => m.Name).IsUnique();

            // entityBuilder.Property(m => m.Location).IsRequired();
            // entityBuilder.Property(m => m.Extension).IsRequired();
            entityBuilder.Property(m => m.CreatedAt).IsRequired();

            /*****/

            //entityBuilder.Ignore(m => m.ContainedIn);
        }

    }
}