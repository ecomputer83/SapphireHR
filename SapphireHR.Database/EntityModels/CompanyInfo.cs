using System.ComponentModel.DataAnnotations.Schema;

namespace SapphireHR.Database.EntityModels
{
    public class CompanyInfo : BaseEntity, IEntity
    {
        public string Name { get; set; }
        public string ContactPerson { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Directory { get; set; }
        public int OrganizationId { get; set; }
        [ForeignKey("OrganizationId")]
        public OrganizationInfo Organization { get; set; }
    }
}