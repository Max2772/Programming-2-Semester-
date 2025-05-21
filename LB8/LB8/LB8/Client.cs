namespace LB8;

abstract class Client : IClient
{
    public string Name { get; }
    public decimal Deposit { get; }
    protected IBonusStrategy BonusStrategy { get; }

    protected Client(string name, decimal deposit, IBonusStrategy strategy)
    {
        Name = name;
        Deposit = deposit;
        BonusStrategy = strategy;
    }

    public virtual decimal GetTotalDeposit()
    {
        return Deposit + BonusStrategy.CalculateBonus(Deposit);
    }
}

class RegularClient : Client
{
    public RegularClient(string name, decimal deposit) : base(name, deposit, new NoBonusStrategy()) { }
}

class PremiumClient : Client
{
    public PremiumClient(string name, decimal deposit, decimal bonus) : base(name, deposit, new FixedBonusStrategy(bonus)) { }
}