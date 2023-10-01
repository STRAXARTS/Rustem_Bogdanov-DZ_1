Console.Write("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());

int max = a;

if (max < b)
{
Console.WriteLine ("Второе число максимальное, а первое число минимальное");
}
else if (max == b)
{
Console.WriteLine ("Числа равны");
}
else
{
Console.WriteLine ("Первое число максимальное, а второе число минимальное"); 
}



    