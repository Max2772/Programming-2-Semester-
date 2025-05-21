namespace LB5;

public class DepositAccount
    {
        public Bank Bank { get; set; }
        public string FIO { get; }
        public double Balance { get; private set; }
        public DepositType depositType { get; private set; }
        public double Percentage { get; private set; }
        
        public void PercentageByType(DepositType type)
        {
            Percentage = Bank.depositTypePercentages[(int)type];
        }

        public DepositAccount(Bank bank, string fio, double balance, DepositType type)
        {
            Bank = bank;
            FIO = fio;
            Balance = balance;
            depositType = type;
            Percentage = Bank.depositTypePercentages[(int)type];
        }

        public void AccountInfo()
        {
            Console.WriteLine("Account Information:");
            Console.WriteLine($"FIO:{FIO}");
            Console.WriteLine($"Balance:{Balance}$");
            Console.WriteLine($"Percentage:{Percentage}%");
        }
        
        public void DoOperation(double amount)
        {
            Console.WriteLine("Choose your operation:");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            int input = 0;
            while(input != 1 && input != 2) input = IO.ReadInteger(null);
            PaymentType paymentType = (PaymentType)input-1;
            
            if (paymentType == PaymentType.Deposit)
            {
                if (Bank.MaxDepositAmount < amount)
                {
                    Console.WriteLine("Over max deposit amount! Operation aborted.");
                    return;
                }
                Balance += amount;
                Console.WriteLine($"{amount}$ added to your account");
                return;
            }

            if (amount > Balance)
            {
                Console.WriteLine($"Account balance less than {amount}$!");
                return;
            }
            
            Balance -= amount;
            Console.WriteLine($"{amount}$ withdrew from your account");
        }

        public void ChangePercentage(double percentage)
        {
            Percentage = percentage;
            Console.WriteLine($"New percentage: {Percentage}%");
        }
        
        public void ChangePercentageForBankManagement(double percentage)
        {
            Percentage = percentage;
        }
        
        public void ChangeType(DepositType type)
        {
            if (type == DepositType.Standard)
            {
                depositType = DepositType.Standard;
                PercentageByType(depositType);
            }else if (type == DepositType.Premium)
            {
                depositType = DepositType.Premium;
                PercentageByType(depositType);
            }else if (type == DepositType.Platinum)
            {
                depositType = DepositType.Platinum;
                PercentageByType(depositType);
            }
            Console.WriteLine($"{FIO} account is now of type {depositType}");
        }

        public void CalculateAmountWithPercentage()
        {
            double amount = Balance * ((Percentage / 100) + 1);
            Console.WriteLine($"Annual amount with {Percentage}%: {amount}$");
        }

        public DepositType GetTypeOfAccount()
        {
            Console.WriteLine("\nTypes of account: ");
            Console.WriteLine("1. Standard");
            Console.WriteLine("2. Premium");
            Console.WriteLine("3. Platinum");
            int choice = 0;
            while(choice != 1 && choice != 2 && choice != 3) choice  = IO.ReadInteger("Choose type: ");
            return ((DepositType)choice-1);
        }

        public void ShowMenu()
        {
            Console.WriteLine($"\n{FIO} Account");
            Console.WriteLine("-------------------------");
            Console.WriteLine("1. Account information");
            Console.WriteLine("2. Account operation");
            Console.WriteLine("3. Change account percentage");
            Console.WriteLine("4. Change account type");
            Console.WriteLine("5. Calculate percentage balance");
            Console.WriteLine("6. Exit");
            Console.WriteLine("-------------------------\n");
        }
        
        public void SwitchCaseForAccount()
        {
            bool exitBool = false;
            while (exitBool == false)
            {
                ShowMenu();
                int choiceAccount = IO.ReadInteger("Input choice number: ");
                switch (choiceAccount)
                {
                    case 1:
                        AccountInfo();
                        BanksManager.ToContinue();
                        break;
                    case 2:
                        double balance = 0; 
                        while(balance <= 0 ) balance = IO.ReadDouble("Enter balance: ");
                        DoOperation(balance);
                        BanksManager.ToContinue();
                        break;
                    case 3:
                        double percentage = IO.ReadDouble("Enter percentage: ");
                        ChangePercentage(percentage);
                        BanksManager.ToContinue();
                        break;
                    case 4:
                        DepositType type = GetTypeOfAccount();
                        ChangeType(type);
                        BanksManager.ToContinue();
                        break;
                    case 5:
                        CalculateAmountWithPercentage();
                        BanksManager.ToContinue();
                        break;
                    case 6:
                        Console.WriteLine("Exiting Account Menu...\n");
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
    
