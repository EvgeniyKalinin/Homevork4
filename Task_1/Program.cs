try
{
Console.WriteLine("Введите число.");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степерь");
int num2 = Convert.ToInt32(Console.ReadLine());
int Step(int num, int st)
{
    int save = num;
    for (int i = 1; i < st; i++)
    {
        save = save * num;
    }
    return save;
}
Console.WriteLine();
int res = Step(num1, num2);
Console.WriteLine($"Число {num1} в степени {num2} равно {res}.");
}
catch
{
    Console.WriteLine("Ошибка ввода! Введите целое число.");
}