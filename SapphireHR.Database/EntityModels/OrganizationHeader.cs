using System.ComponentModel.DataAnnotations.Schema;

namespace SapphireHR.Database.EntityModels
{
    public class OrganizationHeader : BaseEntity
    {
        public int OrganizationId { get; set; }
        public string HostName { get; set; }
        public int Status {get;set;}
        
        [ForeignKey("OrganizationId")]
        public OrganizationInfo Organization { get; set; }
    }
}