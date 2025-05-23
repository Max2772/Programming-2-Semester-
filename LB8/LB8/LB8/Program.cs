using LB8;

Console.WriteLine("Выполнил студент группы 453502, Бибиков Максим Алексеевич, Вариант 15/5");
Console.WriteLine("\n######################################## " +
                  "BANK PROGRAM " +
                  "########################################\n");

Bank bank = new Bank();


bank.AddBonusClient("regular1", 100);
bank.AddNoBonusClient("premium1", 100);

bank.Show();

Console.WriteLine($"Общая сумма вкладов: {bank.CalculateTotalDeposits()}$");