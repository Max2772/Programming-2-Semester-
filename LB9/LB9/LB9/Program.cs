using System;
using System.Collections.Generic;

namespace LB9;

class Program
{
    static void Main(string[] args)
    {
        List<DeliveryCompany> companies = new List<DeliveryCompany>();

        DeliveryCompanyFactory cityFactory = new CityDeliveryFactory(new CarDelivery());
        DeliveryCompanyFactory interCityFactory = new InterCityDeliveryFactory(new DHLDelivery());
        DeliveryCompanyFactory internationalFactory = new InternationalDeliveryFactory(new AutoLightExpressDelivery());

        companies.Add(cityFactory.CreateCompany("FastCity"));
        companies.Add(interCityFactory.CreateCompany("RegionalExpress"));
        companies.Add(internationalFactory.CreateCompany("GlobalShip"));

        foreach (var company in companies)
        {
            company.GetInfo();
            company.Deliver();

            if (company is ICargoTracking tracking)
            {
                tracking.TrackCargo();
            }
            if (company is ICargoEscort escort)
            {
                escort.EscortCargo();
            }
            if (company is ICargoInsurance insurance)
            {
                insurance.InsureCargo();
            }
            Console.WriteLine();
        }
    }
}