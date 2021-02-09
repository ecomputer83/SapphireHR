using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class RankModel
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public string RankName { get; set; }
    }
}
