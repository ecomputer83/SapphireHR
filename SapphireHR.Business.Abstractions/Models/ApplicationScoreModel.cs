using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class ApplicationScoreModel
    {
        public int Id { get; set; }
        public int ApplicationId { get; set; }
        public double Score { get; set; }
        public int Status { get; set; }
    }
}
