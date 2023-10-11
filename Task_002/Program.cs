// Внутри класса Answer напишите метод FindMax, который принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите 3 числа и мы тебе скажем какое из них больше");
System.Console.WriteLine("Введите свое первое число");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
if (a >c){
System.Console.WriteLine("Максимальное число: " + a);
}
else{
    System.Console.WriteLine("Максимальное число: " + c);
}
}
else if (b > c){
    System.Console.WriteLine("Максимальное число: " + b);
}
else{
    System.Console.WriteLine("Максимальное число: " + c);
}

