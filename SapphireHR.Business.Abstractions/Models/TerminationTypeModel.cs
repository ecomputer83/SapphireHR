using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class TerminationTypeModel
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public string Name { get; set; }
    }
}