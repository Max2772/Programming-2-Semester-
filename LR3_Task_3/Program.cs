
using LR3_Task_3;

ConsoleTools stream = new ConsoleTools();
while (true)
{
    stream.Print("\nМеню\n" +
                 "1 - День недели по дате\n" +
                 "2 - Кол-во дней до даты\n" +
                 "3 - Выход\n");
    int choice = stream.ReadInt("Введите выбор:");
    string? dateStr;
    DateService date = new DateService();
    
    switch (choice)
    {
        case 1:
            dateStr = stream.ReadStr("Введите дату:");
            date.ChangeDate(dateStr);
            stream.Print(date.GetDateName());
            break;
        case 2:
            dateStr = stream.ReadStr("Введите дату:");
            date.ChangeDate(dateStr);
            stream.Print((date.DaysFromNow()).ToString());
            break;
        default: return 0;
    }
}