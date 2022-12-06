// task 2
Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine()); // ввод чисел
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine()); // ввод чисел
if (n > m)
{
    Console.WriteLine($" MAX-> {n} ");
    Console.WriteLine($" MIN-> {m} ");
}
else if(n < m)
{
    Console.WriteLine($" MAX-> {m} ");
    Console.WriteLine($" MIN-> {n} "); 
}
else
{
    Console.WriteLine($"Дружище, победила дружба!!! Введённые числа равны {n}={m}");
}