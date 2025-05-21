namespace LB6;

abstract class Vegetable
{
    public string Name { get; set; }
    public double Weight { get; set; }

    public Vegetable(string name, double weight)
    {
        Name = name;
        Weight = weight;
        Console.WriteLine($"Vegetable constructor: {Name}, weight: {Weight}g");
    }

    public abstract double CalculateCalories();
    public abstract void Cook();

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Vegetable: {Name}, weight: {Weight} g");
    }

    public void Peel()
    {
        Weight *= 0.9;
        Console.WriteLine($"Peeled {Name}, new weight: {Weight} g");
    }
}