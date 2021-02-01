namespace SapphireHR.Database.EntityModels
{
    public class CompanyEmployee : BaseEntity
    {
        public int CompanyId { get; set; }
        public int EmployeeId { get; set; }
        public int RankId { get; set; }
    }
}