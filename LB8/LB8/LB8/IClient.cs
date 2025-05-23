namespace LB8;

interface IClient
{
    string Name { get; }
    decimal Deposit { get; }
    decimal GetTotalDeposit();
    IBonusStrategy BonusStrategy { get; }
}