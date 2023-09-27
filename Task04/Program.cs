// 7. Напишите программу, 
// 1. которая принимает на вход трёхзначное число и 
// 2. на выходе показывает последнюю цифру этого числа.
// 456 -> 6 
// 782 -> 2 
// 918 -> 8

Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    number *= -1;
}

if(number >= 100 && number <= 999)
{
    int lastNumber = number % 10;
    Console.WriteLine($"{number} -> {lastNumber}");
}
else 
{
    Console.WriteLine("Ошибка ввода!");
}