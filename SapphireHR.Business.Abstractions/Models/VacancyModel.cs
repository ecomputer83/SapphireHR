﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class VacancyModel: BaseModel
    {
        public int CompanyId { get; set; }
        public int JobProfileId { get; set; }
        public int DesignationId { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public string Scores { get; set; }
        public int RequestedBy { get; set; }
        public DateTime RequestedOn { get; set; }
        public DateTime PeriodFrom { get; set; }
        public DateTime PeriodTo { get; set; }

        public EmployeeModel Requestor { get; set; }

        public DesignationModel Designation { get; set; }
        public JobProfileModel JobProfile { get; set; }

        public virtual JobRequisitionModel JobRequisition { get; set; }
    }
}
