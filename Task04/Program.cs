// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите трёхзначное целое число");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 0)
{
    number *= -1;
}
if(number >= 100 && number <= 999)
{
    int result = number % 10;
    Console.WriteLine($"Последняя цифра числа: {result}");
}
else
{
    Console.WriteLine("Число не трёхзначное");
}

int result2 = number / 100; // первая цифра трёхзначного числа

int result3 = number / 10 % 10; // вторая цифра трёхзначного числа