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
using Cityton.Data.Mapper;

namespace Cityton.Service
{

    public interface IUserService
    {
        Task<User> UpdateToken(User user);
        Task<UserDTO> Update(UserUpdateDTO userToUpdate);
        Task<User> Get(int id);
        Task<User> GetToTransformInDTO(int id);
        Task<User> GetByUsername(string username);
        Task<User> GetByEmail(string email);
        Task<User> GetByPhoneNumber(string phoneNumber);
        Task<List<User>> Search(string sl, string q);
        Task<string> UploadProfilePicture(int userId, IFormFile file);
        Task<bool> ExistUsername(string username);
        Task<bool> ExistPhoneNumber(string username);
        Task<bool> ExistEmail(string email);
        Task Delete(User user);
        Task<List<User>> GetUsersWithoutGroup();
        Task<User> GetWithRequest(int userId);
        Task<User> Get_Challenges_Achievements(int userId);
    }

    public class UserService : IUserService
    {

        private IUserRepository userRepository;
        private readonly IConfiguration _appSettings;
        private readonly IGroupService groupService;

        public UserService(
            IUserRepository userRepository,
            IConfiguration config,
            IGroupService groupService)
        {
            this.userRepository = userRepository;
            this._appSettings = config;
            this.groupService = groupService;
        }

        public async Task<User> UpdateToken(User user)
        {
            string tokenSecret = this._appSettings.GetSection("Settings:Secret").Value;
            user.CreateToken(tokenSecret);

            await userRepository.SaveChanges();

            return user;
        }

        public async Task<UserDTO> Update(UserUpdateDTO userToUpdate)
        {

            //validator sur userToUpdate

            User userInDb = await this.GetToTransformInDTO(userToUpdate.Id);

            if (userInDb == null) return null;

            userInDb.DeepCopy(userToUpdate);

            if (!string.IsNullOrEmpty(userToUpdate.Password))
            {
                userInDb.CreatePasswordHash(userToUpdate.Password);
            }

            //validator sur user
            string tokenSecret = this._appSettings.GetSection("Settings:Secret").Value;

            userInDb.CreateToken(tokenSecret);

            await userRepository.Update(userInDb);

            User test = await this.userRepository.Get(userInDb.Id);

            return userInDb.ToDTO();
        }

        public async Task<User> Get(int id)
        {
            return await userRepository.Get(id);
        }

        public async Task<User> GetToTransformInDTO(int id)
        {
            return await userRepository.GetWithRequests(id);
        }

        public async Task<User> GetByUsername(string username)
        {
            return await userRepository.GetByUsername(username);
        }

        public async Task<User> GetByEmail(string email)
        {
            return await userRepository.GetByEmail(email);
        }

        public async Task<User> GetByPhoneNumber(string phoneNumber)
        {
            return await userRepository.GetByPhoneNumber(phoneNumber);
        }

        public async Task<List<User>> Search(string securityLevel, string username)
        {

            if (username == null) username = "";

            return await userRepository.GetByUsernameRole(securityLevel, username);
        }

        public async Task<string> UploadProfilePicture(int userId, IFormFile file)
        {

            string cloudName = this._appSettings.GetSection("Cloudinary:cloudName").Value;
            string apiKey = this._appSettings.GetSection("Cloudinary:apiKey").Value;
            string apiSecret = this._appSettings.GetSection("Cloudinary:apiSecret").Value;

            Account account = new Account(cloudName, apiKey, apiSecret);

            Cloudinary cloudinary = new Cloudinary(account);

            Stream stream = file.OpenReadStream();

            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription("1_profilePicture", stream),
                PublicId = "1_profilePicture"
            };

            ImageUploadResult uploadResult = await cloudinary.UploadAsync(uploadParams);

            stream.Close();

            User user = await this.Get(userId);

            user.Picture = uploadResult.SecureUri.AbsoluteUri;
            await userRepository.SaveChanges();

            return uploadResult.SecureUri.AbsoluteUri;
        }

        public async Task<bool> ExistUsername(string username)
        {
            return await userRepository.GetByUsername(username) != null;
        }

        public async Task<bool> ExistPhoneNumber(string phoneNumber)
        {
            return await userRepository.GetByPhoneNumber(phoneNumber) != null;
        }

        public async Task<bool> ExistEmail(string email)
        {
            return await userRepository.GetByEmail(email) != null;
        }

        public async Task Delete(User user)
        {
            foreach (var challengesCreated in user.Challenges)
            {
                challengesCreated.AuthorId = null;
            }

            foreach (var achievement in user.Achievements)
            {
                achievement.WinnerId = null;
            }
            await userRepository.Update(user);

            foreach (var request in user.ParticipantGroups)
            {
                await this.groupService.DeleteRequest(request);
            }

            await userRepository.Delete(user);
        }

        public async Task<List<User>> GetUsersWithoutGroup()
        {
            return await userRepository.GetUsersWithoutGroup();
        }

        public async Task<User> GetWithRequest(int userId)
        {
            return await userRepository.GetWithRequests(userId);
        }

        public async Task<User> Get_Challenges_Achievements(int userId)
        {
            return await userRepository.Get_Challenges_Achievements(userId);
        }

    }
}