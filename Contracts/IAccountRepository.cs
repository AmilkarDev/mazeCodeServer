using Entities.Models;
using System;
using System.Collections.Generic;

namespace Contracts
{
    public interface IAccountRepository: IRepositoryBase<Account>
    {
        IEnumerable<Account> AccountsByOwner(Guid iwnerId);
        IEnumerable<Account> GetAllAccounts();
        Account GetAccountById(Guid ownerId);
        Account GetAccountWithDetails(Guid ownerId);
        void CreateAccount(Account account);
        void UpdateAccount(Account account);
        void DeleteAccount(Account account);
    }
}
