// Внутри класса Answer напишите метод PrintEvenNumbers, которая на вход принимает число (number), а на выходе выводит все чётные числа от 1 до number (включительно), разделеные знаком табуляции.


// number = 5 -> 2    4

// number = 8 -> 2    4    6    8
Console.WriteLine("Введите число: ");
int numTest = int.Parse(Console.ReadLine () ?? "");
// Переберем все числа от 1 до числа numTest
int cur = 2;
Console.Write($"Четные числа от <1> до <{numTest}> :");  
while (cur < numTest)
{
    Console.Write($" {cur}");
    cur =cur +2;  
}    
Console.WriteLine("");