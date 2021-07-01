using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class Policy : BaseEntity, IEntity
    {
        public int OrganizationId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Document { get; set; }
        public virtual DepartmentPolicy DepartmentPolicy { get; set; }
    }
}
