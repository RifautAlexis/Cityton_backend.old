using Cityton.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cityton.Data.Mapping
{
    public class UserInDiscussionMap
    {

        public UserInDiscussionMap(EntityTypeBuilder<UserInDiscussion> entityBuilder)
        {
            entityBuilder.HasKey(uid => uid.Id);
            entityBuilder.Property(uid => uid.JoinedAt).IsRequired();

            /*****/

            //entityBuilder.Ignore(uid => uid.Participant);
            //entityBuilder.Ignore(uid => uid.Discussion);
        }

    }
}