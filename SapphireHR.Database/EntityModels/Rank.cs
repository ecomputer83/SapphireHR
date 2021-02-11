namespace SapphireHR.Database.EntityModels
{
    public class Rank : BaseEntity
    {
        public int OrganizationId { get; set; }
        public string RankName { get; set; }
        public OrganizationInfo OrganizationInfo { get; set; }
    }
}