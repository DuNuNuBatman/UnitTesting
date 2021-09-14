using System;

namespace UnitTesting
{
    public class Account
    {
        public Account(Guid id, decimal balance)
        {
            Id = id;
            Balance = balance;
        }

        public Guid Id { get; }
        public decimal Balance { get; }
    }
}
