// Внутри класса Answer напишите метод CheckIfEven, который на вход принимает число number и выводит, является ли число чётным (делится ли оно на два без остатка).

// number = 4 -> Число 4 чётное

// number = 3 -> Число 3 нечётное

// number = 7 -> Число 7 нечётное
Console.WriteLine("Введите число: ");
int numTest = int.Parse(Console.ReadLine () ?? "");
// Проверим на четность (т.е деление на два без остатка)
if (numTest % 2 == 0 ) Console.WriteLine($"Число: {numTest} - Четное"); 
else Console.WriteLine($"Число: {numTest} - Нечетное");  
    