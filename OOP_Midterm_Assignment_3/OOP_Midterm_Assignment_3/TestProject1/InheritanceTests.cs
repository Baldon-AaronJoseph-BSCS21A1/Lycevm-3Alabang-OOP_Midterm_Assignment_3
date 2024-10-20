using System;
using Xunit;
 
namespace TestProject1
{
    public class InheritanceTests
    {
        [Fact]
        public void CalculateInterest_AppliesHigherRate()
        {
            // Arrange
            BankAccount account = new SavingsAccount(12345, 1000, 0.07); // Use higher interest rate
 
            // Act
            account.CalculateInterest(); // Calculate interest
 
            // Assert
            Assert.Equal(1070, account.GetBalance()); // Expect 1070 after applying interest
        }
 
        [Fact]
        public void InheritsFromBankAccount()
        {
            // Arrange
            SavingsAccount account = new SavingsAccount(12345, 1000, 0.07);
 
            // Assert
            Assert.True(account is BankAccount); // Ensure it's an instance of BankAccount
        }
    }
}