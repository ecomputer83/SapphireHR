using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class ApplicationLogin : BaseEntity, IEntity
    {
        public int ApplicationId { get; set; }
        public string UserName { get; set; }
        public  string Password { get; set; }

        [ForeignKey("ApplicationId")]
        public Application Application { get; set; }
    }
}
