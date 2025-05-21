namespace LR3_Task_3;

public class DateService
{
    public int Day, Month, Year;
    private DateTime _dateValue;
    
    public DateService(int day = 1, int month = 1, int year = 1)
    {
        Day = day;
        Month = month;
        Year = year;
        _dateValue = new DateTime(Year, Month, Day);
    }
     

    public bool ChangeDate(string? dateStr)
    {
        if (dateStr == null) return false;
        string[] dateParts = dateStr.Split('.');
        if (dateParts.Length != 3) return false;
        if (!int.TryParse(dateParts[0], out int posibleDay)) return false;
        if (!int.TryParse(dateParts[1], out int posibleMonth)) return false;
        if (!int.TryParse(dateParts[2], out int posibleYear)) return false;
        
        
        
        Day = posibleDay;
        Month = posibleMonth;
        Year = posibleYear;
        _dateValue = new DateTime(Year, Month, Day);
        return true;
    }

    public string GetDate()
    {
        return $"{Day}.{Month}.{Year}";
    }

    public string GetDateName()
    {
        string englishDay = _dateValue.DayOfWeek.ToString();
        Dictionary<string, string> toRus = new Dictionary<string,string>();
        toRus.Add("Monday", "Понедельник");
        toRus.Add("Tuesday", "Вторник");
        toRus.Add("Wednesday", "Среда");
        toRus.Add("Thursday", "Четверг");
        toRus.Add("Friday", "Пятница");
        toRus.Add("Saturday", "Суббота");
        toRus.Add("Sunday", "Воскресенье");
        return toRus[englishDay];
    }

    public int DaysFromNow()
    {
        return Math.Abs((_dateValue - DateTime.Now).Days);
    }

}