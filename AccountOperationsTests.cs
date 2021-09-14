using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace UnitTesting
{
    public class AccountOperationsTests
    {
        [Fact]
        public async Task GetTotalAsync_ExistingAccountBalances_SumOfAllBalances()
        {
            // NOTE: How would you refactor this so you can test the add functionality to get the asserted result?

            // Arrange
            User user = new();
            AccountRepository repository = new();
            AccountOperations sut = new(user, repository);

            // Act
            decimal result = await sut.GetTotalAsync();

            // Assert
            Assert.Equal(100, result);
        }

        [Fact]
        private async Task TransferAsync_ValidAccounts_AccountBalancesCorrectlySaved()
        {
            // Arrange
            Account fromAccount = new(Guid.Empty, 100m);
            Account toAccount = new(Guid.Empty, 0m);

            User user = new();
            AccountRepository repository = new();
            AccountOperations sut = new(user, repository);

            // Act
            await sut.TransferAsync(fromAccount, toAccount, 100m);

            // Assert
            // NOTE: Check to see if the balance matches expected value
            // NOTE: Check to see if the repository SaveChangesAsync did in fact get called correctly
        }

        [Fact]
        private async Task TransferAsync_InvalidTransferAmount_ThrowsInvalidOperationException()
        {
            // Arrange
            Account fromAccount = new(Guid.Empty, 50m);
            Account toAccount = new(Guid.Empty, 50m);

            User user = new();
            AccountRepository repository = new();
            AccountOperations sut = new(user, repository);

            // Act
            await sut.TransferAsync(fromAccount, toAccount, 100m);

            // Assert
            // NOTE: Assert than an InvalidOperationException was thrown as the transfer amount exceeds the account balance
        }
    }
}
