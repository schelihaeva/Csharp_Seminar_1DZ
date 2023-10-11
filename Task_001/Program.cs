// Задача2. Напишите программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньше
//  a = 5; b = 7 -> max = 7
//  a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3
//using System.Globalization;
// Мое решение
// Console.WriteLine("Введите 2 числа и мы тебе скажем какое из них больше");
// System.Console.WriteLine("Введите свое первое число");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе число:");
//int b = Convert.ToInt32(Console.ReadLine());
//
// if (a > b)
//{
    //System.Console.WriteLine("больше");
//}
//else if(a == b) {
 //   System.Console.WriteLine("равен");
//
//}
   // else{
      //  System.Console.WriteLine("меньше");
   // }
   // пример идельного решения
   //if (firstNumber == secondNumber)
  Console.WriteLine("Введите 2 числа и мы тебе скажем какое из них больше");
System.Console.WriteLine("Введите свое первое число");
int first_number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число:");
int second_number = Convert.ToInt32(Console.ReadLine());
        if (first_number == second_number){
                Console.WriteLine($"Введенные числа равны");
        }
        
        if (first_number > second_number)
        {
            Console.WriteLine($"Первое число `{first_number}` больше чем второе число `{second_number}`");
        }
        if (first_number < second_number)
        {
            Console.WriteLine($"Первое число `{first_number}` меньше чем второе число `{second_number}`");
        }
