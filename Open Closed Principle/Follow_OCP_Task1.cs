public interface IPayment
{
    public void ProcessPayment(double amount);
}

public class Payment
{
    public double amount;
}

public class CreditCardPayment : IPayment
{
    public void ProcessPayment(double amount)
    {
        // Process credit card payment
    }
}

public class PayPalPayment : IPayment
{
    public void ProcessPayment(double amount)
    {
        // Process PayPal payment
    }
}

public class BankTransferPayment : IPayment
{
    public void ProcessPayment(double amount)
    {
        // Process bank transfer payment
    }
}