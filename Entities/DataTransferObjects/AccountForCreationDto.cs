using System;

namespace Entities.DataTransferObjects
{
    public class AccountForCreationDto
    {
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; }
        public string AccountType { get; set; }
    }
}
