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
using System.Linq;

namespace Cityton.Service
{

    public interface IGroupService
    {
        Task<List<Group>> GetAll();
        Task<Group> Get(int id);
        Task<Group> GetWithRequest(int id);
        Task<Group> GetWithRequestUser(int id);
        Task<ValidationResult> MembershipRequest(int groupId, User connectedUser);
        Task<bool> ExistRequest(ParticipantGroup data);
        Task<bool> IsAccepted(int userId);
        Task<ParticipantGroup> GetRequest(int id);
        Task AcceptRequest(ParticipantGroup participantGroup);
        Task DeleteRequest(ParticipantGroup participantGroup);
        Task<User> GetCreator(int groupId);
        Task<Group> GetByName(string name);
        Task<ParticipantGroup> GetRequestAcceptedByUserId(int connectedUserId);
        Task<int> Create(Group newGroup, User connectedUser);
        Task<int> CreateByAdmin(GroupByAdmin newGroupByAdmin);
        Task<bool> ExistName(string name);
        Task<List<Group>> Search(string toSearch);
        Task Delete(Group group);
        Task<List<Group>> GetMinorGroups(int comapanyId);
        Task Edit(GroupInfosEdit groupToEdit);
        Task<bool> IsConformSize(int membersSize);
    }

    public class GroupService : IGroupService
    {

        private IGroupRepository groupRepository;
        private IParticipantGroupRepository participantGroupRepository;
        private ICompanyRepository companyRepository;
        private IUserRepository userRepository;
        private readonly IConfiguration _appSettings;

        public GroupService(
            IGroupRepository groupRepository,
            IParticipantGroupRepository participantGroupRepository,
            ICompanyRepository companyRepository,
            IUserRepository userRepository,
            IConfiguration config)
        {
            this.groupRepository = groupRepository;
            this.participantGroupRepository = participantGroupRepository;
            this.companyRepository = companyRepository;
            this.userRepository = userRepository;
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

        public async Task<Group> GetWithRequest(int id)
        {
            return await this.groupRepository.GetWithRequest(id);
        }

        public Task<Group> GetWithRequestUser(int id)
        {
            return this.groupRepository.GetWithRequestUser(id);
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
            allRequests.Remove(participantGroup);

            foreach (var request in allRequests)
            {
                this.participantGroupRepository.Remove(request);
            }

            await this.participantGroupRepository.SaveChanges();
        }

        public async Task DeleteRequest(ParticipantGroup participantGroup)
        {

            Group group = null;

            if (participantGroup.IsCreator)
            {
                group = await this.groupRepository.GetWithRequestUser(participantGroup.BelongingGroupId);

                group.Members.Clear();

                await this.groupRepository.Delete(group);

            }
            else
                await this.participantGroupRepository.Delete(participantGroup);

        }

        public async Task<User> GetCreator(int groupId)
        {
            ParticipantGroup request = await this.participantGroupRepository.GetRequestFromCreator(groupId);

            return request.User;
        }

        public async Task<Group> GetByName(string name)
        {
            return await this.groupRepository.GetByName(name);
        }

        public async Task<ParticipantGroup> GetRequestAcceptedByUserId(int connectedUserId)
        {
            List<ParticipantGroup> requests = await this.participantGroupRepository.GetByUser(connectedUserId);

            return requests.Where(pg => pg.Status == Status.Accepted).FirstOrDefault();
        }

        public async Task<int> Create(Group newGroup, User connectedUser)
        {
            newGroup.CreatedAt = DateTime.Now;

            await this.groupRepository.Insert(newGroup);

            Group group = await this.groupRepository.GetByName(newGroup.Name);

            await this.CreateAcceptedMembership(true, group, connectedUser.Id);

            // delete request Waiting

            return group.Id;
        }

        public async Task<int> CreateByAdmin(GroupByAdmin newGroupByAdmin)
        {

            var newGroup = new Group
            {
                Name = newGroupByAdmin.Name,
                CreatedAt = newGroupByAdmin.CreatedAt
            };

            await this.groupRepository.Insert(newGroup);

            Group group = await this.groupRepository.GetByName(newGroup.Name);

            await this.CreateAcceptedMembership(true, group, newGroupByAdmin.CreatorId);

            foreach (var membershipId in newGroupByAdmin.MembersId)
            {

                await this.CreateAcceptedMembership(false, group, membershipId);

            }

            return group.Id;
        }

        public async Task<bool> ExistName(string name)
        {
            return await this.groupRepository.GetByName(name) != null;
        }

        public async Task<List<Group>> Search(string toSearch)
        {
            return await this.groupRepository.Search(toSearch);
        }

        public async Task Delete(Group group)
        {
            await this.groupRepository.Delete(group);
        }

        public async Task<List<Group>> GetMinorGroups(int comapanyId)
        {
            int minimalGroupSize = await this.companyRepository.getMinimalSize(comapanyId);
            return await this.groupRepository.GetMinorGroups(4);
        }

        public async Task Edit(GroupInfosEdit groupToEdit)
        {
            Group group = await this.groupRepository.Get(groupToEdit.Id);

            Group orignalGroup = await this.groupRepository.GetWithRequestUser(groupToEdit.Id);

            List<int> originalMembers = orignalGroup.Members.Where(pg => pg.Status == Status.Accepted).Select(pg => pg.User).Select(user => user.Id).ToList();

            List<int> currentMembers = groupToEdit.Members.Select(pg => pg.Id).ToList();
            currentMembers.Add(groupToEdit.Creator.Id);

            List<int> membersToDelete = originalMembers.Except(currentMembers).ToList();
            membersToDelete.ForEach(
                (userId) =>
                {
                    ParticipantGroup requestAccepted = group.Members.FirstOrDefault(pg => pg.UserId == userId);
                    group.Members.Remove(requestAccepted);
                    // await this.DeleteRequests(userId);
                }
            );

            List<int> membersToAdd = currentMembers.Except(originalMembers).ToList();

            foreach (var userId in membersToAdd)
            {
                await RemoveAllRequests(userId);
            }
            membersToAdd.ForEach(
                (userId) =>
                {

                    // User user = await this.userRepository.Get(userId);

                    if (userId != groupToEdit.Creator.Id)
                    {
                        group.Members.Add(new ParticipantGroup
                        {
                            IsCreator = false,
                            Status = Status.Accepted,
                            BelongingGroup = group,
                            BelongingGroupId = group.Id,
                            UserId = userId
                        });
                        // await this.CreateAcceptedMembership(false, orignalGroup, userId);
                    }
                    else
                    {
                        group.Members.Add(new ParticipantGroup
                        {
                            IsCreator = true,
                            Status = Status.Accepted,
                            BelongingGroup = group,
                            BelongingGroupId = group.Id,
                            UserId = userId
                        });
                        // await this.CreateAcceptedMembership(true, orignalGroup, userId);
                    }
                }
            );

            group.Name = groupToEdit.Name;

            await this.groupRepository.Update(group);
        }

        private async Task RemoveAllRequests(int userId)
        {
            List<ParticipantGroup> requests = await this.participantGroupRepository.GetByUser(userId);
            requests.ForEach(
                (request) =>
                {
                    this.participantGroupRepository.Remove(request);
                }
            );
            await this.participantGroupRepository.SaveChanges();
        }

        public async Task<bool> IsConformSize(int membersSize)
        {

            Company company = await this.companyRepository.Get(1);

            return membersSize >= company.MinGroupSize && membersSize <= company.MaxGroupSize;

        }

        /* ************************************************** */

        private async Task DeleteRequests(int userId)
        {
            List<ParticipantGroup> requests = await this.participantGroupRepository.GetByUser(userId);

            foreach (var request in requests)
            {
                this.participantGroupRepository.Remove(request);
            }

            await this.participantGroupRepository.SaveChanges();
        }

        private async Task CreateAcceptedMembership(bool isCreator, Group group, int userId)
        {

            User user = await this.userRepository.GetWithRequests(userId);

            foreach (var request in user.ParticipantGroups)
            {
                this.participantGroupRepository.Remove(request);
            }

            await this.participantGroupRepository.SaveChanges();

            var membershipCreator = new ParticipantGroup
            {
                IsCreator = isCreator,
                Status = Status.Accepted,
                BelongingGroup = group,
                User = user,
                BelongingGroupId = group.Id,
                UserId = user.Id
            };

            await this.participantGroupRepository.Insert(membershipCreator);

        }

    }
}