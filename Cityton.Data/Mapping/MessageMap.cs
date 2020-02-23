using Cityton.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cityton.Data.Mapping
{
    public class MessageMap
    {

        public MessageMap(EntityTypeBuilder<Message> entityBuilder)
        {
            entityBuilder.HasKey(m => m.Id);
            entityBuilder.Property(m => m.Content);
            entityBuilder.Property(m => m.CreatedAt).IsRequired();

            /*****/

            entityBuilder.HasOne(mes => mes.Media).WithOne(med => med.ContainedIn).HasForeignKey<Media>(med => med.MessageId);

            /*****/

            //entityBuilder.Ignore(m => m.Author);
            //entityBuilder.Ignore(m => m.Discussion);
            //entityBuilder.Ignore(m => m.Media);
        }

    }
}