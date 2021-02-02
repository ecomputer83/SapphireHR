using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class RankPermission
    {
        public int Id { get; set; }
        public int RankId { get; set; }
        public bool ReadHoliday { get; set; }
        public bool ReadLeave { get; set; }
        public bool ReadAssets { get; set; }
        public bool ReadTimesheet { get; set; }
        public bool WriteHolidays { get; set; }
        public bool WriteLeave { get; set; }
        public bool WriteAssets { get; set; }
        public bool WriteTimesheet { get; set; }
        public bool DeleteHolidays { get; set; }
        public bool DeleteLeave { get; set; }
        public bool DeleteAssets { get; set; }
        public bool DeleteTimesheet { get; set; }

        [ForeignKey("RankId")]
        public CompanyRank Rank { get; set; }
    }
}
