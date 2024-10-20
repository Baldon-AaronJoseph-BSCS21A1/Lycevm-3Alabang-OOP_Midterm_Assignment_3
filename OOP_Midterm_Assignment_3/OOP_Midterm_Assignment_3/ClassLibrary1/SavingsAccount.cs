public class SavingsAccount : BankAccount
{
    public SavingsAccount(int accountNumber, double balance, double interestRate = 0.07)
        : base(accountNumber, balance, interestRate)
    {
    }
 
    
    public override void CalculateInterest()
    {
        // Call the base method to calculate interest
        base.CalculateInterest();
        
    }
}