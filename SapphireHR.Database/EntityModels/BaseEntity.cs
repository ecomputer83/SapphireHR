using System;

namespace SapphireHR.Database.EntityModels
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int Status { get; set; } // "1" or "0"

    }
}