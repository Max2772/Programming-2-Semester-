Console.WriteLine("Программа для определения, являются ли все цифры трехзначного числа одинаковые");
Console.WriteLine("Выполнил студент группы 453502, Бибиков Максим Алексеевич, Вариант 15");

bool DefineAllNumbersEqual() { 
    Console.WriteLine("Введите трехзначное натуральное число");
    int a, tmp;
    a = Convert.ToInt32(Console.ReadLine());
    int lastNum = a % 10;
    tmp = lastNum;
    while (a > 0 && tmp == lastNum){
        tmp = a % 10;
        a /= 10;
    }

    if(a == 0)
        return true;
    else{
        return false;
    }
}


int exitNum = 1;
do {
    bool res = DefineAllNumbersEqual();
    if(res)
        Console.WriteLine("В введенном числе все цифры одинаковые");
    
    else{
        Console.WriteLine("В введенном числе цифры различны");
    }
    Console.WriteLine("Введите 1 для продолжения, 0 - для выхода из программы");
    exitNum = Convert.ToInt32(Console.ReadLine());
}
while(exitNum != 0);