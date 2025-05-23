namespace LB9;

public abstract class DeliveryCompanyFactory
{
    public abstract DeliveryCompany CreateCompany(string name);
}

public class CityDeliveryFactory : DeliveryCompanyFactory
{
    private readonly IDeliveryMethod deliveryMethod;

    public CityDeliveryFactory(IDeliveryMethod deliveryMethod)
    {
        this.deliveryMethod = deliveryMethod;
    }

    public override DeliveryCompany CreateCompany(string name)
    {
        return new CityDelivery(name, deliveryMethod);
    }
}

public class InterCityDeliveryFactory : DeliveryCompanyFactory
{
    private readonly IDeliveryMethod deliveryMethod;

    public InterCityDeliveryFactory(IDeliveryMethod deliveryMethod)
    {
        this.deliveryMethod = deliveryMethod;
    }

    public override DeliveryCompany CreateCompany(string name)
    {
        return new InterCityDelivery(name, deliveryMethod);
    }
}

public class InternationalDeliveryFactory : DeliveryCompanyFactory
{
    private readonly IDeliveryMethod deliveryMethod;

    public InternationalDeliveryFactory(IDeliveryMethod deliveryMethod)
    {
        this.deliveryMethod = deliveryMethod;
    }

    public override DeliveryCompany CreateCompany(string name)
    {
        return new InternationalDelivery(name, deliveryMethod);
    }
}