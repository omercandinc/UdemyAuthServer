using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyAuthServer.SharedLibrary.Configuration
{
    public class CustomTokenOptions
    {
        public List<string> Audience { get; set; }
        public string Issuer { get; set; }
        public int AccessTokenExpriation { get; set; }
        public int RefreshTokenExpriation { get; set; }
        public string SecurityKey { get; set; }
    }
}
