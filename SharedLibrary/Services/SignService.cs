using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyAuthServer.SharedLibrary.Services
{
    public static class SignService
    {
        public static SecurityKey GetSymmectricSecurityKey(string securityKey)
        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
        }
    }
}
