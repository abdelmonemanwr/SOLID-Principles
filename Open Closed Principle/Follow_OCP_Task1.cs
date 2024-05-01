public interface IPayment
{
    public void ProcessPayment(double amount);
}

public class Payment
{
    public double amount;
    private IPayment payment;
    Public Payment(IPayment payment, double amount)
    {
        this.payment = payment;
    }
    public void Pay(IPayment payment, double amount)
    {
        payment.ProcessPayment(amount);
    }
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