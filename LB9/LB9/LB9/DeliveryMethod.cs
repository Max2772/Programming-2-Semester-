namespace LB9;

public interface IDeliveryMethod
{
    void Deliver(string companyName, string deliveryType);
}

public class CarDelivery : IDeliveryMethod
{
    public void Deliver(string companyName, string deliveryType)
    {
        Console.WriteLine($"{companyName} delivers cargo by Car for {deliveryType} delivery");
    }
}

public class DHLDelivery : IDeliveryMethod
{
    public void Deliver(string companyName, string deliveryType)
    {
        Console.WriteLine($"{companyName} delivers cargo by DHL for {deliveryType} delivery");
    }
}

public class AutoLightExpressDelivery : IDeliveryMethod
{
    public void Deliver(string companyName, string deliveryType)
    {
        Console.WriteLine($"{companyName} delivers cargo by AutoLight Express for {deliveryType} delivery");
    }
}