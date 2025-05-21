namespace LB5;

public class Bank
{
    //private readonly DepositAccount _depositAccount;
    public string Name { get; set; }
    public double MaxDepositAmount { get; set; }
    public double[] depositTypePercentages = {5.5, 8.0, 12.0};
    private List<DepositAccount> DepositAccounts = new List<DepositAccount>();

    public Bank(string name, double maxDepositAmount)
    {
        Name = name;
        MaxDepositAmount = maxDepositAmount;
    }

    public void AmountOfDepositAccounts()
    {
        Console.WriteLine($"Total amount of deposit accounts: {DepositAccounts.Count}");
        for (int i = 0; i < DepositAccounts.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {DepositAccounts[i].FIO}");
        }
    }

    public void GetBankPercantage()
    {
        Console.WriteLine($"Deposit Standard: {depositTypePercentages[0]}%");
        Console.WriteLine($"Deposit Premium: {depositTypePercentages[1]}%");
        Console.WriteLine($"Deposit Platinum: {depositTypePercentages[2]}%");
    }

    public void ChangeBankPercantage(DepositType type)
    {
        double newPercentage = IO.ReadDouble("Enter new percentage: ");
        depositTypePercentages[(int)type] = newPercentage;
        for (int i = 0; i < DepositAccounts.Count; i++)
        {
            if (DepositAccounts[i].depositType == type)
            {
                DepositAccounts[i].ChangePercentageForBankManagement(newPercentage);
            }
        }
        Console.WriteLine($"{type.ToString()} type percentage changed to {newPercentage}%");
    }
    
    public void AddDepositAccount()
    {
        string? fio = IO.ReadString("Input new deposit FIO: ");
        double balance = IO.ReadDouble("Balance amount in $: ");
        if (balance > MaxDepositAmount)
        {
            Console.WriteLine("Deposit account is too big!");
            return;
        }

        DepositType depositType = DepositAccounts[0].GetTypeOfAccount();
        
        DepositAccounts.Add(new DepositAccount(this, fio, balance, depositType));
        Console.WriteLine($"Deposit account with FIO {fio} added to the bank system");
    }
    
    public void AddDepositAccountDebug(string fio, double balance, DepositType type)
    {
        DepositAccounts.Add(new DepositAccount(this, fio, balance, type));
    }

    public void DeleteDepositAccount()
    {
        string? fio = IO.ReadString("Input deposit FIO to delete: ");
        for(int i = 0; i < DepositAccounts.Count; ++i)
        {
            if (DepositAccounts[i].FIO == fio)
            {
                DepositAccounts.RemoveAt(i);
                return;
            }
        }
        Console.WriteLine("Account not found!");
    }
    
    public DepositAccount AccessDepositAccount()
    {
        string? fio = IO.ReadString("Input deposit FIO to access: ");
        for(int i = 0; i < DepositAccounts.Count; ++i)
        {
            if (DepositAccounts[i].FIO == fio)
            {
                return DepositAccounts[i];
            }
        }
        Console.WriteLine("Account not found!");
        return null;
    }
    
    public void GetBankAnnualPayment()
    {
        double payment = 0;
        for (int i = 0; i < DepositAccounts.Count; ++i)
        {
            payment += DepositAccounts[i].Balance * ((DepositAccounts[i].Percentage / 100.0) + 1);
        }
        Console.WriteLine($"\nBank Annual Payment: {payment}$");
    }
    
    public void ShowMenu()
    {
        Console.WriteLine($"\n{Name} Main Menu");
        Console.WriteLine("-------------------------");
        Console.WriteLine("1. Amount of deposit accounts");
        Console.WriteLine("2. Get bank percentage");
        Console.WriteLine("3. Change bank percentage");
        Console.WriteLine("4. Add deposit account");
        Console.WriteLine("5. Delete deposit account");
        Console.WriteLine("6. Access specific deposit account");
        Console.WriteLine("7. Bank annual deposit payment");
        Console.WriteLine("8. Exit");
        Console.WriteLine("-------------------------\n");
    }
    
    public void SwitchCaseForMenu()
    {
        bool exitBool = false;
        while (exitBool == false)
        {
            ShowMenu();
            int choiceBankMenu = IO.ReadInteger("Input choice number: ");
            
            switch (choiceBankMenu)
            {
                case 1:
                    AmountOfDepositAccounts();
                    BanksManager.ToContinue();
                    break;
                case 2:
                    GetBankPercantage();
                    BanksManager.ToContinue();
                    break;
                case 3:
                    DepositType type = DepositAccounts[0].GetTypeOfAccount();
                    ChangeBankPercantage(type);
                    BanksManager.ToContinue();
                    break;
                case 4:
                    AddDepositAccount();
                    BanksManager.ToContinue();
                    break;
                case 5:
                    DeleteDepositAccount();
                    BanksManager.ToContinue();
                    break;
                case 6:
                    var account = AccessDepositAccount();
                    if (account == null)
                    {
                        BanksManager.ToContinue();
                        break;
                    }
                    BanksManager.ToContinue();
                    account.SwitchCaseForAccount();
                    break;
                case 7:
                    GetBankAnnualPayment();
                    BanksManager.ToContinue();
                    break;
                case 8:
                    Console.WriteLine("Exiting Bank Menu...\n");
                    exitBool = true;
                    break;
                default:
                    Console.WriteLine("Incorret input! Try again");
                    BanksManager.ToContinue();
                    continue;
            }
        }
    }
}