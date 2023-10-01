// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите количество чисел:\t");

int numbersCount = int.Parse(Console.ReadLine());

int[] numbers = new int[numbersCount];

for (int i = 0; i < numbers.Length; i++)
{
     Console.Write($"\nВведите число {i}:\t");
     numbers[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("      ");
Console.WriteLine("Вывод чисел на экран:");

for (int i = 0; i < numbers.Length; i++)
{
     Console.WriteLine(numbers[i]);
}
int max = numbers[0];

for (int i = 1; i < numbers.Length; i++)
{
    if(numbers[i] > max)
    {
        max = numbers [i];
    }
}
Console.WriteLine("      ");
Console.WriteLine("      ");
Console.Write("Максимальное число: ");
Console.WriteLine(max);

// Рустем, у меня есть вопросы:
// 1) какую команду можно использовать вместо Console.WriteLine("      "); 
// для перехода на новую строку?
// 2) Как избавиться от этого предупреждения: "(3,30): warning CS8604: Возможно, аргумент-ссылка, 
// допускающий значение NULL, для параметра "s" в "int int.Parse(string s)""
