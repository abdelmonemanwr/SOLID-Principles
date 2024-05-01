public abstract class BankAccountOperations
{
    public decimal Balance { get; protected set; }
    public decimal InterestRate { get; set; }
    public decimal withdrawalFee = 5.0m;
    public abstract void Deposit(decimal amount);

    public abstract void Withdraw(decimal amount);
}

public class Account : BankAccountOperations
{
    public virtual void Deposit(decimal amount)
    {
        Balance += amount;
    }
    public virtual void Withdraw(decimal amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
        }
        else
        {
            throw new InvalidOperationException("Insufficient balance.");
        }
    }
}

public class SavingsAccount : BankAccountOperations
{
    public override void Withdraw(decimal amount)
    {
        if (Balance >= amount + withdrawalFee)
        {
            Balance -= (amount + withdrawalFee);
        }
        else
        {
            throw new InvalidOperationException("Insufficient balance.");
        }
    }
}