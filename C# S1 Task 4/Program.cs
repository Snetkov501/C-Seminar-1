// task 4
Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите 3-е число: ");
int x = Convert.ToInt32(Console.ReadLine()); 
int MAX = 0;
if (n >= m)
{
    if(n >= x)
    {
        MAX = n;
    }
}
else if (m >= x)
{
    MAX = m;
}
else  
{
    MAX = x;
}
Console.WriteLine($"Дружище, могу поспорить, что максимальное число {MAX} ");