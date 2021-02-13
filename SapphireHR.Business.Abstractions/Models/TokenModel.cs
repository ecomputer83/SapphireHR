using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class TokenModel
    {
        public bool? HasVerifiedEmail { get; set; }
        public bool? TFAEnabled { get; set; }
        public string Token { get; set; }
        public UserModel User { get; set; } 
        public List<string> Role { get; set; }
        public object Extra { get; set; } 
    }
}
