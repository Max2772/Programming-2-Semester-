using LB6;

Console.WriteLine("Выполнил студент группы 453502, Бибиков Максим Алексеевич, Вариант 15/5");
Console.WriteLine("\n######################################## " +
                  "VEGETABLE PROGRAM " +
                  "########################################\n");

Carrot carrot = new Carrot("Carrot", 150, 20);
Potato potato = new Potato("Potato", 200, 5);
Broccoli broccoli = new Broccoli("Broccoli", 300, 5);

Console.WriteLine($"Carrot calories: {carrot.CalculateCalories():F2} kcal");
carrot.Cook();
carrot.Peel();
carrot.PrintInfo();

Console.WriteLine($"Potato calories: {potato.CalculateCalories():F2} kcal");
potato.Cook();
potato.Peel();
potato.PrintInfo();

Console.WriteLine($"Broccoli calories: {broccoli.CalculateCalories():F2} kcal");
broccoli.Cook();
broccoli.Peel();
((Vegetable)broccoli).Peel();
broccoli.PrintInfo();