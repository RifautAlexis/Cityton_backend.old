using Cityton.Data.Common;
using Cityton.Data.DTOs;
using Cityton.Data;
using Cityton.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Cityton.Data.Mapper
{
    public static class DiscussionMapper
    {
        public static Thread ToThread(this Discussion data)
        {
            return (new Thread {
                DiscussionId = data.Id,
                Name = data.Name == null ? "" : data.Name,
                Participants = data.UsersInDiscussion.Select(uid => uid.Participant.ToMinimalDTO()),
            });
        }

        public static List<Thread> ToThreads(this IEnumerable<Discussion> data)
        {
            return data.Select(uid => uid.ToThread()).ToList();
        }
    }
}