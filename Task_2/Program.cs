try
{
Console.WriteLine("Введите число.");
int num = Convert.ToInt32(Console.ReadLine());
int CountNumber(int num)
{
    int save = num;
    int count = 0;
    while (num > 0)
    {
        int ost = num % 10;
        count = count + ost;
        num = num / 10;
    }
    return count;
}

int res = CountNumber(num);
Console.WriteLine($"Сумма цифр в числе {num} равна {res}.");
}
catch
{
    Console.WriteLine("Ошибка ввода! Введите целое число.");
}