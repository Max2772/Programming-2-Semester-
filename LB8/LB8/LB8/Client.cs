namespace LB8;

class Client : IClient
{
    public string Name { get; }
    public decimal Deposit { get; }
    public IBonusStrategy BonusStrategy { get; }

    public Client(string name, decimal deposit, IBonusStrategy strategy)
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

/*class RegularClient : Client
{
    public RegularClient(string name, decimal deposit) : base(name, deposit, new NoBonusStrategy()) { }
}

class PremiumClient : Client
{
    public PremiumClient(string name, decimal deposit, decimal bonus) : base(name, deposit, new FixedBonusStrategy(bonus)) { }
}
*/