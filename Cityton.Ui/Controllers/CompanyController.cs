using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Cityton.Data.DTOs;
using Cityton.Data;
using System.Security.Claims;
using System.Text;
using Cityton.Service;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Configuration;
using FluentValidation.AspNetCore;
using Cityton.Service.Validators.DTOs;
using Cityton.Data.Models;
using System.IO;
using Cityton.Data.Common;
using Cityton.Data.Mapper;

namespace Cityton.Ui.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CompanyController : ControllerBase
    {

        private readonly IConfiguration _appSettings;
        private ICompanyService _companyService;
        private IUserService _userService;

        public CompanyController(ICompanyService companyService, IUserService userService)
        {
            _companyService = companyService;
            _userService = userService;
        }

        [Authorized(Role.Member, Role.Admin)]
        [HttpGet("")]
        public async Task<IActionResult> GetSettings()
        {

            int connectedUserId = int.Parse(User.Identity.Name);
            User connectedUser = await this._userService.Get(connectedUserId);

            Company company = await this._companyService.Get(connectedUser.CompanyId);
            return Ok(company.ToSettings());
        }

    }
}