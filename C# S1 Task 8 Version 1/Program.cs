// task 8.2
Console.Clear();
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
Console.WriteLine("Чётные числа от 1 до " + n);
while (i <= n)
{
    if (i % 2 == 0)
    {
        Console.Write(i+" ");
        i++;
    }
    else
    {
        i++; ;
    }
}
