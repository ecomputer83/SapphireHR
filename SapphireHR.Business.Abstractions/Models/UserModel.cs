using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class UserModel
    {
        public string Id { get; set; }

        public int OrganizationId { get; set; }
        public string FullName { get; set; }
        public int UserType { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public bool IsLockout { get; set; }
    }
}
