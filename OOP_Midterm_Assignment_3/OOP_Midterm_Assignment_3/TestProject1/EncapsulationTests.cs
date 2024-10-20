using System;
using Xunit;
 
namespace TestProject1
{
    public class EncapsulationTests
    {
        [Fact]
        public void Withdraw_OtherBanksShouldHaveChargeOfTwentyPesos()
        {
            // Arrange
            BankAccount account = new BankAccount(12345, 1000); // Starting balance of 1000
 
            // Act
            account.Withdraw(1000, true); // Withdraw from another bank
 
            // Assert
            Assert.Equal(-20, account.GetBalance()); // Should be -20 due to 1000 withdrawal and 20 charge
        }
 
        [Fact]
        public void Withdraw_OtherBanksShouldNotExceedBalance()
        {
            // Arrange
            BankAccount account = new BankAccount(12345, 1000);
 
            // Act
            account.Withdraw(2000, true); // Attempting to withdraw more than balance
 
            // Assert
            Assert.Equal(1000, account.GetBalance()); // Balance should remain the same
        }
        
        // Add more tests as needed to cover other scenarios
    }
}
