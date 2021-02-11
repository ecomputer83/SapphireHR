using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Data.Abstractions.Models
{
    public class Rank : BaseEntity
    {
        public int OrganizationId { get; set; }
        public string RankName { get; set; }
        public OrganizationInfo OrganizationInfo { get; set; }
    }
}
