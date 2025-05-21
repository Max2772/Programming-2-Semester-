namespace LB8;

class NoBonusStrategy : IBonusStrategy
{
    public decimal CalculateBonus(decimal initialDeposit)
    {
        return 0;
    }
}

class FixedBonusStrategy : IBonusStrategy
{
    private readonly decimal fixedBonus;

    public FixedBonusStrategy(decimal bonus)
    {
        fixedBonus = bonus;
    }

    public decimal CalculateBonus(decimal initialDeposit)
    {
        return fixedBonus;
    }
}