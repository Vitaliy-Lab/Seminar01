// Напишите программу, 
// 1. которая на вход принимает два числа и 
// 2. проверяет, является ли первое число квадратом второго

// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3, b = 9 -> нет

int firstNumber, secondNumber;

Console.WriteLine("Введите первое число: ");
firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
  secondNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber == secondNumber * secondNumber)
{
    Console.WriteLine($"первое число = {firstNumber}, второе число = {secondNumber} -> да");
}
else
{
    Console.WriteLine($"первое число = {firstNumber}, второе число = {secondNumber} -> нет");
}