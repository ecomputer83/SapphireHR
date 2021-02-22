using System.ComponentModel.DataAnnotations.Schema;

namespace SapphireHR.Database.EntityModels
{
    public class Rank : BaseEntity
    {
        public int OrganizationId { get; set; }
        public string RankName { get; set; }
        [ForeignKey("OrganizationId")]
        public OrganizationInfo OrganizationInfo { get; set; }

        public virtual RankPermission RankPermission { get; set; }
    }
}