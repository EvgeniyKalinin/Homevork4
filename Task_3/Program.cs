try
{
int[] mass = new int[8];
for (int i = 0; i < mass.Length; i++)
{
    Console.WriteLine($"Введите элемент массива под номером {i}.");
    mass[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
Console.Write("Введеный массив: ");
for (int j = 0; j < mass.Length; j++)
{
    Console.Write($"{mass[j]} ");
}
}
catch
{
    Console.WriteLine("Ошибка ввода! Введите целое число.");
}