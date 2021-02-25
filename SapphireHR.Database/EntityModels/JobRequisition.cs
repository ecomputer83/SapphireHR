using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class JobRequisition : BaseEntity
    {
        public int VacancyId { get; set; }
        public string Duties { get; set; }
        [ForeignKey("VacancyId")]
        public Vacancy Vacancy { get;set; }
    }
}
