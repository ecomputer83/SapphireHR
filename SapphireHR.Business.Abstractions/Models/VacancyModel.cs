using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class VacancyModel: BaseModel
    {
        public int JobProfileId { get; set; }
        public int DesignationId { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public string Scores { get; set; }
    }
}
