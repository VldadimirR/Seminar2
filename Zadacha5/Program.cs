void CheckMultiple(int number1, int number2)
{
    if (number2 == number1 * number1)
    {
        Console.WriteLine("Да, является квадратом");
    }
    else
    {
        Console.WriteLine("Нет, не является квадратом");
    }

}
Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 < number2)
{
    CheckMultiple(number1, number2);
}
else
{
    CheckMultiple(number2, number1);
}