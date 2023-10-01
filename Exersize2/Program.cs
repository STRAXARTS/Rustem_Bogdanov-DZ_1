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
