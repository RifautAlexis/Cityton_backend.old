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
    public class DataController : ControllerBase
    {

        private readonly IConfiguration _appSettings;
        private IDataService _dataService;

        public DataController(IDataService dataService)
        {
            _dataService = dataService;
        }

        [Authorized(Role.Admin)]
        [HttpGet("user")]
        public IActionResult UserTable()
        {

            MemoryStream stream = this._dataService.GetUsers();
            string excelName = "TableUser-" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".xlsx";
            return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", excelName);
        }

    }
}