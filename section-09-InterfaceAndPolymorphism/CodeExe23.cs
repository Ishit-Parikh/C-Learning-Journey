namespace Section09;

/*
Create a simple C# program that demonstrates polymorphism using interfaces. Define an interface IPayment with a method ProcessPayment. Then, create two classes CreditCardPayment and PayPalPayment that implement this interface and provide their own implementations for the ProcessPayment method. Use polymorphism to call the ProcessPayment method on instances of both classes.

Alert!
The result of execution should be:
"Processing credit card payment" "Processing PayPal payment"
*/
public interface IPayment
{
    void ProcessPayment();
}

public class CreditCardPayment: IPayment
{
    public void ProcessPayment()
    {
        System.Console.WriteLine("Processing credit card payment");
    }
}

public class PayPalPayment: IPayment
{
    public void ProcessPayment()
    {
        System.Console.WriteLine("Processing Paypal payment");
    }
}

public class PaymentType
{
    public IPayment _paymentType;
    public PaymentType (IPayment paymentType)
    {
        _paymentType = paymentType;
    }

    public void CallPaymentType()
    {
        _paymentType.ProcessPayment();
    }
}

public class CodeExe23
{
    public static void Run()
    {
        IPayment creditcardpayment = new CreditCardPayment();
        PaymentType paymentType = new PaymentType(creditcardpayment);
        paymentType.CallPaymentType();

        IPayment paypalpayment = new PayPalPayment();
        paymentType = new PaymentType(paypalpayment);
        paymentType.CallPaymentType();
    }
}