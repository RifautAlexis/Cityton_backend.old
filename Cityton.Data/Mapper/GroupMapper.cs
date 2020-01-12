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

        public static GroupDTO ToDTO(this Group data, int userId)
        {
            if (data == null) return null;

            return new GroupDTO
            {
                Id = data.Id,
                Name = data.Name,
                Picture = data.Picture,
                CreatedAt = data.CreatedAt,
                Members = data.Members.Where(pg => pg.Status == Status.Accepted).ToDTO(),
                HasRequested = data.Members.Any(pg => pg.UserId == userId && (pg.Status == Status.Accepted || pg.Status == Status.Waiting))
            };
        }

        public static List<GroupDTO> ToDTO(this IEnumerable<Group> data, int userId)
        {
            return data.Select(g => g.ToDTO(userId)).ToList();
        }

        public static GroupDetailsDTO ToGroupDetailsDTO(this Group data)
        {
            if (data == null) return null;

            return new GroupDetailsDTO
            {
                GroupId = data.Id,
                Name = data.Name,
                Picture = data.Picture,
                CreatedAt = data.CreatedAt,
                Members = data.Members.Where(pg => pg.Status == Status.Accepted).ToDTO(),
                MembershipRequests = data.Members.Where(pg => pg.Status == Status.Waiting).ToMembershipRequestDTO(),
                CreatorId = data.Members.First(pg => pg.IsCreator).UserId
            };
        }

        public static ParticipantGroupDTO ToDTO(this ParticipantGroup data)
        {
            if (data == null) return null;

            return new ParticipantGroupDTO
            {
                RequestId = data.Id,
                UserId = data.User.Id,
                Username = data.User.Username,
                IsCreator = data.IsCreator
            };
        }

        public static List<ParticipantGroupDTO> ToDTO(this IEnumerable<ParticipantGroup> data)
        {
            return data.Select(pg => pg.ToDTO()).ToList();
        }

        public static MembershipRequestDTO ToMembershipRequestDTO(this ParticipantGroup data)
        {
            if (data == null) return null;

            return new MembershipRequestDTO
            {
                RequestId = data.Id,
                UserId = data.User.Id,
                Username = data.User.Username,
                Status = data.Status,
                CreatedAt = data.CreatedAt
            };
        }

        public static List<MembershipRequestDTO> ToMembershipRequestDTO(this IEnumerable<ParticipantGroup> data)
        {
            return data.Select(pg => pg.ToMembershipRequestDTO()).ToList();
        }

    }
}