namespace LB8;

class Bank
{
    private FixedBonusStrategy fixedBonusStrategy = new FixedBonusStrategy(100);
    private NoBonusStrategy noBonusStrategy = new NoBonusStrategy();
    private readonly List<IClient> clients = new List<IClient>();

    public void AddClient(IClient client) => clients.Add(client);

    public void AddBonusClient(string clientName, decimal deposit)
    {
        clients.Add(new Client(clientName, deposit, fixedBonusStrategy));
    }
    public void AddNoBonusClient(string clientName, decimal deposit)
    {
        clients.Add(new Client(clientName, deposit, noBonusStrategy));
    }
    public decimal CalculateTotalDeposits()
    {
        decimal total = 0;
        foreach (var client in clients)
        {
            total += client.GetTotalDeposit();
        }
        return total;
    }


    public void Show()
    {
        foreach (var client in clients)
        {
            Console.WriteLine($"Вклад {client.Name}: {client.GetTotalDeposit()}$");
        }
    }
}