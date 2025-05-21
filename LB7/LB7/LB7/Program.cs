using LB7;

Console.WriteLine("Выполнил студент группы 453502, Бибиков Максим Алексеевич, Вариант 15/5");
Console.WriteLine("\n######################################## " +
                  "POLYNOM PROGRAM " +
                  "########################################\n");

Polynom p1 = new Polynom(2, 3, -1);
Polynom p2 = new Polynom(1, -1, 2);
Polynom p3 = new Polynom(0, 0, 0);

Console.WriteLine($"p1 = {p1.ToString()}");
Console.WriteLine($"p2 = {p2.ToString()}");
Console.WriteLine($"p3 = {p3.ToString()}");

Console.WriteLine($"a from p1 via index: {p1[0]}");
Console.WriteLine($"a from p2 via index: {p2[0]}");
Console.WriteLine($"a from p3 via index: {p3[0]}");

Console.WriteLine($"p1 + p2 = {p1 + p2}");
Console.WriteLine($"p1 - p2 = {p1 - p2}");
Console.WriteLine($"p1 * 3 = {p1 * 3}");
Console.WriteLine($"p2 / 2 = {p2 / 2}");
Console.WriteLine($"p1 after ++ = {++p1}");
Console.WriteLine($"p1 after -- = {--p1}");
Console.WriteLine($"p1 == p2? {p1 == p2}");
Console.WriteLine($"p1 != p2? {p1 != p2}");

if (p1) Console.WriteLine("p1 has non-zero coefficients");
 
if (p3) 
    Console.WriteLine("p3 has non-zero coefficients");
else 
    Console.WriteLine("p3 has all zero coefficients");

int aValue = (int)p1;
Console.WriteLine($"a from p1 = {aValue}");
Polynom fromInt = (Polynom)5;
Console.WriteLine($"From 5 to polynomial = {fromInt}");