namespace LB8;

class Bank
{
    private readonly List<IClient> clients = new List<IClient>();

    public void AddClient(IClient client) => clients.Add(client);

    public decimal CalculateTotalDeposits()
    {
        decimal total = 0;
        foreach (var client in clients)
        {
            total += client.GetTotalDeposit();
        }
        return total;
    }
}