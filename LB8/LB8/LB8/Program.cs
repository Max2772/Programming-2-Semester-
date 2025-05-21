using LB8;

Console.WriteLine("Выполнил студент группы 453502, Бибиков Максим Алексеевич, Вариант 15/5");
Console.WriteLine("\n######################################## " +
                  "BANK PROGRAM " +
                  "########################################\n");

Bank bank = new Bank();
IClient regular1 = new RegularClient("Иван Иванов", 1000m);
IClient premium1 = new PremiumClient("Пётр Петров", 2000m, 500m);
IClient regular2 = new RegularClient("Анна Сидорова", 1500m);
IClient premium2 = new PremiumClient("Мария Кузнецова", 3000m, 750m);
IClient regular3 = new RegularClient("Алексей Морозов", 800m);

bank.AddClient(regular1);
bank.AddClient(premium1);
bank.AddClient(regular2);
bank.AddClient(premium2);
bank.AddClient(regular3);

Console.WriteLine($"Вклад {regular1.Name}: {regular1.GetTotalDeposit()}$");
Console.WriteLine($"Вклад {premium1.Name}: {premium1.GetTotalDeposit()}$");
Console.WriteLine($"Вклад {regular2.Name}: {regular2.GetTotalDeposit()}$");
Console.WriteLine($"Вклад {premium2.Name}: {premium2.GetTotalDeposit()}$");
Console.WriteLine($"Вклад {regular3.Name}: {regular3.GetTotalDeposit()}$");

Console.WriteLine($"Общая сумма вкладов: {bank.CalculateTotalDeposits()}$");