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
    public static class GroupMapper
    {

        public static GroupDTO ToDTO(this Group data)
        {
            if (data == null) return null;

            return new GroupDTO
            {
                Id = data.Id,
                Name = data.Name,
                Picture = data.Picture,
                Members = data.Members.ToDTO()
            };
        }

        public static List<GroupDTO> ToDTO(this IEnumerable<Group> data)
        {
            return data.Select(g => g.ToDTO()).ToList();
        }

        public static ParticipantGroupDTO ToDTO(this ParticipantGroup data)
        {
            if (data == null) return null;

            return new ParticipantGroupDTO
            {
                Id = data.User.Id,
                Username = data.User.Username,
                IsCreator = data.IsCreator,
            };
        }

        public static List<ParticipantGroupDTO> ToDTO(this IEnumerable<ParticipantGroup> data)
        {
            return data.Select(pg => pg.ToDTO()).ToList();
        }

    }
}