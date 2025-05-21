namespace LR3_Task_3;

public class ConsoleTools
{
    public string? ReadStr(string? text = null)
    {   
        if (text != null) Console.WriteLine(text);
        return Console.ReadLine();
    }
    
    public void Print(string text)
    {
        Console.WriteLine(text);
    }
    
    public int ReadInt(string? text = null)
    {
        int result;
        while (true)
        {
            if (text != null) Console.WriteLine(text);
            if (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Ошибка ввода!");
            }
            else break;
        }

        return result;
    }
}