namespace LB9;

public abstract class DeliveryCompany
{
    protected string name;
    protected string deliveryType;
    protected IDeliveryMethod deliveryMethod;

    protected DeliveryCompany(string name, string deliveryType, IDeliveryMethod deliveryMethod)
    {
        this.name = name;
        this.deliveryType = deliveryType;
        this.deliveryMethod = deliveryMethod;
    }

    public abstract void GetInfo();

    public void Deliver()
    {
        deliveryMethod.Deliver(name, deliveryType);
    }
}

public class CityDelivery : DeliveryCompany, ICargoTracking
{
    public CityDelivery(string name, IDeliveryMethod deliveryMethod)
        : base(name, "City", deliveryMethod) { }

    public override void GetInfo()
    {
        Console.WriteLine($"City Delivery Company: {name}, Type: {deliveryType}");
    }

    public void TrackCargo()
    {
        Console.WriteLine($"{name} is tracking cargo for city delivery");
    }
}

public class InterCityDelivery : DeliveryCompany, ICargoEscort, ICargoInsurance
{
    public InterCityDelivery(string name, IDeliveryMethod deliveryMethod)
        : base(name, "InterCity", deliveryMethod) { }

    public override void GetInfo()
    {
        Console.WriteLine($"InterCity Delivery Company: {name}, Type: {deliveryType}");
    }

    public void EscortCargo()
    {
        Console.WriteLine($"{name} is providing cargo escort for intercity delivery");
    }

    public void InsureCargo()
    {
        Console.WriteLine($"{name} is insuring cargo for intercity delivery");
    }
}

public class InternationalDelivery : DeliveryCompany, ICargoTracking, ICargoInsurance
{
    public InternationalDelivery(string name, IDeliveryMethod deliveryMethod)
        : base(name, "International", deliveryMethod) { }

    public override void GetInfo()
    {
        Console.WriteLine($"International Delivery Company: {name}, Type: {deliveryType}");
    }

    public void TrackCargo()
    {
        Console.WriteLine($"{name} is tracking cargo for international delivery");
    }

    public void InsureCargo()
    {
        Console.WriteLine($"{name} is insuring cargo for international delivery");
    }
}