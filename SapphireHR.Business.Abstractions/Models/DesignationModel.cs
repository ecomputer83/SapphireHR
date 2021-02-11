using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class DesignationModel
    {
        public int OrganizationId { get; set; }
        public int DepartmentId { get; set; }
        public string Name { get; set; }

    }
}
