// task 8.1
Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
bool not = true;
Console.WriteLine("Чётные числа от 1 до " + n);
while (i <= n)
{
    if (i % 2 != 1)
    {
        Console.Write(i + ", ");
        not = false;
    }
    i++;
}
    if (not)
    {
        Console.WriteLine("Дружище, здесь НЕТ чётных чисел!");
    }