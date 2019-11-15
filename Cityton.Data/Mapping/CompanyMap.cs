using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Cityton.Data.Models;

namespace Cityton.Data.Mapping
{
    class CompanyMap
    {

        public CompanyMap(EntityTypeBuilder<Company> entityBuilder)
        {
            entityBuilder.HasKey(c => c.Id);
            entityBuilder.Property(c => c.Name).IsRequired();
            entityBuilder.HasIndex(c => c.Name).IsUnique();

            entityBuilder.Property(c => c.MinGroupSize).IsRequired();
            entityBuilder.Property(c => c.MaxGroupSize).IsRequired();
            entityBuilder.Property(c => c.CreatedAt).IsRequired();

            /*****/

            entityBuilder.HasMany(c => c.Users).WithOne(u => u.Company);

            /*****/

            entityBuilder.Ignore(c => c.Users);
        }

    }
}
