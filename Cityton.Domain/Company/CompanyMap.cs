using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cityton.Domain.Company
{
    class CompanyMap
    {

        public CompanyMap(EntityTypeBuilder<Company> entityBuilder)
        {
            entityBuilder.HasKey(c => c.Id); // ???
            entityBuilder.Property(c => c.MinGroupSize).IsRequired();
            entityBuilder.Property(c => c.MaxGroupSize).IsRequired();
            entityBuilder.Property(c => c.CreatedAt).IsRequired();
            entityBuilder.Ignore(c => c.Users);
        }

    }
}
