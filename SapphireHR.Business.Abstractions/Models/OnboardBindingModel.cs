using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class OnboardBindingModel
    {
        public int ApplicationID { get; set; }
        public EmployeeModel Employee { get; set; }
        public OnboardingModel Onboarding { get; set; }
    }
}
