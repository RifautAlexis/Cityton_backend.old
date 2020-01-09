using Cityton.Data.Models;
using Cityton.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Http;
using Cityton.Data.DTOs;
using Cityton.Data;
using Cityton.Data.Common;
using Cityton.Service.Validators;
using FluentValidation.AspNetCore;
using FluentValidation.Results;

namespace Cityton.Service
{

    public interface IGroupService
    {
        Task<List<Group>> GetAll();
        Task<Group> Get(int id);
        Task<ValidationResult> MembershipRequest(int groupId, User connectedUser);
        Task<bool> ExistRequest(ParticipantGroup data);
        Task<bool> IsAccepted(int userId);
        Task<ParticipantGroup> GetRequest(int id);
        Task AcceptRequest(ParticipantGroup participantGroup);
        Task DeclineRequest(ParticipantGroup participantGroup);
    }

    public class GroupService : IGroupService
    {

        private IGroupRepository groupRepository;
        private IParticipantGroupRepository participantGroupRepository;
        private readonly IConfiguration _appSettings;

        public GroupService(
            IGroupRepository groupRepository,
            IParticipantGroupRepository participantGroupRepository,
            IConfiguration config)
        {
            this.groupRepository = groupRepository;
            this.participantGroupRepository = participantGroupRepository;
            this._appSettings = config;
        }

        public async Task<List<Group>> GetAll()
        {
            return await this.groupRepository.GetAll();
        }

        public async Task<Group> Get(int id)
        {
            return await this.groupRepository.Get(id);
        }

        public async Task<ValidationResult> MembershipRequest(int groupId, User connectedUser)
        {

            Group group = await this.groupRepository.Get(groupId);

            var membershipRequest = new ParticipantGroup
            {
                IsCreator = false,
                Status = Status.Waiting,
                BelongingGroup = group,
                User = connectedUser,
                BelongingGroupId = group.Id,
                UserId = connectedUser.Id
            };

            var validator = new ParticipantGroupValidator(this);
            var results = await validator.ValidateAsync(membershipRequest);

            if (results != null) return results;

            await this.participantGroupRepository.Insert(membershipRequest);

            return null;
        }

        public async Task<bool> ExistRequest(ParticipantGroup data)
        {
            ParticipantGroup participantGroup = await this.participantGroupRepository.Get(data.BelongingGroupId, data.UserId);

            if (participantGroup == null) return false;

            if (data.Status == participantGroup.Status) return true;

            return false;

        }

        public async Task<bool> IsAccepted(int userId)
        {
            ParticipantGroup participantGroup = await this.participantGroupRepository.IsAccepted(userId);

            return participantGroup != null;
        }

        public async Task<ParticipantGroup> GetRequest(int id)
        {
            return await this.participantGroupRepository.Get(id);
        }

        public async Task AcceptRequest(ParticipantGroup participantGroup)
        {
            participantGroup.Status = Status.Accepted;
            await this.participantGroupRepository.Update(participantGroup);

            List<ParticipantGroup> allRequests = await this.participantGroupRepository.GetByUser(participantGroup.UserId);
            foreach (var request in allRequests)
            {
                this.participantGroupRepository.Remove(request);
            }

            await this.participantGroupRepository.SaveChanges();
        }

        public async Task DeclineRequest(ParticipantGroup participantGroup)
        {
            await this.participantGroupRepository.Delete(participantGroup);
        }

    }
}