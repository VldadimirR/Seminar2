//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 456 -> 46 782 -> 72 918 -> 98
int number = new Random().Next(100, 999);

    int number1 = number / 100;
    int number2 = number1 * 10;
    int number3 = number % 10;
    
Console.Write(number);
Console.WriteLine();

Console.Write(number2 + number3);