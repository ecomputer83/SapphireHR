using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public partial class MailMessageAddress
    {
        public Guid MailMessageAddressId { get; set; }
        public Guid MailMessageId { get; set; }
        public string AddressType { get; set; }
        public string EmailAddress { get; set; }
        public string DisplayName { get; set; }
        public DateTimeOffset CreatedOn { get; set; }

        public virtual MailMessage MailMessage { get; set; }
    }
}
