using System;
using System.Linq;
using System.Threading.Tasks;

namespace UnitTesting
{
    /// <summary>
    /// Performs operations on accounts.
    /// </summary>
    public class AccountOperations
    {
        private readonly AccountRepository _accountRepository;
        private readonly User _user;

        public AccountOperations(User user, AccountRepository accountRepository)
        {
            _user = user;
            _accountRepository = accountRepository;
        }

        /// <summary>
        /// Gets the total for all accounts.
        /// </summary>
        /// <returns>Total account amount</returns>
        public async Task<decimal> GetTotalAsync()
        {
            var accounts = await _accountRepository.GetAccountsAsync(_user);

            return accounts.Select(x => x.Balance).Sum();
        }

        /// <summary>
        /// Transfers the specified amount from one account to another.
        /// </summary>
        /// <param name="from">Account to transfer from.</param>
        /// <param name="to">Account to transfer to.</param>
        /// <param name="amount">The amount to transfer.</param>
        public async Task TransferAsync(Account from, Account to, decimal amount)
        {
            // Balance in immutable, create a new account object to save that... but how do you test that the balance was updated correctly?
            //from.Balance -= amount;
            //from.Balance += amount;

            await _accountRepository.SaveChangesAsync(from);
            await _accountRepository.SaveChangesAsync(to);
        }
    }
}
