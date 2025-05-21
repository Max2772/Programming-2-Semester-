Console.WriteLine("Программа для определения,где находится точка в декартовой системе координат");
Console.WriteLine("Выполнил студент группы 453502, Бибиков Максим Алексеевич, Вариант 15");

void DefinePointLocation() {
    int x, y;
    Console.WriteLine("Введите координату x: ");
    x = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Введите координату y: ");
    
    y = Convert.ToInt32(Console.ReadLine());

    if (
        (x == 0 && y <= 0 && y <= -15) || (y == 0 && x <= 0 && x >= -15)
        || (x == -15 && y <= 0 && y >= -15) || (y == -15 && x <= 0 && x >= -15)
        ) {
        Console.WriteLine("На границе");
        return;
    }else if((x < 0 && x > -15) && (y < 0 && y > -15)){
        Console.WriteLine("Нет");
        return;
    }
    else{
        Console.WriteLine("Да");
        return;
    }   
    
    
    int counter = 0;

    switch (counter)
    {
        case 1:
        case 2: 
        case 3:  Console.WriteLine("1"); break;
        case 4: Console.WriteLine("4"); break;
    }
    
    
}

int exitNum;
do {
    DefinePointLocation();
    Console.WriteLine("Введите 1 для продолжения, 0 - для выхода из программы");
    exitNum = Convert.ToInt32(Console.ReadLine());
}while(exitNum != 0);