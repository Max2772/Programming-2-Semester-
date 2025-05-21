namespace LB6;

class Potato : Vegetable
{
    public int EyesCount { get; set; }

    public Potato(string name, double weight, int eyes) : base(name, weight)
    {
        EyesCount = eyes;
    }

    public override double CalculateCalories()
    {
        return Weight * 0.77;
    }

    public override void Cook()
    {
        Console.WriteLine($"Fried potato {Name}");
    }
}