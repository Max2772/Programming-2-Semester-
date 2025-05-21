namespace LB6;

class Carrot : Vegetable
{
    public double Length { get; set; }

    public Carrot(string name, double weight, double length) : base(name, weight)
    {
        Length = length;
    }

    public override double CalculateCalories()
    {
        return Weight * 0.41;
    }

    public override void Cook()
    {
        Console.WriteLine($"Cooked carrot {Name}");
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Carrot: {Name}, weight: {Weight} g, length: {Length} cm");
    }
}