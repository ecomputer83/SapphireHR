using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class ContactModel
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public int UserType { get; set; } = 2;
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

    }
}
