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

namespace Cityton.Service
{

    public interface IUserService
    {
        Task Update(User user);
        Task<User> Get(int id);
        Task<User> GetByUsername(string username);
        Task<User> GetByEmail(string email);
        Task<User> GetByPhoneNumber(string phoneNumber);
        Task<List<User>> Search(string sl, string q);
        Task<string> UploadProfilePicture(int userId, IFormFile file);
    }

    public class UserService : IUserService
    {

        private readonly IHttpContextAccessor _httpContextAccessor;
        private IUserRepository userRepository;
        private readonly IConfiguration _config;

        public UserService(
            IUserRepository userRepository,
            IConfiguration config,
            IHttpContextAccessor httpContextAccessor)
        {
            this.userRepository = userRepository;
            this._config = config;
            this._httpContextAccessor = httpContextAccessor;
        }

        public async Task Update(User user)
        {
            await userRepository.Update(user);
        }

        public async Task<User> Get(int id)
        {
            return await userRepository.Get(id);
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
            // var folderName = Path.Combine("wwwroot", "images\\profile\\" + userId + "_profilePicture.png");
            // var filePath = Path.Combine(Directory.GetCurrentDirectory(), folderName);
            // if (!File.Exists(filePath))
            // {
            //     return null;
            // }

            string cloudName = this._config.GetSection("Cloudinary:cloudName").Value;
            string apiKey = this._config.GetSection("Cloudinary:apiKey").Value;
            string apiSecret = this._config.GetSection("Cloudinary:apiSecret").Value;

            Account account = new Account(cloudName, apiKey, apiSecret);

            Cloudinary cloudinary = new Cloudinary(account);

            Stream stream = file.OpenReadStream();

            var uploadParams = new ImageUploadParams()
            {
                // File = new FileDescription(filePath),
                File = new FileDescription("1_profilePicture", stream),
                PublicId = "1_profilePicture"
                // UseFilename = true
            };

            ImageUploadResult uploadResult = await cloudinary.UploadAsync(uploadParams);

            stream.Close();

            // int connectedUserId = _httpContextAccessor.HttpContext.User.GetLoggedInUserId<int>();
            int connectedUserId = 1;
            User user = await this.Get(connectedUserId);
            user.Picture = uploadResult.SecureUri.AbsoluteUri;
            await userRepository.SaveChanges();
            //return userId + " " + filePath + " " + uploadParams.File.FilePath + " " + uploadParams.File.FileName;
            return uploadResult.SecureUri.AbsoluteUri;
        }

    }
}