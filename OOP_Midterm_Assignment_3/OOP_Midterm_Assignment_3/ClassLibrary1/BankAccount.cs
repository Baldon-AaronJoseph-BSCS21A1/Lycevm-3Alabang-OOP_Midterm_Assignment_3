public class BankAccount
{
    private int accountNumber;
    private double balance;
    private double interestRate;
 
    public BankAccount(int accountNumber, double balance, double interestRate = 0.05)
    {
        this.accountNumber = accountNumber;
        this.balance = balance;
        this.interestRate = interestRate;
    }
 
    public void Deposit(double amount)
    {
        balance += amount;
    }
 
    // Base withdrawal method
    public void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
        }
    }
 
    // withdrawal method with charge for other bank withdrawals
    public void Withdraw(double amount, bool isOtherBank)
    {
        if (amount <= balance)
        {
            balance -= amount;
            if (isOtherBank)
            {
                balance -= 20; // Charge for other bank withdrawals
            }
        }
    }
 
    // Method to calculate interest
    public virtual void CalculateInterest()
    {
        balance += balance * interestRate; // Calculate interest based on the current balance
    }
 
    public double GetBalance()
    {
        return balance;
    }
}