namespace LB6;

sealed class Broccoli : Vegetable
{
    public double Diameter { get; set; }

    public Broccoli(string name, double weight, double diameter) : base(name, weight)
    {
        Diameter = diameter;
    }

    public override double CalculateCalories()
    {
        return Weight * 0.24;
    }

    public override void Cook()
    {
        Console.WriteLine($"Baked broccoli {Name}");
    }

    public new void Peel()
    {
        Console.WriteLine($"Won't peel broccoli {Name}");
    }
}