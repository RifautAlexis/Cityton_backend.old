using Cityton.Data.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;

public static class ClaimsExtensions
{
    public static T GetLoggedInUserId<T>(this ClaimsPrincipal principal)
    {
        if (principal == null)
            throw new ArgumentNullException(nameof(principal));

        var loggedInUserId = principal.FindFirst(ClaimTypes.NameIdentifier);

        if (typeof(T) == typeof(string))
        {
            return (T)Convert.ChangeType(loggedInUserId, typeof(T));
        }
        else if (typeof(T) == typeof(int) || typeof(T) == typeof(long))
        {
            return loggedInUserId != null ? (T)Convert.ChangeType(loggedInUserId, typeof(T)) : (T)Convert.ChangeType(0, typeof(T));
        }
        else
        {
            throw new Exception("Invalid type provided");
        }
    }
}