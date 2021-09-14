#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class AccountRepository
    {
        public async Task<IReadOnlyCollection<Account>> GetAccountsAsync(User user)
        {
            // Fail because you don't want to call this method
            throw new InvalidOperationException("You are unit testing, this call should never happen...");
        }

        public async Task SaveChangesAsync(Account account)
        {
            // Fail because you don't want to call this method
            throw new InvalidOperationException("You are unit testing, this call should never happen...");
        }
    }
}
