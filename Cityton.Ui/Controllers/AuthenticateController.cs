using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Cityton.Data.DTOs;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace Cityton.Ui.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AuthenticateController : ControllerBase
    {

        public AuthenticateController() { }

        //[HttpPost]
        //[Route("login")]
        //public async Task<IActionResult> Login([FromBody] LoginDTO model)
        //{
        //    var user = await userManager.FindByNameAsync(model.Username);
        //    if (user != null && await userManager.CheckPasswordAsync(user, model.Password))
        //    {

        //        var authClaims = new[]
        //        {
        //            new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
        //            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        //        };

        //        var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("SecureKey"));

        //        var token = new JwtSecurityToken(
        //            issuer: "http://dotnetdetail.net",
        //            audience: "http://dotnetdetail.net",
        //            expires: DateTime.Now.AddHours(3),
        //            claims: authClaims,
        //            signingCredentials: new Microsoft.IdentityModel.Tokens.SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
        //            );

        //        return Ok(new
        //        {
        //            token = new JwtSecurityTokenHandler().WriteToken(token),
        //            expiration = token.ValidTo
        //        });
        //    }
        //    return Unauthorized();
        //}

    }
}